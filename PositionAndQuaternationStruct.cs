using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
[Serializable]
public struct PositionAndQuaternationStruct
{
	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 Position;

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0xC")]
	public Quaternion Rotation;
}
