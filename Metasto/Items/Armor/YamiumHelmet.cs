using Terraria;

using Terraria.ID;

using Terraria.ModLoader;

using static Terraria.ModLoader.ModContent;

namespace Metasto.Items.Armor

{

    [AutoloadEquip(EquipType.Head)]

    public class YamiumHelmet : ModItem

    {

        public override void SetStaticDefaults()

        {

            Tooltip.SetDefault("+20% Melee Damage");

        }



        public override void SetDefaults()

        {

            item.width = 26;

            item.height = 22;

            item.value = 10000;

            item.rare = ItemRarityID.Purple;

            item.defense = 15;

        }



        public override bool IsArmorSet(Item head, Item body, Item legs)

        {

            return body.type == ModContent.ItemType<YamiumChestplate>() && legs.type == ModContent.ItemType<YamiumGreaves>();

        }





        public override void UpdateEquip(Player player)

        {

            player.meleeDamage += 0.2f;

            

        }



        public override void UpdateArmorSet(Player player)

        {

            

            player.setBonus = "+20 Defense\n+30% Damage.";

            

           



        }



        public override void AddRecipes()

        {

            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "YamiumBar", 12);

            recipe.AddTile(16);

            recipe.SetResult(this);

            recipe.AddRecipe();

        }

    }

}