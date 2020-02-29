using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.NPCs
{
    public class SkylandDread : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skyland Dread");
            Main.npcFrameCount[npc.type] = 1;
        }
        public override void SetDefaults()
        {
            npc.width = 48;
            npc.height = 38;
            npc.damage = 10;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit37;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 10f;
            npc.aiStyle = 5;
            npc.knockBackResist = 0.1f;
            aiType = NPCID.MeteorHead;
            animationType = NPCID.MeteorHead;
            npc.noGravity = true;
            npc.noTileCollide = true;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneSkyHeight && Main.dayTime ? 100f : 0f;

        }
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.5f;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
            npc.spriteDirection = npc.direction;
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Cloud);
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FallenStar);
        }
        public override void AI()
        {
            Lighting.AddLight(npc.position, 0.75f, 0.75f, 0.75f);
        }
    }
}