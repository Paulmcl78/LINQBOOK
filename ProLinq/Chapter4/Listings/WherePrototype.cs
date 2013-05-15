using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Chapter4.Listings
{
    /// <summary>
    /// The Where operator is used to filter elements into a sequence.
    /// </summary>
    public class WherePrototype:IListing
    {
        public void Print()
        {
            string[] presidents = Util.GetNames();

            FirstWherePrototype(presidents);
            SecondWherePrototype(presidents);
        }

        /// <summary>
        /// 
        /// public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T,bool> predicate) 
        /// 
        /// This prototype of Where take an input source sequence and a predicate method delegate and returns an object that, when enumerated, enumerates
        /// through the input source sequence yielding elements for which the predicate method deletage returns true.  Because this is an extension 
        /// method we do not actually pass the input sequence, as long as we call the Where operator using the instance method syntax.
        /// </summary>
        private void FirstWherePrototype(string[] presidents)
        {
            IEnumerable<string> sequence = presidents.Where(p => p.StartsWith("J"));

            foreach (string s in sequence)
            {
                Console.WriteLine(s);
            }
        }

        
        /// <summary>
        /// 
        /// public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        /// 
        /// The second Where prototype is idential to the first one, except it specifies that your predicate method delegate recieves an additional integer
        /// input argument. That argument will be the index numbr for the element from the input sequence.
        /// Notice that this version doesn't even use the actual element itself, p; it uses only the index, i.  This code will cause every other element,
        /// the ones with an odd index number, to be yielded into the output sequence.
        /// </summary>
        private void SecondWherePrototype(string[] presidents)
        {
            IEnumerable<string> sequence = presidents.Where((p, i) => (i & 1) == 1);

            foreach (string s in sequence)
            {
                Console.WriteLine(s);
            }
        }
    }
}
