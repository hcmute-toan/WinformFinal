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
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace FinalProject
{
    public partial class InformationOfCompany : Form
    {

        SqlConnection conn = new
       SqlConnection(Properties.Settings.Default.ConnStr);
        public static int Status;
        public InformationOfCompany()
        {
            InitializeComponent();
            FindNameCompanySame();
        }
        byte[] PathToByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        string logo;
        string cover;
        private void guna2CirclePictureBox3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbCoverImage.Image = System.Drawing.Image.FromFile(open.FileName);
                cover = open.FileName;
            }
        }


        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbLogoImage.Image = System.Drawing.Image.FromFile(open.FileName);
                logo = open.FileName;
            }
        }
        
        private void FindNameCompanySame()
        {
            
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            foreach (Company company in ReadSQL.ListCompany())
            {
                if (company.Name == txtName.Text)
                {
                    Status = 1;
                }
            }

            byte[] logoiamge = PathToByteArray(logo);
            byte[] coverimage = PathToByteArray(cover);
            int i = 0;
            conn.Open();
            if (Status == 1)
            {
                MessageBox.Show("The company name already exists,Please change the company name to another company \n Example:"+ txtName.Text+"123");
                Status = 0;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Company values(@NumberJobs,@IdEmployer,@Name ,@Gmail ,@Phone ,@Field ,@Address , @CompanySize, @Descibe , @logo , @coverimage )", conn);
                cmd.Parameters.Add("@NumberJobs", i);
                cmd.Parameters.Add("@Name", txtName.Text);
                cmd.Parameters.Add("@Gmail", txtEmail.Text);
                cmd.Parameters.Add("@Phone", txtPhone.Text);
                cmd.Parameters.Add("@Field", CbField.Text);
                cmd.Parameters.Add("@Address", txtAddress.Text);
                cmd.Parameters.Add("@Descibe", txtDescribe.Text);
                cmd.Parameters.Add("@CompanySize", Cbsize.Text);
                cmd.Parameters.Add("@IdEmployer", Login.IdCompany.ToString());
                cmd.Parameters.Add("@logo", logoiamge);
                cmd.Parameters.Add("@coverimage", coverimage);
                if (cmd.ExecuteNonQuery() > 0)
                { MessageBox.Show("Succcess!!!"); }
                else
                {
                    MessageBox.Show("Fail!!!");
                }
                conn.Close();
            }
        }
 
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
