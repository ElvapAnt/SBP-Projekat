namespace Taksi_udruzenje.Forme
{
    partial class SveDodeljenoForma
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
            this.dodeljeno = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajDodeljeno = new System.Windows.Forms.Button();
            this.btnPrikaziDodeljenoTaxi = new System.Windows.Forms.Button();
            this.btnPrikaziDodeljenoVozac = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziTrenutnoVozilo = new System.Windows.Forms.Button();
            this.txtJmbgVozaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziTrenutniVozac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegOznaka = new System.Windows.Forms.TextBox();
            this.btnAzurirajDodeljeno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodeljeno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodeljeno";
            // 
            // dodeljeno
            // 
            this.dodeljeno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader4});
            this.dodeljeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dodeljeno.FullRowSelect = true;
            this.dodeljeno.GridLines = true;
            this.dodeljeno.HideSelection = false;
            this.dodeljeno.Location = new System.Drawing.Point(3, 16);
            this.dodeljeno.Name = "dodeljeno";
            this.dodeljeno.Size = new System.Drawing.Size(524, 503);
            this.dodeljeno.TabIndex = 0;
            this.dodeljeno.UseCompatibleStateImageBehavior = false;
            this.dodeljeno.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 69;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Registracija Taxi vozila";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "JMBG Vozaca";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DatumOd";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DatumDo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 99;
            // 
            // btnDodajDodeljeno
            // 
            this.btnDodajDodeljeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDodajDodeljeno.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDodeljeno.Location = new System.Drawing.Point(16, 19);
            this.btnDodajDodeljeno.Name = "btnDodajDodeljeno";
            this.btnDodajDodeljeno.Size = new System.Drawing.Size(184, 57);
            this.btnDodajDodeljeno.TabIndex = 32;
            this.btnDodajDodeljeno.Text = "Sacuvaj novi dodeljeno odnos";
            this.btnDodajDodeljeno.UseVisualStyleBackColor = false;
            this.btnDodajDodeljeno.Click += new System.EventHandler(this.btnDodajDodeljeno_Click);
            // 
            // btnPrikaziDodeljenoTaxi
            // 
            this.btnPrikaziDodeljenoTaxi.BackColor = System.Drawing.Color.Yellow;
            this.btnPrikaziDodeljenoTaxi.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDodeljenoTaxi.Location = new System.Drawing.Point(6, 61);
            this.btnPrikaziDodeljenoTaxi.Name = "btnPrikaziDodeljenoTaxi";
            this.btnPrikaziDodeljenoTaxi.Size = new System.Drawing.Size(179, 58);
            this.btnPrikaziDodeljenoTaxi.TabIndex = 33;
            this.btnPrikaziDodeljenoTaxi.Text = "Prikazi dodeljeno sa taxi vozilom";
            this.btnPrikaziDodeljenoTaxi.UseVisualStyleBackColor = false;
            this.btnPrikaziDodeljenoTaxi.Click += new System.EventHandler(this.btnPrikaziDodeljenoTaxi_Click);
            // 
            // btnPrikaziDodeljenoVozac
            // 
            this.btnPrikaziDodeljenoVozac.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPrikaziDodeljenoVozac.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDodeljenoVozac.Location = new System.Drawing.Point(9, 61);
            this.btnPrikaziDodeljenoVozac.Name = "btnPrikaziDodeljenoVozac";
            this.btnPrikaziDodeljenoVozac.Size = new System.Drawing.Size(183, 58);
            this.btnPrikaziDodeljenoVozac.TabIndex = 34;
            this.btnPrikaziDodeljenoVozac.Text = "Prikazi dodeljeno sa vozacem";
            this.btnPrikaziDodeljenoVozac.UseVisualStyleBackColor = false;
            this.btnPrikaziDodeljenoVozac.Click += new System.EventHandler(this.btnPrikaziDodeljenoVozac_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAzurirajDodeljeno);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnDodajDodeljeno);
            this.groupBox2.Location = new System.Drawing.Point(548, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 522);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrikaziTrenutnoVozilo);
            this.groupBox3.Controls.Add(this.btnPrikaziDodeljenoVozac);
            this.groupBox3.Controls.Add(this.txtJmbgVozaca);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(10, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 183);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vozac";
            // 
            // btnPrikaziTrenutnoVozilo
            // 
            this.btnPrikaziTrenutnoVozilo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPrikaziTrenutnoVozilo.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziTrenutnoVozilo.Location = new System.Drawing.Point(9, 125);
            this.btnPrikaziTrenutnoVozilo.Name = "btnPrikaziTrenutnoVozilo";
            this.btnPrikaziTrenutnoVozilo.Size = new System.Drawing.Size(183, 52);
            this.btnPrikaziTrenutnoVozilo.TabIndex = 37;
            this.btnPrikaziTrenutnoVozilo.Text = "Prikazi trenutno vozilo";
            this.btnPrikaziTrenutnoVozilo.UseVisualStyleBackColor = false;
            this.btnPrikaziTrenutnoVozilo.Click += new System.EventHandler(this.btnPrikaziTrenutnoVozilo_Click);
            // 
            // txtJmbgVozaca
            // 
            this.txtJmbgVozaca.Location = new System.Drawing.Point(9, 35);
            this.txtJmbgVozaca.Name = "txtJmbgVozaca";
            this.txtJmbgVozaca.Size = new System.Drawing.Size(183, 20);
            this.txtJmbgVozaca.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "JMBG Vozaca :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPrikaziTrenutniVozac);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtRegOznaka);
            this.groupBox4.Controls.Add(this.btnPrikaziDodeljenoTaxi);
            this.groupBox4.Location = new System.Drawing.Point(15, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 183);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Taxi vozilo";
            // 
            // btnPrikaziTrenutniVozac
            // 
            this.btnPrikaziTrenutniVozac.BackColor = System.Drawing.Color.Yellow;
            this.btnPrikaziTrenutniVozac.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziTrenutniVozac.Location = new System.Drawing.Point(6, 125);
            this.btnPrikaziTrenutniVozac.Name = "btnPrikaziTrenutniVozac";
            this.btnPrikaziTrenutniVozac.Size = new System.Drawing.Size(179, 52);
            this.btnPrikaziTrenutniVozac.TabIndex = 39;
            this.btnPrikaziTrenutniVozac.Text = "Prikazi trenutnog vozaca";
            this.btnPrikaziTrenutniVozac.UseVisualStyleBackColor = false;
            this.btnPrikaziTrenutniVozac.Click += new System.EventHandler(this.btnPrikaziTrenutniVozac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Reg. oznaka vozila :";
            // 
            // txtRegOznaka
            // 
            this.txtRegOznaka.Location = new System.Drawing.Point(6, 35);
            this.txtRegOznaka.Name = "txtRegOznaka";
            this.txtRegOznaka.Size = new System.Drawing.Size(179, 20);
            this.txtRegOznaka.TabIndex = 37;
            // 
            // btnAzurirajDodeljeno
            // 
            this.btnAzurirajDodeljeno.BackColor = System.Drawing.Color.Lime;
            this.btnAzurirajDodeljeno.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajDodeljeno.Location = new System.Drawing.Point(18, 88);
            this.btnAzurirajDodeljeno.Name = "btnAzurirajDodeljeno";
            this.btnAzurirajDodeljeno.Size = new System.Drawing.Size(181, 54);
            this.btnAzurirajDodeljeno.TabIndex = 40;
            this.btnAzurirajDodeljeno.Text = "Azuriraj dodeljeno odnos";
            this.btnAzurirajDodeljeno.UseVisualStyleBackColor = false;
            this.btnAzurirajDodeljeno.Click += new System.EventHandler(this.btnAzurirajDodeljeno_Click);
            // 
            // SveDodeljenoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(782, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SveDodeljenoForma";
            this.Text = "DODELJENO";
            this.Load += new System.EventHandler(this.SveDodeljenoForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView dodeljeno;
        private System.Windows.Forms.Button btnDodajDodeljeno;
        private System.Windows.Forms.Button btnPrikaziDodeljenoTaxi;
        private System.Windows.Forms.Button btnPrikaziDodeljenoVozac;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegOznaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJmbgVozaca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrikaziTrenutnoVozilo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrikaziTrenutniVozac;
        private System.Windows.Forms.Button btnAzurirajDodeljeno;
    }
}