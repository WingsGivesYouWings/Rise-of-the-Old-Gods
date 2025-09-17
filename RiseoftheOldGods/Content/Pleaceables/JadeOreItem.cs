using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RiseoftheOldGods.Content.Tiles;
using RiseoftheOldGods.Core;

namespace RiseoftheOldGods.Content.Pleaceables
{
    public class JadeOreItem : ModItem
    {
        public override string Texture => TexturesLoader.TexturesPathSolver(GetType(), "Items");
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<JadeOreTile>();
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(0, 0, 0, 20);   //Price balance pending 
        }
    }
}
