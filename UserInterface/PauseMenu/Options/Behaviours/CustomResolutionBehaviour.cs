using System;
using touching_your_mom;
using TMPro;
using UnityEngine;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x02000786 RID: 1926
	[Token(Token = "0x2000786")]
	public class CustomResolutionBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<Vector2Int>
	{
		// Token: 0x06013B87 RID: 80775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B87")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		private void Awake()
		{
		}

		// Token: 0x06013B88 RID: 80776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B88")]
		[Address(RVA = "0x18879E0", Offset = "0x1886DE0", VA = "0x1818879E0")]
		private void OnWidthValueChanged(string arg0)
		{
		}

		// Token: 0x06013B89 RID: 80777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B89")]
		[Address(RVA = "0x18878C0", Offset = "0x1886CC0", VA = "0x1818878C0")]
		private void OnHeigthValueChanged(string arg0)
		{
		}

		// Token: 0x06013B8A RID: 80778 RVA: 0x0007D30C File Offset: 0x0007B50C
		[Token(Token = "0x6013B8A")]
		[Address(RVA = "0x1887550", Offset = "0x1886950", VA = "0x181887550", Slot = "9")]
		public Vector2Int Get(bool save)
		{
			return default(Vector2Int);
		}

		// Token: 0x06013B8B RID: 80779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B8B")]
		[Address(RVA = "0x1887730", Offset = "0x1886B30", VA = "0x181887730", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013B8C RID: 80780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B8C")]
		[Address(RVA = "0x18876D0", Offset = "0x1886AD0", VA = "0x1818876D0", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013B8D RID: 80781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B8D")]
		[Address(RVA = "0x1887B00", Offset = "0x1886F00", VA = "0x181887B00", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013B8E RID: 80782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B8E")]
		[Address(RVA = "0x1887BD0", Offset = "0x1886FD0", VA = "0x181887BD0", Slot = "10")]
		public void Set(Vector2Int value)
		{
		}

		// Token: 0x06013B8F RID: 80783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B8F")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public CustomResolutionBehaviour()
		{
		}

		// Token: 0x04003A0B RID: 14859
		[Token(Token = "0x4003A0B")]
		public const int Minimum = 10;

		// Token: 0x04003A0C RID: 14860
		[Token(Token = "0x4003A0C")]
		public const int Maximimum = 9000;

		// Token: 0x04003A0D RID: 14861
		[Token(Token = "0x4003A0D")]
		[FieldOffset(Offset = "0x20")]
		public TMP_InputField WidthInput;

		// Token: 0x04003A0E RID: 14862
		[Token(Token = "0x4003A0E")]
		[FieldOffset(Offset = "0x28")]
		public TMP_InputField HeightInput;
	}
}
