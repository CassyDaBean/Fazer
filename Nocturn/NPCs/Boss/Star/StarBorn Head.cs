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
	public class StarBorn_Head : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Born");
			 Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 18;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.behindTiles = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = -1;
            NPCs.Boss = true;
		}
 public override void AI(){ BaseMod.BaseAI.AIWorm(npc, new int[]{ mod.NPCType ("StarBorn_Head"), mod.NPCType ("StarBorn_Body"), mod.NPCType ("StarBorn_Tail")}, 20, 8f, 12f, 0.1f, true, false);
	}
	
}}