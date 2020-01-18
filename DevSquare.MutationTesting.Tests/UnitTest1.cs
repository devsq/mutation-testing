using NUnit.Framework;

namespace DevSquare.MutationTesting.Tests
{
    public class WeekendDiscountTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_the_amount_is_greater_then_500_Then_the_discount_is_applied()
        {
            var totalAmount = 600m;
            var sut = new WeekendDiscount();

            var result = sut.ApplyDiscount(totalAmount);

            Assert.IsTrue(result < totalAmount);
        }
    }
}