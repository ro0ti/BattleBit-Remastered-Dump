using System;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	[Serializable]
	public abstract class Prototype
	{
		// Token: 0x06010428 RID: 66600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010428")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		protected Prototype()
		{
		}

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		// Token: 0x04002C07 RID: 11271
		[Token(Token = "0x4002C07")]
		[FieldOffset(Offset = "0x18")]
		public bool selected;
	}
}
