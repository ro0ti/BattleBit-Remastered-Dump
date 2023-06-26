using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UserInterface.PauseMenu.Options;
using UserInterface.PauseMenu.Options.Behaviours;

namespace UserInterface.PauseMenu
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	[Serializable]
	public class MenuAudio : IEnumerable<IOptionsElement>, IEnumerable
	{
		// Token: 0x06013B06 RID: 80646 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B06")]
		[Address(RVA = "0x1689A00", Offset = "0x1688E00", VA = "0x181689A00", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x169270", Offset = "0x168670")]
		public IEnumerator<IOptionsElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013B07 RID: 80647 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B07")]
		[Address(RVA = "0x1689A00", Offset = "0x1688E00", VA = "0x181689A00", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013B08 RID: 80648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B08")]
		[Address(RVA = "0x16891C0", Offset = "0x16885C0", VA = "0x1816891C0")]
		public void ApplyToSettings()
		{
		}

		// Token: 0x06013B09 RID: 80649 RVA: 0x0007D0FC File Offset: 0x0007B2FC
		[Token(Token = "0x6013B09")]
		[Address(RVA = "0x1689140", Offset = "0x1688540", VA = "0x181689140")]
		private static float AmplitudeTodB(float amplitude)
		{
			return 0f;
		}

		// Token: 0x06013B0A RID: 80650 RVA: 0x0007D114 File Offset: 0x0007B314
		[Token(Token = "0x6013B0A")]
		[Address(RVA = "0x1689A70", Offset = "0x1688E70", VA = "0x181689A70")]
		private static float dBToAmplitude(float dB)
		{
			return 0f;
		}

		// Token: 0x06013B0B RID: 80651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B0B")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public MenuAudio()
		{
		}

		// Token: 0x04003966 RID: 14694
		[Token(Token = "0x4003966")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x168F90", Offset = "0x168390")]
		public SliderBehaviour Master;

		// Token: 0x04003967 RID: 14695
		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0x18")]
		public SliderBehaviour Game;

		// Token: 0x04003968 RID: 14696
		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x20")]
		public SliderBehaviour Music;

		// Token: 0x04003969 RID: 14697
		[Token(Token = "0x4003969")]
		[FieldOffset(Offset = "0x28")]
		public SliderBehaviour Speech;

		// Token: 0x0400396A RID: 14698
		[Token(Token = "0x400396A")]
		[FieldOffset(Offset = "0x30")]
		public SliderBehaviour Ambient;

		// Token: 0x0400396B RID: 14699
		[Token(Token = "0x400396B")]
		[FieldOffset(Offset = "0x38")]
		public SliderBehaviour KillSoundVolume;

		// Token: 0x0400396C RID: 14700
		[Token(Token = "0x400396C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169060", Offset = "0x168460")]
		public ToggleBehaviour OptVoiceChat;

		// Token: 0x0400396D RID: 14701
		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x48")]
		public SliderBehaviour MasterVoipVolume;

		// Token: 0x0400396E RID: 14702
		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x50")]
		public SliderBehaviour SteamFriendVoipVolume;

		// Token: 0x0400396F RID: 14703
		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x58")]
		public SliderBehaviour PartyFriendVoipVolume;

		// Token: 0x04003970 RID: 14704
		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x60")]
		public SliderBehaviour ClanFriendVoipVolume;

		// Token: 0x04003971 RID: 14705
		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x68")]
		public SliderBehaviour SquadLeaderVoipVolume;

		// Token: 0x04003972 RID: 14706
		[Token(Token = "0x4003972")]
		[FieldOffset(Offset = "0x70")]
		public SliderBehaviour SquadFriendVoipVolume;

		// Token: 0x04003973 RID: 14707
		[Token(Token = "0x4003973")]
		[FieldOffset(Offset = "0x78")]
		public SliderBehaviour TeammateVoipVolume;

		// Token: 0x04003974 RID: 14708
		[Token(Token = "0x4003974")]
		[FieldOffset(Offset = "0x80")]
		public SliderBehaviour EnemyVoipVolume;

		// Token: 0x04003975 RID: 14709
		[Token(Token = "0x4003975")]
		[FieldOffset(Offset = "0x88")]
		public ToggleBehaviour EnableLocalVoiceChatWhenDown;

		// Token: 0x04003976 RID: 14710
		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169160", Offset = "0x168560")]
		public MicDeviceBehaviour MicDevice;

		// Token: 0x04003977 RID: 14711
		[Token(Token = "0x4003977")]
		[FieldOffset(Offset = "0x98")]
		public SliderBehaviour MicVolume;

		// Token: 0x04003978 RID: 14712
		[Token(Token = "0x4003978")]
		[FieldOffset(Offset = "0xA0")]
		public EnumBehaviour AudioChannels;

		// Token: 0x02000776 RID: 1910
		[Token(Token = "0x2000776")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <GetEnumerator>d__0 : IEnumerator<IOptionsElement>, IEnumerator, IDisposable
		{
			// Token: 0x06013B0C RID: 80652 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B0C")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <GetEnumerator>d__0(int <>1__state)
			{
			}

			// Token: 0x06013B0D RID: 80653 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B0D")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013B0E RID: 80654 RVA: 0x0007D12C File Offset: 0x0007B32C
			[Token(Token = "0x6013B0E")]
			[Address(RVA = "0x1698660", Offset = "0x1697A60", VA = "0x181698660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B99 RID: 2969
			// (get) Token: 0x06013B0F RID: 80655 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B99")]
			private IOptionsElement Current
			{
				[Token(Token = "0x6013B0F")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013B10 RID: 80656 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B10")]
			[Address(RVA = "0x1699300", Offset = "0x1698700", VA = "0x181699300", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B9A RID: 2970
			// (get) Token: 0x06013B11 RID: 80657 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B9A")]
			private object Current
			{
				[Token(Token = "0x6013B11")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04003979 RID: 14713
			[Token(Token = "0x4003979")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400397A RID: 14714
			[Token(Token = "0x400397A")]
			[FieldOffset(Offset = "0x18")]
			private IOptionsElement <>2__current;

			// Token: 0x0400397B RID: 14715
			[Token(Token = "0x400397B")]
			[FieldOffset(Offset = "0x20")]
			public MenuAudio <>4__this;
		}
	}
}
