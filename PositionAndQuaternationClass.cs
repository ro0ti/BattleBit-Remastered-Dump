using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x0200017F RID: 383
[Token(Token = "0x200017F")]
[Serializable]
public class PositionAndQuaternationClass
{
	// Token: 0x06003EB3 RID: 16051 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003EB3")]
	[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
	public PositionAndQuaternationClass()
	{
	}

	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 Position;

	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion Rotation;
}
