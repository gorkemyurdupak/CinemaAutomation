namespace Project.FormUI
{
    partial class SuperAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminPanel));
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.btnCalisanGuncelle = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.BackColor = System.Drawing.Color.Lime;
            this.btnCalisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCalisanEkle.Location = new System.Drawing.Point(32, 146);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(138, 48);
            this.btnCalisanEkle.TabIndex = 1;
            this.btnCalisanEkle.Text = "Çalışan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = false;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.BackColor = System.Drawing.Color.Red;
            this.btnCalisanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCalisanSil.Location = new System.Drawing.Point(32, 228);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(138, 48);
            this.btnCalisanSil.TabIndex = 2;
            this.btnCalisanSil.Text = "Çalışan Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = false;
            // 
            // btnCalisanGuncelle
            // 
            this.btnCalisanGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnCalisanGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCalisanGuncelle.Location = new System.Drawing.Point(32, 305);
            this.btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            this.btnCalisanGuncelle.Size = new System.Drawing.Size(157, 48);
            this.btnCalisanGuncelle.TabIndex = 3;
            this.btnCalisanGuncelle.Text = "Çalışan Güncelle";
            this.btnCalisanGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRaporlama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRaporlama.Location = new System.Drawing.Point(32, 417);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(266, 65);
            this.btnRaporlama.TabIndex = 3;
            this.btnRaporlama.Text = "Raporları Görüntüle";
            this.btnRaporlama.UseVisualStyleBackColor = false;
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.Location = new System.Drawing.Point(377, 39);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(519, 381);
            this.lstEmployee.TabIndex = 4;
            // 
            // SuperAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 504);
            this.Controls.Add(this.lstEmployee);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnCalisanGuncelle);
            this.Controls.Add(this.btnCalisanSil);
            this.Controls.Add(this.btnCalisanEkle);
            this.Name = "SuperAdminPanel";
            this.Text = "SuperAdminPanel";
            this.Load += new System.EventHandler(this.SuperAdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.Button btnCalisanGuncelle;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.ListBox lstEmployee;
    }
}