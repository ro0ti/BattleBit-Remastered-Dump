using System;
using touching_your_mom;
using UnityEngine.UI;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x0200078B RID: 1931
	[Token(Token = "0x200078B")]
	public class SliderBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<float>
	{
		// Token: 0x06013BB9 RID: 80825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB9")]
		[Address(RVA = "0x18954B0", Offset = "0x18948B0", VA = "0x1818954B0", Slot = "4")]
		public override void Apply(SettingsQuality v)
		{
		}

		// Token: 0x06013BBA RID: 80826 RVA: 0x0007D36C File Offset: 0x0007B56C
		[Token(Token = "0x6013BBA")]
		[Address(RVA = "0x18955B0", Offset = "0x18949B0", VA = "0x1818955B0", Slot = "9")]
		public float Get(bool save)
		{
			return 0f;
		}

		// Token: 0x06013BBB RID: 80827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BBB")]
		[Address(RVA = "0xF957A0", Offset = "0xF94BA0", VA = "0x180F957A0", Slot = "10")]
		public void Set(float value)
		{
		}

		// Token: 0x06013BBC RID: 80828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BBC")]
		[Address(RVA = "0x1895640", Offset = "0x1894A40", VA = "0x181895640", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013BBD RID: 80829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BBD")]
		[Address(RVA = "0x1895610", Offset = "0x1894A10", VA = "0x181895610", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013BBE RID: 80830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BBE")]
		[Address(RVA = "0x1895690", Offset = "0x1894A90", VA = "0x181895690", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013BBF RID: 80831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BBF")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public SliderBehaviour()
		{
		}

		// Token: 0x04003A32 RID: 14898
		[Token(Token = "0x4003A32")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B570", Offset = "0x16A970")]
		public float DefaultValue;

		// Token: 0x04003A33 RID: 14899
		[Token(Token = "0x4003A33")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public Slider Slider;

		// Token: 0x04003A34 RID: 14900
		[Token(Token = "0x4003A34")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x14D850", Offset = "0x14CC50")]
		public bool AffectedBySettings;

		// Token: 0x04003A35 RID: 14901
		[Token(Token = "0x4003A35")]
		[FieldOffset(Offset = "0x34")]
		public float Ultra;

		// Token: 0x04003A36 RID: 14902
		[Token(Token = "0x4003A36")]
		[FieldOffset(Offset = "0x38")]
		public float High;

		// Token: 0x04003A37 RID: 14903
		[Token(Token = "0x4003A37")]
		[FieldOffset(Offset = "0x3C")]
		public float Medium;

		// Token: 0x04003A38 RID: 14904
		[Token(Token = "0x4003A38")]
		[FieldOffset(Offset = "0x40")]
		public float Low;

		// Token: 0x04003A39 RID: 14905
		[Token(Token = "0x4003A39")]
		[FieldOffset(Offset = "0x44")]
		public float Potato;
	}
}
