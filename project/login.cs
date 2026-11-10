using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
                errorProvider1.SetError(txtusername, "Username is required");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtusername, "");
            }

            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                errorProvider1.SetError(txtpassword, "Password is required");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtpassword, "");
            }

            if (!isValid) return;

            dashboard f1 = new dashboard();
            f1.Show();

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
