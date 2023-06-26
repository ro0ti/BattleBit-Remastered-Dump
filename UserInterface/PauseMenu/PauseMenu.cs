using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.PauseMenu
{
	// Token: 0x0200077B RID: 1915
	[Token(Token = "0x200077B")]
	public class PauseMenu : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06013B27 RID: 80679 RVA: 0x0007D174 File Offset: 0x0007B374
		// (set) Token: 0x06013B28 RID: 80680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B9F")]
		public static bool isActive
		{
			[Token(Token = "0x6013B27")]
			[Address(RVA = "0x1894450", Offset = "0x1893850", VA = "0x181894450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013B28")]
			[Address(RVA = "0x18944D0", Offset = "0x18938D0", VA = "0x1818944D0")]
			set
			{
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06013B29 RID: 80681 RVA: 0x0007D18C File Offset: 0x0007B38C
		// (set) Token: 0x06013B2A RID: 80682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA0")]
		public int TickIndex8
		{
			[Token(Token = "0x6013B29")]
			[Address(RVA = "0xC0F9F0", Offset = "0xC0EDF0", VA = "0x180C0F9F0", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013B2A")]
			[Address(RVA = "0xC8ED90", Offset = "0xC8E190", VA = "0x180C8ED90", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06013B2B RID: 80683 RVA: 0x0007D1A4 File Offset: 0x0007B3A4
		// (set) Token: 0x06013B2C RID: 80684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA1")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013B2B")]
			[Address(RVA = "0x1894320", Offset = "0x1893720", VA = "0x181894320", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013B2C")]
			[Address(RVA = "0x18944C0", Offset = "0x18938C0", VA = "0x1818944C0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06013B2D RID: 80685 RVA: 0x0007D1BC File Offset: 0x0007B3BC
		[Token(Token = "0x17000BA2")]
		private bool inServer
		{
			[Token(Token = "0x6013B2D")]
			[Address(RVA = "0x1894330", Offset = "0x1893730", VA = "0x181894330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06013B2E RID: 80686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B2E")]
		[Address(RVA = "0x18922D0", Offset = "0x18916D0", VA = "0x1818922D0")]
		private void Awake()
		{
		}

		// Token: 0x06013B2F RID: 80687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B2F")]
		[Address(RVA = "0x18932C0", Offset = "0x18926C0", VA = "0x1818932C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013B30 RID: 80688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B30")]
		[Address(RVA = "0x1893260", Offset = "0x1892660", VA = "0x181893260")]
		private void OnDisable()
		{
		}

		// Token: 0x06013B31 RID: 80689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B31")]
		[Address(RVA = "0x1892510", Offset = "0x1891910", VA = "0x181892510")]
		public void Continue_Press()
		{
		}

		// Token: 0x06013B32 RID: 80690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B32")]
		[Address(RVA = "0x1892EE0", Offset = "0x18922E0", VA = "0x181892EE0")]
		public void Gameplay_Press()
		{
		}

		// Token: 0x06013B33 RID: 80691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B33")]
		[Address(RVA = "0x18926B0", Offset = "0x1891AB0", VA = "0x1818926B0")]
		public void Controllers_Press()
		{
		}

		// Token: 0x06013B34 RID: 80692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B34")]
		[Address(RVA = "0x18930F0", Offset = "0x18924F0", VA = "0x1818930F0")]
		public void Keybindings_Press()
		{
		}

		// Token: 0x06013B35 RID: 80693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B35")]
		[Address(RVA = "0x1894240", Offset = "0x1893640", VA = "0x181894240")]
		public void Video_Press()
		{
		}

		// Token: 0x06013B36 RID: 80694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B36")]
		[Address(RVA = "0x1892230", Offset = "0x1891630", VA = "0x181892230")]
		public void Audio_Press()
		{
		}

		// Token: 0x06013B37 RID: 80695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B37")]
		[Address(RVA = "0x1892020", Offset = "0x1891420", VA = "0x181892020")]
		public void Account_Press()
		{
		}

		// Token: 0x06013B38 RID: 80696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B38")]
		[Address(RVA = "0x1893190", Offset = "0x1892590", VA = "0x181893190")]
		public void Leave_Press()
		{
		}

		// Token: 0x06013B39 RID: 80697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B39")]
		[Address(RVA = "0x1892890", Offset = "0x1891C90", VA = "0x181892890")]
		public void Disconnect()
		{
		}

		// Token: 0x06013B3A RID: 80698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B3A")]
		[Address(RVA = "0x1892750", Offset = "0x1891B50", VA = "0x181892750")]
		private void DisconnectFull()
		{
		}

		// Token: 0x06013B3B RID: 80699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B3B")]
		[Address(RVA = "0x1892330", Offset = "0x1891730", VA = "0x181892330")]
		private void ContinueBackPress()
		{
		}

		// Token: 0x06013B3C RID: 80700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B3C")]
		[Address(RVA = "0x1892D70", Offset = "0x1892170", VA = "0x181892D70")]
		public void Gameplay_Back_Press()
		{
		}

		// Token: 0x06013B3D RID: 80701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B3D")]
		[Address(RVA = "0x1892540", Offset = "0x1891940", VA = "0x181892540")]
		public void Controllers_Back_Press()
		{
		}

		// Token: 0x06013B3E RID: 80702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B3E")]
		[Address(RVA = "0x1892F80", Offset = "0x1892380", VA = "0x181892F80")]
		public void Keybindings_Back_Press()
		{
		}

		// Token: 0x06013B3F RID: 80703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B3F")]
		[Address(RVA = "0x18940D0", Offset = "0x18934D0", VA = "0x1818940D0")]
		public void Video_Back_Press()
		{
		}

		// Token: 0x06013B40 RID: 80704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B40")]
		[Address(RVA = "0x18920C0", Offset = "0x18914C0", VA = "0x1818920C0")]
		public void Audio_Back_Press()
		{
		}

		// Token: 0x06013B41 RID: 80705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B41")]
		[Address(RVA = "0x1891EB0", Offset = "0x18912B0", VA = "0x181891EB0")]
		public void Account_Back_Press()
		{
		}

		// Token: 0x06013B42 RID: 80706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B42")]
		[Address(RVA = "0x1893320", Offset = "0x1892720", VA = "0x181893320", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013B43 RID: 80707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B43")]
		[Address(RVA = "0x1893250", Offset = "0x1892650", VA = "0x181893250")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06013B44 RID: 80708 RVA: 0x0007D1D4 File Offset: 0x0007B3D4
		[Token(Token = "0x17000BA3")]
		public static bool inSettingsMenu
		{
			[Token(Token = "0x6013B44")]
			[Address(RVA = "0x18943B0", Offset = "0x18937B0", VA = "0x1818943B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06013B45 RID: 80709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B45")]
		[Address(RVA = "0x1892B30", Offset = "0x1891F30", VA = "0x181892B30")]
		public void EnableGameplay()
		{
		}

		// Token: 0x06013B46 RID: 80710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B46")]
		[Address(RVA = "0x1892A70", Offset = "0x1891E70", VA = "0x181892A70")]
		public void EnableControllers()
		{
		}

		// Token: 0x06013B47 RID: 80711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B47")]
		[Address(RVA = "0x1892BF0", Offset = "0x1891FF0", VA = "0x181892BF0")]
		public void EnableKeybindings()
		{
		}

		// Token: 0x06013B48 RID: 80712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B48")]
		[Address(RVA = "0x18929B0", Offset = "0x1891DB0", VA = "0x1818929B0")]
		public void EnableAudio()
		{
		}

		// Token: 0x06013B49 RID: 80713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B49")]
		[Address(RVA = "0x1892CB0", Offset = "0x18920B0", VA = "0x181892CB0")]
		public void EnableVideo()
		{
		}

		// Token: 0x06013B4A RID: 80714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B4A")]
		[Address(RVA = "0x18928F0", Offset = "0x1891CF0", VA = "0x1818928F0")]
		public void EnableAccount()
		{
		}

		// Token: 0x06013B4B RID: 80715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B4B")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public PauseMenu()
		{
		}

		// Token: 0x040039AD RID: 14765
		[Token(Token = "0x40039AD")]
		[FieldOffset(Offset = "0x0")]
		public static PauseMenu Instance;

		// Token: 0x040039AE RID: 14766
		[Token(Token = "0x40039AE")]
		[FieldOffset(Offset = "0x8")]
		public static bool MenuExist;

		// Token: 0x040039AF RID: 14767
		[Token(Token = "0x40039AF")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Main;

		// Token: 0x040039B0 RID: 14768
		[Token(Token = "0x40039B0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SettingScreen;

		// Token: 0x040039B1 RID: 14769
		[Token(Token = "0x40039B1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16A250", Offset = "0x169650")]
		public GameObject GameplayObj;

		// Token: 0x040039B2 RID: 14770
		[Token(Token = "0x40039B2")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ControllersObj;

		// Token: 0x040039B3 RID: 14771
		[Token(Token = "0x40039B3")]
		[FieldOffset(Offset = "0x38")]
		public GameObject KeybindingsObj;

		// Token: 0x040039B4 RID: 14772
		[Token(Token = "0x40039B4")]
		[FieldOffset(Offset = "0x40")]
		public GameObject VideoObj;

		// Token: 0x040039B5 RID: 14773
		[Token(Token = "0x40039B5")]
		[FieldOffset(Offset = "0x48")]
		public GameObject AudioObj;

		// Token: 0x040039B6 RID: 14774
		[Token(Token = "0x40039B6")]
		[FieldOffset(Offset = "0x50")]
		public GameObject AccountObj;

		// Token: 0x040039B7 RID: 14775
		[Token(Token = "0x40039B7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16A360", Offset = "0x169760")]
		public PauseMenuOptions Options;

		// Token: 0x040039B8 RID: 14776
		[Token(Token = "0x40039B8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1637D0", Offset = "0x162BD0")]
		public GameObject ConfirmDisconnect;

		// Token: 0x040039B9 RID: 14777
		[Token(Token = "0x40039B9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x040039BA RID: 14778
		[Token(Token = "0x40039BA")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;

		// Token: 0x040039BB RID: 14779
		[Token(Token = "0x40039BB")]
		[FieldOffset(Offset = "0x6D")]
		private bool isDisconnecting;
	}
}
