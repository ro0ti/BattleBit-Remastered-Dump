using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x0200017E RID: 382
[Token(Token = "0x200017E")]
[Serializable]
public struct PositionQuaternationScale
{
	// Token: 0x06003EB2 RID: 16050 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003EB2")]
	[Address(RVA = "0x1AF4000", Offset = "0x1AF3400", VA = "0x181AF4000")]
	public PositionQuaternationScale(Transform \u0303\u0307\u0304\u0307\u0301\u0308\u0305\u0305\u0303\u0305\u0301\u0307\u0307\u0307\u0302)
	{
	}

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 Position;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0xC")]
	public Quaternion Rotation;

	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 Scale;
}
