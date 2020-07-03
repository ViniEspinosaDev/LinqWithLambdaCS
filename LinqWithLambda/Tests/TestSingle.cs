using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestSingle : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var customerWithAge = customers.SingleOrDefault(customer => customer.Age == 13);

            if (customerWithAge != null)
                Console.WriteLine("Id: " + customerWithAge.Id + " Name: " + customerWithAge.Name + " Age: " + customerWithAge.Age);
            else
                Console.WriteLine("Customer is null!");
        }
    }
}
