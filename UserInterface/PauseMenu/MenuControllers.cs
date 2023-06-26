using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UserInterface.PauseMenu.Options;
using UserInterface.PauseMenu.Options.Behaviours;

namespace UserInterface.PauseMenu
{
	// Token: 0x02000771 RID: 1905
	[Token(Token = "0x2000771")]
	[Serializable]
	public class MenuControllers : IEnumerable<IOptionsElement>, IEnumerable
	{
		// Token: 0x06013AF2 RID: 80626 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013AF2")]
		[Address(RVA = "0x168A130", Offset = "0x1689530", VA = "0x18168A130", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1668F0", Offset = "0x165CF0")]
		public IEnumerator<IOptionsElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013AF3 RID: 80627 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013AF3")]
		[Address(RVA = "0x168A130", Offset = "0x1689530", VA = "0x18168A130", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013AF4 RID: 80628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AF4")]
		[Address(RVA = "0x1689AE0", Offset = "0x1688EE0", VA = "0x181689AE0")]
		public void ApplyToSettings()
		{
		}

		// Token: 0x06013AF5 RID: 80629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AF5")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public MenuControllers()
		{
		}

		// Token: 0x040038E8 RID: 14568
		[Token(Token = "0x40038E8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166520", Offset = "0x165920")]
		public SliderBehaviour VerticalSensitivity;

		// Token: 0x040038E9 RID: 14569
		[Token(Token = "0x40038E9")]
		[FieldOffset(Offset = "0x18")]
		public SliderBehaviour HorizontalSensitivity;

		// Token: 0x040038EA RID: 14570
		[Token(Token = "0x40038EA")]
		[FieldOffset(Offset = "0x20")]
		public ToggleBehaviour InvertVertical;

		// Token: 0x040038EB RID: 14571
		[Token(Token = "0x40038EB")]
		[FieldOffset(Offset = "0x28")]
		public ToggleBehaviour InvertHorizontal;

		// Token: 0x040038EC RID: 14572
		[Token(Token = "0x40038EC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166730", Offset = "0x165B30")]
		public ToggleBehaviour DirectionalClimbing;

		// Token: 0x040038ED RID: 14573
		[Token(Token = "0x40038ED")]
		[FieldOffset(Offset = "0x38")]
		public ToggleBehaviour ToggleAim;

		// Token: 0x040038EE RID: 14574
		[Token(Token = "0x40038EE")]
		[FieldOffset(Offset = "0x40")]
		public ToggleBehaviour ToggleLean;

		// Token: 0x040038EF RID: 14575
		[Token(Token = "0x40038EF")]
		[FieldOffset(Offset = "0x48")]
		public ToggleBehaviour SwapReloading;

		// Token: 0x040038F0 RID: 14576
		[Token(Token = "0x40038F0")]
		[FieldOffset(Offset = "0x50")]
		public ToggleBehaviour ToggleDrag;

		// Token: 0x040038F1 RID: 14577
		[Token(Token = "0x40038F1")]
		[FieldOffset(Offset = "0x58")]
		public ToggleBehaviour ToggleRunning;

		// Token: 0x040038F2 RID: 14578
		[Token(Token = "0x40038F2")]
		[FieldOffset(Offset = "0x60")]
		public EnumBehaviour ReloadStyle;

		// Token: 0x040038F3 RID: 14579
		[Token(Token = "0x40038F3")]
		[FieldOffset(Offset = "0x68")]
		public SliderBehaviour ReloadTapDelay;

		// Token: 0x040038F4 RID: 14580
		[Token(Token = "0x40038F4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1667F0", Offset = "0x165BF0")]
		public SliderBehaviour ADSVerticalSensitivity;

		// Token: 0x040038F5 RID: 14581
		[Token(Token = "0x40038F5")]
		[FieldOffset(Offset = "0x78")]
		public SliderBehaviour ADSHorizontalSensitivity;

		// Token: 0x040038F6 RID: 14582
		[Token(Token = "0x40038F6")]
		[FieldOffset(Offset = "0x80")]
		public SliderBehaviour _1Sensitivity;

		// Token: 0x040038F7 RID: 14583
		[Token(Token = "0x40038F7")]
		[FieldOffset(Offset = "0x88")]
		public SliderBehaviour _2Sensitivity;

		// Token: 0x040038F8 RID: 14584
		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x90")]
		public SliderBehaviour _3Sensitivity;

		// Token: 0x040038F9 RID: 14585
		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x98")]
		public SliderBehaviour _4Sensitivity;

		// Token: 0x040038FA RID: 14586
		[Token(Token = "0x40038FA")]
		[FieldOffset(Offset = "0xA0")]
		public SliderBehaviour _6Sensitivity;

		// Token: 0x040038FB RID: 14587
		[Token(Token = "0x40038FB")]
		[FieldOffset(Offset = "0xA8")]
		public SliderBehaviour _8Sensitivity;

		// Token: 0x040038FC RID: 14588
		[Token(Token = "0x40038FC")]
		[FieldOffset(Offset = "0xB0")]
		public SliderBehaviour _12Sensitivity;

		// Token: 0x040038FD RID: 14589
		[Token(Token = "0x40038FD")]
		[FieldOffset(Offset = "0xB8")]
		public SliderBehaviour _15Sensitivity;

		// Token: 0x040038FE RID: 14590
		[Token(Token = "0x40038FE")]
		[FieldOffset(Offset = "0xC0")]
		public SliderBehaviour _20Sensitivity;

		// Token: 0x040038FF RID: 14591
		[Token(Token = "0x40038FF")]
		[FieldOffset(Offset = "0xC8")]
		public SliderBehaviour _40Sensitivity;

		// Token: 0x02000772 RID: 1906
		[Token(Token = "0x2000772")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <GetEnumerator>d__0 : IEnumerator<IOptionsElement>, IEnumerator, IDisposable
		{
			// Token: 0x06013AF6 RID: 80630 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013AF6")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <GetEnumerator>d__0(int <>1__state)
			{
			}

			// Token: 0x06013AF7 RID: 80631 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013AF7")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013AF8 RID: 80632 RVA: 0x0007D0CC File Offset: 0x0007B2CC
			[Token(Token = "0x6013AF8")]
			[Address(RVA = "0x1698D30", Offset = "0x1698130", VA = "0x181698D30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x06013AF9 RID: 80633 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B95")]
			private IOptionsElement Current
			{
				[Token(Token = "0x6013AF9")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013AFA RID: 80634 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013AFA")]
			[Address(RVA = "0x1699260", Offset = "0x1698660", VA = "0x181699260", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x06013AFB RID: 80635 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B96")]
			private object Current
			{
				[Token(Token = "0x6013AFB")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04003900 RID: 14592
			[Token(Token = "0x4003900")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04003901 RID: 14593
			[Token(Token = "0x4003901")]
			[FieldOffset(Offset = "0x18")]
			private IOptionsElement <>2__current;

			// Token: 0x04003902 RID: 14594
			[Token(Token = "0x4003902")]
			[FieldOffset(Offset = "0x20")]
			public MenuControllers <>4__this;
		}
	}
}
