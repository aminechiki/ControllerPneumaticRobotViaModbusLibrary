namespace Chiki.Project.Modbus.UI
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AutomaticMode = new FontAwesome.Sharp.IconButton();
            this.ManualMode = new FontAwesome.Sharp.IconButton();
            this.settings = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.AutomaticMode);
            this.panel1.Controls.Add(this.ManualMode);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 654);
            this.panel1.TabIndex = 1;
            // 
            // AutomaticMode
            // 
            this.AutomaticMode.FlatAppearance.BorderSize = 0;
            this.AutomaticMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutomaticMode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AutomaticMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AutomaticMode.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.AutomaticMode.IconColor = System.Drawing.Color.WhiteSmoke;
            this.AutomaticMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AutomaticMode.IconSize = 60;
            this.AutomaticMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutomaticMode.Location = new System.Drawing.Point(-4, 264);
            this.AutomaticMode.Name = "AutomaticMode";
            this.AutomaticMode.Size = new System.Drawing.Size(295, 60);
            this.AutomaticMode.TabIndex = 4;
            this.AutomaticMode.Text = "Automatic Mode";
            this.AutomaticMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AutomaticMode.UseVisualStyleBackColor = true;
            this.AutomaticMode.Click += new System.EventHandler(this.AutomaticMode_Click);
            // 
            // ManualMode
            // 
            this.ManualMode.FlatAppearance.BorderSize = 0;
            this.ManualMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManualMode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManualMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManualMode.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.ManualMode.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ManualMode.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ManualMode.IconSize = 60;
            this.ManualMode.Location = new System.Drawing.Point(0, 198);
            this.ManualMode.Name = "ManualMode";
            this.ManualMode.Size = new System.Drawing.Size(294, 60);
            this.ManualMode.TabIndex = 11;
            this.ManualMode.Text = "Manual Mode";
            this.ManualMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManualMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManualMode.UseVisualStyleBackColor = true;
            this.ManualMode.Click += new System.EventHandler(this.ManualMode_Click);
            // 
            // settings
            // 
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.settings.IconColor = System.Drawing.Color.WhiteSmoke;
            this.settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settings.IconSize = 60;
            this.settings.Location = new System.Drawing.Point(0, 132);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(294, 60);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(294, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 135);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1301, 89);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTROLLER ROBOT VIA MODBUS TCP/IP";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 654);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "Controller Robot";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton settings;
        private FontAwesome.Sharp.IconButton AutomaticMode;
        private Panel panel4;
        public FontAwesome.Sharp.IconButton ManualMode;
        private Label label1;
    }
}