using System;
using System.Collections.Generic;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UserInterface.Extentions;

namespace UserInterface.InGameBehaviours
{
	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x200079D")]
	public class Scoreboard_Searching : MonoBehaviour
	{
		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06013C63 RID: 80995 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06013C64 RID: 80996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBC")]
		public static Scoreboard_Searching Instance
		{
			[Token(Token = "0x6013C63")]
			[Address(RVA = "0x16927B0", Offset = "0x1691BB0", VA = "0x1816927B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013C64")]
			[Address(RVA = "0x1692830", Offset = "0x1691C30", VA = "0x181692830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06013C65 RID: 80997 RVA: 0x0007D504 File Offset: 0x0007B704
		// (set) Token: 0x06013C66 RID: 80998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBD")]
		public static bool IsSearching
		{
			[Token(Token = "0x6013C65")]
			[Address(RVA = "0x16927F0", Offset = "0x1691BF0", VA = "0x1816927F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013C66")]
			[Address(RVA = "0x1692880", Offset = "0x1691C80", VA = "0x181692880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x06013C67 RID: 80999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C67")]
		[Address(RVA = "0x16914C0", Offset = "0x16908C0", VA = "0x1816914C0")]
		private void Awake()
		{
		}

		// Token: 0x06013C68 RID: 81000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C68")]
		[Address(RVA = "0x1691A40", Offset = "0x1690E40", VA = "0x181691A40")]
		private void OnEnable()
		{
		}

		// Token: 0x06013C69 RID: 81001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C69")]
		[Address(RVA = "0x16919D0", Offset = "0x1690DD0", VA = "0x1816919D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06013C6A RID: 81002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C6A")]
		[Address(RVA = "0x1691AB0", Offset = "0x1690EB0", VA = "0x181691AB0")]
		public void OnLateUpdate()
		{
		}

		// Token: 0x06013C6B RID: 81003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C6B")]
		[Address(RVA = "0x1691BE0", Offset = "0x1690FE0", VA = "0x181691BE0")]
		private void OnValueChanged(string newValue)
		{
		}

		// Token: 0x06013C6C RID: 81004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C6C")]
		[Address(RVA = "0x16925E0", Offset = "0x16919E0", VA = "0x1816925E0")]
		public static void Open(string name = "")
		{
		}

		// Token: 0x06013C6D RID: 81005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C6D")]
		[Address(RVA = "0x16915D0", Offset = "0x16909D0", VA = "0x1816915D0")]
		public static void Close()
		{
		}

		// Token: 0x06013C6E RID: 81006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C6E")]
		[Address(RVA = "0x1692760", Offset = "0x1691B60", VA = "0x181692760")]
		public Scoreboard_Searching()
		{
		}

		// Token: 0x04003B30 RID: 15152
		[Token(Token = "0x4003B30")]
		public const int MaxResults = 20;

		// Token: 0x04003B31 RID: 15153
		[Token(Token = "0x4003B31")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static Scoreboard_Searching <Instance>k__BackingField;

		// Token: 0x04003B32 RID: 15154
		[Token(Token = "0x4003B32")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <IsSearching>k__BackingField;

		// Token: 0x04003B33 RID: 15155
		[Token(Token = "0x4003B33")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Panel;

		// Token: 0x04003B34 RID: 15156
		[Token(Token = "0x4003B34")]
		[FieldOffset(Offset = "0x20")]
		public TMP_InputField InputField;

		// Token: 0x04003B35 RID: 15157
		[Token(Token = "0x4003B35")]
		[FieldOffset(Offset = "0x28")]
		public Transform Parent;

		// Token: 0x04003B36 RID: 15158
		[Token(Token = "0x4003B36")]
		[FieldOffset(Offset = "0x30")]
		public Scoreboard_Searching_Element Element;

		// Token: 0x04003B37 RID: 15159
		[Token(Token = "0x4003B37")]
		[FieldOffset(Offset = "0x38")]
		private bool mIsPanelEnabled;

		// Token: 0x04003B38 RID: 15160
		[Token(Token = "0x4003B38")]
		[FieldOffset(Offset = "0x40")]
		private List<Scoreboard_Searching.SearchUser> mSearchList;

		// Token: 0x04003B39 RID: 15161
		[Token(Token = "0x4003B39")]
		[FieldOffset(Offset = "0x48")]
		private UIPool<Scoreboard_Searching_Element> mPool;

		// Token: 0x04003B3A RID: 15162
		[Token(Token = "0x4003B3A")]
		[FieldOffset(Offset = "0x50")]
		private List<Scoreboard_Searching_Element> mActive;

		// Token: 0x04003B3B RID: 15163
		[Token(Token = "0x4003B3B")]
		[FieldOffset(Offset = "0x58")]
		private string mLastSearch;

		// Token: 0x0200079E RID: 1950
		[Token(Token = "0x200079E")]
		private struct SearchUser
		{
			// Token: 0x04003B3C RID: 15164
			[Token(Token = "0x4003B3C")]
			[FieldOffset(Offset = "0x0")]
			public int HitCount;

			// Token: 0x04003B3D RID: 15165
			[Token(Token = "0x4003B3D")]
			[FieldOffset(Offset = "0x8")]
			public string DisplayName;

			// Token: 0x04003B3E RID: 15166
			[Token(Token = "0x4003B3E")]
			[FieldOffset(Offset = "0x10")]
			public string SortName;

			// Token: 0x04003B3F RID: 15167
			[Token(Token = "0x4003B3F")]
			[FieldOffset(Offset = "0x18")]
			public \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 Client;
		}

		// Token: 0x0200079F RID: 1951
		[Token(Token = "0x200079F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06013C70 RID: 81008 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013C70")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c()
			{
			}

			// Token: 0x06013C71 RID: 81009 RVA: 0x0007D51C File Offset: 0x0007B71C
			[Token(Token = "0x6013C71")]
			[Address(RVA = "0x1699380", Offset = "0x1698780", VA = "0x181699380")]
			internal int <OnValueChanged>b__22_0(Scoreboard_Searching.SearchUser x, Scoreboard_Searching.SearchUser y)
			{
				return 0;
			}

			// Token: 0x04003B40 RID: 15168
			[Token(Token = "0x4003B40")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Scoreboard_Searching.<>c <>9;

			// Token: 0x04003B41 RID: 15169
			[Token(Token = "0x4003B41")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Scoreboard_Searching.SearchUser> <>9__22_0;
		}
	}
}
