using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UserInterface.PauseMenu.Options;
using UserInterface.PauseMenu.Options.Behaviours;

namespace UserInterface.PauseMenu
{
	// Token: 0x0200076F RID: 1903
	[Token(Token = "0x200076F")]
	[Serializable]
	public class MenuGamePlay : IEnumerable<IOptionsElement>, IEnumerable
	{
		// Token: 0x06013AE8 RID: 80616 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013AE8")]
		[Address(RVA = "0x188AAA0", Offset = "0x1889EA0", VA = "0x18188AAA0", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1662A0", Offset = "0x1656A0")]
		public IEnumerator<IOptionsElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013AE9 RID: 80617 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013AE9")]
		[Address(RVA = "0x188AAA0", Offset = "0x1889EA0", VA = "0x18188AAA0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013AEA RID: 80618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AEA")]
		[Address(RVA = "0x18884E0", Offset = "0x18878E0", VA = "0x1818884E0")]
		public void ApplyToSettings()
		{
		}

		// Token: 0x06013AEB RID: 80619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AEB")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public MenuGamePlay()
		{
		}

		// Token: 0x04003898 RID: 14488
		[Token(Token = "0x4003898")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165E30", Offset = "0x165230")]
		public ToggleBehaviour ToggleMap;

		// Token: 0x04003899 RID: 14489
		[Token(Token = "0x4003899")]
		[FieldOffset(Offset = "0x18")]
		public ToggleBehaviour RunningDot;

		// Token: 0x0400389A RID: 14490
		[Token(Token = "0x400389A")]
		[FieldOffset(Offset = "0x20")]
		public ToggleBehaviour ShowPings;

		// Token: 0x0400389B RID: 14491
		[Token(Token = "0x400389B")]
		[FieldOffset(Offset = "0x28")]
		public ToggleBehaviour ShowBorders;

		// Token: 0x0400389C RID: 14492
		[Token(Token = "0x400389C")]
		[FieldOffset(Offset = "0x30")]
		public ToggleBehaviour AutoReady;

		// Token: 0x0400389D RID: 14493
		[Token(Token = "0x400389D")]
		[FieldOffset(Offset = "0x38")]
		public ToggleBehaviour ShareLoadout;

		// Token: 0x0400389E RID: 14494
		[Token(Token = "0x400389E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165F60", Offset = "0x165360")]
		public ToggleBehaviour HitMarkers;

		// Token: 0x0400389F RID: 14495
		[Token(Token = "0x400389F")]
		[FieldOffset(Offset = "0x48")]
		public ToggleBehaviour ShowLevelProgression;

		// Token: 0x040038A0 RID: 14496
		[Token(Token = "0x40038A0")]
		[FieldOffset(Offset = "0x50")]
		public ToggleBehaviour ShowSquadList;

		// Token: 0x040038A1 RID: 14497
		[Token(Token = "0x40038A1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x14B990", Offset = "0x14AD90")]
		public ColorPickerBehaviour DefaultHitMarkerColor;

		// Token: 0x040038A2 RID: 14498
		[Token(Token = "0x40038A2")]
		[FieldOffset(Offset = "0x60")]
		public SliderBehaviour DefaultHitMarkerOpacity;

		// Token: 0x040038A3 RID: 14499
		[Token(Token = "0x40038A3")]
		[FieldOffset(Offset = "0x68")]
		public SliderBehaviour DefaultHitMarkerVolume;

		// Token: 0x040038A4 RID: 14500
		[Token(Token = "0x40038A4")]
		[FieldOffset(Offset = "0x70")]
		public SliderBehaviour DefaultHitMarkerFade;

		// Token: 0x040038A5 RID: 14501
		[Token(Token = "0x40038A5")]
		[FieldOffset(Offset = "0x78")]
		public SliderBehaviour DefaultHitMarkerSize;

		// Token: 0x040038A6 RID: 14502
		[Token(Token = "0x40038A6")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x14B990", Offset = "0x14AD90")]
		public ColorPickerBehaviour HeadshotHitMarkerColor;

		// Token: 0x040038A7 RID: 14503
		[Token(Token = "0x40038A7")]
		[FieldOffset(Offset = "0x88")]
		public SliderBehaviour HeadshotHitMarkerOpacity;

		// Token: 0x040038A8 RID: 14504
		[Token(Token = "0x40038A8")]
		[FieldOffset(Offset = "0x90")]
		public SliderBehaviour HeadshotHitMarkerVolume;

		// Token: 0x040038A9 RID: 14505
		[Token(Token = "0x40038A9")]
		[FieldOffset(Offset = "0x98")]
		public SliderBehaviour HeadshotHitMarkerFade;

		// Token: 0x040038AA RID: 14506
		[Token(Token = "0x40038AA")]
		[FieldOffset(Offset = "0xA0")]
		public SliderBehaviour HeadshotHitMarkerSize;

		// Token: 0x040038AB RID: 14507
		[Token(Token = "0x40038AB")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x14B990", Offset = "0x14AD90")]
		public ColorPickerBehaviour ArmorHitMarkerColor;

		// Token: 0x040038AC RID: 14508
		[Token(Token = "0x40038AC")]
		[FieldOffset(Offset = "0xB0")]
		public SliderBehaviour ArmorHitMarkerOpacity;

		// Token: 0x040038AD RID: 14509
		[Token(Token = "0x40038AD")]
		[FieldOffset(Offset = "0xB8")]
		public SliderBehaviour ArmorHitMarkerVolume;

		// Token: 0x040038AE RID: 14510
		[Token(Token = "0x40038AE")]
		[FieldOffset(Offset = "0xC0")]
		public SliderBehaviour ArmorHitMarkerFade;

		// Token: 0x040038AF RID: 14511
		[Token(Token = "0x40038AF")]
		[FieldOffset(Offset = "0xC8")]
		public SliderBehaviour ArmorHitMarkerSize;

		// Token: 0x040038B0 RID: 14512
		[Token(Token = "0x40038B0")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x14B990", Offset = "0x14AD90")]
		public ColorPickerBehaviour KillHitMarkerColor;

		// Token: 0x040038B1 RID: 14513
		[Token(Token = "0x40038B1")]
		[FieldOffset(Offset = "0xD8")]
		public SliderBehaviour KillHitMarkerOpacity;

		// Token: 0x040038B2 RID: 14514
		[Token(Token = "0x40038B2")]
		[FieldOffset(Offset = "0xE0")]
		public SliderBehaviour KillHitMarkerVolume;

		// Token: 0x040038B3 RID: 14515
		[Token(Token = "0x40038B3")]
		[FieldOffset(Offset = "0xE8")]
		public SliderBehaviour KillHitMarkerFade;

		// Token: 0x040038B4 RID: 14516
		[Token(Token = "0x40038B4")]
		[FieldOffset(Offset = "0xF0")]
		public SliderBehaviour KillHitMarkerSize;

		// Token: 0x040038B5 RID: 14517
		[Token(Token = "0x40038B5")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166080", Offset = "0x165480")]
		public ToggleBehaviour KillFeed;

		// Token: 0x040038B6 RID: 14518
		[Token(Token = "0x40038B6")]
		[FieldOffset(Offset = "0x100")]
		public EnumBehaviour ScoreboardStyle;

		// Token: 0x040038B7 RID: 14519
		[Token(Token = "0x40038B7")]
		[FieldOffset(Offset = "0x108")]
		public ColorPickerBehaviour FriendlyColor;

		// Token: 0x040038B8 RID: 14520
		[Token(Token = "0x40038B8")]
		[FieldOffset(Offset = "0x110")]
		public ColorPickerBehaviour SteamFriendColor;

		// Token: 0x040038B9 RID: 14521
		[Token(Token = "0x40038B9")]
		[FieldOffset(Offset = "0x118")]
		public ColorPickerBehaviour PartyMemberColor;

		// Token: 0x040038BA RID: 14522
		[Token(Token = "0x40038BA")]
		[FieldOffset(Offset = "0x120")]
		public ColorPickerBehaviour SquadFriendColor;

		// Token: 0x040038BB RID: 14523
		[Token(Token = "0x40038BB")]
		[FieldOffset(Offset = "0x128")]
		public ColorPickerBehaviour SquadLeaderColor;

		// Token: 0x040038BC RID: 14524
		[Token(Token = "0x40038BC")]
		[FieldOffset(Offset = "0x130")]
		public ColorPickerBehaviour EnemyColor;

		// Token: 0x040038BD RID: 14525
		[Token(Token = "0x40038BD")]
		[FieldOffset(Offset = "0x138")]
		public SliderBehaviour FriendlyIconFade;

		// Token: 0x040038BE RID: 14526
		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0x140")]
		public SliderBehaviour SquadFriendIconFade;

		// Token: 0x040038BF RID: 14527
		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x148")]
		public SliderBehaviour SquadLeaderIconFade;

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x150")]
		public SliderBehaviour FriendlyIconSize;

		// Token: 0x040038C1 RID: 14529
		[Token(Token = "0x40038C1")]
		[FieldOffset(Offset = "0x158")]
		public SliderBehaviour SteamFriendIconSize;

		// Token: 0x040038C2 RID: 14530
		[Token(Token = "0x40038C2")]
		[FieldOffset(Offset = "0x160")]
		public SliderBehaviour PartyMemberIconSize;

		// Token: 0x040038C3 RID: 14531
		[Token(Token = "0x40038C3")]
		[FieldOffset(Offset = "0x168")]
		public SliderBehaviour SquadFriendIconSize;

		// Token: 0x040038C4 RID: 14532
		[Token(Token = "0x40038C4")]
		[FieldOffset(Offset = "0x170")]
		public SliderBehaviour SquadLeaderIconSize;

		// Token: 0x040038C5 RID: 14533
		[Token(Token = "0x40038C5")]
		[FieldOffset(Offset = "0x178")]
		public ColorPickerBehaviour AllyObjective;

		// Token: 0x040038C6 RID: 14534
		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0x180")]
		public ColorPickerBehaviour EnemyObjective;

		// Token: 0x040038C7 RID: 14535
		[Token(Token = "0x40038C7")]
		[FieldOffset(Offset = "0x188")]
		public ColorPickerBehaviour NeutralObjective;

		// Token: 0x040038C8 RID: 14536
		[Token(Token = "0x40038C8")]
		[FieldOffset(Offset = "0x190")]
		public SliderBehaviour FriendlyOutlineMaxDistance;

		// Token: 0x040038C9 RID: 14537
		[Token(Token = "0x40038C9")]
		[FieldOffset(Offset = "0x198")]
		public SliderBehaviour FriendlyOutlineIntensity;

		// Token: 0x040038CA RID: 14538
		[Token(Token = "0x40038CA")]
		[FieldOffset(Offset = "0x1A0")]
		public SliderBehaviour FriendlyNameTagSize;

		// Token: 0x040038CB RID: 14539
		[Token(Token = "0x40038CB")]
		[FieldOffset(Offset = "0x1A8")]
		public ToggleBehaviour ShowFPS;

		// Token: 0x040038CC RID: 14540
		[Token(Token = "0x40038CC")]
		[FieldOffset(Offset = "0x1B0")]
		public ToggleBehaviour ShowNetworkStats;

		// Token: 0x040038CD RID: 14541
		[Token(Token = "0x40038CD")]
		[FieldOffset(Offset = "0x1B8")]
		public SliderBehaviour PingSize;

		// Token: 0x040038CE RID: 14542
		[Token(Token = "0x40038CE")]
		[FieldOffset(Offset = "0x1C0")]
		public SliderBehaviour FlagSize;

		// Token: 0x040038CF RID: 14543
		[Token(Token = "0x40038CF")]
		[FieldOffset(Offset = "0x1C8")]
		public SliderBehaviour FlagOpacity;

		// Token: 0x040038D0 RID: 14544
		[Token(Token = "0x40038D0")]
		[FieldOffset(Offset = "0x1D0")]
		public SliderBehaviour NonTargetFlagOpacity;

		// Token: 0x040038D1 RID: 14545
		[Token(Token = "0x40038D1")]
		[FieldOffset(Offset = "0x1D8")]
		public SliderBehaviour BorderOpacity;

		// Token: 0x040038D2 RID: 14546
		[Token(Token = "0x40038D2")]
		[FieldOffset(Offset = "0x1E0")]
		public SliderBehaviour CrosshairSize;

		// Token: 0x040038D3 RID: 14547
		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x1E8")]
		public SliderBehaviour CrosshairOpacity;

		// Token: 0x040038D4 RID: 14548
		[Token(Token = "0x40038D4")]
		[FieldOffset(Offset = "0x1F0")]
		public ColorPickerBehaviour CrosshairColor;

		// Token: 0x040038D5 RID: 14549
		[Token(Token = "0x40038D5")]
		[FieldOffset(Offset = "0x1F8")]
		public ToggleBehaviour ShowKeybindings;

		// Token: 0x040038D6 RID: 14550
		[Token(Token = "0x40038D6")]
		[FieldOffset(Offset = "0x200")]
		public ToggleBehaviour ShowButtonToPingOnFlags;

		// Token: 0x040038D7 RID: 14551
		[Token(Token = "0x40038D7")]
		[FieldOffset(Offset = "0x208")]
		public ToggleBehaviour ShowButtonToPingToHelp;

		// Token: 0x040038D8 RID: 14552
		[Token(Token = "0x40038D8")]
		[FieldOffset(Offset = "0x210")]
		public ToggleBehaviour EnableChat;

		// Token: 0x040038D9 RID: 14553
		[Token(Token = "0x40038D9")]
		[FieldOffset(Offset = "0x218")]
		public ToggleBehaviour AllChat;

		// Token: 0x040038DA RID: 14554
		[Token(Token = "0x40038DA")]
		[FieldOffset(Offset = "0x220")]
		public ToggleBehaviour TeamChat;

		// Token: 0x040038DB RID: 14555
		[Token(Token = "0x40038DB")]
		[FieldOffset(Offset = "0x228")]
		public ToggleBehaviour AutoHide;

		// Token: 0x040038DC RID: 14556
		[Token(Token = "0x40038DC")]
		[FieldOffset(Offset = "0x230")]
		public SliderBehaviour ChatOpaque;

		// Token: 0x040038DD RID: 14557
		[Token(Token = "0x40038DD")]
		[FieldOffset(Offset = "0x238")]
		public SliderBehaviour ChatSize;

		// Token: 0x040038DE RID: 14558
		[Token(Token = "0x40038DE")]
		[FieldOffset(Offset = "0x240")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166100", Offset = "0x165500")]
		public ColorPickerBehaviour MapMainGridColor;

		// Token: 0x040038DF RID: 14559
		[Token(Token = "0x40038DF")]
		[FieldOffset(Offset = "0x248")]
		public SliderBehaviour MapMainGridSize;

		// Token: 0x040038E0 RID: 14560
		[Token(Token = "0x40038E0")]
		[FieldOffset(Offset = "0x250")]
		public ColorPickerBehaviour MapChildGridColor;

		// Token: 0x040038E1 RID: 14561
		[Token(Token = "0x40038E1")]
		[FieldOffset(Offset = "0x258")]
		public SliderBehaviour MapChildGridSize;

		// Token: 0x040038E2 RID: 14562
		[Token(Token = "0x40038E2")]
		[FieldOffset(Offset = "0x260")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166210", Offset = "0x165610")]
		public ColorPickerBehaviour TankHUD;

		// Token: 0x040038E3 RID: 14563
		[Token(Token = "0x40038E3")]
		[FieldOffset(Offset = "0x268")]
		public ColorPickerBehaviour ApcHUD;

		// Token: 0x040038E4 RID: 14564
		[Token(Token = "0x40038E4")]
		[FieldOffset(Offset = "0x270")]
		public ColorPickerBehaviour HelicopterHUD;

		// Token: 0x02000770 RID: 1904
		[Token(Token = "0x2000770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <GetEnumerator>d__0 : IEnumerator<IOptionsElement>, IEnumerator, IDisposable
		{
			// Token: 0x06013AEC RID: 80620 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013AEC")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <GetEnumerator>d__0(int <>1__state)
			{
			}

			// Token: 0x06013AED RID: 80621 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013AED")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013AEE RID: 80622 RVA: 0x0007D0B4 File Offset: 0x0007B2B4
			[Token(Token = "0x6013AEE")]
			[Address(RVA = "0x1895BE0", Offset = "0x1894FE0", VA = "0x181895BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x06013AEF RID: 80623 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B93")]
			private IOptionsElement Current
			{
				[Token(Token = "0x6013AEF")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013AF0 RID: 80624 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013AF0")]
			[Address(RVA = "0x18987C0", Offset = "0x1897BC0", VA = "0x1818987C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x06013AF1 RID: 80625 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B94")]
			private object Current
			{
				[Token(Token = "0x6013AF1")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040038E5 RID: 14565
			[Token(Token = "0x40038E5")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040038E6 RID: 14566
			[Token(Token = "0x40038E6")]
			[FieldOffset(Offset = "0x18")]
			private IOptionsElement <>2__current;

			// Token: 0x040038E7 RID: 14567
			[Token(Token = "0x40038E7")]
			[FieldOffset(Offset = "0x20")]
			public MenuGamePlay <>4__this;
		}
	}
}
