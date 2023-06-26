using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.MainMenu.Sub
{
	// Token: 0x02000769 RID: 1897
	[Token(Token = "0x2000769")]
	public class Depth2DBackground : MonoBehaviour
	{
		// Token: 0x06013AAA RID: 80554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AAA")]
		[Address(RVA = "0x167E870", Offset = "0x167DC70", VA = "0x18167E870")]
		private void Awake()
		{
		}

		// Token: 0x06013AAB RID: 80555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AAB")]
		[Address(RVA = "0x167E8F0", Offset = "0x167DCF0", VA = "0x18167E8F0")]
		private void Update()
		{
		}

		// Token: 0x06013AAC RID: 80556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AAC")]
		[Address(RVA = "0x167EA20", Offset = "0x167DE20", VA = "0x18167EA20")]
		public Depth2DBackground()
		{
		}

		// Token: 0x04003867 RID: 14439
		[Token(Token = "0x4003867")]
		[FieldOffset(Offset = "0x18")]
		private Color color;

		// Token: 0x04003868 RID: 14440
		[Token(Token = "0x4003868")]
		[FieldOffset(Offset = "0x28")]
		private RawImage img;

		// Token: 0x04003869 RID: 14441
		[Token(Token = "0x4003869")]
		[FieldOffset(Offset = "0x30")]
		public Color Target;

		// Token: 0x0400386A RID: 14442
		[Token(Token = "0x400386A")]
		[FieldOffset(Offset = "0x40")]
		public float speed;

		// Token: 0x0400386B RID: 14443
		[Token(Token = "0x400386B")]
		[FieldOffset(Offset = "0x44")]
		private float t;
	}
}
