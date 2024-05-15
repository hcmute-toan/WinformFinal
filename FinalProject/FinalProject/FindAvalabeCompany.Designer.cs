namespace FinalProject
{
    partial class FindAvalabeCompany
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.TbFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelAvalableCompany = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(806, 22);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(147, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.TbFind.Location = new System.Drawing.Point(22, 22);
            this.TbFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbFind.Name = "TbFind";
            this.TbFind.PasswordChar = '\0';
            this.TbFind.PlaceholderText = "Name Company";
            this.TbFind.SelectedText = "";
            this.TbFind.Size = new System.Drawing.Size(732, 47);
            this.TbFind.TabIndex = 3;
            // 
            // PanelAvalableCompany
            // 
            this.PanelAvalableCompany.AutoScroll = true;
            this.PanelAvalableCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAvalableCompany.Location = new System.Drawing.Point(0, 186);
            this.PanelAvalableCompany.Name = "PanelAvalableCompany";
            this.PanelAvalableCompany.Size = new System.Drawing.Size(1111, 482);
            this.PanelAvalableCompany.TabIndex = 6;
            // 
            // FindAvalabeCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 668);
            this.Controls.Add(this.PanelAvalableCompany);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.TbFind);
            this.Name = "FindAvalabeCompany";
            this.Text = "FindAvalabeCompany";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox TbFind;
        private System.Windows.Forms.FlowLayoutPanel PanelAvalableCompany;
    }
}