using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestWhere : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            // Pega os customers com idade maior que 40
            var ageCustomers = customers.Where(customer => ValidaIdadeCliente(customer));

            foreach (var customer in ageCustomers)
            {
                Console.WriteLine(customer.Name + " Age: " + customer.Age);
            }
        }

        private bool ValidaIdadeCliente(Customer customer)
        {
            return customer.Age > 40 && customer.Age < 51;
        }

    }
}
