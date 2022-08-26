namespace GildedRoseKata.Model
{
    internal class StandardItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            item.Quality -= item.GetDegradeSpeedBySellIn();

        }
    }
}