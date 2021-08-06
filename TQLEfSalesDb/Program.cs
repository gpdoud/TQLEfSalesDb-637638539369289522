using System;
using System.Linq;

using TQLEfSalesDb.Models;

namespace TQLEfSalesDb {

    class Program {

        static void Main(string[] args) {

            var context = new SalesdbContext();

            var customers = context.Customers.ToList();

            var customer = context.Customers.Find(1);

            var customersInCincinnati = context.Customers
                                .Where(c => c.City == "Cincinnati")
                                .ToList();

            var newCustomer = new Customer() {
                Name = "TQL", City = "Cincinnati", State = "OH",
                Sales = 4000000, Active = true
            };
            //context.Customers.Add(newCustomer);
            //var rowsAffected = context.SaveChanges();

            //var tql = context.Customers.Find(43);
            //tql.Name = "Total Quality Logistics";
            //var rowsAffected = context.SaveChanges();

            //tql = context.Customers.Find(43);
            //context.Customers.Remove(tql);
            //rowsAffected = context.SaveChanges();

            var orders = context.Orders.ToList();


        }
    }
}
