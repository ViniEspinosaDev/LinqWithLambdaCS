using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace LinqWithLambda.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Decimal TotalValue { get; set; }

        public override string ToString()
        {
            return "Id: " + this.Id.ToString() + " || CustomerId: " + this.CustomerId.ToString() + " || CreatedDate: " + this.CreatedDate.ToString("dd/MM/yyyy") + " || Total Value: " + this.TotalValue.ToString();
        }
    }
}
