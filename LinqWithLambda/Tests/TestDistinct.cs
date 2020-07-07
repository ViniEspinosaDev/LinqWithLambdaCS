using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestDistinct : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            var customerIds = orders.Select(order => order.CustomerId).Distinct();
        }
    }
}
