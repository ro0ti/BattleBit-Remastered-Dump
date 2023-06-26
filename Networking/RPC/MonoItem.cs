using System;
using System.Reflection;
using touching_your_mom;

namespace Networking.RPC
{
	// Token: 0x020006C6 RID: 1734
	[Token(Token = "0x20006C6")]
	public struct MonoItem
	{
		// Token: 0x060128B5 RID: 75957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128B5")]
		[Address(RVA = "0x1717DB0", Offset = "0x17171B0", VA = "0x181717DB0")]
		public void WriteTo(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x060128B6 RID: 75958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128B6")]
		[Address(RVA = "0x1717B60", Offset = "0x1716F60", VA = "0x181717B60")]
		public void ReadFrom(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x060128B7 RID: 75959 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128B7")]
		[Address(RVA = "0x1717AF0", Offset = "0x1716EF0", VA = "0x181717AF0")]
		public static string GetNameOf(Type t)
		{
			return null;
		}

		// Token: 0x060128B8 RID: 75960 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128B8")]
		[Address(RVA = "0x1717D40", Offset = "0x1717140", VA = "0x181717D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003320 RID: 13088
		[Token(Token = "0x4003320")]
		[FieldOffset(Offset = "0x0")]
		public Type Type;

		// Token: 0x04003321 RID: 13089
		[Token(Token = "0x4003321")]
		[FieldOffset(Offset = "0x8")]
		public MethodInfo MethodInfo;

		// Token: 0x04003322 RID: 13090
		[Token(Token = "0x4003322")]
		[FieldOffset(Offset = "0x10")]
		public bool IncludesParamater;

		// Token: 0x04003323 RID: 13091
		[Token(Token = "0x4003323")]
		[FieldOffset(Offset = "0x14")]
		public \u0303\u0302\u0301\u0302\u0303\u0305\u0301\u0303\u0302\u0301\u0305\u0306\u0307\u0308\u0306 Permissions;
	}
}
