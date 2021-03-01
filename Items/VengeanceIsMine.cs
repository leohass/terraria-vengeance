using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Vengeance.Items
{
    class VengeanceIsMine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swords Of Vengeance");
            Tooltip.SetDefault("...at last Vengeance shall be mine");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.rare = 5;
            item.accessory = true;

        }
        public override void UpdateAccessory(Player player, bool hideVisual = false)
        {
            player.AddBuff(mod.BuffType("DefensiveStance"), 3600);
        } 
    }

}
