﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace Vengeance.Buffs
{
    public class DefensiveStance : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Defensive Stance");
            Description.SetDefault("The Swords Protect you");

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 6;

            player.moveSpeed -= 0.1f;
        }

    }
    
}
