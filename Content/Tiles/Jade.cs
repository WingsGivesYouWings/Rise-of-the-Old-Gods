using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;


namespace RiseoftheOldGods.Content.Tiles;

public class Jade : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileMergeDirt[Type] = true;
        Main.tileSpelunker[Type] = true;
        Main.tileOreFinderPriority[Type] = 410;
        TileID.Sets.Ore[Type] = true;
        AddMapEntry(new Color(0, 168, 107), CreateMapEntryName()); // 0,168,107 is the jade color for the map
        DustType = DustID.CoralTorch;
        HitSound = SoundID.Tink;
    }
}

public class JadeOreSystem : ModSystem
{
    public static bool SpawnedJadeOre = false; // Every Tick = No jade spawn

    public override void OnWorldLoad() //resets the SpawnedJadeOre flag so it doesnt carry to a different world
    {
        SpawnedJadeOre = false;
    }

    public override void OnWorldUnload() // avoids carrying the flag into a different world
    {
        SpawnedJadeOre = false;
    }

    public override void SaveWorldData(TagCompound tag) // remembers if the jade spawned already or not
    {
        tag["SpawnedJadeOre"] = SpawnedJadeOre;
    }

    public override void LoadWorldData(TagCompound tag) //loads the flag, restoring the previous state
    {
        SpawnedJadeOre = tag.GetBool("SpawnedJadeOre");
    }

    public override void
        PostUpdateWorld() //runs every tick to see if the eye of cthulu and the BoC OR EoW has been defeated
    {
        if (!SpawnedJadeOre &&
            (NPC.downedBoss1 ||
             NPC.downedBoss2)) //checks if jade ore has already spawned and if the Eoc and BoC / EoW has been defeated
        {
            SpawnedJadeOre = true; // sets flag to true
            GenerateJadeOre(); // pretty self explanatory, Generates Jade Ore
            Main.NewText("Jade ore hath Spawned!!!!", 0, 163,
                108); // Shows message ingame where jade ore has spawned with the color of jade
        }
    }

    private void GenerateJadeOre() //Generates randomly throughout the cavern (i think the cavern layer at least)
    {
        int oreCount = 150; //controls how many veins spawns

        for (int i = 0; i < oreCount; i++) //loops 150 times
        {
            
            int x = WorldGen.genRand.Next(0, Main.maxTilesX); //picks a random X Coordinate in the world
            int y = Terraria.WorldGen.genRand.Next((int)Main.rockLayer,
                Main.maxTilesY - 200); //picks a random Y Coordinate in the world, subracted by 200

            Terraria.WorldGen.OreRunner( //Spawns natural looking ore
                x,
                y,
                Terraria.WorldGen.genRand.Next(3, 6), //Horizontal Size
                Terraria.WorldGen.genRand.Next(3, 6), //Vertical Size
                (ushort)ModContent.TileType<Jade>()); // Jade Ore
        }
    }
}