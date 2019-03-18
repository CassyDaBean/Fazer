using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.ModLoader;
using BaseMod;

namespace Nocturn.NPCs.Boss.Star
{
	public class VeinBurster_Body : VeinBurster_Head
	
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vein burster");
			 Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults()
        {
            base.SetDefaults();
            npc.dontCountMe = true;
        }
        public override bool PreNPCLoot()
        {
            return false;
        }
    }
	
}