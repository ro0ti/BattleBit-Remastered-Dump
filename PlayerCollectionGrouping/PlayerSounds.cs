using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerCollectionGrouping
{
	// Token: 0x020007EB RID: 2027
	[Token(Token = "0x20007EB")]
	[Serializable]
	public class PlayerSounds
	{
		// Token: 0x06013E5E RID: 81502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E5E")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public PlayerSounds()
		{
		}

		// Token: 0x04003E11 RID: 15889
		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181630", Offset = "0x180A30")]
		public Mixers AudioMixers;

		// Token: 0x04003E12 RID: 15890
		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1816B0", Offset = "0x180AB0")]
		public Footsteps Footsteps;

		// Token: 0x04003E13 RID: 15891
		[Token(Token = "0x4003E13")]
		[FieldOffset(Offset = "0x20")]
		public MovementShakes Shakes;

		// Token: 0x04003E14 RID: 15892
		[Token(Token = "0x4003E14")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181800", Offset = "0x180C00")]
		public AudioClip[] FleshBodyHits;

		// Token: 0x04003E15 RID: 15893
		[Token(Token = "0x4003E15")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip[] HitClips;

		// Token: 0x04003E16 RID: 15894
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip[] ArmorHitClips;

		// Token: 0x04003E17 RID: 15895
		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x40")]
		public AudioClip[] Ricochets;

		// Token: 0x04003E18 RID: 15896
		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x180F10", Offset = "0x180310")]
		public FoliageItem[] FoliageItems;

		// Token: 0x04003E19 RID: 15897
		[Token(Token = "0x4003E19")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip[] TreeFalls;

		// Token: 0x04003E1A RID: 15898
		[Token(Token = "0x4003E1A")]
		[FieldOffset(Offset = "0x58")]
		public AudioClip[] TreeFallings;

		// Token: 0x04003E1B RID: 15899
		[Token(Token = "0x4003E1B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x167180", Offset = "0x166580")]
		public AudioClip[] DryFires;

		// Token: 0x04003E1C RID: 15900
		[Token(Token = "0x4003E1C")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip[] FireModeChanges;

		// Token: 0x04003E1D RID: 15901
		[Token(Token = "0x4003E1D")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip[] MagazineCombine;

		// Token: 0x04003E1E RID: 15902
		[Token(Token = "0x4003E1E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169060", Offset = "0x168460")]
		public AudioClip RadioStart;

		// Token: 0x04003E1F RID: 15903
		[Token(Token = "0x4003E1F")]
		[FieldOffset(Offset = "0x80")]
		public AudioClip RadioEnd;

		// Token: 0x04003E20 RID: 15904
		[Token(Token = "0x4003E20")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181A80", Offset = "0x180E80")]
		public PlayerSounds.Gadgets GadgetSounds;

		// Token: 0x04003E21 RID: 15905
		[Token(Token = "0x4003E21")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17CD40", Offset = "0x17C140")]
		public AudioClip[] OnKill;

		// Token: 0x04003E22 RID: 15906
		[Token(Token = "0x4003E22")]
		[FieldOffset(Offset = "0x98")]
		public AudioClip[] FireBass;

		// Token: 0x04003E23 RID: 15907
		[Token(Token = "0x4003E23")]
		[FieldOffset(Offset = "0xA0")]
		public AudioClip[] EndFire;

		// Token: 0x04003E24 RID: 15908
		[Token(Token = "0x4003E24")]
		[FieldOffset(Offset = "0xA8")]
		public AudioClip[] PlaytestShots;

		// Token: 0x04003E25 RID: 15909
		[Token(Token = "0x4003E25")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181C20", Offset = "0x181020")]
		public AudioClip OnBalanceChange;

		// Token: 0x04003E26 RID: 15910
		[Token(Token = "0x4003E26")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181DA0", Offset = "0x1811A0")]
		public AudioClip GameAboutToEnd;

		// Token: 0x04003E27 RID: 15911
		[Token(Token = "0x4003E27")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x181E00", Offset = "0x181200")]
		public AudioClip[] BrickFew;

		// Token: 0x04003E28 RID: 15912
		[Token(Token = "0x4003E28")]
		[FieldOffset(Offset = "0xC8")]
		public AudioClip[] BrickMedium;

		// Token: 0x04003E29 RID: 15913
		[Token(Token = "0x4003E29")]
		[FieldOffset(Offset = "0xD0")]
		public AudioClip[] BrickMany;

		// Token: 0x04003E2A RID: 15914
		[Token(Token = "0x4003E2A")]
		[FieldOffset(Offset = "0xD8")]
		public AudioClip[] BrickCollisionFew;

		// Token: 0x04003E2B RID: 15915
		[Token(Token = "0x4003E2B")]
		[FieldOffset(Offset = "0xE0")]
		public AudioClip[] BrickCollisionMedium;

		// Token: 0x04003E2C RID: 15916
		[Token(Token = "0x4003E2C")]
		[FieldOffset(Offset = "0xE8")]
		public AudioClip[] BrickCollisionMany;

		// Token: 0x04003E2D RID: 15917
		[Token(Token = "0x4003E2D")]
		[FieldOffset(Offset = "0xF0")]
		public AudioClip[] BrickGrounded;

		// Token: 0x020007EC RID: 2028
		[Token(Token = "0x20007EC")]
		[Serializable]
		public class Gadgets
		{
			// Token: 0x06013E5F RID: 81503 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E5F")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Gadgets()
			{
			}

			// Token: 0x04003E2E RID: 15918
			[Token(Token = "0x4003E2E")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSounds.Gadgets.Throwable ThrowableObjects;

			// Token: 0x04003E2F RID: 15919
			[Token(Token = "0x4003E2F")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x181F60", Offset = "0x181360")]
			public AudioClip[] C4Trigger;

			// Token: 0x04003E30 RID: 15920
			[Token(Token = "0x4003E30")]
			[FieldOffset(Offset = "0x20")]
			public AudioClip[] C4Throw;

			// Token: 0x020007ED RID: 2029
			[Token(Token = "0x20007ED")]
			[Serializable]
			public class Throwable
			{
				// Token: 0x06013E60 RID: 81504 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013E60")]
				[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
				public Throwable()
				{
				}

				// Token: 0x04003E31 RID: 15921
				[Token(Token = "0x4003E31")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "HeaderAttribute", RVA = "0x181FF0", Offset = "0x1813F0")]
				public AudioClip[] SmokeOnThrown;
			}
		}
	}
}
