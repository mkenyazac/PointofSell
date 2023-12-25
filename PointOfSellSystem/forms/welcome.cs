using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSellSystem.forms
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void termsbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.terms tc1 = new admin.terms();
            tc1.Show();
        }

        private void userbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            user.userlogin f2 = new user.userlogin();
            f2.Show();
        }

        private void adminbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.adminlogin am = new admin.adminlogin();
            am.Show();
        }
    }
}
