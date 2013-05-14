using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.Partial_Methods
{
    public partial class MyWidget
    {
        partial void MyWidgetStart(int count)
        {
           Console.WriteLine("In MyWidgetStart(count is {0})",count);
        }

        partial void MyWidgetEnd(int count)
        {
            Console.WriteLine("In MyWidgetEnd(count is {0})", count);
        }
    }
}
