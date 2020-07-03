namespace DiscountCards
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var owner = string.Empty;
            var cardType = string.Empty;
            var turnover = 0.0m;
            var purchaseValue = 0.0;

            try
            {
                Console.WriteLine("Please enter client name.");
                owner = Console.ReadLine();

                Console.WriteLine("Please enter one of this three different types of discount cards: gold, silver or bronze!");
                var inputCardType = Console.ReadLine().ToUpper();
                cardType = GetCardType(inputCardType);

                Console.WriteLine("Please enter turnower.");
                turnover = decimal.Parse(Console.ReadLine());
                if (turnover < 0)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("Please enter purchase value.");
                purchaseValue = double.Parse(Console.ReadLine());
                if (purchaseValue < 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (AggregateException)
            {
                Console.WriteLine("Please enter valid information");
                throw;
            }
            var card = PayDesk.CreateCart(owner, cardType);
            var textToPrind = PayDesk.calculateResultToPrint(turnover, purchaseValue, card);
            Console.WriteLine(textToPrind);
        }

        private static string GetCardType(string name)
        {
            foreach (var type in new CardTypes().GetAllTypes)
            {
                if (type.Equals(name))
                {
                    return type;
                }
            }
            
            throw new ArgumentException("Please enter one of this three different types of discount cards: gold, silver or bronze!");
        }
    }
}
