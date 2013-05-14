using System;
using Chapter2.ExtentionMethods;

namespace Chapter2.Listings
{
    public class CallingAnExtensionMethod
    {
        public static void Print()
        {
            double pi = "3.14159265350".ToDouble();
            Console.WriteLine(pi);
        }
    }
}
