using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class EditJobs : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public static int IdJobs;
        public static int countNumberJobs;
        public static int idCompany;
        public EditJobs()
        {
            InitializeComponent();
            editJob();
        }
        private void editJob()
        {

            foreach (Jobs job in ReadSQL.Jobs())
            {

                if (job.Id == ListJobsOfCompany._idJob)
                {
                    tbNameJob.Text = job.NameJob;
                    tbContact.Text = job.Contact;
                    tbDecribeJob.Text = job.DescribeJob;
                    tbPositionNeeded.Text = job.PositionNeeded;
                    tbRecruit.Text = job.NumberOfRecruit;
                    tbSlary.Text = job.Salary;
                    CbAddress.Text = job.Address;
                    CbNameCompany.Text = job.CompanyName;
                    IdJobs = job.Id;
                }
            }
        }
        private void btnPost_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Jobs SET CompanyId= @CompanyId ,NameJob =@NameJob,PositionNeeded= @PositionNeeded,CompanyName=@CompanyName,Salary=@Salary,Address=@Address,PostingTime=@PostingTime,NumberOfRecruit=@NumberOfRecruit,DescribeJob=@DescribeJob, Contact=@Contact WHERE Id = @IdParam", conn);
            cmd.Parameters.Add("@CompanyId", Login.IdCompany);
            cmd.Parameters.Add("@NameJob", tbNameJob.Text);
            cmd.Parameters.Add("@PositionNeeded", tbPositionNeeded.Text);
            cmd.Parameters.Add("@CompanyName", CbNameCompany.Text);
            cmd.Parameters.Add("@Salary", tbSlary.Text);
            cmd.Parameters.Add("@Address", CbAddress.Text);
            cmd.Parameters.Add("@PostingTime", DateTime.Now.ToString("dd/MM/yyyy"));
            cmd.Parameters.Add("@NumberOfRecruit", tbRecruit.Text);
            cmd.Parameters.Add("@DescribeJob", tbDecribeJob.Text);
            cmd.Parameters.Add("@Contact", tbContact.Text);
            cmd.Parameters.Add("IdParam", IdJobs);

            if (cmd.ExecuteNonQuery() > 0)
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

            // Ket noi
            conn.Open();
            string SQL = string.Format("DELETE FROM Jobs WHERE Id ='{0}'", IdJobs);
            SqlCommand cmd = new SqlCommand(SQL, conn);

            foreach (Company company in ReadSQL.ListCompany())
            {
                if (company.Name == CbNameCompany.Text)
                {
                    countNumberJobs = company.NumberOfJobs - 1;
                    idCompany = company.Id;
                }
            }
            SqlCommand CMD1 = new SqlCommand("UPDATE Company SET NumberJobs = @NumberJobs WHERE Id = @IdParam", conn);

            // Cung cấp giá trị cho các tham số
            CMD1.Parameters.Add("@NumberJobs", countNumberJobs);
            CMD1.Parameters.Add("@IdParam", idCompany);
            if (cmd.ExecuteNonQuery() > 0 && CMD1.ExecuteNonQuery() >0 )
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
            this.Hide();
        }
    }
}