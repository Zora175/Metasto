using Terraria.ID;

using Terraria.ModLoader;

using static Terraria.ModLoader.ModContent;



namespace Metasto.Items.Placeable

{

	public class YamiumBar : ModItem

	{

		public override void SetStaticDefaults()

		{

			ItemID.Sets.SortingPriorityMaterials[item.type] = 59; 

		}



		public override void SetDefaults()

		{

			item.width = 20;

			item.height = 20;

			item.maxStack = 99;

			item.value = 750;

			item.useStyle = 1;

			item.useTurn = true;

			item.useAnimation = 15;

			item.useTime = 10;

			item.autoReuse = true;

			item.consumable = true;

			item.createTile = TileType<Materials.YamiumBar>();

			item.placeStyle = 0;

		}




		

	}

}