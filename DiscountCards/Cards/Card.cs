namespace DiscountCards.Cards
{
    public abstract class Card : ICard
    {
        private decimal turnover;

        public Card(string owner)
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

        public abstract double GetDiscountRate();
    }
}
