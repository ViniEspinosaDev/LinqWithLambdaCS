using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestSelectLinq : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            // Consulta em Linq para retornar apenas o nome do customer
            Console.WriteLine("\n|| Teste - Retorna apenas Name de cada customer ||\n");
            var nameQueryCustomers = from customer in customers
                                     select customer.Name;

            foreach (var customer in nameQueryCustomers)
            {
                Console.WriteLine(customer);
            }

            // Consulta em Linq para retornar o nome do customer e o id do customer
            Console.WriteLine("\n|| Teste - Retorna Id e Name de cada customer ||\n");
            var nameAndIdQueryCustomers = from customer in customers
                                          select new { customer.Id, NameCustomer = customer.Name };

            foreach (var customer in nameAndIdQueryCustomers)
            {
                Console.WriteLine($"{customer.Id} - {customer.NameCustomer}");
            }
        }
    }
}
