using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadKey(true);
        }

        public static void PrintWrappers(Type type)
        {
            Console.WriteLine(type.Name);
            Console.WriteLine("--------------");
        }
    }
}
