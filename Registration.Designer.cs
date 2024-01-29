
namespace Laundry_System_Project
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdminP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAdminister = new System.Windows.Forms.RadioButton();
            this.rdbCustomer = new System.Windows.Forms.RadioButton();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Items.AddRange(new object[] {
            "Employee/Worker",
            "Manager",
            "Ceo"});
            this.cmbOccupation.Location = new System.Drawing.Point(120, 16);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(121, 21);
            this.cmbOccupation.TabIndex = 40;
            this.cmbOccupation.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(34, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Occupation";
            // 
            // txtAdminP
            // 
            this.txtAdminP.Location = new System.Drawing.Point(120, 43);
            this.txtAdminP.Name = "txtAdminP";
            this.txtAdminP.Size = new System.Drawing.Size(145, 20);
            this.txtAdminP.TabIndex = 38;
            this.txtAdminP.UseSystemPasswordChar = true;
            this.txtAdminP.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdminP_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(11, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Admin Password";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(105, 138);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(145, 20);
            this.txtNIC.TabIndex = 36;
            this.txtNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIC_KeyPress);
            this.txtNIC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNIC_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(50, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 20);
            this.txtPhone.TabIndex = 34;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(50, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(105, 34);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(145, 20);
            this.txtfname.TabIndex = 30;
            this.txtfname.Validating += new System.ComponentModel.CancelEventHandler(this.txtfname_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(44, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbAdminister);
            this.groupBox1.Controls.Add(this.rdbCustomer);
            this.groupBox1.Location = new System.Drawing.Point(29, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 128);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Account Type";
            // 
            // rdbAdminister
            // 
            this.rdbAdminister.AutoSize = true;
            this.rdbAdminister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbAdminister.Location = new System.Drawing.Point(9, 84);
            this.rdbAdminister.Name = "rdbAdminister";
            this.rdbAdminister.Size = new System.Drawing.Size(133, 17);
            this.rdbAdminister.TabIndex = 1;
            this.rdbAdminister.TabStop = true;
            this.rdbAdminister.Text = "Administrative Account";
            this.rdbAdminister.UseVisualStyleBackColor = true;
            this.rdbAdminister.CheckedChanged += new System.EventHandler(this.rdbAdminister_CheckedChanged);
            // 
            // rdbCustomer
            // 
            this.rdbCustomer.AutoSize = true;
            this.rdbCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbCustomer.Location = new System.Drawing.Point(9, 61);
            this.rdbCustomer.Name = "rdbCustomer";
            this.rdbCustomer.Size = new System.Drawing.Size(112, 17);
            this.rdbCustomer.TabIndex = 0;
            this.rdbCustomer.TabStop = true;
            this.rdbCustomer.Text = "Customer Account";
            this.rdbCustomer.UseVisualStyleBackColor = true;
            this.rdbCustomer.CheckedChanged += new System.EventHandler(this.rdbCustomer_CheckedChanged);
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.label7);
            this.grpAdmin.Controls.Add(this.cmbOccupation);
            this.grpAdmin.Controls.Add(this.label6);
            this.grpAdmin.Controls.Add(this.txtAdminP);
            this.grpAdmin.Location = new System.Drawing.Point(377, 226);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(306, 73);
            this.grpAdmin.TabIndex = 41;
            this.grpAdmin.TabStop = false;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(105, 60);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(145, 20);
            this.txtlname.TabIndex = 46;
            this.txtlname.Validating += new System.ComponentModel.CancelEventHandler(this.txtlname_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(44, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Last Name";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(472, 127);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(145, 20);
            this.txtPass.TabIndex = 48;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(374, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Password";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(472, 164);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(145, 20);
            this.txtRePass.TabIndex = 50;
            this.txtRePass.UseSystemPasswordChar = true;
            this.txtRePass.Validating += new System.ComponentModel.CancelEventHandler(this.txtRePass_Validating);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(374, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 35);
            this.label10.TabIndex = 49;
            this.label10.Text = "Re-Enter Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laundry_System_Project.Properties.Resources.registernow_blue_png;
            this.pictureBox1.Location = new System.Drawing.Point(246, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::Laundry_System_Project.Properties.Resources.Windows_Close_Program_icon;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(62, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 36);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Image = global::Laundry_System_Project.Properties.Resources.Actions_edit_clear_history_icon1;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(409, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 40);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateAcc.Image = global::Laundry_System_Project.Properties.Resources.Button_Ok_icon__1_;
            this.btnCreateAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAcc.Location = new System.Drawing.Point(555, 373);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(95, 40);
            this.btnCreateAcc.TabIndex = 43;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(651, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 91);
            this.label11.TabIndex = 53;
            this.label11.Text = "Please fill all requred fields";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtlname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNIC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtfname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 178);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Personal Details";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(666, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 50);
            this.label13.TabIndex = 56;
            this.label13.Text = "Please choose Password and ID Wisely";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.UseWaitCursor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Laundry_System_Project.Properties.Resources.hero_backgroundr21;
            this.ClientSize = new System.Drawing.Size(879, 587);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdminP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbAdminister;
        private System.Windows.Forms.RadioButton rdbCustomer;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}