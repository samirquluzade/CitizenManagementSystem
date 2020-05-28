using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenManagementSystem
{
    public partial class frmForCitizen : Form
    {
        public frmForCitizen()
        {
            InitializeComponent();
        }
        SqlHelper sql = new SqlHelper();
        private void frmForCitizen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_Citizen(Username,Ad,Soyad,Doğum_tarixi,Email,Şifrə,Telefon_nömrəsi,Şəxsiyyət_nömrə) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sql.Connect());
            cmd.Parameters.AddWithValue("@p1", txtusername.Text);
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p4", this.dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@p5", txtemail.Text);
            cmd.Parameters.AddWithValue("@p6", txtparol.Text);
            cmd.Parameters.AddWithValue("@p7", int.Parse(txttelefon.Text));
            cmd.Parameters.AddWithValue("@p8", int.Parse(txtnomre.Text));
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("insert into tbl_Login(username,password) Values(@username,@password)", sql.Connect());
            cmd1.Parameters.AddWithValue("@username", txtusername.Text);
            cmd1.Parameters.AddWithValue("@password", txtparol.Text);
            cmd1.ExecuteNonQuery();
            sql.Connect().Close();
            MessageBox.Show("Qeydiyyat uğurla başa çatdı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
    }
}
