namespace RISK
{
    partial class Vulnerabilitati
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
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cautare = new System.Windows.Forms.TextBox();
            this.nivel = new System.Windows.Forms.TextBox();
            this.vulnerabilitate = new System.Windows.Forms.TextBox();
            this.tabelVulnerabilitati = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.codBun = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.importExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelVulnerabilitati)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.istoricToolStripMenuItem,
            this.reToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 28);
            this.menuStrip1.TabIndex = 2;
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
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            this.rapoarteToolStripMenuItem.Click += new System.EventHandler(this.rapoarteToolStripMenuItem_Click);
            // 
            // istoricToolStripMenuItem
            // 
            this.istoricToolStripMenuItem.Name = "istoricToolStripMenuItem";
            this.istoricToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.istoricToolStripMenuItem.Text = "Istoric";
            this.istoricToolStripMenuItem.Click += new System.EventHandler(this.istoricToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.reToolStripMenuItem.Text = "Reîmprospătare";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Căutare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod bun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vulnerabilitate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel";
            // 
            // cautare
            // 
            this.cautare.Location = new System.Drawing.Point(173, 43);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(322, 22);
            this.cautare.TabIndex = 7;
            this.cautare.TextChanged += new System.EventHandler(this.cautare_TextChanged);
            // 
            // nivel
            // 
            this.nivel.Location = new System.Drawing.Point(173, 175);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(322, 22);
            this.nivel.TabIndex = 8;
            // 
            // vulnerabilitate
            // 
            this.vulnerabilitate.Location = new System.Drawing.Point(173, 135);
            this.vulnerabilitate.Name = "vulnerabilitate";
            this.vulnerabilitate.Size = new System.Drawing.Size(322, 22);
            this.vulnerabilitate.TabIndex = 9;
            // 
            // tabelVulnerabilitati
            // 
            this.tabelVulnerabilitati.ColumnHeadersHeight = 29;
            this.tabelVulnerabilitati.Location = new System.Drawing.Point(34, 277);
            this.tabelVulnerabilitati.Name = "tabelVulnerabilitati";
            this.tabelVulnerabilitati.RowHeadersWidth = 51;
            this.tabelVulnerabilitati.RowTemplate.Height = 24;
            this.tabelVulnerabilitati.Size = new System.Drawing.Size(461, 235);
            this.tabelVulnerabilitati.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(350, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 40);
            this.button3.TabIndex = 25;
            this.button3.Text = "ACTUALIZEAZĂ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(199, 231);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(145, 40);
            this.delete.TabIndex = 24;
            this.delete.Text = "ȘTERGE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.insert.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(31, 231);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(145, 40);
            this.insert.TabIndex = 23;
            this.insert.Text = "INSEREAZĂ";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // codBun
            // 
            this.codBun.FormattingEnabled = true;
            this.codBun.Location = new System.Drawing.Point(173, 90);
            this.codBun.Name = "codBun";
            this.codBun.Size = new System.Drawing.Size(322, 24);
            this.codBun.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 142);
            this.panel1.TabIndex = 27;
            // 
            // importExcelToolStripMenuItem
            // 
            this.importExcelToolStripMenuItem.Name = "importExcelToolStripMenuItem";
            this.importExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importExcelToolStripMenuItem.Text = "Import Excel";
            this.importExcelToolStripMenuItem.Click += new System.EventHandler(this.importExcelToolStripMenuItem_Click);
            // 
            // Vulnerabilitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(521, 541);
            this.Controls.Add(this.codBun);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.tabelVulnerabilitati);
            this.Controls.Add(this.vulnerabilitate);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Vulnerabilitati";
            this.Text = "Identificare vulnerabilitati";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelVulnerabilitati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cautare;
        private System.Windows.Forms.TextBox nivel;
        private System.Windows.Forms.TextBox vulnerabilitate;
        private System.Windows.Forms.DataGridView tabelVulnerabilitati;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ComboBox codBun;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem importExcelToolStripMenuItem;
    }
}