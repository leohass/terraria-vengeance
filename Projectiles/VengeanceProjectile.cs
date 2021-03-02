using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Vengeance.Projectiles
{
    public class VengeanceProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.height = 160;
            projectile.width = 160;
            projectile.friendly = true;
            projectile.penetrate = 1000;
            projectile.tileCollide = false;
            projectile.timeLeft = 100;
            projectile.scale = 0.5f;
            projectile.light = 0.75f;
            projectile.melee = true;
            projectile.aiStyle = 0;

            aiType = ProjectileID.BulletHighVelocity;
     
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation();
        }
    }
}
