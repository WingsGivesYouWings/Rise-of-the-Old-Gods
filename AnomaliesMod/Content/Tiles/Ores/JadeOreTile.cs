using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Localization;
using System.Collections.Generic;
using AnomaliesMod.Content.Items.Pleaceables;

namespace AnomaliesMod.Content.Tiles.Ores
{
    public class JadeOreTile : ModTile
    {
        public override string Texture => TexturesPath("Tiles", Name);
        public override void SetStaticDefaults()
        {
            MinPick = 55;   //Temporal stat
            MineResist = 1.25f;   //Temporal stat
            DustType = DustID.CoralTorch;
            HitSound = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;                 //Jade blocks emit light
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 640;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 410;
            TileID.Sets.Ore[Type] = true;

            AddMapEntry(new Color(0, 168, 107), CreateMapEntryName()); // 0,168,107 is the jade color for the map
            
        }

        //Light color emited for the jade ore
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0f;
            g = 0.659f;
            b = 0.420f; 
        }

        //Jade ore drops when you brake the tile 
        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ModContent.ItemType<JadeOreItem>());
        }
    }
}
























