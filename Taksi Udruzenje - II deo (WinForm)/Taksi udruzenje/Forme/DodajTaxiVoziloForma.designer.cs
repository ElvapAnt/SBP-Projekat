namespace Taksi_udruzenje.Forme
{
    partial class DodajTaxiVoziloForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datumIstekaReg = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGodProizv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txbMarka = new System.Windows.Forms.TextBox();
            this.txtRegOznaka = new System.Windows.Forms.TextBox();
            this.txbTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.datumIstekaReg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGodProizv);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txbMarka);
            this.groupBox1.Controls.Add(this.txtRegOznaka);
            this.groupBox1.Controls.Add(this.txbTip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o taxi vozilu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Godina proizvodnje:";
            // 
            // datumIstekaReg
            // 
            this.datumIstekaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumIstekaReg.Location = new System.Drawing.Point(173, 171);
            this.datumIstekaReg.Name = "datumIstekaReg";
            this.datumIstekaReg.Size = new System.Drawing.Size(131, 22);
            this.datumIstekaReg.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Datum isteka registracije :";
            // 
            // txtGodProizv
            // 
            this.txtGodProizv.Location = new System.Drawing.Point(152, 138);
            this.txtGodProizv.MaxLength = 4;
            this.txtGodProizv.Name = "txtGodProizv";
            this.txtGodProizv.Size = new System.Drawing.Size(152, 22);
            this.txtGodProizv.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodaj.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(3, 209);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(109, 37);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txbMarka
            // 
            this.txbMarka.Location = new System.Drawing.Point(152, 104);
            this.txbMarka.MaxLength = 20;
            this.txbMarka.Name = "txbMarka";
            this.txbMarka.Size = new System.Drawing.Size(152, 22);
            this.txbMarka.TabIndex = 2;
            // 
            // txtRegOznaka
            // 
            this.txtRegOznaka.Location = new System.Drawing.Point(152, 40);
            this.txtRegOznaka.MaxLength = 8;
            this.txtRegOznaka.Name = "txtRegOznaka";
            this.txtRegOznaka.Size = new System.Drawing.Size(152, 22);
            this.txtRegOznaka.TabIndex = 1;
            // 
            // txbTip
            // 
            this.txbTip.Location = new System.Drawing.Point(152, 72);
            this.txbTip.Name = "txbTip";
            this.txbTip.Size = new System.Drawing.Size(152, 22);
            this.txbTip.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reg. oznaka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka :";
            // 
            // DodajTaxiVoziloForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(334, 279);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajTaxiVoziloForma";
            this.Text = "DODAVANJE TAXI VOZILA";
            this.Load += new System.EventHandler(this.DodajTaxiVoziloForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtRegOznaka;
        private System.Windows.Forms.TextBox txbTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGodProizv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datumIstekaReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMarka;
        private System.Windows.Forms.Label label2;
    }
}