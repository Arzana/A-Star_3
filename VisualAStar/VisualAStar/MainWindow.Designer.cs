namespace DeJong.VisualAStar
{
    partial class MainWindow
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
            this.ControllGroup = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnAutoUpdate = new System.Windows.Forms.Button();
            this.Splitter = new System.Windows.Forms.SplitContainer();
            this.LblClosed = new System.Windows.Forms.Label();
            this.ListViewClosed = new System.Windows.Forms.ListView();
            this.ListViewOpen = new System.Windows.Forms.ListView();
            this.LblOpen = new System.Windows.Forms.Label();
            this.BtnTick = new System.Windows.Forms.Button();
            this.BtnFinalizeMap = new System.Windows.Forms.Button();
            this.CheckP = new System.Windows.Forms.CheckBox();
            this.CheckF = new System.Windows.Forms.CheckBox();
            this.CheckG = new System.Windows.Forms.CheckBox();
            this.CheckH = new System.Windows.Forms.CheckBox();
            this.BtnFinalizeSize = new System.Windows.Forms.Button();
            this.LblHeight = new System.Windows.Forms.Label();
            this.SldHeight = new System.Windows.Forms.TrackBar();
            this.LblWidth = new System.Windows.Forms.Label();
            this.SldWidth = new System.Windows.Forms.TrackBar();
            this.AutoTicker = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ControllGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
            this.Splitter.Panel1.SuspendLayout();
            this.Splitter.Panel2.SuspendLayout();
            this.Splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SldWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // ControllGroup
            // 
            this.ControllGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ControllGroup.Controls.Add(this.BtnReset);
            this.ControllGroup.Controls.Add(this.BtnAutoUpdate);
            this.ControllGroup.Controls.Add(this.Splitter);
            this.ControllGroup.Controls.Add(this.BtnTick);
            this.ControllGroup.Controls.Add(this.BtnFinalizeMap);
            this.ControllGroup.Controls.Add(this.CheckP);
            this.ControllGroup.Controls.Add(this.CheckF);
            this.ControllGroup.Controls.Add(this.CheckG);
            this.ControllGroup.Controls.Add(this.CheckH);
            this.ControllGroup.Controls.Add(this.BtnFinalizeSize);
            this.ControllGroup.Controls.Add(this.LblHeight);
            this.ControllGroup.Controls.Add(this.SldHeight);
            this.ControllGroup.Controls.Add(this.LblWidth);
            this.ControllGroup.Controls.Add(this.SldWidth);
            this.ControllGroup.Location = new System.Drawing.Point(12, 27);
            this.ControllGroup.Name = "ControllGroup";
            this.ControllGroup.Size = new System.Drawing.Size(200, 509);
            this.ControllGroup.TabIndex = 1;
            this.ControllGroup.TabStop = false;
            this.ControllGroup.Text = "Controlls";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(19, 177);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 13;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnAutoUpdate
            // 
            this.BtnAutoUpdate.Enabled = false;
            this.BtnAutoUpdate.Location = new System.Drawing.Point(103, 177);
            this.BtnAutoUpdate.Name = "BtnAutoUpdate";
            this.BtnAutoUpdate.Size = new System.Drawing.Size(91, 23);
            this.BtnAutoUpdate.TabIndex = 12;
            this.BtnAutoUpdate.Text = "Start AutoTick";
            this.BtnAutoUpdate.UseVisualStyleBackColor = true;
            this.BtnAutoUpdate.Click += new System.EventHandler(this.BtnAutoUpdate_Click);
            // 
            // Splitter
            // 
            this.Splitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Splitter.IsSplitterFixed = true;
            this.Splitter.Location = new System.Drawing.Point(6, 206);
            this.Splitter.Name = "Splitter";
            // 
            // Splitter.Panel1
            // 
            this.Splitter.Panel1.Controls.Add(this.LblClosed);
            this.Splitter.Panel1.Controls.Add(this.ListViewClosed);
            // 
            // Splitter.Panel2
            // 
            this.Splitter.Panel2.Controls.Add(this.ListViewOpen);
            this.Splitter.Panel2.Controls.Add(this.LblOpen);
            this.Splitter.Size = new System.Drawing.Size(188, 297);
            this.Splitter.SplitterDistance = 94;
            this.Splitter.TabIndex = 11;
            // 
            // LblClosed
            // 
            this.LblClosed.AutoSize = true;
            this.LblClosed.Location = new System.Drawing.Point(4, 4);
            this.LblClosed.Name = "LblClosed";
            this.LblClosed.Size = new System.Drawing.Size(58, 13);
            this.LblClosed.TabIndex = 1;
            this.LblClosed.Text = "Closed List";
            // 
            // ListViewClosed
            // 
            this.ListViewClosed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewClosed.Location = new System.Drawing.Point(3, 20);
            this.ListViewClosed.Name = "ListViewClosed";
            this.ListViewClosed.Size = new System.Drawing.Size(88, 274);
            this.ListViewClosed.TabIndex = 0;
            this.ListViewClosed.UseCompatibleStateImageBehavior = false;
            this.ListViewClosed.View = System.Windows.Forms.View.List;
            // 
            // ListViewOpen
            // 
            this.ListViewOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewOpen.Location = new System.Drawing.Point(7, 20);
            this.ListViewOpen.Name = "ListViewOpen";
            this.ListViewOpen.Size = new System.Drawing.Size(80, 274);
            this.ListViewOpen.TabIndex = 1;
            this.ListViewOpen.UseCompatibleStateImageBehavior = false;
            this.ListViewOpen.View = System.Windows.Forms.View.List;
            // 
            // LblOpen
            // 
            this.LblOpen.AutoSize = true;
            this.LblOpen.Location = new System.Drawing.Point(4, 4);
            this.LblOpen.Name = "LblOpen";
            this.LblOpen.Size = new System.Drawing.Size(52, 13);
            this.LblOpen.TabIndex = 0;
            this.LblOpen.Text = "Open List";
            // 
            // BtnTick
            // 
            this.BtnTick.Enabled = false;
            this.BtnTick.Location = new System.Drawing.Point(19, 149);
            this.BtnTick.Name = "BtnTick";
            this.BtnTick.Size = new System.Drawing.Size(75, 23);
            this.BtnTick.TabIndex = 10;
            this.BtnTick.Text = "Tick A*";
            this.BtnTick.UseVisualStyleBackColor = true;
            this.BtnTick.Click += new System.EventHandler(this.BtnTick_Click);
            // 
            // BtnFinalizeMap
            // 
            this.BtnFinalizeMap.Enabled = false;
            this.BtnFinalizeMap.Location = new System.Drawing.Point(19, 120);
            this.BtnFinalizeMap.Name = "BtnFinalizeMap";
            this.BtnFinalizeMap.Size = new System.Drawing.Size(75, 23);
            this.BtnFinalizeMap.TabIndex = 9;
            this.BtnFinalizeMap.Text = "Finalize Map";
            this.BtnFinalizeMap.UseVisualStyleBackColor = true;
            this.BtnFinalizeMap.Click += new System.EventHandler(this.BtnFinalizeMap_Click);
            // 
            // CheckP
            // 
            this.CheckP.AutoSize = true;
            this.CheckP.Checked = true;
            this.CheckP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckP.Location = new System.Drawing.Point(112, 160);
            this.CheckP.Name = "CheckP";
            this.CheckP.Size = new System.Drawing.Size(62, 17);
            this.CheckP.TabIndex = 8;
            this.CheckP.Text = "Parents";
            this.CheckP.UseVisualStyleBackColor = true;
            this.CheckP.CheckedChanged += new System.EventHandler(this.CheckP_CheckedChanged);
            // 
            // CheckF
            // 
            this.CheckF.AutoSize = true;
            this.CheckF.Location = new System.Drawing.Point(111, 137);
            this.CheckF.Name = "CheckF";
            this.CheckF.Size = new System.Drawing.Size(62, 17);
            this.CheckF.TabIndex = 7;
            this.CheckF.Text = "F Value";
            this.CheckF.UseVisualStyleBackColor = true;
            this.CheckF.CheckedChanged += new System.EventHandler(this.CheckF_CheckedChanged);
            // 
            // CheckG
            // 
            this.CheckG.AutoSize = true;
            this.CheckG.Checked = true;
            this.CheckG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckG.Location = new System.Drawing.Point(112, 114);
            this.CheckG.Name = "CheckG";
            this.CheckG.Size = new System.Drawing.Size(64, 17);
            this.CheckG.TabIndex = 6;
            this.CheckG.Text = "G Value";
            this.CheckG.UseVisualStyleBackColor = true;
            this.CheckG.CheckedChanged += new System.EventHandler(this.CheckG_CheckedChanged);
            // 
            // CheckH
            // 
            this.CheckH.AutoSize = true;
            this.CheckH.Checked = true;
            this.CheckH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckH.Location = new System.Drawing.Point(111, 91);
            this.CheckH.Name = "CheckH";
            this.CheckH.Size = new System.Drawing.Size(67, 17);
            this.CheckH.TabIndex = 5;
            this.CheckH.Text = "Heuristic";
            this.CheckH.UseVisualStyleBackColor = true;
            this.CheckH.CheckedChanged += new System.EventHandler(this.CheckH_CheckedChanged);
            // 
            // BtnFinalizeSize
            // 
            this.BtnFinalizeSize.Location = new System.Drawing.Point(19, 91);
            this.BtnFinalizeSize.Name = "BtnFinalizeSize";
            this.BtnFinalizeSize.Size = new System.Drawing.Size(75, 23);
            this.BtnFinalizeSize.TabIndex = 4;
            this.BtnFinalizeSize.Text = "Finalize Size";
            this.BtnFinalizeSize.UseVisualStyleBackColor = true;
            this.BtnFinalizeSize.Click += new System.EventHandler(this.BtnFinalizeSize_Click);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(116, 70);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(50, 13);
            this.LblHeight.TabIndex = 3;
            this.LblHeight.Text = "Height: 2";
            // 
            // SldHeight
            // 
            this.SldHeight.Location = new System.Drawing.Point(6, 57);
            this.SldHeight.Maximum = 20;
            this.SldHeight.Minimum = 2;
            this.SldHeight.Name = "SldHeight";
            this.SldHeight.Size = new System.Drawing.Size(104, 45);
            this.SldHeight.TabIndex = 2;
            this.SldHeight.Value = 2;
            this.SldHeight.ValueChanged += new System.EventHandler(this.SldHeight_ValueChanged);
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(116, 19);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(47, 13);
            this.LblWidth.TabIndex = 1;
            this.LblWidth.Text = "Width: 2";
            // 
            // SldWidth
            // 
            this.SldWidth.Location = new System.Drawing.Point(6, 19);
            this.SldWidth.Maximum = 20;
            this.SldWidth.Minimum = 2;
            this.SldWidth.Name = "SldWidth";
            this.SldWidth.Size = new System.Drawing.Size(104, 45);
            this.SldWidth.TabIndex = 0;
            this.SldWidth.Value = 2;
            this.SldWidth.ValueChanged += new System.EventHandler(this.SldWidth_ValueChanged);
            // 
            // AutoTicker
            // 
            this.AutoTicker.Tick += new System.EventHandler(this.AutoTicker_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Items.Add(LblStatus);
            this.statusStrip1.Items.Add(LblInfo);
            // 
            // LblStatus
            // 
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(67, 17);
            this.LblStatus.Text = "Not Started";
            // 
            // LblInfo
            // 
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.LblInfo.Size = new System.Drawing.Size(144, 17);
            this.LblInfo.Text = "Specify map size";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Items.Add(BtnSettings);
            this.menuStrip1.Items.Add(BtnAbout);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(61, 20);
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(52, 20);
            this.BtnAbout.Text = "About";
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ControllGroup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 600);
            this.Name = "MainWindow";
            this.Text = "Visualization of A*";
            this.Click += new System.EventHandler(this.MainWindow_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.ControllGroup.ResumeLayout(false);
            this.ControllGroup.PerformLayout();
            this.Splitter.Panel1.ResumeLayout(false);
            this.Splitter.Panel1.PerformLayout();
            this.Splitter.Panel2.ResumeLayout(false);
            this.Splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
            this.Splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SldHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SldWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.TrackBar SldWidth;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.TrackBar SldHeight;
        public System.Windows.Forms.GroupBox ControllGroup;
        private System.Windows.Forms.Button BtnFinalizeSize;
        private System.Windows.Forms.CheckBox CheckH;
        private System.Windows.Forms.CheckBox CheckG;
        private System.Windows.Forms.CheckBox CheckF;
        private System.Windows.Forms.CheckBox CheckP;
        private System.Windows.Forms.Button BtnFinalizeMap;
        private System.Windows.Forms.Button BtnTick;
        private System.Windows.Forms.SplitContainer Splitter;
        private System.Windows.Forms.ListView ListViewClosed;
        private System.Windows.Forms.Label LblClosed;
        private System.Windows.Forms.ListView ListViewOpen;
        private System.Windows.Forms.Label LblOpen;
        private System.Windows.Forms.Button BtnAutoUpdate;
        private System.Windows.Forms.Timer AutoTicker;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.ToolStripStatusLabel LblInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnSettings;
        private System.Windows.Forms.ToolStripMenuItem BtnAbout;
    }
}

