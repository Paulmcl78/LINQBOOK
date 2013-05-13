using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Listings
{
    public static class ConvertingLegacyCollectionToIEnumerable
    {
        public static void Print()
        {
            // Build Array List
            ArrayList arrayList = new ArrayList {"Adams", "Arthur", "Buchann"};

            IEnumerable<string> names = arrayList.Cast<string>().Where(n => n.Length < 7);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
