import { IItemStrategy, ItemStrategy } from "./Items/ItemStrategy";

export class Item {
  name: string;
  sellIn: number;
  quality: number;

  constructor(name, sellIn, quality) {
    this.name = name;
    this.sellIn = sellIn;
    this.quality = quality;
  }
}

export class GildedRose {
  items: Array<Item>;
  strategy: IItemStrategy;

  constructor(items = [] as Array<Item>) {
    this.items = items;
    this.strategy = new ItemStrategy();
  }

  updateQuality() {
    for (let i = 0; i < this.items.length; i++) {
            this.items[i] = this.strategy.updateQuality(this.items[i]);        
    }
    
    return this.items;
  }
}
