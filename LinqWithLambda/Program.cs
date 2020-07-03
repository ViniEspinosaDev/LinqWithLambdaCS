using LinqWithLambda.Tests;
using System;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest customersTest = new TestFirst();
            customersTest.Test();

            Console.Read();
        }
    }
}
