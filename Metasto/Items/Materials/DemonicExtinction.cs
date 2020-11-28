using Terraria.ID;
using Terraria.ModLoader;


namespace Metasto.Items.Materials

{

    public class DemonicExtinction : ModItem

    {

        public override void SetStaticDefaults()

        {
            // DisplayName.SetDefault("DemonicExtinction"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("What they used to make those horrific weapons");

        }



        public override void SetDefaults()

        {

            item.width = 24;

            item.height = 24;

            item.maxStack = 99;

            item.useTurn = true;

            item.autoReuse = true;

            item.useAnimation = 15;

            item.useTime = 10;

            item.useStyle = 1;

            item.value = 0;
			
		    item.rare = ItemRarityID.Purple;

        }

        public override void AddRecipes()

        {
                ModRecipe recipe = new ModRecipe(mod);

           
            recipe.AddIngredient(ItemID.LivingDemonFireBlock, 50);
            recipe.AddIngredient(ItemID.DemonHeart, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }   
}








