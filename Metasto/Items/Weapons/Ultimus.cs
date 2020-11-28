using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;


namespace Metasto.Items.Weapons

{
	public class Ultimus : ModItem
	{
		public override void SetStaticDefaults() {

			Tooltip.SetDefault("His Ultispear was forged into a masterpiece");

		}
		public override void SetDefaults() {

			item.damage = 450;
			item.useStyle = 5;
			item.useAnimation = 16;
			item.useTime = 16;
			item.shootSpeed = 6f;
			item.knockBack = 6.5f;
   		    item.width = 66;
			item.height = 66;
			item.scale = 1f;
			item.rare = 5;
			item.value = Item.sellPrice(silver: 20);
			item.melee = true;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.autoReuse = true; 
			item.shoot = mod.ProjectileType("UltimusSpear"); 
		}



		    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            Vector2 vector2 = new Vector2(speedX, speedY).RotatedByRandom((double)MathHelper.ToRadians(7.0f));
            speedX = vector2.X;
            speedY = vector2.Y;
            Projectile.NewProjectile(position.X, position.Y, speedX * 1.6f, speedY * 1.6f, type, damage, knockBack, player.whoAmI, 0.0f, 0.0f);
          
		  return false;
        }
		
		
         public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "DemonicExtinction", 5);
            recipe.AddIngredient(null, "Ultispear", 2);
            recipe.AddTile(TileID.MythrilAnvil);

            recipe.SetResult(this);
            recipe.AddRecipe();
         }
 	}
}