namespace GildedRoseKata.Model
{
    public interface IItemStrategy
    {
        public void UpdateQuality(Item item);

        public void Validate(Item item) { 
            if(item.Quality<0) item.Quality = 0;
            if(item.Quality>50) item.Quality = 50;
        }

    }
}