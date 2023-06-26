using System;
using touching_your_mom;

namespace MegaWorld
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	[Serializable]
	public class BrushVisualisationSettings
	{
		// Token: 0x06010570 RID: 66928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6010570")]
		[Address(RVA = "0x2B87280", Offset = "0x2B86680", VA = "0x182B87280")]
		public BrushVisualisationSettings()
		{
		}

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[FieldOffset(Offset = "0x10")]
		public \u0301\u0308\u0301\u0303\u0305\u0305\u0308\u0302\u0304\u0301\u0302\u0308\u0301\u0302\u0306 visualizeMode;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		[FieldOffset(Offset = "0x18")]
		public BrushHandlesSettings brushHandlesSettings;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x20")]
		public BrushMaskFiltersSettings brushMaskFiltersSettings;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x28")]
		public SimpleFilterSettings simpleFilterSettings;
	}
}
