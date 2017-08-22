using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Detergent : IInventory
    {
        
        public string GetName()
        {
            return "detergent";
        }

        public double GetPrice()
        {
            return 3;
        }

        public int GetNumberForDiscount()
        {
            return 1;
        }

        public double GetDiscountPrice()
        {
            return 3;
        }
    }
}
