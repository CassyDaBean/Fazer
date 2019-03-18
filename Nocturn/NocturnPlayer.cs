using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nocturn
{
    public class NocturnPlayer : ModPlayer
    {
		public bool UFOLightPet = false;
		
		public override void ResetEffects()
		{
			
			UFOLightPet = false;
			
		}
    }
}