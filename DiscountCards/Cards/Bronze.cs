namespace DiscountCards.Cards
{
    public class Bronze : ICard
    {
        private decimal turnover;

        private const double initialDiscountRate = 0;
        private const double lowDiscountRate = 1;
        private const double highDiscountRate = 2.5;

        public Bronze(string owner)
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
            if (turnover < 100)
            {
                return initialDiscountRate;
            }
            else if (turnover > 300)
            {
                return highDiscountRate;
            }
            else
            {
                return lowDiscountRate;
            }
        }
    }
}
