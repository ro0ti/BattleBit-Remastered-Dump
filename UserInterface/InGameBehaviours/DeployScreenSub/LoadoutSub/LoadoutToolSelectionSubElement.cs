using System;
using touching_your_mom;
using TMPro;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	public class LoadoutToolSelectionSubElement : MonoBehaviour
	{
		// Token: 0x06013D93 RID: 81299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D93")]
		[Address(RVA = "0x17F9AC0", Offset = "0x17F8EC0", VA = "0x1817F9AC0")]
		public void Init(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 item, bool isSelected)
		{
		}

		// Token: 0x06013D94 RID: 81300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D94")]
		[Address(RVA = "0x17F9F50", Offset = "0x17F9350", VA = "0x1817F9F50")]
		public void OnItemClicked()
		{
		}

		// Token: 0x06013D95 RID: 81301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D95")]
		[Address(RVA = "0x17F9FC0", Offset = "0x17F93C0", VA = "0x1817F9FC0")]
		public void SelectThis()
		{
		}

		// Token: 0x06013D96 RID: 81302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D96")]
		[Address(RVA = "0x17F9FD0", Offset = "0x17F93D0", VA = "0x1817F9FD0")]
		public void UnselectThis()
		{
		}

		// Token: 0x06013D97 RID: 81303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D97")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public LoadoutToolSelectionSubElement()
		{
		}

		// Token: 0x04003CB9 RID: 15545
		[Token(Token = "0x4003CB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI LabelName;

		// Token: 0x04003CBA RID: 15546
		[Token(Token = "0x4003CBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI Requirment;

		// Token: 0x04003CBB RID: 15547
		[Token(Token = "0x4003CBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject Locked;

		// Token: 0x04003CBC RID: 15548
		[Token(Token = "0x4003CBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject Selected;

		// Token: 0x04003CBD RID: 15549
		[Token(Token = "0x4003CBD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private \u0307\u0301\u0303\u0301\u0308\u0302\u0301\u0303\u0304\u0306\u0304\u0306\u0305\u0304\u0307 Button;

		// Token: 0x04003CBE RID: 15550
		[Token(Token = "0x4003CBE")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 Item;

		// Token: 0x04003CBF RID: 15551
		[Token(Token = "0x4003CBF")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public bool IsUnlocked;

		// Token: 0x04003CC0 RID: 15552
		[Token(Token = "0x4003CC0")]
		[FieldOffset(Offset = "0x49")]
		private bool isSelected;
	}
}
