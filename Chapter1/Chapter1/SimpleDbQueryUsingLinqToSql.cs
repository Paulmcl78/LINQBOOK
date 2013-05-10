using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nwind;


namespace Chapter1
{
    public static class SimpleDbQueryUsingLinqToSql
    {
        public static void Print()
        {
            Northwind db = new Northwind(@"Data Source=.\SQLEXPRESS;Initial Catalog=Northwind; Integrated Security=SSPI");

            IQueryable<Customer> custs = from c in db.Customers
                        where c.City == "Rio de Janeiro"
                        select c;

            foreach (Customer customer in custs)
            {
                Console.WriteLine("{0}",customer.CompanyName);
            }

            Console.WriteLine("\n");
        }
    }
}
