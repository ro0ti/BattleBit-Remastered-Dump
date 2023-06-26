using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Extentions;
using UserInterface.MainMenu.Cards;

namespace UserInterface.MainMenu
{
	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	public class MainMenu : MonoBehaviour
	{
		// Token: 0x06013A26 RID: 80422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A26")]
		[Address(RVA = "0x1687B20", Offset = "0x1686F20", VA = "0x181687B20")]
		public MainMenu()
		{
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06013A27 RID: 80423 RVA: 0x0007CF4C File Offset: 0x0007B14C
		// (set) Token: 0x06013A28 RID: 80424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B86")]
		public int MenuIndex
		{
			[Token(Token = "0x6013A27")]
			[Address(RVA = "0xB51730", Offset = "0xB50B30", VA = "0x180B51730")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013A28")]
			[Address(RVA = "0x1685DC0", Offset = "0x16851C0", VA = "0x181685DC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013A29 RID: 80425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A29")]
		[Address(RVA = "0x1683E50", Offset = "0x1683250", VA = "0x181683E50")]
		private void Awake()
		{
		}

		// Token: 0x06013A2A RID: 80426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A2A")]
		[Address(RVA = "0x1684490", Offset = "0x1683890", VA = "0x181684490")]
		private void IntroAwake()
		{
		}

		// Token: 0x06013A2B RID: 80427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A2B")]
		[Address(RVA = "0x16846B0", Offset = "0x1683AB0", VA = "0x1816846B0")]
		private void IntroStart()
		{
		}

		// Token: 0x06013A2C RID: 80428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A2C")]
		[Address(RVA = "0x1684730", Offset = "0x1683B30", VA = "0x181684730")]
		private void IntroUpdate()
		{
		}

		// Token: 0x06013A2D RID: 80429 RVA: 0x0007CF64 File Offset: 0x0007B164
		[Token(Token = "0x6013A2D")]
		[Address(RVA = "0x1687BA0", Offset = "0x1686FA0", VA = "0x181687BA0")]
		public float evulate(float a, float b, float x)
		{
			return 0f;
		}

		// Token: 0x06013A2E RID: 80430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A2E")]
		[Address(RVA = "0x1684340", Offset = "0x1683740", VA = "0x181684340")]
		public void GoSettingsGameplay()
		{
		}

		// Token: 0x06013A2F RID: 80431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A2F")]
		[Address(RVA = "0x16842D0", Offset = "0x16836D0", VA = "0x1816842D0")]
		public void GoSettingsControllers()
		{
		}

		// Token: 0x06013A30 RID: 80432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A30")]
		[Address(RVA = "0x16843B0", Offset = "0x16837B0", VA = "0x1816843B0")]
		public void GoSettingsKeybindings()
		{
		}

		// Token: 0x06013A31 RID: 80433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A31")]
		[Address(RVA = "0x1684260", Offset = "0x1683660", VA = "0x181684260")]
		public void GoSettingsAudio()
		{
		}

		// Token: 0x06013A32 RID: 80434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A32")]
		[Address(RVA = "0x1684420", Offset = "0x1683820", VA = "0x181684420")]
		public void GoSettingsVideo()
		{
		}

		// Token: 0x06013A33 RID: 80435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A33")]
		[Address(RVA = "0x16841F0", Offset = "0x16835F0", VA = "0x1816841F0")]
		public void GoSettingsAccount()
		{
		}

		// Token: 0x06013A34 RID: 80436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A34")]
		[Address(RVA = "0x16841E0", Offset = "0x16835E0", VA = "0x1816841E0")]
		public void ExitGame()
		{
		}

		// Token: 0x06013A35 RID: 80437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A35")]
		[Address(RVA = "0x16859A0", Offset = "0x1684DA0", VA = "0x1816859A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013A36 RID: 80438 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013A36")]
		[Address(RVA = "0x1683FB0", Offset = "0x16833B0", VA = "0x181683FB0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x163070", Offset = "0x162470")]
		private IEnumerator ConnectServer()
		{
			return null;
		}

		// Token: 0x06013A37 RID: 80439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A37")]
		[Address(RVA = "0x1685730", Offset = "0x1684B30", VA = "0x181685730")]
		private void OnDisable()
		{
		}

		// Token: 0x06013A38 RID: 80440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A38")]
		[Address(RVA = "0x16862B0", Offset = "0x16856B0", VA = "0x1816862B0")]
		private void UpdatePlayerInfo()
		{
		}

		// Token: 0x06013A39 RID: 80441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A39")]
		[Address(RVA = "0x16856A0", Offset = "0x1684AA0", VA = "0x1816856A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06013A3A RID: 80442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A3A")]
		[Address(RVA = "0x1685E80", Offset = "0x1685280", VA = "0x181685E80")]
		private void Start()
		{
		}

		// Token: 0x06013A3B RID: 80443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A3B")]
		[Address(RVA = "0x16870F0", Offset = "0x16864F0", VA = "0x1816870F0")]
		private void Update()
		{
		}

		// Token: 0x06013A3C RID: 80444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A3C")]
		[Address(RVA = "0x1685210", Offset = "0x1684610", VA = "0x181685210")]
		public void Join(IPEndPoint ep, bool instant, bool waitForTicket)
		{
		}

		// Token: 0x06013A3D RID: 80445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A3D")]
		[Address(RVA = "0x1685DC0", Offset = "0x16851C0", VA = "0x181685DC0")]
		public void SetMenu(int index)
		{
		}

		// Token: 0x06013A3E RID: 80446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A3E")]
		[Address(RVA = "0x1686050", Offset = "0x1685450", VA = "0x181686050")]
		private void UpdateMenus()
		{
		}

		// Token: 0x06013A3F RID: 80447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A3F")]
		[Address(RVA = "0x16851B0", Offset = "0x16845B0", VA = "0x1816851B0")]
		public void JoinShootingRange()
		{
		}

		// Token: 0x06013A40 RID: 80448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A40")]
		[Address(RVA = "0x1684020", Offset = "0x1683420", VA = "0x181684020")]
		public void DiscordOpen()
		{
		}

		// Token: 0x06013A41 RID: 80449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A41")]
		[Address(RVA = "0x1685DD0", Offset = "0x16851D0", VA = "0x181685DD0")]
		public void ShootingRange()
		{
		}

		// Token: 0x06013A42 RID: 80450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A42")]
		[Address(RVA = "0x16841A0", Offset = "0x16835A0", VA = "0x1816841A0")]
		public void DownloadVisualPLus()
		{
		}

		// Token: 0x06013A43 RID: 80451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A43")]
		[Address(RVA = "0x1685930", Offset = "0x1684D30", VA = "0x181685930")]
		public void OnDiscordConnectPressed()
		{
		}

		// Token: 0x06013A44 RID: 80452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A44")]
		[Address(RVA = "0x1685DA0", Offset = "0x16851A0", VA = "0x181685DA0")]
		public void OnServerBrowserPressed()
		{
		}

		// Token: 0x06013A45 RID: 80453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A45")]
		[Address(RVA = "0x1686980", Offset = "0x1685D80", VA = "0x181686980")]
		public void UpdateRoles()
		{
		}

		// Token: 0x06013A46 RID: 80454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A46")]
		[Address(RVA = "0x1685CE0", Offset = "0x16850E0", VA = "0x181685CE0")]
		private void OnReceivedToken(string obj)
		{
		}

		// Token: 0x06013A47 RID: 80455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A47")]
		[Address(RVA = "0x1685BF0", Offset = "0x1684FF0", VA = "0x181685BF0")]
		private void OnReceivedDiscordRegisterResponse(bool obj, \u0304\u0307\u0306\u0305\u0305\u0304\u0308\u0305\u0302\u0304\u0308\u0303\u0306\u0303\u0304 roles)
		{
		}

		// Token: 0x06013A48 RID: 80456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A48")]
		[Address(RVA = "0x1685120", Offset = "0x1684520", VA = "0x181685120")]
		private void JoinServer()
		{
		}

		// Token: 0x06013A49 RID: 80457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A49")]
		[Address(RVA = "0x1685540", Offset = "0x1684940", VA = "0x181685540")]
		public static void LoadMainMenu()
		{
		}

		// Token: 0x06013A4B RID: 80459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A4B")]
		[Address(RVA = "0x1685F70", Offset = "0x1685370", VA = "0x181685F70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private void <UpdateRoles>g__add|92_0(string str)
		{
		}

		// Token: 0x0400375F RID: 14175
		[Token(Token = "0x400375F")]
		[FieldOffset(Offset = "0x0")]
		public static bool InMainMenu;

		// Token: 0x04003760 RID: 14176
		[Token(Token = "0x4003760")]
		[FieldOffset(Offset = "0x8")]
		public static MainMenu Instance;

		// Token: 0x04003761 RID: 14177
		[Token(Token = "0x4003761")]
		[FieldOffset(Offset = "0x10")]
		public static IPEndPoint TargetServer;

		// Token: 0x04003762 RID: 14178
		[Token(Token = "0x4003762")]
		[FieldOffset(Offset = "0x18")]
		public static bool IsJoining;

		// Token: 0x04003763 RID: 14179
		[Token(Token = "0x4003763")]
		[FieldOffset(Offset = "0x1C")]
		private static float mLastLoadedMainMenu;

		// Token: 0x04003764 RID: 14180
		[Token(Token = "0x4003764")]
		[FieldOffset(Offset = "0x18")]
		public CanvasScaler Scaler;

		// Token: 0x04003765 RID: 14181
		[Token(Token = "0x4003765")]
		[FieldOffset(Offset = "0x20")]
		public CanvasGroup[] SocialTabs;

		// Token: 0x04003766 RID: 14182
		[Token(Token = "0x4003766")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x161810", Offset = "0x160C10")]
		public \u0308\u0308\u0307\u0303\u0301\u0301\u0308\u0302\u0305\u0302\u0301\u0306\u0301\u0308\u0308 Regions;

		// Token: 0x04003767 RID: 14183
		[Token(Token = "0x4003767")]
		[FieldOffset(Offset = "0x30")]
		public CanvasGroup IntroParent;

		// Token: 0x04003768 RID: 14184
		[Token(Token = "0x4003768")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup MenuParent;

		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup IntroChild;

		// Token: 0x0400376A RID: 14186
		[Token(Token = "0x400376A")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform Logo;

		// Token: 0x0400376B RID: 14187
		[Token(Token = "0x400376B")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform MenuTop;

		// Token: 0x0400376C RID: 14188
		[Token(Token = "0x400376C")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI ConnectingToServerLabel;

		// Token: 0x0400376D RID: 14189
		[Token(Token = "0x400376D")]
		[FieldOffset(Offset = "0x60")]
		public CanvasGroup LogoCanvas;

		// Token: 0x0400376E RID: 14190
		[Token(Token = "0x400376E")]
		[FieldOffset(Offset = "0x68")]
		public \u0301\u0304\u0305\u0308\u0301\u0307\u0305\u0306\u0302\u0301\u0308\u0305\u0301\u0304\u0307 Eula;

		// Token: 0x0400376F RID: 14191
		[Token(Token = "0x400376F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x161890", Offset = "0x160C90")]
		public GameObject ServerBrowser;

		// Token: 0x04003770 RID: 14192
		[Token(Token = "0x4003770")]
		[FieldOffset(Offset = "0x78")]
		public ServerList ServerList;

		// Token: 0x04003771 RID: 14193
		[Token(Token = "0x4003771")]
		[FieldOffset(Offset = "0x80")]
		public CanvasGroup[] Menus;

		// Token: 0x04003772 RID: 14194
		[Token(Token = "0x4003772")]
		[FieldOffset(Offset = "0x88")]
		public CardSlider MainMenuSlider;

		// Token: 0x04003773 RID: 14195
		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x161940", Offset = "0x160D40")]
		public CanvasGroup ConnectingToMaster;

		// Token: 0x04003774 RID: 14196
		[Token(Token = "0x4003774")]
		[FieldOffset(Offset = "0x98")]
		public CanvasGroup EpilepsyCanvas;

		// Token: 0x04003775 RID: 14197
		[Token(Token = "0x4003775")]
		[FieldOffset(Offset = "0xA0")]
		public CanvasGroup SteamDown;

		// Token: 0x04003776 RID: 14198
		[Token(Token = "0x4003776")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup Eac;

		// Token: 0x04003777 RID: 14199
		[Token(Token = "0x4003777")]
		[FieldOffset(Offset = "0xB0")]
		public CanvasGroup Faceit;

		// Token: 0x04003778 RID: 14200
		[Token(Token = "0x4003778")]
		[FieldOffset(Offset = "0xB8")]
		public CanvasGroup SteamRestart;

		// Token: 0x04003779 RID: 14201
		[Token(Token = "0x4003779")]
		[FieldOffset(Offset = "0xC0")]
		public CanvasGroup AccountNew;

		// Token: 0x0400377A RID: 14202
		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0xC8")]
		public CanvasGroup GPUNotSupported;

		// Token: 0x0400377B RID: 14203
		[Token(Token = "0x400377B")]
		[FieldOffset(Offset = "0xD0")]
		public CanvasGroup VisualCplus;

		// Token: 0x0400377C RID: 14204
		[Token(Token = "0x400377C")]
		[FieldOffset(Offset = "0xD8")]
		public CanvasGroup SteamReload;

		// Token: 0x0400377D RID: 14205
		[Token(Token = "0x400377D")]
		[FieldOffset(Offset = "0xE0")]
		public CanvasGroup FamilyShareNotSupported;

		// Token: 0x0400377E RID: 14206
		[Token(Token = "0x400377E")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1619F0", Offset = "0x160DF0")]
		public Transform PacksParent;

		// Token: 0x0400377F RID: 14207
		[Token(Token = "0x400377F")]
		[FieldOffset(Offset = "0xF0")]
		public TextMeshProUGUI PacksElement;

		// Token: 0x04003780 RID: 14208
		[Token(Token = "0x4003780")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x161A80", Offset = "0x160E80")]
		public GameObject LoadingBar;

		// Token: 0x04003781 RID: 14209
		[Token(Token = "0x4003781")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI LoadingLabel;

		// Token: 0x04003782 RID: 14210
		[Token(Token = "0x4003782")]
		[FieldOffset(Offset = "0x108")]
		public RectTransform LoadingBarValue;

		// Token: 0x04003783 RID: 14211
		[Token(Token = "0x4003783")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <MenuIndex>k__BackingField;

		// Token: 0x04003784 RID: 14212
		[Token(Token = "0x4003784")]
		[FieldOffset(Offset = "0x114")]
		private int mastercounter;

		// Token: 0x04003785 RID: 14213
		[Token(Token = "0x4003785")]
		[FieldOffset(Offset = "0x118")]
		private bool _isConnected;

		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		[FieldOffset(Offset = "0x11C")]
		private float lastTime;

		// Token: 0x04003787 RID: 14215
		[Token(Token = "0x4003787")]
		[FieldOffset(Offset = "0x120")]
		private float mStartTime;

		// Token: 0x04003788 RID: 14216
		[Token(Token = "0x4003788")]
		[FieldOffset(Offset = "0x124")]
		private float steamRichUpdate;

		// Token: 0x04003789 RID: 14217
		[Token(Token = "0x4003789")]
		[FieldOffset(Offset = "0x128")]
		private float mLastRequest;

		// Token: 0x0400378A RID: 14218
		[Token(Token = "0x400378A")]
		[FieldOffset(Offset = "0x12C")]
		private bool mWaitForTicket;

		// Token: 0x0400378B RID: 14219
		[Token(Token = "0x400378B")]
		[FieldOffset(Offset = "0x130")]
		private \u0305\u0302\u0307\u0307\u0307\u0301\u0308\u0307\u0304\u0305\u0307\u0303\u0304\u0303\u0304 mJoinHandle;

		// Token: 0x0400378C RID: 14220
		[Token(Token = "0x400378C")]
		[FieldOffset(Offset = "0x138")]
		private UIPool<TextMeshProUGUI> mPacksPool;

		// Token: 0x0400378D RID: 14221
		[Token(Token = "0x400378D")]
		[FieldOffset(Offset = "0x140")]
		private List<TextMeshProUGUI> mPacksActive;

		// Token: 0x0400378E RID: 14222
		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x161B50", Offset = "0x160F50")]
		public RawImage ProfileIcon;

		// Token: 0x0400378F RID: 14223
		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0x150")]
		public TextMeshProUGUI ProfileName;

		// Token: 0x04003790 RID: 14224
		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x158")]
		public TextMeshProUGUI ProfilePrestige;

		// Token: 0x04003791 RID: 14225
		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0x160")]
		public Image ProfilePrestigeValue;

		// Token: 0x04003792 RID: 14226
		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x168")]
		public Image ProfilePrestigeBackground;

		// Token: 0x04003793 RID: 14227
		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0x170")]
		public TextMeshProUGUI ProfileRank;

		// Token: 0x04003794 RID: 14228
		[Token(Token = "0x4003794")]
		[FieldOffset(Offset = "0x178")]
		public Image ProfileRankValue;

		// Token: 0x04003795 RID: 14229
		[Token(Token = "0x4003795")]
		[FieldOffset(Offset = "0x180")]
		public Image ProfileRankImage;

		// Token: 0x04003796 RID: 14230
		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x188")]
		public GameObject[] ProfilePatreon;

		// Token: 0x04003797 RID: 14231
		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0x190")]
		public GameObject[] ProfileSupporter;

		// Token: 0x04003798 RID: 14232
		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0x198")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x161BB0", Offset = "0x160FB0")]
		public CanvasGroup InClan;

		// Token: 0x04003799 RID: 14233
		[Token(Token = "0x4003799")]
		[FieldOffset(Offset = "0x1A0")]
		public CanvasGroup NotInClan;

		// Token: 0x0400379A RID: 14234
		[Token(Token = "0x400379A")]
		[FieldOffset(Offset = "0x1A8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x163000", Offset = "0x162400")]
		public GameObject LangTab;

		// Token: 0x0200075C RID: 1884
		[Token(Token = "0x200075C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06013A4D RID: 80461 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013A4D")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c()
			{
			}

			// Token: 0x06013A4E RID: 80462 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013A4E")]
			[Address(RVA = "0x1699350", Offset = "0x1698750", VA = "0x181699350")]
			internal void <ConnectServer>b__77_0(bool exists, DateTime until, string reason)
			{
			}

			// Token: 0x06013A4F RID: 80463 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013A4F")]
			[Address(RVA = "0x1699370", Offset = "0x1698770", VA = "0x181699370")]
			internal void <ConnectServer>b__77_1(bool exists, string userText)
			{
			}

			// Token: 0x0400379B RID: 14235
			[Token(Token = "0x400379B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MainMenu.<>c <>9;

			// Token: 0x0400379C RID: 14236
			[Token(Token = "0x400379C")]
			[FieldOffset(Offset = "0x8")]
			public static Action<bool, DateTime, string> <>9__77_0;

			// Token: 0x0400379D RID: 14237
			[Token(Token = "0x400379D")]
			[FieldOffset(Offset = "0x10")]
			public static Action<bool, string> <>9__77_1;
		}

		// Token: 0x0200075D RID: 1885
		[Token(Token = "0x200075D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <ConnectServer>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06013A50 RID: 80464 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013A50")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <ConnectServer>d__77(int <>1__state)
			{
			}

			// Token: 0x06013A51 RID: 80465 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013A51")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013A52 RID: 80466 RVA: 0x0007CF7C File Offset: 0x0007B17C
			[Token(Token = "0x6013A52")]
			[Address(RVA = "0x1697F10", Offset = "0x1697310", VA = "0x181697F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x06013A53 RID: 80467 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B87")]
			private object Current
			{
				[Token(Token = "0x6013A53")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013A54 RID: 80468 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013A54")]
			[Address(RVA = "0x1698610", Offset = "0x1697A10", VA = "0x181698610", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06013A55 RID: 80469 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B88")]
			private object Current
			{
				[Token(Token = "0x6013A55")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400379E RID: 14238
			[Token(Token = "0x400379E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400379F RID: 14239
			[Token(Token = "0x400379F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040037A0 RID: 14240
			[Token(Token = "0x40037A0")]
			[FieldOffset(Offset = "0x20")]
			public MainMenu <>4__this;
		}
	}
}
