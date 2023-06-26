using System;
using touching_your_mom;

namespace MegaWorld
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	[Serializable]
	public class PrecisionObject
	{
		// Token: 0x060101C0 RID: 65984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60101C0")]
		[Address(RVA = "0x8FB6A0", Offset = "0x8FAAA0", VA = "0x1808FB6A0")]
		public PrecisionObject(ObjectInfo \u0301\u0303\u0306\u0302\u0306\u0306\u0306\u0307\u0308\u0308\u0305\u0302\u0305\u0307\u0305, RaycastInfo \u0307\u0302\u0308\u0307\u0303\u0301\u0306\u0302\u0302\u0303\u0304\u0303\u0302\u0308\u0303)
		{
		}

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		[FieldOffset(Offset = "0x10")]
		public ObjectInfo objectInfo;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x18")]
		public RaycastInfo raycastInfo;
	}
}
