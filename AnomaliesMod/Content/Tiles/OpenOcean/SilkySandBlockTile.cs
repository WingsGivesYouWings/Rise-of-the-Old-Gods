using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using AnomaliesMod.Content.Items.Pleaceables;
using AnomaliesMod.Content.Projectiles.Falling_Blocks;
using AnomaliesMod.Core.Utilities;

namespace AnomaliesMod.Content.Tiles.OpenOcean
{
    public class SilkySandBlockTile : ModTile
    {
        public override string Texture => TexturesPath("Tiles", Name);

        public override void SetStaticDefaults()
        {
            MinPick = 35;        //Temporal stat
            MineResist = 0.5f;   //Temporal stat
            DustType = DustID.Sand;
            HitSound = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileBrick[Type] = true;
            Main.tileSand[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = true;

            //To support tile corruption, implement: TilesID.Sets.Conversion.Sand[Type] = true;
            TileID.Sets.CanBeDugByShovel[Type] = true;                     
            TileID.Sets.ChecksForMerge[Type] = true;
            TileID.Sets.GeneralPlacementTiles[Type] = false;               //Silky sand can't be used to spawn general world tiles, as hives or campsites
            TileID.Sets.ForAdvancedCollision.ForSandshark[Type] = true;    //Sand Shark can swing in Silky Sand
            TileID.Sets.Suffocate[Type] = true;
            TileID.Sets.Falling[Type] = true;
            //Creating a falling sand projectile with 10 damage
            TileID.Sets.FallingBlockProjectile[Type] = new TileID.Sets.FallingBlockProjectileInfo(ModContent.ProjectileType<FallingSilkySandBlock>(), 10);   

            AddMapEntry(new Color(223, 211, 147));                         //Silky Sand color in the map
        }

        //This tile randomly generates dust when the player walks over it
        public override bool HasWalkDust()
        {
            return Main.rand.NextBool(3);
        }

        //Generating dust
        public override void WalkDust(ref int dustType, ref bool makeDust, ref Color color)
        {
            dustType = DustID.Sand;
        }

        //Getting items when breaking the tile
        public override IEnumerable<Item> GetItemDrops(int i, int j)
        {
            yield return new Item(ModContent.ItemType<SilkySandBlockItem>());
        }
    }
}
