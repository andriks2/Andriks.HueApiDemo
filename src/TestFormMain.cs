using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Groups;

namespace Andriks.HueApiDemo
{
    /// <summary>
    /// The main form for the demonstration.
    /// </summary>
    public partial class TestFormMain : Form
    {
        #region Private variables

        // The connection to the Hue bridge we use throughout this demonstration.
        private ILocalHueClient client = null;
        LightCommand blinkCmd = new LightCommand();


        #endregion Private variables

        #region Constructor(s)

        /// <summary>
        /// Create the main demo form.
        /// </summary>
        public TestFormMain()
        {
            InitializeComponent();
            blinkCmd.On = true;
            blinkCmd.Brightness = 254;
            blinkCmd.TransitionTime = new TimeSpan(0);
        }

        #endregion Constructor(s)

        #region UI events

        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            if ((bool)blinkCmd.On)
                blinkCmd.TurnOff();
            else
                blinkCmd.TurnOn();
            client.SendCommandAsync(blinkCmd, new List<string> { "2" });
        }

        private void buttonAllOn_Click(object sender, EventArgs e)
        {
            allLightsOn();
        }

        private void buttonAllOff_Click(object sender, EventArgs e)
        {
            allLightsOff();
        }

        private void buttonBlink2_Click(object sender, EventArgs e)
        {
            if (blinkTimer.Enabled)
            {
                blinkTimer.Stop();
                buttonBlink2.Text = "Blink light 2 on";
            }
            else
            {
                blinkTimer.Interval = (int)numericUpDownInterval.Value;
                buttonBlink2.Text = "Blink light 2 off";
                blinkTimer.Start();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            Form f = new AboutForm();
            f.ShowDialog(this);
            statusLabel.Text = "";
        }

        private async void menuConnectBridge_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Connecting...";
            ConnectBridgeForm f = new ConnectBridgeForm(client);
            f.ShowDialog(this);
            client = f.Client;
            if (client != null)
            {
                setClient(true);
                statusLabel.Text = "Bridge connected";
            }
            else
            {
                setClient(false);
                statusLabel.Text = "Error: no connection";
            }
        }

        private void menuDeregisterApp_Click(object sender, EventArgs e)
        {
            DelKeyForm dkf = new DelKeyForm();
            dkf.ShowDialog();
        }

        private void menuDrawBitmaps_Click(object sender, EventArgs e)
        {
            Util.PaintBrightness();
            Util.PaintCT();
            Util.PaintHue();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuHueInfo_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            if (client != null)
            {
                InfoForm f = new InfoForm(client);
                f.Show(this);
            }
            else
                MessageBox.Show("No client. First connect a bridge.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            statusLabel.Text = "";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                statusLabel.Text = "Settings changed";
            }
        }


        #endregion UI events

        #region Private methods

        private async void allLightsOff()
        {
            var command = new LightCommand();
            command.On = false;
            Task<HueResults> task = client.SendCommandAsync(command);
            HueResults results = await task;
            statusLabel.Text = gatherResults(results);
            foreach (System.Windows.Forms.Control control in flowLayoutPanel.Controls)
            {
                LightControl lc = (LightControl)control;
                lc.Resync();
            }
        }

        private async void allLightsOn()
        {
            var command = new LightCommand();
            command.On = true;
            command.Brightness = 254; // to avoid switching on and still see nothing
            HueResults results = await client.SendCommandAsync(command);
            statusLabel.Text = gatherResults(results);
            foreach (System.Windows.Forms.Control control in flowLayoutPanel.Controls)
            {
                LightControl lc = (LightControl)control;
                lc.Resync();
            }
        }


        private string gatherResults(HueResults results)
        {
            StringBuilder sb = new StringBuilder("Results:");
            foreach (var res in results)
            {
                if (res.Error != null) sb.Append(String.Format("Error: {0} at {1} : {2}  ",
                                                                res.Error.Type,
                                                                res.Error.Address,
                                                                res.Error.Description));
                if (res.Success != null) sb.Append(String.Format("Success: {0}  ",
                                                                res.Success.Id));
            }
            return sb.ToString();
        }

        private async void setClient(bool value)
        {
            buttonAllOff.Enabled = buttonAllOn.Enabled = buttonBlink2.Enabled = value;

            flowLayoutPanel.SuspendLayout();
            flowLayoutPanel.Controls.Clear();

            if (value)
            {

                var lights = await client.GetLightsAsync();
                if (lights != null)
                {
                    foreach (Light light in lights)
                    {
                        LightControl ctrl = new LightControl();
                        ctrl.Light = light;
                        ctrl.Client = client;
                        flowLayoutPanel.Controls.Add(ctrl);
                    }
                }
            }
            flowLayoutPanel.ResumeLayout();
        }

        #endregion Private methods
    }
}
