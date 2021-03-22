using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GunGaming.Armor.scrapArmor;

namespace GunGaming.Armor.goldArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class goldBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Gold Plated Chestplate");
			Tooltip.SetDefault("It's so shiny."
				+ "\n3% increased ranged damage" +
				"\n1% increased critical strike chance");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Yellow;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
            player.rangedDamage += 0.03f;
			player.rangedCrit += 1;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<scrapBreastplate>(), 1);
			recipe.AddIngredient(ItemID.GoldBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}