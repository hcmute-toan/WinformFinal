namespace FinalProject
{
    partial class ListJobsOfCompany
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
            this.panelListJobOfCompany = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.TbFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // panelListJobOfCompany
            // 
            this.panelListJobOfCompany.AutoScroll = true;
            this.panelListJobOfCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListJobOfCompany.Location = new System.Drawing.Point(0, 111);
            this.panelListJobOfCompany.Name = "panelListJobOfCompany";
            this.panelListJobOfCompany.Size = new System.Drawing.Size(1123, 570);
            this.panelListJobOfCompany.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(842, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 45);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TbFind
            // 
            this.TbFind.BorderRadius = 15;
            this.TbFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbFind.DefaultText = "";
            this.TbFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbFind.Location = new System.Drawing.Point(48, 22);
            this.TbFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbFind.Name = "TbFind";
            this.TbFind.PasswordChar = '\0';
            this.TbFind.PlaceholderText = "Name Job";
            this.TbFind.SelectedText = "";
            this.TbFind.Size = new System.Drawing.Size(732, 47);
            this.TbFind.TabIndex = 5;
            this.TbFind.TextChanged += new System.EventHandler(this.TbFind_TextChanged);
            // 
            // ListJobsOfCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TbFind);
            this.Controls.Add(this.panelListJobOfCompany);
            this.Name = "ListJobsOfCompany";
            this.Text = "ListJobsOfCompany";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelListJobOfCompany;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox TbFind;
    }
}