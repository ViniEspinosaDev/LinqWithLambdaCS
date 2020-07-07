using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestGroupBySecond : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            // Pega o resultado e pra cada customerId ele coloca dentro do campo key o valor do agrupamento (Id)
            var totalOrders = orders.GroupBy(order => order.CustomerId)
                .Select(order => // Depois de um GroupBy deve usar o Select
                new // Signifca que eu quero passar mais de um valor
                {
                    CustomerId = order.Key, // Armazena o id do cliente (customer)
                    TotalValue = order.Sum(x => x.TotalValue), // Soma os pedidos de cada cliente
                    AverageValue = order.Average(x => x.TotalValue), // Media da soma dos pedidos de cada cliente
                    CountOrders = order.Count() // Total de pedidos que o cliente tem
                });

            foreach (var order in totalOrders)
            {
                Console.WriteLine("Customer: " + order.CustomerId + " - Total value: " + order.TotalValue.ToString("c2") +
                    " - Average value: " + order.AverageValue.ToString("C2") + " - Count" + order.CountOrders);
            }
        }
    }
}
