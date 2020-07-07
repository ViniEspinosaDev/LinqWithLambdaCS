using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestAny : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            if (orders.Any(order => order.TotalValue > 1000000))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            var oldCostumersOrders = orders.Where(order => customers.Any(customer => ValidaSeClientePossuiIdadeMaiorQueCinquenta(order, customer)));

            foreach (var order in oldCostumersOrders)
            {
                Console.WriteLine("CustomerId: " + order.CustomerId + " Value: " + order.TotalValue.ToString("c2"));
            }

        }

        private bool ValidaSeClientePossuiIdadeMaiorQueCinquenta(Order order, Customer customer)
        {
            return customer.Id == order.CustomerId && customer.Age > 62;
        }
    }
}
