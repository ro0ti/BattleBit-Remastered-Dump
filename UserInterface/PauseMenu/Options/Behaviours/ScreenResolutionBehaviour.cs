using System;
using touching_your_mom;
using TMPro;
using UnityEngine.UI;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x02000789 RID: 1929
	[Token(Token = "0x2000789")]
	public class ScreenResolutionBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<int>
	{
		// Token: 0x06013BAA RID: 80810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BAA")]
		[Address(RVA = "0x1894B10", Offset = "0x1893F10", VA = "0x181894B10")]
		[Attribute(Name = "ContextMenu", RVA = "0x16B7D0", Offset = "0x16ABD0")]
		private void mAssign()
		{
		}

		// Token: 0x06013BAB RID: 80811 RVA: 0x0007D354 File Offset: 0x0007B554
		[Token(Token = "0x6013BAB")]
		[Address(RVA = "0x1894550", Offset = "0x1893950", VA = "0x181894550", Slot = "9")]
		public int Get(bool save = false)
		{
			return 0;
		}

		// Token: 0x06013BAC RID: 80812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BAC")]
		[Address(RVA = "0x1894A40", Offset = "0x1893E40", VA = "0x181894A40", Slot = "10")]
		public void Set(int value)
		{
		}

		// Token: 0x06013BAD RID: 80813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BAD")]
		[Address(RVA = "0x1894880", Offset = "0x1893C80", VA = "0x181894880", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013BAE RID: 80814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BAE")]
		[Address(RVA = "0x18945A0", Offset = "0x18939A0", VA = "0x1818945A0", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013BAF RID: 80815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BAF")]
		[Address(RVA = "0x1894960", Offset = "0x1893D60", VA = "0x181894960", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013BB0 RID: 80816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB0")]
		[Address(RVA = "0x1894900", Offset = "0x1893D00", VA = "0x181894900")]
		public void OnNextPressed()
		{
		}

		// Token: 0x06013BB1 RID: 80817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB1")]
		[Address(RVA = "0x1894930", Offset = "0x1893D30", VA = "0x181894930")]
		public void OnPreviousPressed()
		{
		}

		// Token: 0x06013BB2 RID: 80818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB2")]
		[Address(RVA = "0x1894980", Offset = "0x1893D80", VA = "0x181894980")]
		private void SetVisual(int index)
		{
		}

		// Token: 0x06013BB3 RID: 80819 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013BB3")]
		[Address(RVA = "0x1894BB0", Offset = "0x1893FB0", VA = "0x181894BB0")]
		private string process(string raw)
		{
			return null;
		}

		// Token: 0x06013BB4 RID: 80820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB4")]
		[Address(RVA = "0x18947B0", Offset = "0x1893BB0", VA = "0x1818947B0")]
		private void LoadEnum()
		{
		}

		// Token: 0x06013BB5 RID: 80821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB5")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public ScreenResolutionBehaviour()
		{
		}

		// Token: 0x04003A27 RID: 14887
		[Token(Token = "0x4003A27")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public TextMeshProUGUI Label;

		// Token: 0x04003A28 RID: 14888
		[Token(Token = "0x4003A28")]
		[FieldOffset(Offset = "0x28")]
		public Button Next;

		// Token: 0x04003A29 RID: 14889
		[Token(Token = "0x4003A29")]
		[FieldOffset(Offset = "0x30")]
		public Button Previous;

		// Token: 0x04003A2A RID: 14890
		[Token(Token = "0x4003A2A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16AB80", Offset = "0x169F80")]
		public bool useCustomArray;

		// Token: 0x04003A2B RID: 14891
		[Token(Token = "0x4003A2B")]
		[FieldOffset(Offset = "0x40")]
		public string[] Values;

		// Token: 0x04003A2C RID: 14892
		[Token(Token = "0x4003A2C")]
		[FieldOffset(Offset = "0x48")]
		private int currentIndex;

		// Token: 0x04003A2D RID: 14893
		[Token(Token = "0x4003A2D")]
		[FieldOffset(Offset = "0x50")]
		private string[] elements;

		// Token: 0x04003A2E RID: 14894
		[Token(Token = "0x4003A2E")]
		[FieldOffset(Offset = "0x58")]
		private bool loaded;
	}
}
