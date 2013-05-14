using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Chapter1.Listings
{
    public class HelloLinq : IListing
    {
        public void Print()
        {

            string[] greetings = {"Hello world", "Hello LINQ", "Hello Apress"};

            IEnumerable<string> items = from s in greetings
                        where s.EndsWith("LINQ")
                        select s;

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }


        }
    }
}
