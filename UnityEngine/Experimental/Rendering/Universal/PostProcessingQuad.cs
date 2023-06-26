using System;
using touching_your_mom;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	// Token: 0x02000806 RID: 2054
	[Token(Token = "0x2000806")]
	public class PostProcessingQuad : ScriptableRendererFeature
	{
		// Token: 0x06013EF2 RID: 81650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF2")]
		[Address(RVA = "0x1942990", Offset = "0x1941D90", VA = "0x181942990", Slot = "4")]
		public override void Create()
		{
		}

		// Token: 0x06013EF3 RID: 81651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF3")]
		[Address(RVA = "0x1942940", Offset = "0x1941D40", VA = "0x181942940", Slot = "5")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x06013EF4 RID: 81652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EF4")]
		[Address(RVA = "0x1940320", Offset = "0x193F720", VA = "0x181940320")]
		public PostProcessingQuad()
		{
		}

		// Token: 0x04003EAF RID: 16047
		[Token(Token = "0x4003EAF")]
		[FieldOffset(Offset = "0x20")]
		public PostProcessingQuad.PostProcessingQuadSettings m_Settings;

		// Token: 0x04003EB0 RID: 16048
		[Token(Token = "0x4003EB0")]
		[FieldOffset(Offset = "0x28")]
		private PostProcessingPass m_RenderQuadPass;

		// Token: 0x02000807 RID: 2055
		[Token(Token = "0x2000807")]
		[Serializable]
		public struct PostProcessingQuadSettings
		{
			// Token: 0x04003EB1 RID: 16049
			[Token(Token = "0x4003EB1")]
			[FieldOffset(Offset = "0x0")]
			public RenderPassEvent renderPassEvent;
		}
	}
}
