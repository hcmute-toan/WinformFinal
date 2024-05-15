using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
    {
         SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public Login()
        {
            InitializeComponent();
            ptbEye.Visible = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
        }


        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                panelInvalid1.Visible = false;

            }
            catch { }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                panelInvalid2.Visible = false;

            }
            catch { }
        }

        private void tbUserName_Click(object sender, EventArgs e)
        {
            tbUserName.SelectAll();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.SelectAll();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        public static int IdCompany;
        public static int IdUser;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Su ly chuoi.          
            string CharRemove = " ";
            tbUserName.Text = tbUserName.Text.Replace(CharRemove, string.Empty);

            if (tbUserName.Text.Length == 0)
            {
                panelInvalid1.Visible = true;
                return;
            }
            if (tbPassword.Text.Length == 0)
            {
                panelInvalid2.Visible = true;
                return;
            }
            if (panel1.Visible == false && panel2.Visible == false)
            {
                MessageBox.Show("Please select a login type !!!");
                return;
            }
            foreach (UserAccount account in ReadSQL.Accounts())
            {
                if (panel1.Visible == true && tbUserName.Text == account.UserName && tbPassword.Text == account.Password)
                {
                    IdUser = account.Id;
                    this.Hide();
                        conn.Open();
                        SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
                        CMD2.Parameters.Add("@IdLogin", Login.IdUser);
                        CMD2.Parameters.Add("@TypeLogin", (string)"Candidate");
                        CMD2.Parameters.Add("@IdSender", (int)-1);
                        CMD2.Parameters.Add("@IdReceiver", (int)-1);
                        CMD2.Parameters.Add("@IdJob", (int)-1);
                        CMD2.Parameters.Add("@Type", (string)"Login");
                        CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
                        CMD2.Parameters.Add("@StatusCV", (int)-1);
                        CMD2.Parameters.Add("@Mess", (string)"");
                    if (CMD2.ExecuteNonQuery() > 0)
                    {
                    
                    }
                    else
                    {
                        MessageBox.Show("Fail!!!");
                    }
                    conn.Close();
                   
                    FindJob1 form1 = new FindJob1();
                    form1.ShowDialog();
                    return;
                }

            }

            foreach (Employers E in ReadSQL.Company())
            {
                if (panel2.Visible == true && tbUserName.Text == E.UserName && tbPassword.Text == E.Password)
                {
                    IdCompany = E.Id;
                    this.Hide();
                    conn.Open();
                    SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
                    CMD2.Parameters.Add("@IdLogin", Login.IdCompany);
                    CMD2.Parameters.Add("@TypeLogin", (string)"Company");
                    CMD2.Parameters.Add("@IdSender", (int)-1);
                    CMD2.Parameters.Add("@IdReceiver", (int)-1);
                    CMD2.Parameters.Add("@IdJob", (int)-1);
                    CMD2.Parameters.Add("@Type", (string)"Login");
                    CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
                    CMD2.Parameters.Add("@StatusCV", (int)-1);
                    CMD2.Parameters.Add("@Mess", (string)"");
                    if (CMD2.ExecuteNonQuery() > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Fail!!!");
                    }
                    conn.Close();
                    CreateJob form1 = new CreateJob();
                    form1.ShowDialog();                                 
                    return;
                }
             
            }
            MessageBox.Show("Incorrect password or account!!!");
            return;
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void ptbHidden_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            ptbHidden.Visible = false;
            ptbEye.Visible = true;
        }

        private void ptbEye_Click_1(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            ptbHidden.Visible = true;
            ptbEye.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            LbRecruiters.ForeColor = Color.FromArgb(33, 42, 57);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            LbRecruiters.ForeColor = Color.Transparent;
        }



        private void label4_MouseEnter_1(object sender, EventArgs e)
        {
            LbCandidates.ForeColor = Color.FromArgb(33, 42, 57);
        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            LbCandidates.ForeColor = Color.Transparent;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter vua duoc nhan !!!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPaword forgotPaword = new ForgotPaword();
            forgotPaword.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LbForgotPasssword_MouseEnter(object sender, EventArgs e)
        {
            LbForgotPasssword.ForeColor = Color.FromArgb(33, 42, 57);
        }

        private void LbForgotPasssword_MouseLeave(object sender, EventArgs e)
        {
            LbForgotPasssword.ForeColor = Color.Transparent;
        }

        private void LbCreateNewAccount_MouseEnter(object sender, EventArgs e)
        {
            LbCreateNewAccount.ForeColor = Color.FromArgb(33, 42, 57);
        }

        private void LbCreateNewAccount_MouseLeave(object sender, EventArgs e)
        {
            LbCreateNewAccount.ForeColor = Color.Transparent;
        }


    }
}