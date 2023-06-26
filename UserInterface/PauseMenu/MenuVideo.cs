using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UserInterface.PauseMenu.Options;
using UserInterface.PauseMenu.Options.Behaviours;

namespace UserInterface.PauseMenu
{
	// Token: 0x02000777 RID: 1911
	[Token(Token = "0x2000777")]
	[Serializable]
	public class MenuVideo : IEnumerable<IOptionsElement>, IEnumerable
	{
		// Token: 0x06013B12 RID: 80658 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B12")]
		[Address(RVA = "0x188D8C0", Offset = "0x188CCC0", VA = "0x18188D8C0", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x169900", Offset = "0x168D00")]
		public IEnumerator<IOptionsElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013B13 RID: 80659 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B13")]
		[Address(RVA = "0x188D8C0", Offset = "0x188CCC0", VA = "0x18188D8C0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013B14 RID: 80660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B14")]
		[Address(RVA = "0x188C3D0", Offset = "0x188B7D0", VA = "0x18188C3D0")]
		public void ApplyToSettings()
		{
		}

		// Token: 0x06013B15 RID: 80661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B15")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public MenuVideo()
		{
		}

		// Token: 0x06013B16 RID: 80662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B16")]
		[Address(RVA = "0x188D930", Offset = "0x188CD30", VA = "0x18188D930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static void <ApplyToSettings>g__toggleKeyword|2_0(bool value, string field)
		{
		}

		// Token: 0x0400397C RID: 14716
		[Token(Token = "0x400397C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169500", Offset = "0x168900")]
		public ToggleBehaviour CustomResolution;

		// Token: 0x0400397D RID: 14717
		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0x18")]
		public CustomResolutionBehaviour CustomResolutionValue;

		// Token: 0x0400397E RID: 14718
		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0x20")]
		public ScreenResolutionBehaviour Resolution;

		// Token: 0x0400397F RID: 14719
		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0x28")]
		public EnumBehaviour ScreenMode;

		// Token: 0x04003980 RID: 14720
		[Token(Token = "0x4003980")]
		[FieldOffset(Offset = "0x30")]
		public SliderBehaviour ScreenScale;

		// Token: 0x04003981 RID: 14721
		[Token(Token = "0x4003981")]
		[FieldOffset(Offset = "0x38")]
		public ToggleBehaviour VerticalSync;

		// Token: 0x04003982 RID: 14722
		[Token(Token = "0x4003982")]
		[FieldOffset(Offset = "0x40")]
		public SliderBehaviour MaxFPS;

		// Token: 0x04003983 RID: 14723
		[Token(Token = "0x4003983")]
		[FieldOffset(Offset = "0x48")]
		public ToggleBehaviour GpuSkinning;

		// Token: 0x04003984 RID: 14724
		[Token(Token = "0x4003984")]
		[FieldOffset(Offset = "0x50")]
		public SliderBehaviour Brightness;

		// Token: 0x04003985 RID: 14725
		[Token(Token = "0x4003985")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169530", Offset = "0x168930")]
		public SliderBehaviour FieldOfView;

		// Token: 0x04003986 RID: 14726
		[Token(Token = "0x4003986")]
		[FieldOffset(Offset = "0x60")]
		public SliderBehaviour VehicleFieldOfView;

		// Token: 0x04003987 RID: 14727
		[Token(Token = "0x4003987")]
		[FieldOffset(Offset = "0x68")]
		public SliderBehaviour ScreenShake;

		// Token: 0x04003988 RID: 14728
		[Token(Token = "0x4003988")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1695A0", Offset = "0x1689A0")]
		public ToggleBehaviour UIMultithreading;

		// Token: 0x04003989 RID: 14729
		[Token(Token = "0x4003989")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1696A0", Offset = "0x168AA0")]
		public ToggleBehaviour Shadows;

		// Token: 0x0400398A RID: 14730
		[Token(Token = "0x400398A")]
		[FieldOffset(Offset = "0x80")]
		public EnumBehaviour ShadowResolution;

		// Token: 0x0400398B RID: 14731
		[Token(Token = "0x400398B")]
		[FieldOffset(Offset = "0x88")]
		public EnumBehaviour ShadowDistance;

		// Token: 0x0400398C RID: 14732
		[Token(Token = "0x400398C")]
		[FieldOffset(Offset = "0x90")]
		public EnumBehaviour AntiAliasign;

		// Token: 0x0400398D RID: 14733
		[Token(Token = "0x400398D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1697A0", Offset = "0x168BA0")]
		public EnumBehaviour DestructionQuality;

		// Token: 0x0400398E RID: 14734
		[Token(Token = "0x400398E")]
		[FieldOffset(Offset = "0xA0")]
		public SliderBehaviour NumberOfLights;

		// Token: 0x0400398F RID: 14735
		[Token(Token = "0x400398F")]
		[FieldOffset(Offset = "0xA8")]
		public SliderBehaviour ObjectsQuality;

		// Token: 0x04003990 RID: 14736
		[Token(Token = "0x4003990")]
		[FieldOffset(Offset = "0xB0")]
		public ToggleBehaviour LazyLods;

		// Token: 0x04003991 RID: 14737
		[Token(Token = "0x4003991")]
		[FieldOffset(Offset = "0xB8")]
		public EnumBehaviour RainQuality;

		// Token: 0x04003992 RID: 14738
		[Token(Token = "0x4003992")]
		[FieldOffset(Offset = "0xC0")]
		public SliderBehaviour RenderDistance;

		// Token: 0x04003993 RID: 14739
		[Token(Token = "0x4003993")]
		[FieldOffset(Offset = "0xC8")]
		public EnumBehaviour ShaderQuality;

		// Token: 0x04003994 RID: 14740
		[Token(Token = "0x4003994")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169820", Offset = "0x168C20")]
		public ToggleBehaviour BrightnessColoring;

		// Token: 0x04003995 RID: 14741
		[Token(Token = "0x4003995")]
		[FieldOffset(Offset = "0xD8")]
		public ToggleBehaviour Bloom;

		// Token: 0x04003996 RID: 14742
		[Token(Token = "0x4003996")]
		[FieldOffset(Offset = "0xE0")]
		public ToggleBehaviour SSAO;

		// Token: 0x04003997 RID: 14743
		[Token(Token = "0x4003997")]
		[FieldOffset(Offset = "0xE8")]
		public ToggleBehaviour MotionBlur;

		// Token: 0x04003998 RID: 14744
		[Token(Token = "0x4003998")]
		[FieldOffset(Offset = "0xF0")]
		public ToggleBehaviour Vignette;

		// Token: 0x04003999 RID: 14745
		[Token(Token = "0x4003999")]
		[FieldOffset(Offset = "0xF8")]
		public ToggleBehaviour ADSEffect;

		// Token: 0x0400399A RID: 14746
		[Token(Token = "0x400399A")]
		[FieldOffset(Offset = "0x100")]
		public SliderBehaviour ContrastIntensity;

		// Token: 0x02000778 RID: 1912
		[Token(Token = "0x2000778")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <GetEnumerator>d__0 : IEnumerator<IOptionsElement>, IEnumerator, IDisposable
		{
			// Token: 0x06013B17 RID: 80663 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B17")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <GetEnumerator>d__0(int <>1__state)
			{
			}

			// Token: 0x06013B18 RID: 80664 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B18")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013B19 RID: 80665 RVA: 0x0007D144 File Offset: 0x0007B344
			[Token(Token = "0x6013B19")]
			[Address(RVA = "0x1896C70", Offset = "0x1896070", VA = "0x181896C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B9B RID: 2971
			// (get) Token: 0x06013B1A RID: 80666 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B9B")]
			private IOptionsElement Current
			{
				[Token(Token = "0x6013B1A")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013B1B RID: 80667 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B1B")]
			[Address(RVA = "0x1898810", Offset = "0x1897C10", VA = "0x181898810", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B9C RID: 2972
			// (get) Token: 0x06013B1C RID: 80668 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B9C")]
			private object Current
			{
				[Token(Token = "0x6013B1C")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400399B RID: 14747
			[Token(Token = "0x400399B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400399C RID: 14748
			[Token(Token = "0x400399C")]
			[FieldOffset(Offset = "0x18")]
			private IOptionsElement <>2__current;

			// Token: 0x0400399D RID: 14749
			[Token(Token = "0x400399D")]
			[FieldOffset(Offset = "0x20")]
			public MenuVideo <>4__this;
		}
	}
}
