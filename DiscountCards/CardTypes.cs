namespace DiscountCards
{
    using System.Collections.Generic;

    public class CardTypes
    {
        public const string bronze = "BRONZE";
        public const string silver = "SILVER";
        public const string gold = "GOLD";

        public CardTypes()
        {
            this.GetAllTypes = new List<string>
            {
                bronze,
                silver,
                gold
            };
        }

        public List<string> GetAllTypes { get; }
    }
}
