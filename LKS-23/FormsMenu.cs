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
                string query = "Select Menus.ID, Menus.Name as 'Name', Categories.Name as 'Category', Menus.Description as 'Description', Menus.Price as 'Price' from Menus Inner Join Categories on Menus.CategoryID = Categories.ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgMenu.DataSource = dt;
                        DgMenu.Columns["Price"].DefaultCellStyle.Format = "C";
                        DgMenu.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");

                        if (DgMenu.Columns["ID"] != null)
                        {
                            DgMenu.Columns["ID"].Visible = false;
                        }
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
            isUpdate = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DgMenu.SelectedRows.Count > 0) { 
            DataGridViewRow row = DgMenu.SelectedRows[0];
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtDesc.Text = row.Cells["Description"].Value.ToString();
            numPric.Text = row.Cells["Price"].Value.ToString();
            CbCat.Text = row.Cells["Category"].Value.ToString();
            UpdateID = Convert.ToInt32(row.Cells["ID"].Value);
            isUpdate = true;
            showData();
            secondAction();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("silahkan lengkapi data");
            }
            using (SqlConnection conn = Database.GetConnection()) {
                conn.Open();
                if (isUpdate)
                {
                    string query = "Update Menus set Name = @name , Description = @desc, Price = @price , CategoryID = (Select ID from Categories where Name = @Category) Where ID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@price", numPric.Text);
                        cmd.Parameters.AddWithValue("@desc",txtDesc.Text);
                        cmd.Parameters.AddWithValue("@Category",CbCat.Text);
                        cmd.Parameters.AddWithValue("@id", UpdateID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Di Perbarui");
                    }
                }
                else
                {
                    string query = "Insert Into Menus(Name,Description,Price,CategoryID) values(@Name,@Description,@Price,(select ID from Categories where Name = @Category))";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name",txtName.Text);
                        cmd.Parameters.AddWithValue("@Description",txtDesc.Text);
                        cmd.Parameters.AddWithValue("@price",numPric.Text);
                        cmd.Parameters.AddWithValue("@Category",CbCat.Text);
                        cmd.ExecuteNonQuery ();
                        MessageBox.Show("Data Berhasil di Masukan");
                    }
                }
                showData();
                firstAction();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            firstAction();
            showData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection()) {
                conn.Open ();
                if (DgMenu.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = DgMenu.SelectedRows[0];
                    DialogResult result = MessageBox.Show("Apakah Anda Yakin Untuk mengahapus Data ?", "Confrim Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes) {
                        UpdateID = Convert.ToInt32(row.Cells["ID"].Value);
                        SqlTransaction transaction  = conn.BeginTransaction();
                        string query1 = "Delete From MenuIngredients where MenuID = @id";
                        using (SqlCommand cmd = new SqlCommand(query1, conn,transaction)) {
                            cmd.Parameters.AddWithValue("id", UpdateID);
                            cmd.ExecuteNonQuery ();
                        }
                        string query2 = "Delete from Menus Where ID = @id";
                        using(SqlCommand cmd2 = new SqlCommand(query2, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("id",UpdateID);
                            cmd2.ExecuteNonQuery ();
                        }
                        transaction.Commit ();
                        MessageBox.Show("Data Berhasil Di hapus");
                        showData();
                    }
                }
            }
        }

        private void DgMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
