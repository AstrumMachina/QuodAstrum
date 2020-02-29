using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Projectiles
{
    public class SerenadeShot : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 40;
            projectile.melee = true;
            projectile.penetrate = 1000;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.alpha = 0;
            projectile.light = 5f;
            projectile.extraUpdates = 1;
            projectile.timeLeft = 1000;
        }
        public override void AI()
        {
         projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;

        }
    }
}