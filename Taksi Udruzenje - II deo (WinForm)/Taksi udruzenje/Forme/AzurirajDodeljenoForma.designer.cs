namespace Taksi_udruzenje.Forme
{
    partial class AzurirajDodeljenoForma
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
            this.chkDatumDo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datumDoPick = new System.Windows.Forms.DateTimePicker();
            this.datumOdPick = new System.Windows.Forms.DateTimePicker();
            this.txbJMBGVozaca = new System.Windows.Forms.TextBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txbRegOznaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDatumDo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datumDoPick);
            this.groupBox1.Controls.Add(this.datumOdPick);
            this.groupBox1.Controls.Add(this.txbJMBGVozaca);
            this.groupBox1.Controls.Add(this.btnAzuriraj);
            this.groupBox1.Controls.Add(this.txbRegOznaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o odnosu vozaca i taxi vozila";
            // 
            // chkDatumDo
            // 
            this.chkDatumDo.AutoSize = true;
            this.chkDatumDo.Checked = true;
            this.chkDatumDo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDatumDo.Location = new System.Drawing.Point(243, 161);
            this.chkDatumDo.Name = "chkDatumDo";
            this.chkDatumDo.Size = new System.Drawing.Size(175, 22);
            this.chkDatumDo.TabIndex = 10;
            this.chkDatumDo.Text = "Novo-dodeljeno vozilo";
            this.chkDatumDo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datum Do :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum Od :";
            // 
            // datumDoPick
            // 
            this.datumDoPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDoPick.Location = new System.Drawing.Point(262, 120);
            this.datumDoPick.Name = "datumDoPick";
            this.datumDoPick.Size = new System.Drawing.Size(156, 24);
            this.datumDoPick.TabIndex = 7;
            // 
            // datumOdPick
            // 
            this.datumOdPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOdPick.Location = new System.Drawing.Point(262, 50);
            this.datumOdPick.Name = "datumOdPick";
            this.datumOdPick.Size = new System.Drawing.Size(156, 24);
            this.datumOdPick.TabIndex = 6;
            // 
            // txbJMBGVozaca
            // 
            this.txbJMBGVozaca.Location = new System.Drawing.Point(6, 120);
            this.txbJMBGVozaca.MaxLength = 13;
            this.txbJMBGVozaca.Name = "txbJMBGVozaca";
            this.txbJMBGVozaca.Size = new System.Drawing.Size(150, 24);
            this.txbJMBGVozaca.TabIndex = 1;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Teal;
            this.btnAzuriraj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAzuriraj.Location = new System.Drawing.Point(150, 209);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(128, 37);
            this.btnAzuriraj.TabIndex = 5;
            this.btnAzuriraj.Text = "AZURIRAJ";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txbRegOznaka
            // 
            this.txbRegOznaka.Location = new System.Drawing.Point(6, 50);
            this.txbRegOznaka.MaxLength = 8;
            this.txbRegOznaka.Name = "txbRegOznaka";
            this.txbRegOznaka.Size = new System.Drawing.Size(150, 24);
            this.txbRegOznaka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registracija taxi vozila :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "JMBG Vozaca : ";
            // 
            // AzurirajDodeljenoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(439, 275);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AzurirajDodeljenoForma";
            this.Text = "AZURIRANJE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbJMBGVozaca;
        private System.Windows.Forms.TextBox txbRegOznaka;
        private System.Windows.Forms.CheckBox chkDatumDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumDoPick;
        private System.Windows.Forms.DateTimePicker datumOdPick;
    }
}