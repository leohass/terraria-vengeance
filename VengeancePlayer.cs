using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Vengeance
{
    class VengeancePlayer : ModPlayer
    {
        public int accumulated_damage = 0;

  
        public override void OnHitByNPC(NPC npc, int damage, bool crit)
        {
            HandleVengeance(damage);
        }

        public override void OnHitByProjectile(Projectile proj, int damage, bool crit)
        {
            HandleVengeance(damage);
        }

        //This handles the Damage Tracking and sets a new Buff when Threshol is reached(Incredible Hacky i know but dont know how to fix)
        public void HandleVengeance(int damage)
        {
            if (player.HasBuff(mod.BuffType("VengeanceIsMine")))
            {
                player.GetModPlayer<VengeancePlayer>().accumulated_damage += damage;

                if (player.GetModPlayer<VengeancePlayer>().accumulated_damage > 500)
                {
                    player.GetModPlayer<VengeancePlayer>().accumulated_damage = 500;
                }

            }
            if (player.GetModPlayer<VengeancePlayer>().accumulated_damage >= 500 || true)
            {
                player.AddBuff(mod.BuffType("Vengeance"), 3600);
                player.GetModPlayer<VengeancePlayer>().accumulated_damage = 0;

            }
        }
    }
}
