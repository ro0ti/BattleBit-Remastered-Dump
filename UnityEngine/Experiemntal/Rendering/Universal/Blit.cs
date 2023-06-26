using System;
using touching_your_mom;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experiemntal.Rendering.Universal
{
	// Token: 0x02000809 RID: 2057
	[Token(Token = "0x2000809")]
	public class Blit : ScriptableRendererFeature
	{
		// Token: 0x06013EF8 RID: 81656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF8")]
		[Address(RVA = "0x193C8C0", Offset = "0x193BCC0", VA = "0x18193C8C0", Slot = "4")]
		public override void Create()
		{
		}

		// Token: 0x06013EF9 RID: 81657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF9")]
		[Address(RVA = "0x193C6A0", Offset = "0x193BAA0", VA = "0x18193C6A0", Slot = "5")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x06013EFA RID: 81658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EFA")]
		[Address(RVA = "0x193CA90", Offset = "0x193BE90", VA = "0x18193CA90")]
		public Blit()
		{
		}

		// Token: 0x04003EB5 RID: 16053
		[Token(Token = "0x4003EB5")]
		[FieldOffset(Offset = "0x20")]
		public Blit.BlitSettings settings;

		// Token: 0x04003EB6 RID: 16054
		[Token(Token = "0x4003EB6")]
		[FieldOffset(Offset = "0x28")]
		private RenderTargetHandle m_RenderTextureHandle;

		// Token: 0x04003EB7 RID: 16055
		[Token(Token = "0x4003EB7")]
		[FieldOffset(Offset = "0x30")]
		private BlitPass blitPass;

		// Token: 0x0200080A RID: 2058
		[Token(Token = "0x200080A")]
		[Serializable]
		public class BlitSettings
		{
			// Token: 0x06013EFB RID: 81659 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EFB")]
			[Address(RVA = "0x193C640", Offset = "0x193BA40", VA = "0x18193C640")]
			public BlitSettings()
			{
			}

			// Token: 0x04003EB8 RID: 16056
			[Token(Token = "0x4003EB8")]
			[FieldOffset(Offset = "0x10")]
			public RenderPassEvent Event;

			// Token: 0x04003EB9 RID: 16057
			[Token(Token = "0x4003EB9")]
			[FieldOffset(Offset = "0x18")]
			public Material blitMaterial;

			// Token: 0x04003EBA RID: 16058
			[Token(Token = "0x4003EBA")]
			[FieldOffset(Offset = "0x20")]
			public int blitMaterialPassIndex;

			// Token: 0x04003EBB RID: 16059
			[Token(Token = "0x4003EBB")]
			[FieldOffset(Offset = "0x24")]
			public Blit.Target destination;

			// Token: 0x04003EBC RID: 16060
			[Token(Token = "0x4003EBC")]
			[FieldOffset(Offset = "0x28")]
			public string textureId;
		}

		// Token: 0x0200080B RID: 2059
		[Token(Token = "0x200080B")]
		public enum Target
		{
			// Token: 0x04003EBE RID: 16062
			[Token(Token = "0x4003EBE")]
			Color,
			// Token: 0x04003EBF RID: 16063
			[Token(Token = "0x4003EBF")]
			Texture
		}
	}
}
