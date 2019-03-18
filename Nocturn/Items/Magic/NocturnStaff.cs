using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nocturn.Items.Magic
{
    public class NocturnStaff : ModItem
    {
        public override void SetStaticDefaults() { 
            Tooltip.SetDefault("PEW");
        }

        public override void SetDefaults() { 
        
            item.damage = 40;
            item.noMelee = true;
            item.magic = true;
            item.channel = true; //Channel so that you can held the weapon [Important]
            //item.mana = 5;
            item.rare = 5;
            item.width = 24;
            item.height = 64;
            item.useTime = 1;
            item.UseSound = SoundID.Item13;
            item.useStyle = 5;
            item.shootSpeed = 10f;
            item.useAnimation = 20;
            item.shoot = mod.ProjectileType("NocturnBomb");
            item.value = Item.sellPrice(silver: 3);
            //Items.autoReuse = true;
            
        }
    

        //public override void AddRecipes()
        //{
           // ModRecipe recipe = new ModRecipe(mod);
           // recipe.AddIngredient(mod, "ExampleItem", 10);
           // recipe.AddTile(mod, "ExampleWorkbench");
           // recipe.SetResult(this);
           // recipe.AddRecipe();
       // }
   }
}
