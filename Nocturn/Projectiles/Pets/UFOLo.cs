using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nocturn.Projectiles.Pets
{
	public class UFOLightPet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paper Airplane"); // Automatic from .lang files
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			NocturnPlayer modPlayer = player.GetModPlayer<NocturnPlayer>(mod);
			if (player.dead)
			{
				modPlayer.UFOLightPet = false;
			}
			//if (modPlayer.UFOLightpet)
			//{
			//	projectile.timeLeft = 2;
			//}
		}
	}
}