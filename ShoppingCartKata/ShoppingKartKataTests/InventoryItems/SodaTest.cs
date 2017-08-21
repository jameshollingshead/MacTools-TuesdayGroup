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
    class SodaTest
    {
        private Soda soda;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            soda = new Soda();
        }

        

    }
}
