using System;
using touching_your_mom;
using UnityEngine;

namespace TerrainSound
{
	// Token: 0x020007E9 RID: 2025
	[Token(Token = "0x20007E9")]
	[Serializable]
	public class TerrianLayerSound
	{
		// Token: 0x06013E36 RID: 81462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E36")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public TerrianLayerSound()
		{
		}

		// Token: 0x04003DDE RID: 15838
		[Token(Token = "0x4003DDE")]
		[FieldOffset(Offset = "0x10")]
		public TerrainLayer Layer;

		// Token: 0x04003DDF RID: 15839
		[Token(Token = "0x4003DDF")]
		[FieldOffset(Offset = "0x18")]
		public PhysicMaterial Material;
	}
}
