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

namespace LKS_23
{
    public partial class FormRegis : Form
    {
        public FormRegis()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirst.Text) || string.IsNullOrEmpty(txtLast.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtCon.Text))
            {
                MessageBox.Show("Data Harus di lengkapi");
            }
            string phoneNumber = txtPhone.Text;
            if (phoneNumber.Length < 10 || phoneNumber.Length > 15)
            {
                MessageBox.Show("Nomor Telepon Harus di isi minimal 10 max 15");
            }
            string password = txtPass.Text;
            if (password.Length < 8)
            {
                MessageBox.Show("Password harus lebih dari 8");
            }
            if (txtPass.Text != txtCon.Text)
            {
                MessageBox.Show("Password dan Confirm Password Harus Sama");
            }
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Insert Into users(FirstName,LastName,Email,PhoneNumber,Password,DateJoined,RoleID) values(@FirstName,@LastName,@Email,@PhoneNumber,@Password,@DateJoined,@RoleID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtFirst.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLast.Text);
                    cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("PhoneNumber", txtPhone.Text);
                    cmd.Parameters.AddWithValue("Password", txtPass.Text);
                    cmd.Parameters.AddWithValue("DateJoined", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@RoleID", 2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Welcome EsemkaFoodCourt");
                    FormUser formUser = new FormUser(txtFirst.Text, txtLast.Text);
                    formUser.Show();
                    this.Hide();
                }


            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
