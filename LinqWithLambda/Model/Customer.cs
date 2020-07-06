using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Id: " + this.Id.ToString() + " || Name: " + this.Name.ToString() + " || Age: " + this.Age.ToString();
        }
    }
}
