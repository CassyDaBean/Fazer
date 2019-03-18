using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nocturn.Items.Armor.NocturnArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class NocturnBody : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Nocturn Chestplate");
			Tooltip.SetDefault("Nocturn's first and only Chestplate..."
				
				+ "\nGives Nocturn's Void With every weapon");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 100;
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
		}

		//public override void AddRecipes() {
		//	ModRecipe recipe = new ModRecipe(mod);
		//	recipe.AddIngredient(mod.ItemType("EquipMaterial"), 60);
		//	recipe.AddTile(mod.TileType("ExampleWorkbench"));
		//	recipe.SetResult(this);
		//	recipe.AddRecipe();
		//}
	}
}