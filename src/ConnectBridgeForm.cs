using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;

namespace Andriks.HueApiDemo
{
    /// <summary>
    /// A form to connect a Philips Hue bridge to this application.
    /// In a real-live app this could be wrapped up into something simpler.
    /// <seealso cref="https://developers.meethue.com/develop/hue-entertainment/hue-edk-connection-flow/"/>
    /// </summary>
    public partial class ConnectBridgeForm : Form
    {
        #region Private variables

        private string appKey = null;
        private ILocalHueClient client = null;
        private List<LocatedBridge> locBridges = null;
        string computerName = null;

        #endregion Private variables

        #region Constructor(s)

        /// <summary>
        /// Create an instance of this form.
        /// </summary>
        /// <param name="theClient">A possibly already connected client.</param>
        public ConnectBridgeForm(ILocalHueClient theClient)
        {
            saveAppKey("WHAw6x-9xkHFYp1uacmmcatlFdBuc3xtzztQUClJ");
            InitializeComponent();
            appKey = getAppKey();
            client = theClient;
            computerName = Environment.MachineName;
            labelStartSearch.Text = String.Format(
                  "Press the button to start locating bridge(s). This may take up to {0} seconds....",
                  Properties.Settings.Default.SearchTimeout);
            labelPressButton.Text = String.Format(
                  "If you have not already done so in a previous run, " +
                  " press the LinkButton on the selected Philips Hue bridge and then" +
                  " (within 30 seconds) click on 'Register'.\n\n" +
                  "This will add a user 'Q42#{0}' to your bridge.", computerName);
            this.Refresh();
        }

        #endregion Constructor(s)

        #region Public fields

        /*/ <summary>
        /// A list of the located bridges.
        /// </summary>
        public List<LocatedBridge> BridgesFound
        {
            get { return locBridges; }
        }*/


        /// <summary>
        /// A connection client.
        /// </summary>
        public ILocalHueClient Client
        {
            get { return client; }
        }

        #endregion Public fields

        #region UI events

        /// <summary>
        /// When the OK button is pressed, try to connect a bridge. If there is a checked
        /// item in the listbox, use that. Otherwise use the first item.
        /// </summary>
        private async void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                LocatedBridge bridge = null;

                if (checkedListBoxBridges.CheckedItems.Count > 0)
                    bridge = checkedListBoxBridges.CheckedItems[0] as LocatedBridge;
                else if (checkedListBoxBridges.Items.Count > 0)
                    bridge = checkedListBoxBridges.Items[0] as LocatedBridge;

                if (bridge != null)
                {
                    client = new LocalHueClient(bridge.IpAddress);
                    client.Initialize(appKey);
                    if (!await client.CheckConnection())
                    {
                        MessageBox.Show("Could not connect client. This might be caused by an invalid application key.\n\n" +
                                            "Other parts of the application will not work.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        client = null;
                    }
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show("No client connected. Other parts of the application will not work. Continue?",
                                        "Warning",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning) == DialogResult.Yes)
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Something went wrong while connecting. The error was '{0}'.",
                                              ex.Message),
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// If the app key is already know to the bridge, only initialize the client.
        /// Otherwise register the client and initialize.
        /// </summary>
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            foreach (var b in checkedListBoxBridges.CheckedItems)
            {
                LocatedBridge bridge = (LocatedBridge)b;
                // Check if already registered:
                bool ok = await Util.ClientAlreadyRegistered(bridge, appKey);

                ILocalHueClient client = new LocalHueClient(bridge.IpAddress);
                if (ok)
                    client.Initialize(appKey);
                else
                {
                    string computerName = System.Environment.MachineName;
                    // Make sure the user has pressed the button on the bridge before calling RegisterAsync
                    // It will throw an LinkButtonNotPressedException if the user did not press the button
                    appKey = await client.RegisterAsync("Q42", computerName);
                    client.Initialize(appKey);
                    saveAppKey(appKey);
                }
            }
        }


        /// <summary>
        /// Find the Philips Hue bridge(s) in the local network.
        /// </summary>
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            int idx;

