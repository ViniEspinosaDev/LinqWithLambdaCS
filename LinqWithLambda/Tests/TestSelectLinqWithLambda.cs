﻿using System;
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

            // Consulta em Linq with Lambda para retornar o nome do customer e o id do customer
            var nameAndIdlinqWithLambdaQuery = customers
                                                //.Select(customer => new { customer.Id, customer.Name });
                                                .Select(customer => new { Description = "Id: " + customer.Id + " Name: " + customer.Name });

            foreach (var customer in nameAndIdlinqWithLambdaQuery)
            {
                Console.WriteLine(customer.Description);
            }
        }
    }
}
