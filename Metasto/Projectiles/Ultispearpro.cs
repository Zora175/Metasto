

using Metasto.Projectiles;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;


namespace Metasto.Projectiles

{

	public class Ultispearpro : ModProjectile

	{

		public override void SetDefaults()

		{

			projectile.CloneDefaults(66);



			aiType = 66;

		}



		public override void SetStaticDefaults()

		{

			DisplayName.SetDefault("Ultispearpro");



		}



	}

}