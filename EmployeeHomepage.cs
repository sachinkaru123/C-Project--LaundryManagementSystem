using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_System_Project
{
    public partial class EmployeeHomepage : Form
    {
        public EmployeeHomepage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WorkDone wd = new WorkDone();
            wd.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Billing b = new Billing();
            b.Show();
            this.Close();
        }

        private void EmployeeHomepage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbldateTime.Text = DateTime.Now.ToLongDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Login lgn = new Login();
            lgn.Show();
            this.Hide();
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
