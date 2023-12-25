using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSellSystem.forms.user
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void backbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome f3 = new welcome();
            f3.Show();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                this.Hide();
                usermain av = new usermain();
                av.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please Type the Credentiols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label3.Text = "Incorrect email or password";
            }
        }

        private void resetbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the administrator to change the password");
        }
    }
}
