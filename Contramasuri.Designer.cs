namespace RISK
{
    partial class Contramasuri
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
            this.reîmprospătareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metTratare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categContramasuri = new System.Windows.Forms.TextBox();
            this.tratat = new System.Windows.Forms.ComboBox();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.tabelContramasuri = new System.Windows.Forms.DataGridView();
            this.codRisc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.importExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelContramasuri)).BeginInit();
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
            this.reîmprospătareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 28);
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
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
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
            this.istoricToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.istoricToolStripMenuItem.Text = "Istoric";
            this.istoricToolStripMenuItem.Click += new System.EventHandler(this.istoricToolStripMenuItem_Click);
            // 
            // reîmprospătareToolStripMenuItem
            // 
            this.reîmprospătareToolStripMenuItem.Name = "reîmprospătareToolStripMenuItem";
            this.reîmprospătareToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.reîmprospătareToolStripMenuItem.Text = "Reîmprospătare";
            this.reîmprospătareToolStripMenuItem.Click += new System.EventHandler(this.reîmprospătareToolStripMenuItem_Click);
            // 
            // cautare
            // 
            this.cautare.Location = new System.Drawing.Point(230, 44);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(394, 22);
            this.cautare.TabIndex = 11;
            this.cautare.TextChanged += new System.EventHandler(this.cautare_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cautare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cod risc";
            // 
            // metTratare
            // 
            this.metTratare.Location = new System.Drawing.Point(218, 51);
            this.metTratare.Name = "metTratare";
            this.metTratare.Size = new System.Drawing.Size(394, 22);
            this.metTratare.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Metoda de tratare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Categorie contramasuri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tratat";
            // 
            // categContramasuri
            // 
            this.categContramasuri.Location = new System.Drawing.Point(218, 89);
            this.categContramasuri.Name = "categContramasuri";
            this.categContramasuri.Size = new System.Drawing.Size(394, 22);
            this.categContramasuri.TabIndex = 18;
            // 
            // tratat
            // 
            this.tratat.FormattingEnabled = true;
            this.tratat.Items.AddRange(new object[] {
            "DA",
            "NU"});
            this.tratat.Location = new System.Drawing.Point(218, 125);
            this.tratat.Name = "tratat";
            this.tratat.Size = new System.Drawing.Size(394, 24);
            this.tratat.TabIndex = 19;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.insert.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(31, 274);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(145, 40);
            this.insert.TabIndex = 20;
            this.insert.Text = "INSEREAZĂ";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(272, 274);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(145, 40);
            this.delete.TabIndex = 21;
            this.delete.Text = "ȘTERGE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.update.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(495, 274);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(145, 40);
            this.update.TabIndex = 22;
            this.update.Text = "ACTUALIZEAZĂ";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // tabelContramasuri
            // 
            this.tabelContramasuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelContramasuri.Location = new System.Drawing.Point(31, 320);
            this.tabelContramasuri.Name = "tabelContramasuri";
            this.tabelContramasuri.RowHeadersWidth = 51;
            this.tabelContramasuri.RowTemplate.Height = 24;
            this.tabelContramasuri.Size = new System.Drawing.Size(609, 177);
            this.tabelContramasuri.TabIndex = 23;
            // 
            // codRisc
            // 
            this.codRisc.FormattingEnabled = true;
            this.codRisc.Location = new System.Drawing.Point(218, 13);
            this.codRisc.Name = "codRisc";
            this.codRisc.Size = new System.Drawing.Size(394, 24);
            this.codRisc.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.codRisc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.metTratare);
            this.panel1.Controls.Add(this.tratat);
            this.panel1.Controls.Add(this.categContramasuri);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 165);
            this.panel1.TabIndex = 25;
            // 
            // importExcelToolStripMenuItem
            // 
            this.importExcelToolStripMenuItem.Name = "importExcelToolStripMenuItem";
            this.importExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importExcelToolStripMenuItem.Text = "Import Excel";
            this.importExcelToolStripMenuItem.Click += new System.EventHandler(this.importExcelToolStripMenuItem_Click);
            // 
            // Contramasuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(672, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.tabelContramasuri);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Contramasuri";
            this.Text = "Tratare riscuri si identificare contramasuri";
            this.Load += new System.EventHandler(this.Contramasuri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelContramasuri)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricToolStripMenuItem;
        private System.Windows.Forms.TextBox cautare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox metTratare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categContramasuri;
        private System.Windows.Forms.ComboBox tratat;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView tabelContramasuri;
        private System.Windows.Forms.ToolStripMenuItem reîmprospătareToolStripMenuItem;
        private System.Windows.Forms.ComboBox codRisc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem importExcelToolStripMenuItem;
    }
}