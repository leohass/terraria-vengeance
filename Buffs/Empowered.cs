using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Vengeance.Buffs
{
    class Empowered : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Empowered");
            Description.SetDefault("Strange Power flows through my body");

        }
    }
}
