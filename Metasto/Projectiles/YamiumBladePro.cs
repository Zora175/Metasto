
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Metasto.Projectiles

{
    public class YamiumBladePro : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "YamiumBladePro"; //projectile name
            projectile.width = 117;        //projectile width
            projectile.height = 65;       //projectile height
            projectile.friendly = true;     //make that the projectile will not damage you
            projectile.melee = true;        //
            projectile.tileCollide = false; //make that the projectile won't be destroyed when it hits the terrain
            projectile.penetrate = 20;    //how many NPC will penentrate
            projectile.timeLeft = 1000;   
            projectile.light = 0.75f;      // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;

        }
        public override void AI()          //this will make that the projectile will face the correct way
        {                               
            
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, projectile.velocity.X) + 1.57f;
        }

    }

}