using Guna.UI2.AnimatorNS;
using MaterialSkin;
using MaterialSkin.Controls;
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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{

    public partial class CreateJob : MaterialForm
    {
        public static int IDCOMPANY;
        public static int IDUSER;
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.ConnStr);
        public static int _idJob;
        public static int count = 0;
        public static int idCompany;
        int numbercandidate = 0;
        public CreateJob()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            foreach (Employers employers in ReadSQL.Company())
            {
                if (employers.Id == Login.IdCompany)
                {
                    ptcLogoemployer.Image = ConvertImage.ByteArrayToImage(employers.Picture);
                    PtbImageUser1.Image = ConvertImage.ByteArrayToImage(employers.Picture);
                }
            }


            AcceptCv();
            LoadDataIntoComboBox();
        }
        private void AcceptCv()
        {
            flowLayoutPanelCheckCv.Controls.Clear();
            foreach (Company company in ReadSQL.ListCompany())
            {
                foreach (Jobs job in ReadSQL.Jobs())
                {
                    if (Login.IdCompany == job.CompanyId && job.CompanyName == company.Name)
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
                        UC1.PtbLogoCompany.Image = ConvertImage.ByteArrayToImage(company.Logo);
                        this.Controls.Add(UC1);
                        flowLayoutPanelCheckCv.Controls.Add(UC1);
                        UC1.Click += (sender, e) =>
                        {

                            _idJob = job.Id;
                            AcceptCVs ac = new AcceptCVs();
                            ac.ShowDialog();
                        };
                    }
                }
            }
        }
        private void FindJobsOfAcceptCv()
        {
            flowLayoutPanelCheckCv.Controls.Clear();
            foreach (Company company in ReadSQL.ListCompany())
            {
                foreach (Jobs job in ReadSQL.Jobs())
                {
                    if (Login.IdCompany == job.CompanyId && job.CompanyName == company.Name)
                    {
                        if (TbFindJobs.Text.ToUpper().Replace(" ", "") == job.NameJob.ToUpper().Replace(" ", "") || TbFindJobs.Text.ToUpper().Replace(" ", "") == "")
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
                            UC1.PtbLogoCompany.Image = ConvertImage.ByteArrayToImage(company.Logo);
                            this.Controls.Add(UC1);
                            flowLayoutPanelCheckCv.Controls.Add(UC1);
                            UC1.Click += (sender, e) =>
                            {
                                _idJob = job.Id;
                                AcceptCVs ac = new AcceptCVs();
                                ac.ShowDialog();
                            };
                        }
                    }
                }
            }
        }


        private Form activeForm;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelInformationCompany.Controls.Add(childForm);
            panelInformationCompany.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
        byte[] PathToByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        //private void guna2Button6_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        PtbImageLogoCompany.Image = System.Drawing.Image.FromFile(open.FileName);
        //        this.Text = open.FileName;
        //    }
        //}

        #region Blog
        private void blog()
        {
            foreach (Recruitment re in ReadSQL.Recruitments())
            {
                UCRecruitment uc = new UCRecruitment();
                uc.lbName.Text = re.Name;
                uc.lbAge.Text = re.DateOfBirth;
                uc.lbGender.Text = re.Gender;
                uc.lbAddress.Text = re.Address;
                uc.lbExperience.Text = re.WorkExperience;
                uc.lbSkills.Text = re.ProfessionalSkills;
                uc.lbJobApplication.Text = re.JobApplication;
                flFreeCandidate.Controls.Add(uc);
                uc.Click += (sender, e) =>
                {
                    IDUSER = re.Id;
                    ChatEp chat = new ChatEp();
                    chat.ShowDialog();
                };
            }
        }
        #endregion
        #region controls
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage currentTab = tabControl.SelectedTab;
            if (currentTab != null)
            {
                if (currentTab.Name == tpFreeCandidate.Name)
                {
                    blog();
                }
                else if (currentTab.Name == tpNotice.Name)
                {
                    flNotice.Controls.Clear();
                    foreach (Notice1 a in ReadSQL.Notices1())
                    {
                        if (a.TypeLogin == "Company" && a.IdLogin == Login.IdCompany)
                        {
                            if (a.Type == "ChangePass")
                            {
                                UCChangePasswordNotice p = new UCChangePasswordNotice();
                                p.lbTimeChangePassword.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                                flNotice.Controls.Add(p);
                            }
                            if (a.Type == "ChangeImg")
                            {
                                UCChangeAvatarNotice p = new UCChangeAvatarNotice();
                                p.lbTimeChangePicture.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                                flNotice.Controls.Add(p);
                            }
                            if (a.Type == "Login")
                            {
                                UCLoginNotice p = new UCLoginNotice();
                                p.lbTimeLogin.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                                flNotice.Controls.Add(p);
                            }
                            if (a.Type == "StatusCV")
                            {
                                if (a.StatusCV == 1)
                                {
                                    UCCompanyAcceptCV p = new UCCompanyAcceptCV();
                                    foreach (CV X in ReadSQL.Cvs())
                                    {
                                        if (X.Id == AcceptCVs._idUser)
                                        {
                                            p.lbName.Text = X.Name.ToString();
                                            p.lbAddress.Text = X.Address.ToString();
                                        }
                                    }
                                    p.lbTimeAccept.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                                    flNotice.Controls.Add(p);
                                }
                                if (a.StatusCV == 2)
                                {
                                    UCCompanyDenyCV p = new UCCompanyDenyCV();
                                    foreach (CV X in ReadSQL.Cvs())
                                    {
                                        if (X.Id == AcceptCVs._idUser)
                                        {
                                            p.lbName.Text = X.Name.ToString();
                                            p.lbAddress.Text = X.Address.ToString();
                                        }
                                    }
                                    p.lbTimeRefuse.Text = a.TimeNotice.ToString("dd/MM/yyyy HH:mm:ss");
                                    flNotice.Controls.Add(p);
                                }
                            }
                        }
                    }
                }
                else if (currentTab.Name == tpLogout.Name)
                {
                    this.Hide();
                    this.Close();
                    Login login = new Login();
                    login.ShowDialog();
                }
            }
        }
        #endregion
        private void reloadAdd()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Jobs values(@CompanyId ,@NameJob,@PositionNeeded,@CompanyName,@Salary,@Address,@PostingTime,@NumberOfRecruit,@DescribeJob,@Contact )", conn);
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


            foreach (Company company in ReadSQL.ListCompany())
            {
                if (company.Name == CbNameCompany.Text)
                {
                    count = company.NumberOfJobs + 1;
                    idCompany = company.Id;
                }
            }
            SqlCommand CMD1 = new SqlCommand("UPDATE Company SET NumberJobs = @NumberJobs WHERE Id = @IdParam", conn);

            // Cung cấp giá trị cho các tham số
            CMD1.Parameters.Add("@NumberJobs", count);
            CMD1.Parameters.Add("@IdParam", idCompany);
            if (cmd.ExecuteNonQuery() > 0 && CMD1.ExecuteNonQuery() > 0)
            { MessageBox.Show("Succcess!!!"); }
            else
            {
                MessageBox.Show("Fail!!!");
            }
            conn.Close();
        }
        private bool IsStrongPassword(string password)
        {
            // Kiểm tra xem mật khẩu có ít nhất một chữ in hoa, một chữ số và một ký tự đặc biệt hay không.
            bool hasUpperCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    hasSpecialChar = true;
                }
            }
            return hasUpperCase && hasDigit && hasSpecialChar;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FindAvalabeCompany());
            AcceptCv();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadDataNameCompany();


        }
        private void loadDataNameCompany()
        {
            InformationOfCompany informationOfCompany = new InformationOfCompany();
            openChildForm(informationOfCompany);
            informationOfCompany.btnContinue.Click += (sender, e) =>
            {
                openChildForm(new InformationOfCompany());
                LoadDataIntoComboBox();
                AcceptCv();
            };
        }
        private void PtbImageLogoCompany_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void changeProfile()
        {

        }


        private void btnAddImageLogoCompany_Click(object sender, EventArgs e)
        {

        }



        //private void CreateJob_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'dataSetCompany.Company' table. You can move, or remove it, as needed.
        //    CreateJob_Load1();


        //}

        private void btnPost_Click(object sender, EventArgs e)
        {
            reloadAdd();
            openChildForm(new FindAvalabeCompany());
            AcceptCv();
        }
        private void LoadDataIntoComboBox()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Company WHERE IdEmployer = @IdEmployer", conn);
            cmd.Parameters.AddWithValue("@IdEmployer", Login.IdCompany);
            // Thực thi truy vấn
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                CbNameCompany.Items.Clear();
                while (reader.Read())
                {
                    CbNameCompany.Items.Add(reader["Name"].ToString());
                }
            }

            conn.Close();
        }

        private void TbFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbFindCompany_Click(object sender, EventArgs e)
        {
            FindJobsOfAcceptCv();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            AcceptCv();
        }

        private void btnAddImageUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PtbImageUser1.Image = System.Drawing.Image.FromFile(open.FileName);
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
            CMD2.Parameters.Add("@IdLogin", Login.IdCompany);
            CMD2.Parameters.Add("@IdSender", (int)-1);
            CMD2.Parameters.Add("@TypeLogin", (string)"Company");
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            foreach (Employers a in ReadSQL.Company())
            {
                if (a.Id == Login.IdUser && a.Password == txbPassword.Text)
                {
                    conn.Open();
                    SqlCommand CMD1 = new SqlCommand("UPDATE Candidates SET Password = @Password WHERE Id = @IdParam", conn);
                    // Cung cấp giá trị cho các thamSqlParameter
                    CMD1.Parameters.Add("@Password", txbReEnterNewPassword.Text);
                    CMD1.Parameters.Add("@IdParam", Login.IdUser);

                    SqlCommand CMD2 = new SqlCommand("insert into Notice1 values(@IdLogin,@TypeLogin,@IdSender,@IdReceiver,@IdJob,@Type,@TimeNotice,@StatusCV,@Mess)", conn);
                    CMD2.Parameters.Add("@IdLogin", Login.IdCompany);
                    CMD2.Parameters.Add("@IdSender", (int)-1);
                    CMD2.Parameters.Add("@TypeLogin", (string)"Company");
                    CMD2.Parameters.Add("@IdReceiver", (int)-1);
                    CMD2.Parameters.Add("@IdJob", (int)-1);
                    CMD2.Parameters.Add("@Type", (string)"ChangePass");
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
                else
                {
                    MessageBox.Show("Incorrect password !!!");
                }
            }
        }

        private void flowLayoutPanelCheckCv_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
