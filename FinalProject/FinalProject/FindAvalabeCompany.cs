using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FindAvalabeCompany : Form
    {
        public static UcChangeInforCompany uc;
        public static int IdInforCompany;
        public static string nameCompany;
        public static byte[] imageJobs; 
        public FindAvalabeCompany()
        {       
            InitializeComponent();
            ReadlistCompany();

        }
        private void ReadlistCompany()
        {
            PanelAvalableCompany.Controls.Clear();

            foreach (Company company in ReadSQL.ListCompany())
            {
                if (company.IdEmployer == Login.IdCompany.ToString())
                {
                   
                    UcChangeInforCompany UC = new UcChangeInforCompany();
                    UC.lbAddress.Text = company.Address;
                    UC.lbNameCompany.Text = company.Name;
                    UC.lbDescribe.Text = company.Descibe;
                    UC.lbField.Text = company.Field;
                    UC.lbgmail.Text = company.Gmail;
                    UC.ptbCoverImage.Image = ConvertImage.ByteArrayToImage(company.Coverimage);
                    UC.ptbLogo.Image = ConvertImage.ByteArrayToImage(company.Logo);
                    UC.lblNumberJobs.Text = company.NumberOfJobs.ToString();

                    this.Controls.Add(UC);

                    PanelAvalableCompany.Controls.Add(UC);
                    UC.Click += (sender, e) =>
                    {
                        uc = UC;
                        IdInforCompany = company.Id;
                        UpdateInformationCompany updateinforCompany = new UpdateInformationCompany();
                        updateinforCompany.ShowDialog();
                        ReadlistCompany();
                    };
                    UC.btneditConapny.Click += (sender, e) =>
                    {
                        uc = UC;
                        IdInforCompany = company.Id;
                        UpdateInformationCompany updateinforCompany = new UpdateInformationCompany();
                        updateinforCompany.ShowDialog();
      
                        ReadlistCompany();
                    };
                    UC.btnEditJobs.Click += (sender, e) =>
                    {
                        imageJobs = company.Logo;
                        nameCompany = company.Name;
                        ListJobsOfCompany listjob = new ListJobsOfCompany();
                        listjob.ShowDialog();
                 
                        ReadlistCompany();

                    };
                }
            }
        }
        private void SearchCompany()
        {
            PanelAvalableCompany.Controls.Clear();
            foreach (Company company in ReadSQL.ListCompany())
            {
                if (TbFind.Text.ToUpper().Replace(" ", "") == company.Name.ToUpper().Replace(" ", ""))
                {
                    UcChangeInforCompany UC = new UcChangeInforCompany();
                    UC.lbAddress.Text = company.Address;
                    UC.lbNameCompany.Text = company.Name;
                    UC.lbDescribe.Text = company.Descibe;
                    UC.lbField.Text = company.Field;
                    UC.lbgmail.Text = company.Gmail;
                    UC.ptbCoverImage.Image = ConvertImage.ByteArrayToImage(company.Coverimage);
                    UC.ptbLogo.Image = ConvertImage.ByteArrayToImage(company.Logo);

                    this.Controls.Add(UC);

                    PanelAvalableCompany.Controls.Add(UC);
                    UC.Click += (sender, e) =>
                    {
                        uc = UC;
                        IdInforCompany = company.Id;
                        UpdateInformationCompany updateinforCompany = new UpdateInformationCompany();
                        updateinforCompany.ShowDialog();
                 
                        ReadlistCompany();
                    };
                    UC.btneditConapny.Click += (sender, e) =>
                    {
                        uc = UC;
                        IdInforCompany = company.Id;
                        UpdateInformationCompany updateinforCompany = new UpdateInformationCompany();
                        updateinforCompany.ShowDialog();
          
                        ReadlistCompany();
                    };
                    UC.btnEditJobs.Click += (sender, e) =>
                    {

                        nameCompany= company.Name;
                        MessageBox.Show(nameCompany);
                        ListJobsOfCompany listjob = new ListJobsOfCompany();
                        listjob.ShowDialog();
          
                        ReadlistCompany();
                    };


                }
            }

        }
        public void ResetFlowLayoutPanel()
        {

            PanelAvalableCompany.Controls.Clear();// Xóa tất cả các controls trong FlowLayoutPanel
                                            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SearchCompany();
        }
    }
}
