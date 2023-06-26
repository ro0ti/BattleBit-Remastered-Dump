using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	[ExecuteInEditMode]
	[Serializable]
	public class PrototypeInfo
	{
		// Token: 0x060103A5 RID: 66469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60103A5")]
		[Address(RVA = "0x375F6D0", Offset = "0x375EAD0", VA = "0x18375F6D0")]
		public PrototypeInfo()
		{
		}

		// Token: 0x04002C02 RID: 11266
		[Token(Token = "0x4002C02")]
		[FieldOffset(Offset = "0x10")]
		public PrototypeGameObject prototype;

		// Token: 0x04002C03 RID: 11267
		[Token(Token = "0x4002C03")]
		[FieldOffset(Offset = "0x18")]
		public List<ObjectInfo> prefabList;
	}
}
