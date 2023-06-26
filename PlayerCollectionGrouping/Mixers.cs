using System;
using touching_your_mom;
using UnityEngine.Audio;

namespace PlayerCollectionGrouping
{
	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	[Serializable]
	public class Mixers
	{
		// Token: 0x06013EDA RID: 81626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EDA")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Mixers()
		{
		}

		// Token: 0x04003E3E RID: 15934
		[Token(Token = "0x4003E3E")]
		[FieldOffset(Offset = "0x10")]
		public AudioMixer Main;

		// Token: 0x04003E3F RID: 15935
		[Token(Token = "0x4003E3F")]
		[FieldOffset(Offset = "0x18")]
		public AudioMixerGroup Voip;

		// Token: 0x04003E40 RID: 15936
		[Token(Token = "0x4003E40")]
		[FieldOffset(Offset = "0x20")]
		public AudioMixerGroup Ambient;
	}
}
