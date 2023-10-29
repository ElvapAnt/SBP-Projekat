namespace Taksi_udruzenje.Forme
{
    partial class SviZaposleniForma
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
            this.zaposleni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdmini = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBrojZaposlenih = new System.Windows.Forms.TextBox();
            this.btnVozaci = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zaposleni);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposleni taxi udruzenja";
            // 
            // zaposleni
            // 
            this.zaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.zaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zaposleni.FullRowSelect = true;
            this.zaposleni.GridLines = true;
            this.zaposleni.HideSelection = false;
            this.zaposleni.Location = new System.Drawing.Point(3, 16);
            this.zaposleni.Name = "zaposleni";
            this.zaposleni.Size = new System.Drawing.Size(793, 390);
            this.zaposleni.TabIndex = 1;
            this.zaposleni.UseCompatibleStateImageBehavior = false;
            this.zaposleni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JMBG";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Srednje Slovo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj Telefona";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip Zaposlenog";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 150;
            // 
            // btnAdmini
            // 
            this.btnAdmini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdmini.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAdmini.Location = new System.Drawing.Point(30, 114);
            this.btnAdmini.Name = "btnAdmini";
            this.btnAdmini.Size = new System.Drawing.Size(221, 85);
            this.btnAdmini.TabIndex = 1;
            this.btnAdmini.Text = "Administrativno osoblje";
            this.btnAdmini.UseVisualStyleBackColor = false;
            this.btnAdmini.Click += new System.EventHandler(this.btnAdmini_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Ukupan broj zaposlenih:";
            // 
            // txbBrojZaposlenih
            // 
            this.txbBrojZaposlenih.Location = new System.Drawing.Point(184, 67);
            this.txbBrojZaposlenih.Name = "txbBrojZaposlenih";
            this.txbBrojZaposlenih.ReadOnly = true;
            this.txbBrojZaposlenih.Size = new System.Drawing.Size(67, 20);
            this.txbBrojZaposlenih.TabIndex = 49;
            this.txbBrojZaposlenih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVozaci
            // 
            this.btnVozaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVozaci.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozaci.Location = new System.Drawing.Point(30, 220);
            this.btnVozaci.Name = "btnVozaci";
            this.btnVozaci.Size = new System.Drawing.Size(221, 80);
            this.btnVozaci.TabIndex = 51;
            this.btnVozaci.Text = "Vozaci";
            this.btnVozaci.UseVisualStyleBackColor = false;
            this.btnVozaci.Click += new System.EventHandler(this.btnVozaci_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVozaci);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbBrojZaposlenih);
            this.groupBox2.Controls.Add(this.btnAdmini);
            this.groupBox2.Location = new System.Drawing.Point(831, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 406);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // SviZaposleniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1116, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SviZaposleniForma";
            this.Text = "SVI ZAPOSLENI";
            this.Load += new System.EventHandler(this.SviZaposleniForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdmini;
        private System.Windows.Forms.ListView zaposleni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBrojZaposlenih;
        private System.Windows.Forms.Button btnVozaci;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}