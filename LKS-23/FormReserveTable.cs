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
    public partial class FormReserveTable : Form
    {
        private DataTable DtCart;
       private void FirstAction()
        {
            txtFirst.Enabled = false;
            txtLast.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
        }
        private void SecondAction()
        {
            txtFirst.Enabled = true;
            txtLast.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
        }
        public FormReserveTable(string firstName, string lastName, string phoneNUmber, string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
            txtFirst.Text = firstName;
            txtLast.Text = lastName;
            txtPhone.Text = phoneNUmber;

            DtCart = new DataTable();
            DtCart.Columns.Add("Name");
            DtCart.Columns.Add("Qty");
            DtCart.Columns.Add("Price");
            DtCart.Columns.Add("SubTotal");

            dgMenu.DataSource = DtCart;
            if (dgMenu.Columns["Remove"] == null)
            {
                DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
                Delete.Text = "Remove";
                Delete.HeaderText = "Actions";
                Delete.Name = "Remove";
                Delete.UseColumnTextForButtonValue = true;
                dgMenu.Columns.Add(Delete);

            }
        }

        private void FormReserveTable_Load(object sender, EventArgs e)
        {
           FirstAction();
            ShowCombo();
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (ckEnable.Checked) {
                SecondAction();
            }
            else
            {
                FirstAction();
            }
        }
        private void ShowCombo()
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT Name FROM Menus";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    txtChoose.DataSource = dt;
                    txtChoose.DisplayMember = "Name";
                    txtChoose.ValueMember = "Name";
                }
            }
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in DtCart.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"].ToString().Replace("Rp", "").Replace(".", "").Trim());
            }

            decimal reservationFee = 50000;
            lbMenuTotal.Text = "Rp" + total.ToString("N2");
            lbTotalPrice.Text = "Rp" + (total + reservationFee).ToString("N2");
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string selectedItem = txtChoose.SelectedValue.ToString();
            int qty = (int)txtNum.Value;

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT Price FROM Menus WHERE Name = @name";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", selectedItem);
                    object priceObj = cmd.ExecuteScalar();

                    if (priceObj != null)
                    {
                        decimal price = Convert.ToDecimal(priceObj);
                        decimal subtotal = price * qty;

                        // Check for duplicate item
                        foreach (DataRow row in DtCart.Rows)
                        {
                            if (row["Name"].ToString() == selectedItem)
                            {
                                MessageBox.Show("This item already exists in the cart.");
                                return;
                            }
                        }

                        DataRow newRow = DtCart.NewRow();
                        newRow["Name"] = selectedItem;
                        newRow["Qty"] = qty;
                        newRow["Price"] = price.ToString("C");
                        newRow["SubTotal"] = subtotal.ToString("C");

                        DtCart.Rows.Add(newRow);
                    }
                }
            }

            UpdateTotal();
        }
    }
 }

