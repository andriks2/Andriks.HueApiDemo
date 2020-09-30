namespace Andriks.HueApiDemo
{
    partial class ConnectBridgeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectBridgeForm));
            this.labelPressButton = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelBridgeFound = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelStartSearch = new System.Windows.Forms.Label();
            this.checkedListBoxBridges = new System.Windows.Forms.CheckedListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerSearch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelPressButton
            // 
            this.labelPressButton.Location = new System.Drawing.Point(15, 174);
            this.labelPressButton.Name = "labelPressButton";
            this.labelPressButton.Size = new System.Drawing.Size(455, 60);
            this.labelPressButton.TabIndex = 6;
            this.labelPressButton.Text = "If you have not already done so in a previous run, press the LinkButton on the se" +
    "lected Philips Hue bridge and then click on \'Register\'. \r\n\r\nThis will add  a use" +
    "r \'Q42\' to your bridge.";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Enabled = false;
            this.buttonRegister.Location = new System.Drawing.Point(189, 237);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(79, 25);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "&Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(391, 260);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(79, 25);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelBridgeFound
            // 
            this.labelBridgeFound.Location = new System.Drawing.Point(12, 74);
            this.labelBridgeFound.Name = "labelBridgeFound";
            this.labelBridgeFound.Size = new System.Drawing.Size(455, 40);
            this.labelBridgeFound.TabIndex = 3;
            this.labelBridgeFound.Text = "Locating bridges....";
            this.labelBridgeFound.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(189, 35);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(79, 25);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "&Find";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelStartSearch
            // 
            this.labelStartSearch.Location = new System.Drawing.Point(12, 9);
            this.labelStartSearch.Name = "labelStartSearch";
            this.labelStartSearch.Size = new System.Drawing.Size(444, 23);
            this.labelStartSearch.TabIndex = 1;
            this.labelStartSearch.Text = "Press the button to start locating bridge(s). This may take up to {0} seconds...." +
    "";
            // 
            // checkedListBoxBridges
            // 
            this.checkedListBoxBridges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxBridges.FormattingEnabled = true;
            this.checkedListBoxBridges.Location = new System.Drawing.Point(12, 96);
            this.checkedListBoxBridges.Name = "checkedListBoxBridges";
            this.checkedListBoxBridges.Size = new System.Drawing.Size(455, 64);
            this.checkedListBoxBridges.TabIndex = 5;
            this.checkedListBoxBridges.Visible = false;
            this.checkedListBoxBridges.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxBridges_ItemCheck);
            this.checkedListBoxBridges.SelectedValueChanged += new System.EventHandler(this.checkedListBoxBridges_SelectedValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 96);
            this.progressBar.Maximum = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(455, 19);
            this.progressBar.TabIndex = 4;
            this.progressBar.Value = 10;
            this.progressBar.Visible = false;
            // 
            // timerSearch
            // 
            this.timerSearch.Interval = 1000;
            this.timerSearch.Tick += new System.EventHandler(this.timerSearch_Tick);
            // 
            // ConnectBridgeForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 297);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkedListBoxBridges);
            this.Controls.Add(this.labelStartSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelBridgeFound);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelPressButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectBridgeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect Bridge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPressButton;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelBridgeFound;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelStartSearch;
        private System.Windows.Forms.CheckedListBox checkedListBoxBridges;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerSearch;
    }
}