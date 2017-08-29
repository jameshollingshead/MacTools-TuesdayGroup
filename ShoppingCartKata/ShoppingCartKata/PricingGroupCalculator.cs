using System;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKata
{
    public class PricingGroupCalculator
    {
        public int GetNumberAtRegularPrice(IInventory item, int numberOfItemInCart)
        {
            int result;

            if (numberOfItemInCart < 0)
                result = 0;
            else
                result = numberOfItemInCart % item.GetNumberForDiscount();

            return result;
        }

        public int GetNumberAtDiscountPrice(IInventory item, int numberOfItemInCart)
        {
            int result;

            if (numberOfItemInCart < 0)
                result = 0;
            else
                result = numberOfItemInCart / item.GetNumberForDiscount();

            return result;
        }
    }
}