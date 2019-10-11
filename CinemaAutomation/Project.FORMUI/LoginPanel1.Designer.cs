namespace Project.FormUI
{
    partial class LoginPanel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel1));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLabel1 = new System.Windows.Forms.Label();
            this.txtLabel2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(304, 146);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(269, 41);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(304, 226);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(269, 41);
            this.txtPass.TabIndex = 1;
            // 
            // txtLabel1
            // 
            this.txtLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLabel1.Location = new System.Drawing.Point(182, 146);
            this.txtLabel1.Name = "txtLabel1";
            this.txtLabel1.Size = new System.Drawing.Size(116, 41);
            this.txtLabel1.TabIndex = 2;
            this.txtLabel1.Text = "Kullanıcı Adı";
            this.txtLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLabel2
            // 
            this.txtLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLabel2.Location = new System.Drawing.Point(182, 226);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(116, 41);
            this.txtLabel2.TabIndex = 3;
            this.txtLabel2.Text = "Şifre";
            this.txtLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGiris.Location = new System.Drawing.Point(266, 310);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(215, 60);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // LoginPanel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtLabel2);
            this.Controls.Add(this.txtLabel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "LoginPanel1";
            this.Text = "Login Panel";
            this.Load += new System.EventHandler(this.LoginPanel1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label txtLabel1;
        private System.Windows.Forms.Label txtLabel2;
        private System.Windows.Forms.Button btnGiris;
    }
}

