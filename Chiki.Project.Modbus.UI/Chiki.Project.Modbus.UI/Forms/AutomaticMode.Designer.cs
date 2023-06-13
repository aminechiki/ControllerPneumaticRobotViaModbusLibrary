namespace Chiki.Project.Modbus.UI.Forms
{
    partial class AutomaticMode
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
            this.ResetEmergenza = new FontAwesome.Sharp.IconButton();
            this.Start = new FontAwesome.Sharp.IconButton();
            this.FungoEmergenza = new FontAwesome.Sharp.IconButton();
            this.stop = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxSuRobot = new System.Windows.Forms.TextBox();
            this.textBoxPinzaAperta = new System.Windows.Forms.TextBox();
            this.textBoxCicliMacchina = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBoxPinzaChiusa = new System.Windows.Forms.TextBox();
            this.textBoxGiuRobot = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetEmergenza
            // 
            this.ResetEmergenza.BackColor = System.Drawing.Color.SeaGreen;
            this.ResetEmergenza.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ResetEmergenza.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ResetEmergenza.IconColor = System.Drawing.Color.Black;
            this.ResetEmergenza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ResetEmergenza.Location = new System.Drawing.Point(765, 50);
            this.ResetEmergenza.Name = "ResetEmergenza";
            this.ResetEmergenza.Size = new System.Drawing.Size(203, 90);
            this.ResetEmergenza.TabIndex = 23;
            this.ResetEmergenza.Text = "RESET EMERGENZA";
            this.ResetEmergenza.UseVisualStyleBackColor = false;
            this.ResetEmergenza.Click += new System.EventHandler(this.ResetEmergenza_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.SeaGreen;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Start.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Start.IconColor = System.Drawing.Color.Black;
            this.Start.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Start.Location = new System.Drawing.Point(58, 50);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(212, 90);
            this.Start.TabIndex = 21;
            this.Start.Text = "START CICLO";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // FungoEmergenza
            // 
            this.FungoEmergenza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FungoEmergenza.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FungoEmergenza.IconChar = FontAwesome.Sharp.IconChar.None;
            this.FungoEmergenza.IconColor = System.Drawing.Color.Black;
            this.FungoEmergenza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FungoEmergenza.Location = new System.Drawing.Point(1083, 50);
            this.FungoEmergenza.Name = "FungoEmergenza";
            this.FungoEmergenza.Size = new System.Drawing.Size(206, 90);
            this.FungoEmergenza.TabIndex = 20;
            this.FungoEmergenza.Text = "FUNGO DI EMERGENZA";
            this.FungoEmergenza.UseVisualStyleBackColor = false;
            this.FungoEmergenza.Click += new System.EventHandler(this.FungoEmergenza_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stop.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.stop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.stop.IconColor = System.Drawing.Color.Black;
            this.stop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stop.Location = new System.Drawing.Point(416, 50);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(197, 90);
            this.stop.TabIndex = 22;
            this.stop.Text = "STOP CICLO";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "CAMBIO STATO SU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "TEMPO DA QUANDO è STATA ACCESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "CAMBIO STATO PINZA APERTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "CAMBIO STATO AVANTI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "NUMERO DI RESET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "NUMEOR DI CICLI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "CAMBIO STATO DESTRA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "STATI ROBOT : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(782, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "NUMERO DI STOP CICLO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(782, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(380, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "NUMERO DI PASSAGGI DA MANUALE AD AUTOMATICO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(782, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "VELOCITA ESECUZIONE DI UN CICLO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(365, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "NUMERO DI VOLTE IN CUI è ANDATA IN EMERGENZA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(782, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "NUMERO DI START CICLO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 560);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(442, 511);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 49;
            // 
            // textBoxSuRobot
            // 
            this.textBoxSuRobot.Location = new System.Drawing.Point(442, 455);
            this.textBoxSuRobot.Name = "textBoxSuRobot";
            this.textBoxSuRobot.Size = new System.Drawing.Size(100, 27);
            this.textBoxSuRobot.TabIndex = 51;
            // 
            // textBoxPinzaAperta
            // 
            this.textBoxPinzaAperta.Location = new System.Drawing.Point(442, 413);
            this.textBoxPinzaAperta.Name = "textBoxPinzaAperta";
            this.textBoxPinzaAperta.Size = new System.Drawing.Size(100, 27);
            this.textBoxPinzaAperta.TabIndex = 53;
            // 
            // textBoxCicliMacchina
            // 
            this.textBoxCicliMacchina.Location = new System.Drawing.Point(442, 186);
            this.textBoxCicliMacchina.Name = "textBoxCicliMacchina";
            this.textBoxCicliMacchina.Size = new System.Drawing.Size(100, 27);
            this.textBoxCicliMacchina.TabIndex = 57;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(442, 242);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 27);
            this.textBox8.TabIndex = 56;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(442, 291);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 27);
            this.textBox9.TabIndex = 55;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1180, 206);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 27);
            this.textBox11.TabIndex = 63;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1180, 248);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 27);
            this.textBox12.TabIndex = 62;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1180, 287);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 27);
            this.textBox13.TabIndex = 61;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1180, 167);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 27);
            this.textBox15.TabIndex = 59;
            // 
            // textBoxPinzaChiusa
            // 
            this.textBoxPinzaChiusa.Location = new System.Drawing.Point(995, 413);
            this.textBoxPinzaChiusa.Name = "textBoxPinzaChiusa";
            this.textBoxPinzaChiusa.Size = new System.Drawing.Size(100, 27);
            this.textBoxPinzaChiusa.TabIndex = 71;
            // 
            // textBoxGiuRobot
            // 
            this.textBoxGiuRobot.Location = new System.Drawing.Point(995, 455);
            this.textBoxGiuRobot.Name = "textBoxGiuRobot";
            this.textBoxGiuRobot.Size = new System.Drawing.Size(100, 27);
            this.textBoxGiuRobot.TabIndex = 70;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(995, 511);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 27);
            this.textBox10.TabIndex = 69;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(995, 560);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 27);
            this.textBox14.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(611, 518);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 20);
            this.label14.TabIndex = 67;
            this.label14.Text = "CAMBIO STATO SINISTRA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(611, 563);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "CAMBIO STATO INDIETRO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(611, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(213, 20);
            this.label16.TabIndex = 65;
            this.label16.Text = "CAMBIO STATO PINZA CHIUSA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(611, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 20);
            this.label17.TabIndex = 64;
            this.label17.Text = "CAMBIO STATO GIU";
            // 
            // AutomaticMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1472, 711);
            this.Controls.Add(this.textBoxPinzaChiusa);
            this.Controls.Add(this.textBoxGiuRobot);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBoxCicliMacchina);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBoxPinzaAperta);
            this.Controls.Add(this.textBoxSuRobot);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetEmergenza);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.FungoEmergenza);
            this.Controls.Add(this.stop);
            this.Name = "AutomaticMode";
            this.Text = "AutomaticMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ResetEmergenza;
        private FontAwesome.Sharp.IconButton Start;
        private FontAwesome.Sharp.IconButton FungoEmergenza;
        private FontAwesome.Sharp.IconButton stop;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBoxSuRobot;
        private TextBox textBoxPinzaAperta;
        private TextBox textBoxCicliMacchina;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox15;
        private TextBox textBoxPinzaChiusa;
        private TextBox textBoxGiuRobot;
        private TextBox textBox10;
        private TextBox textBox14;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}