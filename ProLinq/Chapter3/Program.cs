using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3.Listing;
using Common;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.InvokeListing<LinqToObectsQuery>();

            Util.InvokeListing<QueryResultsChangingBetweenEnumerations>();

            Util.InvokeListing<QueryResultsExecutedImmediately>();

            Console.ReadKey(true);
        }
    }
}
