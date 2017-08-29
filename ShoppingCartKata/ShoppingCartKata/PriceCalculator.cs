using System;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKata
{
    public class PriceCalculator
    {
        private readonly PricingGroupCalculator _pricingGroupCalculator = new PricingGroupCalculator();

        public double GetItemTotal(IInventory item, int numberOfItemInCart)
        {
            var nonDiscountedTotal = GetNonDiscountedTotal(item, _pricingGroupCalculator.GetNumberAtRegularPrice(item, numberOfItemInCart));
            var discountedTotal = GetDiscountedTotal(item, _pricingGroupCalculator.GetNumberAtDiscountPrice(item, numberOfItemInCart));

            return nonDiscountedTotal + discountedTotal;
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