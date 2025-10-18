using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnomaliesMod.Content.Walls.OpenOcean
{
    public class SilkySandBlockWall : ModWall
    {
        public override string Texture => TexturesPath("Walls", Name);

        public override void SetStaticDefaults()
        {
            Main.wallHouse[Type] = false;    //This wall is unsafe
            Main.wallBlend[Type] = Type;     //THe wall blends with other walls around it

            DustType = DustID.Sand;
            HitSound = SoundID.Dig;

            AddMapEntry(new Color(158, 130, 94));     //The color of the silky sand blocks in the map entry
        }
    }
}
