﻿using LinqWithLambda.Model;
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

            var customerOrders = customers.Join(orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, order) => new { Customer = customer, Order = order }
                );

            foreach (var customerOrder in customerOrders)
            {
                Console.WriteLine($"The customer '{customerOrder.Customer.Name}' purchased {customerOrder.Order.TotalValue.ToString("c2")} in {customerOrder.Order.CreatedDate.ToString("dd/MM/yyyy")}");
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
