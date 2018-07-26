using System;
using System.Collections.Generic;
using System.Text;

namespace Discount
{
    public interface ICalculateDiscount
    {
        int CalculateDiscount();
    }

    public class CalcluateDiscountGold : ICalculateDiscount
    {
        public int CalculateDiscount()
        {
            return 1;
        }
    }

    public class CalculateDiscountSilver : ICalculateDiscount
    {
        public int CalculateDiscount()
        {
            return 2;
        }
    }

    public class CalcuateDiscountBoronz : ICalculateDiscount
    {
        public int CalculateDiscount()
        {
            return 3;
        }
    }
}
