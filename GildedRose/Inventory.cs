using System.Collections.Generic;

namespace GildedRose
{
    class Inventory
    {
        private readonly IEnumerable<Item> items;

        public Inventory(IEnumerable<Item> items)
        {
            this.items = items;
        }

        /// <summary>
        /// Items:
        /// "+5 Dexterity Vest"
        /// "Aged Brie"
        /// "Elixir of the Mongoose"
        /// "Sulfuras, Hand of Ragnaros"
        /// "Backstage passes to a TAFKAL80ETC concert"
        /// "Conjured Mana Cake"
        /// </summary>
        public void UpdateQuality()
        {
            // TODO ...
            // Hint: Iterate through this.items and check Name property to access specific item
            foreach(var item in items)
            {
                item.SellIn--;                                              
                if(item.Name == "Conjured Mana Cake")
                {
                    item.Quality -=2;
                    if (item.SellIn < 0)
                    {
                        item.Quality -= 2;
                    }
                }
                if (item.Name == "Aged Brie")
                {

                    if (item.SellIn <= 0)
                    {
                        item.Quality +=2;
                    }
                    else
                        item.Quality++;
                }
                if (item.Name == "+5 Dexterity Vest")
                {
                    if (item.SellIn < 0)
                    {
                        item.Quality -= 2;
                    }
                    else item.Quality--;
                }
                if (item.Name == "Elixir of the Mongoose")
                {                    
                    
                    if (item.SellIn < 0)
                    {
                        item.Quality -= 2;
                    }
                    else item.Quality--;
                }
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    
                    
                    if (item.SellIn <= 10 && item.SellIn >= 5)                   
                    item.Quality+=2;
                    else if(item.SellIn <= 5 && item.SellIn > 0)
                    item.Quality += 3;
                    else if (item.SellIn <= 0)
                    item.Quality = 0;
                    else
                    item.Quality++;
                }
                if (item.Quality <= 0)
                {
                    item.Quality = 0;
                }
                if (item.Quality >= 50)
                {
                    item.Quality = 50;
                }
                if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn = 0;
                    item.Quality = 80;
                }
            }
        }
    }
}
