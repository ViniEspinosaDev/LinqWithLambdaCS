using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestAll : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            // Analisa tudo que está na lista e retorna SE todos elementos da lista estão de acordo com a condição atribuida
            var areAllCustomersWithIdGreaterThanZero = customers.All(customer => customer.Id > 0);

            
        }
    }
}
