namespace YSKProje.MusteriApp.WForm
{
    partial class FrmAdres
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
            this.grpAdres = new System.Windows.Forms.GroupBox();
            this.lstAdres = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpAdres.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdres
            // 
            this.grpAdres.Controls.Add(this.lstAdres);
            this.grpAdres.Location = new System.Drawing.Point(12, 12);
            this.grpAdres.Name = "grpAdres";
            this.grpAdres.Size = new System.Drawing.Size(332, 276);
            this.grpAdres.TabIndex = 2;
            this.grpAdres.TabStop = false;
            this.grpAdres.Text = "woeıfjwıoe";
            // 
            // lstAdres
            // 
            this.lstAdres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAdres.FormattingEnabled = true;
            this.lstAdres.Location = new System.Drawing.Point(3, 16);
            this.lstAdres.Name = "lstAdres";
            this.lstAdres.Size = new System.Drawing.Size(326, 257);
            this.lstAdres.TabIndex = 0;
            this.lstAdres.Click += new System.EventHandler(this.lstAdres_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(258, 313);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(138, 313);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Düzenle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 313);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmAdres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 358);
            this.Controls.Add(this.grpAdres);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Name = "FrmAdres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdres";
            this.grpAdres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdres;
        private System.Windows.Forms.ListBox lstAdres;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}