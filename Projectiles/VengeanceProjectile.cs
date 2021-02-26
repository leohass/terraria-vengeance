using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PrototypeSword.Projectiles
{
    class VengeanceProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "VengeanceProjectile";
            projectile.height = 40;
            projectile.width = 40;
            projectile.friendly = true;
            projectile.penetrate = 1000;
            projectile.tileCollide = false;
            projectile.timeLeft = 1800;
            projectile.scale = 8f;
            projectile.light = 0.75f;
            projectile.melee = true;
     
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}
