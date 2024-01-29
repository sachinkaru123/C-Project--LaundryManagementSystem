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
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        MySqlCommand cmd;
        MySqlDataReader mdr;
        int count = 0;
        public Login()
        {
           
            InitializeComponent();
           
        }

        private void linklblNewAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();

        }

        private void linklblFogotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recovery recoverAcc = new Recovery();
            recoverAcc.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNID.Clear();
            txtPasswrd.Clear();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbldateTime.Text=DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogin_Click(object sender, EventArgs e)//LOGIN BUTTON CLICK
        {
            timer1.Stop();
            
            if (txtNID.Text!="" && txtPasswrd.Text!="")
            {
                con.Open();

                String selectQue = "SELECT*FROM registrationdb.regusers WHERE ID=" + txtNID.Text.ToString();
                cmd = new MySqlCommand(selectQue, con);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    //CHECK PASSWORD AND ID IS CORRECT
                    if (txtNID.Text == mdr.GetString("ID") && (txtPasswrd.Text == mdr.GetString("Passw")))
                    {
                        if (mdr.GetString("Type") == "Customer")
                        {
                            homePage hop = new homePage(txtNID.Text.ToString());
                            this.Hide();
                            hop.Show();
                            
                        }
                        else if (mdr.GetString("Type") == "Administer")
                        {//employee ceo
                            if (mdr.GetString("Occupation") == "Employee/Worker")
                            {
                                EmployeeHomepage ep = new EmployeeHomepage();
                                ep.Show();
                                this.Hide();
                            }
                            else
                            {
                                string Occ = mdr.GetString("Occupation");//
                                ProfitDetails pd = new ProfitDetails(Occ);
                                pd.Show();
                                this.Hide();
                            }

                        }

                        //for clothdetails send value
                        Cloths_Detail clod = new Cloths_Detail(txtNID.Text);
                    }
                    else
                    {
                        count++;
                        MessageBox.Show("Your Username & Password Are incorrect! Attempt j"+ count, " Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (count==5)
                        {
                            Application.Exit();
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Your Username & Password Are incorrect", " Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All feilds", " Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNID.Focus();

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
