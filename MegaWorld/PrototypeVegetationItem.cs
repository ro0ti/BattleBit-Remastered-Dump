using System;
using touching_your_mom;
using UnityEngine;

namespace MegaWorld
{
	// Token: 0x020005F0 RID: 1520
	[Token(Token = "0x20005F0")]
	[Serializable]
	public class PrototypeVegetationItem : Prototype
	{
		// Token: 0x06010477 RID: 66679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010477")]
		[Address(RVA = "0x3763A70", Offset = "0x3762E70", VA = "0x183763A70")]
		public PrototypeVegetationItem(GameObject \u0308\u0302\u0306\u0308\u0308\u0307\u0302\u0307\u0303\u0301\u0305\u0305\u0301\u0306\u0302, Vector3 \u0301\u0308\u0306\u0306\u0303\u0303\u0307\u0306\u0302\u0308\u0301\u0301\u0303\u0307\u0307)
		{
		}

		// Token: 0x06010478 RID: 66680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010478")]
		[Address(RVA = "0x37638F0", Offset = "0x3762CF0", VA = "0x1837638F0")]
		public PrototypeVegetationItem()
		{
		}

		// Token: 0x04002C25 RID: 11301
		[Token(Token = "0x4002C25")]
		[FieldOffset(Offset = "0x20")]
		public string terrainTreeName;

		// Token: 0x04002C26 RID: 11302
		[Token(Token = "0x4002C26")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 extents;

		// Token: 0x04002C27 RID: 11303
		[Token(Token = "0x4002C27")]
		[FieldOffset(Offset = "0x34")]
		public int terrainProtoId;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		[FieldOffset(Offset = "0x38")]
		public float bendFactor;

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		[FieldOffset(Offset = "0x40")]
		public AdditionalSpawnSettings additionalSpawnSettings;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		[FieldOffset(Offset = "0x48")]
		public FailureSettings failureSettings;

		// Token: 0x04002C2B RID: 11307
		[Token(Token = "0x4002C2B")]
		[FieldOffset(Offset = "0x50")]
		public IntersectSettings intersectSettings;

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x58")]
		public TerrainTransformSettings terrainTransformSettings;

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x60")]
		public string vegetationItemID;
	}
}
