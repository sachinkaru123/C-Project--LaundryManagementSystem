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
    public partial class ChangeRate : Form
    {
        MySqlConnection conec = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        public ChangeRate()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProfitDetails pd = new ProfitDetails("");
            pd.Show();
            this.Hide();
        }

        private void btncansal_Click(object sender, EventArgs e)
        {
            txtWAD.ResetText();
            txtWash.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string UpdateQue = "UPDATE feerating SET wash='" + txtWash.Text + "',washAndDry='" + txtWAD.Text + "' WHERE ID=" + 1;
                conec.Open();
                MySqlCommand cmd = new MySqlCommand(UpdateQue, conec);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You have successfully Updated");
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
                conec.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void ChangeRate_Load(object sender, EventArgs e)
        {
            String Selectquec = "SELECT `ID`, `wash`, `washAndDry` FROM `feerating` WHERE 1";
            conec.Open();
            MySqlCommand cmd1 = new MySqlCommand(Selectquec, conec);
            MySqlDataReader dr = cmd1.ExecuteReader();

            if (dr.Read())
            {
                //MessageBox.Show(dr.GetString("ID"));
                txtWash.Text = dr.GetString("wash");
                txtWAD.Text = dr.GetString("washAndDry");

            }
            conec.Close();

        }
    }
}
