using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UserInterface.Global.Resources
{
	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	[Serializable]
	public class VideoSettings
	{
		// Token: 0x06013E17 RID: 81431 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013E17")]
		[Address(RVA = "0x19539F0", Offset = "0x1952DF0", VA = "0x1819539F0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x17F6F0", Offset = "0x17EAF0")]
		public IEnumerable<UniversalRenderPipelineAsset> IterateAllPipes()
		{
			return null;
		}

		// Token: 0x06013E18 RID: 81432 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013E18")]
		[Address(RVA = "0x1953890", Offset = "0x1952C90", VA = "0x181953890")]
		public UniversalRenderPipelineAsset GetAsset(bool shadows, ShadowResolution resolution)
		{
			return null;
		}

		// Token: 0x06013E19 RID: 81433 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013E19")]
		[Address(RVA = "0x9359E0", Offset = "0x934DE0", VA = "0x1809359E0")]
		public UniversalRenderPipelineAsset GetSpectatorAsset()
		{
			return null;
		}

		// Token: 0x06013E1A RID: 81434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E1A")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public VideoSettings()
		{
		}

		// Token: 0x04003D5B RID: 15707
		[Token(Token = "0x4003D5B")]
		[FieldOffset(Offset = "0x10")]
		public UniversalRenderPipelineAsset noShadows;

		// Token: 0x04003D5C RID: 15708
		[Token(Token = "0x4003D5C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16AB80", Offset = "0x169F80")]
		public UniversalRenderPipelineAsset loadout;

		// Token: 0x04003D5D RID: 15709
		[Token(Token = "0x4003D5D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17F630", Offset = "0x17EA30")]
		public UniversalRenderPipelineAsset softEdge256;

		// Token: 0x04003D5E RID: 15710
		[Token(Token = "0x4003D5E")]
		[FieldOffset(Offset = "0x28")]
		public UniversalRenderPipelineAsset softEdge512;

		// Token: 0x04003D5F RID: 15711
		[Token(Token = "0x4003D5F")]
		[FieldOffset(Offset = "0x30")]
		public UniversalRenderPipelineAsset softEdge1024;

		// Token: 0x04003D60 RID: 15712
		[Token(Token = "0x4003D60")]
		[FieldOffset(Offset = "0x38")]
		public UniversalRenderPipelineAsset softEdge2048;

		// Token: 0x04003D61 RID: 15713
		[Token(Token = "0x4003D61")]
		[FieldOffset(Offset = "0x40")]
		public UniversalRenderPipelineAsset softEdge4096;

		// Token: 0x04003D62 RID: 15714
		[Token(Token = "0x4003D62")]
		[FieldOffset(Offset = "0x48")]
		public UniversalRenderPipelineAsset spectator;

		// Token: 0x04003D63 RID: 15715
		[Token(Token = "0x4003D63")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169820", Offset = "0x168C20")]
		public VolumeProfile ImageEffects;

		// Token: 0x04003D64 RID: 15716
		[Token(Token = "0x4003D64")]
		[FieldOffset(Offset = "0x58")]
		public VolumeProfile LoadoutImageEffects;

		// Token: 0x04003D65 RID: 15717
		[Token(Token = "0x4003D65")]
		[FieldOffset(Offset = "0x60")]
		public RenderObjects ReticleDay;

		// Token: 0x04003D66 RID: 15718
		[Token(Token = "0x4003D66")]
		[FieldOffset(Offset = "0x68")]
		public RenderObjects ReticleNight;

		// Token: 0x020007DB RID: 2011
		[Token(Token = "0x20007DB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <IterateAllPipes>d__12 : IEnumerable<UniversalRenderPipelineAsset>, IEnumerable, IEnumerator<UniversalRenderPipelineAsset>, IEnumerator, IDisposable
		{
			// Token: 0x06013E1B RID: 81435 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E1B")]
			[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
			[DebuggerHidden]
			public <IterateAllPipes>d__12(int <>1__state)
			{
			}

			// Token: 0x06013E1C RID: 81436 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E1C")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013E1D RID: 81437 RVA: 0x0007DBAC File Offset: 0x0007BDAC
			[Token(Token = "0x6013E1D")]
			[Address(RVA = "0x1945670", Offset = "0x1944A70", VA = "0x181945670", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000BED RID: 3053
			// (get) Token: 0x06013E1E RID: 81438 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000BED")]
			private UniversalRenderPipelineAsset Current
			{
				[Token(Token = "0x6013E1E")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013E1F RID: 81439 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E1F")]
			[Address(RVA = "0x1945890", Offset = "0x1944C90", VA = "0x181945890", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x06013E20 RID: 81440 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000BEE")]
			private object Current
			{
				[Token(Token = "0x6013E20")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013E21 RID: 81441 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E21")]
			[Address(RVA = "0x19457F0", Offset = "0x1944BF0", VA = "0x1819457F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<UniversalRenderPipelineAsset> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06013E22 RID: 81442 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E22")]
			[Address(RVA = "0x19457F0", Offset = "0x1944BF0", VA = "0x1819457F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04003D67 RID: 15719
			[Token(Token = "0x4003D67")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04003D68 RID: 15720
			[Token(Token = "0x4003D68")]
			[FieldOffset(Offset = "0x18")]
			private UniversalRenderPipelineAsset <>2__current;

			// Token: 0x04003D69 RID: 15721
			[Token(Token = "0x4003D69")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04003D6A RID: 15722
			[Token(Token = "0x4003D6A")]
			[FieldOffset(Offset = "0x28")]
			public VideoSettings <>4__this;
		}
	}
}
