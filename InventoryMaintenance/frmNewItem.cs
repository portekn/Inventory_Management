﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the inventory item.
        private InvItem invItem = null;

        // Add a method here that gets and returns a new item.
        public InvItem GetNewItem() 
        {
            this.ShowDialog();
            return invItem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Add code here that creates a new item
                invItem = new InvItem(Convert.ToInt32(txtItemNo), txtDescription.Text, Convert.ToDecimal(txtPrice));
                // and closes the form
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
