using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
//Kelli Porter

namespace InventoryMaintenance
{
    public class InvItem
    {
        //Kelli Porter
        //----------Properties----------//
        //ItemNo - Gets or sets an int that contains the item’s number.
        public int ItemNo { get; set; }
        //Description - Gets or sets a string that contains the item’s description.
        public string Description { get; set; }
        //Price - Gets or sets a decimal that contains the item’s price.
        public decimal Price { get; set;}

        //Kelli Porter
        //----------Methods----------//
        /*GetDisplayText() - Returns a string that contains the item’s number, 
                             description, and price formatted like this:3245649    
                             Agapanthus ($7.95). (The item number and description 
                             are separated by four spaces.)*/
        public string GetDisplayText(string space) => ItemNo.ToString("00000000") + space + Description + " (" + Price.ToString("C", CultureInfo.CurrentCulture) + ")";

        //Kelli Porter
        //----------Constructor----------//
        //() - Creates an InvItemobject with default values.
        //(itemNo, description, price) - Creates an InvItemobject withthe specified values.

        public InvItem() { }
        public InvItem(int ItemNo, string Description, decimal Price) 
        {
            this.ItemNo = ItemNo;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
