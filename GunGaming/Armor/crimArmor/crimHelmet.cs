using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GunGaming.Armor.goldArmor;

namespace GunGaming.Armor.crimArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class crimHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Crimson Helmet");
			Tooltip.SetDefault("Did it just lick me?"
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
		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.04f;
			player.rangedCrit += 3;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<crimBreastplate>() && legs.type == ModContent.ItemType<crimLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "\n+7% ranged damage" +
                "\n+7% critical strike chance";
			player.rangedDamage += 0.07f;
			player.rangedCrit += 7;
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
			recipe.AddIngredient(ModContent.ItemType<goldHelmet>(), 1);
			recipe.AddIngredient(ItemID.CrimtaneBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}