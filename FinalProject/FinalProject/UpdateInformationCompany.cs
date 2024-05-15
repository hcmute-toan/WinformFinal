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
    public partial class UpdateInformationCompany : Form

    {
        SqlConnection conn = new
      SqlConnection(Properties.Settings.Default.ConnStr);
        public static byte[] coverImagebyte;
        public static byte[] logoImagebyte;
        public static string nameCompany;

        public UpdateInformationCompany()
        {
            InitializeComponent();
            CompanyUpdate();
        }
        private void CompanyUpdate()
        {
            foreach (Company company in ReadSQL.ListCompany())
            {
  
                if (company.Id == FindAvalabeCompany.IdInforCompany)
                {
                    txtName.Text = company.Name;
                    nameCompany=company.Name;
                    CbField.Text = company.Field;
                    txtPhone.Text = company.Phone;
                    txtAddress.Text = company.Address;
                    txtDescribe.Text = company.Descibe;
                    txtEmail.Text = company.Gmail;
                    Cbsize.Text= company.CompanySize;
                    coverImagebyte = company.Coverimage;
                    logoImagebyte = company.Logo;
                    ptbCoverImage.Image = ConvertImage.ByteArrayToImage(company.Coverimage);
                    ptbLogoImage.Image = ConvertImage.ByteArrayToImage(company.Logo);
                }
            }
        }
        byte[] PathToByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        string logo;
        string cover;
        public static int statuslogo = 0;
        public static int statuscover = 0;
        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbCoverImage.Image = System.Drawing.Image.FromFile(open.FileName);
                cover = open.FileName;
                statuscover = 1;
                
            }
        }


        private void guna2CirclePictureBox2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbLogoImage.Image = System.Drawing.Image.FromFile(open.FileName);
                logo = open.FileName;
                statuslogo = 1;
            }
        }

        byte[] coverimage;
        byte[] logoiamge;
        private void btnContinue_Click(object sender, EventArgs e)
        {
            //byte[] logoiamge;
            if (statuslogo == 1)
            {
                 logoiamge = PathToByteArray(logo);
            }
            else if (statuslogo == 0 )
            {
                logoiamge = logoImagebyte;
            }
            //byte[] coverimage ;
            if(statuscover ==1 )
            {
                coverimage = PathToByteArray(cover);
            }
            else if( statuscover ==0 )
            {
                coverimage = coverImagebyte;
            }
            conn.Open();
            SqlCommand CMD1 = new SqlCommand("UPDATE Company SET Name = @Name, Gmail = @Gmail, Phone = @Phone, Field = @Field, Address = @Address, CompanySize = @CompanySize, Descibe = @Descibe, logo = @logo, coverImage = @coverImage WHERE Id = @IdParam", conn);

            // Cung cấp giá trị cho các tham số
            CMD1.Parameters.Add("@Name", txtName.Text);
            CMD1.Parameters.Add("@Field", CbField.Text);
            CMD1.Parameters.Add("@Phone", txtPhone.Text);
            CMD1.Parameters.Add("@Address", txtAddress.Text);
            CMD1.Parameters.Add("@Descibe", txtDescribe.Text);
            CMD1.Parameters.Add("@Gmail", txtEmail.Text);
            CMD1.Parameters.Add("@CompanySize", Cbsize.Text);
            CMD1.Parameters.Add("@logo", logoiamge);
            CMD1.Parameters.Add("@coverImage", coverimage);

            CMD1.Parameters.Add("@IdParam", FindAvalabeCompany.IdInforCompany);
            if (CMD1.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thành công!!!");
            }
            else
            {
                MessageBox.Show("Thất bại!!!");
            }
            conn.Close();
            this.Hide();

        }
        private void btnDelete()
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM Company WHERE Id ='{0}'", FindAvalabeCompany.IdInforCompany);
                string SQL1 = string.Format("DELETE FROM Jobs WHERE CompanyName ='{0}'",nameCompany);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                SqlCommand cmd1 = new SqlCommand(SQL1, conn);
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                    MessageBox.Show("delete success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Fail" + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnDele_Click_1(object sender, EventArgs e)
        {
            btnDelete();
            this.Hide();
        }
    }
}
