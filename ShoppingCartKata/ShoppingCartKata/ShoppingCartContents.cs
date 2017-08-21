using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKata
{
    
    public class ShoppingCartContents
    {
        private List<IInventory> _scannedItems = new List<IInventory>();

        public void AddItem(IInventory item)
        {
            throw new NotImplementedException();
        }

        public int GetItemCount(IInventory item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IInventory> GetUniqueItemsInCart()
        {
            throw new NotImplementedException();
        }
    }
}
