using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GunGaming.Armor.goldArmor;

namespace GunGaming.Armor.crimArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class crimBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Crimson Chestplate");
			Tooltip.SetDefault("It feels like it's breathing."
				+ "\n4% increased ranged damage" +
				"\n3% increased critical strike chance");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player) {
            player.rangedDamage += 0.04f;
			player.rangedCrit += 3;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<goldBreastplate>(), 1);
			recipe.AddIngredient(ItemID.CrimtaneBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}