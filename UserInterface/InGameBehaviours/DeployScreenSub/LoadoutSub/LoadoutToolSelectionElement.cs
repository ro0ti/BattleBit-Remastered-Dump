using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007C2 RID: 1986
	[Token(Token = "0x20007C2")]
	public class LoadoutToolSelectionElement : MonoBehaviour
	{
		// Token: 0x06013D8B RID: 81291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D8B")]
		[Address(RVA = "0x17F9200", Offset = "0x17F8600", VA = "0x1817F9200")]
		public void Init(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 item, bool isSelected)
		{
		}

		// Token: 0x06013D8C RID: 81292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D8C")]
		[Address(RVA = "0x17F9730", Offset = "0x17F8B30", VA = "0x1817F9730")]
		public void OnItemClicked()
		{
		}

		// Token: 0x06013D8D RID: 81293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D8D")]
		[Address(RVA = "0x17F97A0", Offset = "0x17F8BA0", VA = "0x1817F97A0")]
		public void SelectThis()
		{
		}

		// Token: 0x06013D8E RID: 81294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D8E")]
		[Address(RVA = "0x17F97B0", Offset = "0x17F8BB0", VA = "0x1817F97B0")]
		public void UnselectThis()
		{
		}

		// Token: 0x06013D8F RID: 81295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D8F")]
		[Address(RVA = "0x17F9650", Offset = "0x17F8A50", VA = "0x1817F9650")]
		public void OnHover()
		{
		}

		// Token: 0x06013D90 RID: 81296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D90")]
		[Address(RVA = "0x17F97C0", Offset = "0x17F8BC0", VA = "0x1817F97C0")]
		private void Update()
		{
		}

		// Token: 0x06013D91 RID: 81297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D91")]
		[Address(RVA = "0x17F9AB0", Offset = "0x17F8EB0", VA = "0x1817F9AB0")]
		public LoadoutToolSelectionElement()
		{
		}

		// Token: 0x04003CA8 RID: 15528
		[Token(Token = "0x4003CA8")]
		[FieldOffset(Offset = "0x0")]
		private static Color orange;

		// Token: 0x04003CA9 RID: 15529
		[Token(Token = "0x4003CA9")]
		[FieldOffset(Offset = "0x10")]
		private static Color red;

		// Token: 0x04003CAA RID: 15530
		[Token(Token = "0x4003CAA")]
		[FieldOffset(Offset = "0x20")]
		private static Color green;

		// Token: 0x04003CAB RID: 15531
		[Token(Token = "0x4003CAB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI label_name;

		// Token: 0x04003CAC RID: 15532
		[Token(Token = "0x4003CAC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image Icon;

		// Token: 0x04003CAD RID: 15533
		[Token(Token = "0x4003CAD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject isLocked;

		// Token: 0x04003CAE RID: 15534
		[Token(Token = "0x4003CAE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI rank_req;

		// Token: 0x04003CAF RID: 15535
		[Token(Token = "0x4003CAF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RawImage obj_color;

		// Token: 0x04003CB0 RID: 15536
		[Token(Token = "0x4003CB0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private \u0307\u0301\u0303\u0301\u0308\u0302\u0301\u0303\u0304\u0306\u0304\u0306\u0305\u0304\u0307 Button;

		// Token: 0x04003CB1 RID: 15537
		[Token(Token = "0x4003CB1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject New;

		// Token: 0x04003CB2 RID: 15538
		[Token(Token = "0x4003CB2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup Canvas;

		// Token: 0x04003CB3 RID: 15539
		[Token(Token = "0x4003CB3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject NewAttachments;

		// Token: 0x04003CB4 RID: 15540
		[Token(Token = "0x4003CB4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI NewAttachmentsLabel;

		// Token: 0x04003CB5 RID: 15541
		[Token(Token = "0x4003CB5")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[NonSerialized]
		public \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 Item;

		// Token: 0x04003CB6 RID: 15542
		[Token(Token = "0x4003CB6")]
		[FieldOffset(Offset = "0x70")]
		private bool isUnlocked;

		// Token: 0x04003CB7 RID: 15543
		[Token(Token = "0x4003CB7")]
		[FieldOffset(Offset = "0x74")]
		private int mLastCount;

		// Token: 0x04003CB8 RID: 15544
		[Token(Token = "0x4003CB8")]
		[FieldOffset(Offset = "0x78")]
		private bool isSelected;
	}
}
