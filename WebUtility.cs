using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using BestHTTP;
using touching_your_mom;
using UnityEngine;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public static class WebUtility
{
	// Token: 0x060013BB RID: 5051 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x308D0C0", Offset = "0x308C4C0", VA = "0x18308D0C0")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x146E90", Offset = "0x146290")]
	private static void CreateInstance()
	{
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x00008A2C File Offset: 0x00006C2C
	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760")]
	private static bool \u0301\u0307\u0305\u0304\u0302\u0303\u0308\u0304\u0303\u0306\u0305\u0303\u0307\u0308\u0301(HTTPRequest \u0305\u0301\u0301\u0302\u0305\u0303\u0302\u0303\u0306\u0306\u0306\u0302\u0305\u0305\u0303, X509Certificate \u0306\u0305\u0301\u0307\u0308\u0306\u0307\u0308\u0302\u0304\u0306\u0306\u0302\u0305\u0304, X509Chain \u0308\u0305\u0301\u0302\u0308\u0308\u0308\u0303\u0302\u0305\u0305\u0304\u0308\u0307\u0305, SslPolicyErrors \u0301\u0308\u0308\u0305\u0303\u0304\u0306\u0306\u0306\u0307\u0305\u0302\u0303\u0305\u0302)
	{
		return default(bool);
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x00008A44 File Offset: 0x00006C44
	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760")]
	private static bool \u0304\u0306\u0306\u0304\u0308\u0308\u0304\u0303\u0305\u0301\u0303\u0302\u0301\u0302\u0302(object \u0303\u0307\u0301\u0303\u0308\u0301\u0306\u0301\u0308\u0302\u0308\u0305\u0307\u0303\u0306, X509Certificate \u0306\u0304\u0301\u0306\u0304\u0302\u0302\u0305\u0303\u0305\u0302\u0307\u0305\u0306\u0304, X509Chain \u0301\u0302\u0304\u0308\u0305\u0307\u0301\u0305\u0307\u0304\u0305\u0306\u0301\u0304\u0308, SslPolicyErrors \u0305\u0302\u0302\u0306\u0307\u0308\u0303\u0301\u0304\u0306\u0302\u0304\u0303\u0304\u0304)
	{
		return default(bool);
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x308DAD0", Offset = "0x308CED0", VA = "0x18308DAD0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x178F50", Offset = "0x178350")]
	public static Task<WebRequestResponse> \u0303\u0303\u0307\u0308\u0305\u0307\u0302\u0301\u0302\u0305\u0303\u0307\u0301\u0306\u0302(string \u0306\u0301\u0303\u0301\u0303\u0307\u0304\u0302\u0303\u0305\u0307\u0301\u0302\u0306\u0304, ulong \u0306\u0308\u0301\u0306\u0305\u0304\u0305\u0302\u0304\u0302\u0302\u0307\u0307\u0303\u0308, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x308DBF0", Offset = "0x308CFF0", VA = "0x18308DBF0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x178FD0", Offset = "0x1783D0")]
	public static Task<WebRequestResponse> \u0303\u0308\u0308\u0305\u0306\u0304\u0303\u0305\u0304\u0305\u0301\u0302\u0307\u0301\u0302(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308, int \u0305\u0308\u0301\u0307\u0306\u0303\u0301\u0308\u0307\u0307\u0303\u0303\u0301\u0308\u0307, int \u0305\u0301\u0308\u0306\u0305\u0305\u0304\u0302\u0303\u0305\u0306\u0308\u0303\u0305\u0304, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x308E1F0", Offset = "0x308D5F0", VA = "0x18308E1F0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179090", Offset = "0x178490")]
	public static Task<WebRequestResponse> \u0304\u0306\u0304\u0303\u0301\u0301\u0304\u0304\u0304\u0307\u0308\u0306\u0303\u0302\u0305(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x308E540", Offset = "0x308D940", VA = "0x18308E540")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179130", Offset = "0x178530")]
	public static Task<WebRequestResponse> \u0306\u0305\u0303\u0302\u0303\u0305\u0301\u0303\u0303\u0301\u0306\u0303\u0305\u0307\u0307(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x308DE80", Offset = "0x308D280", VA = "0x18308DE80")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179350", Offset = "0x178750")]
	public static Task<Texture2D> \u0304\u0301\u0306\u0304\u0308\u0304\u0308\u0308\u0308\u0304\u0301\u0301\u0307\u0306\u0302(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x308DD40", Offset = "0x308D140", VA = "0x18308DD40")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179410", Offset = "0x178810")]
	public static Task<WebRequestResponse> \u0303\u0308\u0308\u0305\u0306\u0304\u0303\u0305\u0304\u0305\u0301\u0302\u0307\u0301\u0302(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308, int \u0305\u0308\u0301\u0307\u0306\u0303\u0301\u0308\u0307\u0307\u0303\u0303\u0301\u0308\u0307, int \u0305\u0301\u0308\u0306\u0305\u0305\u0304\u0302\u0303\u0305\u0306\u0308\u0303\u0305\u0304, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x308E0E0", Offset = "0x308D4E0", VA = "0x18308E0E0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179460", Offset = "0x178860")]
	public static Task<WebRequestResponse> \u0304\u0306\u0304\u0303\u0301\u0301\u0304\u0304\u0304\u0307\u0308\u0306\u0303\u0302\u0305(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x308E670", Offset = "0x308DA70", VA = "0x18308E670")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x1795C0", Offset = "0x1789C0")]
	public static Task<WebRequestResponse> \u0306\u0305\u0303\u0302\u0303\u0305\u0301\u0303\u0303\u0301\u0306\u0303\u0305\u0307\u0307(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
		return null;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x308D6E0", Offset = "0x308CAE0", VA = "0x18308D6E0")]
	public static void \u0301\u0306\u0304\u0304\u0306\u0302\u0304\u0308\u0306\u0306\u0305\u0304\u0307\u0305\u0304(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308, int \u0305\u0308\u0301\u0307\u0306\u0303\u0301\u0308\u0307\u0307\u0303\u0303\u0301\u0308\u0307, int \u0305\u0301\u0308\u0306\u0305\u0305\u0304\u0302\u0303\u0305\u0306\u0308\u0303\u0305\u0304, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x308D640", Offset = "0x308CA40", VA = "0x18308D640")]
	public static void \u0301\u0306\u0304\u0304\u0306\u0302\u0304\u0308\u0306\u0306\u0305\u0304\u0307\u0305\u0304(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308, int \u0305\u0308\u0301\u0307\u0306\u0303\u0301\u0308\u0307\u0307\u0303\u0303\u0301\u0308\u0307, int \u0305\u0301\u0308\u0306\u0305\u0305\u0304\u0302\u0303\u0305\u0306\u0308\u0303\u0305\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x308E780", Offset = "0x308DB80", VA = "0x18308E780")]
	public static void \u0307\u0301\u0307\u0302\u0306\u0307\u0302\u0304\u0302\u0308\u0301\u0307\u0305\u0301\u0307(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x308E810", Offset = "0x308DC10", VA = "0x18308E810")]
	public static void \u0307\u0301\u0307\u0302\u0306\u0307\u0302\u0304\u0302\u0308\u0301\u0307\u0305\u0301\u0307(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x308F330", Offset = "0x308E730", VA = "0x18308F330")]
	public static void \u0308\u0307\u0307\u0307\u0306\u0308\u0301\u0305\u0304\u0304\u0302\u0305\u0301\u0306\u0305(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x308F2B0", Offset = "0x308E6B0", VA = "0x18308F2B0")]
	public static void \u0308\u0307\u0307\u0307\u0306\u0308\u0301\u0305\u0304\u0304\u0302\u0305\u0301\u0306\u0305(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x308D770", Offset = "0x308CB70", VA = "0x18308D770")]
	public static void \u0302\u0307\u0304\u0302\u0307\u0303\u0306\u0306\u0302\u0307\u0303\u0305\u0307\u0304\u0304(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308, int \u0305\u0308\u0301\u0307\u0306\u0303\u0301\u0308\u0307\u0307\u0303\u0303\u0301\u0308\u0307, int \u0305\u0301\u0308\u0306\u0305\u0305\u0304\u0302\u0303\u0305\u0306\u0308\u0303\u0305\u0304, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x308D920", Offset = "0x308CD20", VA = "0x18308D920")]
	public static void \u0302\u0307\u0304\u0302\u0307\u0303\u0306\u0306\u0302\u0307\u0303\u0305\u0307\u0304\u0304(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308, int \u0305\u0308\u0301\u0307\u0306\u0303\u0301\u0308\u0307\u0307\u0303\u0303\u0301\u0308\u0307, int \u0305\u0301\u0308\u0306\u0305\u0305\u0304\u0302\u0303\u0305\u0306\u0308\u0303\u0305\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x308D330", Offset = "0x308C730", VA = "0x18308D330")]
	public static void \u0301\u0301\u0306\u0307\u0303\u0303\u0305\u0306\u0307\u0308\u0307\u0305\u0303\u0305\u0304(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x308D4C0", Offset = "0x308C8C0", VA = "0x18308D4C0")]
	public static void \u0301\u0301\u0306\u0307\u0303\u0303\u0305\u0306\u0307\u0308\u0307\u0305\u0303\u0305\u0304(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x308EFA0", Offset = "0x308E3A0", VA = "0x18308EFA0")]
	public static void \u0308\u0307\u0301\u0308\u0305\u0301\u0308\u0308\u0303\u0301\u0304\u0305\u0303\u0305\u0303(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x308F130", Offset = "0x308E530", VA = "0x18308F130")]
	public static void \u0308\u0307\u0301\u0308\u0305\u0301\u0308\u0308\u0303\u0301\u0304\u0305\u0303\u0305\u0303(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x308E890", Offset = "0x308DC90", VA = "0x18308E890")]
	public static void \u0307\u0302\u0302\u0305\u0301\u0302\u0303\u0304\u0307\u0303\u0304\u0305\u0307\u0306\u0306(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Action<Texture2D> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301 = 8000)
	{
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x308D1E0", Offset = "0x308C5E0", VA = "0x18308D1E0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179630", Offset = "0x178A30")]
	private static Task \u0301\u0301\u0305\u0302\u0303\u0308\u0306\u0305\u0303\u0305\u0307\u0308\u0305\u0302\u0307(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, byte[] \u0302\u0302\u0303\u0308\u0305\u0302\u0301\u0301\u0307\u0307\u0308\u0305\u0305\u0304\u0308, int \u0305\u0308\u0301\u0307\u0306\u0303\u0301\u0308\u0307\u0307\u0303\u0303\u0301\u0308\u0307, int \u0305\u0301\u0308\u0306\u0305\u0305\u0304\u0302\u0303\u0305\u0306\u0308\u0303\u0305\u0304, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301)
	{
		return null;
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x308DFA0", Offset = "0x308D3A0", VA = "0x18308DFA0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179780", Offset = "0x178B80")]
	private static Task \u0304\u0303\u0304\u0306\u0301\u0303\u0304\u0307\u0307\u0303\u0302\u0308\u0301\u0302\u0301(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301)
	{
		return null;
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x308ED70", Offset = "0x308E170", VA = "0x18308ED70")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x179880", Offset = "0x178C80")]
	private static Task \u0307\u0303\u0306\u0303\u0308\u0307\u0301\u0305\u0303\u0306\u0307\u0305\u0302\u0302\u0302(string \u0303\u0307\u0307\u0306\u0308\u0303\u0307\u0302\u0303\u0301\u0308\u0305\u0305\u0305\u0307, Dictionary<string, string> \u0308\u0308\u0306\u0307\u0302\u0303\u0305\u0304\u0301\u0304\u0302\u0307\u0308\u0302\u0304, Action<WebRequestResponse> \u0307\u0308\u0302\u0304\u0302\u0305\u0304\u0304\u0306\u0301\u0308\u0308\u0307\u0308\u0302, int \u0307\u0305\u0305\u0304\u0306\u0308\u0304\u0303\u0304\u0307\u0301\u0307\u0306\u0304\u0301)
	{
		return null;
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x308EB00", Offset = "0x308DF00", VA = "0x18308EB00")]
	private static void \u0307\u0302\u0303\u0305\u0306\u0303\u0301\u0305\u0302\u0305\u0301\u0304\u0304\u0302\u0304()
	{
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x00008A5C File Offset: 0x00006C5C
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x308E420", Offset = "0x308D820", VA = "0x18308E420")]
	private static bool \u0306\u0302\u0307\u0306\u0306\u0306\u0307\u0307\u0302\u0307\u0308\u0306\u0306\u0304\u0304(WebUtility.mOutgoingRequest \u0308\u0305\u0305\u0305\u0307\u0302\u0301\u0308\u0307\u0305\u0302\u0307\u0303\u0304\u0306)
	{
		return default(bool);
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x00008A74 File Offset: 0x00006C74
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x308E320", Offset = "0x308D720", VA = "0x18308E320")]
	private static bool \u0305\u0303\u0308\u0305\u0306\u0302\u0301\u0302\u0306\u0302\u0308\u0303\u0301\u0305\u0304(WebUtility.mOutgoingTextureRequest \u0308\u0305\u0305\u0305\u0307\u0302\u0301\u0308\u0307\u0305\u0302\u0307\u0303\u0304\u0306)
	{
		return default(bool);
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x308EEB0", Offset = "0x308E2B0", VA = "0x18308EEB0")]
	public static Uri \u0307\u0307\u0305\u0301\u0306\u0305\u0305\u0305\u0306\u0306\u0301\u0304\u0307\u0308\u0307(Uri \u0301\u0301\u0307\u0307\u0308\u0306\u0302\u0305\u0304\u0306\u0307\u0304\u0306\u0307\u0306)
	{
		return null;
	}

	// Token: 0x04000274 RID: 628
	[Token(Token = "0x4000274")]
	public const int \u0301\u0304\u0304\u0306\u0305\u0307\u0301\u0302\u0306\u0302\u0302\u0301\u0304\u0302\u0306 = 8000;

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x4000275")]
	public const string \u0302\u0308\u0302\u0308\u0302\u0303\u0303\u0304\u0308\u0301\u0302\u0302\u0301\u0304\u0303 = "User-Agent";

	// Token: 0x04000276 RID: 630
	[Token(Token = "0x4000276")]
	public const string \u0301\u0306\u0307\u0307\u0303\u0306\u0307\u0302\u0302\u0302\u0304\u0301\u0303\u0301\u0306 = "b32bf642b285ca1f0663688e7078f892dc2d0843";

	// Token: 0x04000277 RID: 631
	[Token(Token = "0x4000277")]
	[touching_your_mom.FieldOffset(Offset = "0x0")]
	private static List<WebUtility.mOutgoingRequest> \u0304\u0308\u0301\u0306\u0303\u0304\u0304\u0304\u0301\u0302\u0304\u0307\u0301\u0307\u0303;

	// Token: 0x04000278 RID: 632
	[Token(Token = "0x4000278")]
	[touching_your_mom.FieldOffset(Offset = "0x8")]
	private static List<WebUtility.mOutgoingTextureRequest> \u0302\u0302\u0303\u0303\u0308\u0303\u0303\u0304\u0308\u0307\u0304\u0306\u0308\u0308\u0307;

	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	private class WebUtilityBehaviour : MonoBehaviour
	{
		// Token: 0x060013DB RID: 5083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x28CAD00", Offset = "0x28CA100", VA = "0x1828CAD00")]
		private void \u0304\u0303\u0308\u0304\u0301\u0307\u0306\u0303\u0308\u0307\u0301\u0303\u0305\u0304\u0303()
		{
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x28CAFD0", Offset = "0x28CA3D0", VA = "0x1828CAFD0")]
		private void \u0306\u0307\u0301\u0306\u0306\u0307\u0304\u0304\u0305\u0303\u0304\u0303\u0304\u0307\u0306()
		{
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x28CB2F0", Offset = "0x28CA6F0", VA = "0x1828CB2F0")]
		private void \u0308\u0302\u0303\u0307\u0305\u0302\u0304\u0306\u0307\u0301\u0301\u0303\u0302\u0301\u0304()
		{
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x28CAD50", Offset = "0x28CA150", VA = "0x1828CAD50")]
		private void \u0305\u0306\u0306\u0304\u0303\u0306\u0308\u0302\u0303\u0304\u0301\u0305\u0307\u0308\u0308()
		{
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x28CB110", Offset = "0x28CA510", VA = "0x1828CB110")]
		private void \u0307\u0303\u0305\u0305\u0308\u0306\u0307\u0305\u0305\u0302\u0307\u0305\u0306\u0301\u0306()
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x28CADF0", Offset = "0x28CA1F0", VA = "0x1828CADF0")]
		private void \u0305\u0308\u0307\u0304\u0303\u0307\u0306\u0305\u0301\u0302\u0307\u0305\u0302\u0305\u0305()
		{
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x28CAA30", Offset = "0x28C9E30", VA = "0x1828CAA30")]
		private void \u0302\u0303\u0301\u0301\u0303\u0304\u0308\u0305\u0307\u0308\u0306\u0307\u0305\u0301\u0301()
		{
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x28CB200", Offset = "0x28CA600", VA = "0x1828CB200")]
		private void \u0307\u0304\u0306\u0302\u0302\u0307\u0303\u0305\u0306\u0305\u0301\u0302\u0304\u0302\u0302()
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x28CB3E0", Offset = "0x28CA7E0", VA = "0x1828CB3E0")]
		private void Update()
		{
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x28CB0C0", Offset = "0x28CA4C0", VA = "0x1828CB0C0")]
		private void \u0306\u0308\u0305\u0306\u0302\u0301\u0307\u0306\u0304\u0307\u0308\u0302\u0306\u0301\u0301()
		{
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x28CACB0", Offset = "0x28CA0B0", VA = "0x1828CACB0")]
		private void \u0303\u0305\u0304\u0308\u0301\u0308\u0308\u0304\u0301\u0304\u0307\u0308\u0308\u0302\u0303()
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x28CAE90", Offset = "0x28CA290", VA = "0x1828CAE90")]
		private void \u0306\u0304\u0306\u0305\u0307\u0308\u0307\u0304\u0308\u0306\u0305\u0301\u0307\u0305\u0304()
		{
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x28CA9E0", Offset = "0x28C9DE0", VA = "0x1828CA9E0")]
		private void \u0301\u0307\u0307\u0302\u0301\u0303\u0305\u0305\u0303\u0301\u0304\u0304\u0301\u0305\u0304()
		{
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x28CAB20", Offset = "0x28C9F20", VA = "0x1828CAB20")]
		private void \u0302\u0307\u0308\u0307\u0301\u0304\u0304\u0305\u0306\u0304\u0304\u0305\u0305\u0305\u0304()
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x28CAF80", Offset = "0x28CA380", VA = "0x1828CAF80")]
		private void \u0306\u0306\u0302\u0308\u0308\u0303\u0301\u0307\u0302\u0306\u0307\u0305\u0303\u0306\u0304()
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x28CAC60", Offset = "0x28CA060", VA = "0x1828CAC60")]
		private void \u0303\u0302\u0304\u0303\u0308\u0302\u0301\u0307\u0303\u0303\u0305\u0307\u0302\u0301\u0301()
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x28CADA0", Offset = "0x28CA1A0", VA = "0x1828CADA0")]
		private void \u0305\u0307\u0307\u0301\u0308\u0304\u0302\u0304\u0303\u0302\u0303\u0304\u0301\u0303\u0301()
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public WebUtilityBehaviour()
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x28CB390", Offset = "0x28CA790", VA = "0x1828CB390")]
		private void \u0308\u0305\u0304\u0305\u0306\u0302\u0306\u0301\u0301\u0304\u0304\u0308\u0305\u0306\u0306()
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x28CA8A0", Offset = "0x28C9CA0", VA = "0x1828CA8A0")]
		private void \u0301\u0302\u0302\u0304\u0304\u0308\u0303\u0308\u0307\u0308\u0303\u0303\u0304\u0301\u0305()
		{
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x28CAEE0", Offset = "0x28CA2E0", VA = "0x1828CAEE0")]
		private void \u0306\u0305\u0301\u0301\u0301\u0301\u0303\u0307\u0305\u0308\u0301\u0307\u0306\u0301\u0304()
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x28CAAD0", Offset = "0x28C9ED0", VA = "0x1828CAAD0")]
		private void \u0302\u0307\u0303\u0308\u0304\u0306\u0304\u0302\u0307\u0304\u0306\u0307\u0302\u0301\u0305()
		{
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x28CA8F0", Offset = "0x28C9CF0", VA = "0x1828CA8F0")]
		private void \u0301\u0302\u0302\u0306\u0302\u0307\u0308\u0308\u0302\u0304\u0308\u0301\u0305\u0301\u0308()
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x28CAE40", Offset = "0x28CA240", VA = "0x1828CAE40")]
		private void \u0306\u0301\u0308\u0305\u0303\u0306\u0307\u0306\u0307\u0308\u0306\u0302\u0306\u0308\u0301()
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x28CB020", Offset = "0x28CA420", VA = "0x1828CB020")]
		private void \u0306\u0307\u0301\u0307\u0303\u0306\u0307\u0308\u0303\u0304\u0303\u0303\u0304\u0306\u0308()
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x28CB2A0", Offset = "0x28CA6A0", VA = "0x1828CB2A0")]
		private void \u0307\u0307\u0302\u0305\u0308\u0306\u0305\u0303\u0307\u0307\u0305\u0301\u0306\u0304\u0304()
		{
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x28CB250", Offset = "0x28CA650", VA = "0x1828CB250")]
		private void \u0307\u0306\u0306\u0302\u0307\u0302\u0302\u0307\u0302\u0301\u0304\u0304\u0308\u0302\u0304()
		{
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x28CAB70", Offset = "0x28C9F70", VA = "0x1828CAB70")]
		private void \u0302\u0308\u0303\u0303\u0304\u0306\u0303\u0308\u0303\u0306\u0305\u0303\u0305\u0305\u0301()
		{
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x28CABC0", Offset = "0x28C9FC0", VA = "0x1828CABC0")]
		private void \u0303\u0301\u0307\u0306\u0302\u0302\u0307\u0304\u0306\u0307\u0301\u0307\u0304\u0305\u0304()
		{
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x28CAA80", Offset = "0x28C9E80", VA = "0x1828CAA80")]
		private void \u0302\u0305\u0303\u0303\u0302\u0307\u0308\u0302\u0308\u0301\u0302\u0306\u0307\u0301\u0306()
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x28CA940", Offset = "0x28C9D40", VA = "0x1828CA940")]
		private void \u0301\u0303\u0302\u0308\u0307\u0307\u0305\u0306\u0308\u0307\u0308\u0303\u0303\u0302\u0308()
		{
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x28CA990", Offset = "0x28C9D90", VA = "0x1828CA990")]
		private void \u0301\u0304\u0308\u0304\u0301\u0307\u0305\u0306\u0307\u0301\u0303\u0305\u0302\u0303\u0305()
		{
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x28CB070", Offset = "0x28CA470", VA = "0x1828CB070")]
		private void \u0306\u0307\u0305\u0302\u0304\u0303\u0305\u0307\u0301\u0304\u0308\u0302\u0301\u0304\u0307()
		{
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x28CB340", Offset = "0x28CA740", VA = "0x1828CB340")]
		private void \u0308\u0302\u0303\u0307\u0307\u0301\u0303\u0302\u0307\u0301\u0305\u0303\u0304\u0302\u0302()
		{
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x28CB160", Offset = "0x28CA560", VA = "0x1828CB160")]
		private void \u0307\u0304\u0302\u0305\u0306\u0302\u0306\u0307\u0302\u0304\u0306\u0306\u0302\u0304\u0307()
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x28CAF30", Offset = "0x28CA330", VA = "0x1828CAF30")]
		private void \u0306\u0306\u0302\u0305\u0303\u0306\u0305\u0306\u0301\u0304\u0304\u0302\u0302\u0303\u0307()
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x28CAC10", Offset = "0x28CA010", VA = "0x1828CAC10")]
		private void \u0303\u0301\u0308\u0308\u0306\u0304\u0301\u0305\u0306\u0306\u0303\u0306\u0304\u0308\u0304()
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001400")]
		[Address(RVA = "0x28CB1B0", Offset = "0x28CA5B0", VA = "0x1828CB1B0")]
		private void \u0307\u0304\u0303\u0306\u0303\u0301\u0308\u0308\u0301\u0301\u0304\u0302\u0306\u0303\u0301()
		{
		}
	}

	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	private struct mOutgoingRequest
	{
		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public Task<WebRequestResponse> \u0308\u0301\u0302\u0308\u0308\u0301\u0308\u0307\u0306\u0308\u0308\u0302\u0305\u0304\u0308;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public Action<WebRequestResponse> \u0304\u0302\u0308\u0307\u0304\u0301\u0307\u0305\u0305\u0308\u0302\u0304\u0305\u0304\u0304;
	}

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	private struct mOutgoingTextureRequest
	{
		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public Task<Texture2D> \u0308\u0301\u0302\u0308\u0308\u0301\u0308\u0307\u0306\u0308\u0308\u0302\u0305\u0304\u0308;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public Action<Texture2D> \u0304\u0302\u0308\u0307\u0304\u0301\u0307\u0305\u0305\u0308\u0302\u0304\u0305\u0304\u0304;
	}

	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0304\u0302\u0302\u0303\u0303\u0303\u0304\u0303\u0307\u0304\u0305\u0307\u0303\u0302\u0302 : IAsyncStateMachine
	{
		// Token: 0x06001401 RID: 5121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001401")]
		[Address(RVA = "0x28C8500", Offset = "0x28C7900", VA = "0x1828C8500", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001402")]
		[Address(RVA = "0x28C8D60", Offset = "0x28C8160", VA = "0x1828C8D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<WebRequestResponse> <>t__builder;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string text;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public ulong steamID;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int timeout;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[touching_your_mom.FieldOffset(Offset = "0x34")]
		private HttpStatusCode <code>5__2;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		private string <error>5__3;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private byte[] <content>5__4;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		private bool <isOk>5__5;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		private HTTPRequest <request>5__6;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		private CancellationTokenSource <mToken>5__7;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		private TaskAwaiter<HTTPResponse> <>u__1;
	}

	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0304\u0304\u0308\u0308\u0307\u0308\u0307\u0303\u0307\u0306\u0305\u0301\u0304\u0301\u0307 : IAsyncStateMachine
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x28C8DB0", Offset = "0x28C81B0", VA = "0x1828C8DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x28C94F0", Offset = "0x28C88F0", VA = "0x1828C94F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<WebRequestResponse> <>t__builder;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public byte[] data;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public string url;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int offset;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[touching_your_mom.FieldOffset(Offset = "0x34")]
		public int size;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public Dictionary<string, string> values;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		public int timeout;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[touching_your_mom.FieldOffset(Offset = "0x44")]
		private HttpStatusCode <code>5__2;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		private string <error>5__3;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		private byte[] <content>5__4;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		private bool <isOk>5__5;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		private HTTPRequest <request>5__6;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[touching_your_mom.FieldOffset(Offset = "0x68")]
		private CancellationTokenSource <mToken>5__7;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[touching_your_mom.FieldOffset(Offset = "0x70")]
		private TaskAwaiter<HTTPResponse> <>u__1;
	}

	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0308\u0308\u0308\u0305\u0306\u0306\u0308\u0301\u0307\u0308\u0308\u0305\u0301\u0308\u0304 : IAsyncStateMachine
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x28CA1E0", Offset = "0x28C95E0", VA = "0x1828CA1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x28CA850", Offset = "0x28C9C50", VA = "0x1828CA850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<WebRequestResponse> <>t__builder;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> values;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int timeout;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[touching_your_mom.FieldOffset(Offset = "0x34")]
		private HttpStatusCode <code>5__2;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		private string <error>5__3;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private byte[] <content>5__4;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		private bool <isOk>5__5;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		private HTTPRequest <request>5__6;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		private CancellationTokenSource <mToken>5__7;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		private TaskAwaiter<HTTPResponse> <>u__1;
	}

	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0302\u0305\u0304\u0302\u0303\u0305\u0305\u0306\u0307\u0303\u0301\u0305\u0304\u0305\u0308 : IAsyncStateMachine
	{
		// Token: 0x06001407 RID: 5127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x28C7C30", Offset = "0x28C7030", VA = "0x1828C7C30", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x28C82A0", Offset = "0x28C76A0", VA = "0x1828C82A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<WebRequestResponse> <>t__builder;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> values;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int timeout;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[touching_your_mom.FieldOffset(Offset = "0x34")]
		private HttpStatusCode <code>5__2;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		private string <error>5__3;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private byte[] <content>5__4;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		private bool <isOk>5__5;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		private HTTPRequest <request>5__6;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		private CancellationTokenSource <mToken>5__7;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		private TaskAwaiter<HTTPResponse> <>u__1;
	}

	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0307\u0305\u0303\u0306\u0307\u0304\u0305\u0301\u0306\u0305\u0305\u0307\u0304\u0304\u0308 : IAsyncStateMachine
	{
		// Token: 0x06001409 RID: 5129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x28C9960", Offset = "0x28C8D60", VA = "0x1828C9960", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x28C9D70", Offset = "0x28C9170", VA = "0x1828C9D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public int timeout;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		private Texture2D <result>5__2;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		private HTTPRequest <request>5__3;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private CancellationTokenSource <mToken>5__4;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<HTTPResponse> <>u__1;
	}

	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0308\u0305\u0306\u0303\u0303\u0302\u0307\u0305\u0301\u0306\u0301\u0301\u0304\u0306\u0307 : IAsyncStateMachine
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x28C9FD0", Offset = "0x28C93D0", VA = "0x1828C9FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x28CA190", Offset = "0x28C9590", VA = "0x1828CA190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<WebRequestResponse> <>t__builder;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public byte[] data;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int offset;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[touching_your_mom.FieldOffset(Offset = "0x34")]
		public int size;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public int timeout;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<WebRequestResponse> <>u__1;
	}

	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0307\u0304\u0303\u0306\u0305\u0302\u0302\u0308\u0305\u0307\u0305\u0305\u0307\u0304\u0304 : IAsyncStateMachine
	{
		// Token: 0x0600140D RID: 5133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x28C9780", Offset = "0x28C8B80", VA = "0x1828C9780", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x28C9910", Offset = "0x28C8D10", VA = "0x1828C9910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<WebRequestResponse> <>t__builder;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public int timeout;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<WebRequestResponse> <>u__1;
	}

	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0301\u0302\u0306\u0306\u0303\u0305\u0302\u0301\u0302\u0301\u0302\u0307\u0304\u0306\u0304 : IAsyncStateMachine
	{
		// Token: 0x0600140F RID: 5135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x28C7A50", Offset = "0x28C6E50", VA = "0x1828C7A50", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x28C7BE0", Offset = "0x28C6FE0", VA = "0x1828C7BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<WebRequestResponse> <>t__builder;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public int timeout;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<WebRequestResponse> <>u__1;
	}

	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0305\u0304\u0302\u0304\u0303\u0302\u0304\u0303\u0304\u0306\u0302\u0308\u0305\u0302\u0305 : IAsyncStateMachine
	{
		// Token: 0x06001411 RID: 5137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x28C9540", Offset = "0x28C8940", VA = "0x1828C9540", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001412")]
		[Address(RVA = "0xD239E0", Offset = "0xD22DE0", VA = "0x180D239E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public byte[] data;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int offset;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[touching_your_mom.FieldOffset(Offset = "0x34")]
		public int size;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public Dictionary<string, string> values;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		public int timeout;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		public Action<WebRequestResponse> callback;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<WebRequestResponse> <>u__1;
	}

	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0303\u0301\u0301\u0304\u0301\u0305\u0308\u0307\u0303\u0303\u0302\u0305\u0301\u0307\u0308 : IAsyncStateMachine
	{
		// Token: 0x06001413 RID: 5139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x28C82F0", Offset = "0x28C76F0", VA = "0x1828C82F0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001414")]
		[Address(RVA = "0xD239E0", Offset = "0xD22DE0", VA = "0x180D239E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> values;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int timeout;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public Action<WebRequestResponse> callback;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<WebRequestResponse> <>u__1;
	}

	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	[StructLayout(3)]
	private struct \u0307\u0308\u0305\u0305\u0305\u0302\u0308\u0303\u0302\u0303\u0306\u0302\u0306\u0304\u0301 : IAsyncStateMachine
	{
		// Token: 0x06001415 RID: 5141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x28C9DC0", Offset = "0x28C91C0", VA = "0x1828C9DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001416")]
		[Address(RVA = "0xD239E0", Offset = "0xD22DE0", VA = "0x180D239E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> values;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public int timeout;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public Action<WebRequestResponse> callback;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<WebRequestResponse> <>u__1;
	}
}
