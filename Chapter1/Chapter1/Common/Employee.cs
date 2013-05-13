using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Common
{
    public class Employee
    {
        public int id;
        public string firstName;
        public string lastName;

        public static ArrayList GetEmployees()
        {
            ArrayList list = new ArrayList();

            list.Add(new Employee {id = 1, firstName = "Joe", lastName = "Rattz"});
            list.Add(new Employee { id = 2, firstName = "William", lastName = "Gates" });
            list.Add(new Employee { id = 3, firstName = "Anders", lastName = "Hejlsberg" });

            return list;
        }
    }
}
