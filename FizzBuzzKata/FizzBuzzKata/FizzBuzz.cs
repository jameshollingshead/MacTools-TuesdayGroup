using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int p)
        {
            
            if (IsDivisibleBy3(p) && IsDivisibleBy5(p))
                return "FizzBuzz";
            if (IsDivisibleBy3(p))
                return "Fizz";
            else if (IsDivisibleBy5(p))
                return "Buzz";

            return p.ToString();
        }

        private static bool IsDivisibleBy5(int p)
        {
            return p % 5 == 0;
        }

        private static bool IsDivisibleBy3(int p)
        {
            return p % 3 == 0;
        }


    }
}

