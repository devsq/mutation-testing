using NUnit.Framework;

namespace DevSquare.MutationTesting.Tests
{
    [TestFixture]
    public class DiscountTest
    {
        [Test]
        public void When_the_amount_is_greater_than_500_Then_the_discount_is_applied()
        {
            const decimal totalAmount = 600m;

            var sut = new Discount();

            var result = sut.ApplyDiscount(totalAmount);

            Assert.IsTrue(result < totalAmount);
        }

        [TestCase(500, 450)]
        [TestCase(600, 540)]
        [TestCase(499, 499)]

        public void When_the_discount_is_applyed_Then_the_expected_amount_is_returned(decimal totalAmount, decimal expectedAmount)
        {
            var sut = new Discount();

            var actualAmount = sut.ApplyDiscount(totalAmount);

            Assert.AreEqual(expectedAmount, actualAmount);
        }
    }
}