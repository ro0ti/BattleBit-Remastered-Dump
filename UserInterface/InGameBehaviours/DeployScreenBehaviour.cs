using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Extentions;
using UserInterface.InGameBehaviours.DeployScreenSub.SquadSub;

namespace UserInterface.InGameBehaviours
{
	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	public class DeployScreenBehaviour : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x06013BE1 RID: 80865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BE1")]
		[Address(RVA = "0x193FE80", Offset = "0x193F280", VA = "0x18193FE80")]
		public DeployScreenBehaviour()
		{
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06013BE2 RID: 80866 RVA: 0x0007D3FC File Offset: 0x0007B5FC
		// (set) Token: 0x06013BE3 RID: 80867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB4")]
		public int TickIndex8
		{
			[Token(Token = "0x6013BE2")]
			[Address(RVA = "0x8ADF50", Offset = "0x8AD350", VA = "0x1808ADF50", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013BE3")]
			[Address(RVA = "0xA019B0", Offset = "0xA00DB0", VA = "0x180A019B0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06013BE4 RID: 80868 RVA: 0x0007D414 File Offset: 0x0007B614
		// (set) Token: 0x06013BE5 RID: 80869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB5")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013BE4")]
			[Address(RVA = "0xA199D0", Offset = "0xA18DD0", VA = "0x180A199D0", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013BE5")]
			[Address(RVA = "0xA2F370", Offset = "0xA2E770", VA = "0x180A2F370", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013BE6 RID: 80870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BE6")]
		[Address(RVA = "0x193CDD0", Offset = "0x193C1D0", VA = "0x18193CDD0")]
		private void Awake()
		{
		}

		// Token: 0x06013BE7 RID: 80871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BE7")]
		[Address(RVA = "0x193DD80", Offset = "0x193D180", VA = "0x18193DD80")]
		private void OnEnable()
		{
		}

		// Token: 0x06013BE8 RID: 80872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BE8")]
		[Address(RVA = "0x193DC70", Offset = "0x193D070", VA = "0x18193DC70")]
		private void OnDisable()
		{
		}

		// Token: 0x06013BE9 RID: 80873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BE9")]
		[Address(RVA = "0x193E000", Offset = "0x193D400", VA = "0x18193E000", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013BEA RID: 80874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BEA")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		public void Event_SquadKickPressed(int index)
		{
		}

		// Token: 0x06013BEB RID: 80875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BEB")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		public void Event_SquadPromotePressed(int index)
		{
		}

		// Token: 0x06013BEC RID: 80876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BEC")]
		[Address(RVA = "0x193CFF0", Offset = "0x193C3F0", VA = "0x18193CFF0")]
		public void Event_RoleSelectPressed(int index)
		{
		}

		// Token: 0x06013BED RID: 80877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BED")]
		[Address(RVA = "0x193D220", Offset = "0x193C620", VA = "0x18193D220")]
		public void Event_SquadCreatePressed()
		{
		}

		// Token: 0x06013BEE RID: 80878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BEE")]
		[Address(RVA = "0x193D0C0", Offset = "0x193C4C0", VA = "0x18193D0C0")]
		public void Event_SquadClanCreatePressed()
		{
		}

		// Token: 0x06013BEF RID: 80879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BEF")]
		[Address(RVA = "0x193D380", Offset = "0x193C780", VA = "0x18193D380")]
		public void Event_SquadLeavePressed()
		{
		}

		// Token: 0x06013BF0 RID: 80880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF0")]
		[Address(RVA = "0x193D7A0", Offset = "0x193CBA0", VA = "0x18193D7A0")]
		public void Event_SquadNameChangPressed()
		{
		}

		// Token: 0x06013BF1 RID: 80881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF1")]
		[Address(RVA = "0x193D450", Offset = "0x193C850", VA = "0x18193D450")]
		public void Event_SquadLockPressed()
		{
		}

		// Token: 0x06013BF2 RID: 80882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF2")]
		[Address(RVA = "0x193EFA0", Offset = "0x193E3A0", VA = "0x18193EFA0")]
		private void Squad_Awake()
		{
		}

		// Token: 0x06013BF3 RID: 80883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF3")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		private void Squad_OnEnable()
		{
		}

		// Token: 0x06013BF4 RID: 80884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF4")]
		[Address(RVA = "0x193EFC0", Offset = "0x193E3C0", VA = "0x18193EFC0")]
		private void Squad_Update()
		{
		}

		// Token: 0x06013BF5 RID: 80885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF5")]
		[Address(RVA = "0x193FB30", Offset = "0x193EF30", VA = "0x18193FB30")]
		private void UpdateSquadName(bool isFirstTime)
		{
		}

		// Token: 0x06013BF6 RID: 80886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF6")]
		[Address(RVA = "0x193DFF0", Offset = "0x193D3F0", VA = "0x18193DFF0")]
		private void OnJoinedSquad()
		{
		}

		// Token: 0x06013BF7 RID: 80887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF7")]
		[Address(RVA = "0x193E590", Offset = "0x193D990", VA = "0x18193E590")]
		private void OnSquadListViewed()
		{
		}

		// Token: 0x06013BF8 RID: 80888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF8")]
		[Address(RVA = "0x193E5A0", Offset = "0x193D9A0", VA = "0x18193E5A0")]
		private void RefreshInSquadList()
		{
		}

		// Token: 0x06013BF9 RID: 80889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BF9")]
		[Address(RVA = "0x193EB20", Offset = "0x193DF20", VA = "0x18193EB20")]
		private void RefreshSquadList()
		{
		}

		// Token: 0x06013BFA RID: 80890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BFA")]
		[Address(RVA = "0x193DE70", Offset = "0x193D270", VA = "0x18193DE70")]
		public void OnGoToCustomizePressed()
		{
		}

		// Token: 0x06013BFB RID: 80891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BFB")]
		[Address(RVA = "0x193CC80", Offset = "0x193C080", VA = "0x18193CC80")]
		private void ActivateCustomize()
		{
		}

		// Token: 0x06013BFC RID: 80892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BFC")]
		[Address(RVA = "0x193DF70", Offset = "0x193D370", VA = "0x18193DF70")]
		public void OnGoToLoadoutPressed()
		{
		}

		// Token: 0x06013BFD RID: 80893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BFD")]
		[Address(RVA = "0x193CD60", Offset = "0x193C160", VA = "0x18193CD60")]
		private void ActivateLoadout()
		{
		}

		// Token: 0x06013BFE RID: 80894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BFE")]
		[Address(RVA = "0x193DEF0", Offset = "0x193D2F0", VA = "0x18193DEF0")]
		public void OnGoToDeployBack()
		{
		}

		// Token: 0x06013BFF RID: 80895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BFF")]
		[Address(RVA = "0x193CCF0", Offset = "0x193C0F0", VA = "0x18193CCF0")]
		private void ActivateDeploy()
		{
		}

		// Token: 0x06013C00 RID: 80896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C00")]
		[Address(RVA = "0x193CED0", Offset = "0x193C2D0", VA = "0x18193CED0")]
		public void Event_DeployPressed()
		{
		}

		// Token: 0x06013C01 RID: 80897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C01")]
		[Address(RVA = "0x193D970", Offset = "0x193CD70", VA = "0x18193D970")]
		public void OnConnected()
		{
		}

		// Token: 0x06013C03 RID: 80899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C03")]
		[Address(RVA = "0x193FB20", Offset = "0x193EF20", VA = "0x18193FB20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static void <Event_SquadLockPressed>g__increment|36_0(ref DeployScreenBehaviour.<>c__DisplayClass36_0 A_0)
		{
		}

		// Token: 0x06013C04 RID: 80900 RVA: 0x0007D42C File Offset: 0x0007B62C
		[Token(Token = "0x6013C04")]
		[Address(RVA = "0x193FA90", Offset = "0x193EE90", VA = "0x18193FA90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static bool <Event_SquadLockPressed>g__canUse|36_1(ref DeployScreenBehaviour.<>c__DisplayClass36_0 A_0)
		{
			return default(bool);
		}

		// Token: 0x04003A63 RID: 14947
		[Token(Token = "0x4003A63")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public static bool isActive;

		// Token: 0x04003A64 RID: 14948
		[Token(Token = "0x4003A64")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public static DeployScreenBehaviour Instance;

		// Token: 0x04003A65 RID: 14949
		[Token(Token = "0x4003A65")]
		private const float fade = 0.25f;

		// Token: 0x04003A66 RID: 14950
		[Token(Token = "0x4003A66")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003A67 RID: 14951
		[Token(Token = "0x4003A67")]
		[touching_your_mom.FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;

		// Token: 0x04003A68 RID: 14952
		[Token(Token = "0x4003A68")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		private int mLastFrame;

		// Token: 0x04003A69 RID: 14953
		[Token(Token = "0x4003A69")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		public static float LastEscapeUsed;

		// Token: 0x04003A6A RID: 14954
		[Token(Token = "0x4003A6A")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16DD30", Offset = "0x16D130")]
		public TextMeshProUGUI Servername;

		// Token: 0x04003A6B RID: 14955
		[Token(Token = "0x4003A6B")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public RectTransform CenterBottomLeft;

		// Token: 0x04003A6C RID: 14956
		[Token(Token = "0x4003A6C")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public GameObject Camera;

		// Token: 0x04003A6D RID: 14957
		[Token(Token = "0x4003A6D")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		public GameObject Background;

		// Token: 0x04003A6E RID: 14958
		[Token(Token = "0x4003A6E")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		public GameObject Self;

		// Token: 0x04003A6F RID: 14959
		[Token(Token = "0x4003A6F")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16DF30", Offset = "0x16D330")]
		public DeployScreenBehaviour.SquadUI SquadUserInterface;

		// Token: 0x04003A70 RID: 14960
		[Token(Token = "0x4003A70")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		private bool lock_inSquad;

		// Token: 0x04003A71 RID: 14961
		[Token(Token = "0x4003A71")]
		[touching_your_mom.FieldOffset(Offset = "0x5C")]
		private int locked_squadMemberCount;

		// Token: 0x04003A72 RID: 14962
		[Token(Token = "0x4003A72")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		private \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 locked_squadTeam;

		// Token: 0x04003A73 RID: 14963
		[Token(Token = "0x4003A73")]
		[touching_your_mom.FieldOffset(Offset = "0x64")]
		private \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303.\u0304\u0305\u0308\u0303\u0304\u0307\u0304\u0303\u0306\u0306\u0302\u0301\u0302\u0304\u0301 lastLockedState;

		// Token: 0x04003A74 RID: 14964
		[Token(Token = "0x4003A74")]
		[touching_your_mom.FieldOffset(Offset = "0x68")]
		private float lastChangeRequestSent;

		// Token: 0x04003A75 RID: 14965
		[Token(Token = "0x4003A75")]
		[touching_your_mom.FieldOffset(Offset = "0x70")]
		private \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 mLastSquad;

		// Token: 0x04003A76 RID: 14966
		[Token(Token = "0x4003A76")]
		[touching_your_mom.FieldOffset(Offset = "0x78")]
		private ulong mLastSquadMemberHash;

		// Token: 0x04003A77 RID: 14967
		[Token(Token = "0x4003A77")]
		[touching_your_mom.FieldOffset(Offset = "0x80")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16E020", Offset = "0x16D420")]
		public GameObject Menu;

		// Token: 0x04003A78 RID: 14968
		[Token(Token = "0x4003A78")]
		[touching_your_mom.FieldOffset(Offset = "0x88")]
		public GameObject Loadout;

		// Token: 0x04003A79 RID: 14969
		[Token(Token = "0x4003A79")]
		[touching_your_mom.FieldOffset(Offset = "0x90")]
		public GameObject LoadoutNew;

		// Token: 0x04003A7A RID: 14970
		[Token(Token = "0x4003A7A")]
		[touching_your_mom.FieldOffset(Offset = "0x98")]
		public GameObject Customize;

		// Token: 0x02000790 RID: 1936
		[Token(Token = "0x2000790")]
		[Serializable]
		public class SquadUI
		{
			// Token: 0x06013C05 RID: 80901 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013C05")]
			[Address(RVA = "0x1944F30", Offset = "0x1944330", VA = "0x181944F30")]
			public void Awake()
			{
			}

			// Token: 0x06013C06 RID: 80902 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013C06")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public SquadUI()
			{
			}

			// Token: 0x04003A7B RID: 14971
			[Token(Token = "0x4003A7B")]
			[touching_your_mom.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x16E020", Offset = "0x16D420")]
			public GameObject CreateJoinTab;

			// Token: 0x04003A7C RID: 14972
			[Token(Token = "0x4003A7C")]
			[touching_your_mom.FieldOffset(Offset = "0x18")]
			public GameObject InSquadTab;

			// Token: 0x04003A7D RID: 14973
			[Token(Token = "0x4003A7D")]
			[touching_your_mom.FieldOffset(Offset = "0x20")]
			public GameObject ClanCraeteTab;

			// Token: 0x04003A7E RID: 14974
			[Token(Token = "0x4003A7E")]
			[touching_your_mom.FieldOffset(Offset = "0x28")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x16E440", Offset = "0x16D840")]
			public TextMeshProUGUI WriteOnlyName;

			// Token: 0x04003A7F RID: 14975
			[Token(Token = "0x4003A7F")]
			[touching_your_mom.FieldOffset(Offset = "0x30")]
			public InputField ReadWriteName;

			// Token: 0x04003A80 RID: 14976
			[Token(Token = "0x4003A80")]
			[touching_your_mom.FieldOffset(Offset = "0x38")]
			public GameObject MemberPrefab;

			// Token: 0x04003A81 RID: 14977
			[Token(Token = "0x4003A81")]
			[touching_your_mom.FieldOffset(Offset = "0x40")]
			public Transform MemberParent;

			// Token: 0x04003A82 RID: 14978
			[Token(Token = "0x4003A82")]
			[touching_your_mom.FieldOffset(Offset = "0x48")]
			public Image LockedIcon;

			// Token: 0x04003A83 RID: 14979
			[Token(Token = "0x4003A83")]
			[touching_your_mom.FieldOffset(Offset = "0x50")]
			public GameObject LockButton;

			// Token: 0x04003A84 RID: 14980
			[Token(Token = "0x4003A84")]
			[touching_your_mom.FieldOffset(Offset = "0x58")]
			public RawImage LeaveButton;

			// Token: 0x04003A85 RID: 14981
			[Token(Token = "0x4003A85")]
			[touching_your_mom.FieldOffset(Offset = "0x60")]
			[NonSerialized]
			public UIPool<SquadViewMember> memberPool;

			// Token: 0x04003A86 RID: 14982
			[Token(Token = "0x4003A86")]
			[touching_your_mom.FieldOffset(Offset = "0x68")]
			[NonSerialized]
			public List<SquadViewMember> activeMembers;

			// Token: 0x04003A87 RID: 14983
			[Token(Token = "0x4003A87")]
			[touching_your_mom.FieldOffset(Offset = "0x70")]
			public VerticalList mSquadMemberList;

			// Token: 0x04003A88 RID: 14984
			[Token(Token = "0x4003A88")]
			[touching_your_mom.FieldOffset(Offset = "0x78")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x16E600", Offset = "0x16DA00")]
			public DeployScreenBehaviour.SquadUI.SquadListViewUI SquadListViewInterface;

			// Token: 0x04003A89 RID: 14985
			[Token(Token = "0x4003A89")]
			[touching_your_mom.FieldOffset(Offset = "0x80")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x16E680", Offset = "0x16DA80")]
			public DeployScreenBehaviour.SquadUI.RoleUI RoleInterface;

			// Token: 0x02000791 RID: 1937
			[Token(Token = "0x2000791")]
			[Serializable]
			public class SquadListViewUI
			{
				// Token: 0x06013C07 RID: 80903 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013C07")]
				[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
				public SquadListViewUI()
				{
				}

				// Token: 0x04003A8A RID: 14986
				[Token(Token = "0x4003A8A")]
				[touching_your_mom.FieldOffset(Offset = "0x10")]
				[HideInInspector]
				public UIPool<SquadViewElement> Pool;

				// Token: 0x04003A8B RID: 14987
				[Token(Token = "0x4003A8B")]
				[touching_your_mom.FieldOffset(Offset = "0x18")]
				[HideInInspector]
				public Dictionary<\u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303, SquadViewElement> elements;

				// Token: 0x04003A8C RID: 14988
				[Token(Token = "0x4003A8C")]
				[touching_your_mom.FieldOffset(Offset = "0x20")]
				public GameObject ObjectElement;

				// Token: 0x04003A8D RID: 14989
				[Token(Token = "0x4003A8D")]
				[touching_your_mom.FieldOffset(Offset = "0x28")]
				public Transform Parent;
			}

			// Token: 0x02000792 RID: 1938
			[Token(Token = "0x2000792")]
			[Serializable]
			public class RoleUI
			{
				// Token: 0x06013C08 RID: 80904 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013C08")]
				[Address(RVA = "0x1943F30", Offset = "0x1943330", VA = "0x181943F30")]
				public void Sync(\u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 squad)
				{
				}

				// Token: 0x06013C09 RID: 80905 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013C09")]
				[Address(RVA = "0x1943830", Offset = "0x1942C30", VA = "0x181943830")]
				public void SetRolesInSquad(bool insquad)
				{
				}

				// Token: 0x06013C0A RID: 80906 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013C0A")]
				[Address(RVA = "0x1943100", Offset = "0x1942500", VA = "0x181943100")]
				public void OnUpdate()
				{
				}

				// Token: 0x06013C0B RID: 80907 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013C0B")]
				[Address(RVA = "0x1942CC0", Offset = "0x19420C0", VA = "0x181942CC0")]
				public void OnUpdateOffline()
				{
				}

				// Token: 0x06013C0C RID: 80908 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6013C0C")]
				[Address(RVA = "0x1944610", Offset = "0x1943A10", VA = "0x181944610")]
				public RoleUI()
				{
				}

				// Token: 0x04003A8E RID: 14990
				[Token(Token = "0x4003A8E")]
				[touching_your_mom.FieldOffset(Offset = "0x10")]
				public GameObject needToJoin;

				// Token: 0x04003A8F RID: 14991
				[Token(Token = "0x4003A8F")]
				[touching_your_mom.FieldOffset(Offset = "0x18")]
				public DeployScreenBehaviour.SquadUI.RoleUI.RoleUIElement[] Roles;

				// Token: 0x04003A90 RID: 14992
				[Token(Token = "0x4003A90")]
				[touching_your_mom.FieldOffset(Offset = "0x20")]
				public bool _lockedInSquad;

				// Token: 0x04003A91 RID: 14993
				[Token(Token = "0x4003A91")]
				[touching_your_mom.FieldOffset(Offset = "0x21")]
				private \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 lockedRole;

				// Token: 0x02000793 RID: 1939
				[Token(Token = "0x2000793")]
				[Serializable]
				public class RoleUIElement
				{
					// Token: 0x06013C0D RID: 80909 RVA: 0x00002066 File Offset: 0x00000266
					[Token(Token = "0x6013C0D")]
					[Address(RVA = "0x1942BB0", Offset = "0x1941FB0", VA = "0x181942BB0")]
					public void Update(int max, int current, bool isSelected, bool isActive)
					{
					}

					// Token: 0x06013C0E RID: 80910 RVA: 0x00002066 File Offset: 0x00000266
					[Token(Token = "0x6013C0E")]
					[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
					public RoleUIElement()
					{
					}

					// Token: 0x04003A92 RID: 14994
					[Token(Token = "0x4003A92")]
					[touching_your_mom.FieldOffset(Offset = "0x10")]
					public \u0307\u0301\u0303\u0301\u0308\u0302\u0301\u0303\u0304\u0306\u0304\u0306\u0305\u0304\u0307 Button;

					// Token: 0x04003A93 RID: 14995
					[Token(Token = "0x4003A93")]
					[touching_your_mom.FieldOffset(Offset = "0x18")]
					public GameObject isSelected;

					// Token: 0x04003A94 RID: 14996
					[Token(Token = "0x4003A94")]
					[touching_your_mom.FieldOffset(Offset = "0x20")]
					public TextMeshProUGUI Count;

					// Token: 0x04003A95 RID: 14997
					[Token(Token = "0x4003A95")]
					[touching_your_mom.FieldOffset(Offset = "0x28")]
					public GameObject New;

					// Token: 0x04003A96 RID: 14998
					[Token(Token = "0x4003A96")]
					[touching_your_mom.FieldOffset(Offset = "0x30")]
					private int _lockedCurrent;

					// Token: 0x04003A97 RID: 14999
					[Token(Token = "0x4003A97")]
					[touching_your_mom.FieldOffset(Offset = "0x34")]
					private int _lockedMax;

					// Token: 0x04003A98 RID: 15000
					[Token(Token = "0x4003A98")]
					[touching_your_mom.FieldOffset(Offset = "0x38")]
					private bool _lockedIsSelected;
				}
			}
		}

		// Token: 0x02000794 RID: 1940
		[Token(Token = "0x2000794")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[StructLayout(3)]
		private struct <>c__DisplayClass36_0
		{
			// Token: 0x04003A99 RID: 15001
			[Token(Token = "0x4003A99")]
			[touching_your_mom.FieldOffset(Offset = "0x0")]
			public \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303.\u0304\u0305\u0308\u0303\u0304\u0307\u0304\u0303\u0306\u0306\u0302\u0301\u0302\u0304\u0301 currentLock;
		}
	}
}
