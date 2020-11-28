   

using Metasto.Projectiles;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;

using static Terraria.ModLoader.ModContent;

namespace Metasto.Items.Weapons

{
	public class Ultispear : ModItem
	{
		public override void SetStaticDefaults() {

			Tooltip.SetDefault("One said it was made by a dark slime");

		}
		public override void SetDefaults() {

			item.damage = 80;

			item.useStyle = 5;

			item.useAnimation = 16;

			item.useTime = 16;

			item.shootSpeed = 3f;

			item.knockBack = 6f;
         
   		    item.width = 52;

			item.height = 52;

			item.scale = 1f;

			item.rare = 5;

			item.value = Item.sellPrice(silver: 20);

			item.melee = true;

			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.

			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.

			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()
            


			item.UseSound = SoundID.Item1;

			   item.shoot = mod.ProjectileType("Ultispearpro"); //

		}
		public override bool CanUseItem(Player player) {

			// Ensures no more than one spear can be thrown out, use this when using autoReuse

			return player.ownedProjectileCounts[item.shoot] < 1;

		}
		 public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.DemoniteBar, 20);
            recipe.AddIngredient(ItemID.ShadowScale, 15);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
         }

	}

}