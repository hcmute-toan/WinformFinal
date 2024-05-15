namespace FinalProject
{
    partial class UCMessagge
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
            this.lbChat = new System.Windows.Forms.Label();
            this.lbTimeSend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbChat
            // 
            this.lbChat.Location = new System.Drawing.Point(3, 4);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(528, 57);
            this.lbChat.TabIndex = 0;
            this.lbChat.Text = "Your CV has been accepted, go to the company\'s facility 1 at 123 Ly Thuong Kiet S" +
    "treet, Ho Chi Minh City for an interview.\r\n";
            // 
            // lbTimeSend
            // 
            this.lbTimeSend.AutoSize = true;
            this.lbTimeSend.Location = new System.Drawing.Point(387, 70);
            this.lbTimeSend.Name = "lbTimeSend";
            this.lbTimeSend.Size = new System.Drawing.Size(71, 16);
            this.lbTimeSend.TabIndex = 1;
            this.lbTimeSend.Text = "12/05/2004";
            this.lbTimeSend.Click += new System.EventHandler(this.lbTimeSend_Click);
            // 
            // UCMessagge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.lbTimeSend);
            this.Controls.Add(this.lbChat);
            this.Name = "UCMessagge";
            this.Size = new System.Drawing.Size(562, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbChat;
        public System.Windows.Forms.Label lbTimeSend;
    }
}
