using LinqWithLambda.Tests;
using System;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest customersTest = new TestJoin();
            customersTest.Test();

            Console.Read();
        }
    }
}
