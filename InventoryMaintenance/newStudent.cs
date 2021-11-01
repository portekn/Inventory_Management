using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class newStudent: Form
    {

        public newStudent()
        {
            InitializeComponent();
        }

        private TextBox txtName;
        private TextBox txtscore1;
        private TextBox txtscore2;
        private TextBox txtscore3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancel;
        private Button btnSave;

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
    private void btnSave_Click(object sender, EventArgs e)
    {
        if (IsValidData())
        {
            // Add code here that creates a new item
            students = new Students(Convert.ToInt32(txtName.Text),Convert.ToDecimal(txtscore1.Text), Convert.ToDecimal(txtscore2.Text), Convert.ToDecimal(txtscore3.Text));

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 27);
            this.txtName.TabIndex = 0;
            // 
            // txtscore1
            // 
            this.txtscore1.Location = new System.Drawing.Point(81, 76);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(46, 27);
            this.txtscore1.TabIndex = 1;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(81, 109);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(46, 27);
            this.txtscore2.TabIndex = 2;
            // 
            // txtscore3
            // 
            this.txtscore3.Location = new System.Drawing.Point(81, 142);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(46, 27);
            this.txtscore3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score 2:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score 3:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // newStudent
            // 
            this.ClientSize = new System.Drawing.Size(383, 201);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.txtscore1);
            this.Controls.Add(this.txtName);
            this.Name = "newStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
