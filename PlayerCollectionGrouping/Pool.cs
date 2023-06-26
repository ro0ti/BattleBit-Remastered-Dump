using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerCollectionGrouping
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	[Serializable]
	public class Pool
	{
		// Token: 0x06013EDB RID: 81627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EDB")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Pool()
		{
		}

		// Token: 0x04003E41 RID: 15937
		[Token(Token = "0x4003E41")]
		[FieldOffset(Offset = "0x10")]
		public Pool.Explosion Explosions;

		// Token: 0x04003E42 RID: 15938
		[Token(Token = "0x4003E42")]
		[FieldOffset(Offset = "0x18")]
		public Pool.Bullet Bullets;

		// Token: 0x04003E43 RID: 15939
		[Token(Token = "0x4003E43")]
		[FieldOffset(Offset = "0x20")]
		public Pool.Environment EnvironmentObjects;

		// Token: 0x04003E44 RID: 15940
		[Token(Token = "0x4003E44")]
		[FieldOffset(Offset = "0x28")]
		public Pool.Debug Debugging;

		// Token: 0x04003E45 RID: 15941
		[Token(Token = "0x4003E45")]
		[FieldOffset(Offset = "0x30")]
		public Pool.Muzzle Muzzles;

		// Token: 0x04003E46 RID: 15942
		[Token(Token = "0x4003E46")]
		[FieldOffset(Offset = "0x38")]
		public Pool.Gadget Gadgets;

		// Token: 0x04003E47 RID: 15943
		[Token(Token = "0x4003E47")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182230", Offset = "0x181630")]
		public GameObject Ping;

		// Token: 0x020007F2 RID: 2034
		[Token(Token = "0x20007F2")]
		[Serializable]
		public class Explosion
		{
			// Token: 0x06013EDC RID: 81628 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EDC")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Explosion()
			{
			}

			// Token: 0x04003E48 RID: 15944
			[Token(Token = "0x4003E48")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182330", Offset = "0x181730")]
			public GameObject[] SmallExplosions;

			// Token: 0x04003E49 RID: 15945
			[Token(Token = "0x4003E49")]
			[FieldOffset(Offset = "0x18")]
			public GameObject[] MediumExplosions;

			// Token: 0x04003E4A RID: 15946
			[Token(Token = "0x4003E4A")]
			[FieldOffset(Offset = "0x20")]
			public GameObject[] BigExplosions;

			// Token: 0x04003E4B RID: 15947
			[Token(Token = "0x4003E4B")]
			[FieldOffset(Offset = "0x28")]
			public GameObject[] BuildingExplosions;

			// Token: 0x04003E4C RID: 15948
			[Token(Token = "0x4003E4C")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182470", Offset = "0x181870")]
			public GameObject[] TankExplosions;

			// Token: 0x04003E4D RID: 15949
			[Token(Token = "0x4003E4D")]
			[FieldOffset(Offset = "0x38")]
			public GameObject[] TransportExplosions;

			// Token: 0x04003E4E RID: 15950
			[Token(Token = "0x4003E4E")]
			[FieldOffset(Offset = "0x40")]
			public GameObject[] ApcExplosions;

			// Token: 0x04003E4F RID: 15951
			[Token(Token = "0x4003E4F")]
			[FieldOffset(Offset = "0x48")]
			public GameObject[] BoatExplosions;

			// Token: 0x04003E50 RID: 15952
			[Token(Token = "0x4003E50")]
			[FieldOffset(Offset = "0x50")]
			public GameObject[] HelicopterExplosions;

			// Token: 0x04003E51 RID: 15953
			[Token(Token = "0x4003E51")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182520", Offset = "0x181920")]
			public GameObject[] VehicleImpacts;

			// Token: 0x04003E52 RID: 15954
			[Token(Token = "0x4003E52")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x1826B0", Offset = "0x181AB0")]
			public GameObject TankBlast;

			// Token: 0x04003E53 RID: 15955
			[Token(Token = "0x4003E53")]
			[FieldOffset(Offset = "0x68")]
			public GameObject RegularExplosionBlast;

			// Token: 0x04003E54 RID: 15956
			[Token(Token = "0x4003E54")]
			[FieldOffset(Offset = "0x70")]
			public GameObject ApcBlast;
		}

		// Token: 0x020007F3 RID: 2035
		[Token(Token = "0x20007F3")]
		[Serializable]
		public class Bullet
		{
			// Token: 0x06013EDD RID: 81629 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EDD")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Bullet()
			{
			}

			// Token: 0x04003E55 RID: 15957
			[Token(Token = "0x4003E55")]
			[FieldOffset(Offset = "0x10")]
			public Pool.Bullet.Shell Shells;

			// Token: 0x04003E56 RID: 15958
			[Token(Token = "0x4003E56")]
			[FieldOffset(Offset = "0x18")]
			public Pool.Bullet.Projectile Projectiles;

			// Token: 0x04003E57 RID: 15959
			[Token(Token = "0x4003E57")]
			[FieldOffset(Offset = "0x20")]
			public GameObject ArtilleryShell;

			// Token: 0x020007F4 RID: 2036
			[Token(Token = "0x20007F4")]
			[Serializable]
			public class Shell
			{
				// Token: 0x06013EDE RID: 81630 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013EDE")]
				[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
				public Shell()
				{
				}

				// Token: 0x04003E58 RID: 15960
				[Token(Token = "0x4003E58")]
				[FieldOffset(Offset = "0x10")]
				public GameObject RifleShell;

				// Token: 0x04003E59 RID: 15961
				[Token(Token = "0x4003E59")]
				[FieldOffset(Offset = "0x18")]
				public GameObject RifleConnectoredShell;

				// Token: 0x04003E5A RID: 15962
				[Token(Token = "0x4003E5A")]
				[FieldOffset(Offset = "0x20")]
				public GameObject PistolShell;

				// Token: 0x04003E5B RID: 15963
				[Token(Token = "0x4003E5B")]
				[FieldOffset(Offset = "0x28")]
				public GameObject APCShell;
			}

			// Token: 0x020007F5 RID: 2037
			[Token(Token = "0x20007F5")]
			[Serializable]
			public class Projectile
			{
				// Token: 0x06013EDF RID: 81631 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013EDF")]
				[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
				public Projectile()
				{
				}

				// Token: 0x04003E5C RID: 15964
				[Token(Token = "0x4003E5C")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "HeaderAttribute", RVA = "0x182790", Offset = "0x181B90")]
				public GameObject Bullet;

				// Token: 0x04003E5D RID: 15965
				[Token(Token = "0x4003E5D")]
				[FieldOffset(Offset = "0x18")]
				[Attribute(Name = "HeaderAttribute", RVA = "0x181A80", Offset = "0x180E80")]
				public GameObject Rocket;

				// Token: 0x04003E5E RID: 15966
				[Token(Token = "0x4003E5E")]
				[FieldOffset(Offset = "0x20")]
				[Attribute(Name = "HeaderAttribute", RVA = "0x167680", Offset = "0x166A80")]
				public GameObject TankAPShell;

				// Token: 0x04003E5F RID: 15967
				[Token(Token = "0x4003E5F")]
				[FieldOffset(Offset = "0x28")]
				public GameObject TankHeShell;

				// Token: 0x04003E60 RID: 15968
				[Token(Token = "0x4003E60")]
				[FieldOffset(Offset = "0x30")]
				[Attribute(Name = "HeaderAttribute", RVA = "0x1637D0", Offset = "0x162BD0")]
				public GameObject ExplosiveBullet;
			}
		}

		// Token: 0x020007F6 RID: 2038
		[Token(Token = "0x20007F6")]
		[Serializable]
		public class Environment
		{
			// Token: 0x06013EE0 RID: 81632 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EE0")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Environment()
			{
			}

			// Token: 0x04003E61 RID: 15969
			[Token(Token = "0x4003E61")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182A40", Offset = "0x181E40")]
			public GameObject Concrete;

			// Token: 0x04003E62 RID: 15970
			[Token(Token = "0x4003E62")]
			[FieldOffset(Offset = "0x18")]
			public GameObject Metal;

			// Token: 0x04003E63 RID: 15971
			[Token(Token = "0x4003E63")]
			[FieldOffset(Offset = "0x20")]
			public GameObject Armor;

			// Token: 0x04003E64 RID: 15972
			[Token(Token = "0x4003E64")]
			[FieldOffset(Offset = "0x28")]
			public GameObject Dirt;

			// Token: 0x04003E65 RID: 15973
			[Token(Token = "0x4003E65")]
			[FieldOffset(Offset = "0x30")]
			public GameObject Wood;

			// Token: 0x04003E66 RID: 15974
			[Token(Token = "0x4003E66")]
			[FieldOffset(Offset = "0x38")]
			public GameObject Glass;

			// Token: 0x04003E67 RID: 15975
			[Token(Token = "0x4003E67")]
			[FieldOffset(Offset = "0x40")]
			public GameObject Water;

			// Token: 0x04003E68 RID: 15976
			[Token(Token = "0x4003E68")]
			[FieldOffset(Offset = "0x48")]
			public GameObject WaterSplash;

			// Token: 0x04003E69 RID: 15977
			[Token(Token = "0x4003E69")]
			[FieldOffset(Offset = "0x50")]
			public GameObject WaterHand;

			// Token: 0x04003E6A RID: 15978
			[Token(Token = "0x4003E6A")]
			[FieldOffset(Offset = "0x58")]
			public GameObject Blood;

			// Token: 0x04003E6B RID: 15979
			[Token(Token = "0x4003E6B")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182AD0", Offset = "0x181ED0")]
			public GameObject BrokenGlass;

			// Token: 0x04003E6C RID: 15980
			[Token(Token = "0x4003E6C")]
			[FieldOffset(Offset = "0x68")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182BE0", Offset = "0x181FE0")]
			public GameObject TreeFallFoliageFx;
		}

		// Token: 0x020007F7 RID: 2039
		[Token(Token = "0x20007F7")]
		[Serializable]
		public class Debug
		{
			// Token: 0x06013EE1 RID: 81633 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EE1")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Debug()
			{
			}

			// Token: 0x04003E6D RID: 15981
			[Token(Token = "0x4003E6D")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182C70", Offset = "0x182070")]
			public GameObject DebugLinePrefab;

			// Token: 0x04003E6E RID: 15982
			[Token(Token = "0x4003E6E")]
			[FieldOffset(Offset = "0x18")]
			public Material DebugLineRed;

			// Token: 0x04003E6F RID: 15983
			[Token(Token = "0x4003E6F")]
			[FieldOffset(Offset = "0x20")]
			public Material DebugLineBlue;

			// Token: 0x04003E70 RID: 15984
			[Token(Token = "0x4003E70")]
			[FieldOffset(Offset = "0x28")]
			public Material DebugLineGreen;

			// Token: 0x04003E71 RID: 15985
			[Token(Token = "0x4003E71")]
			[FieldOffset(Offset = "0x30")]
			public Material DebugLineWhite;
		}

		// Token: 0x020007F8 RID: 2040
		[Token(Token = "0x20007F8")]
		[Serializable]
		public class Muzzle
		{
			// Token: 0x06013EE2 RID: 81634 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EE2")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Muzzle()
			{
			}

			// Token: 0x04003E72 RID: 15986
			[Token(Token = "0x4003E72")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x167180", Offset = "0x166580")]
			public GameObject[] MuzzleFlashesRemote;

			// Token: 0x04003E73 RID: 15987
			[Token(Token = "0x4003E73")]
			[FieldOffset(Offset = "0x18")]
			public GameObject[] MuzzleFlashesLocal;

			// Token: 0x04003E74 RID: 15988
			[Token(Token = "0x4003E74")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x182DF0", Offset = "0x1821F0")]
			public GameObject TankMuzzle;

			// Token: 0x04003E75 RID: 15989
			[Token(Token = "0x4003E75")]
			[FieldOffset(Offset = "0x28")]
			public GameObject ApcMuzzle;
		}

		// Token: 0x020007F9 RID: 2041
		[Token(Token = "0x20007F9")]
		[Serializable]
		public class Gadget
		{
			// Token: 0x06013EE3 RID: 81635 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EE3")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Gadget()
			{
			}

			// Token: 0x04003E76 RID: 15990
			[Token(Token = "0x4003E76")]
			[FieldOffset(Offset = "0x10")]
			public GameObject Prefab_ThrownMedicKit;
		}
	}
}
