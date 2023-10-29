namespace Taksi_Udruzenje
{
    partial class PocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStranica));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoznje = new System.Windows.Forms.Button();
            this.btnTaxiVozila = new System.Windows.Forms.Button();
            this.btnRedMusterije = new System.Windows.Forms.Button();
            this.btnDodeljeno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.BackColor = System.Drawing.Color.Aqua;
            this.btnZaposleni.Font = new System.Drawing.Font("Constantia", 22F);
            this.btnZaposleni.Location = new System.Drawing.Point(24, 291);
            this.btnZaposleni.Margin = new System.Windows.Forms.Padding(2);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(204, 76);
            this.btnZaposleni.TabIndex = 1;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = false;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "TAKSI UDRUŽENJE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoznje
            // 
            this.btnVoznje.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoznje.BackColor = System.Drawing.Color.Silver;
            this.btnVoznje.Font = new System.Drawing.Font("Constantia", 22F);
            this.btnVoznje.Location = new System.Drawing.Point(118, 451);
            this.btnVoznje.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoznje.Name = "btnVoznje";
            this.btnVoznje.Size = new System.Drawing.Size(229, 76);
            this.btnVoznje.TabIndex = 3;
            this.btnVoznje.Text = "Voznje";
            this.btnVoznje.UseVisualStyleBackColor = false;
            this.btnVoznje.Click += new System.EventHandler(this.btnVoznje_Click);
            // 
            // btnTaxiVozila
            // 
            this.btnTaxiVozila.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaxiVozila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTaxiVozila.Font = new System.Drawing.Font("Constantia", 22F);
            this.btnTaxiVozila.Location = new System.Drawing.Point(242, 291);
            this.btnTaxiVozila.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaxiVozila.Name = "btnTaxiVozila";
            this.btnTaxiVozila.Size = new System.Drawing.Size(215, 76);
            this.btnTaxiVozila.TabIndex = 4;
            this.btnTaxiVozila.Text = "Taxi Vozila";
            this.btnTaxiVozila.UseVisualStyleBackColor = false;
            this.btnTaxiVozila.Click += new System.EventHandler(this.btnTaxiVozila_Click);
            // 
            // btnRedMusterije
            // 
            this.btnRedMusterije.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRedMusterije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRedMusterije.Font = new System.Drawing.Font("Constantia", 20F);
            this.btnRedMusterije.Location = new System.Drawing.Point(118, 532);
            this.btnRedMusterije.Name = "btnRedMusterije";
            this.btnRedMusterije.Size = new System.Drawing.Size(229, 77);
            this.btnRedMusterije.TabIndex = 5;
            this.btnRedMusterije.Text = "Redovne Musterije";
            this.btnRedMusterije.UseVisualStyleBackColor = false;
            this.btnRedMusterije.Click += new System.EventHandler(this.btnRedMusterije_Click);
            // 
            // btnDodeljeno
            // 
            this.btnDodeljeno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDodeljeno.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDodeljeno.Font = new System.Drawing.Font("Constantia", 22F);
            this.btnDodeljeno.Location = new System.Drawing.Point(118, 371);
            this.btnDodeljeno.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodeljeno.Name = "btnDodeljeno";
            this.btnDodeljeno.Size = new System.Drawing.Size(229, 76);
            this.btnDodeljeno.TabIndex = 6;
            this.btnDodeljeno.Text = "Dodeljeno";
            this.btnDodeljeno.UseVisualStyleBackColor = false;
            this.btnDodeljeno.Click += new System.EventHandler(this.btnDodeljeno_Click);
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(468, 621);
            this.Controls.Add(this.btnDodeljeno);
            this.Controls.Add(this.btnRedMusterije);
            this.Controls.Add(this.btnTaxiVozila);
            this.Controls.Add(this.btnVoznje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PocetnaStranica";
            this.Text = "POCETNA STRANICA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoznje;
        private System.Windows.Forms.Button btnTaxiVozila;
        private System.Windows.Forms.Button btnRedMusterije;
        private System.Windows.Forms.Button btnDodeljeno;
    }
}