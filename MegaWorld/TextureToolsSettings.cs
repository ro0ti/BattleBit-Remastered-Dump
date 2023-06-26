using System;
using touching_your_mom;

namespace MegaWorld
{
	// Token: 0x0200060E RID: 1550
	[Token(Token = "0x200060E")]
	[Serializable]
	public class TextureToolsSettings
	{
		// Token: 0x06010B08 RID: 68360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010B08")]
		[Address(RVA = "0x2A87CF0", Offset = "0x2A870F0", VA = "0x182A87CF0")]
		public TextureToolsSettings()
		{
		}

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x10")]
		public float targetStrength;

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x14")]
		public float opacity;

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x18")]
		public float sharpenStrength;

		// Token: 0x04002D44 RID: 11588
		[Token(Token = "0x4002D44")]
		[FieldOffset(Offset = "0x1C")]
		public int blurStrength;
	}
}
