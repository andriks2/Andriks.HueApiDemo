namespace Andriks.HueApiDemo
{
    partial class LightControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.labelB0 = new System.Windows.Forms.Label();
            this.labelB254 = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.labelCTCool = new System.Windows.Forms.Label();
            this.labelCTWarm = new System.Windows.Forms.Label();
            this.labelColTemp = new System.Windows.Forms.Label();
            this.labelHue = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelBrightness = new System.Windows.Forms.Panel();
            this.panelPicB = new System.Windows.Forms.Panel();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.panelColTemp = new System.Windows.Forms.Panel();
            this.panelPicC = new System.Windows.Forms.Panel();
            this.trackBarColTemp = new System.Windows.Forms.TrackBar();
            this.panelHue = new System.Windows.Forms.Panel();
            this.panelPicH = new System.Windows.Forms.Panel();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.panelBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.panelColTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColTemp)).BeginInit();
            this.panelHue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.Location = new System.Drawing.Point(257, 4);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(40, 17);
            this.checkBoxOn.TabIndex = 1;
            this.checkBoxOn.Text = "On";
            this.checkBoxOn.UseVisualStyleBackColor = true;
            this.checkBoxOn.CheckedChanged += new System.EventHandler(this.checkBoxOn_CheckedChanged);
            // 
            // labelB0
            // 
            this.labelB0.AutoSize = true;
            this.labelB0.Location = new System.Drawing.Point(5, 35);
            this.labelB0.Name = "labelB0";
            this.labelB0.Size = new System.Drawing.Size(13, 13);
            this.labelB0.TabIndex = 3;
            this.labelB0.Text = "0";
            this.labelB0.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelB254
            // 
            this.labelB254.AutoSize = true;
            this.labelB254.Location = new System.Drawing.Point(262, 35);
            this.labelB254.Name = "labelB254";
            this.labelB254.Size = new System.Drawing.Size(25, 13);
            this.labelB254.TabIndex = 2;
            this.labelB254.Text = "254";
            this.labelB254.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.BackColor = System.Drawing.Color.Transparent;
            this.labelBrightness.Location = new System.Drawing.Point(115, 35);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(56, 13);
            this.labelBrightness.TabIndex = 0;
            this.labelBrightness.Text = "Brightness";
            this.labelBrightness.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelCTCool
            // 
            this.labelCTCool.AutoSize = true;
            this.labelCTCool.Location = new System.Drawing.Point(5, 34);
            this.labelCTCool.Name = "labelCTCool";
            this.labelCTCool.Size = new System.Drawing.Size(28, 13);
            this.labelCTCool.TabIndex = 5;
            this.labelCTCool.Text = "Cool";
            this.labelCTCool.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCTWarm
            // 
            this.labelCTWarm.AutoSize = true;
            this.labelCTWarm.Location = new System.Drawing.Point(252, 35);
            this.labelCTWarm.Name = "labelCTWarm";
            this.labelCTWarm.Size = new System.Drawing.Size(35, 13);
            this.labelCTWarm.TabIndex = 4;
            this.labelCTWarm.Text = "Warm";
            this.labelCTWarm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelColTemp
            // 
            this.labelColTemp.AutoSize = true;
            this.labelColTemp.Location = new System.Drawing.Point(99, 34);
            this.labelColTemp.Name = "labelColTemp";
            this.labelColTemp.Size = new System.Drawing.Size(96, 13);
            this.labelColTemp.TabIndex = 3;
            this.labelColTemp.Text = "Colour temperature";
            this.labelColTemp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(130, 34);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(27, 13);
            this.labelHue.TabIndex = 4;
            this.labelHue.Text = "Hue";
            this.labelHue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfo.Location = new System.Drawing.Point(5, 5);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(185, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Light 1 (woonkamer, room, livingroom)";
            // 
            // panelBrightness
            // 
            this.panelBrightness.BackColor = System.Drawing.SystemColors.Control;
            this.panelBrightness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBrightness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrightness.Controls.Add(this.labelB0);
            this.panelBrightness.Controls.Add(this.labelB254);
            this.panelBrightness.Controls.Add(this.labelBrightness);
            this.panelBrightness.Controls.Add(this.panelPicB);
            this.panelBrightness.Controls.Add(this.trackBarBrightness);
            this.panelBrightness.Location = new System.Drawing.Point(5, 30);
            this.panelBrightness.Name = "panelBrightness";
            this.panelBrightness.Size = new System.Drawing.Size(290, 50);
            this.panelBrightness.TabIndex = 2;
            // 
            // panelPicB
            // 
            this.panelPicB.BackgroundImage = global::Andriks.HueApiDemo.Properties.Resources.brightness;
            this.panelPicB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicB.Location = new System.Drawing.Point(12, 28);
            this.panelPicB.Name = "panelPicB";
            this.panelPicB.Size = new System.Drawing.Size(265, 16);
            this.panelPicB.TabIndex = 4;
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarBrightness.LargeChange = 32;
            this.trackBarBrightness.Location = new System.Drawing.Point(-2, 0);
            this.trackBarBrightness.Maximum = 254;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(292, 45);
            this.trackBarBrightness.SmallChange = 16;
            this.trackBarBrightness.TabIndex = 1;
            this.trackBarBrightness.TickFrequency = 32;
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            // 
            // panelColTemp
            // 
            this.panelColTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColTemp.Controls.Add(this.labelCTCool);
            this.panelColTemp.Controls.Add(this.labelCTWarm);
            this.panelColTemp.Controls.Add(this.labelColTemp);
            this.panelColTemp.Controls.Add(this.panelPicC);
            this.panelColTemp.Controls.Add(this.trackBarColTemp);
            this.panelColTemp.Location = new System.Drawing.Point(5, 85);
            this.panelColTemp.Name = "panelColTemp";
            this.panelColTemp.Size = new System.Drawing.Size(290, 50);
            this.panelColTemp.TabIndex = 3;
            // 
            // panelPicC
            // 
            this.panelPicC.BackgroundImage = global::Andriks.HueApiDemo.Properties.Resources.ct;
            this.panelPicC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicC.Location = new System.Drawing.Point(12, 28);
            this.panelPicC.Name = "panelPicC";
            this.panelPicC.Size = new System.Drawing.Size(265, 16);
            this.panelPicC.TabIndex = 4;
            // 
            // trackBarColTemp
            // 
            this.trackBarColTemp.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarColTemp.LargeChange = 32;
            this.trackBarColTemp.Location = new System.Drawing.Point(-2, 0);
            this.trackBarColTemp.Maximum = 254;
            this.trackBarColTemp.Name = "trackBarColTemp";
            this.trackBarColTemp.Size = new System.Drawing.Size(292, 45);
            this.trackBarColTemp.SmallChange = 16;
            this.trackBarColTemp.TabIndex = 2;
            this.trackBarColTemp.TickFrequency = 32;
            this.trackBarColTemp.ValueChanged += new System.EventHandler(this.trackBarColTemp_ValueChanged);
            // 
            // panelHue
            // 
            this.panelHue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHue.Controls.Add(this.labelHue);
            this.panelHue.Controls.Add(this.panelPicH);
            this.panelHue.Controls.Add(this.trackBarHue);
            this.panelHue.Enabled = false;
            this.panelHue.Location = new System.Drawing.Point(5, 140);
            this.panelHue.Name = "panelHue";
            this.panelHue.Size = new System.Drawing.Size(290, 50);
            this.panelHue.TabIndex = 4;
            // 
            // panelPicH
            // 
            this.panelPicH.BackgroundImage = global::Andriks.HueApiDemo.Properties.Resources.hue;
            this.panelPicH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicH.Location = new System.Drawing.Point(12, 28);
            this.panelPicH.Name = "panelPicH";
            this.panelPicH.Size = new System.Drawing.Size(265, 16);
            this.panelPicH.TabIndex = 4;
            // 
            // trackBarHue
            // 
            this.trackBarHue.Enabled = false;
            this.trackBarHue.Location = new System.Drawing.Point(-2, 0);
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(292, 45);
            this.trackBarHue.TabIndex = 0;
            this.trackBarHue.ValueChanged += new System.EventHandler(this.trackBarHue_ValueChanged);
            // 
            // LightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panelHue);
            this.Controls.Add(this.panelColTemp);
            this.Controls.Add(this.panelBrightness);
            this.Controls.Add(this.checkBoxOn);
            this.Controls.Add(this.labelInfo);
            this.Name = "LightControl";
            this.Size = new System.Drawing.Size(300, 200);
            this.panelBrightness.ResumeLayout(false);
            this.panelBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.panelColTemp.ResumeLayout(false);
            this.panelColTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColTemp)).EndInit();
            this.panelHue.ResumeLayout(false);
            this.panelHue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.Label labelB0;
        private System.Windows.Forms.Label labelB254;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Label labelCTCool;
        private System.Windows.Forms.Label labelCTWarm;
        private System.Windows.Forms.Label labelColTemp;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelBrightness;
        private System.Windows.Forms.Panel panelColTemp;
        private System.Windows.Forms.Panel panelHue;
        private System.Windows.Forms.Panel panelPicB;
        private System.Windows.Forms.Panel panelPicC;
        private System.Windows.Forms.Panel panelPicH;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarColTemp;
        private System.Windows.Forms.TrackBar trackBarHue;
    }
}