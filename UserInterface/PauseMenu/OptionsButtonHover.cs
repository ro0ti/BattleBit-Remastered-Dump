using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.PauseMenu
{
	// Token: 0x0200076D RID: 1901
	[Token(Token = "0x200076D")]
	public class OptionsButtonHover : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06013AB9 RID: 80569 RVA: 0x0007D03C File Offset: 0x0007B23C
		// (set) Token: 0x06013ABA RID: 80570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8F")]
		public int TickIndex8
		{
			[Token(Token = "0x6013AB9")]
			[Address(RVA = "0xA67550", Offset = "0xA66950", VA = "0x180A67550", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013ABA")]
			[Address(RVA = "0xD768A0", Offset = "0xD75CA0", VA = "0x180D768A0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06013ABB RID: 80571 RVA: 0x0007D054 File Offset: 0x0007B254
		// (set) Token: 0x06013ABC RID: 80572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B90")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013ABB")]
			[Address(RVA = "0xA90040", Offset = "0xA8F440", VA = "0x180A90040", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013ABC")]
			[Address(RVA = "0x188E020", Offset = "0x188D420", VA = "0x18188E020", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013ABD RID: 80573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013ABD")]
		[Address(RVA = "0x188DCE0", Offset = "0x188D0E0", VA = "0x18188DCE0")]
		private void Awake()
		{
		}

		// Token: 0x06013ABE RID: 80574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013ABE")]
		[Address(RVA = "0x188DDD0", Offset = "0x188D1D0", VA = "0x18188DDD0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013ABF RID: 80575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013ABF")]
		[Address(RVA = "0x188DD70", Offset = "0x188D170", VA = "0x18188DD70")]
		private void OnDisable()
		{
		}

		// Token: 0x06013AC0 RID: 80576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AC0")]
		[Address(RVA = "0x188DE30", Offset = "0x188D230", VA = "0x18188DE30", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013AC1 RID: 80577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AC1")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public OptionsButtonHover()
		{
		}

		// Token: 0x0400387A RID: 14458
		[Token(Token = "0x400387A")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform Bounds;

		// Token: 0x0400387B RID: 14459
		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x20")]
		public RawImage Hover;

		// Token: 0x0400387C RID: 14460
		[Token(Token = "0x400387C")]
		[FieldOffset(Offset = "0x28")]
		public OptionsButtonDescription TargetDescription;

		// Token: 0x0400387D RID: 14461
		[Token(Token = "0x400387D")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public bool changed;

		// Token: 0x0400387E RID: 14462
		[Token(Token = "0x400387E")]
		[FieldOffset(Offset = "0x31")]
		[HideInInspector]
		public bool mouseInside;

		// Token: 0x0400387F RID: 14463
		[Token(Token = "0x400387F")]
		[FieldOffset(Offset = "0x34")]
		private Color color;

		// Token: 0x04003880 RID: 14464
		[Token(Token = "0x4003880")]
		[FieldOffset(Offset = "0x48")]
		private RawImage rawImage;

		// Token: 0x04003881 RID: 14465
		[Token(Token = "0x4003881")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003882 RID: 14466
		[Token(Token = "0x4003882")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
