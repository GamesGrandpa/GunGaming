using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria;


namespace GunGaming.Items
{
	public class scrapBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded bullet ammo.");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = .5f;
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<Projectiles.scrapBullet>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 1f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		/*public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(5))
			{
				player.AddBuff(BuffID.Wrath, 300);
			}
		}*/

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}