using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace Metasto.Items.Armor

{

    [AutoloadEquip(EquipType.Legs)]

    public class YamiumGreaves : ModItem

    {

        public override void SetStaticDefaults()

        {

            Tooltip.SetDefault("Increased jump height\n+15% Movement Speed and Max Run Speed");

        }



        public override void SetDefaults()

        {

            item.width = 22;

            item.height = 18;

            item.value = 10000;

            item.rare = ItemRarityID.Purple;

            item.defense = 30;

        }



        public override void UpdateEquip(Player player)

        {

            player.moveSpeed += 0.15f;

            player.maxRunSpeed += .15f;

            player.jumpSpeedBoost += 4;

        }



        public override void AddRecipes()

        {

            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "YamiumBar", 14);

            recipe.AddTile(16);

            recipe.SetResult(this);

            recipe.AddRecipe();

        }

    }

}