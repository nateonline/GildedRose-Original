using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using static GildedRoseKata.GildedRose;

namespace GildedRoseTests
{
	public class GildedRoseTest
	{
		#region Normal Item

		const string NormalItemName = "Normal Item";

		[Fact]
		public void NormalItem_BeforeSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(NormalItemName, 20, 15)
			});

			shop.UpdateQuality(1);

			Assert.Equal(19, shop[0].SellIn);
			Assert.Equal(14, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(16, shop[0].SellIn);
			Assert.Equal(11, shop[0].Quality);

			shop.UpdateQuality(15);

			Assert.Equal(1, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);
		}

		[Fact]
		public void NormalItem_PastSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(NormalItemName, -1, 18)
			});

			shop.UpdateQuality(1);

			Assert.Equal(-2, shop[0].SellIn);
			Assert.Equal(16, shop[0].Quality);

			shop.UpdateQuality(7);

			Assert.Equal(-9, shop[0].SellIn);
			Assert.Equal(2, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(-12, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);
		}

		[Fact]
		public void NormalItem_AcrossSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(NormalItemName, 5, 20)
			});

			shop.UpdateQuality(1);

			Assert.Equal(4, shop[0].SellIn);
			Assert.Equal(19, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(1, shop[0].SellIn);
			Assert.Equal(16, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(-2, shop[0].SellIn);
			Assert.Equal(11, shop[0].Quality);
		}

		#endregion


		#region Aged Brie

		[Fact]
		public void AgedBrie_BeforeSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(AgedBrie, 20, 35)
			});

			shop.UpdateQuality(1);

			Assert.Equal(19, shop[0].SellIn);
			Assert.Equal(36, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(16, shop[0].SellIn);
			Assert.Equal(39, shop[0].Quality);

			shop.UpdateQuality(13);

			Assert.Equal(3, shop[0].SellIn);
			Assert.Equal(50, shop[0].Quality);
		}

		[Fact]
		public void AgedBrie_PastSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(AgedBrie, -1, 18)
			});

			shop.UpdateQuality(1);

			Assert.Equal(-2, shop[0].SellIn);
			Assert.Equal(20, shop[0].Quality);

			shop.UpdateQuality(7);

			Assert.Equal(-9, shop[0].SellIn);
			Assert.Equal(34, shop[0].Quality);

			shop.UpdateQuality(20);

			Assert.Equal(-29, shop[0].SellIn);
			Assert.Equal(50, shop[0].Quality);
		}

		[Fact]
		public void AgedBrie_AcrossSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(AgedBrie, 5, 5)
			});

			shop.UpdateQuality(1);

			Assert.Equal(4, shop[0].SellIn);
			Assert.Equal(6, shop[0].Quality);

			shop.UpdateQuality(7);

			Assert.Equal(-3, shop[0].SellIn);
			Assert.Equal(16, shop[0].Quality);

			shop.UpdateQuality(2);

			Assert.Equal(-5, shop[0].SellIn);
			Assert.Equal(20, shop[0].Quality);
		}

		#endregion


		#region Sulfuras

		[Fact]
		public void Sulfuras_BeforeSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(Sulfuras, 250, 80)
			});

			shop.UpdateQuality(1);

			Assert.Equal(250, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);

			shop.UpdateQuality(100);

			Assert.Equal(250, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);

			shop.UpdateQuality(140);

			Assert.Equal(250, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);
		}

		[Fact]
		public void Sulfuras_PastSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(Sulfuras, -1337, 80)
			});

			shop.UpdateQuality(1);

			Assert.Equal(-1337, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);

			shop.UpdateQuality(7);

			Assert.Equal(-1337, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);

			shop.UpdateQuality(20);

			Assert.Equal(-1337, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);
		}

		[Fact]
		public void Sulfuras_AcrossSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(Sulfuras, 5, 80)
			});

			shop.UpdateQuality(1);

			Assert.Equal(5, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);

			shop.UpdateQuality(7);

			Assert.Equal(5, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);

			shop.UpdateQuality(2);

			Assert.Equal(5, shop[0].SellIn);
			Assert.Equal(80, shop[0].Quality);
		}

		#endregion


		#region Backstage Passes

		[Fact]
		public void BackstagePasses_BeforeSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(BackstagePasses, 15, 1)
			});

			shop.UpdateQuality(1);

			Assert.Equal(14, shop[0].SellIn);
			Assert.Equal(2, shop[0].Quality);

			shop.UpdateQuality(7);

			Assert.Equal(7, shop[0].SellIn);
			Assert.Equal(12, shop[0].Quality);

			shop.UpdateQuality(4);

			Assert.Equal(3, shop[0].SellIn);
			Assert.Equal(22, shop[0].Quality);
		}

		[Fact]
		public void BackstagePasses_PastSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(BackstagePasses, -1, 40)
			});

			shop.UpdateQuality(1);

			Assert.Equal(-2, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);

			shop.UpdateQuality(7);

			Assert.Equal(-9, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);

			shop.UpdateQuality(4444);

			Assert.Equal(-4453, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);
		}

		[Fact]
		public void BackstagePasses_AcrossSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(BackstagePasses, 6, 10)
			});

			shop.UpdateQuality(1);

			Assert.Equal(5, shop[0].SellIn);
			Assert.Equal(12, shop[0].Quality);

			shop.UpdateQuality(2);

			Assert.Equal(3, shop[0].SellIn);
			Assert.Equal(18, shop[0].Quality);

			shop.UpdateQuality(5);

			Assert.Equal(-2, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);
		}

		#endregion


		#region Conjured Items

		const string ConjuredItemName = "Normal Item";

		[Fact]
		public void ConjuredItem_BeforeSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(ConjuredItemName, 20, 15)
			});

			shop.UpdateQuality(1);

			Assert.Equal(19, shop[0].SellIn);
			Assert.Equal(13, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(16, shop[0].SellIn);
			Assert.Equal(7, shop[0].Quality);

			shop.UpdateQuality(15);

			Assert.Equal(1, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);
		}

		[Fact]
		public void ConjuredItem_PastSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(ConjuredItemName, -1, 18)
			});

			shop.UpdateQuality(1);

			Assert.Equal(-2, shop[0].SellIn);
			Assert.Equal(14, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(-5, shop[0].SellIn);
			Assert.Equal(2, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(-12, shop[0].SellIn);
			Assert.Equal(0, shop[0].Quality);
		}

		[Fact]
		public void ConjuredItem_AcrossSellIn()
		{
			GildedRose shop = new GildedRose(new List<Item>
			{
				new Item(ConjuredItemName, 5, 20)
			});

			shop.UpdateQuality(1);

			Assert.Equal(4, shop[0].SellIn);
			Assert.Equal(18, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(1, shop[0].SellIn);
			Assert.Equal(12, shop[0].Quality);

			shop.UpdateQuality(3);

			Assert.Equal(-2, shop[0].SellIn);
			Assert.Equal(6, shop[0].Quality);
		}

		#endregion


		#region Item Hoard

		[Fact]
		public void ItemHoard_ConstantOrder()
		{
			GildedRose shop = new GildedRose(new List<Item>()
			{
				new Item("Normal Item A", 10, 10),
				new Item("Normal Item B", -5, 40),
				new Item("Normal Item C", 0, 0),
				new Item("Normal Item D", 20, 0),
				new Item(Sulfuras, 1, 80),
				new Item(AgedBrie, -10, 0),
				new Item(BackstagePasses, 13, 38),
				new Item("Conjured Item A", 10, 10),
				new Item("Conjured Item B", -5, 40),
				new Item("Conjured Item C", 0, 0),
				new Item("Conjured Item D", 20, 0),
			});

			shop.UpdateQuality(1);

			Assert.Equal(9, shop["Normal Item A"].Quality);
			Assert.Equal(38, shop["Normal Item B"].Quality);
			Assert.Equal(0, shop["Normal Item C"].Quality);
			Assert.Equal(0, shop["Normal Item D"].Quality);
			Assert.Equal(80, shop[Sulfuras].Quality);
			Assert.Equal(2, shop[AgedBrie].Quality);
			Assert.Equal(39, shop[BackstagePasses].Quality);
			Assert.Equal(8, shop["Conjured Item A"].Quality);
			Assert.Equal(36, shop["Conjured Item B"].Quality);
			Assert.Equal(0, shop["Conjured Item C"].Quality);
			Assert.Equal(0, shop["Conjured Item D"].Quality);

			shop.UpdateQuality(4);

			Assert.Equal(5, shop["Normal Item A"].Quality);
			Assert.Equal(30, shop["Normal Item B"].Quality);
			Assert.Equal(0, shop["Normal Item C"].Quality);
			Assert.Equal(0, shop["Normal Item D"].Quality);
			Assert.Equal(80, shop[Sulfuras].Quality);
			Assert.Equal(10, shop[AgedBrie].Quality);
			Assert.Equal(45, shop[BackstagePasses].Quality);
			Assert.Equal(1, shop["Conjured Item A"].Quality);
			Assert.Equal(22, shop["Conjured Item B"].Quality);
			Assert.Equal(0, shop["Conjured Item C"].Quality);
			Assert.Equal(0, shop["Conjured Item D"].Quality);

			shop.UpdateQuality(4);

			Assert.Equal(1, shop["Normal Item A"].Quality);
			Assert.Equal(22, shop["Normal Item B"].Quality);
			Assert.Equal(0, shop["Normal Item C"].Quality);
			Assert.Equal(0, shop["Normal Item D"].Quality);
			Assert.Equal(80, shop[Sulfuras].Quality);
			Assert.Equal(18, shop[AgedBrie].Quality);
			Assert.Equal(50, shop[BackstagePasses].Quality);
			Assert.Equal(0, shop["Normal Item A"].Quality);
			Assert.Equal(4, shop["Normal Item B"].Quality);
			Assert.Equal(0, shop["Normal Item C"].Quality);
			Assert.Equal(0, shop["Normal Item D"].Quality);
		}

		[Fact]
		public void ItemHoard_RandomOrder()
		{
			const int RandomIterations = 10000;

			for (int i = 0; i < RandomIterations; i++)
			{
				List<Item> items = new List<Item>()
				{
					new Item("Normal Item A", 10, 10),
					new Item("Normal Item B", -5, 40),
					new Item("Normal Item C", 0, 0),
					new Item("Normal Item D", 20, 0),
					new Item(Sulfuras, 1, 80),
					new Item(AgedBrie, -10, 0),
					new Item(BackstagePasses, 13, 38),
					new Item("Conjured Item A", 10, 10),
					new Item("Conjured Item B", -5, 40),
					new Item("Conjured Item C", 0, 0),
					new Item("Conjured Item D", 20, 0),
				};

				items.Shuffle();

				GildedRose shop = new GildedRose(items);

				shop.UpdateQuality(1);

				Assert.Equal(9, shop["Normal Item A"].Quality);
				Assert.Equal(38, shop["Normal Item B"].Quality);
				Assert.Equal(0, shop["Normal Item C"].Quality);
				Assert.Equal(0, shop["Normal Item D"].Quality);
				Assert.Equal(80, shop[Sulfuras].Quality);
				Assert.Equal(2, shop[AgedBrie].Quality);
				Assert.Equal(39, shop[BackstagePasses].Quality);
				Assert.Equal(8, shop["Conjured Item A"].Quality);
				Assert.Equal(36, shop["Conjured Item B"].Quality);
				Assert.Equal(0, shop["Conjured Item C"].Quality);
				Assert.Equal(0, shop["Conjured Item D"].Quality);

				shop.UpdateQuality(4);

				Assert.Equal(5, shop["Normal Item A"].Quality);
				Assert.Equal(30, shop["Normal Item B"].Quality);
				Assert.Equal(0, shop["Normal Item C"].Quality);
				Assert.Equal(0, shop["Normal Item D"].Quality);
				Assert.Equal(80, shop[Sulfuras].Quality);
				Assert.Equal(10, shop[AgedBrie].Quality);
				Assert.Equal(45, shop[BackstagePasses].Quality);
				Assert.Equal(1, shop["Conjured Item A"].Quality);
				Assert.Equal(22, shop["Conjured Item B"].Quality);
				Assert.Equal(0, shop["Conjured Item C"].Quality);
				Assert.Equal(0, shop["Conjured Item D"].Quality);

				shop.UpdateQuality(4);

				Assert.Equal(1, shop["Normal Item A"].Quality);
				Assert.Equal(22, shop["Normal Item B"].Quality);
				Assert.Equal(0, shop["Normal Item C"].Quality);
				Assert.Equal(0, shop["Normal Item D"].Quality);
				Assert.Equal(80, shop[Sulfuras].Quality);
				Assert.Equal(18, shop[AgedBrie].Quality);
				Assert.Equal(50, shop[BackstagePasses].Quality);
				Assert.Equal(0, shop["Normal Item A"].Quality);
				Assert.Equal(4, shop["Normal Item B"].Quality);
				Assert.Equal(0, shop["Normal Item C"].Quality);
				Assert.Equal(0, shop["Normal Item D"].Quality);
			}
		}

		#endregion
	}

	public static class TestHelpers
	{
		public static void Shuffle<T>(this IList<T> list)
		{
			System.Random rng = new();

			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
	}
}
