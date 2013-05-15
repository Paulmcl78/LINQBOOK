using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter4.Listings;
using Common;

namespace Chapter4
{
    class Program
    {
        /// <summary>
        /// All operators used in these listings will be deferred query operators.
        /// </summary>
        static void Main(string[] args)
        {
            Util.InvokeListing<WherePrototype>();

            Util.InvokeListing<SelectPrototype>();

            Console.ReadKey(true);
        }
    }
}
