using System;
using touching_your_mom;

namespace Networking.Core
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	public class UnverifiedOutgoingPackage
	{
		// Token: 0x06012910 RID: 76048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012910")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public UnverifiedOutgoingPackage()
		{
		}

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0x10")]
		public float EtaResend;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0x18")]
		public SharedPackage Package;
	}
}
