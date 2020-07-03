using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestTake : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var firstTenCustomers = customers.Take(10);

            foreach (var customer in firstTenCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            var takeWhile = customers.TakeWhile(customer => customer.Age > 0);

            foreach (var customer in takeWhile)
            {
                Console.WriteLine("TW " + customer.Name);
            }

        }
    }
}
