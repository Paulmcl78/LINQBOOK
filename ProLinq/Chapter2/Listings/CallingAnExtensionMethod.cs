using System;
using Chapter2.ExtentionMethods;
using Common;

namespace Chapter2.Listings
{
    public class CallingAnExtensionMethod : IListing
    {
        public void Print()
        {
            double pi = "3.14159265350".ToDouble();
            Console.WriteLine(pi);
        }
    }
}
