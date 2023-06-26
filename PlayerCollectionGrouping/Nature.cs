using System;
using Gameplay.Environment.Nature.Thunder;
using touching_your_mom;

namespace PlayerCollectionGrouping
{
	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	[Serializable]
	public class Nature
	{
		// Token: 0x06013EE8 RID: 81640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EE8")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Nature()
		{
		}

		// Token: 0x04003E95 RID: 16021
		[Token(Token = "0x4003E95")]
		[FieldOffset(Offset = "0x10")]
		public Nature.Thunder NatureThunder;

		// Token: 0x020007FF RID: 2047
		[Token(Token = "0x20007FF")]
		[Serializable]
		public class Thunder
		{
			// Token: 0x06013EE9 RID: 81641 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013EE9")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Thunder()
			{
			}

			// Token: 0x04003E96 RID: 16022
			[Token(Token = "0x4003E96")]
			[FieldOffset(Offset = "0x10")]
			public ThunderItem[] Thunders;
		}
	}
}
