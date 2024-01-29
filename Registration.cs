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
    public partial class Registration : Form
    {
        MySqlConnection conec = new MySqlConnection("server=localhost;user id=root;database=registrationdb");
        public Registration()
        {
            InitializeComponent();
        }

        string AccType=" ";
        string AdminPass = "sck123";
        //bool DuplicateKey = false;
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {


                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    string que = "insert into regusers(Fname,Lname,Email,PhoneNum,ID,Type,Occupation,Passw) values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtNIC.Text + "','" + AccType + "','" + cmbOccupation.Text + "','" + txtPass.Text + "')";//query

                    conec.Open();//connection eka open karanawa
                    MySqlCommand cmd = new MySqlCommand(que, conec);


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("You have successfully created");
                        if (cmbOccupation.Text == "Manager" || cmbOccupation.Text == "Ceo")
                        {
                            ProfitDetails pd = new ProfitDetails(cmbOccupation.Text);
                            pd.Show();
                            this.Hide();
                        }
                        else if ((cmbOccupation.Text == "Employee/Worker"))
                        {
                            EmployeeHomepage eh = new EmployeeHomepage();
                            eh.Show();
                            this.Hide();
                        }
                        else
                        {
                            homePage hp = new homePage(txtNIC.Text.ToString());
                            this.Hide();
                            hp.Show();
                            this.Hide();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                    conec.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show(" This Id is already used ", "Existing ID", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtNIC.Focus();
                txtNIC.Clear();
                //DuplicateKey = false;
                conec.Close();

            }
           
        }

        private void rdbCustomer_CheckedChanged(object sender, EventArgs e)//radio
        {
            txtAdminP.Text.Equals("null");
            cmbOccupation.Text.Equals("null");
            grpAdmin.Hide();
            AccType = "Customer";
        }

        private void rdbAdminister_CheckedChanged(object sender, EventArgs e)//radio
        {

            grpAdmin.Show();
            AccType = "Administer";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdminP.Clear();
            txtEmail.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtNIC.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            txtRePass.Clear();
            cmbOccupation.Text = " ";
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void txtfname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtfname.Text))
            {
                e.Cancel = true;
                txtfname.Focus();
                errorProvider.SetError(txtfname, "Please enter first name");
            }
            else
            {
                
                errorProvider.SetError(txtfname, null);
            }
        }

        private void txtlname_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(txtlname.Text))
            {
                e.Cancel = true;
                txtlname.Focus();
                errorProvider.SetError(txtlname, "Please enter last name");
            }
            else
            {
                
                errorProvider.SetError(txtlname, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Please enter Email");
            }
            else
            {

                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            

            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider.SetError(txtPhone, "Please enter Phone number");
            }
            else
            {

                errorProvider.SetError(txtPhone, null);
            }

        }

        private void txtNIC_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNIC.Text))
            {
                e.Cancel = true;
                txtNIC.Focus();
                errorProvider.SetError(txtNIC, "Please enter NIC number");
            }
            else
            {

                errorProvider.SetError(txtNIC, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                e.Cancel = true;
                txtPass.Focus();
                errorProvider.SetError(txtPass, "Please enter password");
            }
            else
            {

                errorProvider.SetError(txtPass, null);
            }
        }

        private void txtRePass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text==txtRePass.Text)
            {
                if (String.IsNullOrEmpty(txtRePass.Text))
                {
                    e.Cancel = true;
                    //txtRePass.Focus();
                    errorProvider.SetError(txtRePass, "Please re enter password");
                }
                else
                {

                    errorProvider.SetError(txtRePass, null);
                }
            }
            else
            {
              
                MessageBox.Show("Your password is not correct");
                txtPass.Clear();
                txtRePass.Clear();
                txtPass.Focus();
            }
           
        }

        private void txtAdminP_Validating(object sender, CancelEventArgs e)
        {
            if (rdbAdminister.Checked == true)
            {
                if ((AdminPass == txtAdminP.Text))
                {
                    MessageBox.Show("Successfull");
                }
                else
                {
                    MessageBox.Show("Your Administrative password is not correct");
                    txtAdminP.Focus();
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr)&& chr!=8)
            {
                e.Handled = true;
                errorProvider.SetError(txtPhone, "Please enter Correct Phone Number");
            }
        }

        private void txtNIC_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                errorProvider.SetError(txtNIC, "Please enter only Numbers in NIC");
            }
        }
    }
}
