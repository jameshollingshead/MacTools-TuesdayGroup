using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKataTests.InventoryItems
{
    [TestFixture]
    class AppleTest
    {
        private Apple apple;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            apple = new Apple();
        }

        [Test]
        public void GetNameReturnApple()
        {
            Assert.AreEqual("apple", apple.GetName());
        }

        [Test]
        public void GetPriceReturn50()
        {
            Assert.AreEqual(0.50, apple.GetPrice(), delta );
        }

        [Test]
        public void ThreeApplesNeededToGetDiscount()
        {
            Assert.AreEqual(3, apple.GetNumberForDiscount());
        }

        [Test]
        public void GetDiscountPriceReturn120()
        {
            Assert.AreEqual(1.20, apple.GetDiscountPrice(), delta);
        }
    }
}
