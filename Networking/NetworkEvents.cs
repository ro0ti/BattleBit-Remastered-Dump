using System;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006B4 RID: 1716
	[Token(Token = "0x20006B4")]
	public static class NetworkEvents
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06012809 RID: 75785 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0601280A RID: 75786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public static event NetworkingEvent OnConnectedEvent
		{
			[Token(Token = "0x6012809")]
			[Address(RVA = "0x171B790", Offset = "0x171AB90", VA = "0x18171B790")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			add
			{
			}
			[Token(Token = "0x601280A")]
			[Address(RVA = "0x171B8F0", Offset = "0x171ACF0", VA = "0x18171B8F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0601280B RID: 75787 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0601280C RID: 75788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		public static event NetworkingEvent OnDisconnectedEvent
		{
			[Token(Token = "0x601280B")]
			[Address(RVA = "0x171B840", Offset = "0x171AC40", VA = "0x18171B840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			add
			{
			}
			[Token(Token = "0x601280C")]
			[Address(RVA = "0x171B9A0", Offset = "0x171ADA0", VA = "0x18171B9A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			remove
			{
			}
		}

		// Token: 0x0601280D RID: 75789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601280D")]
		[Address(RVA = "0x171B260", Offset = "0x171A660", VA = "0x18171B260")]
		public static void OnConnected()
		{
		}

		// Token: 0x0601280E RID: 75790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601280E")]
		[Address(RVA = "0x171B340", Offset = "0x171A740", VA = "0x18171B340")]
		public static void OnDisconnected()
		{
		}

		// Token: 0x0601280F RID: 75791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601280F")]
		[Address(RVA = "0x171B3B0", Offset = "0x171A7B0", VA = "0x18171B3B0")]
		public static void OnNetworkClientConnected(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client)
		{
		}

		// Token: 0x06012810 RID: 75792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012810")]
		[Address(RVA = "0x171B4C0", Offset = "0x171A8C0", VA = "0x18171B4C0")]
		public static void OnNetworkClientDisconnected(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client)
		{
		}
	}
}
