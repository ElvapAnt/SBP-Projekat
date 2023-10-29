namespace Taksi_udruzenje.Forme
{
    partial class TaxiVozilaForma
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
            this.taxiVozila = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajTaxiVozilo = new System.Windows.Forms.Button();
            this.btnAzurirajTaxiVozilo = new System.Windows.Forms.Button();
            this.btnObrisiTaxiVozilo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodeliTaxiVozilo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taxiVozila);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taxi vozila";
            // 
            // taxiVozila
            // 
            this.taxiVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.taxiVozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxiVozila.FullRowSelect = true;
            this.taxiVozila.GridLines = true;
            this.taxiVozila.HideSelection = false;
            this.taxiVozila.Location = new System.Drawing.Point(3, 16);
            this.taxiVozila.Name = "taxiVozila";
            this.taxiVozila.Size = new System.Drawing.Size(524, 311);
            this.taxiVozila.TabIndex = 0;
            this.taxiVozila.UseCompatibleStateImageBehavior = false;
            this.taxiVozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Registracione tablice";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 63;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Datum isteka registracije";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Godina proizvodnje";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 121;
            // 
            // btnDodajTaxiVozilo
            // 
            this.btnDodajTaxiVozilo.BackColor = System.Drawing.Color.Lime;
            this.btnDodajTaxiVozilo.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTaxiVozilo.Location = new System.Drawing.Point(16, 19);
            this.btnDodajTaxiVozilo.Name = "btnDodajTaxiVozilo";
            this.btnDodajTaxiVozilo.Size = new System.Drawing.Size(183, 64);
            this.btnDodajTaxiVozilo.TabIndex = 32;
            this.btnDodajTaxiVozilo.Text = "Dodaj novo taxi vozilo";
            this.btnDodajTaxiVozilo.UseVisualStyleBackColor = false;
            this.btnDodajTaxiVozilo.Click += new System.EventHandler(this.btnDodajSopVozilo_Click);
            // 
            // btnAzurirajTaxiVozilo
            // 
            this.btnAzurirajTaxiVozilo.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajTaxiVozilo.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajTaxiVozilo.Location = new System.Drawing.Point(16, 89);
            this.btnAzurirajTaxiVozilo.Name = "btnAzurirajTaxiVozilo";
            this.btnAzurirajTaxiVozilo.Size = new System.Drawing.Size(183, 65);
            this.btnAzurirajTaxiVozilo.TabIndex = 33;
            this.btnAzurirajTaxiVozilo.Text = "Azuriraj postojece taxi vozilo";
            this.btnAzurirajTaxiVozilo.UseVisualStyleBackColor = false;
            this.btnAzurirajTaxiVozilo.Click += new System.EventHandler(this.btnAzurirajVozilo_Click);
            // 
            // btnObrisiTaxiVozilo
            // 
            this.btnObrisiTaxiVozilo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiTaxiVozilo.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTaxiVozilo.Location = new System.Drawing.Point(16, 160);
            this.btnObrisiTaxiVozilo.Name = "btnObrisiTaxiVozilo";
            this.btnObrisiTaxiVozilo.Size = new System.Drawing.Size(183, 65);
            this.btnObrisiTaxiVozilo.TabIndex = 34;
            this.btnObrisiTaxiVozilo.Text = "Obrisi taxi vozilo";
            this.btnObrisiTaxiVozilo.UseVisualStyleBackColor = false;
            this.btnObrisiTaxiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodeliTaxiVozilo);
            this.groupBox2.Controls.Add(this.btnObrisiTaxiVozilo);
            this.groupBox2.Controls.Add(this.btnAzurirajTaxiVozilo);
            this.groupBox2.Controls.Add(this.btnDodajTaxiVozilo);
            this.groupBox2.Location = new System.Drawing.Point(548, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 330);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // btnDodeliTaxiVozilo
            // 
            this.btnDodeliTaxiVozilo.BackColor = System.Drawing.Color.Aqua;
            this.btnDodeliTaxiVozilo.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodeliTaxiVozilo.Location = new System.Drawing.Point(16, 231);
            this.btnDodeliTaxiVozilo.Name = "btnDodeliTaxiVozilo";
            this.btnDodeliTaxiVozilo.Size = new System.Drawing.Size(183, 69);
            this.btnDodeliTaxiVozilo.TabIndex = 35;
            this.btnDodeliTaxiVozilo.Text = "Dodeli taxi vozilo";
            this.btnDodeliTaxiVozilo.UseVisualStyleBackColor = false;
            this.btnDodeliTaxiVozilo.Click += new System.EventHandler(this.btnDodeliTaxiVozilo_Click);
            // 
            // TaxiVozilaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(782, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaxiVozilaForma";
            this.Text = "TAXI VOZILA";
            this.Load += new System.EventHandler(this.TaxiVozilaForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView taxiVozila;
        private System.Windows.Forms.Button btnDodajTaxiVozilo;
        private System.Windows.Forms.Button btnAzurirajTaxiVozilo;
        private System.Windows.Forms.Button btnObrisiTaxiVozilo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDodeliTaxiVozilo;
    }
}