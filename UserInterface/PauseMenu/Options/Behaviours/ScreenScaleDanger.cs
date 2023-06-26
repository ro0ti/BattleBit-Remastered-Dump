using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	public class ScreenScaleDanger : MonoBehaviour
	{
		// Token: 0x06013BB6 RID: 80822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB6")]
		[Address(RVA = "0x1894FE0", Offset = "0x18943E0", VA = "0x181894FE0")]
		private void Awake()
		{
		}

		// Token: 0x06013BB7 RID: 80823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB7")]
		[Address(RVA = "0x18950A0", Offset = "0x18944A0", VA = "0x1818950A0")]
		private void OnValueChanged(float arg0)
		{
		}

		// Token: 0x06013BB8 RID: 80824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BB8")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public ScreenScaleDanger()
		{
		}

		// Token: 0x04003A2F RID: 14895
		[Token(Token = "0x4003A2F")]
		[FieldOffset(Offset = "0x18")]
		public Slider Slider;

		// Token: 0x04003A30 RID: 14896
		[Token(Token = "0x4003A30")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Text;

		// Token: 0x04003A31 RID: 14897
		[Token(Token = "0x4003A31")]
		[FieldOffset(Offset = "0x28")]
		public RawImage Image;
	}
}
