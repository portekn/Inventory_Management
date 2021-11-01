using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class newStudentForm : Form
    {
        public newStudentForm()
        {
            InitializeComponent();
        }

        //Kelli Porter
        // Add a statement here that declares the list of items.
        private List<Students> students = null;

        //Kelli Porter
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            students = StudentDB.GetStudents();
            FillItemListBox();
        }

        //Kelli Porter
        private void FillItemListBox()
        {
            // Add code here that loads the list box with the items in the list.
            lstItems.Items.Clear();
            students.ForEach(x => lstItems.Items.Add(x.GetDisplayText("    ")));
        }

        //Kelli Porter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            newStudentForm newSForm = new newStudentForm();
            // and then gets a new item from that form.
            Students student = newSForm.GetNewStudent();

            if (student != null)
            {
                students.Add(student);
                StudentDB.SaveStudents(students);
                FillItemListBox();
            }
        }
        //Kelli Porter
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // Add code here that displays a dialog box to confirm
                string message = "Are you sure you want to delete this Student Record ?";
                DialogResult button = MessageBox.Show(message, "Confirm the delete", MessageBoxButtons.YesNo);

                // the deletion and then removes the item from the list,
                if (button == DialogResult.Yes)
                {
                    lstItems.Items.RemoveAt(i);
                    students.RemoveAt(i);

                }
                // saves the list of products, and refreshes the list box.
                StudentDB.SaveStudents(students);
                // if the deletion is confirmed.
                FillItemListBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

