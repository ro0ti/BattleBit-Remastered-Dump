using System;
using System.Collections.Generic;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Extentions;
using UserInterface.InGameBehaviours.ScoreboardSub;

namespace UserInterface.InGameBehaviours
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class ScoreboardBehaviour : MonoBehaviour
	{
		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06013C4E RID: 80974 RVA: 0x0007D4EC File Offset: 0x0007B6EC
		// (set) Token: 0x06013C4F RID: 80975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBB")]
		public int TickIndex8
		{
			[Token(Token = "0x6013C4E")]
			[Address(RVA = "0x168C8E0", Offset = "0x168BCE0", VA = "0x18168C8E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013C4F")]
			[Address(RVA = "0x168D270", Offset = "0x168C670", VA = "0x18168D270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013C50 RID: 80976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C50")]
		[Address(RVA = "0x168AF60", Offset = "0x168A360", VA = "0x18168AF60")]
		private void Awake()
		{
		}

		// Token: 0x06013C51 RID: 80977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C51")]
		[Address(RVA = "0x168B520", Offset = "0x168A920", VA = "0x18168B520")]
		private void OnEnable()
		{
		}

		// Token: 0x06013C52 RID: 80978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C52")]
		[Address(RVA = "0x168B2A0", Offset = "0x168A6A0", VA = "0x18168B2A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06013C53 RID: 80979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C53")]
		[Address(RVA = "0x168C410", Offset = "0x168B810", VA = "0x18168C410")]
		private void Start()
		{
		}

		// Token: 0x06013C54 RID: 80980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C54")]
		[Address(RVA = "0x168B160", Offset = "0x168A560", VA = "0x18168B160")]
		public void OnConnected()
		{
		}

		// Token: 0x06013C55 RID: 80981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C55")]
		[Address(RVA = "0x168B130", Offset = "0x168A530", VA = "0x18168B130")]
		public void Dirty()
		{
		}

		// Token: 0x06013C56 RID: 80982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C56")]
		[Address(RVA = "0x168B140", Offset = "0x168A540", VA = "0x18168B140")]
		public void Dirty(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 team)
		{
		}

		// Token: 0x06013C57 RID: 80983 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013C57")]
		[Address(RVA = "0x168C8F0", Offset = "0x168BCF0", VA = "0x18168C8F0")]
		private ScoreboardSquad mCreateSquad(Transform parent)
		{
			return null;
		}

		// Token: 0x06013C58 RID: 80984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C58")]
		[Address(RVA = "0x168CF30", Offset = "0x168C330", VA = "0x18168CF30")]
		private void mSetMyTeam(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 newTeam)
		{
		}

		// Token: 0x06013C59 RID: 80985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C59")]
		[Address(RVA = "0x168CA50", Offset = "0x168BE50", VA = "0x18168CA50")]
		private void mRepaintTeamA()
		{
		}

		// Token: 0x06013C5A RID: 80986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C5A")]
		[Address(RVA = "0x168CCC0", Offset = "0x168C0C0", VA = "0x18168CCC0")]
		private void mRepaintTeamB()
		{
		}

		// Token: 0x06013C5B RID: 80987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C5B")]
		[Address(RVA = "0x168B7A0", Offset = "0x168ABA0", VA = "0x18168B7A0")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013C5C RID: 80988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C5C")]
		[Address(RVA = "0x168C270", Offset = "0x168B670", VA = "0x18168C270")]
		public void OnSearchPressed()
		{
		}

		// Token: 0x06013C5D RID: 80989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C5D")]
		[Address(RVA = "0x168C230", Offset = "0x168B630", VA = "0x18168C230")]
		private void OnPlayerConnectedAndDisconnected(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 player)
		{
		}

		// Token: 0x06013C5E RID: 80990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C5E")]
		[Address(RVA = "0x168C230", Offset = "0x168B630", VA = "0x18168C230")]
		private void OnPlayerSquadChanged(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 player)
		{
		}

		// Token: 0x06013C5F RID: 80991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C5F")]
		[Address(RVA = "0x168B130", Offset = "0x168A530", VA = "0x18168B130")]
		private void OnPlayerTeamChanged(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client, \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 newTeam)
		{
		}

		// Token: 0x06013C60 RID: 80992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C60")]
		[Address(RVA = "0x168C8B0", Offset = "0x168BCB0", VA = "0x18168C8B0")]
		public ScoreboardBehaviour()
		{
		}

		// Token: 0x06013C61 RID: 80993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C61")]
		[Address(RVA = "0x168C7D0", Offset = "0x168BBD0", VA = "0x18168C7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private void <Start>b__56_0(Vector2 x)
		{
		}

		// Token: 0x06013C62 RID: 80994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C62")]
		[Address(RVA = "0x168C840", Offset = "0x168BC40", VA = "0x18168C840")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private void <Start>b__56_1(Vector2 x)
		{
		}

		// Token: 0x04003AFE RID: 15102
		[Token(Token = "0x4003AFE")]
		[FieldOffset(Offset = "0x0")]
		public static ScoreboardBehaviour Instance;

		// Token: 0x04003AFF RID: 15103
		[Token(Token = "0x4003AFF")]
		[FieldOffset(Offset = "0x8")]
		public static float TopPosition;

		// Token: 0x04003B00 RID: 15104
		[Token(Token = "0x4003B00")]
		[FieldOffset(Offset = "0xC")]
		public static float TopPositionMember;

		// Token: 0x04003B01 RID: 15105
		[Token(Token = "0x4003B01")]
		[FieldOffset(Offset = "0x10")]
		public static float TopPositionSquad;

		// Token: 0x04003B02 RID: 15106
		[Token(Token = "0x4003B02")]
		[FieldOffset(Offset = "0x14")]
		public static float BottomPosition;

		// Token: 0x04003B03 RID: 15107
		[Token(Token = "0x4003B03")]
		[FieldOffset(Offset = "0x18")]
		public static float BottomPositionMember;

		// Token: 0x04003B04 RID: 15108
		[Token(Token = "0x4003B04")]
		[FieldOffset(Offset = "0x1C")]
		public static float BottomPositionSquad;

		// Token: 0x04003B05 RID: 15109
		[Token(Token = "0x4003B05")]
		[FieldOffset(Offset = "0x20")]
		public static bool IsScrollingTeamA;

		// Token: 0x04003B06 RID: 15110
		[Token(Token = "0x4003B06")]
		[FieldOffset(Offset = "0x21")]
		public static bool IsScrollingTeamB;

		// Token: 0x04003B07 RID: 15111
		[Token(Token = "0x4003B07")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16EBE0", Offset = "0x16DFE0")]
		public RectTransform MyTeamParent;

		// Token: 0x04003B08 RID: 15112
		[Token(Token = "0x4003B08")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform EnemyTeamParent;

		// Token: 0x04003B09 RID: 15113
		[Token(Token = "0x4003B09")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform TeamAParent;

		// Token: 0x04003B0A RID: 15114
		[Token(Token = "0x4003B0A")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform TeamAElementParent;

		// Token: 0x04003B0B RID: 15115
		[Token(Token = "0x4003B0B")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform TeamBParent;

		// Token: 0x04003B0C RID: 15116
		[Token(Token = "0x4003B0C")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform TeamBElementParent;

		// Token: 0x04003B0D RID: 15117
		[Token(Token = "0x4003B0D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16EE30", Offset = "0x16E230")]
		public GameObject SquadPrefab;

		// Token: 0x04003B0E RID: 15118
		[Token(Token = "0x4003B0E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject MemberPrefab;

		// Token: 0x04003B0F RID: 15119
		[Token(Token = "0x4003B0F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x170DB0", Offset = "0x1701B0")]
		public Image TeamAFlag;

		// Token: 0x04003B10 RID: 15120
		[Token(Token = "0x4003B10")]
		[FieldOffset(Offset = "0x60")]
		public Image TeamBFlag;

		// Token: 0x04003B11 RID: 15121
		[Token(Token = "0x4003B11")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI TeamAName;

		// Token: 0x04003B12 RID: 15122
		[Token(Token = "0x4003B12")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI TeamBName;

		// Token: 0x04003B13 RID: 15123
		[Token(Token = "0x4003B13")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI TeamACount;

		// Token: 0x04003B14 RID: 15124
		[Token(Token = "0x4003B14")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI TeamBCount;

		// Token: 0x04003B15 RID: 15125
		[Token(Token = "0x4003B15")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1721A0", Offset = "0x1715A0")]
		public Canvas TeamACanvas;

		// Token: 0x04003B16 RID: 15126
		[Token(Token = "0x4003B16")]
		[FieldOffset(Offset = "0x90")]
		public Canvas TeamBCanvas;

		// Token: 0x04003B17 RID: 15127
		[Token(Token = "0x4003B17")]
		[FieldOffset(Offset = "0x98")]
		public GraphicRaycaster TeamARaycaster;

		// Token: 0x04003B18 RID: 15128
		[Token(Token = "0x4003B18")]
		[FieldOffset(Offset = "0xA0")]
		public GraphicRaycaster TeamBRaycaster;

		// Token: 0x04003B19 RID: 15129
		[Token(Token = "0x4003B19")]
		[FieldOffset(Offset = "0xA8")]
		public ScrollRect TeamAScroll;

		// Token: 0x04003B1A RID: 15130
		[Token(Token = "0x4003B1A")]
		[FieldOffset(Offset = "0xB0")]
		public ScrollRect TeamBScroll;

		// Token: 0x04003B1B RID: 15131
		[Token(Token = "0x4003B1B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x172280", Offset = "0x171680")]
		public RectTransform Top;

		// Token: 0x04003B1C RID: 15132
		[Token(Token = "0x4003B1C")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform Bottom;

		// Token: 0x04003B1D RID: 15133
		[Token(Token = "0x4003B1D")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1722E0", Offset = "0x1716E0")]
		public Scoreboard_Searching Searching;

		// Token: 0x04003B1E RID: 15134
		[Token(Token = "0x4003B1E")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public List<ScoreboardMember> VisibleMembers;

		// Token: 0x04003B1F RID: 15135
		[Token(Token = "0x4003B1F")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public \u0308\u0308\u0306\u0308\u0308\u0305\u0306\u0307\u0304\u0303\u0301\u0301\u0306\u0302\u0308 LastAppliedScoreboardStyle;

		// Token: 0x04003B20 RID: 15136
		[Token(Token = "0x4003B20")]
		[FieldOffset(Offset = "0xDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003B21 RID: 15137
		[Token(Token = "0x4003B21")]
		[FieldOffset(Offset = "0xE0")]
		private UIPool<ScoreboardMember> mTeamAMemberPool;

		// Token: 0x04003B22 RID: 15138
		[Token(Token = "0x4003B22")]
		[FieldOffset(Offset = "0xE8")]
		private UIPool<ScoreboardMember> mTeamBMemberPool;

		// Token: 0x04003B23 RID: 15139
		[Token(Token = "0x4003B23")]
		[FieldOffset(Offset = "0xF0")]
		private ScoreboardSquad[] mTeamASquads;

		// Token: 0x04003B24 RID: 15140
		[Token(Token = "0x4003B24")]
		[FieldOffset(Offset = "0xF8")]
		private ScoreboardSquad[] mTeamBSquads;

		// Token: 0x04003B25 RID: 15141
		[Token(Token = "0x4003B25")]
		[FieldOffset(Offset = "0x100")]
		private \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 mCurrentTeam;

		// Token: 0x04003B26 RID: 15142
		[Token(Token = "0x4003B26")]
		[FieldOffset(Offset = "0x101")]
		private bool mShowTeams;

		// Token: 0x04003B27 RID: 15143
		[Token(Token = "0x4003B27")]
		[FieldOffset(Offset = "0x104")]
		private int mLockedTeamACount;

		// Token: 0x04003B28 RID: 15144
		[Token(Token = "0x4003B28")]
		[FieldOffset(Offset = "0x108")]
		private int mLockedTeamBCount;

		// Token: 0x04003B29 RID: 15145
		[Token(Token = "0x4003B29")]
		[FieldOffset(Offset = "0x10C")]
		private int mTeamACurrentVersion;

		// Token: 0x04003B2A RID: 15146
		[Token(Token = "0x4003B2A")]
		[FieldOffset(Offset = "0x110")]
		private int mTeamBCurrentVersion;

		// Token: 0x04003B2B RID: 15147
		[Token(Token = "0x4003B2B")]
		[FieldOffset(Offset = "0x114")]
		private int mTeamATargetVersion;

		// Token: 0x04003B2C RID: 15148
		[Token(Token = "0x4003B2C")]
		[FieldOffset(Offset = "0x118")]
		private int mTeamBTargetVersion;

		// Token: 0x04003B2D RID: 15149
		[Token(Token = "0x4003B2D")]
		[FieldOffset(Offset = "0x11C")]
		private float mLastScrollA;

		// Token: 0x04003B2E RID: 15150
		[Token(Token = "0x4003B2E")]
		[FieldOffset(Offset = "0x120")]
		private float mLastScrollB;

		// Token: 0x04003B2F RID: 15151
		[Token(Token = "0x4003B2F")]
		[FieldOffset(Offset = "0x128")]
		private Canvas mCanvas;
	}
}
