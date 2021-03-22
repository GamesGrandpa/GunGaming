using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria;


namespace GunGaming.Items
{
	public class goldGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gold Gun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Budder");
		}

		public override void SetDefaults()
		{
			item.damage = 8; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 15; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 15; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = .1f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 100000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Yellow; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<que>(), 1);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(4, 0);
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .33f;
		}
	}
}