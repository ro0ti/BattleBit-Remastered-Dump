using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours.DeployScreenSub.SquadSub
{
	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x20007A7")]
	public class SquadViewMember : MonoBehaviour
	{
		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06013CCD RID: 81101 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x17000BCD")]
		private \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 Player
		{
			[Token(Token = "0x6013CCD")]
			[Address(RVA = "0x18032D0", Offset = "0x18026D0", VA = "0x1818032D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06013CCE RID: 81102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CCE")]
		[Address(RVA = "0x1802E70", Offset = "0x1802270", VA = "0x181802E70")]
		public void Set(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 player)
		{
		}

		// Token: 0x06013CCF RID: 81103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CCF")]
		[Address(RVA = "0x1802870", Offset = "0x1801C70", VA = "0x181802870")]
		public void OnUpdate(bool force = false)
		{
		}

		// Token: 0x06013CD0 RID: 81104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD0")]
		[Address(RVA = "0x1802EF0", Offset = "0x18022F0", VA = "0x181802EF0")]
		private void UpdateButtons(SquadViewMember.buttons_state value)
		{
		}

		// Token: 0x06013CD1 RID: 81105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD1")]
		[Address(RVA = "0x18030F0", Offset = "0x18024F0", VA = "0x1818030F0")]
		private void UpdateRole(\u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 value)
		{
		}

		// Token: 0x06013CD2 RID: 81106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD2")]
		[Address(RVA = "0x1803010", Offset = "0x1802410", VA = "0x181803010")]
		private void UpdateDeadIcon(bool value)
		{
		}

		// Token: 0x06013CD3 RID: 81107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD3")]
		[Address(RVA = "0x1803050", Offset = "0x1802450", VA = "0x181803050")]
		private void UpdateIsCaptain(bool value)
		{
		}

		// Token: 0x06013CD4 RID: 81108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD4")]
		[Address(RVA = "0x1803080", Offset = "0x1802480", VA = "0x181803080")]
		private void UpdateMuted(bool value)
		{
		}

		// Token: 0x06013CD5 RID: 81109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD5")]
		[Address(RVA = "0x1803190", Offset = "0x1802590", VA = "0x181803190")]
		private void UpdateStreamerMode()
		{
		}

		// Token: 0x06013CD6 RID: 81110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD6")]
		[Address(RVA = "0x1802780", Offset = "0x1801B80", VA = "0x181802780")]
		public void OnPressed()
		{
		}

		// Token: 0x06013CD7 RID: 81111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD7")]
		[Address(RVA = "0x18025F0", Offset = "0x18019F0", VA = "0x1818025F0")]
		public void Kick()
		{
		}

		// Token: 0x06013CD8 RID: 81112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD8")]
		[Address(RVA = "0x1802DC0", Offset = "0x18021C0", VA = "0x181802DC0")]
		public void Promote()
		{
		}

		// Token: 0x06013CD9 RID: 81113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CD9")]
		[Address(RVA = "0x18026A0", Offset = "0x1801AA0", VA = "0x1818026A0")]
		public void MutePressed()
		{
		}

		// Token: 0x06013CDA RID: 81114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CDA")]
		[Address(RVA = "0x18032C0", Offset = "0x18026C0", VA = "0x1818032C0")]
		public SquadViewMember()
		{
		}

		// Token: 0x04003BB5 RID: 15285
		[Token(Token = "0x4003BB5")]
		[FieldOffset(Offset = "0x18")]
		public RawImage RoleIcon;

		// Token: 0x04003BB6 RID: 15286
		[Token(Token = "0x4003BB6")]
		[FieldOffset(Offset = "0x20")]
		public RawImage MuteIcon;

		// Token: 0x04003BB7 RID: 15287
		[Token(Token = "0x4003BB7")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI Name;

		// Token: 0x04003BB8 RID: 15288
		[Token(Token = "0x4003BB8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject isDead;

		// Token: 0x04003BB9 RID: 15289
		[Token(Token = "0x4003BB9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ButtonKick;

		// Token: 0x04003BBA RID: 15290
		[Token(Token = "0x4003BBA")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ButtonPromote;

		// Token: 0x04003BBB RID: 15291
		[Token(Token = "0x4003BBB")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ButtonMute;

		// Token: 0x04003BBC RID: 15292
		[Token(Token = "0x4003BBC")]
		[FieldOffset(Offset = "0x50")]
		public GameObject IsCaptain;

		// Token: 0x04003BBD RID: 15293
		[Token(Token = "0x4003BBD")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform NameLabelBackground;

		// Token: 0x04003BBE RID: 15294
		[Token(Token = "0x4003BBE")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform RectTransform;

		// Token: 0x04003BBF RID: 15295
		[Token(Token = "0x4003BBF")]
		[FieldOffset(Offset = "0x68")]
		private ulong steamID;

		// Token: 0x04003BC0 RID: 15296
		[Token(Token = "0x4003BC0")]
		[FieldOffset(Offset = "0x70")]
		private uint _streamerVersion;

		// Token: 0x04003BC1 RID: 15297
		[Token(Token = "0x4003BC1")]
		[FieldOffset(Offset = "0x74")]
		private bool _lastSetDeadFlag;

		// Token: 0x04003BC2 RID: 15298
		[Token(Token = "0x4003BC2")]
		[FieldOffset(Offset = "0x75")]
		private \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 _lastSetRole;

		// Token: 0x04003BC3 RID: 15299
		[Token(Token = "0x4003BC3")]
		[FieldOffset(Offset = "0x78")]
		private SquadViewMember.buttons_state _lastSetButtons;

		// Token: 0x04003BC4 RID: 15300
		[Token(Token = "0x4003BC4")]
		[FieldOffset(Offset = "0x7C")]
		private bool _lastSetCaptain;

		// Token: 0x04003BC5 RID: 15301
		[Token(Token = "0x4003BC5")]
		[FieldOffset(Offset = "0x7D")]
		private bool _lastSetMuted;

		// Token: 0x020007A8 RID: 1960
		[Token(Token = "0x20007A8")]
		private enum buttons_state
		{
			// Token: 0x04003BC7 RID: 15303
			[Token(Token = "0x4003BC7")]
			None,
			// Token: 0x04003BC8 RID: 15304
			[Token(Token = "0x4003BC8")]
			All,
			// Token: 0x04003BC9 RID: 15305
			[Token(Token = "0x4003BC9")]
			muteOnly
		}
	}
}
