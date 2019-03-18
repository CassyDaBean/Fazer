using Terraria;
using Terraria.ModLoader;

namespace Nocturn.Items.Armor.NocturnArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class NocturnHelmet: ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("blah");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("ExampleBreastplate") && legs.type == mod.ItemType("ExampleLeggings");
		}

		public override void UpdateArmorSet(Player player) {
			//player.setBonus = "trollface.jpg";
			player.meleeDamage *= 1f;
			player.thrownDamage *= 1f;
			player.rangedDamage *= 1f;
			player.magicDamage *= 1f;
			player.minionDamage *= 1f;
		}

		//public override void AddRecipes() {
		//	ModRecipe recipe = new ModRecipe(mod);
		//	recipe.AddIngredient(mod.ItemType("EquipMaterial"), 30);
		//	recipe.AddTile(mod.TileType("ExampleWorkbench"));
		//	recipe.SetResult(this);
		//	recipe.AddRecipe();
		//}
	}
}