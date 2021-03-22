using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GunGaming.Armor.scrapArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class scrapHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("There's gotta be at least 12 safety regulation broken here"
				+ "\n2% increased ranged damage");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.defense = 1;
		}
		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
			player.rangedDamage += 0.02f;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<scrapBreastplate>() && legs.type == ModContent.ItemType<scrapLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "+5% ranged damage";
			player.rangedDamage += 0.05f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}