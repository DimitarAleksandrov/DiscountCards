namespace DiscountCards
{
    using Cards;
    using System;
    using System.Text;

    public class PayDesk
    {
        public static ICard CreateCart(string owner, string cardType)
        {
            switch (cardType)
            {
                case CardTypes.gold: return new Gold(owner);
                case CardTypes.silver: return new Silver(owner);
                case CardTypes.bronze: return new Bronze(owner);
                default:
                    throw new ArgumentException("Please enter one of this three different types of discount cards: gold, silver or bronze!");
            }
        }

        public static string calculateResultToPrint(decimal turnover, double purchaseValue, ICard card)
        {
            card.Turnover = turnover;

            var discountRate = card.GetDiscountRate();
            var discount = purchaseValue * discountRate / 100;
            var total = purchaseValue - discount;

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Purchase value: ${purchaseValue:f2}");
            builder.AppendLine($"Discount rate: {discountRate:f1} %");
            builder.AppendLine($"Discount: ${discount:f2}");
            builder.AppendLine($"Total: ${total:f2}");

            return builder.ToString();
        }

    }
}
