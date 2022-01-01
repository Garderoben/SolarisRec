using System;

namespace SolarisRec.Core.Deck
{
    public struct CardQuantity
    {
        private const int MAX_COUNT = 3;
        private const int MIN_COUNT = 1;

        private readonly int count;

        public CardQuantity(int count)
        {
            if (count > MAX_COUNT)
            {
                throw new ArgumentException(
                    $"Maximum allowed copies of a card is {MAX_COUNT}", 
                    nameof(count));
            }
            else if (count < MIN_COUNT)
            {
                throw new ArgumentException(
                    $"Minimum allowed copies of a card is {MIN_COUNT}", 
                    nameof(count));
            }           

            this.count = count;
        }

        public static CardQuantity FromInteger(int count) => new(count);

        public int ToInteger()
        {
            return count;
        }

        public static CardQuantity operator +(CardQuantity left, CardQuantity right)
        {
            var result = left.count + right.count;
            return FromInteger(result);
        }

        public static CardQuantity operator -(CardQuantity left, CardQuantity right)
        {
            var result = left.count - right.count;
            return FromInteger(result);
        }
    }
}