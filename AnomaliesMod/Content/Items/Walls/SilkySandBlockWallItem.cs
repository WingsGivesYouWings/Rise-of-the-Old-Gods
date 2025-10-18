using AnomaliesMod.Content.Walls;
using AnomaliesMod.Content.Walls.OpenOcean;
using AnomaliesMod.Content.Items.Pleaceables;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AnomaliesMod.Content.Items.Walls
{
    public class SilkySandBlockWallItem : ModItem
    {
        public override string Texture => TexturesPath("Items", Name);

        public override void SetStaticDefaults() => Item.ResearchUnlockCount = 400;    //Minimun value for Journey mode's item research

        public override void SetDefaults() => Item.DefaultToPlaceableWall(ModContent.WallType<SilkySandBlockWall>());

        public override void AddRecipes()
        {
            CreateRecipe(4)
                .AddIngredient(ModContent.ItemType<SilkySandBlockItem>(), 1)
                .AddTile(18)
                .Register();
        }

    }
}
