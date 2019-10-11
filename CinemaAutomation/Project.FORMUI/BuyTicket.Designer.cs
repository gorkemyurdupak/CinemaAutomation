namespace Project.FormUI
{
    partial class BuyTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFilmAdı = new System.Windows.Forms.ComboBox();
            this.lblFilmAdı = new System.Windows.Forms.Label();
            this.lblSalonAdı = new System.Windows.Forms.Label();
            this.cmbSalonGetir = new System.Windows.Forms.ComboBox();
            this.lblFilmTarihi = new System.Windows.Forms.Label();
            this.cmbFilmTarihi = new System.Windows.Forms.ComboBox();
            this.lblSeans = new System.Windows.Forms.Label();
            this.cmbSeansGetir = new System.Windows.Forms.ComboBox();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.cmbKoltukNo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbKoltukIptal = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 345);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbKoltukNo);
            this.panel2.Controls.Add(this.lblKoltukNo);
            this.panel2.Controls.Add(this.cmbSeansGetir);
            this.panel2.Controls.Add(this.lblSeans);
            this.panel2.Controls.Add(this.cmbFilmTarihi);
            this.panel2.Controls.Add(this.lblFilmTarihi);
            this.panel2.Controls.Add(this.cmbSalonGetir);
            this.panel2.Controls.Add(this.lblSalonAdı);
            this.panel2.Controls.Add(this.lblFilmAdı);
            this.panel2.Controls.Add(this.cmbFilmAdı);
            this.panel2.Location = new System.Drawing.Point(741, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 280);
            this.panel2.TabIndex = 1;
            // 
            // cmbFilmAdı
            // 
            this.cmbFilmAdı.FormattingEnabled = true;
            this.cmbFilmAdı.Location = new System.Drawing.Point(158, 15);
            this.cmbFilmAdı.Name = "cmbFilmAdı";
            this.cmbFilmAdı.Size = new System.Drawing.Size(143, 21);
            this.cmbFilmAdı.TabIndex = 0;
            this.cmbFilmAdı.SelectedIndexChanged += new System.EventHandler(this.cmbFilmAdı_SelectedIndexChanged);
            // 
            // lblFilmAdı
            // 
            this.lblFilmAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilmAdı.Location = new System.Drawing.Point(25, 15);
            this.lblFilmAdı.Name = "lblFilmAdı";
            this.lblFilmAdı.Size = new System.Drawing.Size(100, 23);
            this.lblFilmAdı.TabIndex = 1;
            this.lblFilmAdı.Text = "Film Adı";
            this.lblFilmAdı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalonAdı
            // 
            this.lblSalonAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalonAdı.Location = new System.Drawing.Point(25, 72);
            this.lblSalonAdı.Name = "lblSalonAdı";
            this.lblSalonAdı.Size = new System.Drawing.Size(100, 23);
            this.lblSalonAdı.TabIndex = 2;
            this.lblSalonAdı.Text = "Salon No";
            this.lblSalonAdı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSalonGetir
            // 
            this.cmbSalonGetir.FormattingEnabled = true;
            this.cmbSalonGetir.Location = new System.Drawing.Point(158, 72);
            this.cmbSalonGetir.Name = "cmbSalonGetir";
            this.cmbSalonGetir.Size = new System.Drawing.Size(143, 21);
            this.cmbSalonGetir.TabIndex = 3;
            // 
            // lblFilmTarihi
            // 
            this.lblFilmTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilmTarihi.Location = new System.Drawing.Point(25, 124);
            this.lblFilmTarihi.Name = "lblFilmTarihi";
            this.lblFilmTarihi.Size = new System.Drawing.Size(100, 23);
            this.lblFilmTarihi.TabIndex = 4;
            this.lblFilmTarihi.Text = "Film Tarihi";
            this.lblFilmTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFilmTarihi
            // 
            this.cmbFilmTarihi.FormattingEnabled = true;
            this.cmbFilmTarihi.Location = new System.Drawing.Point(158, 124);
            this.cmbFilmTarihi.Name = "cmbFilmTarihi";
            this.cmbFilmTarihi.Size = new System.Drawing.Size(143, 21);
            this.cmbFilmTarihi.TabIndex = 5;
            // 
            // lblSeans
            // 
            this.lblSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSeans.Location = new System.Drawing.Point(25, 174);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(100, 23);
            this.lblSeans.TabIndex = 6;
            this.lblSeans.Text = "Film Seansı";
            this.lblSeans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSeansGetir
            // 
            this.cmbSeansGetir.FormattingEnabled = true;
            this.cmbSeansGetir.Location = new System.Drawing.Point(158, 174);
            this.cmbSeansGetir.Name = "cmbSeansGetir";
            this.cmbSeansGetir.Size = new System.Drawing.Size(143, 21);
            this.cmbSeansGetir.TabIndex = 7;
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKoltukNo.Location = new System.Drawing.Point(25, 216);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(100, 23);
            this.lblKoltukNo.TabIndex = 8;
            this.lblKoltukNo.Text = "Koltuk No";
            this.lblKoltukNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbKoltukNo
            // 
            this.cmbKoltukNo.Enabled = false;
            this.cmbKoltukNo.FormattingEnabled = true;
            this.cmbKoltukNo.Location = new System.Drawing.Point(158, 216);
            this.cmbKoltukNo.Name = "cmbKoltukNo";
            this.cmbKoltukNo.Size = new System.Drawing.Size(143, 21);
            this.cmbKoltukNo.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(442, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cmbKoltukIptal
            // 
            this.cmbKoltukIptal.Enabled = false;
            this.cmbKoltukIptal.FormattingEnabled = true;
            this.cmbKoltukIptal.Location = new System.Drawing.Point(899, 325);
            this.cmbKoltukIptal.Name = "cmbKoltukIptal";
            this.cmbKoltukIptal.Size = new System.Drawing.Size(143, 21);
            this.cmbKoltukIptal.TabIndex = 10;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 728);
            this.Controls.Add(this.cmbKoltukIptal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFilmAdı;
        private System.Windows.Forms.ComboBox cmbSalonGetir;
        private System.Windows.Forms.Label lblSalonAdı;
        private System.Windows.Forms.Label lblFilmAdı;
        private System.Windows.Forms.ComboBox cmbKoltukNo;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.ComboBox cmbSeansGetir;
        private System.Windows.Forms.Label lblSeans;
        private System.Windows.Forms.ComboBox cmbFilmTarihi;
        private System.Windows.Forms.Label lblFilmTarihi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbKoltukIptal;
    }
}