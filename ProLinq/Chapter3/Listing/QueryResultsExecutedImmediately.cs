using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Chapter3.Listing
{
    /// <summary>
    /// Notice that the results do not change from one enumeration to the next as the ToList
    /// method is not deferred, and the query is actually preformed at the time the quesy is called.
    /// </summary>
    public class QueryResultsExecutedImmediately : IListing
    {
        public void Print()
        {
            int[] intArray = new int[] { 1, 2, 3 };

            List<int> ints = intArray.Select(i => i).ToList();

            //Display the results
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------");
            //Change an element in the source data
            intArray[0] = 5;

            //display results again

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
