using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GunGaming.Armor.scrapArmor;

namespace GunGaming.Armor.goldArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class goldHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Gold Plated Chestplate");
			Tooltip.SetDefault("Feels pretty smooth"
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
		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.1f;
			player.rangedDamage += 0.03f;
			player.rangedCrit += 1;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<goldBreastplate>() && legs.type == ModContent.ItemType<goldLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "+5% ranged damage" +
                "+5% critical strike chance";
			player.rangedDamage += 0.05f;
			player.rangedCrit += 5;
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
			recipe.AddIngredient(ModContent.ItemType<scrapHelmet>(), 1);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}