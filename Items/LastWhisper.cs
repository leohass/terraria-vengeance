using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace PrototypeSword.Items
{
    class LastWhisper : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Vengeance"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Youre Enemys wont whisper they will scream in Agony");
        }

        public override void SetDefaults()
        {
            item.damage = 160;
            item.ranged = true;
            item.width = 80;
            item.height = 40;
            item.useStyle = 5;
            item.value = 10000;
            item.rare = 5;
            item.scale = 0.7f;
			item.shoot = 10;
            item.useAmmo = AmmoID.Bullet;
            item.shootSpeed = 50;
            item.autoReuse = true;
            item.useAnimation = 12;
            item.useTime = 4;
            item.reuseDelay = 14;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            //shoot custom ammo consume normal bullets
            if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
            {
                type = mod.ProjectileType("NaniteInfectionBullet"); // or ProjectileID.FireArrow;
            }

            //Appen Bullets from Muzzle
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20, 0);
        }

        // Burst Fire
        public override bool ConsumeAmmo(Player player)
        {
            // Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (useAnimation - 1, then - useTime until less than 0.) 
            // We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
            return !(player.itemAnimation < item.useAnimation - 2);
        }
        
    }
}
