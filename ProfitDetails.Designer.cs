
namespace Laundry_System_Project
{
    partial class ProfitDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonthPro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDaily = new System.Windows.Forms.Label();
            this.btnGetProfDe = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpRate = new System.Windows.Forms.GroupBox();
            this.btnChangeRate = new System.Windows.Forms.Button();
            this.lblWashandDry = new System.Windows.Forms.Label();
            this.lblWashOnly = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNotVisual = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monthly Profit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daily Profit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::Laundry_System_Project.Properties.Resources.Windows_Close_Program_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(278, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::Laundry_System_Project.Properties.Resources.Window_Enter_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(60, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(32, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 246);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profit Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblMonthPro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDaily);
            this.groupBox1.Controls.Add(this.btnGetProfDe);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 157);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "To";
            // 
            // lblMonthPro
            // 
            this.lblMonthPro.AutoSize = true;
            this.lblMonthPro.Location = new System.Drawing.Point(118, 136);
            this.lblMonthPro.Name = "lblMonthPro";
            this.lblMonthPro.Size = new System.Drawing.Size(0, 13);
            this.lblMonthPro.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "From";
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Location = new System.Drawing.Point(118, 108);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(10, 13);
            this.lblDaily.TabIndex = 18;
            this.lblDaily.Text = "-";
            // 
            // btnGetProfDe
            // 
            this.btnGetProfDe.Location = new System.Drawing.Point(160, 11);
            this.btnGetProfDe.Name = "btnGetProfDe";
            this.btnGetProfDe.Size = new System.Drawing.Size(75, 44);
            this.btnGetProfDe.TabIndex = 17;
            this.btnGetProfDe.Text = "Get Profit Details";
            this.btnGetProfDe.UseVisualStyleBackColor = true;
            this.btnGetProfDe.Click += new System.EventHandler(this.btnGetProfDe_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(44, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.CadetBlue;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewAll.Location = new System.Drawing.Point(470, 355);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(104, 64);
            this.btnViewAll.TabIndex = 12;
            this.btnViewAll.Text = "View All Bill Info";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Location = new System.Drawing.Point(431, 87);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvshow.Size = new System.Drawing.Size(435, 243);
            this.dgvshow.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 302);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Profit Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpRate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Rate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpRate
            // 
            this.grpRate.Controls.Add(this.btnChangeRate);
            this.grpRate.Controls.Add(this.lblWashandDry);
            this.grpRate.Controls.Add(this.lblWashOnly);
            this.grpRate.Controls.Add(this.label4);
            this.grpRate.Controls.Add(this.label3);
            this.grpRate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRate.Location = new System.Drawing.Point(57, 38);
            this.grpRate.Name = "grpRate";
            this.grpRate.Size = new System.Drawing.Size(327, 150);
            this.grpRate.TabIndex = 8;
            this.grpRate.TabStop = false;
            this.grpRate.Text = "Charge Rate";
            // 
            // btnChangeRate
            // 
            this.btnChangeRate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnChangeRate.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangeRate.Location = new System.Drawing.Point(189, 100);
            this.btnChangeRate.Name = "btnChangeRate";
            this.btnChangeRate.Size = new System.Drawing.Size(75, 44);
            this.btnChangeRate.TabIndex = 11;
            this.btnChangeRate.Text = "Change Rate";
            this.btnChangeRate.UseVisualStyleBackColor = false;
            this.btnChangeRate.Click += new System.EventHandler(this.btnChangeRate_Click_1);
            // 
            // lblWashandDry
            // 
            this.lblWashandDry.AutoSize = true;
            this.lblWashandDry.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWashandDry.Location = new System.Drawing.Point(237, 61);
            this.lblWashandDry.Name = "lblWashandDry";
            this.lblWashandDry.Size = new System.Drawing.Size(13, 15);
            this.lblWashandDry.TabIndex = 10;
            this.lblWashandDry.Text = "0";
            // 
            // lblWashOnly
            // 
            this.lblWashOnly.AutoSize = true;
            this.lblWashOnly.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWashOnly.Location = new System.Drawing.Point(237, 28);
            this.lblWashOnly.Name = "lblWashOnly";
            this.lblWashOnly.Size = new System.Drawing.Size(13, 15);
            this.lblWashOnly.TabIndex = 9;
            this.lblWashOnly.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Rate Wash And Dry For (1KG)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Rate Wash only For (1KG)";
            // 
            // dgvNotVisual
            // 
            this.dgvNotVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotVisual.Location = new System.Drawing.Point(534, 177);
            this.dgvNotVisual.Name = "dgvNotVisual";
            this.dgvNotVisual.Size = new System.Drawing.Size(148, 82);
            this.dgvNotVisual.TabIndex = 13;
            this.dgvNotVisual.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(286, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(422, 64);
            this.label7.TabIndex = 29;
            this.label7.Text = "PROFIT DETAILS";
            // 
            // ProfitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(879, 587);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvNotVisual);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfitDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrative Account";
            this.Load += new System.EventHandler(this.ProfitDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpRate.ResumeLayout(false);
            this.grpRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label lblMonthPro;
        private System.Windows.Forms.Label lblDaily;
        private System.Windows.Forms.Button btnGetProfDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpRate;
        private System.Windows.Forms.Button btnChangeRate;
        private System.Windows.Forms.Label lblWashandDry;
        private System.Windows.Forms.Label lblWashOnly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNotVisual;
        private System.Windows.Forms.Label label7;
    }
}