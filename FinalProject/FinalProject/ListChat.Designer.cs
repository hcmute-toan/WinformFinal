namespace FinalProject
{
    partial class ListChat
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
            this.flListChat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flListChat
            // 
            this.flListChat.AutoScroll = true;
            this.flListChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flListChat.Location = new System.Drawing.Point(0, 0);
            this.flListChat.Name = "flListChat";
            this.flListChat.Size = new System.Drawing.Size(1004, 577);
            this.flListChat.TabIndex = 0;
            // 
            // ListChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 577);
            this.Controls.Add(this.flListChat);
            this.Name = "ListChat";
            this.Text = "ListChat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flListChat;
    }
}