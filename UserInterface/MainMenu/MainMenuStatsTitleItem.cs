using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.MainMenu
{
	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	public class MainMenuStatsTitleItem : MonoBehaviour
	{
		// Token: 0x06013A74 RID: 80500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A74")]
		[Address(RVA = "0x1680620", Offset = "0x167FA20", VA = "0x181680620")]
		public void OnClicked()
		{
		}

		// Token: 0x06013A75 RID: 80501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A75")]
		[Address(RVA = "0x1680680", Offset = "0x167FA80", VA = "0x181680680")]
		public void UnSelect()
		{
		}

		// Token: 0x06013A76 RID: 80502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A76")]
		[Address(RVA = "0x1680650", Offset = "0x167FA50", VA = "0x181680650")]
		public void OnSelect()
		{
		}

		// Token: 0x06013A77 RID: 80503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A77")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public MainMenuStatsTitleItem()
		{
		}

		// Token: 0x0400380A RID: 14346
		[Token(Token = "0x400380A")]
		[FieldOffset(Offset = "0x18")]
		public MainMenuStatsTitle Parent;

		// Token: 0x0400380B RID: 14347
		[Token(Token = "0x400380B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelectedGameObj;

		// Token: 0x0400380C RID: 14348
		[Token(Token = "0x400380C")]
		[FieldOffset(Offset = "0x28")]
		private bool wasSelected;

		// Token: 0x0400380D RID: 14349
		[Token(Token = "0x400380D")]
		[FieldOffset(Offset = "0x2C")]
		public \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304 WeaponType;

		// Token: 0x0400380E RID: 14350
		[Token(Token = "0x400380E")]
		[FieldOffset(Offset = "0x30")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 GadgetType;

		// Token: 0x0400380F RID: 14351
		[Token(Token = "0x400380F")]
		[FieldOffset(Offset = "0x34")]
		public \u0301\u0303\u0305\u0305\u0301\u0303\u0306\u0305\u0305\u0304\u0301\u0301\u0307\u0305\u0301 VehicleType;
	}
}
