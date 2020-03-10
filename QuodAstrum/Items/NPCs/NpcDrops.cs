using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            if (npc.type == mod.NPCType("AstrumTerr")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.spawnDragonAge)
                {                                                          //Red  Green Blue
                    Main.NewText("Lyrium has developed in the world caverns", 50, 100, 225);  //this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 40E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("LyriumOre"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                    }
                }
                AstrumWorld.spawnDragonAge = true;   //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.WallofFlesh)
            //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.spawnWyvernSteel)
                {                                                          //Red  Green Blue
                    Main.NewText("The Sky has been gifted with the Wyvern's Steel", 150, 100, 255);  //this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) / 4 * 20E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next(10, 80); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(5, 10), WorldGen.genRand.Next(5, 10), (ushort)mod.TileType("AstrumRock"));
                        
                    }
                }
                AstrumWorld.spawnWyvernSteel = false;   //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }

        }
    }
}