using Terraria.ID;
using Terraria.ModLoader;
using Metasto.Items;

namespace Metasto.Items.Weapons
{
    public class YamiumBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            
            Tooltip.SetDefault("Made out of demonic matter, this sword shall guarantee victory.");
			
        }

        public override void SetDefaults()
        {
            item.damage = 666;
            item.melee = true;
            item.width = 100;
            item.height = 120;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 1;
            item.knockBack = 12;
            item.value = 10000;
            item.rare = ItemRarityID.Cyan;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("YamiumBladePro"); //
            item.shootSpeed = 12f;  // 
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "DemonicExtinction", 10);
            recipe.AddTile(TileID.LunarCraftingStation);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}