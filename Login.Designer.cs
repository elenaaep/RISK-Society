namespace RISK
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contNou = new System.Windows.Forms.LinkLabel();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Autentificare = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.contNou);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Autentificare);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(27, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 462);
            this.panel1.TabIndex = 0;
            // 
            // contNou
            // 
            this.contNou.AutoSize = true;
            this.contNou.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contNou.LinkColor = System.Drawing.Color.White;
            this.contNou.Location = new System.Drawing.Point(98, 396);
            this.contNou.Name = "contNou";
            this.contNou.Size = new System.Drawing.Size(203, 27);
            this.contNou.TabIndex = 5;
            this.contNou.TabStop = true;
            this.contNou.Text = "Creează un cont nou.";
            this.contNou.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contNou_LinkClicked);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(112, 229);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(245, 35);
            this.Password.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(112, 128);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(245, 35);
            this.Username.TabIndex = 3;
            // 
            // Autentificare
            // 
            this.Autentificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.Autentificare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autentificare.ForeColor = System.Drawing.Color.White;
            this.Autentificare.Location = new System.Drawing.Point(57, 327);
            this.Autentificare.Name = "Autentificare";
            this.Autentificare.Size = new System.Drawing.Size(300, 50);
            this.Autentificare.TabIndex = 2;
            this.Autentificare.Text = "AUTENTIFICARE";
            this.Autentificare.UseVisualStyleBackColor = false;
            this.Autentificare.Click += new System.EventHandler(this.Autentificare_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RISK.Properties.Resources.user__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(57, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 42);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RISK.Properties.Resources.privacy;
            this.pictureBox1.Location = new System.Drawing.Point(63, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(156, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(478, 521);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "RISK-LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Autentificare;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel contNou;
    }
}

