using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nwind;

namespace Chapter1.Listings
{
    public static class UsingDataContextLogObject
    {
        public static void Print()
        {
            Northwind db = Northwind.GetDataBase();
            db.Log = Console.Out;

            IQueryable<Order> orders = (from c in db.Customers
                                       from o in db.Orders
                                       where c.Country == "USA" && c.Region == "WA"
                                       select o).Take(10);

            foreach (Order order in orders)
            {
                Console.WriteLine("{0} - {1} - {2}",order.OrderDate,order.OrderID,order.ShipName);
            }

        }
    }
}
