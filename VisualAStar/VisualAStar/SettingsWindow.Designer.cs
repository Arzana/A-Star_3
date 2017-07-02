namespace DeJong.VisualAStar
{
    partial class SettingsWindow
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
            this.DialogColor = new System.Windows.Forms.ColorDialog();
            this.BtnWallColor = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnStartColor = new System.Windows.Forms.Button();
            this.BtnEndColor = new System.Windows.Forms.Button();
            this.BtnCurColor = new System.Windows.Forms.Button();
            this.BtnTextColor = new System.Windows.Forms.Button();
            this.BtnArrowColor = new System.Windows.Forms.Button();
            this.BtnGridColor = new System.Windows.Forms.Button();
            this.BtnRouteColor = new System.Windows.Forms.Button();
            this.NumGridPenSize = new System.Windows.Forms.NumericUpDown();
            this.LblGridPenSize = new System.Windows.Forms.Label();
            this.NumRoutePenSize = new System.Windows.Forms.NumericUpDown();
            this.LblRoutePenSize = new System.Windows.Forms.Label();
            this.NumNodeSize = new System.Windows.Forms.NumericUpDown();
            this.LblNodeSize = new System.Windows.Forms.Label();
            this.NumTickCooldown = new System.Windows.Forms.NumericUpDown();
            this.LblTickCooldown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumGridPenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRoutePenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNodeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTickCooldown)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnWallColor
            // 
            this.BtnWallColor.Location = new System.Drawing.Point(12, 12);
            this.BtnWallColor.Name = "BtnWallColor";
            this.BtnWallColor.Size = new System.Drawing.Size(84, 23);
            this.BtnWallColor.TabIndex = 0;
            this.BtnWallColor.Text = "Wall color";
            this.BtnWallColor.UseVisualStyleBackColor = true;
            this.BtnWallColor.Click += new System.EventHandler(this.BtnWallColor_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(197, 215);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 1;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnStartColor
            // 
            this.BtnStartColor.Location = new System.Drawing.Point(12, 41);
            this.BtnStartColor.Name = "BtnStartColor";
            this.BtnStartColor.Size = new System.Drawing.Size(84, 23);
            this.BtnStartColor.TabIndex = 2;
            this.BtnStartColor.Text = "Start color";
            this.BtnStartColor.UseVisualStyleBackColor = true;
            this.BtnStartColor.Click += new System.EventHandler(this.BtnStartColor_Click);
            // 
            // BtnEndColor
            // 
            this.BtnEndColor.Location = new System.Drawing.Point(12, 70);
            this.BtnEndColor.Name = "BtnEndColor";
            this.BtnEndColor.Size = new System.Drawing.Size(84, 23);
            this.BtnEndColor.TabIndex = 3;
            this.BtnEndColor.Text = "End color";
            this.BtnEndColor.UseVisualStyleBackColor = true;
            this.BtnEndColor.Click += new System.EventHandler(this.BtnEndColor_Click);
            // 
            // BtnCurColor
            // 
            this.BtnCurColor.Location = new System.Drawing.Point(12, 99);
            this.BtnCurColor.Name = "BtnCurColor";
            this.BtnCurColor.Size = new System.Drawing.Size(84, 23);
            this.BtnCurColor.TabIndex = 4;
            this.BtnCurColor.Text = "Current Color";
            this.BtnCurColor.UseVisualStyleBackColor = true;
            this.BtnCurColor.Click += new System.EventHandler(this.BtnCurColor_Click);
            // 
            // BtnTextColor
            // 
            this.BtnTextColor.Location = new System.Drawing.Point(12, 128);
            this.BtnTextColor.Name = "BtnTextColor";
            this.BtnTextColor.Size = new System.Drawing.Size(84, 23);
            this.BtnTextColor.TabIndex = 5;
            this.BtnTextColor.Text = "Text color";
            this.BtnTextColor.UseVisualStyleBackColor = true;
            this.BtnTextColor.Click += new System.EventHandler(this.BtnTextColor_Click);
            // 
            // BtnArrowColor
            // 
            this.BtnArrowColor.Location = new System.Drawing.Point(12, 157);
            this.BtnArrowColor.Name = "BtnArrowColor";
            this.BtnArrowColor.Size = new System.Drawing.Size(84, 23);
            this.BtnArrowColor.TabIndex = 6;
            this.BtnArrowColor.Text = "Arrow color";
            this.BtnArrowColor.UseVisualStyleBackColor = true;
            this.BtnArrowColor.Click += new System.EventHandler(this.BtnArrowColor_Click);
            // 
            // BtnGridColor
            // 
            this.BtnGridColor.Location = new System.Drawing.Point(12, 186);
            this.BtnGridColor.Name = "BtnGridColor";
            this.BtnGridColor.Size = new System.Drawing.Size(84, 23);
            this.BtnGridColor.TabIndex = 7;
            this.BtnGridColor.Text = "Grid color";
            this.BtnGridColor.UseVisualStyleBackColor = true;
            this.BtnGridColor.Click += new System.EventHandler(this.BtnGridColor_Click);
            // 
            // BtnRouteColor
            // 
            this.BtnRouteColor.Location = new System.Drawing.Point(12, 215);
            this.BtnRouteColor.Name = "BtnRouteColor";
            this.BtnRouteColor.Size = new System.Drawing.Size(84, 23);
            this.BtnRouteColor.TabIndex = 8;
            this.BtnRouteColor.Text = "Route color";
            this.BtnRouteColor.UseVisualStyleBackColor = true;
            this.BtnRouteColor.Click += new System.EventHandler(this.BtnRouteColor_Click);
            // 
            // NumGridPenSize
            // 
            this.NumGridPenSize.Location = new System.Drawing.Point(197, 12);
            this.NumGridPenSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumGridPenSize.Name = "NumGridPenSize";
            this.NumGridPenSize.Size = new System.Drawing.Size(75, 20);
            this.NumGridPenSize.TabIndex = 9;
            this.NumGridPenSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblGridPenSize
            // 
            this.LblGridPenSize.AutoSize = true;
            this.LblGridPenSize.Location = new System.Drawing.Point(111, 14);
            this.LblGridPenSize.Name = "LblGridPenSize";
            this.LblGridPenSize.Size = new System.Drawing.Size(57, 13);
            this.LblGridPenSize.TabIndex = 10;
            this.LblGridPenSize.Text = "Grid width:";
            // 
            // NumRoutePenSize
            // 
            this.NumRoutePenSize.Location = new System.Drawing.Point(197, 44);
            this.NumRoutePenSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumRoutePenSize.Name = "NumRoutePenSize";
            this.NumRoutePenSize.Size = new System.Drawing.Size(75, 20);
            this.NumRoutePenSize.TabIndex = 11;
            this.NumRoutePenSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblRoutePenSize
            // 
            this.LblRoutePenSize.AutoSize = true;
            this.LblRoutePenSize.Location = new System.Drawing.Point(111, 46);
            this.LblRoutePenSize.Name = "LblRoutePenSize";
            this.LblRoutePenSize.Size = new System.Drawing.Size(67, 13);
            this.LblRoutePenSize.TabIndex = 12;
            this.LblRoutePenSize.Text = "Route width:";
            // 
            // NumNodeSize
            // 
            this.NumNodeSize.Location = new System.Drawing.Point(197, 73);
            this.NumNodeSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumNodeSize.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NumNodeSize.Name = "NumNodeSize";
            this.NumNodeSize.Size = new System.Drawing.Size(75, 20);
            this.NumNodeSize.TabIndex = 13;
            this.NumNodeSize.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // LblNodeSize
            // 
            this.LblNodeSize.AutoSize = true;
            this.LblNodeSize.Location = new System.Drawing.Point(111, 75);
            this.LblNodeSize.Name = "LblNodeSize";
            this.LblNodeSize.Size = new System.Drawing.Size(57, 13);
            this.LblNodeSize.TabIndex = 14;
            this.LblNodeSize.Text = "Node size:";
            // 
            // NumTickCooldown
            // 
            this.NumTickCooldown.Location = new System.Drawing.Point(197, 102);
            this.NumTickCooldown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumTickCooldown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTickCooldown.Name = "NumTickCooldown";
            this.NumTickCooldown.Size = new System.Drawing.Size(75, 20);
            this.NumTickCooldown.TabIndex = 15;
            this.NumTickCooldown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblTickCooldown
            // 
            this.LblTickCooldown.AutoSize = true;
            this.LblTickCooldown.Location = new System.Drawing.Point(111, 104);
            this.LblTickCooldown.Name = "LblTickCooldown";
            this.LblTickCooldown.Size = new System.Drawing.Size(80, 13);
            this.LblTickCooldown.TabIndex = 16;
            this.LblTickCooldown.Text = "Tick cooldown:";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.LblTickCooldown);
            this.Controls.Add(this.NumTickCooldown);
            this.Controls.Add(this.LblNodeSize);
            this.Controls.Add(this.NumNodeSize);
            this.Controls.Add(this.LblRoutePenSize);
            this.Controls.Add(this.NumRoutePenSize);
            this.Controls.Add(this.LblGridPenSize);
            this.Controls.Add(this.NumGridPenSize);
            this.Controls.Add(this.BtnRouteColor);
            this.Controls.Add(this.BtnGridColor);
            this.Controls.Add(this.BtnArrowColor);
            this.Controls.Add(this.BtnTextColor);
            this.Controls.Add(this.BtnCurColor);
            this.Controls.Add(this.BtnEndColor);
            this.Controls.Add(this.BtnStartColor);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.BtnWallColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.NumGridPenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRoutePenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNodeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTickCooldown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog DialogColor;
        private System.Windows.Forms.Button BtnWallColor;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnStartColor;
        private System.Windows.Forms.Button BtnEndColor;
        private System.Windows.Forms.Button BtnCurColor;
        private System.Windows.Forms.Button BtnTextColor;
        private System.Windows.Forms.Button BtnArrowColor;
        private System.Windows.Forms.Button BtnGridColor;
        private System.Windows.Forms.Button BtnRouteColor;
        private System.Windows.Forms.NumericUpDown NumGridPenSize;
        private System.Windows.Forms.Label LblGridPenSize;
        private System.Windows.Forms.NumericUpDown NumRoutePenSize;
        private System.Windows.Forms.Label LblRoutePenSize;
        private System.Windows.Forms.NumericUpDown NumNodeSize;
        private System.Windows.Forms.Label LblNodeSize;
        private System.Windows.Forms.NumericUpDown NumTickCooldown;
        private System.Windows.Forms.Label LblTickCooldown;
    }
}