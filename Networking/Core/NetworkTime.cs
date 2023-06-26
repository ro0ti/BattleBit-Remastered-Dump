using System;
using System.Diagnostics;
using touching_your_mom;

namespace Networking.Core
{
	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x20006D0")]
	public static class NetworkTime
	{
		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x0601290C RID: 76044 RVA: 0x00074114 File Offset: 0x00072314
		[Token(Token = "0x17000A4B")]
		public static long now
		{
			[Token(Token = "0x601290C")]
			[Address(RVA = "0x17223E0", Offset = "0x17217E0", VA = "0x1817223E0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[FieldOffset(Offset = "0x40DB704")]
		private static Stopwatch watch;
	}
}
