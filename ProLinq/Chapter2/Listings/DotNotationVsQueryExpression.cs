using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Chapter2.Listings
{
    public class DotNotationVsQueryExpression : IListing
    {

        public void Print()
        {
            DotNotation();
            QueryExpression();
        }

        private static void DotNotation()
        {
            string[] names = getNames();

            IEnumerable<string> sequence = names
                .Where(n => n.Length < 6)
                .Select(n => n);

            foreach (string name in sequence)
            {
                Console.WriteLine("{0}",name);
            }
        }

        private static void QueryExpression()
        {
            string[] names = getNames();

            IEnumerable<string> sequence = from n in names
                                           where n.Length < 6
                                           select n;

            foreach (string name in sequence)
            {
                Console.WriteLine("{0}", name);
            }

        }

        private static string[] getNames()
        {
            return new[] {"Adam", "Arthur","Buchanan","Bush","Carter","Cleveland",
                          "Clinton","Coolidge"};
        }

    }
}
