using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_23
{
    public partial class FormManageMenu : Form
    {
        public FormManageMenu()
        {
            InitializeComponent();
        }
        private void IsData()
        {
            using(SqlConnection conn = Database.GetConnection())
            {
               conn.Open();
               string query = "Select FirstName as 'FirstName',LastName as 'LastName',Email as 'Email',DateJoined as 'Member Since' from users";
                using (SqlCommand cmd = new SqlCommand(query, conn)) { 
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgManage.DataSource = dt;
                    }
                }

            }
        }
        private void FormManageMenu_Load(object sender, EventArgs e)
        {
            IsData();
        }
    }
}
