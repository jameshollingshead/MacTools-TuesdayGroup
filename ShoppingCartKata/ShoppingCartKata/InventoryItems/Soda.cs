using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Soda : IInventory
    {
        
        public string GetName()
        {
            return "soda";
        }

        public double GetPrice()
        {
            return 1.00;
        }

        public int GetNumberForDiscount()
        {
            return 3;
        }

        public double GetDiscountPrice()
        {
            return 2.00;
        }
    }
}
