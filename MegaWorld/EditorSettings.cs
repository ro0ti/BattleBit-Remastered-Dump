using System;
using touching_your_mom;

namespace MegaWorld
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	[Serializable]
	public class EditorSettings
	{
		// Token: 0x060105E7 RID: 67047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60105E7")]
		[Address(RVA = "0x35D6B50", Offset = "0x35D5F50", VA = "0x1835D6B50")]
		public EditorSettings()
		{
		}

		// Token: 0x04002C7A RID: 11386
		[Token(Token = "0x4002C7A")]
		[FieldOffset(Offset = "0x10")]
		public bool useLargeRanges;

		// Token: 0x04002C7B RID: 11387
		[Token(Token = "0x4002C7B")]
		[FieldOffset(Offset = "0x14")]
		public float maxBrushSize;

		// Token: 0x04002C7C RID: 11388
		[Token(Token = "0x4002C7C")]
		[FieldOffset(Offset = "0x18")]
		public float maxEraseSize;

		// Token: 0x04002C7D RID: 11389
		[Token(Token = "0x4002C7D")]
		[FieldOffset(Offset = "0x1C")]
		public float maxEditSize;

		// Token: 0x04002C7E RID: 11390
		[Token(Token = "0x4002C7E")]
		[FieldOffset(Offset = "0x20")]
		public float maxBrushLargeSpacing;

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		[FieldOffset(Offset = "0x24")]
		public int maxChecks;

		// Token: 0x04002C80 RID: 11392
		[Token(Token = "0x4002C80")]
		[FieldOffset(Offset = "0x28")]
		public float minHeight;

		// Token: 0x04002C81 RID: 11393
		[Token(Token = "0x4002C81")]
		[FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		// Token: 0x04002C82 RID: 11394
		[Token(Token = "0x4002C82")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "MinAttribute", RVA = "0x180E60", Offset = "0x180260")]
		public int maxTargetStrength;

		// Token: 0x04002C83 RID: 11395
		[Token(Token = "0x4002C83")]
		[FieldOffset(Offset = "0x34")]
		public float spawnCheckOffset;

		// Token: 0x04002C84 RID: 11396
		[Token(Token = "0x4002C84")]
		[FieldOffset(Offset = "0x38")]
		public bool enableUndoForGameObject;

		// Token: 0x04002C85 RID: 11397
		[Token(Token = "0x4002C85")]
		[FieldOffset(Offset = "0x39")]
		public bool enableTips;
	}
}
