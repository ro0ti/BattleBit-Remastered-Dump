using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Global.Resources
{
	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x20007D9")]
	[Serializable]
	public class GlobalUI
	{
		// Token: 0x06013E16 RID: 81430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E16")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public GlobalUI()
		{
		}

		// Token: 0x04003D59 RID: 15705
		[Token(Token = "0x4003D59")]
		[FieldOffset(Offset = "0x10")]
		public GameObject UIPrefab;

		// Token: 0x04003D5A RID: 15706
		[Token(Token = "0x4003D5A")]
		[FieldOffset(Offset = "0x18")]
		public Material MaskedMapUI;
	}
}
