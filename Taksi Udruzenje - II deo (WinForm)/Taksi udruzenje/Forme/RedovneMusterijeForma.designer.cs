namespace Taksi_udruzenje.Forme
{
    partial class RedovneMusterijeForma
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
            this.musterije = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajMusteriju = new System.Windows.Forms.Button();
            this.btnPopust = new System.Windows.Forms.Button();
            this.btnAzurirajMusteriju = new System.Windows.Forms.Button();
            this.btnBrojeviTelefona = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musterije);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Redovne musterije";
            // 
            // musterije
            // 
            this.musterije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.musterije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musterije.FullRowSelect = true;
            this.musterije.GridLines = true;
            this.musterije.HideSelection = false;
            this.musterije.Location = new System.Drawing.Point(3, 16);
            this.musterije.Name = "musterije";
            this.musterije.Size = new System.Drawing.Size(334, 275);
            this.musterije.TabIndex = 0;
            this.musterije.UseCompatibleStateImageBehavior = false;
            this.musterije.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 69;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adresa";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Broj koriscenih voznji";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 124;
            // 
            // btnDodajMusteriju
            // 
            this.btnDodajMusteriju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodajMusteriju.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajMusteriju.Location = new System.Drawing.Point(358, 39);
            this.btnDodajMusteriju.Name = "btnDodajMusteriju";
            this.btnDodajMusteriju.Size = new System.Drawing.Size(163, 55);
            this.btnDodajMusteriju.TabIndex = 1;
            this.btnDodajMusteriju.Text = "Dodaj redovnu musteriju";
            this.btnDodajMusteriju.UseVisualStyleBackColor = false;
            this.btnDodajMusteriju.Click += new System.EventHandler(this.btnDodajMusteriju_Click);
            // 
            // btnPopust
            // 
            this.btnPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPopust.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopust.Location = new System.Drawing.Point(358, 164);
            this.btnPopust.Name = "btnPopust";
            this.btnPopust.Size = new System.Drawing.Size(163, 60);
            this.btnPopust.TabIndex = 2;
            this.btnPopust.Text = "Izracunaj popust musteriji";
            this.btnPopust.UseVisualStyleBackColor = false;
            this.btnPopust.Click += new System.EventHandler(this.btnPopust_Click);
            // 
            // btnAzurirajMusteriju
            // 
            this.btnAzurirajMusteriju.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajMusteriju.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajMusteriju.Location = new System.Drawing.Point(358, 100);
            this.btnAzurirajMusteriju.Name = "btnAzurirajMusteriju";
            this.btnAzurirajMusteriju.Size = new System.Drawing.Size(163, 58);
            this.btnAzurirajMusteriju.TabIndex = 3;
            this.btnAzurirajMusteriju.Text = "Azuriraj musteriju";
            this.btnAzurirajMusteriju.UseVisualStyleBackColor = false;
            this.btnAzurirajMusteriju.Click += new System.EventHandler(this.btnAzurirajMusteriju_Click);
            // 
            // btnBrojeviTelefona
            // 
            this.btnBrojeviTelefona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBrojeviTelefona.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrojeviTelefona.Location = new System.Drawing.Point(358, 230);
            this.btnBrojeviTelefona.Name = "btnBrojeviTelefona";
            this.btnBrojeviTelefona.Size = new System.Drawing.Size(163, 60);
            this.btnBrojeviTelefona.TabIndex = 4;
            this.btnBrojeviTelefona.Text = "Brojevi telefona musterije";
            this.btnBrojeviTelefona.UseVisualStyleBackColor = false;
            this.btnBrojeviTelefona.Click += new System.EventHandler(this.btnBrojeviTelefona_Click);
            // 
            // RedovneMusterijeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 317);
            this.Controls.Add(this.btnBrojeviTelefona);
            this.Controls.Add(this.btnAzurirajMusteriju);
            this.Controls.Add(this.btnPopust);
            this.Controls.Add(this.btnDodajMusteriju);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RedovneMusterijeForma";
            this.Text = "REDOVNE MUSTERIJE";
            this.Load += new System.EventHandler(this.RedovneMusterijeForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView musterije;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDodajMusteriju;
        private System.Windows.Forms.Button btnPopust;
        private System.Windows.Forms.Button btnAzurirajMusteriju;
        private System.Windows.Forms.Button btnBrojeviTelefona;
    }
}