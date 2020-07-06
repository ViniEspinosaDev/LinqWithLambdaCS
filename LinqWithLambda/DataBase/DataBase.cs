using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.DataBase
{
    public static class DataBase
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            for (int index = 0; index <= 50; index++)
            {
                var customer = new Customer();

                customer.Id = index;
                customer.Name = $"Customer {index}";
                customer.Age = 18 + index;

                customers.Add(customer);
            }

            return customers;
        }

        public static List<Order> GetOrders()
        {
            var orders = new List<Order>();

            var customerId = 0;

            for (int index = 0; index <= 1000; index++)
            {
                var order = new Order();

                if (customerId > 50)
                    customerId = 0;

                order.Id = index;
                order.CustomerId = customerId;
                order.CreatedDate = DateTime.Now;
                order.TotalValue = 5 * index + 5;

                orders.Add(order);

                customerId++;
            }

            return orders;
        }

    }
}
