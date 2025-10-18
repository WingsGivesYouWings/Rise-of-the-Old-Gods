using AnomaliesMod.Content.Tiles.Ores;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace AnomaliesMod.Core.World.WorldGenSystem
{
    public class JadeOreGenSystem : ModSystem
    {
        public static bool spawnedJadeOre = false; // Every Tick = No jade spawn

        public override void OnWorldLoad() //resets the spawnedJadeOre flag so it doesnt carry to a different world
        {
            spawnedJadeOre = false;
        }
        public override void OnWorldUnload() // avoids carrying the flag into a different world
        {
            spawnedJadeOre = false;
        }
        public override void SaveWorldData(TagCompound tag) // remembers if the jade spawned already or not
        {
            tag["spawnedJadeOre"] = spawnedJadeOre;
        }
        public override void LoadWorldData(TagCompound tag) //loads the flag, restoring the previous state
        {
            spawnedJadeOre = tag.GetBool("spawnedJadeOre");
        }

        public override void PostUpdateWorld() //runs every tick to see if the eye of cthulu and the BoC OR EoW has been defeated
        {
            if (!spawnedJadeOre && (NPC.downedBoss1 || NPC.downedBoss2)) //checks if jade ore has already spawned and if the Eoc and BoC / EoW has been defeated
            {
                spawnedJadeOre = true; // sets flag to true
                GenerateJadeOre(); // pretty self explanatory, Generates Jade Ore
                Main.NewText("Jade ore hath Spawned!!!", 0, 163, 108); // Shows message ingame where jade ore has spawned with the color of jade
            }
        }
        private void GenerateJadeOre() //Generates randomly throughout the cavern (i think the cavern layer at least)
        {
            int oreCount = 450; //controls how many veins spawns

            for (int i = 0; i < oreCount; i++) //loops 150 times
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX); //picks a random X Coordinate in the world
                int y = WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY - 200); //picks a random Y Coordinate in the world, subracted by 200

                WorldGen.OreRunner( //Spawns natural looking ore
                x,
                y,
                WorldGen.genRand.Next(4, 11), //Horizontal Size
                WorldGen.genRand.Next(4, 11), //Vertical Size
                (ushort)ModContent.TileType<JadeOreTile>()); // Jade Ore
            }
        }
    }
}
