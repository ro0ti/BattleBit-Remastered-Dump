using System;
using System.Collections.Generic;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UserInterface.Extentions;

namespace UserInterface.MainMenu
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public class ServerList : MonoBehaviour
	{
		// Token: 0x06013A78 RID: 80504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A78")]
		[Address(RVA = "0x1696EC0", Offset = "0x16962C0", VA = "0x181696EC0")]
		public ServerList()
		{
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06013A79 RID: 80505 RVA: 0x0007CFAC File Offset: 0x0007B1AC
		// (set) Token: 0x06013A7A RID: 80506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B89")]
		public static int NumberOfServersKnown
		{
			[Token(Token = "0x6013A79")]
			[Address(RVA = "0x16971E0", Offset = "0x16965E0", VA = "0x1816971E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013A7A")]
			[Address(RVA = "0x16977C0", Offset = "0x1696BC0", VA = "0x1816977C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06013A7B RID: 80507 RVA: 0x0007CFC4 File Offset: 0x0007B1C4
		// (set) Token: 0x06013A7C RID: 80508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8A")]
		public static int NumberOfServerListRefreshed
		{
			[Token(Token = "0x6013A7B")]
			[Address(RVA = "0x1697120", Offset = "0x1696520", VA = "0x181697120")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013A7C")]
			[Address(RVA = "0x1697760", Offset = "0x1696B60", VA = "0x181697760")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06013A7D RID: 80509 RVA: 0x0007CFDC File Offset: 0x0007B1DC
		// (set) Token: 0x06013A7E RID: 80510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8B")]
		public static DateTime ServersOpenTime
		{
			[Token(Token = "0x6013A7D")]
			[Address(RVA = "0x16972A0", Offset = "0x16966A0", VA = "0x1816972A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6013A7E")]
			[Address(RVA = "0x1697820", Offset = "0x1696C20", VA = "0x181697820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06013A7F RID: 80511 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06013A80 RID: 80512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8C")]
		public static List<\u0306\u0304\u0301\u0306\u0304\u0301\u0305\u0301\u0308\u0305\u0304\u0303\u0303\u0303\u0301> Servers
		{
			[Token(Token = "0x6013A7F")]
			[Address(RVA = "0x1697360", Offset = "0x1696760", VA = "0x181697360")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013A80")]
			[Address(RVA = "0x1697880", Offset = "0x1696C80", VA = "0x181697880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06013A81 RID: 80513 RVA: 0x0007CFF4 File Offset: 0x0007B1F4
		[Token(Token = "0x17000B8D")]
		public static bool IsServersOn
		{
			[Token(Token = "0x6013A81")]
			[Address(RVA = "0x1696F30", Offset = "0x1696330", VA = "0x181696F30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06013A82 RID: 80514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A82")]
		[Address(RVA = "0x16955F0", Offset = "0x16949F0", VA = "0x1816955F0")]
		private void Awake()
		{
		}

		// Token: 0x06013A83 RID: 80515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A83")]
		[Address(RVA = "0x1695CA0", Offset = "0x16950A0", VA = "0x181695CA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013A84 RID: 80516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A84")]
		[Address(RVA = "0x1695E70", Offset = "0x1695270", VA = "0x181695E70")]
		private void Start()
		{
		}

		// Token: 0x06013A85 RID: 80517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A85")]
		[Address(RVA = "0x1695C90", Offset = "0x1695090", VA = "0x181695C90")]
		private void OnDisable()
		{
		}

		// Token: 0x06013A86 RID: 80518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A86")]
		[Address(RVA = "0x1696BB0", Offset = "0x1695FB0", VA = "0x181696BB0")]
		private void Update()
		{
		}

		// Token: 0x06013A87 RID: 80519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A87")]
		[Address(RVA = "0x1695EC0", Offset = "0x16952C0", VA = "0x181695EC0")]
		public static void UpdateServers(bool forceRefresh = false)
		{
		}

		// Token: 0x06013A88 RID: 80520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A88")]
		[Address(RVA = "0x1697420", Offset = "0x1696820", VA = "0x181697420")]
		private static void mOnReceivedServerList(DateTime serverOpenTime, List<\u0306\u0304\u0301\u0306\u0304\u0301\u0305\u0301\u0308\u0305\u0304\u0303\u0303\u0303\u0301> servers)
		{
		}

		// Token: 0x06013A89 RID: 80521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A89")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		public void OnFocus()
		{
		}

		// Token: 0x06013A8A RID: 80522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A8A")]
		[Address(RVA = "0x1695CB0", Offset = "0x16950B0", VA = "0x181695CB0")]
		public void OnRefresh()
		{
		}

		// Token: 0x06013A8B RID: 80523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A8B")]
		[Address(RVA = "0x16960A0", Offset = "0x16954A0", VA = "0x1816960A0")]
		public void UpdateSortingFor(ServerListSortItem item)
		{
		}

		// Token: 0x06013A8C RID: 80524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A8C")]
		[Address(RVA = "0x16961F0", Offset = "0x16955F0", VA = "0x1816961F0")]
		public void UpdateSorting()
		{
		}

		// Token: 0x06013A8D RID: 80525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A8D")]
		[Address(RVA = "0x16957D0", Offset = "0x1694BD0", VA = "0x1816957D0")]
		public void LoadServers(List<\u0306\u0304\u0301\u0306\u0304\u0301\u0305\u0301\u0308\u0305\u0304\u0303\u0303\u0303\u0301> servers)
		{
		}

		// Token: 0x06013A8E RID: 80526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A8E")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		public void ClearServers()
		{
		}

		// Token: 0x04003810 RID: 14352
		[Token(Token = "0x4003810")]
		[FieldOffset(Offset = "0x0")]
		public static ServerList instance;

		// Token: 0x04003811 RID: 14353
		[Token(Token = "0x4003811")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static int <NumberOfServersKnown>k__BackingField;

		// Token: 0x04003812 RID: 14354
		[Token(Token = "0x4003812")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static int <NumberOfServerListRefreshed>k__BackingField;

		// Token: 0x04003813 RID: 14355
		[Token(Token = "0x4003813")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static DateTime <ServersOpenTime>k__BackingField;

		// Token: 0x04003814 RID: 14356
		[Token(Token = "0x4003814")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static List<\u0306\u0304\u0301\u0306\u0304\u0301\u0305\u0301\u0308\u0305\u0304\u0303\u0303\u0303\u0301> <Servers>k__BackingField;

		// Token: 0x04003815 RID: 14357
		[Token(Token = "0x4003815")]
		[FieldOffset(Offset = "0x20")]
		public static float LastRefresh;

		// Token: 0x04003816 RID: 14358
		[Token(Token = "0x4003816")]
		[FieldOffset(Offset = "0x24")]
		private static bool mIsSearching;

		// Token: 0x04003817 RID: 14359
		[Token(Token = "0x4003817")]
		[FieldOffset(Offset = "0x18")]
		public Transform Parent;

		// Token: 0x04003818 RID: 14360
		[Token(Token = "0x4003818")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Prefab;

		// Token: 0x04003819 RID: 14361
		[Token(Token = "0x4003819")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SrcBtn;

		// Token: 0x0400381A RID: 14362
		[Token(Token = "0x400381A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SrcLoading;

		// Token: 0x0400381B RID: 14363
		[Token(Token = "0x400381B")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup Top;

		// Token: 0x0400381C RID: 14364
		[Token(Token = "0x400381C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x163DD0", Offset = "0x1631D0")]
		public TMP_InputField ServerNameFilter;

		// Token: 0x0400381D RID: 14365
		[Token(Token = "0x400381D")]
		[FieldOffset(Offset = "0x48")]
		public \u0305\u0305\u0304\u0301\u0308\u0306\u0301\u0303\u0306\u0301\u0308\u0303\u0301\u0301\u0302 GamemodesFilter;

		// Token: 0x0400381E RID: 14366
		[Token(Token = "0x400381E")]
		[FieldOffset(Offset = "0x50")]
		public \u0302\u0306\u0308\u0307\u0303\u0302\u0306\u0308\u0305\u0308\u0301\u0305\u0308\u0306\u0304 GameMapsFilter;

		// Token: 0x0400381F RID: 14367
		[Token(Token = "0x400381F")]
		[FieldOffset(Offset = "0x58")]
		public \u0306\u0303\u0306\u0301\u0305\u0308\u0307\u0306\u0308\u0303\u0301\u0308\u0302\u0302\u0303 SizeFilter;

		// Token: 0x04003820 RID: 14368
		[Token(Token = "0x4003820")]
		[FieldOffset(Offset = "0x60")]
		public ServerListSortItem[] SortItems;

		// Token: 0x04003821 RID: 14369
		[Token(Token = "0x4003821")]
		[FieldOffset(Offset = "0x68")]
		private UIPool<ServerListElement> mPool;

		// Token: 0x04003822 RID: 14370
		[Token(Token = "0x4003822")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<ulong, ServerListElement> mElements;

		// Token: 0x04003823 RID: 14371
		[Token(Token = "0x4003823")]
		[FieldOffset(Offset = "0x78")]
		private List<ServerListElement> mSortElements;

		// Token: 0x04003824 RID: 14372
		[Token(Token = "0x4003824")]
		[FieldOffset(Offset = "0x80")]
		private Queue<ulong> mRemoveQueue;

		// Token: 0x04003825 RID: 14373
		[Token(Token = "0x4003825")]
		[FieldOffset(Offset = "0x88")]
		private CanvasGroup mCanvasGroup;

		// Token: 0x04003826 RID: 14374
		[Token(Token = "0x4003826")]
		[FieldOffset(Offset = "0x90")]
		private HashSet<\u0306\u0307\u0303\u0304\u0301\u0301\u0305\u0308\u0301\u0306\u0307\u0302\u0304\u0306\u0305> mAllowedSizes;

		// Token: 0x04003827 RID: 14375
		[Token(Token = "0x4003827")]
		[FieldOffset(Offset = "0x98")]
		private HashSet<\u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304> mAllowedGamemodes;

		// Token: 0x04003828 RID: 14376
		[Token(Token = "0x4003828")]
		[FieldOffset(Offset = "0xA0")]
		private ServerListSortItem mLastSort;

		// Token: 0x04003829 RID: 14377
		[Token(Token = "0x4003829")]
		[FieldOffset(Offset = "0xA8")]
		private HashSet<string> mAllowedMaps;

		// Token: 0x0400382A RID: 14378
		[Token(Token = "0x400382A")]
		[FieldOffset(Offset = "0xB0")]
		private bool mIgnoreAlphaUpdate;

		// Token: 0x0400382B RID: 14379
		[Token(Token = "0x400382B")]
		[FieldOffset(Offset = "0xB1")]
		private bool mIsActive;

		// Token: 0x02000764 RID: 1892
		[Token(Token = "0x2000764")]
		public enum Sorting
		{
			// Token: 0x0400382D RID: 14381
			[Token(Token = "0x400382D")]
			Map,
			// Token: 0x0400382E RID: 14382
			[Token(Token = "0x400382E")]
			Gamemode,
			// Token: 0x0400382F RID: 14383
			[Token(Token = "0x400382F")]
			Servername,
			// Token: 0x04003830 RID: 14384
			[Token(Token = "0x4003830")]
			Type,
			// Token: 0x04003831 RID: 14385
			[Token(Token = "0x4003831")]
			Tickrate,
			// Token: 0x04003832 RID: 14386
			[Token(Token = "0x4003832")]
			Players,
			// Token: 0x04003833 RID: 14387
			[Token(Token = "0x4003833")]
			Ping,
			// Token: 0x04003834 RID: 14388
			[Token(Token = "0x4003834")]
			Favorite,
			// Token: 0x04003835 RID: 14389
			[Token(Token = "0x4003835")]
			MapSize,
			// Token: 0x04003836 RID: 14390
			[Token(Token = "0x4003836")]
			None
		}

		// Token: 0x02000765 RID: 1893
		[Token(Token = "0x2000765")]
		public class Sorter : Comparer<ServerListElement>
		{
			// Token: 0x06013A90 RID: 80528 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013A90")]
			[Address(RVA = "0x1697CD0", Offset = "0x16970D0", VA = "0x181697CD0")]
			public Sorter(ServerList.Sorting sort, bool revert)
			{
			}

			// Token: 0x06013A91 RID: 80529 RVA: 0x0007D00C File Offset: 0x0007B20C
			[Token(Token = "0x6013A91")]
			[Address(RVA = "0x16978F0", Offset = "0x1696CF0", VA = "0x1816978F0", Slot = "6")]
			public override int Compare(ServerListElement a, ServerListElement b)
			{
				return 0;
			}

			// Token: 0x04003837 RID: 14391
			[Token(Token = "0x4003837")]
			[FieldOffset(Offset = "0x10")]
			private ServerList.Sorting sort;

			// Token: 0x04003838 RID: 14392
			[Token(Token = "0x4003838")]
			[FieldOffset(Offset = "0x14")]
			private bool revert;
		}
	}
}
