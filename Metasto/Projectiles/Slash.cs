
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Metasto.Projectiles

{
    public class Slash : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "Slash"; //projectile name
            projectile.width = 70;        //projectile width
            projectile.height = 20;       //projectile height
            projectile.friendly = true;     //make that the projectile will not damage you
            projectile.melee = true;        //
            projectile.tileCollide = true; //make that the projectile won't be destroyed when it hits the terrain
            projectile.penetrate = 5;    //how many NPC will penentrate
            projectile.timeLeft = 250;   //how many time this projectile had before desepire
            projectile.light = 0.5f;      // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
			projectile.spriteDirection = projectile.direction;

        }
        public override void AI()          //this will make that the projectile will face the correct way
        {                                //| 

            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, projectile.velocity.X) + 1.57f;

        }

    }

}