using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CtoFConverter;
using NUnit.Framework;

namespace CtoFConverterTests
{
    [TestFixture]
    public class CtoFTests
    {
        public CtoF converter;
        public double delta = 0.01;

        [SetUp]
        public void SetUp()
        {
            converter = new CtoF();
        }

        [Test]
        public void Negative40CIsNegative40F()
        {
            Assert.AreEqual(-40.0, converter.Convert(-40.0), delta);
        }

        [Test]
        public void Negative30CIsNegative22F()
        {
            Assert.AreEqual(-22.0, converter.Convert(-30.0), delta);
        }
    }
}
