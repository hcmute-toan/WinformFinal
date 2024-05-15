using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AcceptCVs : Form
    {
        public static CV cvtmp;
        public static int  idCv;
        public static int _idUser;
        string Consider = "CV is being considered";
        string Accpeted = "CV has been accepted";
        string Deny = "CV has been deny";

        public AcceptCVs()
        {
            //flAcceptCVs.Controls.Clear();
            InitializeComponent();
            AcceptCvs();

        }
        private void FindAccpetCvs()
        {
            int i = 0;
            flAcceptCVs.Controls.Clear();
            if (CBStatus.Text == Consider || CBStatus.Text == "")
            {
                foreach (CV cv in ReadSQL.Cvs())
                {
                    foreach (JobApplication japp in ReadSQL.Jobapplication())
                    {
                        if (cv.Id == japp.IdUser && CreateJob._idJob == japp.IdJob && cv.IdCv == japp.IdCv && japp.Status == 0 )
                        {
                            if (TbFind.Text.ToUpper().Replace(" ", "") == cv.Name.ToUpper().Replace(" ", "") || TbFind.Text.ToUpper().Replace(" ", "") == "")
                            {
                                UCInformationCV uc2 = new UCInformationCV();
                                if (japp.IdUser == cv.Id)
                                {
                                    foreach (JobApplication jobaply in ReadSQL.Jobapplication())
                                    {

                                        if (jobaply.IdJob == CreateJob._idJob && cv.IdCv == jobaply.IdCv && jobaply.IdUser == cv.Id && jobaply.Status == 0)
                                        {
                                            i++;
                                        }
                                    }

                                    lbNumberCandidate.Text = i.ToString();
                                    _idUser = cv.IdCv;

                                    uc2.lbName.Text = cv.Name;
                                    uc2.lbAge.Text = cv.DateOfBirth;
                                    uc2.lbGender.Text = cv.Gender;
                                    uc2.lbAddress.Text = cv.Address;
                                    uc2.lbSkills.Text = cv.ProfessionalSkills;
                                    uc2.lbExperience.Text = cv.WorkExperience;
                                    uc2.TopLevel = false;
                                    //this.Controls.Add(uc2);
                                    flAcceptCVs.Controls.Add(uc2);
                                    uc2.Show();
                                    uc2.Click += (sender, e) =>
                                    {
                                        idCv = cv.IdCv;
                                        cvtmp = cv;
                                        AcceptCV acceptCV = new AcceptCV();
                                        acceptCV.ShowDialog();
                                        AcceptCvs();
                                    };
                                }
                            }
                        }
                    }
                }
            }
            else if( CBStatus.Text == Deny)
            {
                foreach (CV cv in ReadSQL.Cvs())
                {
                    foreach (JobApplication japp in ReadSQL.Jobapplication())
                    {
                        if (cv.Id == japp.IdUser && CreateJob._idJob == japp.IdJob && cv.IdCv == japp.IdCv && japp.Status == 2)
                        {
                            if (TbFind.Text.ToUpper().Replace(" ", "") == cv.Name.ToUpper().Replace(" ", "") || TbFind.Text.ToUpper().Replace(" ", "") == "")
                            {
                                UCInformationCV uc2 = new UCInformationCV();
                                if (japp.IdUser == cv.Id)
                                {
                                    foreach (JobApplication jobaply in ReadSQL.Jobapplication())
                                    {

                                        if (jobaply.IdJob == CreateJob._idJob && cv.IdCv == jobaply.IdCv && jobaply.IdUser == cv.Id && jobaply.Status == 2)
                                        {
                                            i++;
                                        }
                                    }

                                    lbNumberCandidate.Text = i.ToString();
                                    _idUser = cv.IdCv;

                                    uc2.lbName.Text = cv.Name;
                                    uc2.lbAge.Text = cv.DateOfBirth;
                                    uc2.lbGender.Text = cv.Gender;
                                    uc2.lbAddress.Text = cv.Address;
                                    uc2.lbSkills.Text = cv.ProfessionalSkills;
                                    uc2.lbExperience.Text = cv.WorkExperience;
                                    uc2.TopLevel = false;
                                    //this.Controls.Add(uc2);
                                    flAcceptCVs.Controls.Add(uc2);
                                    uc2.Show();
                                    uc2.Click += (sender, e) =>
                                    {
                                        idCv = cv.IdCv;
                                        cvtmp = cv;
                                        AcceptCV acceptCV = new AcceptCV();
                                        acceptCV.ShowDialog();
                                        AcceptCvs();
                                    };
                                }
                            }
                        }
                    }
                }
            }
            else if( CBStatus.Text == Accpeted )
            {
                foreach (CV cv in ReadSQL.Cvs())
                {
                    foreach (JobApplication japp in ReadSQL.Jobapplication())
                    {
                        if (cv.Id == japp.IdUser && CreateJob._idJob == japp.IdJob && cv.IdCv == japp.IdCv && japp.Status == 1)
                        {
                            if (TbFind.Text.ToUpper().Replace(" ", "") == cv.Name.ToUpper().Replace(" ", "") || TbFind.Text.ToUpper().Replace(" ", "") == "")
                            {
                                UCInformationCV uc2 = new UCInformationCV();
                                if (japp.IdUser == cv.Id)
                                {
                                    foreach (JobApplication jobaply in ReadSQL.Jobapplication())
                                    {

                                        if (jobaply.IdJob == CreateJob._idJob && cv.IdCv == jobaply.IdCv && jobaply.IdUser == cv.Id && jobaply.Status ==1 )
                                        {
                                            i++;
                                        }
                                    }

                                    lbNumberCandidate.Text = i.ToString();
                                    _idUser = cv.IdCv;

                                    uc2.lbName.Text = cv.Name;
                                    uc2.lbAge.Text = cv.DateOfBirth;
                                    uc2.lbGender.Text = cv.Gender;
                                    uc2.lbAddress.Text = cv.Address;
                                    uc2.lbSkills.Text = cv.ProfessionalSkills;
                                    uc2.lbExperience.Text = cv.WorkExperience;
                                    uc2.TopLevel = false;
                                    //this.Controls.Add(uc2);
                                    flAcceptCVs.Controls.Add(uc2);
                                    uc2.Show();
                                    uc2.Click += (sender, e) =>
                                    {
                                        idCv = cv.IdCv;
                                        cvtmp = cv;
                                        AcceptCV acceptCV = new AcceptCV();
                                        acceptCV.ShowDialog();
                                        AcceptCvs();
                                    };
                                }
                            }
                        }
                    }
                }
            }    
          
        }

//
        private void AcceptCvs()
        {
            int i = 0;
            flAcceptCVs.Controls.Clear();
            if (CBStatus.Text == Consider || CBStatus.Text=="")
            {
                foreach (CV cv in ReadSQL.Cvs())
                {
                    foreach (JobApplication japp in ReadSQL.Jobapplication())
                    {
                        if (cv.Id == japp.IdUser && CreateJob._idJob == japp.IdJob && cv.IdCv == japp.IdCv && japp.Status == 0)
                        {
                            {
                                UCInformationCV uc2 = new UCInformationCV();
                                if (japp.IdUser == cv.Id)
                                {
                                    foreach (JobApplication jobaply in ReadSQL.Jobapplication())
                                    {

                                        if (jobaply.IdJob == CreateJob._idJob && cv.IdCv == jobaply.IdCv && jobaply.IdUser == cv.Id && jobaply.Status == 0)
                                        {
                                            i++;
                                        }
                                    }

                                    lbNumberCandidate.Text = i.ToString();
                                    _idUser = cv.IdCv;

                                    uc2.lbName.Text = cv.Name;
                                    uc2.lbAge.Text = cv.DateOfBirth;
                                    uc2.lbGender.Text = cv.Gender;
                                    uc2.lbAddress.Text = cv.Address;
                                    uc2.lbSkills.Text = cv.ProfessionalSkills;
                                    uc2.lbExperience.Text = cv.WorkExperience;
                                    uc2.TopLevel = false;
                                    //this.Controls.Add(uc2);
                                    flAcceptCVs.Controls.Add(uc2);
                                    uc2.Show();
                                    uc2.Click += (sender, e) =>
                                    {
                                        idCv = cv.IdCv;
                                        cvtmp = cv;
                                        AcceptCV acceptCV = new AcceptCV();
                                        acceptCV.ShowDialog();
                                        AcceptCvs();
                                    };
                                }
                            }

                        }
                    }
                }
            }
            else if (CBStatus.Text == Deny)
            {
                foreach (CV cv in ReadSQL.Cvs())
                {
                    foreach (JobApplication japp in ReadSQL.Jobapplication())
                    {
                        if (cv.Id == japp.IdUser && CreateJob._idJob == japp.IdJob && cv.IdCv == japp.IdCv && japp.Status == 2)
                        {
                            UCInformationCV uc2 = new UCInformationCV();
                            if (japp.IdUser == cv.Id)
                            {
                                foreach (JobApplication jobaply in ReadSQL.Jobapplication())
                                {

                                    if (jobaply.IdJob == CreateJob._idJob && cv.IdCv == jobaply.IdCv && jobaply.IdUser == cv.Id && jobaply.Status == 2)
                                    {
                                        i++;
                                    }
                                }

                                lbNumberCandidate.Text = i.ToString();
                                _idUser = cv.IdCv;

                                uc2.lbName.Text = cv.Name;
                                uc2.lbAge.Text = cv.DateOfBirth;
                                uc2.lbGender.Text = cv.Gender;
                                uc2.lbAddress.Text = cv.Address;
                                uc2.lbSkills.Text = cv.ProfessionalSkills;
                                uc2.lbExperience.Text = cv.WorkExperience;
                                uc2.TopLevel = false;
                                //this.Controls.Add(uc2);
                                flAcceptCVs.Controls.Add(uc2);
                                uc2.Show();
                                uc2.Click += (sender, e) =>
                                {
                                    idCv = cv.IdCv;
                                    cvtmp = cv;
                                    AcceptCV acceptCV = new AcceptCV();
                                    acceptCV.ShowDialog();
                                    AcceptCvs();
                                };
                            }
                        }

                    }
                }
            }
            else if (CBStatus.Text == Accpeted)
            {
                foreach (CV cv in ReadSQL.Cvs())
                {
                    foreach (JobApplication japp in ReadSQL.Jobapplication())
                    {
                        if (cv.Id == japp.IdUser && CreateJob._idJob == japp.IdJob && cv.IdCv == japp.IdCv && japp.Status == 1)
                        {

                            UCInformationCV uc2 = new UCInformationCV();
                            if (japp.IdUser == cv.Id)
                            {
                                foreach (JobApplication jobaply in ReadSQL.Jobapplication())
                                {

                                    if (jobaply.IdJob == CreateJob._idJob && cv.IdCv == jobaply.IdCv && jobaply.IdUser == cv.Id && jobaply.Status ==1 )
                                    {
                                        i++;
                                    }
                                }

                                lbNumberCandidate.Text = i.ToString();
                                _idUser = cv.IdCv;

                                uc2.lbName.Text = cv.Name;
                                uc2.lbAge.Text = cv.DateOfBirth;
                                uc2.lbGender.Text = cv.Gender;
                                uc2.lbAddress.Text = cv.Address;
                                uc2.lbSkills.Text = cv.ProfessionalSkills;
                                uc2.lbExperience.Text = cv.WorkExperience;
                                uc2.TopLevel = false;
                                //this.Controls.Add(uc2);
                                flAcceptCVs.Controls.Add(uc2);
                                uc2.Show();
                                uc2.Click += (sender, e) =>
                                {
                                    idCv = cv.IdCv;
                                    cvtmp = cv;
                                    AcceptCV acceptCV = new AcceptCV();
                                    acceptCV.ShowDialog();
                                    AcceptCvs();
                                };
                            }
                        }

                    }
                }
            }


          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AcceptCVs_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            FindAccpetCvs();
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindAccpetCvs();
            AcceptCvs();
        }
    }
}
