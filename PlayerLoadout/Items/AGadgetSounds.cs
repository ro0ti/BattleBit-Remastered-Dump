using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerLoadout.Items
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	[Serializable]
	public class AGadgetSounds
	{
		// Token: 0x06011E8D RID: 73357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011E8D")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public AGadgetSounds()
		{
		}

		// Token: 0x040030F4 RID: 12532
		[Token(Token = "0x40030F4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17CD40", Offset = "0x17C140")]
		public AudioClip DrawIn;

		// Token: 0x040030F5 RID: 12533
		[Token(Token = "0x40030F5")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip DrawOut;

		// Token: 0x040030F6 RID: 12534
		[Token(Token = "0x40030F6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x191C40", Offset = "0x191040")]
		public AudioClip Reload;

		// Token: 0x040030F7 RID: 12535
		[Token(Token = "0x40030F7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x191CE0", Offset = "0x1910E0")]
		public AudioClip[] Actions;
	}
}
