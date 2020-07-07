using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestUnion : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            var firstCustomer = customers.FirstOrDefault();
            var lastCustomer = customers.LastOrDefault();

            var firstCustomerOrders = orders.Where(order => order.CustomerId == firstCustomer.Id);
            var lastCustomerOrders = orders.Where(order => order.CustomerId == lastCustomer.Id);

            // Essa lista vai ter os pedidos tanto do último quanto do primeiro cliente (OBS: Listas devem ser do mesmo tipo)
            var firstAndLastCustomerOrders = firstCustomerOrders.Union(lastCustomerOrders);

            foreach (var order in firstAndLastCustomerOrders)
            {
                Console.WriteLine("Customer Id: " + order.CustomerId + " - Total Value: " + order.TotalValue.ToString("c2"));
            }

        }
    }
}
