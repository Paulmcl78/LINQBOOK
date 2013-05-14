using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Chapter3.Listing
{
    public class LinqToObectsQuery : IListing
    {
        public void Print()
        {
            string[] presidents = Util.getNames();

            string president = presidents.Where(p => p.StartsWith("Lin")).First();

            Console.WriteLine(president);
        }
    }
}
