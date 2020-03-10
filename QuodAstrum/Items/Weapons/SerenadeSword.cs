using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons        //The directory for your .cs and .png; Example: Mod Sources/TutorialMOD/Items
{
    public class SerenadeSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Serenade Sword");
            Tooltip.SetDefault("Let the ancients lend you strength\nThe light of the stars is with you\nIt's dangerous to go alone\nTake this");
        }
        public override void SetDefaults()
        {
            
            item.damage = 15;     //The damage stat for the Weapon.
            item.melee = true;      //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.width = 75;   //The size of the width of the hitbox in pixels.
            item.height = 75;  //The size of the height of the hitbox in pixels.
            item.useTime = 10;   //How fast the Weapon is used.
            item.useAnimation = 10;     //How long the Weapon is used for.
            item.useStyle = 1;            //The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 10;  //The knockback stat of your Weapon.
            item.value = Item.buyPrice(0, 0, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = ItemRarityID.Expert;    //The color the title of your Weapon when hovering over it ingame
            item.UseSound = SoundID.Item71;   //The sound played when using your Weapon
            item.shoot = mod.ProjectileType("SerenadeShot");
            item.shootSpeed = 6f;
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
        }

        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddIngredient(ItemID.WoodenSword, 1);     
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}