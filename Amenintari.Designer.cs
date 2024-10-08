namespace RISK
{
    partial class Amenintari
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
            this.cautare = new System.Windows.Forms.TextBox();
            this.amenintare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.tabelAmenintari = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.codBun = new System.Windows.Forms.ComboBox();
            this.nivMin = new System.Windows.Forms.NumericUpDown();
            this.nivMax = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.importExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelAmenintari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivMax)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(694, 28);
            this.menuStrip1.TabIndex = 1;
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
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Căutare";
            // 
            // cautare
            // 
            this.cautare.Location = new System.Drawing.Point(170, 50);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(485, 22);
            this.cautare.TabIndex = 3;
            this.cautare.TextChanged += new System.EventHandler(this.cautare_TextChanged);
            // 
            // amenintare
            // 
            this.amenintare.Location = new System.Drawing.Point(158, 45);
            this.amenintare.Name = "amenintare";
            this.amenintare.Size = new System.Drawing.Size(485, 22);
            this.amenintare.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amenintari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cod bun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nivel minim";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.insert.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(46, 263);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(177, 40);
            this.insert.TabIndex = 10;
            this.insert.Text = "INSEREAZĂ";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(264, 263);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(177, 40);
            this.delete.TabIndex = 11;
            this.delete.Text = "ȘTERGE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.update.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(478, 263);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(177, 40);
            this.update.TabIndex = 12;
            this.update.Text = "ACTUALIZEAZĂ";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // tabelAmenintari
            // 
            this.tabelAmenintari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelAmenintari.Location = new System.Drawing.Point(46, 309);
            this.tabelAmenintari.Name = "tabelAmenintari";
            this.tabelAmenintari.RowHeadersWidth = 51;
            this.tabelAmenintari.RowTemplate.Height = 24;
            this.tabelAmenintari.Size = new System.Drawing.Size(609, 287);
            this.tabelAmenintari.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nivel maxim";
            // 
            // codBun
            // 
            this.codBun.FormattingEnabled = true;
            this.codBun.Location = new System.Drawing.Point(158, 11);
            this.codBun.Name = "codBun";
            this.codBun.Size = new System.Drawing.Size(485, 24);
            this.codBun.TabIndex = 16;
            // 
            // nivMin
            // 
            this.nivMin.Location = new System.Drawing.Point(158, 77);
            this.nivMin.Name = "nivMin";
            this.nivMin.Size = new System.Drawing.Size(485, 22);
            this.nivMin.TabIndex = 17;
            // 
            // nivMax
            // 
            this.nivMax.Location = new System.Drawing.Point(158, 111);
            this.nivMax.Name = "nivMax";
            this.nivMax.Size = new System.Drawing.Size(485, 22);
            this.nivMax.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nivMax);
            this.panel1.Controls.Add(this.codBun);
            this.panel1.Controls.Add(this.nivMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.amenintare);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 150);
            this.panel1.TabIndex = 19;
            // 
            // importExcelToolStripMenuItem
            // 
            this.importExcelToolStripMenuItem.Name = "importExcelToolStripMenuItem";
            this.importExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importExcelToolStripMenuItem.Text = "Import Excel";
            this.importExcelToolStripMenuItem.Click += new System.EventHandler(this.importExcelToolStripMenuItem_Click);
            // 
            // Amenintari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(694, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabelAmenintari);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Amenintari";
            this.Text = "Identificare amenintari";
            this.Load += new System.EventHandler(this.Amenintari_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelAmenintari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivMax)).EndInit();
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
        private System.Windows.Forms.TextBox cautare;
        private System.Windows.Forms.TextBox amenintare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView tabelAmenintari;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem reîmprospatareToolStripMenuItem;
        private System.Windows.Forms.ComboBox codBun;
        private System.Windows.Forms.NumericUpDown nivMin;
        private System.Windows.Forms.NumericUpDown nivMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem importExcelToolStripMenuItem;
    }
}