namespace RISK
{
    partial class Inregistrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inregistrare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.utilizator = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.confirmare);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.gen);
            this.panel1.Controls.Add(this.data);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.parola);
            this.panel1.Controls.Add(this.prenume);
            this.panel1.Controls.Add(this.utilizator);
            this.panel1.Controls.Add(this.nume);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 430);
            this.panel1.TabIndex = 0;
            // 
            // confirmare
            // 
            this.confirmare.Location = new System.Drawing.Point(178, 328);
            this.confirmare.Name = "confirmare";
            this.confirmare.PasswordChar = '*';
            this.confirmare.Size = new System.Drawing.Size(235, 22);
            this.confirmare.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Confirmare parola";
            // 
            // gen
            // 
            this.gen.FormattingEnabled = true;
            this.gen.Items.AddRange(new object[] {
            "Barbat",
            "Femeie"});
            this.gen.Location = new System.Drawing.Point(178, 188);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(235, 24);
            this.gen.TabIndex = 13;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(178, 224);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(235, 22);
            this.data.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ziua de naștere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gen";
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(178, 292);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(235, 22);
            this.parola.TabIndex = 9;
            // 
            // prenume
            // 
            this.prenume.Location = new System.Drawing.Point(178, 154);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(235, 22);
            this.prenume.TabIndex = 8;
            // 
            // utilizator
            // 
            this.utilizator.Location = new System.Drawing.Point(178, 258);
            this.utilizator.Name = "utilizator";
            this.utilizator.Size = new System.Drawing.Size(235, 22);
            this.utilizator.TabIndex = 7;
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(178, 117);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(235, 22);
            this.nume.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(102, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Înregistrare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume de utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introdu datele personale.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(501, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Inregistrare";
            this.Text = "RISK-INREGISTRARE";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox utilizator;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.TextBox confirmare;
        private System.Windows.Forms.Label label8;
    }
}