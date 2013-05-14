using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.Listings
{
    public class InstantiatingAndIntializingAnonymousType
    {
        public static void Print()
        {
            var address = new
                {
                    address = "105 Elm Street",
                    city = "Atlanta",
                    state = "GA",
                    postalCode = "30339"
                };

            Console.WriteLine("Address = {0} : City = {1} : state = {2} : postcode = {3}",address.address,address.city,address.state,address.postalCode);

            Console.WriteLine("{0}",address.GetType().ToString());
        }
    }
}
