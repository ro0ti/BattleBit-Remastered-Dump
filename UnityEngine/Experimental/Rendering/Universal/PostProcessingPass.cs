using System;
using touching_your_mom;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	// Token: 0x02000808 RID: 2056
	[Token(Token = "0x2000808")]
	public class PostProcessingPass : ScriptableRenderPass
	{
		// Token: 0x06013EF5 RID: 81653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF5")]
		[Address(RVA = "0x19428E0", Offset = "0x1941CE0", VA = "0x1819428E0")]
		public PostProcessingPass(PostProcessingQuad.PostProcessingQuadSettings settings)
		{
		}

		// Token: 0x06013EF6 RID: 81654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF6")]
		[Address(RVA = "0x193C620", Offset = "0x193BA20", VA = "0x18193C620")]
		public void Setup(RenderTargetIdentifier source)
		{
		}

		// Token: 0x06013EF7 RID: 81655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF7")]
		[Address(RVA = "0x1942890", Offset = "0x1941C90", VA = "0x181942890", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x04003EB2 RID: 16050
		[Token(Token = "0x4003EB2")]
		[FieldOffset(Offset = "0x68")]
		private string m_ProfilerTag;

		// Token: 0x04003EB3 RID: 16051
		[Token(Token = "0x4003EB3")]
		[FieldOffset(Offset = "0x70")]
		private PostProcessingQuad.PostProcessingQuadSettings m_Settings;

		// Token: 0x04003EB4 RID: 16052
		[Token(Token = "0x4003EB4")]
		[FieldOffset(Offset = "0x78")]
		private RenderTargetIdentifier source;
	}
}
