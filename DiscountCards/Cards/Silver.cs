namespace DiscountCards.Cards
{
    public class Silver : ICard
    {
        private decimal turnover;

        private const double initialDiscountRate = 2.0;
        private const double increasedDiscountRate = 3.5;

        public Silver(string owner)
        {
            this.turnover = 0;
            this.Owner = owner;
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
            if (this.turnover > 300)
            {
                return increasedDiscountRate;
            }
            else
            {
                return initialDiscountRate;
            }
        }
    }
}
