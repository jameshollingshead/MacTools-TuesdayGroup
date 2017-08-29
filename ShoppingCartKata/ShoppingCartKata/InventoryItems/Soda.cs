using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Soda : IInventory
    {
        private string _name = "soda";
        private double _price = 1.00;
        private int _numberForDiscount = 3;
        private double _discountPrice = 2;

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
