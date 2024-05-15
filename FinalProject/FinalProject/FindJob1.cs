using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using LiveCharts.Wpf;
using LiveCharts;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.IO;

namespace FinalProject
{
    public partial class FindJob1 : ScalableForm
    {


        SqlConnection conn = new
       SqlConnection(Properties.Settings.Default.ConnStr);

        public static UCInformationCompanies uc;
        public static int IDCOMPANY;
        public static int IDJOB;
        public FindJob1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green500, Primary.Green500, Accent.Green200, TextShade.WHITE);

            foreach (UserAccount user in ReadSQL.Accounts())
            {
                if (user.Id == Login.IdUser)
                {
                    ptbLogoUser.Image = ConvertImage.ByteArrayToImage(user.Picture);

                }
            }
            FindJob();
            LiveChart();
            FindJobByNameAndAddress();
            ucInformationUser1.btnContinue.Click += new System.EventHandler(this.BtnContinueOfInformationUser);
            ucInformationUser1.btnBack.Click += new System.EventHandler(this.BtnBackOfInformationUser);
            ucInformationUser1.btnAddImageUser.Click += new System.EventHandler(BtnAddImageUserOfInformationUser);
        }
        #region tpFindJob
        public void FindJob()
        {
            flFindJob.Controls.Clear();
            foreach (Employers employers in ReadSQL.Company())
            {
                foreach (Jobs job in ReadSQL.Jobs())
                {
                    if (employers.Id == job.CompanyId)
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
                        UC.lbDescribeJob.Text = job.DescribeJob;
                        //UC.PtbLogoCompany.Image = ConvertImage.ByteArrayToImage(employers.Picture);
                        flFindJob.Controls.Add(UC);

                        foreach (JobLove joblove in ReadSQL.jobLoves())
                        {
                            if (job.CompanyId == joblove.IdCompany && joblove.IdUser == Login.IdUser && job.Id == joblove.IdJob)
                            {
                                UC.love2.Visible = false;
                                UC.love1.Visible = true;
                            }
                        }

                        UC.Click += (sender, e) =>
                        {
                            IDCOMPANY = job.CompanyId;
                            IDJOB = job.Id;
                            uc = UC;
                            DescribeJob describeJob = new DescribeJob();
                            describeJob.ShowDialog();
                        };

                        UC.love2.Click += (sender, e) =>
                        {
                            UC.love2.Visible = false;
                            UC.love1.Visible = true;
                            AddJoblove(job.Id, job.CompanyId);
                        };
                        UC.love1.Click += (sender, e) =>
                        {
                            UC.love1.Visible = false;
                            UC.love2.Visible = true;
                            DeleteJoblove(job.Id, job.CompanyId);
                        };


                    }
                }
            }
        }

        public void AddJoblove(int idJob, int idcompany)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Joblove values(@IdUser, @IdJob, @IdCompany)", conn);
            cmd.Parameters.Add("@IdUser", Login.IdUser);
            cmd.Parameters.Add("@IdJob", idJob);
            cmd.Parameters.Add("@IdCompany", idcompany);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Da them vao muc yeu thich!!!");
            }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
        }

        public void DeleteJoblove(int idJob, int idcompany)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM JobLove WHERE @IdUser = @IdUser AND @IdJob = @IdJob AND @IdCompany = @IdCompany", conn);
            cmd.Parameters.Add("@IdUser", Login.IdUser);
            cmd.Parameters.Add("@IdJob", idJob);
            cmd.Parameters.Add("@IdCompany", idcompany);
            if (cmd.ExecuteNonQuery() > 0)
            {

            }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();

        }
        public void FindJobByNameAndAddress()
        {

            foreach (Jobs job in ReadSQL.Jobs())
            {
                if (TbFind.Text.ToUpper().Replace(" ", "") == job.NameJob.ToUpper().Replace(" ", ""))
                {
                    UCInformationCompanies UC1 = new UCInformationCompanies();
                    UC1.lbAddress.Text = job.Address;
                    UC1.lbNameCompany.Text = job.CompanyName;
                    UC1.lbNameJob.Text = job.NameJob;
                    UC1.lbNeedPosition.Text = job.PositionNeeded;
                    UC1.lbRecruit.Text = job.NumberOfRecruit;
                    UC1.lbContact.Text = job.Contact;
                    UC1.lbTime.Text = job.PostingTime;
                    UC1.lbSalary.Text = job.Salary;
                    //this.Controls.Add(UC1);

                    flFindJob.Controls.Add(UC1);
                    UC1.Click += (sender, e) =>
                    {
                        uc = UC1;
                        DescribeJob describeJob = new DescribeJob();
                        describeJob.ShowDialog();
                    };
                }
                if (TbFind.Text.ToUpper().Replace(" ", "") == "" && cbAddress.Text.ToUpper().Replace(" ", "") == job.Address.ToUpper().Replace(" ", ""))
                {
                    UCInformationCompanies UC1 = new UCInformationCompanies();
                    UC1.lbAddress.Text = job.Address;
                    UC1.lbNameCompany.Text = job.CompanyName;
                    UC1.lbNameJob.Text = job.NameJob;
                    UC1.lbNeedPosition.Text = job.PositionNeeded;
                    UC1.lbRecruit.Text = job.NumberOfRecruit;
                    UC1.lbContact.Text = job.Contact;
                    UC1.lbTime.Text = job.PostingTime;
                    UC1.lbSalary.Text = job.Salary;
                    // this.Controls.Add(UC1);

                    flFindJob.Controls.Add(UC1);
                    UC1.Click += (sender, e) =>
                    {
                        uc = UC1;
                        DescribeJob describeJob = new DescribeJob();
                        describeJob.ShowDialog();
                    };
                }
                if (TbFind.Text.ToUpper().Replace(" ", "") == job.NameJob.ToUpper().Replace(" ", "") && cbAddress.Text.ToUpper().Replace(" ", "") == job.Address.ToUpper().Replace(" ", ""))
                {
                    UCInformationCompanies UC1 = new UCInformationCompanies();
                    UC1.lbAddress.Text = job.Address;
                    UC1.lbNameCompany.Text = job.CompanyName;
                    UC1.lbNameJob.Text = job.NameJob;
                    UC1.lbNeedPosition.Text = job.PositionNeeded;
                    UC1.lbRecruit.Text = job.NumberOfRecruit;
                    UC1.lbContact.Text = job.Contact;
                    UC1.lbTime.Text = job.PostingTime;
                    UC1.lbSalary.Text = job.Salary;
                    // this.Controls.Add(UC1);

                    flFindJob.Controls.Add(UC1);
                    UC1.Click += (sender, e) =>
                    {
                        uc = UC1;
                        DescribeJob describeJob = new DescribeJob();
                        describeJob.ShowDialog();
                    };
                }
            }
        }
        private void BtnContinueOfInformationUser(object sender, EventArgs e)
        {
    
                byte[] b = PathToByteArray(this.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into CVs values(@UserId, @Name,@Gender,@Address,@DateOfBirth,@WorkExperience,@EducationAndCertifications,@ProfessionalSkills,@GoalsAtWork)", conn);
                cmd.Parameters.Add("@UserId", Login.IdUser);
                cmd.Parameters.Add("@Name", ucInformationUser1.tbName.Text);
                cmd.Parameters.Add("@Gender", ucInformationUser1.cbgender.Text);
                cmd.Parameters.Add("@Address", ucInformationUser1.cbaddress.Text);
                cmd.Parameters.Add("@DateOfBirth", ucInformationUser1.dtpDateOfBirth.Value.ToString("dd/MM/yyyy"));
                cmd.Parameters.Add("@WorkExperience", ucInformationUser1.tbWorkExperience.Text);
                cmd.Parameters.Add("@EducationAndCertifications", ucInformationUser1.tbCertifications.Text);
                cmd.Parameters.Add("@ProfessionalSkills", ucInformationUser1.tbSkills.Text);
                cmd.Parameters.Add("@GoalsAtWork", ucInformationUser1.tbGoalsAtWork.Text);

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
        private void BtnBackOfInformationUser(object sender, EventArgs e)
        {
            tabcontrolFindJob.SelectedTab = tpfindjob;
        }
        private void BtnAddImageUserOfInformationUser(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ucInformationUser1.PtbImageUser.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        private void ptbFind_Click(object sender, EventArgs e)
        {
            FindJobByNameAndAddress();
        }
        #endregion


        #region tpChart 
        public void LiveChart()
        {
            //Bar Chart
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2015",
                    Values = new ChartValues<double> { 10, 50, 39, 50 }
                }
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2016",
                Values = new ChartValues<double> { 11, 56, 42 }
            });

            //also adding values updates and animates the chart automatically
            cartesianChart1.Series[1].Values.Add(48d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Sales Man",
                Labels = new[] { "Maria", "Susan", "Charles", "Frida" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sold Apps",
                LabelFormatter = value => value.ToString("N")
            });
        }
        #endregion

        #region tpChangePassword
        private void guna2Button5_Click(object sender, EventArgs e)
        {
    
                foreach (UserAccount a in ReadSQL.Accounts())
                {
                    if (a.Id == Login.IdUser && a.Password == txbPassword.Text)
                    {
                        conn.Open();
                        SqlCommand CMD1 = new SqlCommand("UPDATE Candidates SET Password = @Password WHERE Id = @IdParam", conn);
                        // Cung cấp giá trị cho các thamSqlParameter
                        CMD1.Parameters.Add("@Password", txbReEnterNewPassword.Text);
                        CMD1.Parameters.Add("@IdParam", Login.IdUser);

                        SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
                        CMD2.Parameters.Add("@IdLogin", Login.IdUser);
                        CMD2.Parameters.Add("@IdSender", (int)-1);
                        CMD2.Parameters.Add("@TypeLogin", (string)"Candidate");
                        CMD2.Parameters.Add("@IdReceiver", (int)-1);
                        CMD2.Parameters.Add("@IdJob", (int)-1);
                        CMD2.Parameters.Add("@Type", (string)"ChangePass");
                        CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
                        CMD2.Parameters.Add("@StatusCV", (int)-1);
                        CMD2.Parameters.Add("@Mess", (string)"");
                    if (CMD1.ExecuteNonQuery()>0&&CMD2.ExecuteNonQuery() > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Fail!!!");
                    }
                    conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password !!!");
                    }
             
            }
        }
        #endregion

        #region tpNotice
        private void ViewNotice()
        {
            flNotice.Controls.Clear();
            foreach(Notice1 a in ReadSQL.Notices1())
            {
                if(a.TypeLogin == "Candidate" && a.IdLogin == Login.IdUser)
                {
                    if(a.Type=="ChangePass")
                    {
                        UCChangePasswordNotice p = new UCChangePasswordNotice();
                        p.lbTimeChangePassword.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                        flNotice.Controls.Add(p);
                    }
                    if(a.Type=="ChangeImg")
                    {
                       UCChangeAvatarNotice p = new UCChangeAvatarNotice();
                       p.lbTimeChangePicture.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                       flNotice.Controls.Add(p);
                    }
                    if(a.Type == "Login")
                    {
                        UCLoginNotice p = new UCLoginNotice();
                        p.lbTimeLogin.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                        flNotice.Controls.Add(p);
                    }
                    if(a.Type=="StatusCV")
                    {
                        if(a.StatusCV == 0)
                        {
                            UCSubmitNotice p = new UCSubmitNotice();
                            foreach(Jobs X in  ReadSQL.Jobs())
                            {
                                if(X.Id == FindJob1.IDJOB)
                                {
                                    p.lbNameJob.Text = X.NameJob.ToString();
                                    p.lbNameCompany.Text = X.CompanyName.ToString();
                                }
                            }
                            p.lbTimeSubmit.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                            flNotice.Controls.Add(p);
                        }
                       
                    }
                }
                else if(a.TypeLogin == "Company" && a.Type=="StatusCV")
                {
                    if (a.StatusCV == 1)
                    {
                        UCAcceptCVNotice p = new UCAcceptCVNotice();
                        foreach (Jobs X in ReadSQL.Jobs())
                        {
                            if (X.Id == FindJob1.IDJOB)
                            {
                                p.lbNameJob.Text = X.NameJob.ToString();
                                p.lbNameCompany.Text = X.CompanyName.ToString();
                            }
                        }
                        p.lbTimeAccept.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                        flNotice.Controls.Add(p);
                    }
                    if (a.StatusCV == 2)
                    {
                        UCRefuseCVNotice p = new UCRefuseCVNotice();
                        foreach (Jobs X in ReadSQL.Jobs())
                        {
                            if (X.Id == FindJob1.IDJOB)
                            {
                                p.lbNameJob.Text = X.NameJob.ToString();
                                p.lbNameCompany.Text = X.CompanyName.ToString();
                            }
                        }
                        p.lbTimeRefuse.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                        flNotice.Controls.Add(p);
                    }
                }
                     
            }
        }
        #endregion

        #region tpFeedback
        #endregion

        #region tpCVSubmissionHistory
        private void ViewCVSubmissionHistory()
        {
            foreach (JobApplication a in ReadSQL.Jobapplication())
            {
                foreach (Employers b in ReadSQL.Company())
                {
                    foreach (Jobs job in ReadSQL.Jobs())
                    {
                        if (a.IdUser == Login.IdUser && a.IdCompany == b.Id && job.Id == a.IdJob)
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
                            UC.lbDescribeJob.Text = job.DescribeJob;
                            UC.PtbLogoCompany.Image = ConvertImage.ByteArrayToImage(b.Picture);
                            // this.Controls.Add(UC);
                            flHistory.Controls.Add(UC);
                            UC.Click += (sender, e) =>
                            {
                                IDCOMPANY = job.CompanyId;
                                IDJOB = job.Id;
                                Chat chat = new Chat();
                                chat.ShowDialog();
                            };
                        }

                    }
                }
            }
        }
        #endregion

        #region tpBlog
        private void blog()
        {
            foreach (Recruitment re in ReadSQL.Recruitments())
            {
                if (re.Id == Login.IdUser)
                {
                    UCRecruitment uc = new UCRecruitment();
                    uc.lbName.Text = re.Name;
                    uc.lbAge.Text = re.DateOfBirth;
                    uc.lbGender.Text = re.Gender;
                    uc.lbAddress.Text = re.Address;
                    uc.lbExperience.Text = re.WorkExperience;
                    uc.lbSkills.Text = re.ProfessionalSkills;
                    uc.lbJobApplication.Text = re.JobApplication;
                    flBlog.Controls.Add(uc);
                    uc.Click += (sender, e) =>
                    {
                        ListChat listChat = new ListChat();
                        listChat.ShowDialog();

                    };
                }
            }
        }
        #endregion

        #region tpRecruitment
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PtbImageUser.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            byte[] b = PathToByteArray(this.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Recruitment values(@UserId,@Name,@Gender,@Address,@DateOfBirth,@JobApplication,@WorkExperience,@EducationAndCertifications,@ProfessionalSkills,@GoalsAtWork,@Picture)", conn);
            cmd.Parameters.Add("@UserId", Login.IdUser);
            cmd.Parameters.Add("@Name", tbName.Text);
            cmd.Parameters.Add("@Gender", cbgender.Text);
            cmd.Parameters.Add("@Address", tbaddress.Text);
            cmd.Parameters.Add("@DateOfBirth", dtDateOfBirth.Value.ToString("dd/MM/yyyy"));
            cmd.Parameters.Add("@WorkExperience", cbExperience.Text);
            cmd.Parameters.Add("@jobApplication", tbJobApplication.Text);
            cmd.Parameters.Add("@EducationAndCertifications", tbEducation.Text);
            cmd.Parameters.Add("@ProfessionalSkills", tbSkill.Text);
            cmd.Parameters.Add("@GoalsAtWork", cbGoals.Text);
            cmd.Parameters.Add("@Picture", b);
            if (cmd.ExecuteNonQuery() > 0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
        }
       
        #endregion

        #region tpChangeAvatar
        private void btnAddImageUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PtbImageUser1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
  
                byte[] b = PathToByteArray(this.Text);
                conn.Open();
                SqlCommand CMD1 = new SqlCommand("UPDATE Candidates SET Picture = @PictureParam WHERE Id = @IdParam", conn);
                // Cung cấp giá trị cho các thamSqlParameter
                CMD1.Parameters.Add("@PictureParam", b);
                CMD1.Parameters.Add("@IdParam", Login.IdUser);

                SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
                CMD2.Parameters.Add("@IdLogin", Login.IdUser);
                CMD2.Parameters.Add("@IdSender", (int)-1);
                CMD2.Parameters.Add("@TypeLogin", (string)"Candidate");
                CMD2.Parameters.Add("@IdReceiver", (int)-1);
                CMD2.Parameters.Add("@IdJob", (int)-1);
                CMD2.Parameters.Add("@Type", (string)"ChangeImg");
                CMD2.Parameters.Add("@TimeNotice", DateTime.Now);
                CMD2.Parameters.Add("@StatusCV", (int)-1);
                CMD2.Parameters.Add("@Mess", (string)"");
            if (CMD1.ExecuteNonQuery() > 0 && CMD2.ExecuteNonQuery() > 0)
            {

            }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
 
        }


        #endregion

        #region control
        private void tabcontrolFindJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage currentTab = tabcontrolFindJob.SelectedTab;
            if (currentTab != null)
            {
                if (currentTab.Name == tpfindjob.Name)
                {
                    FindJob();
                }
                else if (currentTab.Name == tpstatistics.Name)
                {
                    LiveChart();
                }
                else if (currentTab.Name == tpCreatecv.Name)
                {

                }
                else if (currentTab.Name == tpHistory.Name)
                {
                    ViewCVSubmissionHistory();
                }
                else if(currentTab.Name==tpnotice.Name)
                {
                    ViewNotice();
                }
                else if(currentTab.Name == tpBlog.Name)
                {
                    blog();
                }
                
                else if (currentTab.Name == tplogout.Name)
                {
                    this.Hide();
             
                    Login login = new Login();
                    login.ShowDialog();
                }
            }

        }
        #endregion
        private void tpCreateCV_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void ucInformationUser1_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpfindjob_Click(object sender, EventArgs e)
        {

        }

        private void tplogout_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tpchangepassword_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tpnotice_Click(object sender, EventArgs e)
        {

        }

        private void ptbLogoUser_Click(object sender, EventArgs e)
        {

        }

        private void lbNameUser_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void tpfeedback_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flFindJob_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void tpchangeavatar_Click(object sender, EventArgs e)
        {

        }

        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ptbLogoTTT_Click(object sender, EventArgs e)
        {

        }

        private void tpstatistics_Click(object sender, EventArgs e)
        {

        }

       

        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucInformationUser1_Load_1(object sender, EventArgs e)
        {

        }

        private void TbFind_TextChanged(object sender, EventArgs e)
        {

        }

      
       

        private void tpHistory_Click(object sender, EventArgs e)
        {

        }

        private void PtbImageUser_Click(object sender, EventArgs e)
        {

        }
    }
}
