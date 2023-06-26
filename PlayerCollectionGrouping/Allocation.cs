using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerCollectionGrouping
{
	// Token: 0x02000802 RID: 2050
	[Token(Token = "0x2000802")]
	[Serializable]
	public class Allocation
	{
		// Token: 0x06013EEC RID: 81644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EEC")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Allocation()
		{
		}

		// Token: 0x04003EA7 RID: 16039
		[Token(Token = "0x4003EA7")]
		[FieldOffset(Offset = "0x10")]
		public GameObject[] Prefabs;

		// Token: 0x04003EA8 RID: 16040
		[Token(Token = "0x4003EA8")]
		[FieldOffset(Offset = "0x18")]
		public int Count;
	}
}
