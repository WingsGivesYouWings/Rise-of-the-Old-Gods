using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using RiseoftheGods.Core;
using RiseoftheGods.Content.Pleaceables;

namespace RiseoftheGods.Content.Tiles
{
    internal class AbyssalStoneTile : ModTile
    {
        public override string Texture => TexturesLoader.TexturesPathSolver(GetType(), "Tiles");

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

        //Tile drop function 
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
