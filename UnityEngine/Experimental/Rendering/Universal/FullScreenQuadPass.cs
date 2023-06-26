using System;
using touching_your_mom;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	// Token: 0x02000805 RID: 2053
	[Token(Token = "0x2000805")]
	public class FullScreenQuadPass : ScriptableRenderPass
	{
		// Token: 0x06013EF0 RID: 81648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF0")]
		[Address(RVA = "0x1940170", Offset = "0x193F570", VA = "0x181940170")]
		public FullScreenQuadPass(FullScreenQuad.FullScreenQuadSettings settings)
		{
		}

		// Token: 0x06013EF1 RID: 81649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF1")]
		[Address(RVA = "0x193FF00", Offset = "0x193F300", VA = "0x18193FF00", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x04003EAD RID: 16045
		[Token(Token = "0x4003EAD")]
		[FieldOffset(Offset = "0x68")]
		private string m_ProfilerTag;

		// Token: 0x04003EAE RID: 16046
		[Token(Token = "0x4003EAE")]
		[FieldOffset(Offset = "0x70")]
		private FullScreenQuad.FullScreenQuadSettings m_Settings;
	}
}
