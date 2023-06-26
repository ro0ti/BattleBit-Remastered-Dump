using System;
using System.Collections.Generic;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006B9 RID: 1721
	[Token(Token = "0x20006B9")]
	public static class NetworkSynchronization
	{
		// Token: 0x06012818 RID: 75800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012818")]
		[Address(RVA = "0x171F770", Offset = "0x171EB70", VA = "0x18171F770")]
		public static void Add(SyncFunction function)
		{
		}

		// Token: 0x06012819 RID: 75801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012819")]
		[Address(RVA = "0x17200A0", Offset = "0x171F4A0", VA = "0x1817200A0")]
		public static void Remove(SyncFunction function)
		{
		}

		// Token: 0x0601281A RID: 75802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601281A")]
		[Address(RVA = "0x1721BD0", Offset = "0x1720FD0", VA = "0x181721BD0")]
		private static void WriteTo(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, \u0308\u0304\u0303\u0306\u0307\u0305\u0302\u0308\u0301\u0301\u0304\u0304\u0302\u0306\u0305 order)
		{
		}

		// Token: 0x0601281B RID: 75803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601281B")]
		[Address(RVA = "0x171FA30", Offset = "0x171EE30", VA = "0x18171FA30")]
		private static void ReadFrom(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601281C RID: 75804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601281C")]
		[Address(RVA = "0x17215B0", Offset = "0x17209B0", VA = "0x1817215B0")]
		private static void WriteLevelTo(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601281D RID: 75805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601281D")]
		[Address(RVA = "0x171FD60", Offset = "0x171F160", VA = "0x18171FD60")]
		private static void ReadLevelFrom(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601281E RID: 75806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601281E")]
		[Address(RVA = "0x1720F60", Offset = "0x1720360", VA = "0x181720F60")]
		public static void SyncToClient(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 package)
		{
		}

		// Token: 0x0601281F RID: 75807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601281F")]
		[Address(RVA = "0x17201F0", Offset = "0x171F5F0", VA = "0x1817201F0")]
		public static void SyncFromServer(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 package)
		{
		}

		// Token: 0x06012820 RID: 75808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012820")]
		[Address(RVA = "0x171F950", Offset = "0x171ED50", VA = "0x18171F950")]
		public static void Clear()
		{
		}

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsSynchronizating;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, SyncFunction> Hash2Functions;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x10")]
		private static List<SyncFunction>[] IdToFunctions;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<ulong, List<\u0302\u0305\u0302\u0306\u0308\u0308\u0302\u0308\u0303\u0304\u0308\u0304\u0307\u0308\u0302>> writeLevelTemp;
	}
}
