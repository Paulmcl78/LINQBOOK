using System;
using System.Linq;
using System.Xml.Linq;

namespace Chapter1
{
    public static class XMLQueryUsingLinqToXml
    {
        public static void Print()
        {
            XElement books = getBooks();

            var titles = from book in books.Elements("book")
                         where (string) book.Element("author") == "Joe Rattz"
                         select book.Element("title");

            foreach (var title in titles)
            {
                Console.WriteLine(title.Value);
            }

            Console.WriteLine("\n");
        }



        private static XElement getBooks()
        {

            return XElement.Parse(
                @"<books>
                    <book>
                        <title>Pro LINQ: Language Integrated Query in C# 2010</title>
                        <author>Joe Rattz</author>
                    </book>
                    <book>
                        <title>Pro .NET 4.0 Parallet Programmins in c#</title>
                        <author>Adam Freeman</author>
                    </book>
                    <book>
                        <title>Pro VB 2010 and the .NET 4.0 Platform</title>
                        <author>Andrew Troelsen</author>
                    </book>
                   </books>");
        }
    }
}
