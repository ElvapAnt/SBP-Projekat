namespace Taksi_udruzenje.Forme
{
    partial class SveVoznjeForma
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
            this.voznje = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajVoznju = new System.Windows.Forms.Button();
            this.btnObrisiVoznju = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupanBrVoznji = new System.Windows.Forms.TextBox();
            this.btnPrikaziVoznjeOdDo = new System.Windows.Forms.Button();
            this.dateOd = new System.Windows.Forms.DateTimePicker();
            this.dateDo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voznje);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voznje";
            // 
            // voznje
            // 
            this.voznje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.voznje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voznje.FullRowSelect = true;
            this.voznje.GridLines = true;
            this.voznje.HideSelection = false;
            this.voznje.Location = new System.Drawing.Point(3, 16);
            this.voznje.Name = "voznje";
            this.voznje.Size = new System.Drawing.Size(721, 327);
            this.voznje.TabIndex = 0;
            this.voznje.UseCompatibleStateImageBehavior = false;
            this.voznje.View = System.Windows.Forms.View.Details;
            this.voznje.SelectedIndexChanged += new System.EventHandler(this.voznje_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Voznje";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pocetna Stanica";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Krajnja Stanica";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pocetno vreme";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Krajnje vreme";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj poziva";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vreme primanja poziva";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // btnDodajVoznju
            // 
            this.btnDodajVoznju.BackColor = System.Drawing.Color.Lime;
            this.btnDodajVoznju.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVoznju.Location = new System.Drawing.Point(16, 127);
            this.btnDodajVoznju.Name = "btnDodajVoznju";
            this.btnDodajVoznju.Size = new System.Drawing.Size(183, 53);
            this.btnDodajVoznju.TabIndex = 32;
            this.btnDodajVoznju.Text = "Dodaj voznju";
            this.btnDodajVoznju.UseVisualStyleBackColor = false;
            this.btnDodajVoznju.Click += new System.EventHandler(this.btnDodajVoznju_Click);
            // 
            // btnObrisiVoznju
            // 
            this.btnObrisiVoznju.BackColor = System.Drawing.Color.SandyBrown;
            this.btnObrisiVoznju.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiVoznju.Location = new System.Drawing.Point(16, 186);
            this.btnObrisiVoznju.Name = "btnObrisiVoznju";
            this.btnObrisiVoznju.Size = new System.Drawing.Size(183, 55);
            this.btnObrisiVoznju.TabIndex = 34;
            this.btnObrisiVoznju.Text = "Obrisi voznju";
            this.btnObrisiVoznju.UseVisualStyleBackColor = false;
            this.btnObrisiVoznju.Click += new System.EventHandler(this.btnObrisiVoznju_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateDo);
            this.groupBox2.Controls.Add(this.dateOd);
            this.groupBox2.Controls.Add(this.btnPrikaziVoznjeOdDo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUkupanBrVoznji);
            this.groupBox2.Controls.Add(this.btnObrisiVoznju);
            this.groupBox2.Controls.Add(this.btnDodajVoznju);
            this.groupBox2.Location = new System.Drawing.Point(767, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 343);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ukupan broj voznji : ";
            // 
            // txtUkupanBrVoznji
            // 
            this.txtUkupanBrVoznji.Location = new System.Drawing.Point(120, 90);
            this.txtUkupanBrVoznji.Name = "txtUkupanBrVoznji";
            this.txtUkupanBrVoznji.Size = new System.Drawing.Size(89, 20);
            this.txtUkupanBrVoznji.TabIndex = 35;
            // 
            // btnPrikaziVoznjeOdDo
            // 
            this.btnPrikaziVoznjeOdDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPrikaziVoznjeOdDo.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziVoznjeOdDo.Location = new System.Drawing.Point(20, 247);
            this.btnPrikaziVoznjeOdDo.Name = "btnPrikaziVoznjeOdDo";
            this.btnPrikaziVoznjeOdDo.Size = new System.Drawing.Size(179, 50);
            this.btnPrikaziVoznjeOdDo.TabIndex = 37;
            this.btnPrikaziVoznjeOdDo.Text = "Prikazi voznje Od-Do datuma";
            this.btnPrikaziVoznjeOdDo.UseVisualStyleBackColor = false;
            this.btnPrikaziVoznjeOdDo.Click += new System.EventHandler(this.btnPrikaziVoznjeOdDo_Click);
            // 
            // dateOd
            // 
            this.dateOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOd.Location = new System.Drawing.Point(6, 311);
            this.dateOd.Name = "dateOd";
            this.dateOd.Size = new System.Drawing.Size(103, 20);
            this.dateOd.TabIndex = 38;
            this.dateOd.Value = new System.DateTime(2001, 1, 1, 21, 13, 0, 0);
            // 
            // dateDo
            // 
            this.dateDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDo.Location = new System.Drawing.Point(115, 311);
            this.dateDo.Name = "dateDo";
            this.dateDo.Size = new System.Drawing.Size(94, 20);
            this.dateDo.TabIndex = 39;
            // 
            // SveVoznjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(991, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SveVoznjeForma";
            this.Text = "VOZNJE";
            this.Load += new System.EventHandler(this.SveVoznjeForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView voznje;
        private System.Windows.Forms.Button btnDodajVoznju;
        private System.Windows.Forms.Button btnObrisiVoznju;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUkupanBrVoznji;
        private System.Windows.Forms.DateTimePicker dateDo;
        private System.Windows.Forms.DateTimePicker dateOd;
        private System.Windows.Forms.Button btnPrikaziVoznjeOdDo;
    }
}