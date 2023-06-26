using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x020002D6 RID: 726
[Token(Token = "0x20002D6")]
[Serializable]
public class ToolThpOffsets
{
	// Token: 0x06008204 RID: 33284 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6008204")]
	[Address(RVA = "0x24FB880", Offset = "0x24FAC80", VA = "0x1824FB880")]
	public ToolThpOffsets()
	{
	}

	// Token: 0x04001456 RID: 5206
	[Token(Token = "0x4001456")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x153590", Offset = "0x152990")]
	public bool DisableOnPacked;

	// Token: 0x04001457 RID: 5207
	[Token(Token = "0x4001457")]
	[FieldOffset(Offset = "0x14")]
	public ToolThpOffsets.PackedPosition Position;

	// Token: 0x04001458 RID: 5208
	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0x18")]
	public ToolThpOffsets.Offset Packad;

	// Token: 0x04001459 RID: 5209
	[Token(Token = "0x4001459")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x153670", Offset = "0x152A70")]
	public ToolThpOffsets.Offset UseDefault;

	// Token: 0x0400145A RID: 5210
	[Token(Token = "0x400145A")]
	[FieldOffset(Offset = "0x28")]
	public ToolThpOffsets.Offset UseAimdown;

	// Token: 0x0400145B RID: 5211
	[Token(Token = "0x400145B")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1536F0", Offset = "0x152AF0")]
	public bool RotateHeadOnAim;

	// Token: 0x0400145C RID: 5212
	[Token(Token = "0x400145C")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x154C90", Offset = "0x154090")]
	public float ThirdPersonScale;

	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	[Serializable]
	public enum PackedPosition
	{
		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		OnSpine,
		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		OnBelt
	}

	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	[Serializable]
	public class Offset
	{
		// Token: 0x06008205 RID: 33285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6008205")]
		[Address(RVA = "0x24FB840", Offset = "0x24FAC40", VA = "0x1824FB840")]
		public Offset(Vector3 \u0305\u0301\u0302\u0304\u0306\u0302\u0305\u0306\u0307\u0308\u0304\u0305\u0301\u0303\u0308)
		{
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6008206")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Offset()
		{
		}

		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Rotation;
	}
}
