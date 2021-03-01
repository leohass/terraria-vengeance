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
    class NaniteInfectionBullet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.damage = 20;
            projectile.height = 5;
            projectile.friendly = true;
            projectile.penetrate = 10;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
            projectile.scale = 1f;
            projectile.light = 0.75f;
            projectile.ranged = true;
            projectile.aiStyle = 0;

            aiType = ProjectileID.BulletHighVelocity;

        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation();
        }
    }
}
