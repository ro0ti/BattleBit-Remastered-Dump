using System;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006B7 RID: 1719
	[Token(Token = "0x20006B7")]
	public static class PingBuffer
	{
		// Token: 0x06012815 RID: 75797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012815")]
		[Address(RVA = "0x17227D0", Offset = "0x1721BD0", VA = "0x1817227D0")]
		public static void SetPing(int ID, int ping)
		{
		}

		// Token: 0x06012816 RID: 75798 RVA: 0x00073D0C File Offset: 0x00071F0C
		[Token(Token = "0x6012816")]
		[Address(RVA = "0x17225D0", Offset = "0x17219D0", VA = "0x1817225D0")]
		public static int GetPing(int ID)
		{
			return 0;
		}

		// Token: 0x06012817 RID: 75799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012817")]
		[Address(RVA = "0x1722450", Offset = "0x1721850", VA = "0x181722450")]
		public static void ExchangeReceivedPingBuffer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 newBuffer)
		{
		}

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		public const int HeaderSize = 2;

		// Token: 0x0400329B RID: 12955
		[Token(Token = "0x400329B")]
		public const int BufferSize = 510;

		// Token: 0x0400329C RID: 12956
		[Token(Token = "0x400329C")]
		[FieldOffset(Offset = "0x0")]
		public static byte[] ServerPingResponse;

		// Token: 0x0400329D RID: 12957
		[Token(Token = "0x400329D")]
		[FieldOffset(Offset = "0x8")]
		public static \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ClientReceivedPingRequestBuffer;

		// Token: 0x0400329E RID: 12958
		[Token(Token = "0x400329E")]
		[FieldOffset(Offset = "0x10")]
		private static object BufferExchangeLock;
	}
}
