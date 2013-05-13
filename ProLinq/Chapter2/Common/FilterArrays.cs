using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.Common
{
    public class FilterArrays
    {
        public delegate bool IntFilter(int i);

        public static int[] FilterArrayOfInts(int[] ints, IntFilter filter)
        {
            ArrayList aList = new ArrayList();

            foreach (int i in ints)
            {
                if (filter(i))
                {
                    aList.Add(i);
                }
            }

            return ((int[]) aList.ToArray(typeof (int)));
        }
    }
}
