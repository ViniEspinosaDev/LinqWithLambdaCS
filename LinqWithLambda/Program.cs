using LinqWithLambda.Tests;
using System;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest customersTest = new TestSelectLinqWithLambda();
            customersTest.Test();

            Console.Read();
        }
    }
}
