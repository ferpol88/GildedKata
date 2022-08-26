using Xunit;
using System.Collections.Generic;
using GildedRoseKata.Model;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        private Dictionary<string, Item> TestCasesMap = new();

        public GildedRoseTest() {
            TestCasesMap = CreateItemsList();
        }
        [Fact]
        public void TestItemNameCreatedOk()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.SULFURAS_ON_TIME_80_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal("Sulfuras, Hand of Ragnaros", caseAux.Name);
        }

        [Fact]
        public void TestItemSulfurasUpdateQualityInTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.SULFURAS_ON_TIME_80_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux)); 
            app.UpdateQuality();
            Assert.Equal(80, caseAux.Quality);
            Assert.Equal(5, caseAux.SellIn);
        }

        [Fact]
        public void TestItemAgedBrieUpdateQualityInTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.AGED_BRIE_ON_TIME_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(21, caseAux.Quality);

        }
        [Fact]
        public void TestItemAgedBrieUpdateQualityOutOfTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.AGED_BRIE_OFF_TIME_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(22, caseAux.Quality);

        }

        [Fact]
        public void TestItemBackStageUpdateQualityInTime5Days()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.BACKSTAGE_ON_TIME_5_DAYS_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(23, caseAux.Quality);

        }
        [Fact]
        public void TestItemBackStageUpdateQualityInTime10Days()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.BACKSTAGE_ON_TIME_10_DAYS_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(22, caseAux.Quality);

        }
        [Fact]
        public void TestItemBackStageUpdateQualityOutOfTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.BACKSTAGE_OFF_TIME_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(0, caseAux.Quality);

        }
        [Fact]
        public void TestItemConjurasUpdateQualityInTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.CONJURA_ON_TIME_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(18, caseAux.Quality);

        }
        [Fact]
        public void TestItemConjurasUpdateQualityOffTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.CONJURA_OFF_TIME_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(16, caseAux.Quality);

        }

        [Fact]
        public void TestItemAgedBrieUpdateQualityOver50()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.AGED_BRIE_ON_TIME_50_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(50, caseAux.Quality);

        }

        [Fact]
        public void TestItemOtherUpdateQualityInTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.OTHER_ON_TIME_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(19, caseAux.Quality);
        }
        [Fact]
        public void TestItemOtherUpdateQualityOffTime()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.OTHER_OFF_TIME_20_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(18, caseAux.Quality);
        }
        [Fact]
        public void TestItemConjuraUpdateQualityBelow0()
        {
            var caseAux = TestCasesMap.GetValueOrDefault(TestCases.CONJURA_ON_TIME_ZERO_QUALITY);
            GildedRose app = new GildedRose(CaseToList(caseAux));
            app.UpdateQuality();
            Assert.Equal(0, caseAux.Quality);
        }
        public Dictionary<string, Item> CreateItemsList()
        {
           return new Dictionary<string, Item>
            {
                { TestCases.AGED_BRIE_OFF_TIME_20_QUALITY, new Item { Name = "Aged Brie", SellIn = 0, Quality = 20 } },
                { TestCases.AGED_BRIE_ON_TIME_50_QUALITY, new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } },
                { TestCases.AGED_BRIE_ON_TIME_20_QUALITY, new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 } },
                { TestCases.BACKSTAGE_ON_TIME_10_DAYS_20_QUALITY, new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } },
                { TestCases.BACKSTAGE_OFF_TIME_20_QUALITY, new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } },
                { TestCases.BACKSTAGE_ON_TIME_5_DAYS_20_QUALITY, new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } },
                { TestCases.BACKSTAGE_ON_TIME_20_QUALITY, new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 20 } },
                { TestCases.CONJURA_OFF_TIME_20_QUALITY, new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 20 } },
                { TestCases.CONJURA_ON_TIME_20_QUALITY, new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 20 } },
                { TestCases.CONJURA_ON_TIME_ZERO_QUALITY, new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 0 } },
                { TestCases.SULFURAS_OFF_TIME_80_QUALITY, new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } },
                { TestCases.SULFURAS_ON_TIME_80_QUALITY, new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } },
                { TestCases.OTHER_ON_TIME_20_QUALITY, new Item { Name = "Cacharrin", SellIn = 10, Quality = 20 } },
                { TestCases.OTHER_OFF_TIME_20_QUALITY, new Item { Name = "Mariposa", SellIn = 0, Quality = 20 } }
            };
        }

        public List<Item> CaseToList(Item item) {
            return new List<Item> { item };
        }
    }

}
