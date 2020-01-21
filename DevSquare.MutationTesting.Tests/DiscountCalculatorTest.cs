using NUnit.Framework;

namespace DevSquare.MutationTesting.Tests
{
    [TestFixture]
    public class DiscountCalculatorTest
    {
        [Test]
        public void When_the_amount_is_greater_than_500_Then_the_discount_is_applied()
        {
            const decimal totalAmount = 600m;

            var sut = new DiscountCalculator();

            var result = sut.ApplyDiscount(totalAmount);

            Assert.IsTrue(result < totalAmount);
        }
    }
}