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
    class PricingGroupCalculatorTest
    {
        private PricingGroupCalculator _pricingGroupCalculator;

        [SetUp]
        public void SetUp()
        {
            _pricingGroupCalculator = new PricingGroupCalculator();
        }

        [Test]
        public void OneAppleIsOneAppleAtRegularPrice()
        {
            Assert.AreEqual(1, _pricingGroupCalculator.GetNumberAtRegularPrice(new Apple(), 1));
        }

        [Test]
        public void TwoApplesIsTwoApplesAtRegularPrice()
        {
            Assert.AreEqual(2, _pricingGroupCalculator.GetNumberAtRegularPrice(new Apple(), 2));
        }

        [Test]
        public void ThreeApplesIsZeroApplesAtRegularPrice()
        {
            Assert.AreEqual(0, _pricingGroupCalculator.GetNumberAtRegularPrice(new Apple(), 3));
        }
        
        [Test]
        public void NegativeOneApplesIsZeroApplesAtRegularPrice()
        {
            Assert.AreEqual(0, _pricingGroupCalculator.GetNumberAtRegularPrice(new Apple(), -1));
        }

        [Test]
        public void OneAppleIsZeroApplesAtDiscountPrice()
        {
            Assert.AreEqual(0, _pricingGroupCalculator.GetNumberAtDiscountPrice(new Apple(), 1));
        }

        [Test]
        public void ThreeApplesIsOneApplesAtDiscountPrice()
        {
            Assert.AreEqual(1, _pricingGroupCalculator.GetNumberAtDiscountPrice(new Apple(), 3));
        }

        [Test]
        public void ZeroApplesIsZeroApplesAtDiscountPrice()
        {
            Assert.AreEqual(0, _pricingGroupCalculator.GetNumberAtDiscountPrice(new Apple(), 0));
        }

        [Test]
        public void NegativeThreeApplesIsZeroApplesAtDiscountPrice()
        {
            Assert.AreEqual(0, _pricingGroupCalculator.GetNumberAtDiscountPrice(new Apple(), -3));
        }
    }
}
