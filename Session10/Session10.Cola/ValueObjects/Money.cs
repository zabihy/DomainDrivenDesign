using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Session10.ValueObjectNewImplement;

namespace Session10.ColaStoreProject.ValueObjects
{
    public class Money : ValueObject
    {
        public Money(int credit)
        {
            this.Credit = credit;
        }
        public int Credit { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Credit;
        }

        public override string ToString()
        {
            return this.Credit.ToString();
        }
        public static bool operator <(Money money1, Money money2)
        {

            return Comparison(money1, money2) < 0;

        }

        public static bool operator >(Money money1, Money money2)
        {

            return Comparison(money1, money2) > 0;

        }

        public static bool operator <=(Money money1, Money money2)
        {

            return Comparison(money1, money2) <= 0;

        }

        public static bool operator >=(Money money1, Money money2)
        {

            return Comparison(money1, money2) >= 0;

        }

        public static Money operator -(Money money1, Money money2)
        {
            if (money1.Credit < 0)
            {
                throw new System.Exception("Low money");
            }

            if (money2.Credit < 0)
            {
                throw new System.Exception("Low money");
            }

            if (money1.Credit < money2.Credit)
            {
                throw new System.Exception("Low money");
            }

            //Contract.Requires(money1.Credit >= 0);

            //Contract.Requires(money2.Credit >= 0);

            //Contract.Requires(money1 >= money2);

            return new Money(money1.Credit - money2.Credit);
        }

        public static Money operator +(Money money1, Money money2)
        {
            //Contract.Requires(money1.Credit >= 0);

            //Contract.Requires(money2.Credit >= 0);

            if (money1.Credit < 0)
            {
                throw new System.Exception("Low money");
            }

            if (money2.Credit < 0)
            {
                throw new System.Exception("Low money");
            }

            return new Money(money1.Credit + money2.Credit);
        }

        public static int Comparison(Money money1, Money money2)
        {

            if (money1.Credit < money2.Credit)

                return -1;

            else if (money1.Credit == money2.Credit)

                return 0;

            else if (money1.Credit > money2.Credit)

                return 1;

            return 0;

        }
    }
}
