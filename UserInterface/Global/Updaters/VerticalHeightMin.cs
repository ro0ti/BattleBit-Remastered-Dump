using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Global.Updaters
{
	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	[ExecuteInEditMode]
	public class VerticalHeightMin : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06013DFB RID: 81403 RVA: 0x0007DB4C File Offset: 0x0007BD4C
		// (set) Token: 0x06013DFC RID: 81404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE7")]
		public int TickIndex8
		{
			[Token(Token = "0x6013DFB")]
			[Address(RVA = "0xA4ED60", Offset = "0xA4E160", VA = "0x180A4ED60", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013DFC")]
			[Address(RVA = "0xC59210", Offset = "0xC58610", VA = "0x180C59210", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06013DFD RID: 81405 RVA: 0x0007DB64 File Offset: 0x0007BD64
		// (set) Token: 0x06013DFE RID: 81406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE8")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013DFD")]
			[Address(RVA = "0xE82640", Offset = "0xE81A40", VA = "0x180E82640", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013DFE")]
			[Address(RVA = "0xE826D0", Offset = "0xE81AD0", VA = "0x180E826D0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013DFF RID: 81407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DFF")]
		[Address(RVA = "0x1952490", Offset = "0x1951890", VA = "0x181952490", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013E00 RID: 81408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E00")]
		[Address(RVA = "0x1952380", Offset = "0x1951780", VA = "0x181952380")]
		private void Awake()
		{
		}

		// Token: 0x06013E01 RID: 81409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E01")]
		[Address(RVA = "0x1952430", Offset = "0x1951830", VA = "0x181952430")]
		private void OnEnable()
		{
		}

		// Token: 0x06013E02 RID: 81410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E02")]
		[Address(RVA = "0x19523D0", Offset = "0x19517D0", VA = "0x1819523D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06013E03 RID: 81411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E03")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public VerticalHeightMin()
		{
		}

		// Token: 0x04003D4C RID: 15692
		[Token(Token = "0x4003D4C")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform MaxRect;

		// Token: 0x04003D4D RID: 15693
		[Token(Token = "0x4003D4D")]
		[FieldOffset(Offset = "0x20")]
		public float Min;

		// Token: 0x04003D4E RID: 15694
		[Token(Token = "0x4003D4E")]
		[FieldOffset(Offset = "0x24")]
		public float Max;

		// Token: 0x04003D4F RID: 15695
		[Token(Token = "0x4003D4F")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform rect;

		// Token: 0x04003D50 RID: 15696
		[Token(Token = "0x4003D50")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003D51 RID: 15697
		[Token(Token = "0x4003D51")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
