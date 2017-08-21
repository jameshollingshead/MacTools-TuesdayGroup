using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKata
{
    public class ShoppingCart
    {
        private ShoppingCartContents _shoppingCartContents = new ShoppingCartContents();
        private readonly PriceCalculator _priceCalculator = new PriceCalculator();

        public void ScanItem(IInventory item)
        {
            throw new NotImplementedException();
        }
        
        public double GetTotal()
        {
            throw new NotImplementedException();
        }

    }
}
