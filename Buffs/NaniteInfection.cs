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
    class NaniteInfection : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Vengeance is mine");
            Description.SetDefault("A Powerful Energy fills your Blade");
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.defense = (int)(npc.defense * 0.9f);
            npc.damage = (int)(npc.damage * 0.8f);
        }
    }
}
