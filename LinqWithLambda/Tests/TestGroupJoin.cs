using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestGroupJoin : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            var customerOrders = customers.GroupJoin(orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, AllOrders) => new { Customer = customer, AllOrders = AllOrders }
                );

            foreach (var customerOrder in customerOrders)
            {
                Console.WriteLine($"The customer '{customerOrder.Customer.Name}' purchased: ");

                foreach (var order in customerOrder.AllOrders)
                {
                    Console.WriteLine($"Value: {order.TotalValue.ToString("c2")} in {order.CreatedDate.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
