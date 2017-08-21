using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShoppingCartKata;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKataTests
{
    [TestFixture]
    public class ShoppingCartTest
    {
        private ShoppingCart shoppingCart;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            shoppingCart = new ShoppingCart();
        }


    }
}


