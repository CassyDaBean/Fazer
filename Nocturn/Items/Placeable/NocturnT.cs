using Terraria.ModLoader;

namespace Nocturn.Items.Placeable
{
	public class NocturnT : ModItem
	{
		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 50000;
			item.rare = 1;
			item.createTile = mod.TileType("NocturnTrophie");
			item.placeStyle = 0;
		}
	}
}