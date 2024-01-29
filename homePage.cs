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
    public partial class homePage : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        MySqlCommand cmd;
        MySqlDataReader mdr;
        public string ID;

        public homePage(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            
            con.Open();

            String selectQue = "select * from registrationdb.regusers WHERE ID="+ ID;
            cmd = new MySqlCommand(selectQue, con);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                lblName.Text = mdr.GetString("Fname");

            }
            else
            {
                MessageBox.Show("Wrong Info Please Try again");
            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddCloth_Click(object sender, EventArgs e)
        {
            Cloths_Detail cd = new Cloths_Detail(ID);
            cd.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Login lgn = new Login();
            lgn.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
