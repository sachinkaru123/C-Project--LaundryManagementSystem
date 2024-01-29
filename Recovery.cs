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
    public partial class Recovery : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        public Recovery()
        {
            InitializeComponent();
           
        }
        int RandomNumber;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String selectQue = "SELECT*FROM registrationdb.regusers WHERE ID=" + txtNIC.Text.ToString();
                cmd = new MySqlCommand(selectQue, con);
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    if (mdr.GetString("PhoneNum").Equals(txtPhone.Text) && mdr.GetString("Email").Equals(txtEmail.Text))
                    {
                        MessageBox.Show("Your 4 digit Code for recovery is sent to your phone");
                        Random random = new Random();
                        RandomNumber = random.Next(0000, 9999);

                        MessageBox.Show("Your code is " + RandomNumber.ToString());
                        con.Close();
                        txtCdigits.Focus();

                        grpConfir.Enabled = true;
                        grpDet.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Your details Are not valid Please Try Again!!!");
                    }
                }
                else
                {
                    MessageBox.Show("No record Found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Wrong Info");
            }
            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCdigits.Text==RandomNumber.ToString())
            {
                //database change
                string UpdateQue = "UPDATE regusers SET Passw='" + txtReNpassword.Text+  "' WHERE ID=" + txtNIC.Text;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(UpdateQue, con);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You have successfully Updated");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Your OTP num is invalid");
            }
        }

        private void Recovery_Load(object sender, EventArgs e)
        {
            grpConfir.Enabled = false;
        }

        private void btnReenter_Click(object sender, EventArgs e)
        {
            grpDet.Enabled = true;
        }
    }
}
