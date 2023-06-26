using System;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	[Serializable]
	public class PrototypeTerrainTexture : Prototype
	{
		// Token: 0x06010447 RID: 66631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010447")]
		[Address(RVA = "0x375FB70", Offset = "0x375EF70", VA = "0x18375FB70")]
		public PrototypeTerrainTexture(TerrainTextureSettings \u0307\u0307\u0301\u0303\u0301\u0303\u0302\u0302\u0302\u0308\u0303\u0308\u0306\u0303\u0302, TerrainLayer \u0305\u0306\u0302\u0301\u0303\u0302\u0301\u0302\u0306\u0308\u0305\u0305\u0305\u0304\u0307, string \u0303\u0303\u0306\u0302\u0306\u0305\u0307\u0301\u0303\u0304\u0304\u0303\u0303\u0306\u0308)
		{
		}

		// Token: 0x06010448 RID: 66632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010448")]
		[Address(RVA = "0x375FC50", Offset = "0x375F050", VA = "0x18375FC50")]
		public PrototypeTerrainTexture()
		{
		}

		// Token: 0x06010449 RID: 66633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010449")]
		[Address(RVA = "0x375FA80", Offset = "0x375EE80", VA = "0x18375FA80")]
		public PrototypeTerrainTexture(TerrainLayer \u0305\u0306\u0302\u0301\u0303\u0302\u0301\u0302\u0306\u0308\u0305\u0305\u0305\u0304\u0307, string \u0303\u0303\u0306\u0302\u0306\u0305\u0307\u0301\u0303\u0304\u0304\u0303\u0303\u0306\u0308)
		{
		}

		// Token: 0x0601044A RID: 66634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601044A")]
		[Address(RVA = "0x375FCD0", Offset = "0x375F0D0", VA = "0x18375FCD0")]
		public PrototypeTerrainTexture(Texture2D \u0306\u0308\u0304\u0304\u0307\u0301\u0305\u0305\u0301\u0304\u0304\u0306\u0304\u0301\u0305, string \u0303\u0303\u0306\u0302\u0306\u0305\u0307\u0301\u0303\u0304\u0304\u0303\u0303\u0306\u0308)
		{
		}

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		[FieldOffset(Offset = "0x20")]
		public string terrainTextureName;

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x28")]
		public int splatIndex;

		// Token: 0x04002C1B RID: 11291
		[Token(Token = "0x4002C1B")]
		[FieldOffset(Offset = "0x30")]
		public TerrainTextureSettings terrainTextureSettings;

		// Token: 0x04002C1C RID: 11292
		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x38")]
		public TerrainLayer terrainLayer;
	}
}
