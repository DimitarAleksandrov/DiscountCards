namespace DiscountCards.Cards
{
    public class Silver : Card
    {
        private const double initialDiscountRate = 2.0;
        private const double increasedDiscountRate = 3.5;

        public Silver(string owner): base(owner)
        {
        }

        public override double GetDiscountRate()
        {
            if (base.Turnover > 300)
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
