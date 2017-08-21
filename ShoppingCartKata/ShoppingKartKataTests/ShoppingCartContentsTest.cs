using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ShoppingCartKata;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKataTests
{
    [TestFixture]
    class ShoppingCartContentsTest
    {
        private ShoppingCartContents shoppingCartContents;

        [SetUp]
        public void SetUp()
        {
            shoppingCartContents = new ShoppingCartContents();
        }

        
    }
}
