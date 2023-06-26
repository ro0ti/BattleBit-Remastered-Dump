using System;
using touching_your_mom;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	// Token: 0x02000803 RID: 2051
	[Token(Token = "0x2000803")]
	public class FullScreenQuad : ScriptableRendererFeature
	{
		// Token: 0x06013EED RID: 81645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EED")]
		[Address(RVA = "0x1940270", Offset = "0x193F670", VA = "0x181940270", Slot = "4")]
		public override void Create()
		{
		}

		// Token: 0x06013EEE RID: 81646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EEE")]
		[Address(RVA = "0x19401E0", Offset = "0x193F5E0", VA = "0x1819401E0", Slot = "5")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x06013EEF RID: 81647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EEF")]
		[Address(RVA = "0x1940320", Offset = "0x193F720", VA = "0x181940320")]
		public FullScreenQuad()
		{
		}

		// Token: 0x04003EA9 RID: 16041
		[Token(Token = "0x4003EA9")]
		[FieldOffset(Offset = "0x20")]
		public FullScreenQuad.FullScreenQuadSettings m_Settings;

		// Token: 0x04003EAA RID: 16042
		[Token(Token = "0x4003EAA")]
		[FieldOffset(Offset = "0x30")]
		private FullScreenQuadPass m_RenderQuadPass;

		// Token: 0x02000804 RID: 2052
		[Token(Token = "0x2000804")]
		[Serializable]
		public struct FullScreenQuadSettings
		{
			// Token: 0x04003EAB RID: 16043
			[Token(Token = "0x4003EAB")]
			[FieldOffset(Offset = "0x0")]
			public RenderPassEvent renderPassEvent;

			// Token: 0x04003EAC RID: 16044
			[Token(Token = "0x4003EAC")]
			[FieldOffset(Offset = "0x8")]
			public Material material;
		}
	}
}
