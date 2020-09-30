using System;
using System.Windows.Forms;

namespace Andriks.HueApiDemo
{
    public partial class SettingsForm : Form
    {
        #region Private fields
        #endregion Private fields

        #region Constructor(s)
        public SettingsForm()
        {
            InitializeComponent();
            propertyGrid.SelectedObject = Properties.Settings.Default;
        }

        #endregion Constructor(s)

        #region Private UI events

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        #endregion Private UI events

    }
}
