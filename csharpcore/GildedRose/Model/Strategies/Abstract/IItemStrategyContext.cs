namespace GildedRoseKata.Model
{
    public interface IItemStrategyContext
    {
        IItemStrategy GetItemStrategy(string name);
    }
}