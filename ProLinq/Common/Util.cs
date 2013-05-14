using System;
using System.Linq;

namespace Common
{
    public class Util
    {

        public static void InvokeListing<T>()
        {
            Type type = typeof(T);
            Console.WriteLine("\n");
            Console.WriteLine(type.Name);
            Console.WriteLine("--------------");

            if (type.GetInterfaces().Contains(typeof (IListing)))
            {
                IListing listing = (IListing)Activator.CreateInstance(type, new object[] { });
                listing.Print();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} does not implement the IListing Interface",type.Name);
                Console.ResetColor();
                Console.ReadKey(true);
            }
            

        }

        public static string[] GetNames()
        {
            return  new[]  { "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", 
        "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford",  "Garfield",
        "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
        "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", 
        "Monroe", "Nixon", "Obama", "Pierce", "Polk", "Reagan", "Roosevelt", 
        "Taft", "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"};
        }
    }
}
