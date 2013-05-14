using System;
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
            Util.PrintWrappers(typeof(CallingFilterUsingLambdaExpression));
            CallingFilterUsingLambdaExpression.Print();

            Util.PrintWrappers(typeof(InstantiatingAndIntializingAnonymousType));
            InstantiatingAndIntializingAnonymousType.Print();

            Util.PrintWrappers(typeof(CallingAnExtensionMethod));
            CallingAnExtensionMethod.Print();

            Util.PrintWrappers(typeof(InstantiatingPartialClass));
            InstantiatingPartialClass.Print();

            Util.PrintWrappers(typeof(DotNotationVsQueryExpression));
            DotNotationVsQueryExpression.print();

            Console.ReadKey(true);
        }
    }
}
