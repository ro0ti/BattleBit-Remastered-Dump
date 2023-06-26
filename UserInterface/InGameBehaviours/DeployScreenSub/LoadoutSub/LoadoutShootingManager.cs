using System;
using touching_your_mom;
using TMPro;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007C4 RID: 1988
	[Token(Token = "0x20007C4")]
	public class LoadoutShootingManager : MonoBehaviour
	{
		// Token: 0x06013D98 RID: 81304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D98")]
		[Address(RVA = "0x17F77E0", Offset = "0x17F6BE0", VA = "0x1817F77E0")]
		public LoadoutShootingManager()
		{
		}

		// Token: 0x06013D99 RID: 81305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D99")]
		[Address(RVA = "0x17F6E90", Offset = "0x17F6290", VA = "0x1817F6E90")]
		private void Start()
		{
		}

		// Token: 0x06013D9A RID: 81306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D9A")]
		[Address(RVA = "0x17F6FD0", Offset = "0x17F63D0", VA = "0x1817F6FD0")]
		private void Update()
		{
		}

		// Token: 0x17000BD8 RID: 3032
		// (set) Token: 0x06013D9B RID: 81307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD8")]
		public static int Ammo
		{
			[Token(Token = "0x6013D9B")]
			[Address(RVA = "0x17F7850", Offset = "0x17F6C50", VA = "0x1817F7850")]
			set
			{
			}
		}

		// Token: 0x04003CC1 RID: 15553
		[Token(Token = "0x4003CC1")]
		[FieldOffset(Offset = "0x0")]
		public static LoadoutShootingManager Instance;

		// Token: 0x04003CC2 RID: 15554
		[Token(Token = "0x4003CC2")]
		[FieldOffset(Offset = "0x18")]
		public CanvasGroup MainC;

		// Token: 0x04003CC3 RID: 15555
		[Token(Token = "0x4003CC3")]
		[FieldOffset(Offset = "0x20")]
		public CanvasGroup ShootC;

		// Token: 0x04003CC4 RID: 15556
		[Token(Token = "0x4003CC4")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup BoltC;

		// Token: 0x04003CC5 RID: 15557
		[Token(Token = "0x4003CC5")]
		[FieldOffset(Offset = "0x30")]
		public CanvasGroup ReloadC;

		// Token: 0x04003CC6 RID: 15558
		[Token(Token = "0x4003CC6")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup AmmoCountC;

		// Token: 0x04003CC7 RID: 15559
		[Token(Token = "0x4003CC7")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup MagazineCheckC;

		// Token: 0x04003CC8 RID: 15560
		[Token(Token = "0x4003CC8")]
		[FieldOffset(Offset = "0x48")]
		public CanvasGroup RotateC;

		// Token: 0x04003CC9 RID: 15561
		[Token(Token = "0x4003CC9")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI AmmoCount;

		// Token: 0x04003CCA RID: 15562
		[Token(Token = "0x4003CCA")]
		[FieldOffset(Offset = "0x8")]
		public static bool onWeapon;

		// Token: 0x04003CCB RID: 15563
		[Token(Token = "0x4003CCB")]
		[FieldOffset(Offset = "0x9")]
		public static bool showReload;

		// Token: 0x04003CCC RID: 15564
		[Token(Token = "0x4003CCC")]
		[FieldOffset(Offset = "0xA")]
		public static bool showMagCheck;

		// Token: 0x04003CCD RID: 15565
		[Token(Token = "0x4003CCD")]
		[FieldOffset(Offset = "0xB")]
		public static bool showShoot;

		// Token: 0x04003CCE RID: 15566
		[Token(Token = "0x4003CCE")]
		[FieldOffset(Offset = "0xC")]
		public static bool showBoltAction;

		// Token: 0x04003CCF RID: 15567
		[Token(Token = "0x4003CCF")]
		[FieldOffset(Offset = "0xD")]
		public static bool showRotate;
	}
}
