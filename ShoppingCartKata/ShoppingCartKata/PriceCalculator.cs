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
            throw new NotImplementedException();
        }

        public double GetDiscountedTotal(IInventory item, int discountedNumber)
        {
            throw new NotImplementedException();
        }
    }
}