using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Placeable
{
	public class AstrumBench : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astrum Bench");
			Tooltip.SetDefault("The bench of the stars");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.AstrumBench>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}