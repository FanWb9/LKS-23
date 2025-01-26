using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_23
{
    public partial class FormManageMenu : Form
    {
        private Boolean IsUpdate = true;
        private int UpdateId;
        public FormManageMenu()
        {
            InitializeComponent();
        }

        private void FormManageMenu_Load(object sender, EventArgs e)
        {
            Isdata();
            FirstAction();
        }
        private void Isdata()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select ID,FirstName, LastName,Email,PhoneNumber,DateJoined as 'Member Since' from users ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgManage.DataSource = dt;
                    }
                    if (dgManage.Columns["ID"] != null)
                    {
                        dgManage.Columns["ID"].Visible = false;

                    }
                }
            }
        }
        private void FirstAction()
        {
            txtFirst.Text = "";
            txtLast.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPass.Text = "";


            txtFirst.Enabled = false;
            txtLast.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtPass.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
        }
        private void SecondAction()
        {
            txtFirst.Enabled = true;
            txtLast.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtPass.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
        }

        private void txtSearc_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select ID,FirstName,LastName,PhoneNumber,Email,DateJoined as 'Member Since' from users where FirstName like @search or LastName like @search or Email like @search";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearc.Text + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgManage.DataSource = dt;
                    }
                    if (dgManage.Columns["ID"] != null)
                    {
                        dgManage.Columns["ID"].Visible = false;
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SecondAction();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FirstAction();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgManage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgManage.SelectedRows[0];
                txtFirst.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLast.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtPass.Text = ""; 

                UpdateId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                IsUpdate = true;
                SecondAction();
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirst.Text) || string.IsNullOrEmpty(txtLast.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string phoneNumber = txtPhone.Text;
            if (phoneNumber.Length < 10 || phoneNumber.Length > 15)
            {
                MessageBox.Show("Phone number must be between 10 and 15 digits");
                return;
            }
            string password = txtPass.Text;
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                if (IsUpdate)
                {
                    string query = "Update users set Firstname = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Password = @Password where ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirst.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLast.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                        cmd.Parameters.AddWithValue("@ID", UpdateId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been updated");
                    }
                }
                else
                {
                    string query = "Insert into users (FirstName, LastName, Email, PhoneNumber, Password) values (@FirstName, @LastName, @Email, @PhoneNumber, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirst.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLast.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been inserted");
                    }
                }
                Isdata();
                FirstAction();

            }
        }
    }
}
