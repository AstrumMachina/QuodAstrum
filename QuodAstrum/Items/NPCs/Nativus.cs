using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.NPCs
{
    [AutoloadBossHead]
    public class Nativus : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nativus, the Sandstorm Queen");

        }
        public override void SetDefaults()
        {
            npc.aiStyle = 102;
            npc.lifeMax = 500000;
            npc.damage = 100;
            npc.defense = 250;
            npc.knockBackResist = 0f;
            npc.width = 104;
            npc.height = 184;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            Main.npcFrameCount[npc.type] = 1;
            aiType = NPCID.SandElemental;
            animationType = NPCID.SkeletronHead;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit55;
            npc.DeathSound = SoundID.NPCDeath62;
            npc.buffImmune[24] = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Raw, Unfiltered Calamity");
        }


    }
}