using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ListChat : Form
    {
        public ListChat()
        {
            InitializeComponent();
            View();
        }
        private void View()
        {
            flListChat.Controls.Clear();
            foreach(Notice1 a in ReadSQL.Messages1())
            {
                if (a.TypeLogin == "Company" && a.Type == "ChatFree" && a.IdReceiver ==Login.IdUser);
                {
                    UCBoxChat uCBoxChat = new UCBoxChat();
                    uCBoxChat.lbTimeNotice.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                            flListChat.Controls.Add(uCBoxChat);
                            uCBoxChat.Click += (sender, e) =>
                            {
                                ChatUser chatep = new ChatUser();
                                chatep.ShowDialog();

                            };
                        }
                        
                    }
                   
                }
            }
        }
