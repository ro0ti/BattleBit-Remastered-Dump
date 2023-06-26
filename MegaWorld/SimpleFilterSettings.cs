using System;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x02000609 RID: 1545
	[Token(Token = "0x2000609")]
	[Serializable]
	public class SimpleFilterSettings
	{
		// Token: 0x06010A70 RID: 68208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010A70")]
		[Address(RVA = "0x374F220", Offset = "0x374E620", VA = "0x18374F220")]
		public SimpleFilterSettings()
		{
		}

		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		[FieldOffset(Offset = "0x10")]
		public bool enableSpawnVisualization;

		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		[FieldOffset(Offset = "0x11")]
		public bool visualizeArea;

		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		[FieldOffset(Offset = "0x14")]
		public int visualiserResolution;

		// Token: 0x04002D1C RID: 11548
		[Token(Token = "0x4002D1C")]
		[FieldOffset(Offset = "0x18")]
		public float customHandleSize;

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x1C")]
		public \u0308\u0304\u0305\u0308\u0305\u0302\u0304\u0306\u0305\u0304\u0301\u0301\u0307\u0304\u0305 handlesType;

		// Token: 0x04002D1E RID: 11550
		[Token(Token = "0x4002D1E")]
		[FieldOffset(Offset = "0x20")]
		public \u0308\u0307\u0302\u0305\u0307\u0306\u0302\u0308\u0307\u0304\u0301\u0303\u0301\u0307\u0301 handleResizingType;

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x24")]
		public \u0306\u0308\u0306\u0303\u0304\u0303\u0301\u0302\u0305\u0304\u0301\u0302\u0308\u0306\u0306 colorHandlesType;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x13EA00", Offset = "0x13DE00")]
		public float alpha;

		// Token: 0x04002D21 RID: 11553
		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x2C")]
		public Color activeColor;

		// Token: 0x04002D22 RID: 11554
		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x3C")]
		public Color inactiveColor;
	}
}
