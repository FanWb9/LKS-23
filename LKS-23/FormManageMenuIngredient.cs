using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_23
{
    public partial class FormManageMenuIngredient : Form
    {
        public FormManageMenuIngredient()
        {
            InitializeComponent();
            dgMenu.ScrollBars = ScrollBars.Vertical;
        }
        private void ShowData()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select ID,Name from Menus";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgMenu.DataSource = dt;

                        if (dgMenu.Columns["ID"] != null)
                        {
                            dgMenu.Columns["ID"].Visible = false;
                        }
                        if (dgMenu.Columns["Edit"] == null)
                        {
                            DataGridViewLinkColumn edit = new DataGridViewLinkColumn();
                            edit.HeaderText = "Actions";
                            edit.Name = "Edit";
                            edit.Text = "Edit Ingredients";
                            edit.UseColumnTextForLinkValue = true;
                            dgMenu.Columns.Add(edit);
                        }
                    }
                }
            }
        }

        private void FormManageMenuIngredient_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using(SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select ID,Name from Menus where Name Like @search";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search","%" + txtSearch.Text + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) { 
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgMenu.DataSource = dt;
                        if (dgMenu.Columns["ID"] != null) { 
                            dgMenu.Columns["ID"].Visible = false;
                        }
                        if (dgMenu.Columns["Edit"] == null)
                        {
                            DataGridViewLinkColumn edit = new DataGridViewLinkColumn();
                            edit.HeaderText = "Actions";
                            edit.Text = "Edit Ingredient";
                            edit.Name = "Edit";
                            edit.UseColumnTextForLinkValue = true;
                            dgMenu.Columns.Add(edit);
                        }
                    }
                }
            }
        }
    }
}
