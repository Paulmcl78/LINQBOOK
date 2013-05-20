using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter4.Common;
using Common;

namespace Chapter4.Listings
{
    /// <summary>
    /// The select operator is used to create an output sequence of one type of element from an input sequence of another type of element.  It is not necessary
    /// that the input element type and the output element type to be the same.
    /// </summary>
    public class SelectPrototype:IListing
    {
        public void Print()
        {
            string[] presidents = Util.GetNames();
            FirstSelectPrototype(presidents);
            SecondSelectPrototype(presidents);
            FirstSelectManyPrototype(presidents);
            SecondSelectManyPrototype(presidents);
        }


        /// <summary>
        /// public static IEnumerable<S> Select<T,S>(this IEnumerable<T> source, Func<T,S> selector )
        /// 
        /// This prototype of Select take an input source sequence and a selector method delegate as input arguments, and it returns an object that, when
        /// enumerate, enuerates the input source swquence yielding a sequence of elements of type S.  When calling Select, you pass a delegate to a selector
        /// method via the selector argument.  Your selctor method must accept a type T as input, where T is the type of elements contained in the input sequence
        /// and it returns a type S element
        /// 
        /// Notice we are passing out selector method using a lamda expressiong. In this case, our lambda expression will return the lenght of each element in
        /// the input sequence.  Also notice that although our input types are strings, our output types are ints.
        /// </summary>
        private void FirstSelectPrototype(string[] presidents)
        {
            IEnumerable<int> nameLengths = presidents.Select(p => p.Length);

            foreach (int nameLength in nameLengths)
            {
                Console.WriteLine(nameLength);
            }
        }



        /// <summary>
        /// 
        /// public static IEnumerable<S> Select<T,S>(this IEnumerable<T> source, Func<T,int,S> selector)
        /// 
        /// In this prototype of the select operator an additional integer is passed to the selector method delegate.  This will be the zero-based index
        /// for the input element in the sequence
        /// </summary>
        /// <param name="presidents"></param>
        private void SecondSelectPrototype(string[] presidents)
        {
            var nameObjs = presidents.Select((p, i) => new {Index = i, LastName = p});
            foreach (var item in nameObjs)
            {
                Console.WriteLine("{0}. {1}",item.Index +1 , item.LastName);
            }
        }

        /// <summary>
        /// 
        /// public static IEnumerable<S> SelectMany<T,S>(this IEnumerable<T> source,Func<T,IEnumerable<S>> selector)
        /// 
        /// This prototype of the operator is passed an input source sequence of elements of type T and a selector method delegate, and it returns an object that, 
        /// when enumerated, enumerates the input source sequence, passing each element individually from the input sequence to the selector method. The selector
        /// method then returns an object, that when enumerated, yields zero or more elements of type S in an intermediate output sequecne.
        /// 
        /// In the example below the selector method receives a string as input, and by calling to ToArray on that string, it returns an array of chars, which
        /// becomes an output sequence of type char.
        /// </summary>
        private void FirstSelectManyPrototype(string[] presidents)
        {
            IEnumerable<char> chars = presidents.SelectMany(p => p.ToArray());

            foreach (char c in chars)
            {
               Console.WriteLine(c); 
            }

        }

        /// <summary>
        /// 
        /// public static IEnumerable<S> SelectMany<T,S>(this IEnumerable<T> source, Func<T,int,IEnumerable<S>> selector ) 
        /// 
        /// This prototype behaves just like the first prototype, except a zero-based index of the elements in the input sequence is passed to your selector
        /// method.
        /// 
        /// In the example below, the lambda expression we provided checks the incoming index and outputs the array of characters from the input string only
        /// if the index is less than five. This means we will get the characters for the first 5 input strings only.
        /// </summary>
        private void SecondSelectManyPrototype(string[] presidents)
        {
            IEnumerable<char> chars = presidents.SelectMany((p, i) => i < 5 ? p.ToArray() : new char[] {});

            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }
        
    }
}
