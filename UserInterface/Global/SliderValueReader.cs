using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.Global
{
	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x20007D0")]
	public class SliderValueReader : MonoBehaviour
	{
		// Token: 0x06013DE1 RID: 81377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE1")]
		[Address(RVA = "0x1944C80", Offset = "0x1944080", VA = "0x181944C80")]
		private void Awake()
		{
		}

		// Token: 0x06013DE2 RID: 81378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE2")]
		[Address(RVA = "0x1944E40", Offset = "0x1944240", VA = "0x181944E40")]
		public void OnValueChanged(float value)
		{
		}

		// Token: 0x06013DE3 RID: 81379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE3")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public SliderValueReader()
		{
		}

		// Token: 0x04003D35 RID: 15669
		[Token(Token = "0x4003D35")]
		[FieldOffset(Offset = "0x18")]
		public Slider Slider;

		// Token: 0x04003D36 RID: 15670
		[Token(Token = "0x4003D36")]
		[FieldOffset(Offset = "0x20")]
		public bool asFloat;

		// Token: 0x04003D37 RID: 15671
		[Token(Token = "0x4003D37")]
		[FieldOffset(Offset = "0x21")]
		public bool asFloat2;

		// Token: 0x04003D38 RID: 15672
		[Token(Token = "0x4003D38")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI txt;

		// Token: 0x04003D39 RID: 15673
		[Token(Token = "0x4003D39")]
		[FieldOffset(Offset = "0x30")]
		public string Additional;
	}
}
