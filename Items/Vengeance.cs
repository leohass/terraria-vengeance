using PrototypeSword.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrototypeSword.Items
{
	public class Vengeance : ModItem
	{


		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Vengeance"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Brother... Avenge me");
		}

		public override void SetDefaults() 
		{
			item.damage = 240;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useStyle = 1;
			item.value = 10000;
			item.rare = 5;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowScale, 150);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 5);
			recipe.AddIngredient(ItemID.SoulofFright, 80);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        //Weapon Handler

        public override bool AltFunctionUse(Player player)
        {
			return true;
		}
        public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2)
            {
				item.damage = item.damage * 10;
				item.useTime = 1800;
				item.useAnimation = 30;
				item.useStyle = 1;
				item.scale = 8f;
				item.shoot = ModContent.ProjectileType<VengeanceProjectile>();
				item.shootSpeed = 16f;
				item.autoReuse = false;
				item.noMelee = true;
				item.notAmmo = true;

			}
			else
            {
				item.scale = 2f;
				item.damage = 520;
				item.width = 40;
				item.height = 40;
				item.useTime = 20;
				item.useAnimation = 20;
				item.useStyle = 1;
				item.knockBack = 6;
				item.shoot = 0;
				item.UseSound = SoundID.Item1;
				item.autoReuse = true;
				item.noMelee = false;
			}
			return base.CanUseItem(player);
        }
		
		
    }
}