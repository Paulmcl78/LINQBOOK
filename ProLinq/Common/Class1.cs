using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Util
    {

        public static void PrintWrappers(Type type)
        {
            Console.WriteLine("\n");
            Console.WriteLine(type.Name);
            Console.WriteLine("--------------");
        }
    }
}
