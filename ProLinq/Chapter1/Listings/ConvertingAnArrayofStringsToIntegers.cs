using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Listings
{
   public static class ConvertingAnArrayofStringsToIntegers 
    {
        public static void Print()
        {
            string[] numbers = {"0042","010","9","27"};

            int[] nums = numbers.Select(s => Int32.Parse(s)).OrderBy(s=>s).ToArray();

            foreach (int num in nums)
            {
             Console.WriteLine(num);   
            }

        }
    }
}
