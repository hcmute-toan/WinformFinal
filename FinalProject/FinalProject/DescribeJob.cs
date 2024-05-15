using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DescribeJob : Form
    {
        public static int idCV;
        public DescribeJob()
        {
            InitializeComponent();
            TbCompany.Text = FindJob1.uc.lbNameCompany.Text;
            TbAddress.Text = FindJob1.uc.lbAddress.Text;
            TbContact.Text = FindJob1.uc.lbContact.Text;
            TbNameJob.Text = FindJob1.uc.lbNameJob.Text;
            TbPositon.Text = FindJob1.uc.lbNeedPosition.Text;
            TbRecruit.Text = FindJob1.uc.lbRecruit.Text;
            TbSalary.Text = FindJob1.uc.lbSalary.Text;
            TbTime.Text = FindJob1.uc.lbTime.Text;
            TbDescribe.Text = FindJob1.uc.lbDescribeJob.Text;
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DescribeJob_Load(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            foreach (CV a in ReadSQL.Cvs())
            {
                if (a.Id == Login.IdUser)
                {
                    a.IdCv = idCV;
                    this.Hide();
                    UpdateCV updateCV = new UpdateCV();
                    updateCV.ShowDialog();
                    return;
                }
            }
            this.Hide();
            InformationUser informationUser = new InformationUser();
            informationUser.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}