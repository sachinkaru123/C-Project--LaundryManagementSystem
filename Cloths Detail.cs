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
    public partial class Cloths_Detail : Form
    {
        public String NIC;
        int id;
        String name;
        Double Bill = 0;
        MySqlConnection conec = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        
       
        public Cloths_Detail(String nic)
        {
            InitializeComponent();
            NIC = nic;
        }

       
       
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you want to Confirm this Details?", "Confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string que = "insert into inventory(refID,NIC,Clcount,Meterial,ServiceType,Bill) values" +
            "('" + id + "','" + NIC + "','" + txtCount.Text + "','" + txtClothMe.Text + "','" + cmbType.Text + "','" + Bill + "')";//query

                conec.Open();//open connection
                MySqlCommand cmd = new MySqlCommand(que, conec);

                if (cmd.ExecuteNonQuery() == 1)
                {
                   if( MessageBox.Show("You have successfully Entered data to system", "Confirmation")==DialogResult.OK)
                    {
                        homePage h1 = new homePage( NIC);
                        h1.Show();
                        this.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Invalid");
                }
                conec.Close();
            }

           

           /*Billing bl = new Billing(id,name,Bill);
            bl.Show();
            this.Hide();*/
        }

        private void Cloths_Detail_Load(object sender, EventArgs e)
        {
            grpdt.Enabled = false;
            DateTime myvalue = DateTime.Now;
            String date = myvalue.ToShortDateString();
            txtDateATime.Text = date;
  
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtCount.Text==" "||txtWeight.Text== " "|| txtClothMe.Text==" ")
            {
                MessageBox.Show("Please Input All feilds", " Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ///calculation 
                conec.Open();
                String selectQue2 = "SELECT*FROM registrationdb.feerating WHERE ID=" + 1;
                MySqlCommand cmd2 = new MySqlCommand(selectQue2, conec);
                MySqlDataReader mdr2 = cmd2.ExecuteReader();
                String TYPE;
                if (mdr2.Read())
                {

                    if (cmbType.Text == "Wash only")
                    {
                        TYPE = "wash";
                    }
                    else
                    {
                        TYPE = "washAndDry";
                    }
                    Double rate = Convert.ToDouble(mdr2.GetString(TYPE));
                    double weight = Convert.ToDouble(txtWeight.Text);
                    Bill = weight * rate;
                }
                conec.Close();

                grpIn.Enabled = false;
                grpdt.Enabled = true;


                using (MySqlConnection AR = new MySqlConnection())
                {
                    //genarate ref ID
                    conec.Open();
                    String query = "SELECT*FROM inventory ORDER BY (1) DESC LIMIT 1";
                    using (MySqlCommand SDA = new MySqlCommand(query, conec))
                    {
                        MySqlDataReader data = SDA.ExecuteReader();
                        if (data.Read())
                        { 
                            int sid = Convert.ToInt32(data.GetValue(0));
                            id = sid + 1;
                        }
                    }
                    conec.Close();
                }

                conec.Open();
                String selectQue = "SELECT*FROM registrationdb.regusers WHERE ID=" + NIC;
                MySqlCommand cmd = new MySqlCommand(selectQue, conec);
                MySqlDataReader mdr = cmd.ExecuteReader();


                if (mdr.Read())
                {
                    lblName.Text = mdr.GetString("Fname") + " " + mdr.GetString("Lname");
                    lblCount.Text = txtCount.Text.ToString();
                    lblMeterial.Text = txtClothMe.Text.ToString();
                    lblServiceT.Text = cmbType.Text.ToString();
                    lblTotal.Text = Bill.ToString();
                    lblWeight.Text = txtWeight.Text.ToString();
                    lblRefID.Text = id.ToString();

                    if (cmbType.Text == "Wash only")
                    {
                        DateTime Amyvalue = DateTime.Now;
                        String ASdate = Amyvalue.AddDays(1).ToShortDateString();
                        lblAstimeteDt.Text = ASdate;
                    }
                    else
                    {
                        DateTime Amyvalue = DateTime.Now;
                        String ASdate = Amyvalue.AddDays(2).ToShortDateString();
                        lblAstimeteDt.Text = ASdate;
                    }

                    name = mdr.GetString("Fname") + " " + mdr.GetString("Lname");

                }
                else
                {
                    MessageBox.Show("Error");
                }
                conec.Close();
            }

           

           
          
        }

        private void btnEddit_Click(object sender, EventArgs e)
        {
            grpIn.Enabled = true;
            grpdt.Enabled = false;
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {//validate
            char ch = e.KeyChar;
            if (!char.IsDigit(ch)&& (ch !=8) && (ch != 46))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Correct Weight", " input is Not an Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && (ch != 8) && (ch != 46))
            {
                e.Handled = true;
                MessageBox.Show("Wrong input", " input is Not an Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = " ";
            txtClothMe.Text = " ";
            txtCount.Text = " ";
            cmbType.Text = " ";
            
              
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
