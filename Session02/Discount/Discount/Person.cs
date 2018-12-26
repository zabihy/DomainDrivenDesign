using System;
using System.Collections.Generic;
using System.Text;

namespace Discount
{
    public class Person
    {
        private readonly ICalculateDiscount _discount;

        public Person(ICalculateDiscount discount)
        {
            _discount = discount;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int Discount()
        {
            return _discount.CalculateDiscount();
        }
    }
}
