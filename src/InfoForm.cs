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
    /// A form to display information about the configuration of the Philips Hue system.
    /// </summary>
    public partial class InfoForm : Form
    {

        #region Private variables

        private ILocalHueClient client = null;
        private Dictionary<string, HueObject> groupByName;
        private List<HueObject> groupList;

        #endregion Private variables

        #region Constructor(s)

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="client"></param>
        public InfoForm(ILocalHueClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        #endregion Constructor(s)

        #region UI events

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonInfo_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = await getInfo();
        }

        private void buttonInfoZone_Click(object sender, EventArgs e)
        {
            HueObject info = (HueObject)comboBoxGroup.SelectedItem;
            StringBuilder sb = new StringBuilder();

            if (info.IsBridge)
            {
                sb.AppendLine(String.Format("Bridge {0} ({1})", info.ID, info.Name));
            }
            else if (info.IsLight)
            {
                sb.AppendLine(String.Format("Light {0} ({1})", info.ID, info.Name));
            }
            else
            {
                Group group = (Group)info.Value;
                sb.AppendLine(String.Format("Group {0} ({1}, {2})", info.ID, info.Name, group.Type));
                foreach (string id in info.LightIDs)
                    sb.AppendLine(String.Format("  Contains light : {0}", id));
            }
            sb.AppendLine();
            textBoxResults.Text = sb.ToString();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            getGroups();
        }


        private void menuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResults.SelectedText);
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            textBoxResults.SelectAll();
        }
        #endregion UI events

        #region Private methods

        private async void getGroups()
        {
            groupByName = new Dictionary<string, HueObject>();
            groupList = new List<HueObject>();
            comboBoxGroup.Items.Clear();
            var groups = await client.GetGroupsAsync();
            if (groups != null)
            {
                foreach (Group grp in groups)
                {
                    HueObject info = new HueObject(grp);
                    if (groupByName.ContainsKey(info.Name.ToLower()))
                        MessageBox.Show(String.Format("The name {0} appears multiple times." +
                                                "This might cause confusion when addressing items by their name.", info.Name.ToLower()),
                                        "Warning",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    else
                        groupByName.Add(info.Name.ToLower(), info);
                    groupList.Add(info);
                    comboBoxGroup.Items.Add(info);
                }
            }

            var lights = await client.GetLightsAsync();
            if (lights != null)
            {
                foreach (Light light in lights)
                {
                    HueObject info = new HueObject(light);
                    if (groupByName.ContainsKey(info.Name.ToLower()))
                        MessageBox.Show(String.Format("The name {0} appears multiple times." +
                                                "This might cause confusion when addressing items by their name.", info.Name.ToLower()),
                                        "Warning",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    else
                        groupByName.Add(info.Name.ToLower(), info);
                    groupList.Add(info);
                    comboBoxGroup.Items.Add(info);
                }
            }

            if (comboBoxGroup.Items.Count > 0)
            {
                buttonInfoZone.Enabled =
                comboBoxGroup.Enabled = true;
                comboBoxGroup.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Get (almost) complete info about bridge, groups and lights.
        /// </summary>
        /// <returns>Multiline string with info.</returns>
        private async Task<string> getInfo()
        {
            StringBuilder sb = new StringBuilder("Info:");
            sb.AppendLine();
            sb.AppendLine();
            Bridge bridge = await client.GetBridgeAsync();

            if (bridge != null)
            {
                sb.Append(Util.CreateBridgeInfo(bridge, 1));


                var groups = bridge.Groups;
                if (groups != null)
                {
                    foreach (Group group in groups)
                    {
                        sb.Append(Util.CreateGroupInfo(group, 1));
                    }
                }

                var lights = bridge.Lights;
                if (lights != null)
                {
                    foreach (Light light in lights)
                    {
                        sb.Append(Util.CreateLightInfo(light, 1));
                    }
                }
            }
            return sb.ToString();
        }

        #endregion Private methods
    }
}
