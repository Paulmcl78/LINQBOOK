using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Chapter3.Listing
{
    public class FuncDelegate: IListing
    {
        public void Print()
        {
            // Create an array of ints
            int[] ints = new int[] {1,2,3,4,5,6};

            // Declare our delegate
            Func<int, bool> GreaterThanTwo = i => i > 2;

            // Perform the query ...not really. Don't forget about deferred queries!!!
            IEnumerable<int> intsGreaterThanTwo = ints.Where(GreaterThanTwo);

            // Display results
            foreach (int i in intsGreaterThanTwo)
            {
                Console.WriteLine(i);
            }
        }
    }
}
