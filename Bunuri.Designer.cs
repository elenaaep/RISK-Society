namespace RISK
{
    partial class Bunuri
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reîmprospatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.domeniu = new System.Windows.Forms.TextBox();
            this.reducere = new System.Windows.Forms.TextBox();
            this.tabelBunuri = new System.Windows.Forms.DataGridView();
            this.inserare = new System.Windows.Forms.Button();
            this.stergere = new System.Windows.Forms.Button();
            this.actualizare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cautare = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.codBun = new System.Windows.Forms.TextBox();
            this.codProiect = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.importExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBunuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.istoricToolStripMenuItem,
            this.reîmprospatareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePDFToolStripMenuItem,
            this.saveExcelToolStripMenuItem,
            this.importExcelToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // savePDFToolStripMenuItem
            // 
            this.savePDFToolStripMenuItem.Name = "savePDFToolStripMenuItem";
            this.savePDFToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.savePDFToolStripMenuItem.Text = "Save PDF";
            this.savePDFToolStripMenuItem.Click += new System.EventHandler(this.savePDFToolStripMenuItem_Click);
            // 
            // saveExcelToolStripMenuItem
            // 
            this.saveExcelToolStripMenuItem.Name = "saveExcelToolStripMenuItem";
            this.saveExcelToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.saveExcelToolStripMenuItem.Text = "Save Excel";
            this.saveExcelToolStripMenuItem.Click += new System.EventHandler(this.saveExcelToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.goBackToolStripMenuItem.Text = "Go back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // istoricToolStripMenuItem
            // 
            this.istoricToolStripMenuItem.Name = "istoricToolStripMenuItem";
            this.istoricToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.istoricToolStripMenuItem.Text = "Istoric";
            this.istoricToolStripMenuItem.Click += new System.EventHandler(this.istoricToolStripMenuItem_Click);
            // 
            // reîmprospatareToolStripMenuItem
            // 
            this.reîmprospatareToolStripMenuItem.Name = "reîmprospatareToolStripMenuItem";
            this.reîmprospatareToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.reîmprospatareToolStripMenuItem.Text = "Reîmprospătare";
            this.reîmprospatareToolStripMenuItem.Click += new System.EventHandler(this.reîmprospatareToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Impact minim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Domeniu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Impact maxim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cost de reducere";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(167, 124);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(237, 22);
            this.nume.TabIndex = 7;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(167, 192);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(237, 22);
            this.cost.TabIndex = 8;
            // 
            // domeniu
            // 
            this.domeniu.Location = new System.Drawing.Point(612, 121);
            this.domeniu.Name = "domeniu";
            this.domeniu.Size = new System.Drawing.Size(237, 22);
            this.domeniu.TabIndex = 9;
            // 
            // reducere
            // 
            this.reducere.Location = new System.Drawing.Point(612, 189);
            this.reducere.Name = "reducere";
            this.reducere.Size = new System.Drawing.Size(237, 22);
            this.reducere.TabIndex = 10;
            // 
            // tabelBunuri
            // 
            this.tabelBunuri.ColumnHeadersHeight = 29;
            this.tabelBunuri.Location = new System.Drawing.Point(30, 302);
            this.tabelBunuri.Name = "tabelBunuri";
            this.tabelBunuri.RowHeadersWidth = 51;
            this.tabelBunuri.RowTemplate.Height = 24;
            this.tabelBunuri.Size = new System.Drawing.Size(815, 271);
            this.tabelBunuri.TabIndex = 13;
            // 
            // inserare
            // 
            this.inserare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.inserare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inserare.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserare.ForeColor = System.Drawing.SystemColors.Control;
            this.inserare.Location = new System.Drawing.Point(30, 256);
            this.inserare.Name = "inserare";
            this.inserare.Size = new System.Drawing.Size(150, 40);
            this.inserare.TabIndex = 14;
            this.inserare.Text = "INSEREAZĂ";
            this.inserare.UseVisualStyleBackColor = false;
            this.inserare.Click += new System.EventHandler(this.inserare_Click);
            // 
            // stergere
            // 
            this.stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.stergere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergere.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergere.ForeColor = System.Drawing.SystemColors.Control;
            this.stergere.Location = new System.Drawing.Point(394, 256);
            this.stergere.Name = "stergere";
            this.stergere.Size = new System.Drawing.Size(150, 40);
            this.stergere.TabIndex = 15;
            this.stergere.Text = "ȘTERGE";
            this.stergere.UseVisualStyleBackColor = false;
            this.stergere.Click += new System.EventHandler(this.stergere_Click);
            // 
            // actualizare
            // 
            this.actualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.actualizare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.actualizare.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizare.ForeColor = System.Drawing.SystemColors.Control;
            this.actualizare.Location = new System.Drawing.Point(699, 256);
            this.actualizare.Name = "actualizare";
            this.actualizare.Size = new System.Drawing.Size(150, 40);
            this.actualizare.TabIndex = 16;
            this.actualizare.Text = "ACTUALIZEAZĂ";
            this.actualizare.UseVisualStyleBackColor = false;
            this.actualizare.Click += new System.EventHandler(this.actualizare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cautare";
            // 
            // cautare
            // 
            this.cautare.Location = new System.Drawing.Point(167, 42);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(682, 22);
            this.cautare.TabIndex = 18;
            this.cautare.TextChanged += new System.EventHandler(this.cautare_TextChanged);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(612, 155);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(237, 22);
            this.max.TabIndex = 19;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(167, 155);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(237, 22);
            this.min.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cod bun";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(443, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cod proiect";
            // 
            // codBun
            // 
            this.codBun.Location = new System.Drawing.Point(167, 90);
            this.codBun.Name = "codBun";
            this.codBun.Size = new System.Drawing.Size(237, 22);
            this.codBun.TabIndex = 23;
            // 
            // codProiect
            // 
            this.codProiect.FormattingEnabled = true;
            this.codProiect.Location = new System.Drawing.Point(612, 87);
            this.codProiect.Name = "codProiect";
            this.codProiect.Size = new System.Drawing.Size(237, 24);
            this.codProiect.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 167);
            this.panel1.TabIndex = 25;
            // 
            // importExcelToolStripMenuItem
            // 
            this.importExcelToolStripMenuItem.Name = "importExcelToolStripMenuItem";
            this.importExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importExcelToolStripMenuItem.Text = "Import Excel";
            this.importExcelToolStripMenuItem.Click += new System.EventHandler(this.importExcelToolStripMenuItem_Click);
            // 
            // Bunuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(883, 595);
            this.Controls.Add(this.codProiect);
            this.Controls.Add(this.codBun);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.actualizare);
            this.Controls.Add(this.stergere);
            this.Controls.Add(this.inserare);
            this.Controls.Add(this.tabelBunuri);
            this.Controls.Add(this.reducere);
            this.Controls.Add(this.domeniu);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bunuri";
            this.Text = "Identificare bunuri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBunuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox domeniu;
        private System.Windows.Forms.TextBox reducere;
        private System.Windows.Forms.DataGridView tabelBunuri;
        private System.Windows.Forms.Button inserare;
        private System.Windows.Forms.Button stergere;
        private System.Windows.Forms.Button actualizare;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cautare;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox codBun;
        private System.Windows.Forms.ComboBox codProiect;
        private System.Windows.Forms.ToolStripMenuItem reîmprospatareToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem importExcelToolStripMenuItem;
    }
}