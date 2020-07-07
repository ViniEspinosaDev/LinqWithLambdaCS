using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestContains : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var customersIds = customers.Select(customer => customer.Id);

            if (customersIds.Contains(1))
            {
                Console.WriteLine("Tem um customer com id = 1");
            }
            else
            {
                Console.WriteLine("Não tem");
            }

            var customerNames = customers.Select(customer => customer.Name);

            if (customerNames.Contains("Customer 1"))
            {
                Console.WriteLine("Tem cliente com o nome 'Customer 1'.");
            }
            else
            {
                Console.WriteLine("Nao");
            }

        }
    }
}
