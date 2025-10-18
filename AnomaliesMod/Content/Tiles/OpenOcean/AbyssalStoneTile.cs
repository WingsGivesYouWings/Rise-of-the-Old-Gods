using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using AnomaliesMod.Content.Items.Pleaceables;
using AnomaliesMod.Core.Utilities;

namespace AnomaliesMod.Content.Tiles.OpenOcean
{
    internal class AbyssalStoneTile : ModTile
    {
        public override string Texture => TexturesPath("Tiles", Name);

        //Tile properties
        public override void SetStaticDefaults()
        {
            MinPick = 225;                        //Requires lunar pickaxe tier or better
            DustType = DustID.Stone;
            MineResist = 1.5f;
            HitSound = SoundID.Tink;

            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            AddMapEntry(new Color(36, 44, 82), CreateMapEntryName());  //36,44,82 is the abyssal stone color for the map

        }

        //Abyssal stone block drops when you brake the tile 
        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ModContent.ItemType<AbyssalStoneItem>());
        }

        //Desabling explosives mining for this tile
        public override bool CanExplode(int i, int j)
        {
            return false;
        }

    }
}
