using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Chat : Form
    {
        SqlConnection conn = new
         SqlConnection(Properties.Settings.Default.ConnStr);
        public Chat()
        {
            InitializeComponent();
            BoxChat();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
            CMD2.Parameters.Add("@IdLogin", Login.IdUser);
            CMD2.Parameters.Add("@IdSender", Login.IdUser);
            CMD2.Parameters.Add("@TypeLogin", (string)"Candidate");
            CMD2.Parameters.Add("@IdReceiver", FindJob1.IDCOMPANY);
            CMD2.Parameters.Add("@IdJob", FindJob1.IDJOB);
            CMD2.Parameters.Add("@Type", (string)"Chat");
            CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
            CMD2.Parameters.Add("@StatusCV", (int)-1);
            CMD2.Parameters.Add("@Mess", txbChat.Text);
            conn.Close();
            BoxChat();
        }
        private void BoxChat()
        {
            flSender.Controls.Clear();
            flReceiver.Controls.Clear();
            foreach(Notice1 a in ReadSQL.Messages1())
            {                   
                    if(a.TypeLogin=="Candidate" && a.IdJob == FindJob1.IDJOB && a.IdSender == Login.IdUser && a.IdReceiver == FindJob1.IDCOMPANY)
                    {
                        UCMessagge mess = new UCMessagge();
                        UCEmty mt = new UCEmty();
                        mess.lbChat.Text = a.Mess.ToString();
                        mess.lbTimeSend.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                        flSender.Controls.Add(mess);
                        flReceiver.Controls.Add(mt);
                    }
                    if (a.TypeLogin == "Company" && a.IdJob == FindJob1.IDJOB && a.IdSender == FindJob1.IDCOMPANY && a.IdReceiver == Login.IdUser)
                    {
                        UCMessagge mess = new UCMessagge();
                        UCEmty mt = new UCEmty();
                        mess.lbChat.Text = a.Mess.ToString();
                        mess.lbTimeSend.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                        flReceiver.Controls.Add(mess);
                        flSender.Controls.Add(mt);
                    }
            }
        }
        private void pnReceiver_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
