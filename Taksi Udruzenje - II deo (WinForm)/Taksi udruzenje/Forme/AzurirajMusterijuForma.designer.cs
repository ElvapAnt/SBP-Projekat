namespace Taksi_udruzenje.Forme
{
    partial class AzurirajMusterijuForma
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
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAzurirajVozaca = new System.Windows.Forms.Button();
            this.txbBrVoz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMusterije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdMusterije);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAzurirajVozaca);
            this.groupBox1.Controls.Add(this.txbBrVoz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o musteriji";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(184, 53);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(152, 22);
            this.txtAdresa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adresa :";
            // 
            // btnAzurirajVozaca
            // 
            this.btnAzurirajVozaca.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajVozaca.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajVozaca.Location = new System.Drawing.Point(227, 124);
            this.btnAzurirajVozaca.Name = "btnAzurirajVozaca";
            this.btnAzurirajVozaca.Size = new System.Drawing.Size(109, 37);
            this.btnAzurirajVozaca.TabIndex = 12;
            this.btnAzurirajVozaca.Text = "AZURIRAJ";
            this.btnAzurirajVozaca.UseVisualStyleBackColor = false;
            this.btnAzurirajVozaca.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txbBrVoz
            // 
            this.txbBrVoz.Location = new System.Drawing.Point(184, 85);
            this.txbBrVoz.Name = "txbBrVoz";
            this.txbBrVoz.Size = new System.Drawing.Size(152, 22);
            this.txbBrVoz.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj koriscenih voznji :";
            // 
            // txtIdMusterije
            // 
            this.txtIdMusterije.Location = new System.Drawing.Point(182, 24);
            this.txtIdMusterije.Name = "txtIdMusterije";
            this.txtIdMusterije.Size = new System.Drawing.Size(153, 22);
            this.txtIdMusterije.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Musterije :";
            // 
            // AzurirajMusterijuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(366, 186);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AzurirajMusterijuForma";
            this.Text = "AZURIRANJE REDOVNE MUSTERIJE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAzurirajVozaca;
        private System.Windows.Forms.TextBox txbBrVoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMusterije;
    }
}