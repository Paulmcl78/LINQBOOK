using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.Partial_Methods
{
    /// <summary>
    /// Partial methods are methods where the prototype or definition of the method is specified in the declareation of a partial
    /// class, but an implementation for the method is not provided in that same declaration of the partial class.
    /// </summary>
    public partial class MyWidget
    {
        partial void MyWidgetStart(int count);
        partial void MyWidgetEnd(int count);

        public MyWidget()
        {
            int count = 0;
            MyWidgetStart(++count);
            Console.WriteLine("In the constructor for MyWidget");
            MyWidgetEnd(++count);
            Console.WriteLine("count = " + count);
        }
    }
}
