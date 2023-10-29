namespace Taksi_udruzenje.Forme
{
    partial class DodajVoznjuForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPStanica = new System.Windows.Forms.TextBox();
            this.txtKStanica = new System.Windows.Forms.TextBox();
            this.btnDodajVozaca = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrPoz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.kVremePicker = new System.Windows.Forms.DateTimePicker();
            this.pVremePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJMBGVozaca = new System.Windows.Forms.TextBox();
            this.txtJMBGAdmina = new System.Windows.Forms.TextBox();
            this.txtMusterijaID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pocetno vreme : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pocetna stanica : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Krajnja stanica :";
            // 
            // txtPStanica
            // 
            this.txtPStanica.Location = new System.Drawing.Point(164, 43);
            this.txtPStanica.MaxLength = 50;
            this.txtPStanica.Name = "txtPStanica";
            this.txtPStanica.Size = new System.Drawing.Size(140, 22);
            this.txtPStanica.TabIndex = 0;
            // 
            // txtKStanica
            // 
            this.txtKStanica.Location = new System.Drawing.Point(164, 78);
            this.txtKStanica.MaxLength = 50;
            this.txtKStanica.Name = "txtKStanica";
            this.txtKStanica.Size = new System.Drawing.Size(140, 22);
            this.txtKStanica.TabIndex = 1;
            // 
            // btnDodajVozaca
            // 
            this.btnDodajVozaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajVozaca.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozaca.Location = new System.Drawing.Point(16, 271);
            this.btnDodajVozaca.Name = "btnDodajVozaca";
            this.btnDodajVozaca.Size = new System.Drawing.Size(109, 37);
            this.btnDodajVozaca.TabIndex = 9;
            this.btnDodajVozaca.Text = "DODAJ";
            this.btnDodajVozaca.UseVisualStyleBackColor = false;
            this.btnDodajVozaca.Click += new System.EventHandler(this.btnDodajVoznju_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Krajnje vreme :";
            // 
            // txtBrPoz
            // 
            this.txtBrPoz.Location = new System.Drawing.Point(164, 185);
            this.txtBrPoz.Name = "txtBrPoz";
            this.txtBrPoz.Size = new System.Drawing.Size(139, 22);
            this.txtBrPoz.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vreme primanja poziva :\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Broj poziva : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.kVremePicker);
            this.groupBox1.Controls.Add(this.pVremePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBrPoz);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKStanica);
            this.groupBox1.Controls.Add(this.txtPStanica);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o voznji";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(164, 217);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker3.TabIndex = 20;
            // 
            // kVremePicker
            // 
            this.kVremePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.kVremePicker.Location = new System.Drawing.Point(164, 149);
            this.kVremePicker.Name = "kVremePicker";
            this.kVremePicker.Size = new System.Drawing.Size(139, 22);
            this.kVremePicker.TabIndex = 19;
            // 
            // pVremePicker
            // 
            this.pVremePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pVremePicker.Location = new System.Drawing.Point(164, 114);
            this.pVremePicker.Name = "pVremePicker";
            this.pVremePicker.Size = new System.Drawing.Size(139, 22);
            this.pVremePicker.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJMBGVozaca);
            this.groupBox2.Location = new System.Drawing.Point(383, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 56);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voznju obavio vozac : ";
            // 
            // txtJMBGVozaca
            // 
            this.txtJMBGVozaca.Location = new System.Drawing.Point(39, 19);
            this.txtJMBGVozaca.MaxLength = 13;
            this.txtJMBGVozaca.Name = "txtJMBGVozaca";
            this.txtJMBGVozaca.Size = new System.Drawing.Size(138, 20);
            this.txtJMBGVozaca.TabIndex = 0;
            // 
            // txtJMBGAdmina
            // 
            this.txtJMBGAdmina.Location = new System.Drawing.Point(36, 20);
            this.txtJMBGAdmina.MaxLength = 13;
            this.txtJMBGAdmina.Name = "txtJMBGAdmina";
            this.txtJMBGAdmina.Size = new System.Drawing.Size(132, 20);
            this.txtJMBGAdmina.TabIndex = 11;
            // 
            // txtMusterijaID
            // 
            this.txtMusterijaID.Location = new System.Drawing.Point(43, 20);
            this.txtMusterijaID.MaxLength = 1;
            this.txtMusterijaID.Name = "txtMusterijaID";
            this.txtMusterijaID.Size = new System.Drawing.Size(129, 20);
            this.txtMusterijaID.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtJMBGAdmina);
            this.groupBox3.Location = new System.Drawing.Point(383, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 59);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Primio poziv admin : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMusterijaID);
            this.groupBox4.Location = new System.Drawing.Point(383, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 61);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Voznju narucila musterija : ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(383, 271);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 20);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Nije redovna musterija";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DodajVoznjuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(669, 315);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajVozaca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajVoznjuForma";
            this.Text = "DODAVANJE VOZNJE";
            this.Load += new System.EventHandler(this.DodajVoznjuForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPStanica;
        private System.Windows.Forms.TextBox txtKStanica;
        private System.Windows.Forms.Button btnDodajVozaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrPoz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker kVremePicker;
        private System.Windows.Forms.DateTimePicker pVremePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtJMBGVozaca;
        private System.Windows.Forms.TextBox txtJMBGAdmina;
        private System.Windows.Forms.TextBox txtMusterijaID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}