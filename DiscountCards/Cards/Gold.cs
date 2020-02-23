namespace DiscountCards.Cards
{
    using System;

    public class Gold : ICard
    {
        private decimal turnover;
        private double discountRate;

        private const double initialDiscountRate = 2;
        private const double upperLimitDiscountRate = 10;

        public Gold(string owner)
        {
            this.turnover = 0;
            this.Owner = owner;
            this.discountRate = initialDiscountRate;
        }

        public string Owner { get; }

        public decimal Turnover
        {
            get => this.turnover;
            set
            {
                if (value >= 0)
                {
                    this.turnover = value;
                }
            }
        }

        public double GetDiscountRate()
        {
            if (turnover < 100)
            {
                return this.discountRate;
            }

            double growth = Math.Floor((double)turnover / 100);
            this.discountRate += growth;

            if (this.discountRate > upperLimitDiscountRate)
            {
                this.discountRate = upperLimitDiscountRate;
            }

            return discountRate;
        }
    }
}
