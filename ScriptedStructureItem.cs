using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x0200008E RID: 142
[Token(Token = "0x200008E")]
public class ScriptedStructureItem : ScriptableObject
{
	// Token: 0x0600183C RID: 6204 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x1C93870", Offset = "0x1C92C70", VA = "0x181C93870")]
	public ScriptedStructureItem()
	{
	}

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x17CC80", Offset = "0x17C080")]
	public AnimationCurve Animation;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x17CCE0", Offset = "0x17C0E0")]
	public float FallTime;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x24")]
	public float ParticlesPlayDelay;

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x17CD40", Offset = "0x17C140")]
	public AudioClip EarthRumble;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip Sound;

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip[] ImpactSound;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x17CDF0", Offset = "0x17C1F0")]
	public AnimationCurve ScreenShakeAnimation;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve ScreenShakeRadiusAnimation;
}
