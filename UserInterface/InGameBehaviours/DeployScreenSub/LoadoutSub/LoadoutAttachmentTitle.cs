using System;
using touching_your_mom;
using TMPro;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	public class LoadoutAttachmentTitle : MonoBehaviour
	{
		// Token: 0x06013D2F RID: 81199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D2F")]
		[Address(RVA = "0x17F3700", Offset = "0x17F2B00", VA = "0x1817F3700")]
		public void SetLabel(ref string title, float height = 60f, float font = 18f)
		{
		}

		// Token: 0x06013D30 RID: 81200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D30")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public LoadoutAttachmentTitle()
		{
		}

		// Token: 0x04003C26 RID: 15398
		[Token(Token = "0x4003C26")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform Rect;

		// Token: 0x04003C27 RID: 15399
		[Token(Token = "0x4003C27")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;
	}
}
