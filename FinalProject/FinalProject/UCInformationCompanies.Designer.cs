using System.Windows.Forms;

namespace FinalProject
{
    partial class UCInformationCompanies
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

        public void OnClick()
        {
            // Xử lý sự kiện click
            MessageBox.Show("User Control đã được click!");

        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInformationCompanies));
            this.lbNameCompany = new System.Windows.Forms.Label();
            this._panel1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbNameJob = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbNeedPosition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRecruit = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this._panel2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbDescribeJob = new System.Windows.Forms.Label();
            this.PtbLogoCompany = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.love2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.love1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._panel1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.love2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.love1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameCompany
            // 
            this.lbNameCompany.AutoSize = true;
            this.lbNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCompany.Location = new System.Drawing.Point(5, 5);
            this.lbNameCompany.Margin = new System.Windows.Forms.Padding(5);
            this.lbNameCompany.Name = "lbNameCompany";
            this.lbNameCompany.Size = new System.Drawing.Size(94, 20);
            this.lbNameCompany.TabIndex = 3;
            this.lbNameCompany.Text = "Tuyensansi";
            this.lbNameCompany.Click += new System.EventHandler(this.lbNameCompany_Click);
            // 
            // _panel1
            // 
            this._panel1.Image = ((System.Drawing.Image)(resources.GetObject("_panel1.Image")));
            this._panel1.ImageRotate = 0F;
            this._panel1.Location = new System.Drawing.Point(130, 5);
            this._panel1.Name = "_panel1";
            this._panel1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this._panel1.Size = new System.Drawing.Size(18, 20);
            this._panel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._panel1.TabIndex = 4;
            this._panel1.TabStop = false;
            // 
            // lbNameJob
            // 
            this.lbNameJob.AutoSize = true;
            this.lbNameJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameJob.Location = new System.Drawing.Point(141, 9);
            this.lbNameJob.Name = "lbNameJob";
            this.lbNameJob.Size = new System.Drawing.Size(126, 20);
            this.lbNameJob.TabIndex = 5;
            this.lbNameJob.Text = "RÚT HẦM CẦU";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(142, 61);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(110, 16);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "TP HỒ CHÍ MINH";
            // 
            // lbNeedPosition
            // 
            this.lbNeedPosition.AutoSize = true;
            this.lbNeedPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNeedPosition.Location = new System.Drawing.Point(403, 10);
            this.lbNeedPosition.Name = "lbNeedPosition";
            this.lbNeedPosition.Size = new System.Drawing.Size(162, 18);
            this.lbNeedPosition.TabIndex = 7;
            this.lbNeedPosition.Text = "Tốt nghiệp cấp 3 trở lên\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng cần tuyển :\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đăng vào :\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbRecruit
            // 
            this.lbRecruit.AutoSize = true;
            this.lbRecruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecruit.Location = new System.Drawing.Point(792, 68);
            this.lbRecruit.Name = "lbRecruit";
            this.lbRecruit.Size = new System.Drawing.Size(16, 18);
            this.lbRecruit.TabIndex = 10;
            this.lbRecruit.Text = "0";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(728, 108);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(80, 18);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "22/12/2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contact :";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Location = new System.Drawing.Point(403, 108);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(217, 16);
            this.lbContact.TabIndex = 14;
            this.lbContact.Text = "vancongtoan09102004@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salary :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(403, 61);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(83, 16);
            this.lbSalary.TabIndex = 16;
            this.lbSalary.Text = "thuong luong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Request :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this._panel1);
            this.guna2Panel1.Controls.Add(this._panel2);
            this.guna2Panel1.Controls.Add(this.lbNameCompany);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 108);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(151, 34);
            this.guna2Panel1.TabIndex = 19;
            // 
            // _panel2
            // 
            this._panel2.Image = ((System.Drawing.Image)(resources.GetObject("_panel2.Image")));
            this._panel2.ImageRotate = 0F;
            this._panel2.Location = new System.Drawing.Point(130, 5);
            this._panel2.Name = "_panel2";
            this._panel2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this._panel2.Size = new System.Drawing.Size(18, 20);
            this._panel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._panel2.TabIndex = 21;
            this._panel2.TabStop = false;
            // 
            // lbDescribeJob
            // 
            this.lbDescribeJob.AutoSize = true;
            this.lbDescribeJob.Location = new System.Drawing.Point(644, 13);
            this.lbDescribeJob.Name = "lbDescribeJob";
            this.lbDescribeJob.Size = new System.Drawing.Size(44, 16);
            this.lbDescribeJob.TabIndex = 20;
            this.lbDescribeJob.Text = "label4";
            this.lbDescribeJob.Visible = false;
            // 
            // PtbLogoCompany
            // 
            this.PtbLogoCompany.Image = ((System.Drawing.Image)(resources.GetObject("PtbLogoCompany.Image")));
            this.PtbLogoCompany.ImageRotate = 0F;
            this.PtbLogoCompany.Location = new System.Drawing.Point(0, 0);
            this.PtbLogoCompany.Name = "PtbLogoCompany";
            this.PtbLogoCompany.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PtbLogoCompany.Size = new System.Drawing.Size(99, 102);
            this.PtbLogoCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLogoCompany.TabIndex = 2;
            this.PtbLogoCompany.TabStop = false;
            this.PtbLogoCompany.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 15);
            this.panel1.TabIndex = 17;
            // 
            // love2
            // 
            this.love2.Image = ((System.Drawing.Image)(resources.GetObject("love2.Image")));
            this.love2.ImageRotate = 0F;
            this.love2.Location = new System.Drawing.Point(722, 3);
            this.love2.Name = "love2";
            this.love2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.love2.Size = new System.Drawing.Size(64, 55);
            this.love2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.love2.TabIndex = 21;
            this.love2.TabStop = false;
            this.love2.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click_1);
            // 
            // love1
            // 
            this.love1.Image = ((System.Drawing.Image)(resources.GetObject("love1.Image")));
            this.love1.ImageRotate = 0F;
            this.love1.Location = new System.Drawing.Point(722, 3);
            this.love1.Name = "love1";
            this.love1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.love1.Size = new System.Drawing.Size(64, 64);
            this.love1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.love1.TabIndex = 23;
            this.love1.TabStop = false;
            // 
            // UCInformationCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.love2);
            this.Controls.Add(this.lbDescribeJob);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbRecruit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNeedPosition);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbNameJob);
            this.Controls.Add(this.PtbLogoCompany);
            this.Controls.Add(this.love1);
            this.Name = "UCInformationCompanies";
            this.Size = new System.Drawing.Size(841, 163);
            this.Load += new System.EventHandler(this.UCInformationCompanies_Load);
            this.Click += new System.EventHandler(this.UCInformationCompanies_Click);
            ((System.ComponentModel.ISupportInitialize)(this._panel1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.love2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.love1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbNameCompany;
        public Guna.UI2.WinForms.Guna2CirclePictureBox _panel1;
        public System.Windows.Forms.Label lbNameJob;
        public System.Windows.Forms.Label lbAddress;
        public System.Windows.Forms.Label lbNeedPosition;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbRecruit;
        public System.Windows.Forms.Label lbTime;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbContact;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbSalary;
        public System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Label lbDescribeJob;
        public Guna.UI2.WinForms.Guna2CirclePictureBox _panel2;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PtbLogoCompany;
        public Panel panel1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox love2;
        public Guna.UI2.WinForms.Guna2CirclePictureBox love1;
    }
}
