using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        //define variables in the class for a new item
        private int intItemNo;
        private string strDescription;
        private decimal decPrice;

        //constructor
        public InvItem() { }

        //constructor that accepts item no, description and price
        public InvItem(int intItemNo, string strDescription, decimal decPrice)
        {
            this.ItemNo = intItemNo;
            this.Description = strDescription;
            this.Price = decPrice;
        }

        //set and get price
        public decimal Price
        {
            get { return decPrice; }
            set { decPrice = value; }
        }

        //set and get item no
        public int ItemNo
        {
            get { return intItemNo; }
            set { intItemNo = value; }
        }

        //set and get description
        public string Description
        {
            get { return strDescription; }
            set { strDescription = value; }
        }

        /// <summary>
        /// returns a formatted string containing Item No, Description and Price.
        /// </summary>
        /// <returns></returns>
        public string GetDisplayText()
        {
            return ItemNo + "    " + Description + " (" + Price.ToString("c") + ")";
        }
    }
}
