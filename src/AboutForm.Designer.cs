namespace Andriks.HueApiDemo
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelQ42 = new System.Windows.Forms.Label();
            this.labelCopyrightQ42 = new System.Windows.Forms.Label();
            this.labelPhilipsHue = new System.Windows.Forms.Label();
            this.labelCopyrightIcons = new System.Windows.Forms.Label();
            this.textBoxExplain = new System.Windows.Forms.TextBox();
            this.linkLabelQ42 = new System.Windows.Forms.LinkLabel();
            this.linkLabelHueDev = new System.Windows.Forms.LinkLabel();
            this.linkLabelFamfamfam = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(377, 232);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(73, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelQ42
            // 
            this.labelQ42.AutoSize = true;
            this.labelQ42.Location = new System.Drawing.Point(12, 121);
            this.labelQ42.Name = "labelQ42";
            this.labelQ42.Size = new System.Drawing.Size(33, 13);
            this.labelQ42.TabIndex = 2;
            this.labelQ42.Text = "Q42 :";
            // 
            // labelCopyrightQ42
            // 
            this.labelCopyrightQ42.AutoSize = true;
            this.labelCopyrightQ42.Location = new System.Drawing.Point(12, 179);
            this.labelCopyrightQ42.Name = "labelCopyrightQ42";
            this.labelCopyrightQ42.Size = new System.Drawing.Size(184, 13);
            this.labelCopyrightQ42.TabIndex = 3;
            this.labelCopyrightQ42.Text = "Copyright © 2020 andriks / Q42 team";
            // 
            // labelPhilipsHue
            // 
            this.labelPhilipsHue.AutoSize = true;
            this.labelPhilipsHue.Location = new System.Drawing.Point(12, 144);
            this.labelPhilipsHue.Name = "labelPhilipsHue";
            this.labelPhilipsHue.Size = new System.Drawing.Size(66, 13);
            this.labelPhilipsHue.TabIndex = 4;
            this.labelPhilipsHue.Text = "Philips Hue :";
            // 
            // labelCopyrightIcons
            // 
            this.labelCopyrightIcons.AutoSize = true;
            this.labelCopyrightIcons.Location = new System.Drawing.Point(12, 206);
            this.labelCopyrightIcons.Name = "labelCopyrightIcons";
            this.labelCopyrightIcons.Size = new System.Drawing.Size(98, 13);
            this.labelCopyrightIcons.TabIndex = 6;
            this.labelCopyrightIcons.Text = "Icons: Copyright © ";
            // 
            // textBoxExplain
            // 
            this.textBoxExplain.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExplain.Location = new System.Drawing.Point(13, 16);
            this.textBoxExplain.Multiline = true;
            this.textBoxExplain.Name = "textBoxExplain";
            this.textBoxExplain.ReadOnly = true;
            this.textBoxExplain.Size = new System.Drawing.Size(436, 90);
            this.textBoxExplain.TabIndex = 7;
            this.textBoxExplain.Text = "Windows Forms sample application for the Q42.HueApi library. \r\n\r\nThe Q42.HueApi l" +
    "ibrary provides a C# interface to the Philips Hue™ smart home automation system." +
    "\r\n\r\nFor more information:";
            // 
            // linkLabelQ42
            // 
            this.linkLabelQ42.AutoSize = true;
            this.linkLabelQ42.Location = new System.Drawing.Point(116, 121);
            this.linkLabelQ42.Name = "linkLabelQ42";
            this.linkLabelQ42.Size = new System.Drawing.Size(219, 13);
            this.linkLabelQ42.TabIndex = 8;
            this.linkLabelQ42.TabStop = true;
            this.linkLabelQ42.Text = "https://github.com/Q42/Q42.HueApi#bridge";
            this.linkLabelQ42.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQ42_LinkClicked);
            // 
            // linkLabelHueDev
            // 
            this.linkLabelHueDev.AutoSize = true;
            this.linkLabelHueDev.Location = new System.Drawing.Point(116, 144);
            this.linkLabelHueDev.Name = "linkLabelHueDev";
            this.linkLabelHueDev.Size = new System.Drawing.Size(210, 13);
            this.linkLabelHueDev.TabIndex = 9;
            this.linkLabelHueDev.TabStop = true;
            this.linkLabelHueDev.Text = "https://developers.meethue.com/develop/";
            this.linkLabelHueDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHueDev_LinkClicked);
            // 
            // linkLabelFamfamfam
            // 
            this.linkLabelFamfamfam.AutoSize = true;
            this.linkLabelFamfamfam.Location = new System.Drawing.Point(116, 206);
            this.linkLabelFamfamfam.Name = "linkLabelFamfamfam";
            this.linkLabelFamfamfam.Size = new System.Drawing.Size(117, 13);
            this.linkLabelFamfamfam.TabIndex = 10;
            this.linkLabelFamfamfam.TabStop = true;
            this.linkLabelFamfamfam.Text = "http://famfamfam.com/";
            this.linkLabelFamfamfam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFamfamfam_LinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 267);
            this.Controls.Add(this.linkLabelFamfamfam);
            this.Controls.Add(this.linkLabelHueDev);
            this.Controls.Add(this.linkLabelQ42);
            this.Controls.Add(this.textBoxExplain);
            this.Controls.Add(this.labelCopyrightIcons);
            this.Controls.Add(this.labelPhilipsHue);
            this.Controls.Add(this.labelCopyrightQ42);
            this.Controls.Add(this.labelQ42);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About WinForm Sample";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelQ42;
        private System.Windows.Forms.Label labelCopyrightQ42;
        private System.Windows.Forms.Label labelPhilipsHue;
        private System.Windows.Forms.Label labelCopyrightIcons;
        private System.Windows.Forms.TextBox textBoxExplain;
        private System.Windows.Forms.LinkLabel linkLabelQ42;
        private System.Windows.Forms.LinkLabel linkLabelHueDev;
        private System.Windows.Forms.LinkLabel linkLabelFamfamfam;
    }
}