using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class HelloLinq
    {
        public static void Print()
        {

            string[] greetings = {"Hello world", "Hello LINQ", "Hello Apress"};

            IEnumerable<string> items = from s in greetings
                        where s.EndsWith("LINQ")
                        select s;

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
        }
    }
}
