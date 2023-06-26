using System;
using touching_your_mom;
using TMPro;
using UnityEngine.UI;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x02000787 RID: 1927
	[Token(Token = "0x2000787")]
	public class EnumBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<int>
	{
		// Token: 0x06013B90 RID: 80784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B90")]
		[Address(RVA = "0x18882E0", Offset = "0x18876E0", VA = "0x1818882E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x16B7D0", Offset = "0x16ABD0")]
		private void mAssign()
		{
		}

		// Token: 0x06013B91 RID: 80785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B91")]
		[Address(RVA = "0x1887C90", Offset = "0x1887090", VA = "0x181887C90", Slot = "4")]
		public override void Apply(SettingsQuality v)
		{
		}

		// Token: 0x06013B92 RID: 80786 RVA: 0x0007D324 File Offset: 0x0007B524
		[Token(Token = "0x6013B92")]
		[Address(RVA = "0x1887D10", Offset = "0x1887110", VA = "0x181887D10", Slot = "9")]
		public int Get(bool save = false)
		{
			return 0;
		}

		// Token: 0x06013B93 RID: 80787 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B93")]
		public T GetAsEnum<T>(bool save = false)
		{
			return null;
		}

		// Token: 0x06013B94 RID: 80788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B94")]
		[Address(RVA = "0x1888250", Offset = "0x1887650", VA = "0x181888250", Slot = "10")]
		public void Set(int value)
		{
		}

		// Token: 0x06013B95 RID: 80789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B95")]
		[Address(RVA = "0x1887F40", Offset = "0x1887340", VA = "0x181887F40", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013B96 RID: 80790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B96")]
		[Address(RVA = "0x1887D60", Offset = "0x1887160", VA = "0x181887D60", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013B97 RID: 80791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B97")]
		[Address(RVA = "0x1887FE0", Offset = "0x18873E0", VA = "0x181887FE0", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013B98 RID: 80792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B98")]
		[Address(RVA = "0x1887F80", Offset = "0x1887380", VA = "0x181887F80")]
		public void OnNextPressed()
		{
		}

		// Token: 0x06013B99 RID: 80793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B99")]
		[Address(RVA = "0x1887FB0", Offset = "0x18873B0", VA = "0x181887FB0")]
		public void OnPreviousPressed()
		{
		}

		// Token: 0x06013B9A RID: 80794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B9A")]
		[Address(RVA = "0x1888000", Offset = "0x1887400", VA = "0x181888000")]
		private void SetVisual(int index)
		{
		}

		// Token: 0x06013B9B RID: 80795 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B9B")]
		[Address(RVA = "0x1888460", Offset = "0x1887860", VA = "0x181888460")]
		private string process(string word)
		{
			return null;
		}

		// Token: 0x06013B9C RID: 80796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B9C")]
		[Address(RVA = "0x1887DA0", Offset = "0x18871A0", VA = "0x181887DA0")]
		private void LoadEnum()
		{
		}

		// Token: 0x06013B9D RID: 80797 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B9D")]
		public static T GetFromIndex<T>(int index)
		{
			return null;
		}

		// Token: 0x06013B9E RID: 80798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B9E")]
		[Address(RVA = "0x1888260", Offset = "0x1887660", VA = "0x181888260")]
		public EnumBehaviour()
		{
		}

		// Token: 0x04003A0F RID: 14863
		[Token(Token = "0x4003A0F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B570", Offset = "0x16A970")]
		public int DefaultValue;

		// Token: 0x04003A10 RID: 14864
		[Token(Token = "0x4003A10")]
		[FieldOffset(Offset = "0x28")]
		public string AssemblyType;

		// Token: 0x04003A11 RID: 14865
		[Token(Token = "0x4003A11")]
		[FieldOffset(Offset = "0x30")]
		public string EnumType;

		// Token: 0x04003A12 RID: 14866
		[Token(Token = "0x4003A12")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public TextMeshProUGUI Label;

		// Token: 0x04003A13 RID: 14867
		[Token(Token = "0x4003A13")]
		[FieldOffset(Offset = "0x40")]
		public Button Next;

		// Token: 0x04003A14 RID: 14868
		[Token(Token = "0x4003A14")]
		[FieldOffset(Offset = "0x48")]
		public Button Previous;

		// Token: 0x04003A15 RID: 14869
		[Token(Token = "0x4003A15")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x14D850", Offset = "0x14CC50")]
		public bool AffectedBySettings;

		// Token: 0x04003A16 RID: 14870
		[Token(Token = "0x4003A16")]
		[FieldOffset(Offset = "0x54")]
		public int Ultra;

		// Token: 0x04003A17 RID: 14871
		[Token(Token = "0x4003A17")]
		[FieldOffset(Offset = "0x58")]
		public int High;

		// Token: 0x04003A18 RID: 14872
		[Token(Token = "0x4003A18")]
		[FieldOffset(Offset = "0x5C")]
		public int Medium;

		// Token: 0x04003A19 RID: 14873
		[Token(Token = "0x4003A19")]
		[FieldOffset(Offset = "0x60")]
		public int Low;

		// Token: 0x04003A1A RID: 14874
		[Token(Token = "0x4003A1A")]
		[FieldOffset(Offset = "0x64")]
		public int Potato;

		// Token: 0x04003A1B RID: 14875
		[Token(Token = "0x4003A1B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16AB80", Offset = "0x169F80")]
		public bool useCustomArray;

		// Token: 0x04003A1C RID: 14876
		[Token(Token = "0x4003A1C")]
		[FieldOffset(Offset = "0x70")]
		public string[] Values;

		// Token: 0x04003A1D RID: 14877
		[Token(Token = "0x4003A1D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B770", Offset = "0x16AB70")]
		public bool useCustomToString;

		// Token: 0x04003A1E RID: 14878
		[Token(Token = "0x4003A1E")]
		[FieldOffset(Offset = "0x80")]
		public string[] ValuesString;

		// Token: 0x04003A1F RID: 14879
		[Token(Token = "0x4003A1F")]
		[FieldOffset(Offset = "0x88")]
		private int currentIndex;

		// Token: 0x04003A20 RID: 14880
		[Token(Token = "0x4003A20")]
		[FieldOffset(Offset = "0x90")]
		private string[] elements;

		// Token: 0x04003A21 RID: 14881
		[Token(Token = "0x4003A21")]
		[FieldOffset(Offset = "0x98")]
		private bool loaded;
	}
}
