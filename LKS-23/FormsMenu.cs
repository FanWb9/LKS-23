using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_23
{
    public partial class FormsMenu : Form
    {
        public FormsMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cmData()
        {
           using(SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Name From Categories";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        CbCat.DataSource = dt;
                        CbCat.DisplayMember = "Name";
                        CbCat.ValueMember = "Name";
                    }
                }
            }
        }
        private void showData()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Menus.Name as 'Name', Categories.Name as 'Category', Menus.Description as 'Description', Menus.Price as 'Price' from Menus Inner Join Categories on Menus.CategoryID = Categories.ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgMenu.DataSource = dt;
                        DgMenu.Columns["Price"].DefaultCellStyle.Format = "C";
                        DgMenu.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                    }
                }
            }
        }

        private void CbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void FormsMenu_Load(object sender, EventArgs e)
        {
            cmData();
            showData();
        }
    }
}
