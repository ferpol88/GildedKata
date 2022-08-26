import { Item, GildedRose } from '@/gilded-rose';

describe('Gilded Rose', () => {
  describe('Quality Updates', () => {
    it('should foo', () => {
      const gildedRose = new GildedRose([new Item('foo', 0, 0)]);
      const items = gildedRose.updateQuality();
      expect(items[0].name).toBe('foo');
    });

    it('When item is Sulfuras, attributes should not be modified', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Sulfuras, Hand of Ragnaros', 0, 80)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].sellIn).toBe(0);
      expect(items[0].quality).toBe(80);
    });

    it('When item is other than Sulfuras, Sellin should be decreased in 1', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Aged Brie', 10, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].sellIn).toBe(9);
    });

    it('When item is AgedBrie and sellIn is in time, Quality should be increased in 1', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Aged Brie', 10, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(21);
    });


    it('When item is AgedBrie and sellIn is out of time, Quality should be increased in 2', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Aged Brie', 0, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(22);
    });

    it('When item is AgedBrie and Quality is over 50, Quality should be 50', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Aged Brie', 0, 50)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(50);
    });

    it('When item is Backstage and sellIn is 5, Quality should be increased in 3', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Backstage passes to a TAFKAL80ETC concert', 5, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(23);
    });

    it('When item is Backstage and sellIn is 10, Quality should be increased in 2', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Backstage passes to a TAFKAL80ETC concert', 10, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(22);
    });

    it('When item is Backstage and sellIn is 0, Quality should be 0', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Backstage passes to a TAFKAL80ETC concert', 0, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(0);
    });

    it('When item is Conjuras and sellIn is in time, Quality should be decreased in 2', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Conjured Mana Cake', 10, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(18);
    });

    it('When item is Conjuras and sellIn is out of time, Quality should be decreased in 4', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Conjured Mana Cake', 0, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(16);
    });

    it('When item is Conjuras and Quality is 0, Quality should be 0', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Conjured Mana Cake', 0, 0)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(0);
    });

    it('When item is Other and sellIn is in of time, Quality should be decreased in 1', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Other Item v1', 10, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(19);
    });

    it('When item is Other and sellIn is out of time, Quality should be decreased in 2', () => {
      //Arrange
      const gildedRose = new GildedRose([new Item('Other Item v2', 0, 20)]);

      //Act
      const items = gildedRose.updateQuality();

      //Assert
      expect(items[0].quality).toBe(18);
    });

  });
});
