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
    public partial class Billing : Form
    {
        MySqlConnection conec = new MySqlConnection("server=localhost;user id=root;database=registrationdb");

       private string FName,Lname, CusID, datereciv, bill, servtype, clCount, refId;
       


        public Billing()//int referencenum,string name,double bill
        {
            InitializeComponent();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                grpCardOP.Enabled = false;
            }
            else
            {
                grpCardOP.Enabled = true;
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            grppaymontMethord.Enabled = false;
            grpRefDetails.Enabled = true;
            grpCardOP.Enabled = false;
            btnConfirm.Enabled = false;
            btnNext.Enabled = false;
            btnPrint.Enabled = false;
            String dt = (DateTime.Now).ToString();
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrefOk_Click(object sender, EventArgs e)
        {
            conec.Close();

            //hide 
            
            if (txtRefNo.Text == "")
            {
                MessageBox.Show("Please Enter reference number ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRefNo.Focus();

            }
            else
            {
                btnConfirm.Enabled = true;
                grppaymontMethord.Enabled = true;
                grpRefDetails.Enabled = false;

                //------------------inventory Database open------------------
                String Selectquec = "SELECT*FROM registrationdb.inventory WHERE refID=" + txtRefNo.Text.ToString();
                conec.Open();
                MySqlCommand cmd1 = new MySqlCommand(Selectquec, conec);
                MySqlDataReader dr = cmd1.ExecuteReader();

                if (dr.Read())
                {
                    refId = dr.GetString("refID");
                    clCount = dr.GetString("Clcount");
                    servtype = dr.GetString("ServiceType");
                    bill = dr.GetString("Bill");
                    datereciv = dr.GetString("Date");
                    CusID = dr.GetString("NIC");
                }
                conec.Close();
                lblRef.Text = refId;
                lblBil.Text = "RS/- "+bill;
                lblDric.Text = datereciv;
                //------------------inventory Database closed------------------

                //-------------------register Database open--------------------
                try
                {
                   
                    String Selectquec2 = "SELECT*FROM registrationdb.regusers WHERE ID=" + CusID;///
                    conec.Open();
                    MySqlCommand cmd2 = new MySqlCommand(Selectquec2, conec);
                    MySqlDataReader dr1 = cmd2.ExecuteReader();

                    if (dr1.Read())
                    {

                        FName = dr1.GetString("Fname");
                        Lname = dr1.GetString("Lname");

                    }
                    conec.Close();
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("Input Reference number is incorrect","ERROR REFFERENCE NO:",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtRefNo.Focus();
                }
                //-------------------register Database Closed--------------------

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //FOR PRINGTING PURPOSE
        }

        private void btnRefClear_Click(object sender, EventArgs e)
        {
            txtRefNo.Clear();
            txtRefNo.Focus();
            lblRef.Text = "";
            lblBil.Text = "";
            lblDric.Text = "";

            grpRefDetails.Enabled = true;
            grppaymontMethord.Enabled = false;
            grpShow.Enabled = false;
            btnNext.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            grpRefDetails.Enabled = true;
            grppaymontMethord.Enabled = false;
            grpShow.Enabled = false;
            btnConfirm.Enabled = false;

            txtRefNo.Clear();
            lblRef.Text=null;
            lblBil.Text = null;
            lblBill.Text = null;
            lblcusID.Text = null;
            lblDateAndT.Text = null;
            lblDric.Text = null;
            lblname.Text = null;
            lblpaymentM.Text = null;
            lblRef.Text = null;
            lblRefno.Text = null;
            txtRefNo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCrdNum.Clear();
            txtOTP.Clear();
            txtCrdNum.Focus();
        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            EmployeeHomepage eh = new EmployeeHomepage();
            eh.Show();
            this.Close();
        }

        private void btnConfirm_Click_2(object sender, EventArgs e)
        {
            if (txtRefNo.Text!="")
            {
                btnPrint.Enabled = true;
                grppaymontMethord.Enabled = false;
                conec.Close();
                try
                {
                    if (MessageBox.Show("Is payment recived ??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        grpShow.Visible = true;


                        lblRefno.Text = refId;
                        lblname.Text = FName + " " + Lname;
                        lblcusID.Text = CusID;
                        lblDateAndT.Text = datereciv;
                        lblBill.Text = "RS/- " + bill;
                        lblpaymentM.Text = "Paid";

                        string que = "insert into billdetails(refNum,bills,paymeMeth) values('" + refId + "','" + bill + "','" + lblpaymentM.Text + "')";
                        conec.Open();
                        MySqlCommand cmd = new MySqlCommand(que, conec);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("You have successfully created");
                        }
                        else
                        {
                            MessageBox.Show("Invalid");
                        }
                        conec.Close();

                        if (radioButton1.Checked)
                        {
                            MessageBox.Show("Cash Payment is SUCESS");
                            lblpaymentM.Text = "Paid";
                        }
                        else
                        {
                            MessageBox.Show("Card Payment is Success");
                            lblpaymentM.Text = "Paid";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Payment not Recived Please Choose different methord !!", "Message", MessageBoxButtons.OK);
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Already compleated this bill,  please check reference number!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    grpRefDetails.Enabled = true;
                    txtRefNo.Focus();
                }

                btnNext.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Enter reference number ", "Alert",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
