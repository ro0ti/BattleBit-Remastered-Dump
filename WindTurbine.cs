using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x02000153 RID: 339
[Token(Token = "0x2000153")]
public class WindTurbine : ScriptedStructure
{
	// Token: 0x060039C9 RID: 14793 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60039C9")]
	[Address(RVA = "0x28CB430", Offset = "0x28CA830", VA = "0x1828CB430", Slot = "7")]
	public override void Awake()
	{
	}

	// Token: 0x060039CA RID: 14794 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60039CA")]
	[Address(RVA = "0x28CB720", Offset = "0x28CAB20", VA = "0x1828CB720", Slot = "11")]
	public override void OnLateUpdateEnd()
	{
	}

	// Token: 0x060039CB RID: 14795 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60039CB")]
	[Address(RVA = "0x28CB540", Offset = "0x28CA940", VA = "0x1828CB540", Slot = "12")]
	public override void OnClientThreadUpdate()
	{
	}

	// Token: 0x060039CC RID: 14796 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60039CC")]
	[Address(RVA = "0x28CB970", Offset = "0x28CAD70", VA = "0x1828CB970", Slot = "15")]
	public override void ResetState()
	{
	}

	// Token: 0x060039CD RID: 14797 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60039CD")]
	[Address(RVA = "0x28CB990", Offset = "0x28CAD90", VA = "0x1828CB990")]
	public WindTurbine()
	{
	}

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x142850", Offset = "0x141C50")]
	public float Sound_RPM;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0xD4")]
	public Vector2 MinMaxRPM;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1428C0", Offset = "0x141CC0")]
	public Transform Blade;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x142A10", Offset = "0x141E10")]
	public AudioSource EngineAudioSource;

	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0xF0")]
	public AudioSource WindAudioSource;

	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0xF8")]
	private float mRPMSpeed;

	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0xFC")]
	private float mOffset;

	// Token: 0x04000891 RID: 2193
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x100")]
	private float mBladeRotation;

	// Token: 0x04000892 RID: 2194
	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x104")]
	private float mBladeRotationFallState;

	// Token: 0x04000893 RID: 2195
	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x108")]
	private float mBladeRotationFallStateStart;

	// Token: 0x04000894 RID: 2196
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x10C")]
	private bool mAudioShouldEnabled;

	// Token: 0x04000895 RID: 2197
	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x10D")]
	private bool mAudioEnabled;
}
