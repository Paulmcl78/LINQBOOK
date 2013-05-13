using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Listings
{
    public static class QueryWithIntentionalExceptionDeferred
    {
        public static void Print()
        {
            try
            {
                string[] strings = { "one", "two", null, "three" };

                Console.WriteLine("Before where is called");

                IEnumerable<string> ieStrings = strings.Where(s => s.Length == 3);

                Console.WriteLine("After where is called");

                foreach (string ieString in ieStrings)
                {
                    Console.WriteLine("processing " + ieString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception :" + ex.Message);
            }
        }
    }
}
