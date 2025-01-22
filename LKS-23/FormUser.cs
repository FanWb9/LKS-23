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
    public partial class FormUser : Form
    {
        private string FirstName;
        private string LastName;
        public FormUser( string firstName, string lastName)
        {
            InitializeComponent();
            FirstName = firstName;
            LastName = lastName;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            lbName.Text = $"Welcome {FirstName}{LastName}";
        }
    }
}
