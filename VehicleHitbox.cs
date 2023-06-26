using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x02000327 RID: 807
[Token(Token = "0x2000327")]
[Serializable]
public class VehicleHitbox
{
	// Token: 0x06008FDA RID: 36826 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6008FDA")]
	[Address(RVA = "0x1834CE0", Offset = "0x18340E0", VA = "0x181834CE0")]
	public VehicleHitbox()
	{
	}

	// Token: 0x04001715 RID: 5909
	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x10")]
	public Bounds Bounds;

	// Token: 0x04001716 RID: 5910
	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x28")]
	public float DamageMultiplier;
}
