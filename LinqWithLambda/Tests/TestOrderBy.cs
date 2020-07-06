using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestOrderBy : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            var customerOrders = customers.Join(orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, order) => new
                {
                    CustomerId = customer.Id,
                    Name = customer.Name,
                    Age = customer.Age,
                    TotalValue = order.TotalValue,
                    CreatedDate = order.CreatedDate
                });

            foreach (var customerOrder in customerOrders.OrderBy(customer => customer.Name).ThenByDescending(Order => Order.TotalValue))
            {
                Console.WriteLine(customerOrder.Name + " - purchased: " + customerOrder.TotalValue.ToString("c2"));
            }

        }
    }
}
