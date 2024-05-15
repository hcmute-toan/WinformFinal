﻿using System;
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
    public partial class ChatEp : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public ChatEp()
        {
            InitializeComponent();
            BoxChat();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
            CMD2.Parameters.Add("@IdLogin", Login.IdCompany);
            CMD2.Parameters.Add("@IdSender", Login.IdCompany);
            CMD2.Parameters.Add("@TypeLogin", (string)"Company");
            CMD2.Parameters.Add("@IdReceiver", CreateJob.IDUSER);
            CMD2.Parameters.Add("@IdJob", (int)-1);
            CMD2.Parameters.Add("@Type", (string)"ChatFree");
            CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
            CMD2.Parameters.Add("@StatusCV", (int)-1);
            CMD2.Parameters.Add("@Mess", txbChat.Text);
            if(CMD2.ExecuteNonQuery()>0)
            {

            }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
            BoxChat();
        }
        private void BoxChat()
        {
            flSender.Controls.Clear();
            flReceiver.Controls.Clear();
            foreach (Notice1 a in ReadSQL.Messages1())
            {
                if (a.TypeLogin == "Candidate" && a.IdJob == -1 && a.IdSender == CreateJob.IDUSER && a.IdReceiver == Login.IdCompany)
                {
                    UCMessagge mess = new UCMessagge();
                    UCEmty mt = new UCEmty();
                    mess.lbChat.Text = a.Mess.ToString();
                    mess.lbTimeSend.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                    flSender.Controls.Add(mt);
                    flReceiver.Controls.Add(mess);
                }
                if (a.TypeLogin == "Company" && a.IdJob == -1 && a.IdSender == Login.IdCompany && a.IdReceiver == CreateJob.IDUSER)
                {
                    UCMessagge mess = new UCMessagge();
                    UCEmty mt = new UCEmty();
                    mess.lbChat.Text = a.Mess.ToString();
                    mess.lbTimeSend.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                    flReceiver.Controls.Add(mt);
                    flSender.Controls.Add(mess);
                }
            }
        }

        private void ChatEp_Load(object sender, EventArgs e)
        {

        }

        private void flReceiver_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flSender_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
