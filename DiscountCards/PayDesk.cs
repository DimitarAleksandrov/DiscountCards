namespace DiscountCards
{
    using Cards;
    using System;
    using System.Text;

    public class PayDesk
    {
        public static ICard CreateCart(string owner, CardTypes cardType)
        {
            if (cardType == CardTypes.GOLD)
            {
                return new Gold(owner);
            }
            else if (cardType == CardTypes.SILVER)
            {
                return new Silver(owner);
            }
            else if (cardType == CardTypes.BRONZE)
            {
                return new Bronze(owner);
            }
            throw new ArgumentException("Please enter one of this three different types of discount cards: gold, silver or bronze!");
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
