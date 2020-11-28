using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Metasto.Projectiles
{

	public class Ultimuspro : ModProjectile

	{

		public override void SetStaticDefaults() {

			DisplayName.SetDefault("Ultimus");

		}



		public override void SetDefaults() {

			projectile.width = 29;
			projectile.height = 35;
			projectile.aiStyle = 27;
			projectile.penetrate = 5;
			projectile.scale = 1.0f;
			projectile.alpha = 0;
			projectile.melee = true;
			projectile.tileCollide = false;
			projectile.friendly = true;
			projectile.timeLeft = 1000;
            aiType = 156;
		}
		
		   public override void Kill(int timeLeft)

         {

            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 34);

            for (int k = 0; k < 16; k++)

            {

                int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 107, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, new Color(), 1f);

                Main.dust[dust].noGravity = true;
            }
       }
		
   	}
}	