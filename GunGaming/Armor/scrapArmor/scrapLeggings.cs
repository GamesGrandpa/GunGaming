using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GunGaming.Armor.scrapArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class scrapLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("I think something moved in there."
				+ "\n5% increased movement speed"
				+ "\n2% increased ranged damage");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.defense = 1;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
			player.rangedDamage += 0.02f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}