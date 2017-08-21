using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;
using ShoppingCartKata;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKataTests
{
    [TestFixture]
    class PriceCalculatorTest
    {
        private PriceCalculator priceCalculator;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            priceCalculator = new PriceCalculator();
        }


    }
}
