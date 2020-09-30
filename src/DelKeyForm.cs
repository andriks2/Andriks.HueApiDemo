using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Andriks.HueApiDemo
{
    public partial class DelKeyForm : Form
    {
        public DelKeyForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
