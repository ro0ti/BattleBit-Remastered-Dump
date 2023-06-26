using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x02000146 RID: 326
[Token(Token = "0x2000146")]
[Serializable]
public struct mBuildableInstance
{
	// Token: 0x0400083F RID: 2111
	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x0")]
	public string PrefabName;

	// Token: 0x04000840 RID: 2112
	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 Position;

	// Token: 0x04000841 RID: 2113
	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x14")]
	public Quaternion Rotation;

	// Token: 0x04000842 RID: 2114
	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x24")]
	public float HP;
}