            progressBar.Value = 0;
            progressBar.Maximum = Properties.Settings.Default.SearchTimeout;
            progressBar.Visible = labelBridgeFound.Visible = true;
            timerSearch.Enabled = true;
            buttonSearch.Enabled = false;
            buttonRegister.Enabled = false;

            try
            {
                TimeSpan duration = await searchBridge();
                if (duration.TotalSeconds > 0)
                {
                    progressBar.Visible = false;
                    if ((locBridges == null) || (locBridges.Count < 1))
                    {
                        labelBridgeFound.Text = "Error: no bridges found within the timeout period, consider increasing time out value in Settings.";
                    }
                    else
                    {
                        checkedListBoxBridges.Visible = true;
                        if (locBridges.Count == 1)
                        {
                            labelBridgeFound.Text =
                                String.Format("Found one bridge in {0:0.0} seconds.",
                                              duration.TotalSeconds);
                        }
                        else
                        {
                            labelBridgeFound.Text =
                                String.Format("Found {1} bridges in {0:0.0} seconds.",
                                              duration.TotalSeconds, locBridges.Count);
                        }
                        checkedListBoxBridges.Items.Clear();
                        foreach (LocatedBridge bridge in locBridges)
                        {
                            if (await Util.ClientAlreadyRegistered(bridge, appKey))
                            {
                                idx = checkedListBoxBridges.Items.Add(bridge);
                                checkedListBoxBridges.SetItemChecked(idx, true);
                                buttonRegister.Enabled = true;
                            }
                            else
                            {
                                idx = checkedListBoxBridges.Items.Add(bridge);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                labelBridgeFound.Text = String.Format("Something went wrong: {0}", ex.Message);
            }
            finally
            {
                progressBar.Visible = false;
                timerSearch.Enabled = false;
                buttonSearch.Enabled = true;
            }
        }


        /// <summary>
        /// If an item is checked, clear the checks on all others so only one at a time can be selected.
        /// </summary>
        private void checkedListBoxBridges_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // uncheck all others
                for (int j = 0; j < checkedListBoxBridges.Items.Count; j++)
                    checkedListBoxBridges.SetItemCheckState(j, CheckState.Unchecked);
            }
        }


        /// <summary>
        /// If there is a checked item enable the 'Register' button.
        /// </summary>
        private void checkedListBoxBridges_SelectedValueChanged(object sender, EventArgs e)
        {
            buttonRegister.Enabled = (checkedListBoxBridges.CheckedItems.Count > 0);
        }


        /// <summary>
        /// Increase progressbar each time the event fires (every second).
        /// </summary>
        private void timerSearch_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
                progressBar.Value++;
        }

        #endregion UI events

        #region Private methods

        /// <summary>
        /// Get the appKey for access to the bridge.
        /// </summary>
        /// <returns>Decrypted appKey</returns>
        private string getAppKey()
        {
            // Can be written compacter, but for debugging this is okay.
            string input = Properties.Settings.Default.AppKey;
            string output = Util.DecryptString(input);
            return output;
        }

        /// <summary>
        /// Store an encrypted version of the appKey for subsequent use by the application.
        /// </summary>
        /// <param name="appKeyToSave">Application key</param>
        private void saveAppKey(string appKeyToSave)
        {
            string encrypted = Util.EncryptString(appKeyToSave);
            Properties.Settings.Default.AppKey = encrypted;
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// Asynchronously search for a bridge using the HttpLocator.
        /// </summary>
        /// <returns>The time it took to find the bridge(s).</returns>
        private async Task<TimeSpan> searchBridge()
        {

            DateTime startTime = DateTime.Now;
            IBridgeLocator locator = new HttpBridgeLocator(); //Or: LocalNetworkScanBridgeLocator, MdnsBridgeLocator, MUdpBasedBridgeLocator
            locBridges = (List<LocatedBridge>)await locator.LocateBridgesAsync(
                TimeSpan.FromSeconds(Properties.Settings.Default.SearchTimeout));
            return DateTime.Now.Subtract(startTime);
        }

        #endregion Private methods
    }
}
