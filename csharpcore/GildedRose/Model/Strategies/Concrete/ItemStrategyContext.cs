using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Model
{
    public class ItemStrategyContext : IItemStrategyContext
    {
        private Dictionary<string, IItemStrategy> _strategies = new();

        public ItemStrategyContext() {
            Initialize();
        }
        public IItemStrategy GetItemStrategy(string name)
        {
            return _strategies.TryGetValue(name, out IItemStrategy result) ? result : new StandardItemStrategy();
        }

        private void RegisterStrategy(String itemType, IItemStrategy strategy)
        {
            if (String.IsNullOrEmpty(itemType)) return;
            if (strategy is null) return;

            _strategies[itemType] = strategy;
        }

        private void Initialize() {
            RegisterStrategy("Backstage passes to a TAFKAL80ETC concert", new BackstageItemStrategy());
            RegisterStrategy("Aged Brie", new AgedItemStrategy());
            RegisterStrategy("Sulfuras, Hand of Ragnaros", new SulfurasItemStrategy());
            RegisterStrategy("Conjured Mana Cake", new ConjuredItemStrategy());
        }
    }
}
