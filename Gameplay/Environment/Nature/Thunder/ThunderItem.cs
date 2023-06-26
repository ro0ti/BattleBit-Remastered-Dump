using System;
using touching_your_mom;
using UnityEngine;

namespace Gameplay.Environment.Nature.Thunder
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	public class ThunderItem : ScriptableObject
	{
		// Token: 0x06013978 RID: 80248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013978")]
		[Address(RVA = "0x256F6D0", Offset = "0x256EAD0", VA = "0x18256F6D0")]
		public ThunderItem()
		{
		}

		// Token: 0x04003741 RID: 14145
		[Token(Token = "0x4003741")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public byte NetworkID;

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip Sound;

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x28")]
		public float Delay;

		// Token: 0x04003744 RID: 14148
		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve Lighting;

		// Token: 0x04003745 RID: 14149
		[Token(Token = "0x4003745")]
		[FieldOffset(Offset = "0x38")]
		public float DirectionLightIntensity;

		// Token: 0x04003746 RID: 14150
		[Token(Token = "0x4003746")]
		[FieldOffset(Offset = "0x3C")]
		public float SkyExpesureIntensity;
	}
}
