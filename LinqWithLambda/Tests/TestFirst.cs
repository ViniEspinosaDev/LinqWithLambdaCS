using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestFirst : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var firstCustomer = customers.First();

            // SEMPRE USAR O FIRST COM CONDIÇÃO DENTRO DE UM TRY CATCH
            var firstCustomerWhoHaveTwentyYears = customers.First(customer => customer.Age > 30);
            Console.WriteLine(firstCustomerWhoHaveTwentyYears.Name + " Age: " + firstCustomerWhoHaveTwentyYears.Age);

            try
            {
                var firstCustomerLessTen = customers.First(customer => customer.Age < 10);
                Console.WriteLine(firstCustomerLessTen.Name + " Age: " + firstCustomerLessTen.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There is no customer with this condition. Less than 10 years old - {ex.Message}.");
            }

            var firstOrDefaultCustomerLessTen = customers.FirstOrDefault(customer => customer.Age < 10);
            Console.WriteLine(firstOrDefaultCustomerLessTen?.Name + " Age: " + firstOrDefaultCustomerLessTen?.Age);

        }
    }
}
