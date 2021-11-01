using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class newStudent : Form
    {

        public newStudent()
        {
            InitializeComponent();
        }

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtscore1;
        private TextBox txtscore2;
        private TextBox txtscore3;
        private Button btnCancel;
        private Button btnSubmit;

        //Kelli Porter
        // Add a statement here that declares the student item.
        public Students students = null;

        //Kelli Porter
        // Add a method here that gets and returns a new item.
        public Students GetNewStudent()
        {
            this.ShowDialog();
            return students;
        }

        //Kelli Porter
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Add code here that creates a new item
                students = new Students(txtName.Text, Convert.ToDecimal(txtscore1.Text), Convert.ToDecimal(txtscore2.Text), Convert.ToDecimal(txtscore3.Text));

                // and closes the form
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtName) &&
                   Validator.IsDecimal(txtscore1) &&
                   Validator.IsDecimal(txtscore2) &&
                   Validator.IsDecimal(txtscore3);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 27);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score 3:";
            // 
            // txtscore1
            // 
            this.txtscore1.Location = new System.Drawing.Point(99, 71);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(48, 27);
            this.txtscore1.TabIndex = 5;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(99, 110);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(48, 27);
            this.txtscore2.TabIndex = 6;
            // 
            // txtscore3
            // 
            this.txtscore3.Location = new System.Drawing.Point(99, 152);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(48, 27);
            this.txtscore3.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(194, 156);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 26);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // newStudent
            // 
            this.ClientSize = new System.Drawing.Size(341, 222);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.txtscore1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "newStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
      
}
