
namespace Laundry_System_Project
{
    partial class ChangeRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeRate));
            this.label1 = new System.Windows.Forms.Label();
            this.txtWash = new System.Windows.Forms.TextBox();
            this.txtWAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btncansal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate of Wash Only For 1KG";
            // 
            // txtWash
            // 
            this.txtWash.Location = new System.Drawing.Point(385, 150);
            this.txtWash.Name = "txtWash";
            this.txtWash.Size = new System.Drawing.Size(100, 20);
            this.txtWash.TabIndex = 1;
            // 
            // txtWAD
            // 
            this.txtWAD.Location = new System.Drawing.Point(385, 185);
            this.txtWAD.Name = "txtWAD";
            this.txtWAD.Size = new System.Drawing.Size(100, 20);
            this.txtWAD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate of Wash and dry for 1KG";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Laundry_System_Project.Properties.Resources.Go_back_icon;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(265, 229);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btncansal
            // 
            this.btncansal.Image = global::Laundry_System_Project.Properties.Resources.Windows_Close_Program_icon;
            this.btncansal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncansal.Location = new System.Drawing.Point(346, 229);
            this.btncansal.Name = "btncansal";
            this.btncansal.Size = new System.Drawing.Size(80, 40);
            this.btncansal.TabIndex = 5;
            this.btncansal.Text = "Cancel";
            this.btncansal.UseVisualStyleBackColor = true;
            this.btncansal.Click += new System.EventHandler(this.btncansal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Laundry_System_Project.Properties.Resources.Save_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(477, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(220, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 64);
            this.label3.TabIndex = 29;
            this.label3.Text = "CHANGE RATE";
            // 
            // ChangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laundry_System_Project.Properties.Resources.hero_backgroundr21;
            this.ClientSize = new System.Drawing.Size(879, 587);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btncansal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWash);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRate";
            this.Load += new System.EventHandler(this.ChangeRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWash;
        private System.Windows.Forms.TextBox txtWAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btncansal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
    }
}