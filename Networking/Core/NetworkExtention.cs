using System;
using System.Collections.Generic;
using System.Net;
using touching_your_mom;

namespace Networking.Core
{
	// Token: 0x020006CF RID: 1743
	[Token(Token = "0x20006CF")]
	internal static class NetworkExtention
	{
		// Token: 0x06012907 RID: 76039 RVA: 0x000740B4 File Offset: 0x000722B4
		[Token(Token = "0x6012907")]
		[Address(RVA = "0x171BB60", Offset = "0x171AF60", VA = "0x18171BB60")]
		public static uint GetIP(this IPEndPoint ip)
		{
			return 0U;
		}

		// Token: 0x06012908 RID: 76040 RVA: 0x000740CC File Offset: 0x000722CC
		[Token(Token = "0x6012908")]
		[Address(RVA = "0x171BBB0", Offset = "0x171AFB0", VA = "0x18171BBB0")]
		public static uint GetIP(this EndPoint ip)
		{
			return 0U;
		}

		// Token: 0x06012909 RID: 76041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012909")]
		public static void AddOrUpdate<T1, T2>(this Dictionary<T1, T2> dic, T1 key, T2 value)
		{
		}

		// Token: 0x0601290A RID: 76042 RVA: 0x000740E4 File Offset: 0x000722E4
		[Token(Token = "0x601290A")]
		[Address(RVA = "0x171BB00", Offset = "0x171AF00", VA = "0x18171BB00")]
		public static ulong GetHash(this IPEndPoint ip)
		{
			return 0UL;
		}

		// Token: 0x0601290B RID: 76043 RVA: 0x000740FC File Offset: 0x000722FC
		[Token(Token = "0x601290B")]
		[Address(RVA = "0x171BA50", Offset = "0x171AE50", VA = "0x18171BA50")]
		public static ulong GetHash(this EndPoint ep)
		{
			return 0UL;
		}
	}
}
