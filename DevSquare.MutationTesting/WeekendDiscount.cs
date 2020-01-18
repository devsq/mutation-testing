using System;

namespace DevSquare.MutationTesting
{
    public class WeekendDiscount
    {
        private const decimal Discount = 0.1m;

        public decimal ApplyDiscount(decimal total)
        {
            var totalWithDiscount = total;
            if( total > 500)
            {
                totalWithDiscount = totalWithDiscount - (totalWithDiscount * Discount);
            }

            return totalWithDiscount;
        }
    }
}
