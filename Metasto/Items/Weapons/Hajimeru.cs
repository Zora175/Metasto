using Terraria.ID;
using Terraria.ModLoader;
using Metasto.Items;

namespace Metasto.Items.Weapons
{
    public class Hajimeru : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("hajimeru"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("The first weapon that was created with embodiments of hell.");
        }

        public override void SetDefaults()
        
            {
                item.damage = 40;
                item.melee = true;
                item.width = 70;
                item.height = 70;
                item.useTime = 16;
                item.useAnimation = 16;
                item.useStyle = 1;
                item.knockBack = 2;
                item.value = 100;
                item.rare = ItemRarityID.Green;
                item.UseSound = SoundID.Item1;
                item.autoReuse = true;
                item.useTurn = true;
            item.shoot = mod.ProjectileType("Slash"); //
			
            item.shootSpeed = 1f;  //


        }

            public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.PlatinumBar, 10);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
         }






    }
    

}
