using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ListJobsOfCompany : Form
    {
        public static int _idJob;
        public ListJobsOfCompany()
        {
            InitializeComponent();
            listjob();
        }
        private void listjob()
        {
            panelListJobOfCompany.Controls.Clear();

                foreach (Jobs job in ReadSQL.Jobs())
                {
                    if (FindAvalabeCompany.nameCompany == job.CompanyName)
                    {
               
                        UCInformationCompanies UC= new UCInformationCompanies();
                        UC.lbAddress.Text = job.Address;
                        UC.lbNameCompany.Text = job.CompanyName;
                        UC.lbNameJob.Text = job.NameJob;
                        UC.lbNeedPosition.Text = job.PositionNeeded;
                        UC.lbRecruit.Text = job.NumberOfRecruit;
                        UC.lbContact.Text = job.Contact;
                        UC.lbTime.Text = job.PostingTime;
                        UC.lbSalary.Text = job.Salary;
                        UC.PtbLogoCompany.Image = ConvertImage.ByteArrayToImage(FindAvalabeCompany.imageJobs);
                        this.Controls.Add(UC);
                        panelListJobOfCompany.Controls.Add(UC);
                        UC.Click += (sender, e) =>
                        {
                            _idJob = job.Id;
                            EditJobs edit= new EditJobs();
                            edit.ShowDialog();
                            listjob();
                        };
                    }    
            }
        }
        private void SearchCompany()
        {
            panelListJobOfCompany.Controls.Clear();
            foreach (Jobs job in ReadSQL.Jobs())
            {
                if (TbFind.Text.ToUpper().Replace(" ", "") == job.NameJob.ToUpper().Replace(" ", ""))
                {
                    UCInformationCompanies UC = new UCInformationCompanies();
                    UC.lbAddress.Text = job.Address;
                    UC.lbNameCompany.Text = job.CompanyName;
                    UC.lbNameJob.Text = job.NameJob;
                    UC.lbNeedPosition.Text = job.PositionNeeded;
                    UC.lbRecruit.Text = job.NumberOfRecruit;
                    UC.lbContact.Text = job.Contact;
                    UC.lbTime.Text = job.PostingTime;
                    UC.lbSalary.Text = job.Salary;
                    UC.PtbLogoCompany.Image = ConvertImage.ByteArrayToImage(FindAvalabeCompany.imageJobs);
                    this.Controls.Add(UC);
                    panelListJobOfCompany.Controls.Add(UC);
                    UC.Click += (sender, e) =>
                    {
                        _idJob = job.Id;
                        EditJobs edit = new EditJobs();
                        edit.ShowDialog();
                        listjob();
                    };
                }
            }
        }
        private void TbFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCompany();
        }
    }
}
