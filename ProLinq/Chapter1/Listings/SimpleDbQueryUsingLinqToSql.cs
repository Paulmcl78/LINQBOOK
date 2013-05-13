using System;
using System.Linq;
using nwind;

namespace Chapter1.Listings
{
    public static class SimpleDbQueryUsingLinqToSql
    {
        public static void Print()
        {
            Northwind db = Northwind.GetDataBase();

            IQueryable<Customer> custs = from c in db.Customers
                        where c.City == "Rio de Janeiro"
                        select c;

            foreach (Customer customer in custs)
            {
                Console.WriteLine("{0}",customer.CompanyName);
            }


        }
    }
}
