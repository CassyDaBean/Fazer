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
	public class VeinBurster_Head : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vein Burster");
			 Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 26;
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
		}
 public override void AI(){ BaseMod.BaseAI.AIWorm(npc, new int[]{ mod.NPCType ("VeinBurster_Head"), mod.NPCType ("VeinBurster_Body"), mod.NPCType ("VeinBurster_Tail")}, 12, 8f, 12f, 0.1f, false, false);
	}
	
}}