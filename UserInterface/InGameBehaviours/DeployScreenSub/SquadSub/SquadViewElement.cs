using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours.DeployScreenSub.SquadSub
{
	// Token: 0x020007A6 RID: 1958
	[Token(Token = "0x20007A6")]
	public class SquadViewElement : MonoBehaviour
	{
		// Token: 0x06013CC4 RID: 81092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC4")]
		[Address(RVA = "0x1801C20", Offset = "0x1801020", VA = "0x181801C20")]
		private void Awake()
		{
		}

		// Token: 0x06013CC5 RID: 81093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC5")]
		[Address(RVA = "0x1801CB0", Offset = "0x18010B0", VA = "0x181801CB0")]
		public void Init(\u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 sq)
		{
		}

		// Token: 0x06013CC6 RID: 81094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC6")]
		[Address(RVA = "0x1801D90", Offset = "0x1801190", VA = "0x181801D90")]
		public void OnClick()
		{
		}

		// Token: 0x06013CC7 RID: 81095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC7")]
		[Address(RVA = "0x1801DF0", Offset = "0x18011F0", VA = "0x181801DF0")]
		public void OnUpdate()
		{
		}

		// Token: 0x06013CC8 RID: 81096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC8")]
		[Address(RVA = "0x18023A0", Offset = "0x18017A0", VA = "0x1818023A0")]
		private void UpdateLocked()
		{
		}

		// Token: 0x06013CC9 RID: 81097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC9")]
		[Address(RVA = "0x18022D0", Offset = "0x18016D0", VA = "0x1818022D0")]
		private void UpdateCount()
		{
		}

		// Token: 0x06013CCA RID: 81098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CCA")]
		[Address(RVA = "0x1802490", Offset = "0x1801890", VA = "0x181802490")]
		private void UpdateMyClan()
		{
		}

		// Token: 0x06013CCB RID: 81099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CCB")]
		[Address(RVA = "0x18021D0", Offset = "0x18015D0", VA = "0x1818021D0")]
		private void UpdateClan()
		{
		}

		// Token: 0x06013CCC RID: 81100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CCC")]
		[Address(RVA = "0x18025D0", Offset = "0x18019D0", VA = "0x1818025D0")]
		public SquadViewElement()
		{
		}

		// Token: 0x04003BA9 RID: 15273
		[Token(Token = "0x4003BA9")]
		[FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI SquadName;

		// Token: 0x04003BAA RID: 15274
		[Token(Token = "0x4003BAA")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI SquadCount;

		// Token: 0x04003BAB RID: 15275
		[Token(Token = "0x4003BAB")]
		[FieldOffset(Offset = "0x28")]
		public RawImage SquadLockedImg;

		// Token: 0x04003BAC RID: 15276
		[Token(Token = "0x4003BAC")]
		[FieldOffset(Offset = "0x30")]
		public GameObject JoinButton;

		// Token: 0x04003BAD RID: 15277
		[Token(Token = "0x4003BAD")]
		[FieldOffset(Offset = "0x38")]
		private \u0307\u0301\u0303\u0301\u0308\u0302\u0301\u0303\u0304\u0306\u0304\u0306\u0305\u0304\u0307 btn;

		// Token: 0x04003BAE RID: 15278
		[Token(Token = "0x4003BAE")]
		[FieldOffset(Offset = "0x40")]
		private RawImage rawButton;

		// Token: 0x04003BAF RID: 15279
		[Token(Token = "0x4003BAF")]
		[FieldOffset(Offset = "0x48")]
		private bool mAwakeCalled;

		// Token: 0x04003BB0 RID: 15280
		[Token(Token = "0x4003BB0")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 Squad;

		// Token: 0x04003BB1 RID: 15281
		[Token(Token = "0x4003BB1")]
		[FieldOffset(Offset = "0x58")]
		private int _lockedSquadCount;

		// Token: 0x04003BB2 RID: 15282
		[Token(Token = "0x4003BB2")]
		[FieldOffset(Offset = "0x5C")]
		private bool _lockedMyClanSquad;

		// Token: 0x04003BB3 RID: 15283
		[Token(Token = "0x4003BB3")]
		[FieldOffset(Offset = "0x5D")]
		private bool _lockedClanSquad;

		// Token: 0x04003BB4 RID: 15284
		[Token(Token = "0x4003BB4")]
		[FieldOffset(Offset = "0x60")]
		private \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303.\u0304\u0305\u0308\u0303\u0304\u0307\u0304\u0303\u0306\u0306\u0302\u0301\u0302\u0304\u0301 _lockedSquadLocked;
	}
}
