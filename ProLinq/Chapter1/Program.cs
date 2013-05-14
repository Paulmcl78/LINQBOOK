using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter1.Listings;
using Common;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.InvokeListing<HelloLinq>();

            Util.InvokeListing<XmlQueryUsingLinqToXml>();

            Util.InvokeListing<SimpleDbQueryUsingLinqToSql>();

            Util.InvokeListing<ConvertingAnArrayofStringsToIntegers>();

            Util.InvokeListing<ConvertArrayListEmployeeToArrayContacts>();

            Util.InvokeListing<ConvertingLegacyCollectionToIEnumerable>();

            Util.InvokeListing<QueryWithIntentionalExceptionDeferred>();

            Util.InvokeListing<UsingDataContextLogObject>();

            Console.ReadKey(true);
        }

     
    }
}
