using System;
using touching_your_mom;
using UnityEngine.Experimental.Rendering.Universal;

namespace PlayerCollectionGrouping
{
	// Token: 0x02000800 RID: 2048
	[Token(Token = "0x2000800")]
	[Serializable]
	public class Pipeline
	{
		// Token: 0x06013EEA RID: 81642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EEA")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Pipeline()
		{
		}

		// Token: 0x04003E97 RID: 16023
		[Token(Token = "0x4003E97")]
		[FieldOffset(Offset = "0x10")]
		public RenderObjects UIRender;

		// Token: 0x04003E98 RID: 16024
		[Token(Token = "0x4003E98")]
		[FieldOffset(Offset = "0x18")]
		public RenderObjects DefaultCharacterPassFriendly;

		// Token: 0x04003E99 RID: 16025
		[Token(Token = "0x4003E99")]
		[FieldOffset(Offset = "0x20")]
		public RenderObjects DefaultCharacterPassEnemy;

		// Token: 0x04003E9A RID: 16026
		[Token(Token = "0x4003E9A")]
		[FieldOffset(Offset = "0x28")]
		public RenderObjects FlirEnemy;

		// Token: 0x04003E9B RID: 16027
		[Token(Token = "0x4003E9B")]
		[FieldOffset(Offset = "0x30")]
		public RenderObjects FlirEnemyGlobal;

		// Token: 0x04003E9C RID: 16028
		[Token(Token = "0x4003E9C")]
		[FieldOffset(Offset = "0x38")]
		public PostProcess NightVision;
	}
}
