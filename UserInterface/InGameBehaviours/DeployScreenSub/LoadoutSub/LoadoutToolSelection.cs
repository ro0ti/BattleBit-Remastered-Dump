using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UserInterface.Extentions;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007BF RID: 1983
	[Token(Token = "0x20007BF")]
	public class LoadoutToolSelection : MonoBehaviour
	{
		// Token: 0x06013D6A RID: 81258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D6A")]
		[Address(RVA = "0x17FD5E0", Offset = "0x17FC9E0", VA = "0x1817FD5E0")]
		public LoadoutToolSelection()
		{
		}

		// Token: 0x06013D6B RID: 81259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D6B")]
		[Address(RVA = "0x17F9FE0", Offset = "0x17F93E0", VA = "0x1817F9FE0")]
		private void Awake()
		{
		}

		// Token: 0x06013D6C RID: 81260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D6C")]
		[Address(RVA = "0x17FA580", Offset = "0x17F9980", VA = "0x1817FA580")]
		public void Load(\u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 index)
		{
		}

		// Token: 0x06013D6D RID: 81261 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013D6D")]
		[Address(RVA = "0x17FA130", Offset = "0x17F9530", VA = "0x1817FA130")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x17BDA0", Offset = "0x17B1A0")]
		private IEnumerable<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> ClearWorkInProgress(IEnumerable<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> collection)
		{
			return null;
		}

		// Token: 0x06013D6E RID: 81262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D6E")]
		[Address(RVA = "0x17FD700", Offset = "0x17FCB00", VA = "0x1817FD700")]
		private void createSub(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 item, bool isSelected)
		{
		}

		// Token: 0x06013D6F RID: 81263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D6F")]
		[Address(RVA = "0x17FD9F0", Offset = "0x17FCDF0", VA = "0x1817FD9F0")]
		private void create(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 item, bool isSelected)
		{
		}

		// Token: 0x06013D70 RID: 81264 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013D70")]
		[Address(RVA = "0x17FD7F0", Offset = "0x17FCBF0", VA = "0x1817FD7F0")]
		private GameObject createTitle(string str)
		{
			return null;
		}

		// Token: 0x06013D71 RID: 81265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D71")]
		[Address(RVA = "0x17FA1A0", Offset = "0x17F95A0", VA = "0x1817FA1A0")]
		private void DeleteTitle(GameObject obj)
		{
		}

		// Token: 0x06013D72 RID: 81266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D72")]
		[Address(RVA = "0x17FA230", Offset = "0x17F9630", VA = "0x1817FA230")]
		private void Flush()
		{
		}

		// Token: 0x06013D73 RID: 81267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D73")]
		[Address(RVA = "0x17FD300", Offset = "0x17FC700", VA = "0x1817FD300")]
		public void OnItemSelected(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 tool)
		{
		}

		// Token: 0x04003C87 RID: 15495
		[Token(Token = "0x4003C87")]
		[FieldOffset(Offset = "0x0")]
		public static LoadoutToolSelection Instance;

		// Token: 0x04003C88 RID: 15496
		[Token(Token = "0x4003C88")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Prefab;

		// Token: 0x04003C89 RID: 15497
		[Token(Token = "0x4003C89")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PrefabSub;

		// Token: 0x04003C8A RID: 15498
		[Token(Token = "0x4003C8A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject PrefabTitle;

		// Token: 0x04003C8B RID: 15499
		[Token(Token = "0x4003C8B")]
		[FieldOffset(Offset = "0x30")]
		public Transform Parent;

		// Token: 0x04003C8C RID: 15500
		[Token(Token = "0x4003C8C")]
		[FieldOffset(Offset = "0x38")]
		public LoadoutToolLine Line;

		// Token: 0x04003C8D RID: 15501
		[Token(Token = "0x4003C8D")]
		[FieldOffset(Offset = "0x40")]
		private List<LoadoutToolSelectionElement> spawnedObjects;

		// Token: 0x04003C8E RID: 15502
		[Token(Token = "0x4003C8E")]
		[FieldOffset(Offset = "0x48")]
		private List<LoadoutToolSelectionSubElement> spawnedSubObjects;

		// Token: 0x04003C8F RID: 15503
		[Token(Token = "0x4003C8F")]
		[FieldOffset(Offset = "0x50")]
		private List<TextMeshProUGUI> spawnedTitles;

		// Token: 0x04003C90 RID: 15504
		[Token(Token = "0x4003C90")]
		[FieldOffset(Offset = "0x58")]
		private List<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> mTools;

		// Token: 0x04003C91 RID: 15505
		[Token(Token = "0x4003C91")]
		[FieldOffset(Offset = "0x60")]
		private \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 latestIndex;

		// Token: 0x04003C92 RID: 15506
		[Token(Token = "0x4003C92")]
		[FieldOffset(Offset = "0x68")]
		private UIPool<LoadoutToolSelectionSubElement> poolSubElements;

		// Token: 0x04003C93 RID: 15507
		[Token(Token = "0x4003C93")]
		[FieldOffset(Offset = "0x70")]
		private UIPool<LoadoutToolSelectionElement> poolElements;

		// Token: 0x04003C94 RID: 15508
		[Token(Token = "0x4003C94")]
		[FieldOffset(Offset = "0x78")]
		private UIPool<TextMeshProUGUI> poolTitles;

		// Token: 0x020007C0 RID: 1984
		[Token(Token = "0x20007C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06013D75 RID: 81269 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D75")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c()
			{
			}

			// Token: 0x06013D76 RID: 81270 RVA: 0x0007D834 File Offset: 0x0007BA34
			[Token(Token = "0x6013D76")]
			[Address(RVA = "0x1803820", Offset = "0x1802C20", VA = "0x181803820")]
			internal int <Load>b__13_0(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D77 RID: 81271 RVA: 0x0007D84C File Offset: 0x0007BA4C
			[Token(Token = "0x6013D77")]
			[Address(RVA = "0x18039D0", Offset = "0x1802DD0", VA = "0x1818039D0")]
			internal int <Load>b__13_1(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D78 RID: 81272 RVA: 0x0007D864 File Offset: 0x0007BA64
			[Token(Token = "0x6013D78")]
			[Address(RVA = "0x1803A60", Offset = "0x1802E60", VA = "0x181803A60")]
			internal int <Load>b__13_2(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D79 RID: 81273 RVA: 0x0007D87C File Offset: 0x0007BA7C
			[Token(Token = "0x6013D79")]
			[Address(RVA = "0x1803AF0", Offset = "0x1802EF0", VA = "0x181803AF0")]
			internal int <Load>b__13_3(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D7A RID: 81274 RVA: 0x0007D894 File Offset: 0x0007BA94
			[Token(Token = "0x6013D7A")]
			[Address(RVA = "0x1803B80", Offset = "0x1802F80", VA = "0x181803B80")]
			internal int <Load>b__13_4(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D7B RID: 81275 RVA: 0x0007D8AC File Offset: 0x0007BAAC
			[Token(Token = "0x6013D7B")]
			[Address(RVA = "0x1803C10", Offset = "0x1803010", VA = "0x181803C10")]
			internal int <Load>b__13_5(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D7C RID: 81276 RVA: 0x0007D8C4 File Offset: 0x0007BAC4
			[Token(Token = "0x6013D7C")]
			[Address(RVA = "0x1803CA0", Offset = "0x18030A0", VA = "0x181803CA0")]
			internal int <Load>b__13_6(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D7D RID: 81277 RVA: 0x0007D8DC File Offset: 0x0007BADC
			[Token(Token = "0x6013D7D")]
			[Address(RVA = "0x1803D30", Offset = "0x1803130", VA = "0x181803D30")]
			internal int <Load>b__13_7(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D7E RID: 81278 RVA: 0x0007D8F4 File Offset: 0x0007BAF4
			[Token(Token = "0x6013D7E")]
			[Address(RVA = "0x1803DC0", Offset = "0x18031C0", VA = "0x181803DC0")]
			internal int <Load>b__13_8(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D7F RID: 81279 RVA: 0x0007D90C File Offset: 0x0007BB0C
			[Token(Token = "0x6013D7F")]
			[Address(RVA = "0x1803E50", Offset = "0x1803250", VA = "0x181803E50")]
			internal int <Load>b__13_9(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D80 RID: 81280 RVA: 0x0007D924 File Offset: 0x0007BB24
			[Token(Token = "0x6013D80")]
			[Address(RVA = "0x18038B0", Offset = "0x1802CB0", VA = "0x1818038B0")]
			internal int <Load>b__13_10(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x06013D81 RID: 81281 RVA: 0x0007D93C File Offset: 0x0007BB3C
			[Token(Token = "0x6013D81")]
			[Address(RVA = "0x1803940", Offset = "0x1802D40", VA = "0x181803940")]
			internal int <Load>b__13_11(\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 x, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 y)
			{
				return 0;
			}

			// Token: 0x04003C95 RID: 15509
			[Token(Token = "0x4003C95")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LoadoutToolSelection.<>c <>9;

			// Token: 0x04003C96 RID: 15510
			[Token(Token = "0x4003C96")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_0;

			// Token: 0x04003C97 RID: 15511
			[Token(Token = "0x4003C97")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_1;

			// Token: 0x04003C98 RID: 15512
			[Token(Token = "0x4003C98")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_2;

			// Token: 0x04003C99 RID: 15513
			[Token(Token = "0x4003C99")]
			[FieldOffset(Offset = "0x20")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_3;

			// Token: 0x04003C9A RID: 15514
			[Token(Token = "0x4003C9A")]
			[FieldOffset(Offset = "0x28")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_4;

			// Token: 0x04003C9B RID: 15515
			[Token(Token = "0x4003C9B")]
			[FieldOffset(Offset = "0x30")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_5;

			// Token: 0x04003C9C RID: 15516
			[Token(Token = "0x4003C9C")]
			[FieldOffset(Offset = "0x38")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_6;

			// Token: 0x04003C9D RID: 15517
			[Token(Token = "0x4003C9D")]
			[FieldOffset(Offset = "0x40")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_7;

			// Token: 0x04003C9E RID: 15518
			[Token(Token = "0x4003C9E")]
			[FieldOffset(Offset = "0x48")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_8;

			// Token: 0x04003C9F RID: 15519
			[Token(Token = "0x4003C9F")]
			[FieldOffset(Offset = "0x50")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_9;

			// Token: 0x04003CA0 RID: 15520
			[Token(Token = "0x4003CA0")]
			[FieldOffset(Offset = "0x58")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_10;

			// Token: 0x04003CA1 RID: 15521
			[Token(Token = "0x4003CA1")]
			[FieldOffset(Offset = "0x60")]
			public static Comparison<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>9__13_11;
		}

		// Token: 0x020007C1 RID: 1985
		[Token(Token = "0x20007C1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <ClearWorkInProgress>d__14 : IEnumerable<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301>, IEnumerable, IEnumerator<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301>, IEnumerator, IDisposable
		{
			// Token: 0x06013D82 RID: 81282 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D82")]
			[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
			[DebuggerHidden]
			public <ClearWorkInProgress>d__14(int <>1__state)
			{
			}

			// Token: 0x06013D83 RID: 81283 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D83")]
			[Address(RVA = "0x1803690", Offset = "0x1802A90", VA = "0x181803690", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013D84 RID: 81284 RVA: 0x0007D954 File Offset: 0x0007BB54
			[Token(Token = "0x6013D84")]
			[Address(RVA = "0x1803340", Offset = "0x1802740", VA = "0x181803340", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06013D85 RID: 81285 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D85")]
			[Address(RVA = "0x1803730", Offset = "0x1802B30", VA = "0x181803730")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x06013D86 RID: 81286 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000BD6")]
			private \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 Current
			{
				[Token(Token = "0x6013D86")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013D87 RID: 81287 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D87")]
			[Address(RVA = "0x1803640", Offset = "0x1802A40", VA = "0x181803640", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x06013D88 RID: 81288 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000BD7")]
			private object Current
			{
				[Token(Token = "0x6013D88")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013D89 RID: 81289 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013D89")]
			[Address(RVA = "0x18035A0", Offset = "0x18029A0", VA = "0x1818035A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06013D8A RID: 81290 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013D8A")]
			[Address(RVA = "0x18035A0", Offset = "0x18029A0", VA = "0x1818035A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04003CA2 RID: 15522
			[Token(Token = "0x4003CA2")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04003CA3 RID: 15523
			[Token(Token = "0x4003CA3")]
			[FieldOffset(Offset = "0x18")]
			private \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301 <>2__current;

			// Token: 0x04003CA4 RID: 15524
			[Token(Token = "0x4003CA4")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04003CA5 RID: 15525
			[Token(Token = "0x4003CA5")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerable<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> collection;

			// Token: 0x04003CA6 RID: 15526
			[Token(Token = "0x4003CA6")]
			[FieldOffset(Offset = "0x30")]
			public IEnumerable<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>3__collection;

			// Token: 0x04003CA7 RID: 15527
			[Token(Token = "0x4003CA7")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<\u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301> <>7__wrap1;
		}
	}
}
