namespace DevSquare.MutationTesting
{
    public class DiscountCalculator
    {
        private const decimal Discount = 0.1m;

        public decimal ApplyDiscount(decimal total)
        {
            var totalWithDiscount = total;

            if (total > 500)
            {
                totalWithDiscount = totalWithDiscount - (totalWithDiscount * Discount);
            }

            return totalWithDiscount;
        }
    }
}
