using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter2.Common;
using Common;

namespace Chapter2.Listings
{
    public class CallingFilterUsingLambdaExpression : IListing
    {
        public void Print()
        {
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int[] oddNums = FilterArrays.FilterArrayOfInts(nums, i => ((i & 1) == 1));

            foreach (int oddNum in oddNums)
            {
                Console.WriteLine(oddNum);
            }
        }
    }
}
