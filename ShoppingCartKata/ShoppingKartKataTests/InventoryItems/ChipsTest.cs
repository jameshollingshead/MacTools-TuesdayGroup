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
    class ChipsTest
    {
        private Chips chips;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            chips = new Chips();
        }

        [Test]
        public void GetNameReturnChips()
        {
            Assert.AreEqual("chips", chips.GetName());
        }

        [Test]
        public void GetPriceReturn75()
        {
            Assert.AreEqual(0.75, chips.GetPrice(), delta);
        }

        [Test]
        public void GetNumberForDiscountReturn1()
        {
            Assert.AreEqual(1, chips.GetNumberForDiscount());
        }

        [Test]
        public void GetDiscountPriceReturn75()
        {
            Assert.AreEqual(0.75, chips.GetDiscountPrice(), delta);
        }
    }
}
