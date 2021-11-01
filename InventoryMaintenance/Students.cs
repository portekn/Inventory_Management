using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    class Students 
    { 
     //Kelli Porter
     //----------Properties----------//
     //Name - Gets or sets an string that contains a students name.
    public string Name { get; set; }
    //Score1,2,3 - Gets or sets a decimal of the students score.
    public decimal score1 { get; set; }
    public decimal score2 { get; set; }
    public decimal score3 { get; set; }

     //Kelli Porter
     //----------Methods----------//
     /*GetDisplayText() - Returns a string that contains the students name and scores */
    public string GetDisplayText(string space) => Name + " | " + score1 + " | " + score2 + " | " + score3;

    //Kelli Porter
    //----------Constructor----------//
    //() - Creates an InvItemobject with default values.
    //(itemNo, description, price) - Creates an InvItemobject withthe specified values.

    public Students() { }
    public Students(string Name, decimal score1, decimal score2, decimal score3)
    {
        this.Name = Name;
        this.score1 = score1;
        this.score1 = score2;
        this.score1 = score3;
        }
}
}
