using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPNET
{
    public partial class formproject : Form
    {
        public formproject()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtusername.Text;
            password = txtpassword.Text;

            if(username == "admin" && password == "123")
            {
                FormHome fk = new FormHome();
                fk.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password salah");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }
    }
}
