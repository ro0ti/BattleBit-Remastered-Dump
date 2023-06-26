using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.Global.Sub
{
	// Token: 0x020007D1 RID: 2001
	[Token(Token = "0x20007D1")]
	public class Notification : MonoBehaviour
	{
		// Token: 0x06013DE4 RID: 81380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE4")]
		[Address(RVA = "0x1942020", Offset = "0x1941420", VA = "0x181942020")]
		public void Init(string text, \u0308\u0304\u0308\u0302\u0303\u0306\u0304\u0301\u0308\u0303\u0303\u0304\u0306\u0307\u0307.\u0308\u0307\u0305\u0301\u0301\u0304\u0305\u0301\u0304\u0303\u0308\u0306\u0306\u0304\u0307 color, float delay, \u0308\u0304\u0308\u0302\u0303\u0306\u0304\u0301\u0308\u0303\u0303\u0304\u0306\u0307\u0307 handler)
		{
		}

		// Token: 0x06013DE5 RID: 81381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE5")]
		[Address(RVA = "0x1941FB0", Offset = "0x19413B0", VA = "0x181941FB0")]
		private void Awake()
		{
		}

		// Token: 0x06013DE6 RID: 81382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE6")]
		[Address(RVA = "0x1942260", Offset = "0x1941660", VA = "0x181942260")]
		public void OnLateUpdate()
		{
		}

		// Token: 0x06013DE7 RID: 81383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE7")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public Notification()
		{
		}

		// Token: 0x04003D3A RID: 15674
		[Token(Token = "0x4003D3A")]
		[FieldOffset(Offset = "0x0")]
		private static Color[] Table;

		// Token: 0x04003D3B RID: 15675
		[Token(Token = "0x4003D3B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public TextMeshProUGUI Label;

		// Token: 0x04003D3C RID: 15676
		[Token(Token = "0x4003D3C")]
		[FieldOffset(Offset = "0x20")]
		public RawImage Indicator;

		// Token: 0x04003D3D RID: 15677
		[Token(Token = "0x4003D3D")]
		[FieldOffset(Offset = "0x28")]
		public RawImage Layer;

		// Token: 0x04003D3E RID: 15678
		[Token(Token = "0x4003D3E")]
		[FieldOffset(Offset = "0x30")]
		private \u0308\u0304\u0308\u0302\u0303\u0306\u0304\u0301\u0308\u0303\u0303\u0304\u0306\u0307\u0307 handler;

		// Token: 0x04003D3F RID: 15679
		[Token(Token = "0x4003D3F")]
		[FieldOffset(Offset = "0x38")]
		private float InitTime;

		// Token: 0x04003D40 RID: 15680
		[Token(Token = "0x4003D40")]
		[FieldOffset(Offset = "0x3C")]
		private float AliveUntil;

		// Token: 0x04003D41 RID: 15681
		[Token(Token = "0x4003D41")]
		[FieldOffset(Offset = "0x40")]
		private float mWidth;

		// Token: 0x04003D42 RID: 15682
		[Token(Token = "0x4003D42")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public RectTransform rectTransform;

		// Token: 0x04003D43 RID: 15683
		[Token(Token = "0x4003D43")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public CanvasGroup group;
	}
}
