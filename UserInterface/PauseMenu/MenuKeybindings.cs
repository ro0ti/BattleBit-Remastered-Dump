using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UserInterface.PauseMenu.Options;
using UserInterface.PauseMenu.Options.Behaviours;

namespace UserInterface.PauseMenu
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	[Serializable]
	public class MenuKeybindings : IEnumerable<IOptionsElement>, IEnumerable
	{
		// Token: 0x06013AFC RID: 80636 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013AFC")]
		[Address(RVA = "0x188C360", Offset = "0x188B760", VA = "0x18188C360", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x168BC0", Offset = "0x167FC0")]
		public IEnumerator<IOptionsElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013AFD RID: 80637 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013AFD")]
		[Address(RVA = "0x188C360", Offset = "0x188B760", VA = "0x18188C360", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013AFE RID: 80638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AFE")]
		[Address(RVA = "0x188AB10", Offset = "0x1889F10", VA = "0x18188AB10")]
		public void ApplyToSettings()
		{
		}

		// Token: 0x06013AFF RID: 80639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AFF")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public MenuKeybindings()
		{
		}

		// Token: 0x04003903 RID: 14595
		[Token(Token = "0x4003903")]
		[FieldOffset(Offset = "0x10")]
		public BindingBehaviour InfVerticalLook;

		// Token: 0x04003904 RID: 14596
		[Token(Token = "0x4003904")]
		[FieldOffset(Offset = "0x18")]
		public BindingBehaviour InfHorizontalLook;

		// Token: 0x04003905 RID: 14597
		[Token(Token = "0x4003905")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166DC0", Offset = "0x1661C0")]
		public BindingBehaviour Forward;

		// Token: 0x04003906 RID: 14598
		[Token(Token = "0x4003906")]
		[FieldOffset(Offset = "0x28")]
		public BindingBehaviour Backward;

		// Token: 0x04003907 RID: 14599
		[Token(Token = "0x4003907")]
		[FieldOffset(Offset = "0x30")]
		public BindingBehaviour Right;

		// Token: 0x04003908 RID: 14600
		[Token(Token = "0x4003908")]
		[FieldOffset(Offset = "0x38")]
		public BindingBehaviour Left;

		// Token: 0x04003909 RID: 14601
		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x40")]
		public BindingBehaviour Run;

		// Token: 0x0400390A RID: 14602
		[Token(Token = "0x400390A")]
		[FieldOffset(Offset = "0x48")]
		public BindingBehaviour Crouch;

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x50")]
		public BindingBehaviour Prone;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x58")]
		public BindingBehaviour ToggleCrouch;

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x60")]
		public BindingBehaviour LeanLeft;

		// Token: 0x0400390E RID: 14606
		[Token(Token = "0x400390E")]
		[FieldOffset(Offset = "0x68")]
		public BindingBehaviour LeanRight;

		// Token: 0x0400390F RID: 14607
		[Token(Token = "0x400390F")]
		[FieldOffset(Offset = "0x70")]
		public BindingBehaviour Vault;

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x78")]
		public BindingBehaviour Jump;

		// Token: 0x04003911 RID: 14609
		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0x80")]
		public BindingBehaviour FreeLook;

		// Token: 0x04003912 RID: 14610
		[Token(Token = "0x4003912")]
		[FieldOffset(Offset = "0x88")]
		public BindingBehaviour Drag;

		// Token: 0x04003913 RID: 14611
		[Token(Token = "0x4003913")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166EC0", Offset = "0x1662C0")]
		public BindingBehaviour DroneForward;

		// Token: 0x04003914 RID: 14612
		[Token(Token = "0x4003914")]
		[FieldOffset(Offset = "0x98")]
		public BindingBehaviour DroneBackward;

		// Token: 0x04003915 RID: 14613
		[Token(Token = "0x4003915")]
		[FieldOffset(Offset = "0xA0")]
		public BindingBehaviour DroneRight;

		// Token: 0x04003916 RID: 14614
		[Token(Token = "0x4003916")]
		[FieldOffset(Offset = "0xA8")]
		public BindingBehaviour DroneLeft;

		// Token: 0x04003917 RID: 14615
		[Token(Token = "0x4003917")]
		[FieldOffset(Offset = "0xB0")]
		public BindingBehaviour DroneThrottleUp;

		// Token: 0x04003918 RID: 14616
		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0xB8")]
		public BindingBehaviour DroneThrottleDown;

		// Token: 0x04003919 RID: 14617
		[Token(Token = "0x4003919")]
		[FieldOffset(Offset = "0xC0")]
		public BindingBehaviour DroneIncraseSpeed;

		// Token: 0x0400391A RID: 14618
		[Token(Token = "0x400391A")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166FD0", Offset = "0x1663D0")]
		public BindingBehaviour NightVision;

		// Token: 0x0400391B RID: 14619
		[Token(Token = "0x400391B")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x167180", Offset = "0x166580")]
		public BindingBehaviour Fire;

		// Token: 0x0400391C RID: 14620
		[Token(Token = "0x400391C")]
		[FieldOffset(Offset = "0xD8")]
		public BindingBehaviour Fire2;

		// Token: 0x0400391D RID: 14621
		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0xE0")]
		public BindingBehaviour Ads;

		// Token: 0x0400391E RID: 14622
		[Token(Token = "0x400391E")]
		[FieldOffset(Offset = "0xE8")]
		public BindingBehaviour FireMode;

		// Token: 0x0400391F RID: 14623
		[Token(Token = "0x400391F")]
		[FieldOffset(Offset = "0xF0")]
		public BindingBehaviour ZeroingUp;

		// Token: 0x04003920 RID: 14624
		[Token(Token = "0x4003920")]
		[FieldOffset(Offset = "0xF8")]
		public BindingBehaviour ZeroingDown;

		// Token: 0x04003921 RID: 14625
		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x100")]
		public BindingBehaviour ZeroingAdjusmentHoldKey;

		// Token: 0x04003922 RID: 14626
		[Token(Token = "0x4003922")]
		[FieldOffset(Offset = "0x108")]
		public BindingBehaviour SteadyAim;

		// Token: 0x04003923 RID: 14627
		[Token(Token = "0x4003923")]
		[FieldOffset(Offset = "0x110")]
		public BindingBehaviour Reload;

		// Token: 0x04003924 RID: 14628
		[Token(Token = "0x4003924")]
		[FieldOffset(Offset = "0x118")]
		public BindingBehaviour MagCombine;

		// Token: 0x04003925 RID: 14629
		[Token(Token = "0x4003925")]
		[FieldOffset(Offset = "0x120")]
		public BindingBehaviour MagCheck;

		// Token: 0x04003926 RID: 14630
		[Token(Token = "0x4003926")]
		[FieldOffset(Offset = "0x128")]
		public BindingBehaviour SafetlyMode;

		// Token: 0x04003927 RID: 14631
		[Token(Token = "0x4003927")]
		[FieldOffset(Offset = "0x130")]
		public BindingBehaviour LaserOnOff;

		// Token: 0x04003928 RID: 14632
		[Token(Token = "0x4003928")]
		[FieldOffset(Offset = "0x138")]
		public BindingBehaviour NextSight;

		// Token: 0x04003929 RID: 14633
		[Token(Token = "0x4003929")]
		[FieldOffset(Offset = "0x140")]
		public BindingBehaviour PreviousSight;

		// Token: 0x0400392A RID: 14634
		[Token(Token = "0x400392A")]
		[FieldOffset(Offset = "0x148")]
		public BindingBehaviour FlirChange;

		// Token: 0x0400392B RID: 14635
		[Token(Token = "0x400392B")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1671B0", Offset = "0x1665B0")]
		public BindingBehaviour SwitchNext;

		// Token: 0x0400392C RID: 14636
		[Token(Token = "0x400392C")]
		[FieldOffset(Offset = "0x158")]
		public BindingBehaviour SwitchPrevious;

		// Token: 0x0400392D RID: 14637
		[Token(Token = "0x400392D")]
		[FieldOffset(Offset = "0x160")]
		public BindingBehaviour SwitchPrimary;

		// Token: 0x0400392E RID: 14638
		[Token(Token = "0x400392E")]
		[FieldOffset(Offset = "0x168")]
		public BindingBehaviour SwitchSecondary;

		// Token: 0x0400392F RID: 14639
		[Token(Token = "0x400392F")]
		[FieldOffset(Offset = "0x170")]
		public BindingBehaviour SwitchFirstAid;

		// Token: 0x04003930 RID: 14640
		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x178")]
		public BindingBehaviour SwitchGadgetA;

		// Token: 0x04003931 RID: 14641
		[Token(Token = "0x4003931")]
		[FieldOffset(Offset = "0x180")]
		public BindingBehaviour SwitchGadgetB;

		// Token: 0x04003932 RID: 14642
		[Token(Token = "0x4003932")]
		[FieldOffset(Offset = "0x188")]
		public BindingBehaviour SwitchThrowable;

		// Token: 0x04003933 RID: 14643
		[Token(Token = "0x4003933")]
		[FieldOffset(Offset = "0x190")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1672A0", Offset = "0x1666A0")]
		public BindingBehaviour Interact;

		// Token: 0x04003934 RID: 14644
		[Token(Token = "0x4003934")]
		[FieldOffset(Offset = "0x198")]
		public BindingBehaviour ThrowGadget;

		// Token: 0x04003935 RID: 14645
		[Token(Token = "0x4003935")]
		[FieldOffset(Offset = "0x1A0")]
		public BindingBehaviour CutRope;

		// Token: 0x04003936 RID: 14646
		[Token(Token = "0x4003936")]
		[FieldOffset(Offset = "0x1A8")]
		public BindingBehaviour Push;

		// Token: 0x04003937 RID: 14647
		[Token(Token = "0x4003937")]
		[FieldOffset(Offset = "0x1B0")]
		public BindingBehaviour Build;

		// Token: 0x04003938 RID: 14648
		[Token(Token = "0x4003938")]
		[FieldOffset(Offset = "0x1B8")]
		public BindingBehaviour Unbuild;

		// Token: 0x04003939 RID: 14649
		[Token(Token = "0x4003939")]
		[FieldOffset(Offset = "0x1C0")]
		public BindingBehaviour Repair;

		// Token: 0x0400393A RID: 14650
		[Token(Token = "0x400393A")]
		[FieldOffset(Offset = "0x1C8")]
		public BindingBehaviour DropCash;

		// Token: 0x0400393B RID: 14651
		[Token(Token = "0x400393B")]
		[FieldOffset(Offset = "0x1D0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x167440", Offset = "0x166840")]
		public BindingBehaviour OpenSocialTab;

		// Token: 0x0400393C RID: 14652
		[Token(Token = "0x400393C")]
		[FieldOffset(Offset = "0x1D8")]
		public BindingBehaviour ChatAll;

		// Token: 0x0400393D RID: 14653
		[Token(Token = "0x400393D")]
		[FieldOffset(Offset = "0x1E0")]
		public BindingBehaviour ChatTeam;

		// Token: 0x0400393E RID: 14654
		[Token(Token = "0x400393E")]
		[FieldOffset(Offset = "0x1E8")]
		public BindingBehaviour ChatSquad;

		// Token: 0x0400393F RID: 14655
		[Token(Token = "0x400393F")]
		[FieldOffset(Offset = "0x1F0")]
		public BindingBehaviour VoipLocal;

		// Token: 0x04003940 RID: 14656
		[Token(Token = "0x4003940")]
		[FieldOffset(Offset = "0x1F8")]
		public BindingBehaviour VoipSquad;

		// Token: 0x04003941 RID: 14657
		[Token(Token = "0x4003941")]
		[FieldOffset(Offset = "0x200")]
		public BindingBehaviour VoipSquadLeaders;

		// Token: 0x04003942 RID: 14658
		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x208")]
		public BindingBehaviour Ping;

		// Token: 0x04003943 RID: 14659
		[Token(Token = "0x4003943")]
		[FieldOffset(Offset = "0x210")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166080", Offset = "0x165480")]
		public BindingBehaviour Map;

		// Token: 0x04003944 RID: 14660
		[Token(Token = "0x4003944")]
		[FieldOffset(Offset = "0x218")]
		public BindingBehaviour MapZoom;

		// Token: 0x04003945 RID: 14661
		[Token(Token = "0x4003945")]
		[FieldOffset(Offset = "0x220")]
		public BindingBehaviour Scoreboard;

		// Token: 0x04003946 RID: 14662
		[Token(Token = "0x4003946")]
		[FieldOffset(Offset = "0x228")]
		public BindingBehaviour SquadLeaderMenu;

		// Token: 0x04003947 RID: 14663
		[Token(Token = "0x4003947")]
		[FieldOffset(Offset = "0x230")]
		public BindingBehaviour HideUI;

		// Token: 0x04003948 RID: 14664
		[Token(Token = "0x4003948")]
		[FieldOffset(Offset = "0x238")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x163690", Offset = "0x162A90")]
		public BindingBehaviour SwitchNextSeat;

		// Token: 0x04003949 RID: 14665
		[Token(Token = "0x4003949")]
		[FieldOffset(Offset = "0x240")]
		public BindingBehaviour SwitchPreviousSeat;

		// Token: 0x0400394A RID: 14666
		[Token(Token = "0x400394A")]
		[FieldOffset(Offset = "0x248")]
		public BindingBehaviour EngineOnOff;

		// Token: 0x0400394B RID: 14667
		[Token(Token = "0x400394B")]
		[FieldOffset(Offset = "0x250")]
		public BindingBehaviour LightsOnOff;

		// Token: 0x0400394C RID: 14668
		[Token(Token = "0x400394C")]
		[FieldOffset(Offset = "0x258")]
		public BindingBehaviour Boost;

		// Token: 0x0400394D RID: 14669
		[Token(Token = "0x400394D")]
		[FieldOffset(Offset = "0x260")]
		public BindingBehaviour ZoomIn;

		// Token: 0x0400394E RID: 14670
		[Token(Token = "0x400394E")]
		[FieldOffset(Offset = "0x268")]
		public BindingBehaviour ZoomOut;

		// Token: 0x0400394F RID: 14671
		[Token(Token = "0x400394F")]
		[FieldOffset(Offset = "0x270")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x167680", Offset = "0x166A80")]
		public BindingBehaviour TankAP;

		// Token: 0x04003950 RID: 14672
		[Token(Token = "0x4003950")]
		[FieldOffset(Offset = "0x278")]
		public BindingBehaviour TankHE;

		// Token: 0x04003951 RID: 14673
		[Token(Token = "0x4003951")]
		[FieldOffset(Offset = "0x280")]
		public BindingBehaviour TankStab;

		// Token: 0x04003952 RID: 14674
		[Token(Token = "0x4003952")]
		[FieldOffset(Offset = "0x288")]
		public BindingBehaviour TankSmoke;

		// Token: 0x04003953 RID: 14675
		[Token(Token = "0x4003953")]
		[FieldOffset(Offset = "0x290")]
		public BindingBehaviour SpotterObservePing;

		// Token: 0x04003954 RID: 14676
		[Token(Token = "0x4003954")]
		[FieldOffset(Offset = "0x298")]
		public BindingBehaviour SpotterDangerPing;

		// Token: 0x04003955 RID: 14677
		[Token(Token = "0x4003955")]
		[FieldOffset(Offset = "0x2A0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x167730", Offset = "0x166B30")]
		public BindingBehaviour HelicopterThrottleIncrease;

		// Token: 0x04003956 RID: 14678
		[Token(Token = "0x4003956")]
		[FieldOffset(Offset = "0x2A8")]
		public BindingBehaviour HelicopterThrottleDecrease;

		// Token: 0x04003957 RID: 14679
		[Token(Token = "0x4003957")]
		[FieldOffset(Offset = "0x2B0")]
		public ToggleBehaviour HelicopterThrottleInvert;

		// Token: 0x04003958 RID: 14680
		[Token(Token = "0x4003958")]
		[FieldOffset(Offset = "0x2B8")]
		public BindingBehaviour HelicopterYawRight;

		// Token: 0x04003959 RID: 14681
		[Token(Token = "0x4003959")]
		[FieldOffset(Offset = "0x2C0")]
		public BindingBehaviour HelicopterYawLeft;

		// Token: 0x0400395A RID: 14682
		[Token(Token = "0x400395A")]
		[FieldOffset(Offset = "0x2C8")]
		public ToggleBehaviour HelicopterYawInvert;

		// Token: 0x0400395B RID: 14683
		[Token(Token = "0x400395B")]
		[FieldOffset(Offset = "0x2D0")]
		public BindingBehaviour HelicopterPitchUp;

		// Token: 0x0400395C RID: 14684
		[Token(Token = "0x400395C")]
		[FieldOffset(Offset = "0x2D8")]
		public BindingBehaviour HelicopterPitchDown;

		// Token: 0x0400395D RID: 14685
		[Token(Token = "0x400395D")]
		[FieldOffset(Offset = "0x2E0")]
		public ToggleBehaviour HelicopterPitchInvert;

		// Token: 0x0400395E RID: 14686
		[Token(Token = "0x400395E")]
		[FieldOffset(Offset = "0x2E8")]
		public BindingBehaviour HelicopterRollRight;

		// Token: 0x0400395F RID: 14687
		[Token(Token = "0x400395F")]
		[FieldOffset(Offset = "0x2F0")]
		public BindingBehaviour HelicopterRollLeft;

		// Token: 0x04003960 RID: 14688
		[Token(Token = "0x4003960")]
		[FieldOffset(Offset = "0x2F8")]
		public ToggleBehaviour HelicopterRollInvert;

		// Token: 0x04003961 RID: 14689
		[Token(Token = "0x4003961")]
		[FieldOffset(Offset = "0x300")]
		public BindingBehaviour HelicopterRappellingRope;

		// Token: 0x04003962 RID: 14690
		[Token(Token = "0x4003962")]
		[FieldOffset(Offset = "0x308")]
		public BindingBehaviour HelicopterChangeCamera;

		// Token: 0x02000774 RID: 1908
		[Token(Token = "0x2000774")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <GetEnumerator>d__0 : IEnumerator<IOptionsElement>, IEnumerator, IDisposable
		{
			// Token: 0x06013B00 RID: 80640 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B00")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <GetEnumerator>d__0(int <>1__state)
			{
			}

			// Token: 0x06013B01 RID: 80641 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B01")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013B02 RID: 80642 RVA: 0x0007D0E4 File Offset: 0x0007B2E4
			[Token(Token = "0x6013B02")]
			[Address(RVA = "0x1897310", Offset = "0x1896710", VA = "0x181897310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B97 RID: 2967
			// (get) Token: 0x06013B03 RID: 80643 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B97")]
			private IOptionsElement Current
			{
				[Token(Token = "0x6013B03")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013B04 RID: 80644 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B04")]
			[Address(RVA = "0x1898770", Offset = "0x1897B70", VA = "0x181898770", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B98 RID: 2968
			// (get) Token: 0x06013B05 RID: 80645 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B98")]
			private object Current
			{
				[Token(Token = "0x6013B05")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04003963 RID: 14691
			[Token(Token = "0x4003963")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04003964 RID: 14692
			[Token(Token = "0x4003964")]
			[FieldOffset(Offset = "0x18")]
			private IOptionsElement <>2__current;

			// Token: 0x04003965 RID: 14693
			[Token(Token = "0x4003965")]
			[FieldOffset(Offset = "0x20")]
			public MenuKeybindings <>4__this;
		}
	}
}
