using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerCollectionGrouping
{
	// Token: 0x020007FB RID: 2043
	[Token(Token = "0x20007FB")]
	[Serializable]
	public class Curves
	{
		// Token: 0x06013EE5 RID: 81637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EE5")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Curves()
		{
		}

		// Token: 0x04003E8A RID: 16010
		[Token(Token = "0x4003E8A")]
		[FieldOffset(Offset = "0x10")]
		public Curves.Aiming AimingCurves;

		// Token: 0x04003E8B RID: 16011
		[Token(Token = "0x4003E8B")]
		[FieldOffset(Offset = "0x18")]
		public Curves.Hearthbeat HearthbeatCurves;

		// Token: 0x04003E8C RID: 16012
		[Token(Token = "0x4003E8C")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve VehicleFallOff;

		// Token: 0x04003E8D RID: 16013
		[Token(Token = "0x4003E8D")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve ShotSoundsFallOff;

		// Token: 0x020007FC RID: 2044
		[Token(Token = "0x20007FC")]
		[Serializable]
		public class Aiming
		{
			// Token: 0x06013EE6 RID: 81638 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EE6")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Aiming()
			{
			}

			// Token: 0x04003E8E RID: 16014
			[Token(Token = "0x4003E8E")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x183170", Offset = "0x182570")]
			public AnimationCurve PrimaryHorizontal;

			// Token: 0x04003E8F RID: 16015
			[Token(Token = "0x4003E8F")]
			[FieldOffset(Offset = "0x18")]
			public AnimationCurve PrimaryVertical;

			// Token: 0x04003E90 RID: 16016
			[Token(Token = "0x4003E90")]
			[FieldOffset(Offset = "0x20")]
			public AnimationCurve PrimaryDepth;

			// Token: 0x04003E91 RID: 16017
			[Token(Token = "0x4003E91")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x1831F0", Offset = "0x1825F0")]
			public AnimationCurve SecondaryHorizontal;

			// Token: 0x04003E92 RID: 16018
			[Token(Token = "0x4003E92")]
			[FieldOffset(Offset = "0x30")]
			public AnimationCurve SecondaryVertical;

			// Token: 0x04003E93 RID: 16019
			[Token(Token = "0x4003E93")]
			[FieldOffset(Offset = "0x38")]
			public AnimationCurve SecondaryDepth;
		}

		// Token: 0x020007FD RID: 2045
		[Token(Token = "0x20007FD")]
		[Serializable]
		public class Hearthbeat
		{
			// Token: 0x06013EE7 RID: 81639 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EE7")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Hearthbeat()
			{
			}

			// Token: 0x04003E94 RID: 16020
			[Token(Token = "0x4003E94")]
			[FieldOffset(Offset = "0x10")]
			public AnimationCurve SingleHeathbeat;
		}
	}
}
