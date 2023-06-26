using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Extentions
{
	// Token: 0x020007CD RID: 1997
	[Token(Token = "0x20007CD")]
	[ExecuteInEditMode]
	public class VerticalListMono : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x06013DCD RID: 81357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DCD")]
		[Address(RVA = "0x1952800", Offset = "0x1951C00", VA = "0x181952800")]
		private void OnEnable()
		{
		}

		// Token: 0x06013DCE RID: 81358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DCE")]
		[Address(RVA = "0x19527A0", Offset = "0x1951BA0", VA = "0x1819527A0")]
		private void OnDisable()
		{
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06013DCF RID: 81359 RVA: 0x0007DA5C File Offset: 0x0007BC5C
		// (set) Token: 0x06013DD0 RID: 81360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDF")]
		public int TickIndex8
		{
			[Token(Token = "0x6013DCF")]
			[Address(RVA = "0xA13840", Offset = "0xA12C40", VA = "0x180A13840", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013DD0")]
			[Address(RVA = "0xCA3840", Offset = "0xCA2C40", VA = "0x180CA3840", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06013DD1 RID: 81361 RVA: 0x0007DA74 File Offset: 0x0007BC74
		// (set) Token: 0x06013DD2 RID: 81362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE0")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013DD1")]
			[Address(RVA = "0xDFA3C0", Offset = "0xDF97C0", VA = "0x180DFA3C0", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013DD2")]
			[Address(RVA = "0xDFA430", Offset = "0xDF9830", VA = "0x180DFA430", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013DD3 RID: 81363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DD3")]
		[Address(RVA = "0x1952860", Offset = "0x1951C60", VA = "0x181952860", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013DD4 RID: 81364 RVA: 0x0007DA8C File Offset: 0x0007BC8C
		[Token(Token = "0x6013DD4")]
		[Address(RVA = "0x19525F0", Offset = "0x19519F0", VA = "0x1819525F0")]
		public Vector2 NextElementPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06013DD5 RID: 81365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DD5")]
		[Address(RVA = "0x1952CC0", Offset = "0x19520C0", VA = "0x181952CC0")]
		public VerticalListMono()
		{
		}

		// Token: 0x04003D24 RID: 15652
		[Token(Token = "0x4003D24")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[NonSerialized]
		public int ConstHeight;

		// Token: 0x04003D25 RID: 15653
		[Token(Token = "0x4003D25")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16A250", Offset = "0x169650")]
		public List<RectTransform> elements;

		// Token: 0x04003D26 RID: 15654
		[Token(Token = "0x4003D26")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x14D850", Offset = "0x14CC50")]
		public float Margin;

		// Token: 0x04003D27 RID: 15655
		[Token(Token = "0x4003D27")]
		[FieldOffset(Offset = "0x2C")]
		public bool ToDown;

		// Token: 0x04003D28 RID: 15656
		[Token(Token = "0x4003D28")]
		[FieldOffset(Offset = "0x30")]
		public float Spacing;

		// Token: 0x04003D29 RID: 15657
		[Token(Token = "0x4003D29")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17D1F0", Offset = "0x17C5F0")]
		public bool lerp;

		// Token: 0x04003D2A RID: 15658
		[Token(Token = "0x4003D2A")]
		[FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		// Token: 0x04003D2B RID: 15659
		[Token(Token = "0x4003D2B")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17DBE0", Offset = "0x17CFE0")]
		public bool ApplyToCurrentRectTransform;

		// Token: 0x04003D2C RID: 15660
		[Token(Token = "0x4003D2C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003D2D RID: 15661
		[Token(Token = "0x4003D2D")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
