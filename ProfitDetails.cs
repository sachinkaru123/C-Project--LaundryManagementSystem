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
    
    public partial class ProfitDetails : Form
    {
        MySqlConnection conec = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        private String Occ;
        public ProfitDetails(String occ)// Get occupation ---------------
        {
            Occ = occ;
            InitializeComponent();
        }
        
        private void btnChangeRate_Click(object sender, EventArgs e)
        {
            ChangeRate cr = new ChangeRate();
            cr.Show();
            this.Hide();
        }

        private void ProfitDetails_Load(object sender, EventArgs e)
        {
            grpRate.Enabled = false;
            if (Occ=="Ceo")
            {
                grpRate.Enabled = true;
            }
            dgvshow.Visible = false;

            // get daily profit---------------------

            var date01=DateTime.Now;

            conec.Open();
            String selectQue = "SELECT billdetails.* FROM billdetails WHERE date = '"+date01.ToString("yyyy-MM-dd")+"'";
           
            MySqlDataAdapter cmd = new MySqlDataAdapter(selectQue, conec);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dgvNotVisual.DataSource = dt;
            conec.Close();

            int rowsCount = dt.Rows.Count;
            double total = 0;
           
            for (int i = 0; i < rowsCount; i++)
            {
                double values = Convert.ToDouble(dgvNotVisual.Rows[i].Cells[1].Value);
                total = values + total;
            }
            lblDaily.Text = "RS " + total.ToString();

            //This Is For Currently Values-----------------

            String Selectquec = "SELECT `ID`, `wash`, `washAndDry` FROM `feerating` WHERE 1";
            conec.Open();
            MySqlCommand cmd1 = new MySqlCommand(Selectquec, conec);
            MySqlDataReader dr = cmd1.ExecuteReader();

            if (dr.Read())
            {
                lblWashOnly.Text = "RS/= "+dr.GetString("wash");
                lblWashandDry.Text = "RS/= " + dr.GetString("washAndDry");
            }
            conec.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetProfDe_Click(object sender, EventArgs e)
        {
            dgvshow.Visible = true;
            try
            {
                //get selected date for profit--------------
               
                String selectQue ="SELECT billdetails.* FROM billdetails WHERE date >='"+dateTimePicker1.Text+"' AND date <= '"+dateTimePicker2.Text+"'";
                MySqlDataAdapter cmd = new MySqlDataAdapter(selectQue, conec);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dgvshow.DataSource = dt;
                conec.Close();

                int rowsCount = dt.Rows.Count;
                double total = 0;
                for (int i = 0; i < rowsCount; i++)
                {

                    double values = Convert.ToDouble(dgvshow.Rows[i].Cells[1].Value);
                    total = values + total;
                }
                lblMonthPro.Text ="RS "+ total.ToString();

                conec.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //View all records----------------------------

            dgvshow.Visible = true;
            try
            {

                String selectQue = "Select * from billdetails";

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

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btnChangeRate_Click_1(object sender, EventArgs e)
        {
            ChangeRate ch = new ChangeRate();
            ch.Show();
            this.Close();
        }
    }
}
