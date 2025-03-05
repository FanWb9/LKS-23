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
        private int UpdateID;
        private Boolean isUpdate = false;
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
        private void firstAction()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            numPric.Value = 0;

            txtName.Enabled = false;
            txtDesc.Enabled = false;
            numPric.Enabled = false;
            CbCat.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }
        private void secondAction()
        {
            txtName.Enabled = true;
            txtDesc.Enabled = true;
            numPric.Enabled = true;
            CbCat.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void FormsMenu_Load(object sender, EventArgs e)
        {
            cmData();
            showData();
            firstAction();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query =
                    @"Select Menus.Name as 'Menu',
                    Categories.Name as 'Category', 
                    Menus.Description as 'Description',
                    Menus.Price as 'Price'
                    From Menus
                    Inner join 
                    Categories on Menus.CategoryID = Categories.ID
                    where
                    Menus.Name Like @search
                    OR
                    Categories.Name Like @search";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgMenu.DataSource = dt;

                       
                        if (DgMenu.Columns["Price"] != null)
                        {
                            DgMenu.Columns["Price"].DefaultCellStyle.Format = "C";
                            DgMenu.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                        }
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            secondAction();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                if (isUpdate)
                {
                   //
                    string query = "Update Menus set Name = @Name, Description = @Description, Price = @Price, CategoryID = (Select ID from Categories where Name = @CategoryName) where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@Price", numPric.Value);
                        cmd.Parameters.AddWithValue("@CategoryName", CbCat.Text);
                        cmd.Parameters.AddWithValue("@ID", UpdateID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been updated");
                    }
                }
                else
                {
                   
                    string query = "Insert into Menus (Name, Description, Price, CategoryID) values (@Name, @Description, @Price, (Select ID from Categories where Name = @CategoryName))";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@Price", numPric.Value);
                        cmd.Parameters.AddWithValue("@CategoryName", CbCat.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been inserted");
                    }
                }
                showData();
                firstAction();
            }
        }
    }
}
