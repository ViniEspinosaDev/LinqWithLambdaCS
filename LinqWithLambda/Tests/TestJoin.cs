using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestJoin : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            // Agrupando manualmente Clientes que tem pedidos
            //foreach (var customer in customers)
            //{
            //    foreach (var order in orders)
            //    {
            //        if(customer.Id == order.CustomerId)
            //        {
            //            // Code here
            //        }
            //    }
            //}

            var customerOrders = customers.Join(orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, order) => new { Customer = customer, Order = order }
                );

            foreach (var customerOrder in customerOrders)
            {
                Console.WriteLine(customerOrder.Customer.ToString());
                Console.WriteLine(customerOrder.Order.ToString());
                Console.WriteLine("-----------------------------------------");
            }




        }
    }
}
