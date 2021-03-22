using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GunGaming.Armor.goldArmor;

namespace GunGaming.Armor.crimArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class crimLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Crimson Plated Leggings");
			Tooltip.SetDefault("It feels a little slimy."
				+ "\n5% increased movement speed"
				+ "\n4% increased ranged damage" +
                "\n3% increased critical strike chance");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
			player.rangedDamage += 0.04f;
			player.rangedCrit += 3;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<goldLeggings>(), 1);
			recipe.AddIngredient(ItemID.CrimtaneBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}