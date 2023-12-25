using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSellSystem.forms.admin
{
    public partial class Suppliers : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "pointofsell.sdf"));
        SqlCeCommand cmd;
        SqlCeDataAdapter adapt;
        //ID variable used in Updating and Deleting Record
        int ID = 0;
        public Suppliers()
        {
            InitializeComponent();
            DisplayData();
        }
       
        private void editbt_Click(object sender, EventArgs e)
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
                btsave.Enabled = true;
            }
        }
        //Insert
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txtcompanyname.Text != "")
            {
                cmd = new SqlCeCommand("INSERT INTO suppliers(CompanyName, photo) VALUES(@CompanyName, @photo)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CompanyName", txtcompanyname.Text);                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please insert the details");
            }
        }
        //Display Data in DataGridView
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlCeDataAdapter("SELECT *FROM suppliers", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data
        private void ClearData()
        {
            txtcompanyname.Text = "";
            ID = 0;
        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtcompanyname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtcompanyname.Text != "")
            {
                cmd = new SqlCeCommand("UPDATE suppliers SET CompanyName=@CompanyName WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@CompanyName", txtcompanyname.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }            
        }
        //Delete Record
        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (ID!=0)
            {
                cmd = new SqlCeCommand("DELETE suppliers WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            btsave.Enabled = false;
        }

        private void btsave_Click(object sender, EventArgs e)
        {

        }
    }
}
