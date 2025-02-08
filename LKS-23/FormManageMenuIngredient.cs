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
using System.Net.NetworkInformation;

namespace LKS_23
{
    public partial class FormManageMenuIngredient : Form
    {
        public FormManageMenuIngredient()
        {
            InitializeComponent();
            dgMenu.ScrollBars = ScrollBars.Vertical;
        }
        private void ActionsFirst()
        {
            CbIng.Enabled = false;
            CbUn.Enabled = false;
            num.Enabled = false;
            BtnAdd.Enabled = false;
            BtnCan.Enabled = false;
            BtnSave.Enabled = false;

        }

        //Ambil data dari Unit dan masukan pada combo box
        private void UnitShow()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Name from Units";
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) { 
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        CbUn.DataSource = dt;
                        CbUn.DisplayMember = "Name";
                        CbUn.ValueMember = "Name";
                    }
                }
            }
        }
        //Ambil data Ingredients dan masukan pada combo box
        private void IngeredientShow()
        {
            using(SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Name from Ingredients";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        CbIng.DataSource = dt;
                        CbIng.ValueMember = "Name";
                        CbIng.DisplayMember = "Name";
                    }
                }                
            }
        }
        //Muculin Menu dari Table menus 
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
            ShowData(); //tampilan data menu 
            IngeredientShow(); // tampilan Nama bahan
            UnitShow(); // tampilan units
            ActionsFirst();
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

        private void dgMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ambil ID menu yang dipilih
                int menuID = Convert.ToInt32(dgMenu.Rows[e.RowIndex].Cells["ID"].Value);

                // Panggil fungsi untuk menampilkan bahan-bahan dari menu yang dipilih
                ShowIngredients(menuID);
            }
        }
        private void ShowIngredients(int menuID)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Ingredients.Name as 'Ingredient Name',Qty,Units.Name as 'Unit' from MenuIngredients inner join Ingredients on MenuIngredients.IngredientID = Ingredients.ID inner join Units on MenuIngredients.UnitID = Units.ID where MenuID = @MenuID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MenuID", menuID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgIng.DataSource = dt;
                    }
                }
            }
        }
    }
}
