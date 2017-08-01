using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzzKata;

namespace FizzBuzzKataTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void InputOfOneShouldReturn1()
        {
            var result = fizzBuzz.GetFizzBuzz(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void InputOfTwoShouldReturn2()
        {
            var result = fizzBuzz.GetFizzBuzz(2);
            Assert.AreEqual("2", result);
        }

        [Test]
        public void InputOfThreeShouldReturnFizz()
        {
            var result = fizzBuzz.GetFizzBuzz(3);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void InputOfFiveShouldReturnBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(5);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void InputOfSixShouldReturnFizz()
        {
            var result = fizzBuzz.GetFizzBuzz(6);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void InputOfTenShouldReturnBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(10);
            Assert.AreEqual("Buzz", result);
        }
        [Test]
        public void InputOfFifteenShouldReturnFizzBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void InputOfThirtyShouldReturnFizzBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(30);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
