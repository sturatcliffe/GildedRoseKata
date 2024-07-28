namespace GildedRoseKata
{
    public abstract class AbstractBaseItem(Item item)
    {
        private readonly Item _item = item;

        public static AbstractBaseItem Create(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrieItem(item),
                "Sulfuras, Hand of Ragnaros" => new SulfurasItem(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassItem(item),
                "Conjured Mana Cake" => new ConjuredItem(item),
                _ => new StandardItem(item),
            };
        }

        public string Name
        {
            get
            {
                return _item.Name;
            }
            set
            {
                _item.Name = value;
            }
        }

        public int Quality
        {
            get
            {
                return _item.Quality;
            }
            set
            {
                _item.Quality = value;
            }
        }

        public int SellIn
        {
            get
            {
                return _item.SellIn;
            }
            set
            {
                _item.SellIn = value;
            }
        }

        public abstract void UpdateQuality();
    }
}
