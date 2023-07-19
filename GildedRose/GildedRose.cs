using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
	public class GildedRose
	{
		public const string AgedBrie = "Aged Brie";
		public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
		public const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";


		List<Item> Items;

		public Item this[string name] => Items.Find(i => i.Name == name);
		public Item this[int index] => Items[index];

		public GildedRose(List<Item> Items)
		{
			this.Items = Items;
		}


		public void UpdateQuality(int days)
		{
			for (int i = 0; i < days; i++)
				UpdateQuality();
		}

		public void UpdateQuality()
		{
			foreach (Item item in Items)
			{
				if (item.Name is Sulfuras)
					continue; // Don't update quality or sell in

				item.SellIn--;

				int normalQualityChange = (item.SellIn >= 0) ? 1 : 2;
				int conjuredCoeficient = (item.Name.ToLower().Contains("conjured")) ? 2 : 1;

				item.Quality = item.Name switch
				{
					BackstagePasses => item.SellIn switch
					{
						< 0 => 0,
						< 5 => item.Quality + 3,
						< 10 => item.Quality + 2,
						_ => item.Quality + 1
					},
					AgedBrie => item.Quality + normalQualityChange,
					_ => item.Quality - (normalQualityChange * conjuredCoeficient),
				};

				item.Quality = Math.Clamp(item.Quality, 0, 50);
			}
		}
	}
}
