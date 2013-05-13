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
            Util.PrintWrappers(typeof(HelloLinq));
            HelloLinq.Print();

            Util.PrintWrappers(typeof(XMLQueryUsingLinqToXml));
            XMLQueryUsingLinqToXml.Print();

            Util.PrintWrappers(typeof(SimpleDbQueryUsingLinqToSql));
            SimpleDbQueryUsingLinqToSql.Print();

            Util.PrintWrappers(typeof(ConvertingAnArrayofStringsToIntegers));
            ConvertingAnArrayofStringsToIntegers.Print();

            Util.PrintWrappers(typeof(ConvertArrayListEmployeeToArrayContacts));
            ConvertArrayListEmployeeToArrayContacts.Print();

            Util.PrintWrappers(typeof(ConvertingLegacyCollectionToIEnumerable));
            ConvertingLegacyCollectionToIEnumerable.Print();

            Util.PrintWrappers(typeof(QueryWithIntentionalExceptionDeferred));
            QueryWithIntentionalExceptionDeferred.Print();

            Util.PrintWrappers(typeof(UsingDataContextLogObject));
            UsingDataContextLogObject.Print();

            Console.ReadKey(true);
        }

     
    }
}
