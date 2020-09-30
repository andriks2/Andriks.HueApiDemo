namespace Andriks.HueApiDemo
{
    partial class TestFormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFormMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConnectBridge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeregisterApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawBitmaps = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHueInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAllOn = new System.Windows.Forms.Button();
            this.buttonAllOff = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBlink2 = new System.Windows.Forms.Button();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.menuMain.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOptions,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(821, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(93, 22);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnectBridge,
            this.menuDeregisterApp,
            this.menuSettings,
            this.menuDrawBitmaps});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(61, 20);
            this.menuOptions.Text = "&Options";
            // 
            // menuConnectBridge
            // 
            this.menuConnectBridge.Name = "menuConnectBridge";
            this.menuConnectBridge.Size = new System.Drawing.Size(156, 22);
            this.menuConnectBridge.Text = "&Connect bridge";
            this.menuConnectBridge.Click += new System.EventHandler(this.menuConnectBridge_Click);
            // 
            // menuDeregisterApp
            // 
            this.menuDeregisterApp.Name = "menuDeregisterApp";
            this.menuDeregisterApp.Size = new System.Drawing.Size(156, 22);
            this.menuDeregisterApp.Text = "&Deregister app";
            this.menuDeregisterApp.Click += new System.EventHandler(this.menuDeregisterApp_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(156, 22);
            this.menuSettings.Text = "&Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuDrawBitmaps
            // 
            this.menuDrawBitmaps.Name = "menuDrawBitmaps";
            this.menuDrawBitmaps.Size = new System.Drawing.Size(156, 22);
            this.menuDrawBitmaps.Text = "Draw bitmaps";
            this.menuDrawBitmaps.Click += new System.EventHandler(this.menuDrawBitmaps_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHueInfo,
            this.menuSep1,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHueInfo
            // 
            this.menuHueInfo.Name = "menuHueInfo";
            this.menuHueInfo.Size = new System.Drawing.Size(120, 22);
            this.menuHueInfo.Text = "Hue &Info";
            this.menuHueInfo.Click += new System.EventHandler(this.menuHueInfo_Click);
            // 
            // menuSep1
            // 
            this.menuSep1.Name = "menuSep1";
            this.menuSep1.Size = new System.Drawing.Size(117, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(120, 22);
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // buttonAllOn
            // 
            this.buttonAllOn.Enabled = false;
            this.buttonAllOn.Location = new System.Drawing.Point(10, 30);
            this.buttonAllOn.Name = "buttonAllOn";
            this.buttonAllOn.Size = new System.Drawing.Size(90, 26);
            this.buttonAllOn.TabIndex = 1;
            this.buttonAllOn.Text = "All lamps on";
            this.buttonAllOn.UseVisualStyleBackColor = true;
            this.buttonAllOn.Click += new System.EventHandler(this.buttonAllOn_Click);
            // 
            // buttonAllOff
            // 
            this.buttonAllOff.Enabled = false;
            this.buttonAllOff.Location = new System.Drawing.Point(117, 30);
            this.buttonAllOff.Name = "buttonAllOff";
            this.buttonAllOff.Size = new System.Drawing.Size(90, 26);
            this.buttonAllOff.TabIndex = 2;
            this.buttonAllOff.Text = "All lamps off";
            this.buttonAllOff.UseVisualStyleBackColor = true;
            this.buttonAllOff.Click += new System.EventHandler(this.buttonAllOff_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 324);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(821, 22);
            this.statusBar.TabIndex = 11;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(235, 17);
            this.statusLabel.Text = "First connect the bridge (Options/Connect)";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(10, 69);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(799, 239);
            this.flowLayoutPanel.TabIndex = 12;
            // 
            // buttonBlink2
            // 
            this.buttonBlink2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlink2.Enabled = false;
            this.buttonBlink2.Location = new System.Drawing.Point(692, 30);
            this.buttonBlink2.Name = "buttonBlink2";
            this.buttonBlink2.Size = new System.Drawing.Size(117, 26);
            this.buttonBlink2.TabIndex = 13;
            this.buttonBlink2.Text = "Blink light 2 on";
            this.buttonBlink2.UseVisualStyleBackColor = true;
            this.buttonBlink2.Click += new System.EventHandler(this.buttonBlink2_Click);
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownInterval.Location = new System.Drawing.Point(608, 35);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownInterval.TabIndex = 14;
            this.numericUpDownInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownInterval.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // blinkTimer
            // 
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            // 
            // TestFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 346);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.buttonBlink2);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.buttonAllOff);
            this.Controls.Add(this.buttonAllOn);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "TestFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q42 Hue Api";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.MenuStrip menuMain;
    private System.Windows.Forms.ToolStripMenuItem menuFile;
    private System.Windows.Forms.ToolStripMenuItem menuExit;
    private System.Windows.Forms.ToolStripMenuItem menuOptions;
    private System.Windows.Forms.ToolStripMenuItem menuHelp;
    private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuConnectBridge;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.Button buttonAllOn;
        private System.Windows.Forms.Button buttonAllOff;
        private System.Windows.Forms.ToolStripMenuItem menuHueInfo;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem menuDeregisterApp;
        private System.Windows.Forms.ToolStripMenuItem menuDrawBitmaps;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonBlink2;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Timer blinkTimer;
    }
}

