namespace FinalProject
{
    partial class UCChatFreeCandidateNotice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChatFreeCandidateNotice));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTimeChangePassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbCompany = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 93);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(811, 10);
            this.guna2Panel1.TabIndex = 12;
            // 
            // lbTimeChangePassword
            // 
            this.lbTimeChangePassword.AutoSize = true;
            this.lbTimeChangePassword.Depth = 0;
            this.lbTimeChangePassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTimeChangePassword.Location = new System.Drawing.Point(639, 68);
            this.lbTimeChangePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTimeChangePassword.Name = "lbTimeChangePassword";
            this.lbTimeChangePassword.Size = new System.Drawing.Size(87, 19);
            this.lbTimeChangePassword.TabIndex = 11;
            this.lbTimeChangePassword.Text = "12/05/2024";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(133, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(275, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "You have a message from company :\r\n";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(77, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Depth = 0;
            this.lbCompany.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbCompany.Location = new System.Drawing.Point(438, 38);
            this.lbCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(43, 19);
            this.lbCompany.TabIndex = 13;
            this.lbCompany.Text = "fpt\r\n\r\n";
            // 
            // UCChatFreeCandidateNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbTimeChangePassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "UCChatFreeCandidateNotice";
            this.Size = new System.Drawing.Size(811, 106);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public MaterialSkin.Controls.MaterialLabel lbTimeChangePassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private MaterialSkin.Controls.MaterialLabel lbCompany;
    }
}
