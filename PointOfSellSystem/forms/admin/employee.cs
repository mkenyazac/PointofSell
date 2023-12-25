using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSellSystem.forms.admin
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void uploadbt_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filter
            open.Filter = "Image Files(*.jpg; *jpeg; *.gif; *.bmp)|*.jpg; *jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //display image in the picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                //image file path
                groupBox1.Text = open.FileName;
            }
        }

        private void backbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminmain adm = new adminmain();
            adm.Show();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
