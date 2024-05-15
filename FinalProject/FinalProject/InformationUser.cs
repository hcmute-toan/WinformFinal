using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class InformationUser : Form
    {
        SqlConnection conn = new
         SqlConnection(Properties.Settings.Default.ConnStr);
        public InformationUser()
        {
            InitializeComponent();
        }

        private void btnAddImageUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PtbImageUser.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            byte[] b = PathToByteArray(this.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into CVs values(@UserId, @Name,@Gender,@Address,@DateOfBirth,@WorkExperience,@EducationAndCertifications,@ProfessionalSkills,@GoalsAtWork)", conn);
            cmd.Parameters.Add("@UserId", Login.IdUser);
            cmd.Parameters.Add("@Name", tbName.Text);
            cmd.Parameters.Add("@Gender", cbgender.Text);
            cmd.Parameters.Add("@Address", cbaddress.Text);
            cmd.Parameters.Add("@DateOfBirth", dtpDateOfBirth.Value.ToString("dd/MM/yyyy"));
            cmd.Parameters.Add("@WorkExperience", tbWorkExperience.Text);
            cmd.Parameters.Add("@EducationAndCertifications", tbCertifications.Text);
            cmd.Parameters.Add("@ProfessionalSkills",tbSkills.Text);
            cmd.Parameters.Add("@GoalsAtWork", tbGoalsAtWork.Text);

            SqlCommand CMD1 = new SqlCommand("UPDATE Candidates SET Picture = @PictureParam WHERE Id = @IdParam", conn);
            // Cung cấp giá trị cho các thamSqlParameter
            CMD1.Parameters.Add("@PictureParam", b);
            CMD1.Parameters.Add("@IdParam", Login.IdUser);
            if (cmd.ExecuteNonQuery() > 0 && CMD1.ExecuteNonQuery() > 0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
            this.Hide();
            CreateCV createCV = new CreateCV();
            createCV.ShowDialog();
        }
        byte[] PathToByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DescribeJob describeJob = new DescribeJob();
            describeJob.ShowDialog();
        }

        private void PtbImageUser_Click(object sender, EventArgs e)
        {

        }

        private void InformationUser_Load(object sender, EventArgs e)
        {

        }
    }
}
