using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.NPCs
{
    [AutoloadBossHead]
    public class AstrumTerr : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astrum Terr, The Earthen Star");

        }
        public override void SetDefaults()
        {
            npc.aiStyle = 10;
            npc.lifeMax = 500;
            npc.damage = 5;
            npc.defense = 0;
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 100;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            animationType = NPCID.DemonEye;
            Main.npcFrameCount[npc.type] = 2;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.Item9;
            npc.DeathSound = SoundID.NPCDeath59;
            npc.buffImmune[24] = false;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Subterranea Stella");
        }
        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            npc.ai[1]++;
            if (npc.ai[1] >= 230)
            {
                float Speed = 10f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 5;
                int type = mod.ProjectileType("TerrBoulder");
                Main.PlaySound(SoundID.Item21, (int)npc.position.X, (int)npc.position.Y);
                float rotation = (vector8 - P.Center).ToRotation();
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }
        }
    }
}