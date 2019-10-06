namespace Project.FormUI
{
    partial class AdminPanel3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel3));
            this.btnFilmDuzenle = new System.Windows.Forms.Button();
            this.btnTürDüzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilmDuzenle
            // 
            this.btnFilmDuzenle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFilmDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFilmDuzenle.Location = new System.Drawing.Point(331, 95);
            this.btnFilmDuzenle.Name = "btnFilmDuzenle";
            this.btnFilmDuzenle.Size = new System.Drawing.Size(146, 50);
            this.btnFilmDuzenle.TabIndex = 0;
            this.btnFilmDuzenle.Text = "Filmleri Düzenle";
            this.btnFilmDuzenle.UseVisualStyleBackColor = false;
            this.btnFilmDuzenle.Click += new System.EventHandler(this.btnFilmDuzenle_Click);
            // 
            // btnTürDüzenle
            // 
            this.btnTürDüzenle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTürDüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTürDüzenle.Location = new System.Drawing.Point(331, 306);
            this.btnTürDüzenle.Name = "btnTürDüzenle";
            this.btnTürDüzenle.Size = new System.Drawing.Size(146, 48);
            this.btnTürDüzenle.TabIndex = 1;
            this.btnTürDüzenle.Text = "Türleri Düzenle";
            this.btnTürDüzenle.UseVisualStyleBackColor = false;
            this.btnTürDüzenle.Click += new System.EventHandler(this.btnTürDüzenle_Click);
            // 
            // AdminPanel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTürDüzenle);
            this.Controls.Add(this.btnFilmDuzenle);
            this.Name = "AdminPanel3";
            this.Text = "AdminPanel3";
            this.Load += new System.EventHandler(this.AdminPanel3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmDuzenle;
        private System.Windows.Forms.Button btnTürDüzenle;
    }
}