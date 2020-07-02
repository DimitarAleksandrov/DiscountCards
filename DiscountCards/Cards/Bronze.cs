namespace DiscountCards.Cards
{
    public class Bronze : Card
    {
        private const double initialDiscountRate = 0;
        private const double lowDiscountRate = 1;
        private const double highDiscountRate = 2.5;

        public Bronze(string owner) : base(owner)
        {
        }

        public override double GetDiscountRate()
        {
            if (base.Turnover  < 100)
            {
                return initialDiscountRate;
            }
            else if (base.Turnover > 300)
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
