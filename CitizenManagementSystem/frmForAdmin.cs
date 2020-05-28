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
    public partial class frmForAdmin : Form
    {
        SqlHelper sql = new SqlHelper();
        public frmForAdmin()
        {
            InitializeComponent();
        }

        private void frmForAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * FROM tbl_Citizen", sql.Connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_Kommunal", sql.Connect());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }
    }
}
