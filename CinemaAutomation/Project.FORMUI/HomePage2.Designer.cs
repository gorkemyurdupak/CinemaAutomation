namespace Project.FormUI
{
    partial class HomePage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage2));
            this.btnBilet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnYonetim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBilet
            // 
            this.btnBilet.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnBilet.Location = new System.Drawing.Point(38, 78);
            this.btnBilet.Name = "btnBilet";
            this.btnBilet.Size = new System.Drawing.Size(162, 63);
            this.btnBilet.TabIndex = 0;
            this.btnBilet.Text = "Bilet Satışı";
            this.btnBilet.UseVisualStyleBackColor = false;
            this.btnBilet.Click += new System.EventHandler(this.btnBilet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnYonetim
            // 
            this.btnYonetim.BackColor = System.Drawing.Color.Red;
            this.btnYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnYonetim.Location = new System.Drawing.Point(574, 189);
            this.btnYonetim.Name = "btnYonetim";
            this.btnYonetim.Size = new System.Drawing.Size(195, 69);
            this.btnYonetim.TabIndex = 2;
            this.btnYonetim.Text = "Film Düzenleme";
            this.btnYonetim.UseVisualStyleBackColor = false;
            this.btnYonetim.Click += new System.EventHandler(this.btnYonetim_Click);
            // 
            // HomePage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYonetim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBilet);
            this.Name = "HomePage2";
            this.Text = "HomePage2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBilet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnYonetim;
    }
}