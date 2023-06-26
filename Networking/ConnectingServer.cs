using System;
using System.Net;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006B8 RID: 1720
	[Token(Token = "0x20006B8")]
	public struct ConnectingServer
	{
		// Token: 0x0400329F RID: 12959
		[Token(Token = "0x400329F")]
		[FieldOffset(Offset = "0x0")]
		public bool IsValid;

		// Token: 0x040032A0 RID: 12960
		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x8")]
		public IPEndPoint IpEndPoint;

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x10")]
		public string Map;
	}
}
