using System;
using System.Linq;
using Common;
using nwind;

namespace Chapter1.Listings
{
    public class SimpleDbQueryUsingLinqToSql : IListing
    {
        public void Print()
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
