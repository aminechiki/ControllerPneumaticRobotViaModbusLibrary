namespace Chiki.Project.Modbus.UI.Forms
{
    partial class settingsMdbusTcp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxTypeConnection = new System.Windows.Forms.ComboBox();
            this.TextboxIpaddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConnectionTimeout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stateConnectionSignal = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP ADDRESS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(810, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TYPE OF CONNECTION :";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(956, 399);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(190, 38);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxTypeConnection
            // 
            this.comboBoxTypeConnection.FormattingEnabled = true;
            this.comboBoxTypeConnection.Location = new System.Drawing.Point(671, 278);
            this.comboBoxTypeConnection.Name = "comboBoxTypeConnection";
            this.comboBoxTypeConnection.Size = new System.Drawing.Size(100, 28);
            this.comboBoxTypeConnection.TabIndex = 7;
            // 
            // TextboxIpaddress
            // 
            this.TextboxIpaddress.Location = new System.Drawing.Point(671, 213);
            this.TextboxIpaddress.Name = "TextboxIpaddress";
            this.TextboxIpaddress.Size = new System.Drawing.Size(100, 27);
            this.TextboxIpaddress.TabIndex = 9;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(1046, 213);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 27);
            this.textBoxPort.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "CONNECTION TIMEOUT :";
            // 
            // textBoxConnectionTimeout
            // 
            this.textBoxConnectionTimeout.Location = new System.Drawing.Point(1046, 279);
            this.textBoxConnectionTimeout.Name = "textBoxConnectionTimeout";
            this.textBoxConnectionTimeout.Size = new System.Drawing.Size(100, 27);
            this.textBoxConnectionTimeout.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1161, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "STATE CONNECTION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(625, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 15;
            // 
            // stateConnectionSignal
            // 
            this.stateConnectionSignal.BackColor = System.Drawing.Color.Silver;
            this.stateConnectionSignal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.stateConnectionSignal.IconColor = System.Drawing.Color.White;
            this.stateConnectionSignal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stateConnectionSignal.Location = new System.Drawing.Point(671, 399);
            this.stateConnectionSignal.Name = "stateConnectionSignal";
            this.stateConnectionSignal.Size = new System.Drawing.Size(100, 29);
            this.stateConnectionSignal.TabIndex = 16;
            this.stateConnectionSignal.UseVisualStyleBackColor = false;
            // 
            // settingsMdbusTcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1238, 552);
            this.Controls.Add(this.stateConnectionSignal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConnectionTimeout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.TextboxIpaddress);
            this.Controls.Add(this.comboBoxTypeConnection);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "settingsMdbusTcp";
            this.Text = "settingsMdbusTcp";
            this.Load += new System.EventHandler(this.settingsMdbusTcp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonConnect;
        private ComboBox comboBoxTypeConnection;
        private TextBox TextboxIpaddress;
        private TextBox textBoxPort;
        private Label label4;
        private TextBox textBoxConnectionTimeout;
        private Label label5;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton stateConnectionSignal;
    }
}