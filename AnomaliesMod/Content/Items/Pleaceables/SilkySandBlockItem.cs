using AnomaliesMod.Core.Utilities;
using AnomaliesMod.Content.Tiles.OpenOcean;
using AnomaliesMod.Content.Walls.OpenOcean;
using Terraria.ID;
using Terraria.ModLoader;
using AnomaliesMod.Content.Items.Walls;

namespace AnomaliesMod.Content.Items.Pleaceables
{
    public class SilkySandBlockItem : ModItem
    {
        public override string Texture => TexturesPath("Items", Name);
        public override void SetStaticDefaults() => Item.ResearchUnlockCount = 100;

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<SilkySandBlockTile>();
            Item.rare = ItemRarityID.Gray;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<SilkySandBlockWallItem>(), 4)
                .AddTile(18)
                .Register();
        }
    }
}
