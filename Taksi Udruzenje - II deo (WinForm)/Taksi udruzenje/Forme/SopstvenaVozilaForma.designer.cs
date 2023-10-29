namespace Taksi_udruzenje.Forme
{
    partial class SopstvenaVozilaForma
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
            this.sopVozila = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajSopVozilo = new System.Windows.Forms.Button();
            this.btnAzurirajVozilo = new System.Windows.Forms.Button();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sopVozila);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sopstvena vozila";
            // 
            // sopVozila
            // 
            this.sopVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.sopVozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sopVozila.FullRowSelect = true;
            this.sopVozila.GridLines = true;
            this.sopVozila.HideSelection = false;
            this.sopVozila.Location = new System.Drawing.Point(3, 16);
            this.sopVozila.Name = "sopVozila";
            this.sopVozila.Size = new System.Drawing.Size(499, 263);
            this.sopVozila.TabIndex = 0;
            this.sopVozila.UseCompatibleStateImageBehavior = false;
            this.sopVozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 69;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Boja";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 67;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DatumOd";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DatumDo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 121;
            // 
            // btnDodajSopVozilo
            // 
            this.btnDodajSopVozilo.BackColor = System.Drawing.Color.Lime;
            this.btnDodajSopVozilo.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSopVozilo.Location = new System.Drawing.Point(16, 19);
            this.btnDodajSopVozilo.Name = "btnDodajSopVozilo";
            this.btnDodajSopVozilo.Size = new System.Drawing.Size(183, 64);
            this.btnDodajSopVozilo.TabIndex = 32;
            this.btnDodajSopVozilo.Text = "Dodaj sopstveno vozilo";
            this.btnDodajSopVozilo.UseVisualStyleBackColor = false;
            this.btnDodajSopVozilo.Click += new System.EventHandler(this.btnDodajSopVozilo_Click);
            // 
            // btnAzurirajVozilo
            // 
            this.btnAzurirajVozilo.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajVozilo.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajVozilo.Location = new System.Drawing.Point(16, 101);
            this.btnAzurirajVozilo.Name = "btnAzurirajVozilo";
            this.btnAzurirajVozilo.Size = new System.Drawing.Size(183, 65);
            this.btnAzurirajVozilo.TabIndex = 33;
            this.btnAzurirajVozilo.Text = "Azuriraj sopstveno vozilo";
            this.btnAzurirajVozilo.UseVisualStyleBackColor = false;
            this.btnAzurirajVozilo.Click += new System.EventHandler(this.btnAzurirajVozilo_Click);
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiVozilo.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiVozilo.Location = new System.Drawing.Point(16, 181);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(183, 65);
            this.btnObrisiVozilo.TabIndex = 34;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = false;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiVozilo);
            this.groupBox2.Controls.Add(this.btnAzurirajVozilo);
            this.groupBox2.Controls.Add(this.btnDodajSopVozilo);
            this.groupBox2.Location = new System.Drawing.Point(548, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 263);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // SopstvenaVozilaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(782, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SopstvenaVozilaForma";
            this.Text = "SOPSTVENA VOZILA ";
            this.Load += new System.EventHandler(this.VozaciForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView sopVozila;
        private System.Windows.Forms.Button btnDodajSopVozilo;
        private System.Windows.Forms.Button btnAzurirajVozilo;
        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}