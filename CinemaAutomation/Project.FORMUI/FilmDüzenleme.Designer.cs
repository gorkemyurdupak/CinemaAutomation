namespace Project.FormUI
{
    partial class FilmDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmDüzenleme));
            this.dataFilmSırala = new System.Windows.Forms.DataGridView();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.FilmSil = new System.Windows.Forms.Button();
            this.btnFilmGuncelle = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataFilmSırala)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFilmSırala
            // 
            this.dataFilmSırala.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataFilmSırala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFilmSırala.Location = new System.Drawing.Point(35, 12);
            this.dataFilmSırala.Name = "dataFilmSırala";
            this.dataFilmSırala.Size = new System.Drawing.Size(835, 308);
            this.dataFilmSırala.TabIndex = 0;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.BackColor = System.Drawing.Color.Lime;
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnFilmEkle.Location = new System.Drawing.Point(35, 349);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(149, 49);
            this.btnFilmEkle.TabIndex = 1;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // FilmSil
            // 
            this.FilmSil.BackColor = System.Drawing.Color.Red;
            this.FilmSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.FilmSil.Location = new System.Drawing.Point(238, 349);
            this.FilmSil.Name = "FilmSil";
            this.FilmSil.Size = new System.Drawing.Size(149, 49);
            this.FilmSil.TabIndex = 2;
            this.FilmSil.Text = "Film Sil";
            this.FilmSil.UseVisualStyleBackColor = false;
            this.FilmSil.Click += new System.EventHandler(this.FilmSil_Click);
            // 
            // btnFilmGuncelle
            // 
            this.btnFilmGuncelle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFilmGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnFilmGuncelle.Location = new System.Drawing.Point(438, 349);
            this.btnFilmGuncelle.Name = "btnFilmGuncelle";
            this.btnFilmGuncelle.Size = new System.Drawing.Size(149, 49);
            this.btnFilmGuncelle.TabIndex = 3;
            this.btnFilmGuncelle.Text = "Film Güncelle";
            this.btnFilmGuncelle.UseVisualStyleBackColor = false;
            this.btnFilmGuncelle.Click += new System.EventHandler(this.btnFilmGuncelle_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Orange;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGeriDon.Location = new System.Drawing.Point(716, 383);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(137, 50);
            this.btnGeriDon.TabIndex = 4;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // FilmDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 474);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnFilmGuncelle);
            this.Controls.Add(this.FilmSil);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.dataFilmSırala);
            this.Name = "FilmDüzenleme";
            this.Text = "FilmDüzenleme";
            this.Load += new System.EventHandler(this.FilmDüzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFilmSırala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFilmSırala;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button FilmSil;
        private System.Windows.Forms.Button btnFilmGuncelle;
        private System.Windows.Forms.Button btnGeriDon;
    }
}