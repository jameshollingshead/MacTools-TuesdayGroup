using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Chips : IInventory
    {
        private string _name = "chips";
        private double _price = 0.75;
        private int _numberForDiscount = 1;
        private double _discountPrice = 0.75;

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
