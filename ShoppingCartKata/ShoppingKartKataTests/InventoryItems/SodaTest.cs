using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKataTests.InventoryItems
{
    [TestFixture]
    class SodaTest
    {
        private Soda soda;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            soda = new Soda();
        }

        [Test]
        public void GetNameReturnSoda()
        {
            Assert.AreEqual("soda", soda.GetName());
        }

        [Test]
        public void GetPriceReturn100()
        {
            Assert.AreEqual(1.00, soda.GetPrice(),delta);
        }

        [Test]
        public void GetDiscountAmountReturn3()
        {
            Assert.AreEqual(3, soda.GetNumberForDiscount());
        }

        [Test]
        public void GetDiscountPriceReturn200()
        {
            Assert.AreEqual(2.00, soda.GetDiscountPrice(), delta);
        }
    }
}
