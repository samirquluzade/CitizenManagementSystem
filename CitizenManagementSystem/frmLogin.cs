using CitizenManagementSystem.BLL;
using CitizenManagementSystem.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        private void button1_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text;
            l.password = txtpassword.Text;
            bool isSuccess = dal.LoginCheck(l);
            if (isSuccess)
            {
                if (l.username == "admin")
                {
                    frmForAdmin admin = new frmForAdmin();
                    admin.Show();
                }
                else
                {
                    Form1 form = new Form1();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya parol səhvdir");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmForCitizen home = new frmForCitizen();
            home.Show();
            this.Hide();
        }
    }
}
