namespace Taksi_udruzenje.Forme
{
    partial class VozaciForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vozaci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajNovogVozaca = new System.Windows.Forms.Button();
            this.btnAzurirajVozaca = new System.Windows.Forms.Button();
            this.btnObrisiVozaca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodeliVozacuVozilo = new System.Windows.Forms.Button();
            this.btnVoznjeObavioVozac = new System.Windows.Forms.Button();
            this.btnPrikaziSopVozila = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vozaci);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozaci";
            // 
            // vozaci
            // 
            this.vozaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader2});
            this.vozaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vozaci.FullRowSelect = true;
            this.vozaci.GridLines = true;
            this.vozaci.HideSelection = false;
            this.vozaci.Location = new System.Drawing.Point(3, 16);
            this.vozaci.Name = "vozaci";
            this.vozaci.Size = new System.Drawing.Size(750, 432);
            this.vozaci.TabIndex = 0;
            this.vozaci.UseCompatibleStateImageBehavior = false;
            this.vozaci.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JMBG";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategorija";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Srednje Slovo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prezime";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adresa";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Broj Telefona";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Broj Dozvole";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 107;
            // 
            // btnDodajNovogVozaca
            // 
            this.btnDodajNovogVozaca.BackColor = System.Drawing.Color.Lime;
            this.btnDodajNovogVozaca.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovogVozaca.Location = new System.Drawing.Point(16, 19);
            this.btnDodajNovogVozaca.Name = "btnDodajNovogVozaca";
            this.btnDodajNovogVozaca.Size = new System.Drawing.Size(183, 54);
            this.btnDodajNovogVozaca.TabIndex = 32;
            this.btnDodajNovogVozaca.Text = "Dodaj novog vozaca";
            this.btnDodajNovogVozaca.UseVisualStyleBackColor = false;
            this.btnDodajNovogVozaca.Click += new System.EventHandler(this.btnDodajNovogVozaca_Click);
            // 
            // btnAzurirajVozaca
            // 
            this.btnAzurirajVozaca.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajVozaca.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajVozaca.Location = new System.Drawing.Point(16, 79);
            this.btnAzurirajVozaca.Name = "btnAzurirajVozaca";
            this.btnAzurirajVozaca.Size = new System.Drawing.Size(183, 56);
            this.btnAzurirajVozaca.TabIndex = 33;
            this.btnAzurirajVozaca.Text = "Azuriraj vozaca";
            this.btnAzurirajVozaca.UseVisualStyleBackColor = false;
            this.btnAzurirajVozaca.Click += new System.EventHandler(this.btnAzurirajVozaca_Click);
            // 
            // btnObrisiVozaca
            // 
            this.btnObrisiVozaca.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiVozaca.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiVozaca.Location = new System.Drawing.Point(16, 141);
            this.btnObrisiVozaca.Name = "btnObrisiVozaca";
            this.btnObrisiVozaca.Size = new System.Drawing.Size(183, 53);
            this.btnObrisiVozaca.TabIndex = 34;
            this.btnObrisiVozaca.Text = "Obrisi vozaca";
            this.btnObrisiVozaca.UseVisualStyleBackColor = false;
            this.btnObrisiVozaca.Click += new System.EventHandler(this.btnObrisiVozaca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodeliVozacuVozilo);
            this.groupBox2.Controls.Add(this.btnVoznjeObavioVozac);
            this.groupBox2.Controls.Add(this.btnPrikaziSopVozila);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnObrisiVozaca);
            this.groupBox2.Controls.Add(this.btnAzurirajVozaca);
            this.groupBox2.Controls.Add(this.btnDodajNovogVozaca);
            this.groupBox2.Location = new System.Drawing.Point(803, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 448);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // btnDodeliVozacuVozilo
            // 
            this.btnDodeliVozacuVozilo.BackColor = System.Drawing.Color.Yellow;
            this.btnDodeliVozacuVozilo.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodeliVozacuVozilo.Location = new System.Drawing.Point(16, 394);
            this.btnDodeliVozacuVozilo.Name = "btnDodeliVozacuVozilo";
            this.btnDodeliVozacuVozilo.Size = new System.Drawing.Size(183, 48);
            this.btnDodeliVozacuVozilo.TabIndex = 39;
            this.btnDodeliVozacuVozilo.Text = "Dodeli vozacu taxi vozilo";
            this.btnDodeliVozacuVozilo.UseVisualStyleBackColor = false;
            this.btnDodeliVozacuVozilo.Click += new System.EventHandler(this.btnDodeliVozacuVozilo_Click);
            // 
            // btnVoznjeObavioVozac
            // 
            this.btnVoznjeObavioVozac.BackColor = System.Drawing.Color.Silver;
            this.btnVoznjeObavioVozac.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoznjeObavioVozac.Location = new System.Drawing.Point(16, 335);
            this.btnVoznjeObavioVozac.Name = "btnVoznjeObavioVozac";
            this.btnVoznjeObavioVozac.Size = new System.Drawing.Size(183, 53);
            this.btnVoznjeObavioVozac.TabIndex = 38;
            this.btnVoznjeObavioVozac.Text = "Voznje koje je obavio vozac";
            this.btnVoznjeObavioVozac.UseVisualStyleBackColor = false;
            this.btnVoznjeObavioVozac.Click += new System.EventHandler(this.btnVoznjeObavioVozac_Click);
            // 
            // btnPrikaziSopVozila
            // 
            this.btnPrikaziSopVozila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrikaziSopVozila.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziSopVozila.Location = new System.Drawing.Point(16, 265);
            this.btnPrikaziSopVozila.Name = "btnPrikaziSopVozila";
            this.btnPrikaziSopVozila.Size = new System.Drawing.Size(183, 64);
            this.btnPrikaziSopVozila.TabIndex = 36;
            this.btnPrikaziSopVozila.Text = "Prikazi sopstvena vozila vozaca";
            this.btnPrikaziSopVozila.UseVisualStyleBackColor = false;
            this.btnPrikaziSopVozila.Click += new System.EventHandler(this.btnPrikaziSopVozila_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 59);
            this.button1.TabIndex = 37;
            this.button1.Text = "Prikazi sva sopstvena vozila";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VozaciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1040, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VozaciForma";
            this.Text = "ZAPOSLENI - VOZACI";
            this.Load += new System.EventHandler(this.VozaciForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView vozaci;
        private System.Windows.Forms.Button btnDodajNovogVozaca;
        private System.Windows.Forms.Button btnAzurirajVozaca;
        private System.Windows.Forms.Button btnObrisiVozaca;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnPrikaziSopVozila;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVoznjeObavioVozac;
        private System.Windows.Forms.Button btnDodeliVozacuVozilo;
    }
}