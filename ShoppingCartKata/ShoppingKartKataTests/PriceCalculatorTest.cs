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

        [Test]
        public void OneAppleNonDiscountedPriceReturns50()
        {
            Assert.AreEqual(0.50, priceCalculator.GetNonDiscountedTotal(new Apple(), 1), delta);
        }

        [Test]
        public void TwoApplesNonDiscountedPriceReturns100()
        {
            Assert.AreEqual(1.00, priceCalculator.GetNonDiscountedTotal(new Apple(), 2), delta);
        }

    
    }
}
