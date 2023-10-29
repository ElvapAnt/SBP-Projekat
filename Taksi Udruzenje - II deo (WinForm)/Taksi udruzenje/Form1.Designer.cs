namespace Taksi_Udruzenje
{
    partial class Form1
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
            this.cmdUcitavanjeVoznje = new System.Windows.Forms.Button();
            this.cmdDodavanjeVoznje = new System.Windows.Forms.Button();
            this.cmdManyToOne = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdManyToMany = new System.Windows.Forms.Button();
            this.cmdUcitavanjeMusterije = new System.Windows.Forms.Button();
            this.cmdUcitavanjeSopVozila = new System.Windows.Forms.Button();
            this.cmdUcitavanjeTaxiVozilo = new System.Windows.Forms.Button();
            this.cmdUcitavanjeZaposleni = new System.Windows.Forms.Button();
            this.cmdUcitavanjeDodavanje = new System.Windows.Forms.Button();
            this.cmdUcitavanjeBrTel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitavanjeVoznje
            // 
            this.cmdUcitavanjeVoznje.Location = new System.Drawing.Point(12, 12);
            this.cmdUcitavanjeVoznje.Name = "cmdUcitavanjeVoznje";
            this.cmdUcitavanjeVoznje.Size = new System.Drawing.Size(142, 23);
            this.cmdUcitavanjeVoznje.TabIndex = 0;
            this.cmdUcitavanjeVoznje.Text = "Ucitavanje voznje";
            this.cmdUcitavanjeVoznje.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeVoznje.Click += new System.EventHandler(this.cmdUcitavanjeVoznje_Click);
            // 
            // cmdDodavanjeVoznje
            // 
            this.cmdDodavanjeVoznje.Location = new System.Drawing.Point(12, 57);
            this.cmdDodavanjeVoznje.Name = "cmdDodavanjeVoznje";
            this.cmdDodavanjeVoznje.Size = new System.Drawing.Size(163, 23);
            this.cmdDodavanjeVoznje.TabIndex = 1;
            this.cmdDodavanjeVoznje.Text = "Dodavanje nove voznje";
            this.cmdDodavanjeVoznje.UseVisualStyleBackColor = true;
            this.cmdDodavanjeVoznje.Click += new System.EventHandler(this.cmdDodavanjeVoznje_Click);
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(12, 98);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(168, 23);
            this.cmdManyToOne.TabIndex = 2;
            this.cmdManyToOne.Text = "Veza ManyToOne";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(12, 139);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(168, 23);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Veza OneToMany";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdManyToMany
            // 
            this.cmdManyToMany.Location = new System.Drawing.Point(19, 184);
            this.cmdManyToMany.Name = "cmdManyToMany";
            this.cmdManyToMany.Size = new System.Drawing.Size(155, 25);
            this.cmdManyToMany.TabIndex = 4;
            this.cmdManyToMany.Text = "Veza ManyToMany";
            this.cmdManyToMany.UseVisualStyleBackColor = true;
            this.cmdManyToMany.Click += new System.EventHandler(this.cmdManyToMany_Click);
            // 
            // cmdUcitavanjeMusterije
            // 
            this.cmdUcitavanjeMusterije.Location = new System.Drawing.Point(18, 234);
            this.cmdUcitavanjeMusterije.Name = "cmdUcitavanjeMusterije";
            this.cmdUcitavanjeMusterije.Size = new System.Drawing.Size(155, 29);
            this.cmdUcitavanjeMusterije.TabIndex = 5;
            this.cmdUcitavanjeMusterije.Text = "Ucitavanje musterije";
            this.cmdUcitavanjeMusterije.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeMusterije.Click += new System.EventHandler(this.cmdUcitavanjeMusterije_Click);
            // 
            // cmdUcitavanjeSopVozila
            // 
            this.cmdUcitavanjeSopVozila.Location = new System.Drawing.Point(23, 291);
            this.cmdUcitavanjeSopVozila.Name = "cmdUcitavanjeSopVozila";
            this.cmdUcitavanjeSopVozila.Size = new System.Drawing.Size(183, 35);
            this.cmdUcitavanjeSopVozila.TabIndex = 6;
            this.cmdUcitavanjeSopVozila.Text = "Ucitavanje sopstvenog vozila";
            this.cmdUcitavanjeSopVozila.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeSopVozila.Click += new System.EventHandler(this.cmdUcitavanjeSopVozila_Click);
            // 
            // cmdUcitavanjeTaxiVozilo
            // 
            this.cmdUcitavanjeTaxiVozilo.Location = new System.Drawing.Point(235, 26);
            this.cmdUcitavanjeTaxiVozilo.Name = "cmdUcitavanjeTaxiVozilo";
            this.cmdUcitavanjeTaxiVozilo.Size = new System.Drawing.Size(180, 31);
            this.cmdUcitavanjeTaxiVozilo.TabIndex = 7;
            this.cmdUcitavanjeTaxiVozilo.Text = "Ucitavanje taxi vozilo";
            this.cmdUcitavanjeTaxiVozilo.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeTaxiVozilo.Click += new System.EventHandler(this.cmdUcitavanjeTaxiVozilo_Click);
            // 
            // cmdUcitavanjeZaposleni
            // 
            this.cmdUcitavanjeZaposleni.Location = new System.Drawing.Point(246, 81);
            this.cmdUcitavanjeZaposleni.Name = "cmdUcitavanjeZaposleni";
            this.cmdUcitavanjeZaposleni.Size = new System.Drawing.Size(193, 28);
            this.cmdUcitavanjeZaposleni.TabIndex = 8;
            this.cmdUcitavanjeZaposleni.Text = "Ucitavanje Zaposleni";
            this.cmdUcitavanjeZaposleni.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeZaposleni.Click += new System.EventHandler(this.cmdUcitavanjeZaposleni_Click);
            // 
            // cmdUcitavanjeDodavanje
            // 
            this.cmdUcitavanjeDodavanje.Location = new System.Drawing.Point(247, 139);
            this.cmdUcitavanjeDodavanje.Name = "cmdUcitavanjeDodavanje";
            this.cmdUcitavanjeDodavanje.Size = new System.Drawing.Size(191, 22);
            this.cmdUcitavanjeDodavanje.TabIndex = 9;
            this.cmdUcitavanjeDodavanje.Text = "Ucitavanje dodavanje";
            this.cmdUcitavanjeDodavanje.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeDodavanje.Click += new System.EventHandler(this.cmdUcitavanjeDodavanje_Click);
            // 
            // cmdUcitavanjeBrTel
            // 
            this.cmdUcitavanjeBrTel.Location = new System.Drawing.Point(243, 189);
            this.cmdUcitavanjeBrTel.Name = "cmdUcitavanjeBrTel";
            this.cmdUcitavanjeBrTel.Size = new System.Drawing.Size(206, 28);
            this.cmdUcitavanjeBrTel.TabIndex = 10;
            this.cmdUcitavanjeBrTel.Text = "Ucitavanje BrTel";
            this.cmdUcitavanjeBrTel.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeBrTel.Click += new System.EventHandler(this.cmdUcitavanjeBrTel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdUcitavanjeBrTel);
            this.Controls.Add(this.cmdUcitavanjeDodavanje);
            this.Controls.Add(this.cmdUcitavanjeZaposleni);
            this.Controls.Add(this.cmdUcitavanjeTaxiVozilo);
            this.Controls.Add(this.cmdUcitavanjeSopVozila);
            this.Controls.Add(this.cmdUcitavanjeMusterije);
            this.Controls.Add(this.cmdManyToMany);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManyToOne);
            this.Controls.Add(this.cmdDodavanjeVoznje);
            this.Controls.Add(this.cmdUcitavanjeVoznje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitavanjeVoznje;
        private System.Windows.Forms.Button cmdDodavanjeVoznje;
        private System.Windows.Forms.Button cmdManyToOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdManyToMany;
        private System.Windows.Forms.Button cmdUcitavanjeMusterije;
        private System.Windows.Forms.Button cmdUcitavanjeSopVozila;
        private System.Windows.Forms.Button cmdUcitavanjeTaxiVozilo;
        private System.Windows.Forms.Button cmdUcitavanjeZaposleni;
        private System.Windows.Forms.Button cmdUcitavanjeDodavanje;
        private System.Windows.Forms.Button cmdUcitavanjeBrTel;
        private System.Windows.Forms.Button button1;
    }
}

