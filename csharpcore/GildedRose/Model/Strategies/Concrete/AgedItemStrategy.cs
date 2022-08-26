namespace GildedRoseKata.Model
{
    public class AgedItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            var degradeSpeed = item.GetDegradeSpeedBySellIn();
            item.Quality += degradeSpeed;
        }

    }
}
