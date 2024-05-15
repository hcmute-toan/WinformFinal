namespace FinalProject
{
    partial class ChatEpJob
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
            this.flSender = new System.Windows.Forms.FlowLayoutPanel();
            this.flReceiver = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.txbChat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flSender
            // 
            this.flSender.AutoScroll = true;
            this.flSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flSender.Location = new System.Drawing.Point(627, 0);
            this.flSender.Name = "flSender";
            this.flSender.Size = new System.Drawing.Size(658, 531);
            this.flSender.TabIndex = 1;
            // 
            // flReceiver
            // 
            this.flReceiver.AutoScroll = true;
            this.flReceiver.Dock = System.Windows.Forms.DockStyle.Left;
            this.flReceiver.Location = new System.Drawing.Point(0, 0);
            this.flReceiver.Name = "flReceiver";
            this.flReceiver.Size = new System.Drawing.Size(627, 531);
            this.flReceiver.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnSend);
            this.guna2Panel1.Controls.Add(this.txbChat);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 531);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1285, 100);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 10;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(835, 29);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 45);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbChat
            // 
            this.txbChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbChat.DefaultText = "";
            this.txbChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbChat.Location = new System.Drawing.Point(375, 28);
            this.txbChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbChat.Name = "txbChat";
            this.txbChat.PasswordChar = '\0';
            this.txbChat.PlaceholderText = "";
            this.txbChat.SelectedText = "";
            this.txbChat.Size = new System.Drawing.Size(397, 46);
            this.txbChat.TabIndex = 0;
            // 
            // ChatEpJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 631);
            this.Controls.Add(this.flSender);
            this.Controls.Add(this.flReceiver);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ChatEpJob";
            this.Text = "ChatEpJob";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flSender;
        private System.Windows.Forms.FlowLayoutPanel flReceiver;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txbChat;
    }
}