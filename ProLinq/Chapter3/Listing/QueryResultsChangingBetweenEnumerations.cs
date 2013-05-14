using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Chapter3.Listing
{
    /// <summary>
    /// ints is not the actual values from the select but a pointer to how to obtain the values,
    /// so that if we change the value in the originating array and then loop through ints
    /// again we will then see the changes in the results as we have enumerated over the intarray
    /// again.
    /// </summary>
    public class QueryResultsChangingBetweenEnumerations : IListing
    {
        public void Print()
        {
            int[] intArray = new int[] {1,2,3};

            IEnumerable<int> ints = intArray.Select(i => i);

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
