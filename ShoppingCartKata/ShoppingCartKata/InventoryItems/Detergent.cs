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

        private string _name = "detergent";
        private double _price = 3;
        private int _numberForDiscount = 1;
        private double _discountPrice = 3;

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetNumberForDiscount()
        {
            return _numberForDiscount;
        }

        public double GetDiscountPrice()
        {
            return _discountPrice;
        }
    }
}
