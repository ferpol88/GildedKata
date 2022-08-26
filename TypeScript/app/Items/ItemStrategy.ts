import { Item } from "@/gilded-rose";

export interface IItemStrategy{
    updateQuality: (item:Item) => Item;

}

export class ItemStrategy implements IItemStrategy{
    //strategys: Array<IItemStrategy>;
  
    constructor() {
      //initialize();
    }
  
    updateQuality(item:Item):Item {

      switch (item.name){
        case 'Sulfuras, Hand of Ragnaros':
            return item;
        case 'Aged Brie':
            item.sellIn--;
            if(item.sellIn>0) item.quality++
            else item.quality+=2;
            break;
        case 'Backstage passes to a TAFKAL80ETC concert':
            item.sellIn--;
            if(item.sellIn>0 && item.sellIn<=5) item.quality+=3;
            else if(item.sellIn>5 && item.sellIn<=10) item.quality+=2;
            else if(item.sellIn<=0) item.quality=0;
            break;
        case 'Conjured Mana Cake':
            item.sellIn--;
            if(item.sellIn>0) item.quality-=2
            else item.quality-=4;
            break;
        default :
            item.sellIn--;
            if(item.sellIn>0) item.quality--
            else item.quality-=2;
            break;
      }

      if(item.quality>50) item.quality=50;
      if(item.quality<0) item.quality=0;

      return item;

    }
  }


