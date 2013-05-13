using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter1.Listings;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWrappers(typeof(HelloLinq));
            HelloLinq.Print();

            PrintWrappers(typeof(XMLQueryUsingLinqToXml));
            XMLQueryUsingLinqToXml.Print();

            PrintWrappers(typeof(SimpleDbQueryUsingLinqToSql));
            SimpleDbQueryUsingLinqToSql.Print();

            PrintWrappers(typeof(ConvertingAnArrayofStringsToIntegers));
            ConvertingAnArrayofStringsToIntegers.Print();

            PrintWrappers(typeof(ConvertArrayListEmployeeToArrayContacts));
            ConvertArrayListEmployeeToArrayContacts.Print();

            PrintWrappers(typeof(ConvertingLegacyCollectionToIEnumerable));
            ConvertingLegacyCollectionToIEnumerable.Print();

            PrintWrappers(typeof(QueryWithIntentionalExceptionDeferred));
            QueryWithIntentionalExceptionDeferred.Print();

            PrintWrappers(typeof(UsingDataContextLogObject));
            UsingDataContextLogObject.Print();

            Console.ReadKey(true);
        }

        public static void PrintWrappers(Type type)
        {
            Console.WriteLine("\n");
            Console.WriteLine(type.Name);
            Console.WriteLine("--------------");
        }
    }
}
