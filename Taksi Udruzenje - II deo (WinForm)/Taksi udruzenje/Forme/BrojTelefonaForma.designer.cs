namespace Taksi_udruzenje.Forme
{
    partial class BrojTelefonaForma
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
            this.telefoni = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefoni);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brojevi telefona";
            // 
            // telefoni
            // 
            this.telefoni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.telefoni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefoni.FullRowSelect = true;
            this.telefoni.GridLines = true;
            this.telefoni.HideSelection = false;
            this.telefoni.Location = new System.Drawing.Point(3, 20);
            this.telefoni.Name = "telefoni";
            this.telefoni.Size = new System.Drawing.Size(211, 271);
            this.telefoni.TabIndex = 0;
            this.telefoni.UseCompatibleStateImageBehavior = false;
            this.telefoni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Broj Telefona";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 209;
            // 
            // BrojTelefonaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(240, 316);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrojTelefonaForma";
            this.Text = "BROJEVI TELEFONA MUSTERIJE";
            this.Load += new System.EventHandler(this.BrojTelefonaForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView telefoni;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}