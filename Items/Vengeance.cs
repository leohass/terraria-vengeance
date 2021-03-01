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
				

				

                if (player.HasBuff(mod.BuffType("Vengeance")))
                {
					item.damage = 50000;
					item.useTime = 150;
					item.useAnimation = 150;
					item.useStyle = 4;
					item.scale = 4f;
					item.noMelee = true;
					item.autoReuse = false;
					this.i++;
                }
                else
                {
					item.damage = 240;
					item.scale = 2f;
					item.shoot = 0;
                }
				if (this.i == 2)
				{
					item.shoot = mod.ProjectileType("VengeanceProjectile");
					item.shootSpeed = 16f;
					item.useStyle = 1;
					this.i = 0;
					player.ClearBuff(mod.BuffType("Vengeance"));
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