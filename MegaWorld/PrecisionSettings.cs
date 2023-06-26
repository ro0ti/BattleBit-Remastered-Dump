using System;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	[Serializable]
	public class PrecisionSettings
	{
		// Token: 0x0601098E RID: 67982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601098E")]
		[Address(RVA = "0x36AB890", Offset = "0x36AAC90", VA = "0x1836AB890")]
		public PrecisionSettings()
		{
		}

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x10")]
		public PrecisionObject precisionObject;

		// Token: 0x04002CE4 RID: 11492
		[Token(Token = "0x4002CE4")]
		[FieldOffset(Offset = "0x18")]
		public Quaternion orientation;

		// Token: 0x04002CE5 RID: 11493
		[Token(Token = "0x4002CE5")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 scaleFactor;

		// Token: 0x04002CE6 RID: 11494
		[Token(Token = "0x4002CE6")]
		[FieldOffset(Offset = "0x34")]
		public float angle;

		// Token: 0x04002CE7 RID: 11495
		[Token(Token = "0x4002CE7")]
		[FieldOffset(Offset = "0x38")]
		public float radius;

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 point;

		// Token: 0x04002CE9 RID: 11497
		[Token(Token = "0x4002CE9")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 fixedRotationValue;

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 fixedScaleValue;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		[FieldOffset(Offset = "0x60")]
		public \u0306\u0303\u0301\u0304\u0307\u0306\u0308\u0306\u0305\u0308\u0301\u0301\u0301\u0307\u0308 selectType;

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		[FieldOffset(Offset = "0x64")]
		public \u0304\u0305\u0302\u0303\u0306\u0305\u0306\u0303\u0305\u0305\u0306\u0306\u0305\u0307\u0304 transfromType;

		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		[FieldOffset(Offset = "0x68")]
		public \u0307\u0304\u0304\u0303\u0306\u0306\u0304\u0304\u0304\u0301\u0303\u0307\u0305\u0308\u0305 handlesType;

		// Token: 0x04002CEE RID: 11502
		[Token(Token = "0x4002CEE")]
		[FieldOffset(Offset = "0x6C")]
		public \u0305\u0307\u0307\u0306\u0303\u0306\u0306\u0303\u0304\u0302\u0301\u0302\u0306\u0303\u0301 objectTransformType;

		// Token: 0x04002CEF RID: 11503
		[Token(Token = "0x4002CEF")]
		[FieldOffset(Offset = "0x70")]
		public bool align;

		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		[FieldOffset(Offset = "0x71")]
		public bool alongStroke;

		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		[FieldOffset(Offset = "0x72")]
		public bool fixedRotation;

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x73")]
		public bool fixedScale;

		// Token: 0x04002CF3 RID: 11507
		[Token(Token = "0x4002CF3")]
		[FieldOffset(Offset = "0x74")]
		public float spacing;
	}
}
