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
    public partial class CreateCV : Form
    {
        string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";
        public static int STATIC = 0;
        public static int IDCv = 0;
        public CreateCV()
        {
            InitializeComponent();
            foreach (UserAccount a in ReadSQL.Accounts())
            {
                if (a.Id == Login.IdUser)
                {
                    ptbImageUser.Image = ConvertImage.ByteArrayToImage(a.Picture);
                }
            }
            foreach (CV cv in ReadSQL.Cvs())
            {
                if (cv.Id == Login.IdUser)
                {
                    IDCv = cv.IdCv;
                    lbName.Text = cv.Name;
                    lbGender.Text = cv.Gender;
                    lbAddress.Text = cv.Address;
                    lbDateOfBirth.Text = cv.DateOfBirth;
                    tbWorkExperience.Text = cv.WorkExperience;
                    tbCertifications.Text = cv.EducationAndCertifications;
                    tbSkills.Text = cv.ProfessionalSkills;
                    tbGoals.Text = cv.GoalAtWork;
                }
            }
        }
        private void CreateCV_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into JobApplication values(@IdCv, @UserId, @JobId, @CompanyId, @Status)", conn);
                    cmd.Parameters.Add("@IdCv", (int)IDCv);
                    cmd.Parameters.Add("@UserId", (int)Login.IdUser);
                    cmd.Parameters.Add("@JobId", (int)FindJob1.IDJOB);
                    cmd.Parameters.Add("@CompanyId", (int)FindJob1.IDCOMPANY);
                    cmd.Parameters.Add("@Status", STATIC);

                    SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
                    CMD2.Parameters.Add("@IdLogin", Login.IdUser);
                    CMD2.Parameters.Add("@IdSender", (int)Login.IdUser);
                    CMD2.Parameters.Add("@TypeLogin", (string)"Candidate");
                    CMD2.Parameters.Add("@IdReceiver", FindJob1.IDCOMPANY);
                    CMD2.Parameters.Add("@IdJob", (int)-1);
                    CMD2.Parameters.Add("@Type", (string)"StatusCV");
                    CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
                    CMD2.Parameters.Add("@StatusCV", STATIC);
                    CMD2.Parameters.Add("@Mess", (string)"");
                    if (cmd.ExecuteNonQuery()>0&&CMD2.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Success!!!");
                    }
                    else
                    {
                        MessageBox.Show("Fail!!!");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tbWorkExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformationUser informationUser = new InformationUser();
            informationUser.ShowDialog();
        }
    }
}