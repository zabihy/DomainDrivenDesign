using System.Collections.Generic;
using Session10.ValueObjectNewImplement;

namespace Session10.ColaStoreProject.ValueObjects
{
    public class Cola : ValueObject
    {
        public Cola(Money price, ColaType colaType)
        {
            this.ColaType = colaType;
            this.Price = price;
        }
        public ColaType ColaType { get; private set; }
        public Money Price { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return ColaType;
            yield return Price;
        }
    }

    public enum ColaType
    {
        Limon,
        Orang,
        Black,
        None
    }
}
