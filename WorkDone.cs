using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laundry_System_Project
{
    public partial class WorkDone : Form
    {
        MySqlConnection conec = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        public WorkDone()
        {
            InitializeComponent();
            grpConfirm.Enabled = false;
        }

        private void btnUndoneW_Click(object sender, EventArgs e)
        {
            try
            {
                String selectQue = "SELECT billdetails.* FROM billdetails WHERE paymeMeth = 'Paid'";

                MySqlDataAdapter cmd = new MySqlDataAdapter(selectQue, conec);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dgvshow.DataSource = dt;
                conec.Close();

            }
            catch (Exception ex)                         
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvshow_DoubleClick(object sender, EventArgs e)
        {
            grpConfirm.Enabled = true;
           lblREf.Text= dgvshow.SelectedRows[0].Cells[0].Value.ToString();
            lblDate.Text= dgvshow.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpConfirm.Enabled = false;

            string UpdateQue = "UPDATE billdetails SET paymeMeth= 'Paid-WorkDone' WHERE refNum= '"+lblREf.Text+"' ";
            MessageBox.Show("Package is completed -- Sending Message to Customer","Sending", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conec.Open();
            MySqlCommand cmd = new MySqlCommand(UpdateQue, conec);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Saved To Database, Sucessful","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid");
            }
            conec.Close();

            ///
            try
            {

                String selectQue = "SELECT billdetails.* FROM billdetails WHERE paymeMeth = 'Paid'";

                MySqlDataAdapter cmd1 = new MySqlDataAdapter(selectQue, conec);
                DataTable dt = new DataTable();
                cmd1.Fill(dt);
                dgvshow.DataSource = dt;
                conec.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeHomepage eh = new EmployeeHomepage();
            eh.Show();
            this.Close();
        }

        private void WorkDone_Load(object sender, EventArgs e)
        {///////////////////-------------
            try
            {

                String selectQue = "SELECT billdetails.* FROM billdetails WHERE paymeMeth = 'Paid'";

                MySqlDataAdapter cmd = new MySqlDataAdapter(selectQue, conec);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dgvshow.DataSource = dt;
                conec.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
