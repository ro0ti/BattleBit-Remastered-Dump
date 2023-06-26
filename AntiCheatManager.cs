using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using touching_your_mom;
using Steamworks;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public static class AntiCheatManager
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002650 File Offset: 0x00000850
	// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700000A")]
	public static \u0306\u0306\u0307\u0306\u0303\u0302\u0304\u0307\u0303\u0307\u0305\u0308\u0304\u0304\u0304 \u0307\u0304\u0302\u0302\u0303\u0305\u0308\u0307\u0301\u0305\u0305\u0303\u0301\u0302\u0305
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1F0BDA0", Offset = "0x1F0B1A0", VA = "0x181F0BDA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return \u0306\u0306\u0307\u0306\u0303\u0302\u0304\u0307\u0303\u0307\u0305\u0308\u0304\u0304\u0304.NoAntiCheat;
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1F0B710", Offset = "0x1F0AB10", VA = "0x181F0B710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002668 File Offset: 0x00000868
	// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700000B")]
	public static \u0306\u0306\u0307\u0306\u0303\u0302\u0304\u0307\u0303\u0307\u0305\u0308\u0304\u0304\u0304 \u0305\u0301\u0303\u0307\u0308\u0301\u0303\u0305\u0303\u0303\u0301\u0303\u0302\u0308\u0308
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1F0CBE0", Offset = "0x1F0BFE0", VA = "0x181F0CBE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return \u0306\u0306\u0307\u0306\u0303\u0302\u0304\u0307\u0303\u0307\u0305\u0308\u0304\u0304\u0304.NoAntiCheat;
		}
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1F09700", Offset = "0x1F08B00", VA = "0x181F09700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000BA RID: 186 RVA: 0x00002680 File Offset: 0x00000880
	// (set) Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700000C")]
	public static bool \u0308\u0301\u0301\u0303\u0306\u0301\u0303\u0302\u0305\u0305\u0303\u0303\u0305\u0301\u0303
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1F0B430", Offset = "0x1F0A830", VA = "0x181F0B430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1F0B770", Offset = "0x1F0AB70", VA = "0x181F0B770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00002698 File Offset: 0x00000898
	[Token(Token = "0x1700000D")]
	public static bool \u0306\u0307\u0301\u0308\u0304\u0301\u0305\u0304\u0306\u0306\u0301\u0302\u0304\u0302\u0306
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1F09F60", Offset = "0x1F09360", VA = "0x181F09F60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000BD RID: 189 RVA: 0x000026B0 File Offset: 0x000008B0
	[Token(Token = "0x1700000E")]
	public static bool \u0303\u0307\u0304\u0302\u0307\u0302\u0306\u0306\u0305\u0304\u0306\u0304\u0301\u0304\u0303
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1F0CC40", Offset = "0x1F0C040", VA = "0x181F0CC40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000BE RID: 190 RVA: 0x000026C8 File Offset: 0x000008C8
	[Token(Token = "0x1700000F")]
	public static bool \u0303\u0307\u0305\u0302\u0303\u0304\u0302\u0307\u0307\u0302\u0307\u0304\u0301\u0302\u0301
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1F0DFB0", Offset = "0x1F0D3B0", VA = "0x181F0DFB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000BF RID: 191 RVA: 0x000026E0 File Offset: 0x000008E0
	// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000010")]
	public static bool \u0301\u0303\u0301\u0305\u0305\u0301\u0307\u0305\u0307\u0302\u0304\u0305\u0302\u0304\u0306
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1F0DEA0", Offset = "0x1F0D2A0", VA = "0x181F0DEA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1F09E20", Offset = "0x1F09220", VA = "0x181F09E20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x000026F8 File Offset: 0x000008F8
	[Token(Token = "0x17000011")]
	public static float \u0301\u0308\u0306\u0302\u0301\u0305\u0301\u0302\u0306\u0307\u0305\u0306\u0301\u0304\u0306
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1F0B7D0", Offset = "0x1F0ABD0", VA = "0x181F0B7D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000012")]
	public static \u0307\u0302\u0308\u0303\u0307\u0305\u0306\u0307\u0303\u0301\u0305\u0304\u0301\u0303\u0306 \u0307\u0307\u0303\u0304\u0306\u0303\u0307\u0304\u0301\u0302\u0305\u0304\u0305\u0304\u0305
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1F09A00", Offset = "0x1F08E00", VA = "0x181F09A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1F09E80", Offset = "0x1F09280", VA = "0x181F09E80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1F08B90", Offset = "0x1F07F90", VA = "0x181F08B90")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x146E90", Offset = "0x146290")]
	private static void OnLoad()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1F09AC0", Offset = "0x1F08EC0", VA = "0x181F09AC0")]
	public static void \u0302\u0303\u0301\u0305\u0301\u0304\u0302\u0308\u0302\u0301\u0307\u0301\u0305\u0308\u0303()
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1F0DD00", Offset = "0x1F0D100", VA = "0x181F0DD00")]
	public static void \u0307\u0307\u0304\u0302\u0301\u0303\u0304\u0308\u0307\u0304\u0302\u0306\u0302\u0308\u0301(ulong \u0306\u0308\u0301\u0306\u0305\u0304\u0305\u0302\u0304\u0302\u0302\u0307\u0307\u0303\u0308, \u0304\u0308\u0305\u0307\u0304\u0302\u0306\u0306\u0307\u0304\u0303\u0303\u0304\u0308\u0301 \u0306\u0303\u0301\u0305\u0304\u0308\u0302\u0301\u0301\u0307\u0304\u0308\u0304\u0301\u0302)
	{
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1F09C80", Offset = "0x1F09080", VA = "0x181F09C80")]
	public static void \u0302\u0305\u0306\u0308\u0308\u0301\u0304\u0306\u0301\u0307\u0304\u0305\u0308\u0307\u0308(byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308)
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1F0E280", Offset = "0x1F0D680", VA = "0x181F0E280")]
	public static void \u0308\u0306\u0302\u0307\u0306\u0306\u0308\u0302\u0303\u0303\u0302\u0304\u0303\u0306\u0308()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1F0BB20", Offset = "0x1F0AF20", VA = "0x181F0BB20")]
	public static void \u0304\u0301\u0308\u0303\u0303\u0305\u0306\u0301\u0306\u0308\u0301\u0303\u0303\u0306\u0305(Action<ulong, byte[]> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302)
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1F0B490", Offset = "0x1F0A890", VA = "0x181F0B490")]
	public static void \u0303\u0305\u0307\u0304\u0306\u0304\u0304\u0303\u0302\u0303\u0304\u0305\u0305\u0306\u0305(Action<ulong, byte[]> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302)
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1F0D760", Offset = "0x1F0CB60", VA = "0x181F0D760")]
	public static void \u0306\u0308\u0305\u0307\u0305\u0302\u0305\u0303\u0308\u0302\u0307\u0302\u0302\u0302\u0307(ArraySegment<byte> \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308)
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1F09330", Offset = "0x1F08730", VA = "0x181F09330")]
	public static void \u0301\u0302\u0308\u0305\u0303\u0304\u0301\u0307\u0304\u0306\u0308\u0308\u0308\u0305\u0308()
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1F09760", Offset = "0x1F08B60", VA = "0x181F09760")]
	public static void \u0301\u0306\u0306\u0301\u0307\u0303\u0305\u0307\u0305\u0302\u0308\u0301\u0307\u0305\u0305()
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1F0D1E0", Offset = "0x1F0C5E0", VA = "0x181F0D1E0")]
	public static void \u0306\u0303\u0305\u0306\u0304\u0305\u0302\u0308\u0304\u0307\u0301\u0301\u0304\u0302\u0307(ulong \u0306\u0308\u0301\u0306\u0305\u0304\u0305\u0302\u0304\u0302\u0302\u0307\u0307\u0303\u0308, IPAddress \u0301\u0302\u0302\u0302\u0306\u0305\u0303\u0305\u0306\u0308\u0308\u0306\u0307\u0302\u0304, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308)
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1F0D4E0", Offset = "0x1F0C8E0", VA = "0x181F0D4E0")]
	public static void \u0306\u0307\u0302\u0303\u0302\u0308\u0302\u0303\u0308\u0306\u0305\u0301\u0305\u0307\u0305(ulong \u0306\u0308\u0301\u0306\u0305\u0304\u0305\u0302\u0304\u0302\u0302\u0307\u0307\u0303\u0308)
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1F0A000", Offset = "0x1F09400", VA = "0x181F0A000")]
	public static void \u0303\u0303\u0306\u0301\u0305\u0301\u0308\u0303\u0302\u0301\u0303\u0306\u0305\u0302\u0301(ulong \u0306\u0308\u0301\u0306\u0305\u0304\u0305\u0302\u0304\u0302\u0302\u0307\u0307\u0303\u0308, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308)
	{
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1F0CD30", Offset = "0x1F0C130", VA = "0x181F0CD30")]
	public static void \u0305\u0308\u0307\u0308\u0305\u0301\u0307\u0304\u0303\u0302\u0305\u0301\u0308\u0301\u0308()
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1F0B870", Offset = "0x1F0AC70", VA = "0x181F0B870")]
	public static void \u0303\u0308\u0307\u0308\u0302\u0305\u0307\u0301\u0305\u0301\u0306\u0304\u0306\u0303\u0308(ulong \u0306\u0308\u0301\u0306\u0305\u0304\u0305\u0302\u0304\u0302\u0302\u0307\u0307\u0303\u0308, ArraySegment<byte> \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308)
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1F0DA60", Offset = "0x1F0CE60", VA = "0x181F0DA60")]
	public static void \u0307\u0305\u0303\u0301\u0305\u0302\u0306\u0302\u0301\u0308\u0304\u0308\u0305\u0303\u0302(ulong \u0306\u0308\u0301\u0306\u0305\u0304\u0305\u0302\u0304\u0302\u0302\u0307\u0307\u0303\u0308, \u0305\u0303\u0301\u0306\u0301\u0301\u0304\u0308\u0304\u0308\u0303\u0307\u0307\u0302\u0307 \u0304\u0301\u0307\u0304\u0301\u0307\u0305\u0305\u0307\u0308\u0306\u0307\u0303\u0305\u0301)
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1F0A1B0", Offset = "0x1F095B0", VA = "0x181F0A1B0")]
	private static void \u0303\u0304\u0303\u0301\u0306\u0306\u0305\u0303\u0308\u0303\u0304\u0302\u0301\u0303\u0304()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1F0BE00", Offset = "0x1F0B200", VA = "0x181F0BE00")]
	public static void \u0304\u0305\u0305\u0303\u0302\u0302\u0302\u0304\u0301\u0307\u0307\u0305\u0301\u0301\u0301(float \u0301\u0303\u0302\u0308\u0307\u0303\u0304\u0301\u0303\u0304\u0306\u0306\u0304\u0304\u0304)
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1F0D140", Offset = "0x1F0C540", VA = "0x181F0D140")]
	private static void \u0306\u0302\u0302\u0303\u0305\u0307\u0301\u0301\u0304\u0307\u0303\u0308\u0304\u0303\u0302()
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1F09960", Offset = "0x1F08D60", VA = "0x181F09960")]
	private static void \u0302\u0301\u0302\u0301\u0302\u0308\u0308\u0308\u0308\u0304\u0302\u0301\u0303\u0302\u0306()
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1F09530", Offset = "0x1F08930", VA = "0x181F09530")]
	public static void \u0301\u0304\u0305\u0303\u0307\u0305\u0301\u0303\u0302\u0307\u0307\u0308\u0306\u0306\u0307(string \u0305\u0303\u0303\u0306\u0303\u0306\u0307\u0308\u0306\u0304\u0301\u0305\u0303\u0303\u0308)
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002714 File Offset: 0x00000914
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1F0DF00", Offset = "0x1F0D300", VA = "0x181F0DF00")]
	public static bool \u0308\u0302\u0303\u0306\u0306\u0303\u0301\u0302\u0304\u0305\u0302\u0302\u0308\u0303\u0301(\u0306\u0306\u0307\u0306\u0303\u0302\u0304\u0307\u0303\u0307\u0305\u0308\u0304\u0304\u0304 \u0308\u0306\u0301\u0304\u0308\u0308\u0301\u0308\u0308\u0308\u0303\u0305\u0308\u0306\u0303)
	{
		return default(bool);
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1F0E060", Offset = "0x1F0D460", VA = "0x181F0E060")]
	public static void \u0308\u0305\u0304\u0306\u0302\u0308\u0305\u0302\u0302\u0304\u0305\u0302\u0303\u0302\u0308()
	{
	}

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private static \u0306\u0306\u0307\u0306\u0303\u0302\u0304\u0307\u0303\u0307\u0305\u0308\u0304\u0304\u0304 <\u0301\u0306\u0302\u0304\u0303\u0301\u0302\u0301\u0302\u0302\u0305\u0308\u0304\u0302\u0306>k__BackingField;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private static \u0306\u0306\u0307\u0306\u0303\u0302\u0304\u0307\u0303\u0307\u0305\u0308\u0304\u0304\u0304 <\u0305\u0303\u0303\u0303\u0305\u0306\u0307\u0308\u0308\u0301\u0302\u0306\u0305\u0305\u0303>k__BackingField;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private static bool <\u0301\u0306\u0306\u0302\u0303\u0308\u0305\u0308\u0306\u0308\u0305\u0308\u0307\u0303\u0302>k__BackingField;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private static bool <\u0304\u0305\u0303\u0301\u0306\u0304\u0306\u0304\u0305\u0303\u0301\u0307\u0302\u0307\u0307>k__BackingField;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private static \u0307\u0302\u0308\u0303\u0307\u0305\u0306\u0307\u0303\u0301\u0305\u0304\u0301\u0303\u0306 <\u0307\u0308\u0307\u0307\u0307\u0308\u0302\u0305\u0306\u0307\u0302\u0302\u0301\u0301\u0307>k__BackingField;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	private static bool \u0308\u0302\u0305\u0307\u0307\u0303\u0304\u0301\u0307\u0306\u0308\u0302\u0302\u0302\u0307;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x1C")]
	private static int \u0301\u0307\u0304\u0303\u0302\u0304\u0302\u0307\u0305\u0302\u0303\u0306\u0307\u0305\u0301;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	private static int \u0305\u0306\u0304\u0304\u0308\u0301\u0308\u0307\u0301\u0301\u0302\u0305\u0304\u0308\u0306;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x28")]
	private static Queue<AntiCheatManager.\u0307\u0307\u0306\u0303\u0301\u0305\u0303\u0307\u0306\u0305\u0308\u0304\u0301\u0303\u0303> \u0304\u0306\u0303\u0304\u0301\u0303\u0306\u0305\u0302\u0307\u0308\u0307\u0301\u0306\u0306;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x30")]
	private static Queue<AntiCheatManager.\u0307\u0307\u0306\u0303\u0301\u0305\u0303\u0307\u0306\u0305\u0308\u0304\u0301\u0303\u0303> \u0303\u0303\u0305\u0301\u0307\u0306\u0306\u0303\u0302\u0303\u0305\u0308\u0302\u0303\u0303;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x163150", Offset = "0x162550")]
	private static List<ValueTuple<Task<byte[]>, Action<ulong, byte[]>>> \u0306\u0307\u0307\u0306\u0308\u0308\u0304\u0306\u0304\u0303\u0306\u0304\u0303\u0308\u0305;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x163210", Offset = "0x162610")]
	private static List<ValueTuple<Task<AuthTicket>, Action<ulong, byte[]>>> \u0303\u0303\u0306\u0305\u0301\u0305\u0305\u0306\u0303\u0302\u0302\u0305\u0308\u0301\u0306;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x48")]
	private static Queue<ArraySegment<byte>> \u0307\u0303\u0305\u0301\u0302\u0301\u0305\u0306\u0303\u0308\u0306\u0304\u0305\u0304\u0305;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x50")]
	private static TextWriter \u0306\u0304\u0307\u0308\u0308\u0305\u0308\u0304\u0302\u0304\u0303\u0308\u0302\u0304\u0303;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x58")]
	private static bool \u0307\u0306\u0306\u0307\u0304\u0305\u0305\u0305\u0303\u0304\u0303\u0302\u0306\u0306\u0308;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x5C")]
	private static float \u0304\u0304\u0301\u0305\u0304\u0304\u0304\u0305\u0303\u0302\u0303\u0308\u0306\u0308\u0301;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x60")]
	private static bool \u0301\u0304\u0303\u0303\u0303\u0305\u0301\u0307\u0308\u0308\u0308\u0305\u0306\u0307\u0307;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x61")]
	private static bool \u0304\u0308\u0306\u0306\u0304\u0302\u0302\u0306\u0305\u0303\u0301\u0306\u0307\u0302\u0304;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x68")]
	private static HashSet<ulong> \u0306\u0302\u0301\u0301\u0304\u0306\u0307\u0303\u0304\u0303\u0301\u0308\u0307\u0301\u0303;

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	private struct \u0307\u0307\u0306\u0303\u0301\u0305\u0303\u0307\u0306\u0305\u0308\u0304\u0301\u0303\u0303
	{
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		public ulong \u0308\u0302\u0306\u0304\u0302\u0304\u0303\u0304\u0305\u0308\u0304\u0304\u0308\u0306\u0308;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x8")]
		public object \u0308\u0307\u0306\u0301\u0304\u0304\u0302\u0308\u0301\u0301\u0301\u0308\u0307\u0307\u0301;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public AntiCheatManager.\u0304\u0306\u0304\u0307\u0304\u0305\u0304\u0301\u0306\u0308\u0307\u0307\u0305\u0302\u0303 \u0301\u0303\u0302\u0304\u0302\u0304\u0301\u0304\u0301\u0306\u0301\u0304\u0308\u0306\u0306;
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private enum \u0304\u0306\u0304\u0307\u0304\u0305\u0304\u0301\u0306\u0308\u0307\u0307\u0305\u0302\u0303
	{
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		Client_ConnectingToServer,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		Client_ReceivedAntiCheatDataFromServer,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		Client_SendAntiCheatDataToServer,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		Client_RequestEncryptedSteamAuth,
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		Client_RequestSteamAuth,
		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		Client_ReportPlayer,
		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		Client_DisconnectingFromServer,
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		Server_BeginSession,
		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		Server_RestartingServer,
		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		Server_ClientConnected,
		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		Server_ReceivedAntiCheatDataFromClient,
		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		Server_SendAntiCheatDataToClient,
		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		Server_KickClient,
		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		Server_ClientDisconnected,
		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		Server_EndSession
	}

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public <>c()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1F10390", Offset = "0x1F0F790", VA = "0x181F10390")]
		internal bool \u0304\u0306\u0304\u0304\u0308\u0307\u0303\u0301\u0308\u0305\u0301\u0307\u0303\u0303\u0302([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x163BD0", Offset = "0x162FD0")] ValueTuple<Task<byte[]>, Action<ulong, byte[]>> item)
		{
			return default(bool);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1F10600", Offset = "0x1F0FA00", VA = "0x181F10600")]
		internal bool \u0308\u0304\u0302\u0304\u0303\u0304\u0306\u0302\u0303\u0303\u0303\u0302\u0303\u0304\u0308([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x163CC0", Offset = "0x1630C0")] ValueTuple<Task<AuthTicket>, Action<ulong, byte[]>> item)
		{
			return default(bool);
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AntiCheatManager.<>c <>9;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x163910", Offset = "0x162D10")]
		public static Predicate<ValueTuple<Task<byte[]>, Action<ulong, byte[]>>> <>9__59_0;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x163A00", Offset = "0x162E00")]
		public static Predicate<ValueTuple<Task<AuthTicket>, Action<ulong, byte[]>>> <>9__59_1;
	}
}
