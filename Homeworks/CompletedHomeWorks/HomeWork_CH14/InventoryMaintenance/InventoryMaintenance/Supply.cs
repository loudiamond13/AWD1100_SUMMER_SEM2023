using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    internal class Supply : InventoryItem
    {
        

        //full argument constructor
        public Supply(int itemNo, string description, decimal price, string manufacturer)
                        : base (itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }

        //get set
        public string Manufacturer { get; set; } = "";

        public override string GetDisplayText()
        {
            return ItemNo.ToString() + "    " + Manufacturer + "    " + Description + "    " + Price.ToString("c");
        }

    }
}
