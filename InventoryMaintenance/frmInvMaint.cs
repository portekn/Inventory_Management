using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Kelli Porter

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        //Kelli Porter
        // Add a statement here that declares the list of items.
        private List<InvItem> invItems = null;

        //Kelli Porter
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        //Kelli Porter
        private void FillItemListBox()
        {
            // Add code here that loads the list box with the items in the list.
            lstItems.Items.Clear();
            invItems.ForEach(x => lstItems.Items.Add(x.GetDisplayText("    ")));
        }

        //Kelli Porter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            frmNewItem newItemForm = new frmNewItem();
            // and then gets a new item from that form.
            InvItem invItem = newItemForm.GetNewItem();

            if (invItem != null)
            {
                invItems.Add(invItem);
                InvItemDB.SaveItems(invItems);
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
                string message = "Are you sure you want to delete this item ?";
                DialogResult button = MessageBox.Show(message, "Confirm the delete", MessageBoxButtons.YesNo);

                // the deletion and then removes the item from the list,
                if (button == DialogResult.Yes)
                {
                    lstItems.Items.RemoveAt(i);
                    invItems.RemoveAt(i);

                }
                // saves the list of products, and refreshes the list box.
                InvItemDB.SaveItems(invItems);
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
