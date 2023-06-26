using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerLoadout.Items
{
	// Token: 0x0200067F RID: 1663
	[Token(Token = "0x200067F")]
	[Serializable]
	public class WeaponAssetAnimations
	{
		// Token: 0x06011F84 RID: 73604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F84")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public WeaponAssetAnimations()
		{
		}

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17D970", Offset = "0x17CD70")]
		public AnimationClip BoltAction;
	}
}
