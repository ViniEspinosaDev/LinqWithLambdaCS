using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestSelectLinqWithLambda : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            // Consulta em Linq with Lambda para retornar apenas o nome do customer
            var nameLinqWithLambdaQuery = customers.Select(customer => customer.Name);
            Console.WriteLine("\n|| Teste Lambda - Retorna apenas Name de cada customer ||\n");

            foreach (var customer in nameLinqWithLambdaQuery)
            {
                Console.WriteLine(customer);
            }

            // Consulta em Linq with Lambda para retornar o nome do customer e o id do customer
            Console.WriteLine("\n|| Teste Lambda - Retorna Id e Name de cada customer ||\n");
            var nameAndIdlinqWithLambdaQuery = customers.Select(customer => new { customer.Id, customer.Name });

            foreach (var customer in nameAndIdlinqWithLambdaQuery)
            {
                Console.WriteLine($"{customer.Id} - {customer.Name}");
            }
        }
    }
}
