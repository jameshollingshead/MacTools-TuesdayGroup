using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Apple : IInventory
    {
        private string _name = "apple";
        private double _price = .50;
        private int _discount = 3;
        private double _discountedPrice = 1.20;

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
            return _discount;
        }

        public double GetDiscountPrice()
        {
            return _discountedPrice;
        }
    }
}
