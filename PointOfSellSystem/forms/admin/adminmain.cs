using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PointOfSellSystem.forms.admin
{
    public partial class adminmain : Form
    {
        public adminmain()
        {
            InitializeComponent();
            CustomizedDesign();
        }

        private void CustomizedDesign()
        {
            sidepaneldown.Visible = false;

        }

        private void hideSubMenu()
        {
            if (sidepaneldown.Visible == true)
                sidepaneldown.Visible = false;

        }

        private void showSubMenu()
        {
            if (sidepaneldown.Visible == false)
            {
                hideSubMenu();
                sidepaneldown.Visible = true;
            }
            else
                sidepaneldown.Visible = false;

        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childpanel.Controls.Add(childForm);
            childpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void sideviewstp_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }

        private void homebt_Click(object sender, EventArgs e)
        {
            openChildForm(new home());
            hideSubMenu();
        }

        private void adminmain_Load(object sender, EventArgs e)
        {
            openChildForm(new home());
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new employee());
            hideSubMenu();
        }

        private void supplierbt_Click(object sender, EventArgs e)
        {
            openChildForm(new Suppliers());
            hideSubMenu();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Suppliers());
        }

        private void employeesbt_Click(object sender, EventArgs e)
        {
            openChildForm(new employee());
            hideSubMenu();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new terms());
            hideSubMenu();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin adl = new adminlogin();
            adl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerInvoice());
            hideSubMenu();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new reports.MonthlySalesReport());
            hideSubMenu();
        }
    }
}
