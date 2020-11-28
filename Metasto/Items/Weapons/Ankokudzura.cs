
using Terraria.ID;
using Terraria.ModLoader;
using Metasto.Items;

namespace Metasto.Items.Weapons
{
    public class Ankokudzura : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ankokudzura"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("You have not chosen this fate.");
        }

        public override void SetDefaults()
        
            {
                item.damage = 200;
                item.melee = true;
                item.width = 230;
                item.height = 240;
                item.useTime = 10;
                item.useAnimation = 10;
                item.useStyle = 1;
                item.knockBack = 6;
                item.value = 10000;
                item.rare = ItemRarityID.Cyan;
                item.UseSound = SoundID.Item1;
                item.autoReuse = true;
                item.useTurn = true;
                
              
            
			   }
               public override void AddRecipes()
               {

               ModRecipe recipe = new ModRecipe(mod);

               recipe.AddIngredient(null, "YamiumBar", 20);
 
            

               recipe.AddTile(16);

               recipe.SetResult(this);
 
               recipe.AddRecipe();

			}
    }
}
	