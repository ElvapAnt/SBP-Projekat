namespace Taksi_udruzenje.Forme
{
    partial class AdministrativnoOsobljeForma
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
            this.admini = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajNovogAdmina = new System.Windows.Forms.Button();
            this.btnAzurirajAdmina = new System.Windows.Forms.Button();
            this.btnObrisiAdmina = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVratiVoznjaAdmina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.admini);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrativno osoblje";
            // 
            // admini
            // 
            this.admini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.admini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admini.FullRowSelect = true;
            this.admini.GridLines = true;
            this.admini.HideSelection = false;
            this.admini.Location = new System.Drawing.Point(3, 16);
            this.admini.Name = "admini";
            this.admini.Size = new System.Drawing.Size(689, 321);
            this.admini.TabIndex = 0;
            this.admini.UseCompatibleStateImageBehavior = false;
            this.admini.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JMBG";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Srednje Slovo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 85;
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
            this.columnHeader8.Text = "Strucna Sprema";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 107;
            // 
            // btnDodajNovogAdmina
            // 
            this.btnDodajNovogAdmina.BackColor = System.Drawing.Color.Lime;
            this.btnDodajNovogAdmina.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovogAdmina.Location = new System.Drawing.Point(16, 31);
            this.btnDodajNovogAdmina.Name = "btnDodajNovogAdmina";
            this.btnDodajNovogAdmina.Size = new System.Drawing.Size(183, 64);
            this.btnDodajNovogAdmina.TabIndex = 32;
            this.btnDodajNovogAdmina.Text = "Dodaj novog admina";
            this.btnDodajNovogAdmina.UseVisualStyleBackColor = false;
            this.btnDodajNovogAdmina.Click += new System.EventHandler(this.btnDodajNovogAdmina_Click);
            // 
            // btnAzurirajAdmina
            // 
            this.btnAzurirajAdmina.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajAdmina.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajAdmina.Location = new System.Drawing.Point(16, 101);
            this.btnAzurirajAdmina.Name = "btnAzurirajAdmina";
            this.btnAzurirajAdmina.Size = new System.Drawing.Size(183, 65);
            this.btnAzurirajAdmina.TabIndex = 33;
            this.btnAzurirajAdmina.Text = "Azuriraj admina";
            this.btnAzurirajAdmina.UseVisualStyleBackColor = false;
            this.btnAzurirajAdmina.Click += new System.EventHandler(this.btnAzurirajAdmina_Click);
            // 
            // btnObrisiAdmina
            // 
            this.btnObrisiAdmina.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiAdmina.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiAdmina.Location = new System.Drawing.Point(16, 172);
            this.btnObrisiAdmina.Name = "btnObrisiAdmina";
            this.btnObrisiAdmina.Size = new System.Drawing.Size(183, 65);
            this.btnObrisiAdmina.TabIndex = 34;
            this.btnObrisiAdmina.Text = "Obrisi administrativno osoblje";
            this.btnObrisiAdmina.UseVisualStyleBackColor = false;
            this.btnObrisiAdmina.Click += new System.EventHandler(this.btnObrisiAdmina_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVratiVoznjaAdmina);
            this.groupBox2.Controls.Add(this.btnObrisiAdmina);
            this.groupBox2.Controls.Add(this.btnAzurirajAdmina);
            this.groupBox2.Controls.Add(this.btnDodajNovogAdmina);
            this.groupBox2.Location = new System.Drawing.Point(721, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 337);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // btnVratiVoznjaAdmina
            // 
            this.btnVratiVoznjaAdmina.BackColor = System.Drawing.Color.Silver;
            this.btnVratiVoznjaAdmina.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiVoznjaAdmina.Location = new System.Drawing.Point(17, 243);
            this.btnVratiVoznjaAdmina.Name = "btnVratiVoznjaAdmina";
            this.btnVratiVoznjaAdmina.Size = new System.Drawing.Size(182, 61);
            this.btnVratiVoznjaAdmina.TabIndex = 35;
            this.btnVratiVoznjaAdmina.Text = "Sve voznje admina";
            this.btnVratiVoznjaAdmina.UseVisualStyleBackColor = false;
            this.btnVratiVoznjaAdmina.Click += new System.EventHandler(this.btnVratiVoznjaAdmina_Click);
            // 
            // AdministrativnoOsobljeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(953, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrativnoOsobljeForma";
            this.Text = "ZAPOSLENI - ADMINISTRATIVNO OSOBLJE";
            this.Load += new System.EventHandler(this.AdminOsobljeForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView admini;
        private System.Windows.Forms.Button btnDodajNovogAdmina;
        private System.Windows.Forms.Button btnAzurirajAdmina;
        private System.Windows.Forms.Button btnObrisiAdmina;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVratiVoznjaAdmina;
    }
}