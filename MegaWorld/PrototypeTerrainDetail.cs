using System;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	[Serializable]
	public class PrototypeTerrainDetail : Prototype
	{
		// Token: 0x06010444 RID: 66628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010444")]
		[Address(RVA = "0x375F810", Offset = "0x375EC10", VA = "0x18375F810")]
		public PrototypeTerrainDetail(GameObject \u0306\u0305\u0301\u0304\u0301\u0307\u0307\u0304\u0304\u0305\u0304\u0308\u0308\u0302\u0307)
		{
		}

		// Token: 0x06010445 RID: 66629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010445")]
		[Address(RVA = "0x375F740", Offset = "0x375EB40", VA = "0x18375F740")]
		public PrototypeTerrainDetail()
		{
		}

		// Token: 0x06010446 RID: 66630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010446")]
		[Address(RVA = "0x375F950", Offset = "0x375ED50", VA = "0x18375F950")]
		public PrototypeTerrainDetail(Texture2D \u0302\u0303\u0305\u0307\u0307\u0302\u0307\u0306\u0302\u0302\u0301\u0307\u0305\u0302\u0304, string \u0303\u0303\u0306\u0302\u0306\u0305\u0307\u0301\u0303\u0304\u0304\u0303\u0303\u0306\u0308)
		{
		}

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x20")]
		public string terrainDetailName;

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x28")]
		public int terrainProtoId;

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		[FieldOffset(Offset = "0x30")]
		public FailureSettings failureSettings;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0x38")]
		public TerrainDetailSettings terrainDetailSettings;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x40")]
		public SpawnDetailSettings spawnDetailSettings;

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x48")]
		public \u0301\u0308\u0303\u0304\u0302\u0302\u0301\u0308\u0305\u0307\u0303\u0303\u0303\u0301\u0308 prefabType;

		// Token: 0x04002C18 RID: 11288
		[Token(Token = "0x4002C18")]
		[FieldOffset(Offset = "0x50")]
		public Texture2D detailTexture;
	}
}
