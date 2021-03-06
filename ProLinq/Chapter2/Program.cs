﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter2.Listings;
using Common;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.InvokeListing<CallingFilterUsingLambdaExpression>();

            Util.InvokeListing<InstantiatingAndIntializingAnonymousType>();

            Util.InvokeListing<CallingAnExtensionMethod>();

            Util.InvokeListing<InstantiatingPartialClass>();

            Util.InvokeListing<DotNotationVsQueryExpression>();

            Console.ReadKey(true);
        }
    }
}
