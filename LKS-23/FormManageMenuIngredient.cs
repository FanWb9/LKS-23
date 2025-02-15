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
            dgIng.ScrollBars = ScrollBars.Vertical;
            ActionsFirst();
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

        private void ActionSecond()
        {
            CbIng.Enabled = true;
            CbUn.Enabled = true;
            num.Enabled = true;
            BtnAdd.Enabled = true;
            BtnCan.Enabled = true;
            BtnSave.Enabled = true;
        }

        private void UnitShow()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Name from Units";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        CbUn.DataSource = dt;
                        CbUn.DisplayMember = "Name";
                        CbUn.ValueMember = "Name";
                    }
                }
            }
        }

        private void IngeredientShow()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Name from Ingredients";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
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
            IngeredientShow();
            UnitShow();
            ActionsFirst();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select ID,Name from Menus where Name Like @search";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
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
            if (e.RowIndex >= 0 && dgMenu.Columns[e.ColumnIndex].Name == "Edit")
            {
                // Ambil ID menu yang dipilih
                int menuID = Convert.ToInt32(dgMenu.Rows[e.RowIndex].Cells["ID"].Value);

                // Panggil fungsi untuk menampilkan bahan-bahan dari menu yang dipilih
                ShowIngredients(menuID);

                ActionSecond();
            }
        }

        private void ShowIngredients(int menuID)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select MenuIngredients.ID as MenuIngredientID, Ingredients.Name as 'Ingredient Name', Qty, Units.Name as 'Unit' from MenuIngredients inner join Ingredients on MenuIngredients.IngredientID = Ingredients.ID inner join Units on MenuIngredients.UnitID = Units.ID where MenuID = @MenuID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MenuID", menuID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgIng.DataSource = dt;

                        if (dgIng.Columns["MenuIngredientID"] != null)
                        {
                            dgIng.Columns["MenuIngredientID"].Visible = false;
                        }

                        if (dgIng.Columns["Delete"] == null)
                        {
                            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
                            Delete.Text = "Delete";
                            Delete.HeaderText = "Delete";
                            Delete.Name = "Delete";
                            Delete.UseColumnTextForButtonValue = true;
                            dgIng.Columns.Add(Delete);
                        }
                    }
                }
            }
        }

        private void dgIng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgIng.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Ambil ID bahan yang dipilih
                int ingredientID = Convert.ToInt32(dgIng.Rows[e.RowIndex].Cells["MenuIngredientID"].Value);
                // Panggil fungsi untuk menghapus bahan dari menu
                DeleteIngredient(ingredientID);
            }
        }

        private void DeleteIngredient(int ingredientID)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Delete from MenuIngredients where ID = @IngredientID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IngredientID", ingredientID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Rows affected: " + rowsAffected); // Log untuk memastikan penghapusan berhasil
                }
            }

            // Refresh data di dgIng setelah penghapusan
            if (dgMenu.SelectedRows.Count > 0)
            {
                int menuID = Convert.ToInt32(dgMenu.SelectedRows[0].Cells["ID"].Value);
                ShowIngredients(menuID);
            }
            else
            {
                dgIng.DataSource = null; // Kosongkan dgIng jika tidak ada baris yang dipilih di dgMenu
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (dgMenu.SelectedRows.Count > 0)
            {
                int menuID = Convert.ToInt32(dgMenu.SelectedRows[0].Cells["ID"].Value);
                string ingredientName = CbIng.SelectedValue.ToString();
                string unitName = CbUn.SelectedValue.ToString();
                int qty = (int)num.Value;

                if (qty < 1)
                {
                    MessageBox.Show("Quantity must be more than or equal to 1.");
                    return;
                }

                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // Check for duplicate ingredient
                    string checkQuery = "Select Count(*) from MenuIngredients inner join Ingredients on MenuIngredients.IngredientID = Ingredients.ID where MenuID = @MenuID and Ingredients.Name = @IngredientName";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MenuID", menuID);
                        checkCmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This ingredient already exists in the menu.");
                            return;
                        }
                    }

                    // Insert new ingredient
                    string insertQuery = "Insert into MenuIngredients (MenuID, IngredientID, UnitID, Qty) values (@MenuID, (Select ID from Ingredients where Name = @IngredientName), (Select ID from Units where Name = @UnitName), @Qty)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@MenuID", menuID);
                        insertCmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                        insertCmd.Parameters.AddWithValue("@UnitName", unitName);
                        insertCmd.Parameters.AddWithValue("@Qty", qty);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Refresh data di dgIng setelah penambahan
                ShowIngredients(menuID);
            }
            else
            {
                MessageBox.Show("Please select a menu.");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Save logic here
            MessageBox.Show("Ingredients saved successfully.");
            ActionsFirst();
        }

        private void BtnCan_Click(object sender, EventArgs e)
        {
            // Clear and disable the ingredients table and input fields
            dgIng.DataSource = null;
            ActionsFirst();
        }
    }
}

