using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Extentions
{
	// Token: 0x020007CC RID: 1996
	[Token(Token = "0x20007CC")]
	public class VerticalList
	{
		// Token: 0x06013DCA RID: 81354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DCA")]
		[Address(RVA = "0x19530D0", Offset = "0x19524D0", VA = "0x1819530D0")]
		public void Update(bool useAnchor = false)
		{
		}

		// Token: 0x06013DCB RID: 81355 RVA: 0x0007DA44 File Offset: 0x0007BC44
		[Token(Token = "0x6013DCB")]
		[Address(RVA = "0x1952F20", Offset = "0x1952320", VA = "0x181952F20")]
		public Vector2 NextElementPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06013DCC RID: 81356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DCC")]
		[Address(RVA = "0x1953810", Offset = "0x1952C10", VA = "0x181953810")]
		public VerticalList()
		{
		}

		// Token: 0x04003D1E RID: 15646
		[Token(Token = "0x4003D1E")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public int ConstHeight;

		// Token: 0x04003D1F RID: 15647
		[Token(Token = "0x4003D1F")]
		[FieldOffset(Offset = "0x18")]
		public List<RectTransform> elements;

		// Token: 0x04003D20 RID: 15648
		[Token(Token = "0x4003D20")]
		[FieldOffset(Offset = "0x20")]
		public bool ToDown;

		// Token: 0x04003D21 RID: 15649
		[Token(Token = "0x4003D21")]
		[FieldOffset(Offset = "0x24")]
		public float Spacing;

		// Token: 0x04003D22 RID: 15650
		[Token(Token = "0x4003D22")]
		[FieldOffset(Offset = "0x28")]
		public bool lerp;

		// Token: 0x04003D23 RID: 15651
		[Token(Token = "0x4003D23")]
		[FieldOffset(Offset = "0x2C")]
		public float lerpSpeed;
	}
}
