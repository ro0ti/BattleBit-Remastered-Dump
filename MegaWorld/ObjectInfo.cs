using System;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	[Serializable]
	public class ObjectInfo
	{
		// Token: 0x06010018 RID: 65560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010018")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public ObjectInfo()
		{
		}

		// Token: 0x06010019 RID: 65561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010019")]
		[Address(RVA = "0x36A6190", Offset = "0x36A5590", VA = "0x1836A6190")]
		public ObjectInfo(GameObject \u0303\u0302\u0307\u0301\u0302\u0308\u0303\u0302\u0304\u0303\u0306\u0305\u0303\u0305\u0307, Bounds \u0304\u0301\u0307\u0307\u0308\u0305\u0304\u0304\u0304\u0305\u0308\u0307\u0305\u0303\u0304)
		{
		}

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x10")]
		public GameObject parentObject;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x18")]
		public Bounds bounds;
	}
}
