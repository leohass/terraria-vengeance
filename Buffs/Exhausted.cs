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
    class Exhausted : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Exhausted");
            Description.SetDefault("Your Defense, Movement Speed and Life Generation are reduced");

        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense -= 20;
            player.lifeRegen -= 5;
            player.moveSpeed = 0.3f;
        }
    }
}
