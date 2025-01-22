using System;
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
    public partial class FormAdmin : Form
    {
        private string FirstName;
        private string LastName;
        public FormAdmin(string firstName, string lastName)
        {
            InitializeComponent();
            FirstName = firstName;
            LastName = lastName;
            lbJam.Text = DateTime.Now.ToString("HH-mm-ss");

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lbName.Text = $"welcome {FirstName}{LastName}";
        }

        private void Jm_Tick(object sender, EventArgs e)
        {
           
           
        }

        private void btnMang_Click(object sender, EventArgs e)
        {
            FormManageMenu formManageMenu = new FormManageMenu();
            formManageMenu.Show();
            this.Hide();
        }
    }
}
