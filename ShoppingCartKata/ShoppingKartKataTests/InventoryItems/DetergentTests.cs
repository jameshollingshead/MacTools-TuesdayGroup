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
    class DetergentTests
    {
        private Detergent detergent;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            detergent = new Detergent();
        }

        [Test]
        public void GetNameReturnDetergent()
        {
            Assert.AreEqual("detergent", detergent.GetName());
        }

        [Test]
        public void GetPriceReturnThree()
        {
            Assert.AreEqual(3, detergent.GetPrice(), delta);
        }

        [Test]
        public void GetNumberForDiscountReturn1()
        {
            Assert.AreEqual(1, detergent.GetNumberForDiscount());
        }

        [Test]
        public void GetDiscountPriceReturn3()
        {
            Assert.AreEqual(3, detergent.GetDiscountPrice(), delta);
        }

    }
}
