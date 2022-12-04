
namespace emulator8086
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AH = new System.Windows.Forms.Label();
            this.BH = new System.Windows.Forms.Label();
            this.CH = new System.Windows.Forms.Label();
            this.DH = new System.Windows.Forms.Label();
            this.AL = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.Label();
            this.CL = new System.Windows.Forms.Label();
            this.DL = new System.Windows.Forms.Label();
            this.AX = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DX = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxOD = new System.Windows.Forms.ComboBox();
            this.comboBoxDO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Random = new System.Windows.Forms.Button();
            this.button5_Reset = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "DX";
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.AH);
            this.panel1.Controls.Add(this.BH);
            this.panel1.Controls.Add(this.CH);
            this.panel1.Controls.Add(this.DH);
            this.panel1.Controls.Add(this.AL);
            this.panel1.Controls.Add(this.BL);
            this.panel1.Controls.Add(this.CL);
            this.panel1.Controls.Add(this.DL);
            this.panel1.Controls.Add(this.AX);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.BX);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CX);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(601, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 313);
            this.panel1.TabIndex = 1;
            this.BackColor = System.Drawing.Color.LightBlue;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(305, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 80);
            this.label19.TabIndex = 25;
            this.label19.Text = "LOW";
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(350, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 80);
            this.label18.TabIndex = 24;
            this.label18.Text = "HIGH";
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // AH
            // 
            this.AH.AutoSize = true;
            this.AH.Location = new System.Drawing.Point(357, 93);
            this.AH.Name = "AH";
            this.AH.Size = new System.Drawing.Size(40, 13);
            this.AH.TabIndex = 23;
            this.AH.Text = "00";
            this.AH.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // BH
            // 
            this.BH.AutoSize = true;
            this.BH.Location = new System.Drawing.Point(357, 145);
            this.BH.Name = "BH";
            this.BH.Size = new System.Drawing.Size(40, 13);
            this.BH.TabIndex = 22;
            this.BH.Text = "00";
            this.BH.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // CH
            // 
            this.CH.AutoSize = true;
            this.CH.Location = new System.Drawing.Point(357, 200);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(19, 13);
            this.CH.TabIndex = 21;
            this.CH.Text = "00";
            this.CH.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // DH
            // 
            this.DH.AutoSize = true;
            this.DH.Location = new System.Drawing.Point(357, 252);
            this.DH.Name = "DH";
            this.DH.Size = new System.Drawing.Size(19, 13);
            this.DH.TabIndex = 20;
            this.DH.Text = "00";
            this.DH.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // AL
            // 
            this.AL.AutoSize = true;
            this.AL.Location = new System.Drawing.Point(311, 93);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(19, 13);
            this.AL.TabIndex = 19;
            this.AL.Text = "00";
            this.AL.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.Location = new System.Drawing.Point(311, 145);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(19, 13);
            this.BL.TabIndex = 18;
            this.BL.Text = "00";
            this.BL.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // CL
            // 
            this.CL.AutoSize = true;
            this.CL.Location = new System.Drawing.Point(311, 200);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(19, 13);
            this.CL.TabIndex = 17;
            this.CL.Text = "00";
            this.CL.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // DL
            // 
            this.DL.AutoSize = true;
            this.DL.Location = new System.Drawing.Point(311, 252);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(19, 13);
            this.DL.TabIndex = 16;
            this.DL.Text = "00";
            this.DL.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // AX
            // 
            this.AX.AutoSize = true;
            this.AX.Location = new System.Drawing.Point(243, 94);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(31, 13);
            this.AX.TabIndex = 10;
            this.AX.Text = "0000";
            this.AX.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 80);
            this.label12.TabIndex = 9;
            this.label12.Text = "AX";
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10F);

            // 
            // BX
            // 
            this.BX.AutoSize = true;
            this.BX.Location = new System.Drawing.Point(243, 146);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(31, 13);
            this.BX.TabIndex = 7;
            this.BX.Text = "0000";
            this.BX.Font = new System.Drawing.Font("Comic Sans MS", 10F);

            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 80);
            this.label9.TabIndex = 6;
            this.label9.Text = "BX";
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // CX
            // 
            this.CX.AutoSize = true;
            this.CX.Location = new System.Drawing.Point(243, 201);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(31, 13);
            this.CX.TabIndex = 4;
            this.CX.Text = "0000";
            this.CX.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 80);
            this.label6.TabIndex = 3;
            this.label6.Text = "CX";
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // DX
            // 
            this.DX.AutoSize = true;
            this.DX.Location = new System.Drawing.Point(243, 253);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(31, 13);
            this.DX.TabIndex = 1;
            this.DX.Text = "0000";
            this.DX.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBox1.Location = new System.Drawing.Point(225, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "AX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "ACCEPT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Font =  new System.Drawing.Font("Comic Sans MS",10f);
            // 
            // comboBoxOD
            // 
            this.comboBoxOD.FormattingEnabled = true;
            this.comboBoxOD.Items.AddRange(new object[] {
            "AX",
            "AH",
            "BX",
            "BH",
            "CX",
            "CH",
            "DX",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxOD.Location = new System.Drawing.Point(225, 250);
            this.comboBoxOD.Name = "comboBoxOD";
            this.comboBoxOD.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOD.TabIndex = 7;
            this.comboBoxOD.Text = "AX";
            // 
            // comboBoxDO
            // 
            this.comboBoxDO.FormattingEnabled = true;
            this.comboBoxDO.Items.AddRange(new object[] {
            "AX",
            "AH",
            "BX",
            "BH",
            "CX",
            "CH",
            "DX",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxDO.Location = new System.Drawing.Point(380, 250);
            this.comboBoxDO.Name = "comboBoxDO";
            this.comboBoxDO.Size = new System.Drawing.Size(111, 21);
            this.comboBoxDO.TabIndex = 8;
            this.comboBoxDO.Text = "AH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 80);
            this.label2.TabIndex = 9;
            this.label2.Text = "MOV";
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "ACCEPT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10f);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 16;
            this.button3.Text = "ACCEPT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10f);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 80);
            this.label4.TabIndex = 15;
            this.label4.Text = "TO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "EXC";
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "AX",
            "AH",
            "BX",
            "BH",
            "CX",
            "CH",
            "DX",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxTo.Location = new System.Drawing.Point(380, 384);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(111, 21);
            this.comboBoxTo.TabIndex = 13;
            this.comboBoxTo.Text = "AH";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "AX",
            "AH",
            "BX",
            "BH",
            "CX",
            "CH",
            "DX",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxFrom.Location = new System.Drawing.Point(225, 384);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 12;
            this.comboBoxFrom.Text = "AX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 80);
            this.label7.TabIndex = 17;
            this.label7.Text = "SET";
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(380, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(550, 300);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(100, 50);
            this.button_Random.TabIndex = 19;
            this.button_Random.Text = "RANDOM";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            this.button_Random.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // button5_Reset
            // 
            this.button5_Reset.Location = new System.Drawing.Point(550, 200);
            this.button5_Reset.Name = "button5_Reset";
            this.button5_Reset.Size = new System.Drawing.Size(100,50);
            this.button5_Reset.TabIndex = 20;
            this.button5_Reset.Text = "RESETUJ";
            this.button5_Reset.UseVisualStyleBackColor = true;
            this.button5_Reset.Click += new System.EventHandler(this.button5_Reset_Click);
            this.button5_Reset.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.label20.Location = new System.Drawing.Point(230, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(350, 80);
            this.label20.TabIndex = 21;
            this.label20.Text = "Emulator Mikroprocesora INTEL 8086";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 568);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button5_Reset);
            this.Controls.Add(this.button_Random);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDO);
            this.Controls.Add(this.comboBoxOD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
        
            this.Name = "Form1";
            this.Text = "EMULATOR 8086";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label BX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DX;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxOD;
        private System.Windows.Forms.ComboBox comboBoxDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numericUpDown1;
        private System.Windows.Forms.Label AH;
        private System.Windows.Forms.Label BH;
        private System.Windows.Forms.Label CH;
        private System.Windows.Forms.Label DH;
        private System.Windows.Forms.Label AL;
        private System.Windows.Forms.Label BL;
        private System.Windows.Forms.Label CL;
        private System.Windows.Forms.Label DL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Button button5_Reset;
        private System.Windows.Forms.Label label20;
    }
}

