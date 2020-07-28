using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Accessories

{
    public class MetalFusionEye : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Metal Fusion Eye");
            Tooltip.SetDefault("0.12%+ Melee Damage");

        }

        public override void SetDefaults()

        {

            item.width = 79;

            item.height = 36;

            item.value = 10000;

            item.rare = -1;

            item.accessory = true;

        }



        public override void UpdateAccessory(Player player, bool hideVisual)

        {
		    player.meleeDamage += 0.12f;
        }


        public override void AddRecipes()  //How to craft this item

        {

            ModRecipe recipe = new ModRecipe (mod);

			recipe.AddIngredient(null, "LeadEye", 1);
            recipe.AddIngredient(null, "IronEye", 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}