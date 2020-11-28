using Terraria.ID;
using Terraria.ModLoader;
using Metasto.Items;

namespace Metasto.Items.Weapons
{
    public class Zasume : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Zasume"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Used by the death himself, this scythe judges fate.");
        }

        public override void SetDefaults()
        {
            item.damage = 80;
            item.melee = true;
            item.width = 124;
            item.height = 129;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = ItemRarityID.Cyan;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("ZasumeP"); //
            item.shootSpeed = 4f;  // 
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}