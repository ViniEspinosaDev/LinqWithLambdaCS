using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestSkip : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var skipCustomers = customers.Skip(5);

            foreach (var customer in skipCustomers)
                Console.WriteLine("SKP: " + customer.Name);

            var skipLastCustomers = customers.SkipLast(5);
            foreach (var customer in skipLastCustomers)
                Console.WriteLine("SKPL: " + customer.Name);

            // Só pega os customers com idade maior ou igual a 25 anos
            var skipWhileCustomers = customers.SkipWhile(customers => customers.Age < 25);
            foreach (var customer in skipWhileCustomers)
                Console.WriteLine("SKPW: " + customer.Name + " Age:" + customer.Age);
        }
    }
}
