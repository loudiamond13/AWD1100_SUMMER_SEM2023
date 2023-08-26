using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Plant : InventoryItem
    {
        //getters & Setters
        public string Size { get; set; } = "";


        //full argument constructor
        public Plant(int itemNo, string description, decimal price, string size) 
                    : base(itemNo, description, price)  
        {
            Size = size;

        }

        public override string GetDisplayText()
        {
            return ItemNo.ToString() + "    " + Size + "    " + Description + "    " + Price.ToString("c");
        }
    }
}
