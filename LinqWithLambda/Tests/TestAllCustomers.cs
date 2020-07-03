using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestAllCustomers : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
