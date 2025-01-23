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
        private void CheckLast()
        {
            txtFirst.Enabled = true;
            txtLast.Enabled = true;
            txtPhone.Enabled = true;
            txtPas.Enabled = true;
            txtEmail.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnCan.Enabled = true;
            btnSave.Enabled = true;
        }
         private void checkFirst()
        {
            txtFirst.Enabled = false;
            txtLast.Enabled = false;
            txtPhone.Enabled = false;
            txtPas.Enabled = false;
            txtEmail.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnCan.Enabled = false;
            btnSave.Enabled = false;
        }
        
        private void FormManageMenu_Load(object sender, EventArgs e)
        {
            IsData();
            checkFirst();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CheckLast();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckLast();
        }

        private void txtSearc_TextChanged(object sender, EventArgs e)
        {
            IsData();
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select FirstName,LastName,Email,DateJoined as 'member since' from users where FirstName like @Search or LastName like @Search or Email like @Search";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearc.Text + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgManage.DataSource = dt;
                    }
                }
              
               
            }
        }
    }
}
