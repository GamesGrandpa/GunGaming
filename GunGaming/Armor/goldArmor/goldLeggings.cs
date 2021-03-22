using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GunGaming.Armor.scrapArmor;

namespace GunGaming.Armor.goldArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class goldLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("It is a little heavy..."
				+ "\n5% decreased movement speed"
				+ "\n3% increased ranged damage" +
                "\n1% increased critical strike chance");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Yellow;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed -= 0.05f;
			player.rangedDamage += 0.03f;
			player.rangedCrit += 1;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<scrapLeggings>(), 1);
			recipe.AddIngredient(ItemID.GoldBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}