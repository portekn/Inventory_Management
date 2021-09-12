﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the list of items.
         List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            InvItem item;
            for (int i = 0; i < invItems.Count; i++)
            {
                item = invItems[i];
                lstItems.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            frmNewItem newItemForm = new frmNewItem();
            // and then gets a new item from that form.
            InvItem invItem = newItemForm.GetNewItem();

            if (invItem != null)
            {
                invItems.Add(invItem);
                FillItemListBox();
            }
        }
            private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // Add code here that displays a dialog box to confirm
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box.
                // if the deletion is confirmed.

                InvItem invItem = invItems[i];

                string message = "Are you sure you want to delete " + invItem + "?";

                DialogResult button = MessageBox.Show(message, "Confirm the delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)

                {

                    //invItems -= invItem;

                    invItems.Remove(invItem);

                    InvItemDB.SaveItems(invItems);

                    FillItemListBox();

                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
