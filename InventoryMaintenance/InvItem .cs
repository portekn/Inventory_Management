using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem
    {
        //----------Properties----------//
        //ItemNo - Gets or sets an int that contains the item’s number.
        public int ItemNo
        { get; set; }
        //Description - Gets or sets a string that contains the item’s description.
        public string Description
        { get; set; }
        //Price - Gets or sets a decimal that contains the item’s price.
        public decimal Price 
        { get; set;}

        //----------Methods----------//
        /*GetDisplayText() - Returns a string that contains the item’s number, 
                             description, and price formatted like this:3245649    
                             Agapanthus ($7.95). (The item number and description 
                             are separated by four spaces.)*/
        public string GetDisplayText(string space) => ItemNo + space + Description + space + Price.ToString("C", CultureInfo.CurrentCulture);

        //----------Constructor----------//
        //() - Creates an InvItemobject with default values.
        //(itemNo, description, price) - Creates an InvItemobject withthe specified values.

        public InvItem() { }
        public InvItem(int itemNo, string description, decimal price) 
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

    }
}
