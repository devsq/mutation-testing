namespace DevSquare.MutationTesting
{
    public class Discount
    {
        private const decimal DiscountPercentage = 0.1m;

        public decimal ApplyDiscount(decimal total)
        {
            var totalWithDiscount = total;

            if (total >= 500)
            {
                totalWithDiscount = totalWithDiscount - (totalWithDiscount * DiscountPercentage);
            }

            return totalWithDiscount;
        }
    }
}
