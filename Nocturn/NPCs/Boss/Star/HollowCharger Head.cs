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
	public class HollowCharger_Head : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hollow Charger");
			 Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults()
		{
			npc.width = 20;
			npc.height = 20;
			npc.damage = 14;
			npc.defense = 30;
			npc.lifeMax = 2000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.behindTiles = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = -1;
			npc.boss = true;
		}
		float speed = 10f;
		 float REE = 0.5f;
             int Seg = 30;
 public override void AI(){ BaseMod.BaseAI.AIWorm(npc, new int[]{ mod.NPCType ("HollowCharger_Head"), mod.NPCType ("HollowCharger_Body"), mod.NPCType ("HollowCharger_Tail")}, Seg, 10f, speed, REE, true, false);
	if (npc.life < npc.lifeMax / 2)
	{
		REE = 0.5f * 2;
		speed = 10f *5;
		Seg = 30 *2;
	}
	}
	
}}