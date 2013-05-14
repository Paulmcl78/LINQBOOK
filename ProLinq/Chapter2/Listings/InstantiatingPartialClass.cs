using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter2.Partial_Methods;
using Common;

namespace Chapter2.Listings
{
    public class InstantiatingPartialClass : IListing
    {
        public void Print()
        {
            MyWidget myWidget =  new MyWidget();
        }
    }
}
