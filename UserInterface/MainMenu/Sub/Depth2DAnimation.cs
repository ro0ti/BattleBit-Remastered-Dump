using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.MainMenu.Sub
{
	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	public class Depth2DAnimation : MonoBehaviour
	{
		// Token: 0x06013AA6 RID: 80550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA6")]
		[Address(RVA = "0x167E090", Offset = "0x167D490", VA = "0x18167E090")]
		private void Awake()
		{
		}

		// Token: 0x06013AA7 RID: 80551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA7")]
		[Address(RVA = "0x167E2F0", Offset = "0x167D6F0", VA = "0x18167E2F0")]
		private void Update()
		{
		}

		// Token: 0x06013AA8 RID: 80552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA8")]
		[Address(RVA = "0x167E170", Offset = "0x167D570", VA = "0x18167E170")]
		private static void StaticUpdate()
		{
		}

		// Token: 0x06013AA9 RID: 80553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA9")]
		[Address(RVA = "0x167E7E0", Offset = "0x167DBE0", VA = "0x18167E7E0")]
		public Depth2DAnimation()
		{
		}

		// Token: 0x0400385E RID: 14430
		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0x18")]
		public float senvisity;

		// Token: 0x0400385F RID: 14431
		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0x1C")]
		public float scale;

		// Token: 0x04003860 RID: 14432
		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform tr;

		// Token: 0x04003861 RID: 14433
		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 defaultPos;

		// Token: 0x04003862 RID: 14434
		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 currentPos;

		// Token: 0x04003863 RID: 14435
		[Token(Token = "0x4003863")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 Sscale;

		// Token: 0x04003864 RID: 14436
		[Token(Token = "0x4003864")]
		[FieldOffset(Offset = "0x0")]
		public static float vertical;

		// Token: 0x04003865 RID: 14437
		[Token(Token = "0x4003865")]
		[FieldOffset(Offset = "0x4")]
		public static float horizontal;

		// Token: 0x04003866 RID: 14438
		[Token(Token = "0x4003866")]
		[FieldOffset(Offset = "0x8")]
		private static int lastFrame;
	}
}
