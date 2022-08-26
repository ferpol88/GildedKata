namespace GildedRoseKata.Model
{
    public class BackstageItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.SellIn <= 0) item.Quality = 0;
            else if (item.SellIn <= 5) item.Quality += 3;
            else if (item.SellIn <= 10) item.Quality += 2;
            else item.Quality++;

        }
    }
}
