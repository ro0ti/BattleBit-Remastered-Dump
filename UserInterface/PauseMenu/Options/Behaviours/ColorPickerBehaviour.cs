using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x02000785 RID: 1925
	[Token(Token = "0x2000785")]
	public class ColorPickerBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<Color>
	{
		// Token: 0x06013B81 RID: 80769 RVA: 0x0007D2F4 File Offset: 0x0007B4F4
		[Token(Token = "0x6013B81")]
		[Address(RVA = "0x1880790", Offset = "0x187FB90", VA = "0x181880790", Slot = "9")]
		public Color Get(bool save = false)
		{
			return default(Color);
		}

		// Token: 0x06013B82 RID: 80770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B82")]
		[Address(RVA = "0x18808B0", Offset = "0x187FCB0", VA = "0x1818808B0", Slot = "10")]
		public void Set(Color value)
		{
		}

		// Token: 0x06013B83 RID: 80771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B83")]
		[Address(RVA = "0x1880820", Offset = "0x187FC20", VA = "0x181880820", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013B84 RID: 80772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B84")]
		[Address(RVA = "0x1880800", Offset = "0x187FC00", VA = "0x181880800", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013B85 RID: 80773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B85")]
		[Address(RVA = "0x1880870", Offset = "0x187FC70", VA = "0x181880870", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013B86 RID: 80774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B86")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public ColorPickerBehaviour()
		{
		}

		// Token: 0x04003A09 RID: 14857
		[Token(Token = "0x4003A09")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B570", Offset = "0x16A970")]
		public Color DefaultValue;

		// Token: 0x04003A0A RID: 14858
		[Token(Token = "0x4003A0A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public ColorPicker Picker;
	}
}
