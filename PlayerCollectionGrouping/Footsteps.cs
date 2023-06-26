using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

namespace PlayerCollectionGrouping
{
	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	[Serializable]
	public class Footsteps
	{
		// Token: 0x06013E61 RID: 81505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E61")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Footsteps()
		{
		}

		// Token: 0x04003E32 RID: 15922
		[Token(Token = "0x4003E32")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<PhysicMaterial, AGround> MaterialToGround;

		// Token: 0x04003E33 RID: 15923
		[Token(Token = "0x4003E33")]
		[FieldOffset(Offset = "0x10")]
		public AGround[] Grounds;

		// Token: 0x04003E34 RID: 15924
		[Token(Token = "0x4003E34")]
		[FieldOffset(Offset = "0x18")]
		public AGround VehicleMetal;

		// Token: 0x04003E35 RID: 15925
		[Token(Token = "0x4003E35")]
		[FieldOffset(Offset = "0x20")]
		public AGround Concrete;
	}
}
