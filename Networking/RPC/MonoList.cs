using System;
using System.Collections.Generic;
using System.Reflection;
using touching_your_mom;
using UnityEngine;

namespace Networking.RPC
{
	// Token: 0x020006C5 RID: 1733
	[Token(Token = "0x20006C5")]
	public class MonoList : TextAsset
	{
		// Token: 0x060128AD RID: 75949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128AD")]
		[Address(RVA = "0x1718300", Offset = "0x1717700", VA = "0x181718300")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x1426C0", Offset = "0x141AC0")]
		private static void LoadInstance()
		{
		}

		// Token: 0x060128AE RID: 75950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128AE")]
		[Address(RVA = "0x1718080", Offset = "0x1717480", VA = "0x181718080")]
		private void Init(byte[] data)
		{
		}

		// Token: 0x060128AF RID: 75951 RVA: 0x00073ED4 File Offset: 0x000720D4
		[Token(Token = "0x60128AF")]
		[Address(RVA = "0x17184E0", Offset = "0x17178E0", VA = "0x1817184E0")]
		public static bool TryGetMarkedFunctions(Type t, out MonoItem[] items)
		{
			return default(bool);
		}

		// Token: 0x060128B0 RID: 75952 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128B0")]
		[Address(RVA = "0x1717F20", Offset = "0x1717320", VA = "0x181717F20")]
		public static MonoItem[] GetMarkedFunctions(Type t)
		{
			return null;
		}

		// Token: 0x060128B1 RID: 75953 RVA: 0x00073EEC File Offset: 0x000720EC
		[Token(Token = "0x60128B1")]
		[Address(RVA = "0x1717EA0", Offset = "0x17172A0", VA = "0x181717EA0")]
		public static ushort GetIDFromType(Type Type)
		{
			return 0;
		}

		// Token: 0x060128B2 RID: 75954 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128B2")]
		[Address(RVA = "0x1718000", Offset = "0x1717400", VA = "0x181718000")]
		public static Type GetTypeFromID(ushort ID)
		{
			return null;
		}

		// Token: 0x060128B3 RID: 75955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128B3")]
		[Address(RVA = "0x1718570", Offset = "0x1717970", VA = "0x181718570")]
		public MonoList()
		{
		}

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		public const BindingFlags Flags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x0400331C RID: 13084
		[Token(Token = "0x400331C")]
		[FieldOffset(Offset = "0x0")]
		private static MonoList Cached;

		// Token: 0x0400331D RID: 13085
		[Token(Token = "0x400331D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, MonoItem[]> AttributeByList;

		// Token: 0x0400331E RID: 13086
		[Token(Token = "0x400331E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ushort, Type> idToType;

		// Token: 0x0400331F RID: 13087
		[Token(Token = "0x400331F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Type, ushort> typeToId;
	}
}
