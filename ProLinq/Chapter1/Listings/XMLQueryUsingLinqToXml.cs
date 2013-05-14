using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Common;

namespace Chapter1.Listings
{
    public class XmlQueryUsingLinqToXml : IListing
    {
        public void Print()
        {
            XElement books = GetBooks();

            IEnumerable<XElement> titles = from book in books.Elements("book")
                         where (string) book.Element("author") == "Joe Rattz"
                         select book.Element("title");

            foreach (var title in titles)
            {
                Console.WriteLine(title.Value);
            }


        }



        private static XElement GetBooks()
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
