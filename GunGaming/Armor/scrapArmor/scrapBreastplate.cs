using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GunGaming.Armor.scrapArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class scrapBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Scrap Chestplate");
			Tooltip.SetDefault("How is this still in one piece."
				+ "\n2% increased ranged damage");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player) {
			player.rangedDamage += 0.02f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}