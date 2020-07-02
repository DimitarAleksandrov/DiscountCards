namespace DiscountCards.Cards
{
    public interface ICard 
    {
        string Owner { get; }
        decimal Turnover { get; set; }
        double GetDiscountRate();
    }
}
