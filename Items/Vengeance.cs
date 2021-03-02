using Vengeance.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Vengeance.Items
{
	public class Vengeance : ModItem
	{


		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Vengeance"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Brother... Avenge me");
		}

		int i = 0;
		public override void SetDefaults() 
		{
			item.damage = 240;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useStyle = 1;
			item.value = 10000;
			item.rare = 5;
			item.shootSpeed = 16f;
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
			if(player.HasBuff(mod.BuffType("Empowered")) || player.HasBuff(mod.BuffType("Vengeance")))
            {
				if(player.altFunctionUse == 2)
				{
					if (player.HasBuff(mod.BuffType("Empowered")))
					{
						player.AddBuff(mod.BuffType("Vengeance"), 3600);
						player.ClearBuff(mod.BuffType("Empowered"));
					}
					if (player.HasBuff(mod.BuffType("Vengeance")))
					{
						if(this.i != 2)
						{
							item.damage = 360;
							item.useTime = 10;
							item.useAnimation = 10;
							item.useStyle = 3;
							item.scale = 3f;
							item.autoReuse = true;
							this.i++;
						}
						else if (this.i == 2)
						{
							item.shoot = mod.ProjectileType("VengeanceProjectile");
							item.useStyle = 1;
						
							this.i = 0;
						}
					}
					else
					{
						item.damage = 240;
						item.scale = 2f;
						item.shoot = 0;
					}
				}
            }
			else
            {
				item.scale = 2f;
				item.damage = 240;
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