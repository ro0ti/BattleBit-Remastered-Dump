using System;
using touching_your_mom;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experiemntal.Rendering.Universal
{
	// Token: 0x0200080C RID: 2060
	[Token(Token = "0x200080C")]
	internal class BlitPass : ScriptableRenderPass
	{
		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06013EFC RID: 81660 RVA: 0x0007DBC4 File Offset: 0x0007BDC4
		// (set) Token: 0x06013EFD RID: 81661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BEF")]
		public FilterMode filterMode
		{
			[Token(Token = "0x6013EFC")]
			[Address(RVA = "0xB45720", Offset = "0xB44B20", VA = "0x180B45720")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return FilterMode.Point;
			}
			[Token(Token = "0x6013EFD")]
			[Address(RVA = "0x193C610", Offset = "0x193BA10", VA = "0x18193C610")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06013EFE RID: 81662 RVA: 0x0007DBDC File Offset: 0x0007BDDC
		// (set) Token: 0x06013EFF RID: 81663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF0")]
		private RenderTargetIdentifier source
		{
			[Token(Token = "0x6013EFE")]
			[Address(RVA = "0x193C5D0", Offset = "0x193B9D0", VA = "0x18193C5D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x6013EFF")]
			[Address(RVA = "0x193C620", Offset = "0x193BA20", VA = "0x18193C620")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06013F00 RID: 81664 RVA: 0x0007DBF4 File Offset: 0x0007BDF4
		// (set) Token: 0x06013F01 RID: 81665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF1")]
		private RenderTargetHandle destination
		{
			[Token(Token = "0x6013F00")]
			[Address(RVA = "0x94CCC0", Offset = "0x94C0C0", VA = "0x18094CCC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x6013F01")]
			[Address(RVA = "0x193C600", Offset = "0x193BA00", VA = "0x18193C600")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013F02 RID: 81666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013F02")]
		[Address(RVA = "0x193C530", Offset = "0x193B930", VA = "0x18193C530")]
		public BlitPass(RenderPassEvent renderPassEvent, Material blitMaterial, int blitShaderPassIndex, string tag)
		{
		}

		// Token: 0x06013F03 RID: 81667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013F03")]
		[Address(RVA = "0x193C500", Offset = "0x193B900", VA = "0x18193C500")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination)
		{
		}

		// Token: 0x06013F04 RID: 81668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013F04")]
		[Address(RVA = "0x193C120", Offset = "0x193B520", VA = "0x18193C120", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x06013F05 RID: 81669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013F05")]
		[Address(RVA = "0x193C450", Offset = "0x193B850", VA = "0x18193C450", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x04003EC0 RID: 16064
		[Token(Token = "0x4003EC0")]
		[FieldOffset(Offset = "0x68")]
		public Material blitMaterial;

		// Token: 0x04003EC1 RID: 16065
		[Token(Token = "0x4003EC1")]
		[FieldOffset(Offset = "0x70")]
		public int blitShaderPassIndex;

		// Token: 0x04003EC2 RID: 16066
		[Token(Token = "0x4003EC2")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private FilterMode <filterMode>k__BackingField;

		// Token: 0x04003EC3 RID: 16067
		[Token(Token = "0x4003EC3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private RenderTargetIdentifier <source>k__BackingField;

		// Token: 0x04003EC4 RID: 16068
		[Token(Token = "0x4003EC4")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private RenderTargetHandle <destination>k__BackingField;

		// Token: 0x04003EC5 RID: 16069
		[Token(Token = "0x4003EC5")]
		[FieldOffset(Offset = "0xA4")]
		private RenderTargetHandle m_TemporaryColorTexture;

		// Token: 0x04003EC6 RID: 16070
		[Token(Token = "0x4003EC6")]
		[FieldOffset(Offset = "0xA8")]
		private string m_ProfilerTag;

		// Token: 0x0200080D RID: 2061
		[Token(Token = "0x200080D")]
		public enum RenderTarget
		{
			// Token: 0x04003EC8 RID: 16072
			[Token(Token = "0x4003EC8")]
			Color,
			// Token: 0x04003EC9 RID: 16073
			[Token(Token = "0x4003EC9")]
			RenderTexture
		}
	}
}
