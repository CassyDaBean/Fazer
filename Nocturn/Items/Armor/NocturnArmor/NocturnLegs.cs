using Terraria;
using Terraria.ModLoader;

namespace Nocturn.Items.Armor.NocturnArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class NocturnLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("awww hekers"
				+ "\n5% increased movement speed");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 3f;
		}

		//public override void AddRecipes() {
		//	ModRecipe recipe = new ModRecipe(mod);
		//	recipe.AddIngredient(mod.ItemType("EquipMaterial"), 45);
		//	recipe.AddTile(mod.TileType("ExampleWorkbench"));
		//	recipe.SetResult(this);
		//	recipe.AddRecipe();
		//}
	}
}