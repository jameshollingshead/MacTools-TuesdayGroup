using System;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKata
{
    public class PriceCalculator
    {
        private readonly PricingGroupCalculator _pricingGroupCalculator = new PricingGroupCalculator();

        public double GetItemTotal(IInventory item, int numberOfItemInCart)
        {
            throw new NotImplementedException();
        }

        public double GetNonDiscountedTotal(IInventory item, int nonDiscountedNumber)
        {
            return item.GetPrice() * nonDiscountedNumber;
        }

        public double GetDiscountedTotal(IInventory item, int discountedNumber)
        {
            return item.GetDiscountPrice() * discountedNumber;
        }
    }
}