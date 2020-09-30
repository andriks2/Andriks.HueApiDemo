using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Andriks.HueApiDemo
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelQ42_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabelQ42.Text);
        }

        private void linkLabelHueDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabelHueDev.Text);
        }

        private void linkLabelFamfamfam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabelFamfamfam.Text);
        }
    }
}
