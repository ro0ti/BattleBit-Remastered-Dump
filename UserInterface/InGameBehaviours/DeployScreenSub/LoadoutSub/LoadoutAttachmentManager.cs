using System;
using touching_your_mom;
using PlayerLoadout.Items;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	public class LoadoutAttachmentManager : MonoBehaviour
	{
		// Token: 0x06013CEC RID: 81132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CEC")]
		[Address(RVA = "0x17EC890", Offset = "0x17EBC90", VA = "0x1817EC890")]
		public LoadoutAttachmentManager()
		{
		}

		// Token: 0x06013CED RID: 81133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CED")]
		[Address(RVA = "0x17EB5D0", Offset = "0x17EA9D0", VA = "0x1817EB5D0")]
		public void LoadAttachments(AWeapon weapon, \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 attachments, \u0308\u0302\u0305\u0305\u0301\u0303\u0306\u0307\u0307\u0301\u0301\u0303\u0306\u0306\u0301 manager)
		{
		}

		// Token: 0x06013CEE RID: 81134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CEE")]
		[Address(RVA = "0x17EC750", Offset = "0x17EBB50", VA = "0x1817EC750")]
		public void SelectNone()
		{
		}

		// Token: 0x06013CEF RID: 81135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CEF")]
		[Address(RVA = "0x17EC7C0", Offset = "0x17EBBC0", VA = "0x1817EC7C0")]
		public void SelectOne(LoadoutAttachmentPoint obj)
		{
		}

		// Token: 0x06013CF0 RID: 81136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF0")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		public void OnColorSelected(\u0303\u0305\u0307\u0303\u0307\u0301\u0308\u0308\u0303\u0302\u0301\u0306\u0301\u0305\u0301 type, Color color)
		{
		}

		// Token: 0x06013CF1 RID: 81137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF1")]
		[Address(RVA = "0x17EC2D0", Offset = "0x17EB6D0", VA = "0x1817EC2D0")]
		public void OnItemSelected(\u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 item)
		{
		}

		// Token: 0x04003BE4 RID: 15332
		[Token(Token = "0x4003BE4")]
		[FieldOffset(Offset = "0x0")]
		public static Vector3[] PanelBounds;

		// Token: 0x04003BE5 RID: 15333
		[Token(Token = "0x4003BE5")]
		[FieldOffset(Offset = "0x8")]
		public static LoadoutAttachmentManager Instance;

		// Token: 0x04003BE6 RID: 15334
		[Token(Token = "0x4003BE6")]
		[FieldOffset(Offset = "0x10")]
		public static AWeapon Active;

		// Token: 0x04003BE7 RID: 15335
		[Token(Token = "0x4003BE7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x178E10", Offset = "0x178210")]
		public LoadoutAttachmentPoint[] Points;

		// Token: 0x04003BE8 RID: 15336
		[Token(Token = "0x4003BE8")]
		[FieldOffset(Offset = "0x20")]
		public LoadoutAttachmentTrigger Trigger;

		// Token: 0x04003BE9 RID: 15337
		[Token(Token = "0x4003BE9")]
		[FieldOffset(Offset = "0x28")]
		public LoadoutAttachmentTrigger Magazine;

		// Token: 0x04003BEA RID: 15338
		[Token(Token = "0x4003BEA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public LoadoutAttachmentPanel Panel;

		// Token: 0x04003BEB RID: 15339
		[Token(Token = "0x4003BEB")]
		[FieldOffset(Offset = "0x38")]
		private AWeapon item;

		// Token: 0x04003BEC RID: 15340
		[Token(Token = "0x4003BEC")]
		[FieldOffset(Offset = "0x40")]
		private \u0303\u0305\u0307\u0303\u0307\u0301\u0308\u0308\u0303\u0302\u0301\u0306\u0301\u0305\u0301 Selected;
	}
}
