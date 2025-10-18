using Terraria.ID;
using Terraria.ModLoader;
using AnomaliesMod.Content.Items.Pleaceables;
using AnomaliesMod.Core.Utilities;
using AnomaliesMod.Content.Tiles.OpenOcean;

namespace AnomaliesMod.Content.Projectiles.Falling_Blocks
{
    internal class FallingSilkySandBlock : ModProjectile
    {
        public override string Texture => TexturesPath("Projectiles/Falling Blocks", Name);
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.FallingBlockDoesNotFallThroughPlatforms[Type] = true;
            ProjectileID.Sets.ForcePlateDetection[Type] = true;
            ProjectileID.Sets.FallingBlockTileItem[Type] = new(ModContent.TileType<SilkySandBlockTile>(), ModContent.ItemType<SilkySandBlockItem>());
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.EbonsandBallFalling);
        }
    }
}
