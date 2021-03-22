using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria;


namespace GunGaming.Items
{
	public class hemoBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;            
			item.knockBack = .5f;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.shoot = ModContent.ProjectileType<Projectiles.goldBullet>();   
			item.shootSpeed = 1.2f;                  
			item.ammo = AmmoID.Bullet;              
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}