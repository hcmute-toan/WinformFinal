using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UpdateCV : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public UpdateCV()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            byte[] b = PathToByteArray(this.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CVs SET Name = @Name,Gender = @Gender,Address = @Address, DateOfBirth = @DateOfBirth, WorkExperience = @WorkExperience,EducationAndCertifications = EducationAndCertifications,ProfessionalSkills = @ProfessionalSkills,GoalsAtWork = @GoalsAtWork WHERE Id = @Id", conn);
            cmd.Parameters.Add("@Name", tbName.Text);
            cmd.Parameters.Add("@Gender", cbgender.Text);
            cmd.Parameters.Add("@Address", cbaddress.Text);
            cmd.Parameters.Add("@DateOfBirth", dtpDateOfBirth.Value.ToString("dd/MM/yyyy"));
            cmd.Parameters.Add("@WorkExperience", tbWorkExperience.Text);
            cmd.Parameters.Add("@EducationAndCertifications", tbCertifications.Text);
            cmd.Parameters.Add("@ProfessionalSkills", tbSkills.Text);
            cmd.Parameters.Add("@GoalsAtWork", tbGoalsAtWork.Text);
            cmd.Parameters.Add("@Id", DescribeJob.idCV);
            SqlCommand CMD1 = new SqlCommand("UPDATE Candidates SET Picture = @PictureParam WHERE Id = @IdParam", conn);
            // Cung cấp giá trị cho các thamSqlParameter
            CMD1.Parameters.Add("@PictureParam", b);
            CMD1.Parameters.Add("@IdParam", Login.IdUser);
            if (cmd.ExecuteNonQuery() > 0 && CMD1.ExecuteNonQuery()>0)
            {
                MessageBox.Show("successful!!!");
            }
            else
            {
                MessageBox.Show("fail!!!");
            }
            conn.Close();
        }
        byte[] PathToByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CVs WHERE Id = @Id", conn);
            cmd.Parameters.Add("@Id", DescribeJob.idCV);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("successful!!!");
            }
            else
            {
                MessageBox.Show("fail!!!");
            }
            conn.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCV createCV = new CreateCV();
            createCV.ShowDialog();
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
    }
}