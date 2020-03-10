using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.NPCs
{
    [AutoloadBossHead]
    public class StellarJelly : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stellar Jelly, the Astral Slime");

        }
        public override void SetDefaults()
        {
            npc.aiStyle = 15;
            npc.lifeMax = 2500;
            npc.damage = 10;
            npc.defense = 5;
            npc.knockBackResist = 0f;
            npc.width = 174;
            npc.height = 120;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            animationType = NPCID.KingSlime;
            Main.npcFrameCount[npc.type] = 6;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.Item9;
            npc.DeathSound = SoundID.NPCDeath59;
            npc.buffImmune[24] = false;
            music = MusicID.Boss2;
        }
        
    }
}