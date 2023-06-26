using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerCollectionGrouping
{
	// Token: 0x02000801 RID: 2049
	[Token(Token = "0x2000801")]
	[Serializable]
	public class Collection
	{
		// Token: 0x06013EEB RID: 81643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EEB")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Collection()
		{
		}

		// Token: 0x04003E9D RID: 16029
		[Token(Token = "0x4003E9D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183270", Offset = "0x182670")]
		public DebrisSoundCollection DebrisMetalLow;

		// Token: 0x04003E9E RID: 16030
		[Token(Token = "0x4003E9E")]
		[FieldOffset(Offset = "0x18")]
		public DebrisSoundCollection DebrisMetalMedium;

		// Token: 0x04003E9F RID: 16031
		[Token(Token = "0x4003E9F")]
		[FieldOffset(Offset = "0x20")]
		public DebrisSoundCollection DebrisMetalHigh;

		// Token: 0x04003EA0 RID: 16032
		[Token(Token = "0x4003EA0")]
		[FieldOffset(Offset = "0x28")]
		public DebrisSoundCollection DebrisWoodLow;

		// Token: 0x04003EA1 RID: 16033
		[Token(Token = "0x4003EA1")]
		[FieldOffset(Offset = "0x30")]
		public DebrisSoundCollection DebrisWoodMedium;

		// Token: 0x04003EA2 RID: 16034
		[Token(Token = "0x4003EA2")]
		[FieldOffset(Offset = "0x38")]
		public DebrisSoundCollection DebrisWoodHigh;

		// Token: 0x04003EA3 RID: 16035
		[Token(Token = "0x4003EA3")]
		[FieldOffset(Offset = "0x40")]
		public DebrisSoundCollection DebrisConcreteLow;

		// Token: 0x04003EA4 RID: 16036
		[Token(Token = "0x4003EA4")]
		[FieldOffset(Offset = "0x48")]
		public DebrisSoundCollection DebrisConcreteMedium;

		// Token: 0x04003EA5 RID: 16037
		[Token(Token = "0x4003EA5")]
		[FieldOffset(Offset = "0x50")]
		public DebrisSoundCollection DebrisConcreteHigh;

		// Token: 0x04003EA6 RID: 16038
		[Token(Token = "0x4003EA6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183350", Offset = "0x182750")]
		public TextAsset MuteWords;
	}
}
