using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	public class ToggleBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<bool>
	{
		// Token: 0x06013BC0 RID: 80832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC0")]
		[Address(RVA = "0x1895720", Offset = "0x1894B20", VA = "0x181895720")]
		private void Awake()
		{
		}

		// Token: 0x06013BC1 RID: 80833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC1")]
		[Address(RVA = "0x1895980", Offset = "0x1894D80", VA = "0x181895980")]
		private void OnValueChanged(bool arg0)
		{
		}

		// Token: 0x06013BC2 RID: 80834 RVA: 0x0007D384 File Offset: 0x0007B584
		[Token(Token = "0x6013BC2")]
		[Address(RVA = "0x18957C0", Offset = "0x1894BC0", VA = "0x1818957C0", Slot = "9")]
		public bool Get(bool save = false)
		{
			return default(bool);
		}

		// Token: 0x06013BC3 RID: 80835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC3")]
		[Address(RVA = "0x1895AF0", Offset = "0x1894EF0", VA = "0x181895AF0", Slot = "10")]
		public void Set(bool value)
		{
		}

		// Token: 0x06013BC4 RID: 80836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC4")]
		[Address(RVA = "0x18956C0", Offset = "0x1894AC0", VA = "0x1818956C0", Slot = "4")]
		public override void Apply(SettingsQuality v)
		{
		}

		// Token: 0x06013BC5 RID: 80837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC5")]
		[Address(RVA = "0x18958C0", Offset = "0x1894CC0", VA = "0x1818958C0", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013BC6 RID: 80838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC6")]
		[Address(RVA = "0x18958B0", Offset = "0x1894CB0", VA = "0x1818958B0", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013BC7 RID: 80839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC7")]
		[Address(RVA = "0x1895A40", Offset = "0x1894E40", VA = "0x181895A40", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013BC8 RID: 80840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BC8")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public ToggleBehaviour()
		{
		}

		// Token: 0x04003A3A RID: 14906
		[Token(Token = "0x4003A3A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B570", Offset = "0x16A970")]
		public bool UseConfigFile;

		// Token: 0x04003A3B RID: 14907
		[Token(Token = "0x4003A3B")]
		[FieldOffset(Offset = "0x21")]
		public bool DefaultValue;

		// Token: 0x04003A3C RID: 14908
		[Token(Token = "0x4003A3C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public Toggle Toggle;

		// Token: 0x04003A3D RID: 14909
		[Token(Token = "0x4003A3D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16BF40", Offset = "0x16B340")]
		public GameObject[] Dependeds;

		// Token: 0x04003A3E RID: 14910
		[Token(Token = "0x4003A3E")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent OnToggleOn;

		// Token: 0x04003A3F RID: 14911
		[Token(Token = "0x4003A3F")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent OnToggleOff;

		// Token: 0x04003A40 RID: 14912
		[Token(Token = "0x4003A40")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16C050", Offset = "0x16B450")]
		public UnityEvent OnUserToggleOn;

		// Token: 0x04003A41 RID: 14913
		[Token(Token = "0x4003A41")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnUserToggleOff;

		// Token: 0x04003A42 RID: 14914
		[Token(Token = "0x4003A42")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x14D850", Offset = "0x14CC50")]
		public bool AffectedBySettings;

		// Token: 0x04003A43 RID: 14915
		[Token(Token = "0x4003A43")]
		[FieldOffset(Offset = "0x59")]
		public bool Ultra;

		// Token: 0x04003A44 RID: 14916
		[Token(Token = "0x4003A44")]
		[FieldOffset(Offset = "0x5A")]
		public bool High;

		// Token: 0x04003A45 RID: 14917
		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0x5B")]
		public bool Medium;

		// Token: 0x04003A46 RID: 14918
		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0x5C")]
		public bool Low;

		// Token: 0x04003A47 RID: 14919
		[Token(Token = "0x4003A47")]
		[FieldOffset(Offset = "0x5D")]
		public bool Potato;
	}
}
