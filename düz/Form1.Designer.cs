namespace düz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bilgisayar_Puan = new System.Windows.Forms.Label();
            this.Oyuncu_Puan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Kağıt = new System.Windows.Forms.PictureBox();
            this.Makas = new System.Windows.Forms.PictureBox();
            this.BİLGİSAYAR = new System.Windows.Forms.PictureBox();
            this.Taş = new System.Windows.Forms.PictureBox();
            this.OYUNCU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Kağıt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Makas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BİLGİSAYAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OYUNCU)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "OYUNCU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1027, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "BİLGİSAYAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(700, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "BİLGİSAYAR PUANI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(377, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "OYUNCU PUANI";
            // 
            // Bilgisayar_Puan
            // 
            this.Bilgisayar_Puan.AutoSize = true;
            this.Bilgisayar_Puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bilgisayar_Puan.Location = new System.Drawing.Point(806, 151);
            this.Bilgisayar_Puan.Name = "Bilgisayar_Puan";
            this.Bilgisayar_Puan.Size = new System.Drawing.Size(54, 58);
            this.Bilgisayar_Puan.TabIndex = 9;
            this.Bilgisayar_Puan.Text = "0";
            this.Bilgisayar_Puan.Click += new System.EventHandler(this.label5_Click);
            // 
            // Oyuncu_Puan
            // 
            this.Oyuncu_Puan.AutoSize = true;
            this.Oyuncu_Puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oyuncu_Puan.Location = new System.Drawing.Point(448, 160);
            this.Oyuncu_Puan.Name = "Oyuncu_Puan";
            this.Oyuncu_Puan.Size = new System.Drawing.Size(54, 58);
            this.Oyuncu_Puan.TabIndex = 10;
            this.Oyuncu_Puan.Text = "0";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(377, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(569, 51);
            this.label5.TabIndex = 11;
            this.label5.Text = "KAZANAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(377, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(569, 51);
            this.label6.TabIndex = 12;
            this.label6.Text = "BERABERE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1018, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 68);
            this.button1.TabIndex = 13;
            this.button1.Text = "OYNA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kağıt
            // 
            this.Kağıt.Image = global::düz.Properties.Resources.kağıt;
            this.Kağıt.Location = new System.Drawing.Point(125, 367);
            this.Kağıt.Name = "Kağıt";
            this.Kağıt.Size = new System.Drawing.Size(104, 97);
            this.Kağıt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kağıt.TabIndex = 4;
            this.Kağıt.TabStop = false;
            this.Kağıt.Click += new System.EventHandler(this.Kağıt_Click);
            // 
            // Makas
            // 
            this.Makas.Image = global::düz.Properties.Resources.makas;
            this.Makas.Location = new System.Drawing.Point(235, 364);
            this.Makas.Name = "Makas";
            this.Makas.Size = new System.Drawing.Size(94, 100);
            this.Makas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Makas.TabIndex = 3;
            this.Makas.TabStop = false;
            this.Makas.Click += new System.EventHandler(this.Makas_Click);
            // 
            // BİLGİSAYAR
            // 
            this.BİLGİSAYAR.Location = new System.Drawing.Point(988, 101);
            this.BİLGİSAYAR.Name = "BİLGİSAYAR";
            this.BİLGİSAYAR.Size = new System.Drawing.Size(307, 249);
            this.BİLGİSAYAR.TabIndex = 2;
            this.BİLGİSAYAR.TabStop = false;
            this.BİLGİSAYAR.Click += new System.EventHandler(this.BİLGİSAYAR_Click);
            // 
            // Taş
            // 
            this.Taş.Image = global::düz.Properties.Resources.tas;
            this.Taş.Location = new System.Drawing.Point(12, 367);
            this.Taş.Name = "Taş";
            this.Taş.Size = new System.Drawing.Size(107, 97);
            this.Taş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Taş.TabIndex = 1;
            this.Taş.TabStop = false;
            this.Taş.Click += new System.EventHandler(this.Taş_Click);
            // 
            // OYUNCU
            // 
            this.OYUNCU.Location = new System.Drawing.Point(12, 101);
            this.OYUNCU.Name = "OYUNCU";
            this.OYUNCU.Size = new System.Drawing.Size(317, 249);
            this.OYUNCU.TabIndex = 0;
            this.OYUNCU.TabStop = false;
            this.OYUNCU.Click += new System.EventHandler(this.OYUNCU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Oyuncu_Puan);
            this.Controls.Add(this.Bilgisayar_Puan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kağıt);
            this.Controls.Add(this.Makas);
            this.Controls.Add(this.BİLGİSAYAR);
            this.Controls.Add(this.Taş);
            this.Controls.Add(this.OYUNCU);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Kağıt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Makas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BİLGİSAYAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OYUNCU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OYUNCU;
        private System.Windows.Forms.PictureBox Taş;
        private System.Windows.Forms.PictureBox BİLGİSAYAR;
        private System.Windows.Forms.PictureBox Makas;
        private System.Windows.Forms.PictureBox Kağıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Bilgisayar_Puan;
        private System.Windows.Forms.Label Oyuncu_Puan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

