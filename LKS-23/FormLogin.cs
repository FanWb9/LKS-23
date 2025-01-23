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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //Pengecekan terhadap textBox kosong atau tidak, jika kosong dia akan munculin message eror
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPas.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Hubungkan btn log ini terhadap database dengan memanggil GetConnection 
            using (SqlConnection conn = Database.GetConnection())
            {
                //sesudah memanggil jangan lupa di buka
                conn.Open();
                //buat suatu query dengan memlih apa yang di minta di soal tersebut 
                string query = "Select RoleID,FirstName,LastName from users where email = @email and password = @password";
                //membuat command dengan memanggil query dan conn
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //menguhubungkan command terhadap parameter yang di minta di query
                    cmd.Parameters.AddWithValue("@email", txtUser.Text);
                    cmd.Parameters.AddWithValue("@password", txtPas.Text);
                    //Data reader di gunakan khusus membaca saja
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //buat pengecekan untuk role id 
                        if (reader.Read())
                        {
                            int role = reader.GetInt32(0);
                            string FirstName = reader.GetString(1);
                            string LastName = reader.GetString(2);

                            if (role == 1)
                            {
                                FormAdmin formAdmin = new FormAdmin(FirstName, LastName);
                                formAdmin.Show();
                                this.Hide();
                            }
                            else if (role == 2)
                            {
                                FormUser formUser = new FormUser(FirstName, LastName);
                                formUser.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                           MessageBox.Show("Username atau Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void ckPas_CheckedChanged(object sender, EventArgs e)
        {
            //Pengecekan checkBox apakah di ceklist atau tidak

            //ckPas itu class yang saya buat pada checkBox
            if (ckPas.Checked)
            {
                //jika di ceklist maka password akan di tampilkan
                txtPas.UseSystemPasswordChar = false;
            }
            else
            {
                txtPas.UseSystemPasswordChar = true;
            }
        }

        private void lbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
