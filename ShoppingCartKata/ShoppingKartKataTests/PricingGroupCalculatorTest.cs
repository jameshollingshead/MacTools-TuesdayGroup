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

        
    }
}
