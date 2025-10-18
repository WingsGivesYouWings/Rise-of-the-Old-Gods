using AnomaliesMod.Core.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using AnomaliesMod.Content.Tiles.Ores;

namespace AnomaliesMod.Content.Items.Pleaceables
{
    public class JadeOreItem : ModItem
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
            Item.createTile = ModContent.TileType<JadeOreTile>();
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(0, 0, 15, 0);   //Price balance pending 
        }
    }
}
