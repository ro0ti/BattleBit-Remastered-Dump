using System;
using System.Collections.Generic;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Extentions;

namespace UserInterface.InGameBehaviours.ScoreboardSub
{
	// Token: 0x020007A2 RID: 1954
	[Token(Token = "0x20007A2")]
	public class ScoreboardSquad : MonoBehaviour
	{
		// Token: 0x06013C94 RID: 81044 RVA: 0x0007D54C File Offset: 0x0007B74C
		[Token(Token = "0x6013C94")]
		[Address(RVA = "0x1691430", Offset = "0x1690830", VA = "0x181691430")]
		private static bool isSelected(ScoreboardSquad inst)
		{
			return default(bool);
		}

		// Token: 0x06013C95 RID: 81045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C95")]
		[Address(RVA = "0x1690740", Offset = "0x168FB40", VA = "0x181690740")]
		private static void Select(ScoreboardSquad inst)
		{
		}

		// Token: 0x06013C96 RID: 81046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C96")]
		[Address(RVA = "0x1690B80", Offset = "0x168FF80", VA = "0x181690B80")]
		private static void Unselect(ScoreboardSquad inst)
		{
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06013C97 RID: 81047 RVA: 0x0007D564 File Offset: 0x0007B764
		[Token(Token = "0x17000BC3")]
		public int ActualtMemberCount
		{
			[Token(Token = "0x6013C97")]
			[Address(RVA = "0x1691230", Offset = "0x1690630", VA = "0x181691230")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06013C98 RID: 81048 RVA: 0x0007D57C File Offset: 0x0007B77C
		[Token(Token = "0x17000BC4")]
		public int ActualmaxMemberCount
		{
			[Token(Token = "0x6013C98")]
			[Address(RVA = "0x16911F0", Offset = "0x16905F0", VA = "0x1816911F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06013C99 RID: 81049 RVA: 0x0007D594 File Offset: 0x0007B794
		[Token(Token = "0x17000BC5")]
		public bool isExpanded
		{
			[Token(Token = "0x6013C99")]
			[Address(RVA = "0x1691360", Offset = "0x1690760", VA = "0x181691360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06013C9A RID: 81050 RVA: 0x0007D5AC File Offset: 0x0007B7AC
		[Token(Token = "0x17000BC6")]
		public int ExpandHeight
		{
			[Token(Token = "0x6013C9A")]
			[Address(RVA = "0x1691320", Offset = "0x1690720", VA = "0x181691320")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06013C9B RID: 81051 RVA: 0x0007D5C4 File Offset: 0x0007B7C4
		// (set) Token: 0x06013C9C RID: 81052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC7")]
		public bool isVisible
		{
			[Token(Token = "0x6013C9B")]
			[Address(RVA = "0x1691420", Offset = "0x1690820", VA = "0x181691420")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013C9C")]
			[Address(RVA = "0x16914B0", Offset = "0x16908B0", VA = "0x1816914B0")]
			set
			{
			}
		}

		// Token: 0x06013C9D RID: 81053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C9D")]
		[Address(RVA = "0x168FB10", Offset = "0x168EF10", VA = "0x18168FB10")]
		public void OnPressed()
		{
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06013C9E RID: 81054 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x17000BC8")]
		public \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 ThisSquad
		{
			[Token(Token = "0x6013C9E")]
			[Address(RVA = "0xAEB400", Offset = "0xAEA800", VA = "0x180AEB400")]
			get
			{
				return null;
			}
		}

		// Token: 0x06013C9F RID: 81055 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013C9F")]
		[Address(RVA = "0x168F8A0", Offset = "0x168ECA0", VA = "0x18168F8A0")]
		public ScoreboardSquad Init(\u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 squad, \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 team, UIPool<ScoreboardMember> pool)
		{
			return null;
		}

		// Token: 0x06013CA0 RID: 81056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA0")]
		[Address(RVA = "0x168EC20", Offset = "0x168E020", VA = "0x18168EC20")]
		private void Awake()
		{
		}

		// Token: 0x06013CA1 RID: 81057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA1")]
		[Address(RVA = "0x168EE50", Offset = "0x168E250", VA = "0x18168EE50")]
		private void CreateAll()
		{
		}

		// Token: 0x06013CA2 RID: 81058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA2")]
		[Address(RVA = "0x168EC90", Offset = "0x168E090", VA = "0x18168EC90")]
		private void ClearAll()
		{
		}

		// Token: 0x06013CA3 RID: 81059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA3")]
		[Address(RVA = "0x16906B0", Offset = "0x168FAB0", VA = "0x1816906B0")]
		public void Rebuild()
		{
		}

		// Token: 0x06013CA4 RID: 81060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA4")]
		[Address(RVA = "0x1690810", Offset = "0x168FC10", VA = "0x181690810")]
		public void SetDirtyTeam()
		{
		}

		// Token: 0x06013CA5 RID: 81061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA5")]
		[Address(RVA = "0x168FC60", Offset = "0x168F060", VA = "0x18168FC60")]
		public void OnUpdate()
		{
		}

		// Token: 0x06013CA6 RID: 81062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA6")]
		[Address(RVA = "0x1690D10", Offset = "0x1690110", VA = "0x181690D10")]
		private void UpdateCountLabel(int newCount)
		{
		}

		// Token: 0x06013CA7 RID: 81063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA7")]
		[Address(RVA = "0x1690E00", Offset = "0x1690200", VA = "0x181690E00")]
		private void UpdateExpanded(bool isExpanded)
		{
		}

		// Token: 0x06013CA8 RID: 81064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA8")]
		[Address(RVA = "0x1690C50", Offset = "0x1690050", VA = "0x181690C50")]
		private void UpdasteIsMine(bool value)
		{
		}

		// Token: 0x06013CA9 RID: 81065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CA9")]
		[Address(RVA = "0x16910C0", Offset = "0x16904C0", VA = "0x1816910C0")]
		private void UpdateSteamFriend(bool steam, bool clan)
		{
		}

		// Token: 0x06013CAA RID: 81066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CAA")]
		[Address(RVA = "0x1690E90", Offset = "0x1690290", VA = "0x181690E90")]
		private void UpdateLocked(\u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303.\u0304\u0305\u0308\u0303\u0304\u0307\u0304\u0303\u0306\u0306\u0302\u0301\u0302\u0304\u0301 newState)
		{
		}

		// Token: 0x06013CAB RID: 81067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CAB")]
		[Address(RVA = "0x1690F70", Offset = "0x1690370", VA = "0x181690F70")]
		private void UpdatePoints(int newCount)
		{
		}

		// Token: 0x06013CAC RID: 81068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CAC")]
		[Address(RVA = "0x1690890", Offset = "0x168FC90", VA = "0x181690890")]
		private void SortAndList(int newScore, bool forceList)
		{
		}

		// Token: 0x06013CAD RID: 81069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CAD")]
		[Address(RVA = "0x16911B0", Offset = "0x16905B0", VA = "0x1816911B0")]
		public ScoreboardSquad()
		{
		}

		// Token: 0x04003B71 RID: 15217
		[Token(Token = "0x4003B71")]
		public const int Height = 30;

		// Token: 0x04003B72 RID: 15218
		[Token(Token = "0x4003B72")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public RectTransform rectTransform;

		// Token: 0x04003B73 RID: 15219
		[Token(Token = "0x4003B73")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CanvasGroup mCanvas;

		// Token: 0x04003B74 RID: 15220
		[Token(Token = "0x4003B74")]
		[FieldOffset(Offset = "0x28")]
		public \u0307\u0301\u0303\u0301\u0308\u0302\u0301\u0303\u0304\u0306\u0304\u0306\u0305\u0304\u0307 btn;

		// Token: 0x04003B75 RID: 15221
		[Token(Token = "0x4003B75")]
		[FieldOffset(Offset = "0x30")]
		public GameObject locked;

		// Token: 0x04003B76 RID: 15222
		[Token(Token = "0x4003B76")]
		[FieldOffset(Offset = "0x38")]
		public RawImage Icon;

		// Token: 0x04003B77 RID: 15223
		[Token(Token = "0x4003B77")]
		[FieldOffset(Offset = "0x40")]
		public RawImage CountIcon;

		// Token: 0x04003B78 RID: 15224
		[Token(Token = "0x4003B78")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI SquadName;

		// Token: 0x04003B79 RID: 15225
		[Token(Token = "0x4003B79")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI SquadCount;

		// Token: 0x04003B7A RID: 15226
		[Token(Token = "0x4003B7A")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI SquadPoint;

		// Token: 0x04003B7B RID: 15227
		[Token(Token = "0x4003B7B")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<ScoreboardSquad> selecteds;

		// Token: 0x04003B7C RID: 15228
		[Token(Token = "0x4003B7C")]
		[FieldOffset(Offset = "0x60")]
		private bool mSquadExist;

		// Token: 0x04003B7D RID: 15229
		[Token(Token = "0x4003B7D")]
		[FieldOffset(Offset = "0x68")]
		private UIPool<ScoreboardMember> mPool;

		// Token: 0x04003B7E RID: 15230
		[Token(Token = "0x4003B7E")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<ulong, ScoreboardMember> mActiveMembersMaps;

		// Token: 0x04003B7F RID: 15231
		[Token(Token = "0x4003B7F")]
		[FieldOffset(Offset = "0x78")]
		private List<ScoreboardMember> mActiveMembersList;

		// Token: 0x04003B80 RID: 15232
		[Token(Token = "0x4003B80")]
		[FieldOffset(Offset = "0x80")]
		private List<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304> mMembers;

		// Token: 0x04003B81 RID: 15233
		[Token(Token = "0x4003B81")]
		[FieldOffset(Offset = "0x88")]
		private Queue<ulong> mRemoveQueue;

		// Token: 0x04003B82 RID: 15234
		[Token(Token = "0x4003B82")]
		[FieldOffset(Offset = "0x90")]
		private \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 mSquad;

		// Token: 0x04003B83 RID: 15235
		[Token(Token = "0x4003B83")]
		[FieldOffset(Offset = "0x98")]
		private \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 mTeam;

		// Token: 0x04003B84 RID: 15236
		[Token(Token = "0x4003B84")]
		[FieldOffset(Offset = "0x99")]
		private bool refresh_flag;

		// Token: 0x04003B85 RID: 15237
		[Token(Token = "0x4003B85")]
		[FieldOffset(Offset = "0x9A")]
		private bool mVisible;

		// Token: 0x04003B86 RID: 15238
		[Token(Token = "0x4003B86")]
		[FieldOffset(Offset = "0x9B")]
		private bool mWasVisible;

		// Token: 0x04003B87 RID: 15239
		[Token(Token = "0x4003B87")]
		[FieldOffset(Offset = "0x9C")]
		[NonSerialized]
		public \u0308\u0308\u0306\u0308\u0308\u0305\u0306\u0307\u0304\u0303\u0301\u0301\u0306\u0302\u0308 LastAppliedStyle;

		// Token: 0x04003B88 RID: 15240
		[Token(Token = "0x4003B88")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public int TargetScoreVersion;

		// Token: 0x04003B89 RID: 15241
		[Token(Token = "0x4003B89")]
		[FieldOffset(Offset = "0xA4")]
		private float mLastUpdate;

		// Token: 0x04003B8A RID: 15242
		[Token(Token = "0x4003B8A")]
		[FieldOffset(Offset = "0xA8")]
		private int mLockedUserCount;

		// Token: 0x04003B8B RID: 15243
		[Token(Token = "0x4003B8B")]
		[FieldOffset(Offset = "0xAC")]
		private int mLockedMaxUserCount;

		// Token: 0x04003B8C RID: 15244
		[Token(Token = "0x4003B8C")]
		[FieldOffset(Offset = "0xB0")]
		private bool mLockedisExpanded;

		// Token: 0x04003B8D RID: 15245
		[Token(Token = "0x4003B8D")]
		[FieldOffset(Offset = "0xB1")]
		private bool mLockedisMine;

		// Token: 0x04003B8E RID: 15246
		[Token(Token = "0x4003B8E")]
		[FieldOffset(Offset = "0xB4")]
		private \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303.\u0304\u0305\u0308\u0303\u0304\u0307\u0304\u0303\u0306\u0306\u0302\u0301\u0302\u0304\u0301 mLockedState;

		// Token: 0x04003B8F RID: 15247
		[Token(Token = "0x4003B8F")]
		[FieldOffset(Offset = "0xB8")]
		private int mLockedPoints;

		// Token: 0x04003B90 RID: 15248
		[Token(Token = "0x4003B90")]
		[FieldOffset(Offset = "0xBC")]
		private int mCurrentScoreVersion;

		// Token: 0x020007A3 RID: 1955
		[Token(Token = "0x20007A3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06013CB0 RID: 81072 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013CB0")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c()
			{
			}

			// Token: 0x06013CB1 RID: 81073 RVA: 0x0007D5DC File Offset: 0x0007B7DC
			[Token(Token = "0x6013CB1")]
			[Address(RVA = "0x1699430", Offset = "0x1698830", VA = "0x181699430")]
			internal int <SortAndList>b__62_0(ScoreboardMember x, ScoreboardMember y)
			{
				return 0;
			}

			// Token: 0x04003B91 RID: 15249
			[Token(Token = "0x4003B91")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ScoreboardSquad.<>c <>9;

			// Token: 0x04003B92 RID: 15250
			[Token(Token = "0x4003B92")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ScoreboardMember> <>9__62_0;
		}
	}
}
