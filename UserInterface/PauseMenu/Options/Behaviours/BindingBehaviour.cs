using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	public class BindingBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<KeyCode>
	{
		// Token: 0x06013B7B RID: 80763 RVA: 0x0007D2DC File Offset: 0x0007B4DC
		[Token(Token = "0x6013B7B")]
		[Address(RVA = "0x187F540", Offset = "0x187E940", VA = "0x18187F540", Slot = "9")]
		public KeyCode Get(bool save = false)
		{
			return KeyCode.None;
		}

		// Token: 0x06013B7C RID: 80764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B7C")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "10")]
		public void Set(KeyCode value)
		{
		}

		// Token: 0x06013B7D RID: 80765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B7D")]
		[Address(RVA = "0x187F600", Offset = "0x187EA00", VA = "0x18187F600", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013B7E RID: 80766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B7E")]
		[Address(RVA = "0x187F570", Offset = "0x187E970", VA = "0x18187F570", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013B7F RID: 80767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B7F")]
		[Address(RVA = "0x187F7C0", Offset = "0x187EBC0", VA = "0x18187F7C0", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013B80 RID: 80768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B80")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public BindingBehaviour()
		{
		}

		// Token: 0x040039DE RID: 14814
		[Token(Token = "0x40039DE")]
		[FieldOffset(Offset = "0x20")]
		public bool isDefaultAxisA;

		// Token: 0x040039DF RID: 14815
		[Token(Token = "0x40039DF")]
		[FieldOffset(Offset = "0x21")]
		public bool isDefaultAxisB;

		// Token: 0x040039E0 RID: 14816
		[Token(Token = "0x40039E0")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B3E0", Offset = "0x16A7E0")]
		public KeyCode DefaultValueA;

		// Token: 0x040039E1 RID: 14817
		[Token(Token = "0x40039E1")]
		[FieldOffset(Offset = "0x28")]
		public KeyCode DefaultValueB;

		// Token: 0x040039E2 RID: 14818
		[Token(Token = "0x40039E2")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B510", Offset = "0x16A910")]
		public InputAxis DefaultAxisA;

		// Token: 0x040039E3 RID: 14819
		[Token(Token = "0x40039E3")]
		[FieldOffset(Offset = "0x30")]
		public InputAxis DefaultAxisB;

		// Token: 0x040039E4 RID: 14820
		[Token(Token = "0x40039E4")]
		[FieldOffset(Offset = "0x34")]
		public bool defaultAxisAPositive;

		// Token: 0x040039E5 RID: 14821
		[Token(Token = "0x40039E5")]
		[FieldOffset(Offset = "0x35")]
		public bool defaultAxisBPositive;

		// Token: 0x040039E6 RID: 14822
		[Token(Token = "0x40039E6")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public Binding BinderA;

		// Token: 0x040039E7 RID: 14823
		[Token(Token = "0x40039E7")]
		[FieldOffset(Offset = "0x40")]
		public Binding BinderB;
	}
}
