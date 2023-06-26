using System;
using touching_your_mom;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public class DropItem : ScriptableObject
{
	// Token: 0x060017F5 RID: 6133 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x9210C0", Offset = "0x9204C0", VA = "0x1809210C0")]
	public DropItem()
	{
	}

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D Texture;

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x20")]
	public string DisplayName;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x28")]
	public string Description;
}
