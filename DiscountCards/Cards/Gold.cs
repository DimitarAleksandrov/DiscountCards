namespace DiscountCards.Cards
{
    using System;

    public class Gold : Card
    {
        private double discountRate;

        private const double initialDiscountRate = 2;
        private const double upperLimitDiscountRate = 10;

        public Gold(string owner) : base(owner)
        {
            this.discountRate = initialDiscountRate;
        }

        public override double GetDiscountRate()
        {
            if (base.Turnover < 100)
            {
                return this.discountRate;
            }

            double growth = Math.Floor((double)base.Turnover / 100);
            this.discountRate += growth;

            if (this.discountRate > upperLimitDiscountRate)
            {
                this.discountRate = upperLimitDiscountRate;
            }

            return discountRate;
        }
    }
}
