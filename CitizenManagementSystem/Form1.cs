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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlHelper sql = new SqlHelper();
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                frmOdemeError error = new frmOdemeError();
                error.Show();
            }
            else
            {
                frmOdemeSuccess success = new frmOdemeSuccess();
                success.Show();
            }
            SqlCommand cmd = new SqlCommand("insert into tbl_Kommunal(Abonent_kodu,Ödənilən_məbləğ) Values(@p1,@p2)", sql.Connect());
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.ExecuteNonQuery();
            sql.Connect().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox3.Text == "")
            {
                frmOdemeError error = new frmOdemeError();
                error.Show();
            }
            else
            {
                frmOdemeSuccess success = new frmOdemeSuccess();
                success.Show();
            }
            SqlCommand cmd = new SqlCommand("insert into tbl_Kommunal(Abonent_kodu,Ödənilən_məbləğ) Values(@p1,@p2)", sql.Connect());
            cmd.Parameters.AddWithValue("@p1", textBox4.Text);
            cmd.Parameters.AddWithValue("@p2", textBox3.Text);
            cmd.ExecuteNonQuery();
            sql.Connect().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox5.Text == "")
            {
                frmOdemeError error = new frmOdemeError();
                error.Show();
            }
            else
            {
                frmOdemeSuccess success = new frmOdemeSuccess();
                success.Show();
            }
            SqlCommand cmd = new SqlCommand("insert into tbl_Kommunal(Abonent_kodu,Ödənilən_məbləğ) Values(@p1,@p2)", sql.Connect());
            cmd.Parameters.AddWithValue("@p1", textBox6.Text);
            cmd.Parameters.AddWithValue("@p2", textBox5.Text);
            cmd.ExecuteNonQuery();
            sql.Connect().Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length != 10)
            {
                MessageBox.Show("Abonent kodu düzgün yazılmayıb");
                textBox1.Focus();
            }
            else
            {

            }
        }


        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text.Length != 10)
            {
                MessageBox.Show("Abonent kodu düzgün yazılmayıb");
                textBox4.Focus();
            }
            else
            {

            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Text.Length != 10)
            {
                MessageBox.Show("Abonent kodu düzgün yazılmayıb");
                textBox6.Focus();
            }
            else
            {

            }
        }
    }
}
