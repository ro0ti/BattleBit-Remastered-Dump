using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Extentions
{
	// Token: 0x020007C9 RID: 1993
	[Token(Token = "0x20007C9")]
	[ExecuteInEditMode]
	public class HorizontallListMono : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x06013DB7 RID: 81335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DB7")]
		[Address(RVA = "0x1941280", Offset = "0x1940680", VA = "0x181941280")]
		private void OnEnable()
		{
		}

		// Token: 0x06013DB8 RID: 81336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DB8")]
		[Address(RVA = "0x1941220", Offset = "0x1940620", VA = "0x181941220")]
		private void OnDisable()
		{
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06013DB9 RID: 81337 RVA: 0x0007D9FC File Offset: 0x0007BBFC
		// (set) Token: 0x06013DBA RID: 81338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDD")]
		public int TickIndex8
		{
			[Token(Token = "0x6013DB9")]
			[Address(RVA = "0x9CDCC0", Offset = "0x9CD0C0", VA = "0x1809CDCC0", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013DBA")]
			[Address(RVA = "0x9BB080", Offset = "0x9BA480", VA = "0x1809BB080", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06013DBB RID: 81339 RVA: 0x0007DA14 File Offset: 0x0007BC14
		// (set) Token: 0x06013DBC RID: 81340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDE")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013DBB")]
			[Address(RVA = "0x91AC30", Offset = "0x91A030", VA = "0x18091AC30", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013DBC")]
			[Address(RVA = "0x9BB070", Offset = "0x9BA470", VA = "0x1809BB070", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013DBD RID: 81341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DBD")]
		[Address(RVA = "0x19412E0", Offset = "0x19406E0", VA = "0x1819412E0", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013DBE RID: 81342 RVA: 0x0007DA2C File Offset: 0x0007BC2C
		[Token(Token = "0x6013DBE")]
		[Address(RVA = "0x1941070", Offset = "0x1940470", VA = "0x181941070")]
		public Vector2 NextElementPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06013DBF RID: 81343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DBF")]
		[Address(RVA = "0x19416C0", Offset = "0x1940AC0", VA = "0x1819416C0")]
		public HorizontallListMono()
		{
		}

		// Token: 0x04003D0A RID: 15626
		[Token(Token = "0x4003D0A")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[NonSerialized]
		public int ConstHeight;

		// Token: 0x04003D0B RID: 15627
		[Token(Token = "0x4003D0B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16A250", Offset = "0x169650")]
		public List<RectTransform> elements;

		// Token: 0x04003D0C RID: 15628
		[Token(Token = "0x4003D0C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x14D850", Offset = "0x14CC50")]
		public bool ToRight;

		// Token: 0x04003D0D RID: 15629
		[Token(Token = "0x4003D0D")]
		[FieldOffset(Offset = "0x2C")]
		public float Spacing;

		// Token: 0x04003D0E RID: 15630
		[Token(Token = "0x4003D0E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17D1F0", Offset = "0x17C5F0")]
		public bool lerp;

		// Token: 0x04003D0F RID: 15631
		[Token(Token = "0x4003D0F")]
		[FieldOffset(Offset = "0x34")]
		public float lerpSpeed;

		// Token: 0x04003D10 RID: 15632
		[Token(Token = "0x4003D10")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003D11 RID: 15633
		[Token(Token = "0x4003D11")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
