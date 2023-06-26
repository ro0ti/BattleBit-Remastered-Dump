using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Extentions
{
	// Token: 0x020007C8 RID: 1992
	[Token(Token = "0x20007C8")]
	public class HorizontalList
	{
		// Token: 0x06013DB3 RID: 81331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DB3")]
		[Address(RVA = "0x1940FE0", Offset = "0x19403E0", VA = "0x181940FE0")]
		public HorizontalList(int count = 4)
		{
		}

		// Token: 0x06013DB4 RID: 81332 RVA: 0x0007D9CC File Offset: 0x0007BBCC
		[Token(Token = "0x6013DB4")]
		[Address(RVA = "0x1940900", Offset = "0x193FD00", VA = "0x181940900")]
		public float Update(bool useAnchor = false)
		{
			return 0f;
		}

		// Token: 0x06013DB5 RID: 81333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DB5")]
		[Address(RVA = "0x19406C0", Offset = "0x193FAC0", VA = "0x1819406C0")]
		public void UpdateCenter(float spacing)
		{
		}

		// Token: 0x06013DB6 RID: 81334 RVA: 0x0007D9E4 File Offset: 0x0007BBE4
		[Token(Token = "0x6013DB6")]
		[Address(RVA = "0x1940510", Offset = "0x193F910", VA = "0x181940510")]
		public Vector2 NextElementPosition()
		{
			return default(Vector2);
		}

		// Token: 0x04003D04 RID: 15620
		[Token(Token = "0x4003D04")]
		[FieldOffset(Offset = "0x10")]
		public List<RectTransform> elements;

		// Token: 0x04003D05 RID: 15621
		[Token(Token = "0x4003D05")]
		[FieldOffset(Offset = "0x18")]
		public int ConstHeight;

		// Token: 0x04003D06 RID: 15622
		[Token(Token = "0x4003D06")]
		[FieldOffset(Offset = "0x1C")]
		public bool ToRight;

		// Token: 0x04003D07 RID: 15623
		[Token(Token = "0x4003D07")]
		[FieldOffset(Offset = "0x20")]
		public float Spacing;

		// Token: 0x04003D08 RID: 15624
		[Token(Token = "0x4003D08")]
		[FieldOffset(Offset = "0x24")]
		public bool lerp;

		// Token: 0x04003D09 RID: 15625
		[Token(Token = "0x4003D09")]
		[FieldOffset(Offset = "0x28")]
		public float lerpSpeed;
	}
}
