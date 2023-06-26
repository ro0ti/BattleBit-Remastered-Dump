using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UserInterface.PauseMenu.Options;
using UserInterface.PauseMenu.Options.Behaviours;

namespace UserInterface.PauseMenu
{
	// Token: 0x02000779 RID: 1913
	[Token(Token = "0x2000779")]
	[Serializable]
	public class MenuAccounts : IEnumerable<IOptionsElement>, IEnumerable
	{
		// Token: 0x06013B1D RID: 80669 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B1D")]
		[Address(RVA = "0x16890D0", Offset = "0x16884D0", VA = "0x1816890D0", Slot = "4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x169F50", Offset = "0x169350")]
		public IEnumerator<IOptionsElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013B1E RID: 80670 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013B1E")]
		[Address(RVA = "0x16890D0", Offset = "0x16884D0", VA = "0x1816890D0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06013B1F RID: 80671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B1F")]
		[Address(RVA = "0x1688D70", Offset = "0x1688170", VA = "0x181688D70")]
		public void ApplyToSettings()
		{
		}

		// Token: 0x06013B20 RID: 80672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B20")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public MenuAccounts()
		{
		}

		// Token: 0x0400399E RID: 14750
		[Token(Token = "0x400399E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x169EA0", Offset = "0x1692A0")]
		public ToggleBehaviour StreamerMode;

		// Token: 0x0400399F RID: 14751
		[Token(Token = "0x400399F")]
		[FieldOffset(Offset = "0x18")]
		public ToggleBehaviour ShowServerName;

		// Token: 0x040039A0 RID: 14752
		[Token(Token = "0x40039A0")]
		[FieldOffset(Offset = "0x20")]
		public ToggleBehaviour ShowFriendNames;

		// Token: 0x040039A1 RID: 14753
		[Token(Token = "0x40039A1")]
		[FieldOffset(Offset = "0x28")]
		public ToggleBehaviour FriendVoiceChat;

		// Token: 0x040039A2 RID: 14754
		[Token(Token = "0x40039A2")]
		[FieldOffset(Offset = "0x30")]
		public ToggleBehaviour ShowClanFriendNames;

		// Token: 0x040039A3 RID: 14755
		[Token(Token = "0x40039A3")]
		[FieldOffset(Offset = "0x38")]
		public ToggleBehaviour ClanFriendVoiceChat;

		// Token: 0x040039A4 RID: 14756
		[Token(Token = "0x40039A4")]
		[FieldOffset(Offset = "0x40")]
		public ToggleBehaviour ShowPartyFriendNames;

		// Token: 0x040039A5 RID: 14757
		[Token(Token = "0x40039A5")]
		[FieldOffset(Offset = "0x48")]
		public ToggleBehaviour PartyFriendVoiceChat;

		// Token: 0x040039A6 RID: 14758
		[Token(Token = "0x40039A6")]
		[FieldOffset(Offset = "0x50")]
		public ToggleBehaviour ShowProfilePictures;

		// Token: 0x040039A7 RID: 14759
		[Token(Token = "0x40039A7")]
		[FieldOffset(Offset = "0x58")]
		public ToggleBehaviour ShowNonRelativePersonUsernames;

		// Token: 0x040039A8 RID: 14760
		[Token(Token = "0x40039A8")]
		[FieldOffset(Offset = "0x60")]
		public ToggleBehaviour NonRelativePersonVoiceChat;

		// Token: 0x040039A9 RID: 14761
		[Token(Token = "0x40039A9")]
		[FieldOffset(Offset = "0x68")]
		public ToggleBehaviour ShowSquadNames;

		// Token: 0x0200077A RID: 1914
		[Token(Token = "0x200077A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <GetEnumerator>d__0 : IEnumerator<IOptionsElement>, IEnumerator, IDisposable
		{
			// Token: 0x06013B21 RID: 80673 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B21")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <GetEnumerator>d__0(int <>1__state)
			{
			}

			// Token: 0x06013B22 RID: 80674 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B22")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013B23 RID: 80675 RVA: 0x0007D15C File Offset: 0x0007B35C
			[Token(Token = "0x6013B23")]
			[Address(RVA = "0x1698A80", Offset = "0x1697E80", VA = "0x181698A80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B9D RID: 2973
			// (get) Token: 0x06013B24 RID: 80676 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B9D")]
			private IOptionsElement Current
			{
				[Token(Token = "0x6013B24")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013B25 RID: 80677 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013B25")]
			[Address(RVA = "0x16992B0", Offset = "0x16986B0", VA = "0x1816992B0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B9E RID: 2974
			// (get) Token: 0x06013B26 RID: 80678 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B9E")]
			private object Current
			{
				[Token(Token = "0x6013B26")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040039AA RID: 14762
			[Token(Token = "0x40039AA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040039AB RID: 14763
			[Token(Token = "0x40039AB")]
			[FieldOffset(Offset = "0x18")]
			private IOptionsElement <>2__current;

			// Token: 0x040039AC RID: 14764
			[Token(Token = "0x40039AC")]
			[FieldOffset(Offset = "0x20")]
			public MenuAccounts <>4__this;
		}
	}
}
