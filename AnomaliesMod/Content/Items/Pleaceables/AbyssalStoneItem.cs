using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent;
using AnomaliesMod.Content.Tiles.OpenOcean;

namespace AnomaliesMod.Content.Items.Pleaceables
{
    internal class AbyssalStoneItem : ModItem
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
            Item.createTile = ModContent.TileType<AbyssalStoneTile>();
            Item.rare = ItemRarityID.White;
            Item.value = 0;
        }
    }
}

