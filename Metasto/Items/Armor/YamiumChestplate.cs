using Terraria;

using Terraria.ID;

using Terraria.ModLoader;

using static Terraria.ModLoader.ModContent;

namespace Metasto.Items.Armor

{

    [AutoloadEquip(EquipType.Body)]

    public class YamiumChestplate : ModItem

    {

        public override void SetStaticDefaults()

        {

            Tooltip.SetDefault("+20% Melee Speed");

        }



        public override void SetDefaults()

        {

            item.width = 29;

            item.height = 17;

            item.value = 10000;

            item.rare = ItemRarityID.Purple;

            item.defense = 35;

        }



        public override void UpdateEquip(Player player)

        {

            player.meleeSpeed += .2f;

            

        }



        public override void AddRecipes()

        {

            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "YamiumBar", 16);

            

            recipe.AddTile(16);

            recipe.SetResult(this);

            recipe.AddRecipe();

        }

    }

}