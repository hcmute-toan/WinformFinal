using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class AcceptCV : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
         int status=0;
        public static int STATIC = 1;
        public static int STATIC1 = 2;
        public AcceptCV()
        {
            
            InitializeComponent();
            foreach(UserAccount a in ReadSQL.Accounts())
            {
                if(AcceptCVs._idUser ==a.Id)
                {
                    ptbImageUser.Image = ConvertImage.ByteArrayToImage(a.Picture);
                }
            }
            lbName.Text = AcceptCVs.cvtmp.Name;
            lbAddress.Text = AcceptCVs.cvtmp.Address;
            lbGender.Text = AcceptCVs.cvtmp.Gender;
            lbDateOfBirth.Text = AcceptCVs.cvtmp.DateOfBirth;
            tbWorkExperience.Text = AcceptCVs.cvtmp.WorkExperience;
            tbCertifications.Text = AcceptCVs.cvtmp.EducationAndCertifications;
            tbSkills.Text = AcceptCVs.cvtmp.ProfessionalSkills;
            tbGoals.Text = AcceptCVs.cvtmp.GoalAtWork; 
        }

        private void AcceptCV_Load(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            status = 2;
            conn.Open();

            SqlCommand CMD1 = new SqlCommand("UPDATE JobApplication SET Status = @Status WHERE IdCv = @IdCv", conn);
            CMD1.Parameters.AddWithValue("@Status", status);
            CMD1.Parameters.Add("@IdCv",  AcceptCVs._idUser);

            SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
            CMD2.Parameters.Add("@IdLogin", Login.IdCompany);
            CMD2.Parameters.Add("@IdSender", (int)Login.IdCompany);
            CMD2.Parameters.Add("@TypeLogin", (string)"Company");
            CMD2.Parameters.Add("@IdReceiver", AcceptCVs._idUser);
            CMD2.Parameters.Add("@IdJob", (int)-1);
            CMD2.Parameters.Add("@Type", (string)"StatusCV");
            CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
            CMD2.Parameters.Add("@StatusCV",STATIC1 );
            CMD2.Parameters.Add("@Mess", (string)"");
            if (CMD1.ExecuteNonQuery() > 0 &&CMD2.ExecuteNonQuery()>0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
            this.Hide();
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            status = 0;
            conn.Open();

            SqlCommand CMD1 = new SqlCommand("UPDATE JobApplication SET Status = @Status WHERE IdCv = @IdCv", conn);
            CMD1.Parameters.AddWithValue("@Status", status);
            CMD1.Parameters.Add("@IdCv", AcceptCVs._idUser);


            if (CMD1.ExecuteNonQuery() > 0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }

            conn.Close();
            this.Hide();

            ChatEpJob chatEpJob = new ChatEpJob();
            chatEpJob.ShowDialog();
            
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            status = 1;
            conn.Open();

            SqlCommand CMD1 = new SqlCommand("UPDATE JobApplication SET Status = @Status WHERE IdCv = @IdCv", conn);
            CMD1.Parameters.AddWithValue("@Status", status);
            CMD1.Parameters.Add("@IdCv", AcceptCVs._idUser);

            SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
            CMD2.Parameters.Add("@IdLogin", Login.IdCompany);
            CMD2.Parameters.Add("@IdSender", (int)Login.IdCompany);
            CMD2.Parameters.Add("@TypeLogin", (string)"Company");
            CMD2.Parameters.Add("@IdReceiver", AcceptCVs._idUser);
            CMD2.Parameters.Add("@IdJob", (int)-1);
            CMD2.Parameters.Add("@Type", (string)"StatusCV");
            CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
            CMD2.Parameters.Add("@StatusCV", status);
            CMD2.Parameters.Add("@Mess", (string)"");

            if (CMD1.ExecuteNonQuery() > 0 && CMD2.ExecuteNonQuery()>0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }

            conn.Close();
            this.Hide();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbWorkExperience_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
