using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestLast : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var lastCustomer = customers.Last();
            Console.WriteLine(lastCustomer.Name);

            var lastOrDefaultCustomer = customers.LastOrDefault();
            Console.WriteLine(lastOrDefaultCustomer.Name);

            var lastCustomerLam = customers.Last(customer => customer.Id == 45);
            Console.WriteLine(lastCustomerLam.Name);

            var lastestCustomers = customers.Last(customer => customer.Id > 45);
            Console.WriteLine(lastestCustomers.Name);

        }
    }
}
