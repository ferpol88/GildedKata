namespace GildedRoseKata.Model
{
    public class ConjuredItemStrategy : IItemStrategy
    {

        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            var degradeSpeed = item.GetDegradeSpeedBySellIn();

            item.Quality -= degradeSpeed * 2;

        }

    }
}
