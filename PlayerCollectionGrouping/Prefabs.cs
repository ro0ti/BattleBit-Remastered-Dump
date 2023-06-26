using System;
using touching_your_mom;
using UnityEngine;

namespace PlayerCollectionGrouping
{
	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	[Serializable]
	public class Prefabs
	{
		// Token: 0x06013EE4 RID: 81636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013EE4")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public Prefabs()
		{
		}

		// Token: 0x04003E77 RID: 15991
		[Token(Token = "0x4003E77")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17C680", Offset = "0x17BA80")]
		public GameObject Player;

		// Token: 0x04003E78 RID: 15992
		[Token(Token = "0x4003E78")]
		[FieldOffset(Offset = "0x18")]
		public GameObject OfflinePlayer;

		// Token: 0x04003E79 RID: 15993
		[Token(Token = "0x4003E79")]
		[FieldOffset(Offset = "0x20")]
		public GameObject FirstPerson;

		// Token: 0x04003E7A RID: 15994
		[Token(Token = "0x4003E7A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ThirdPerson;

		// Token: 0x04003E7B RID: 15995
		[Token(Token = "0x4003E7B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ThirdPersonRagdoll;

		// Token: 0x04003E7C RID: 15996
		[Token(Token = "0x4003E7C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182F30", Offset = "0x182330")]
		public GameObject SafeSpawn;

		// Token: 0x04003E7D RID: 15997
		[Token(Token = "0x4003E7D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Bound;

		// Token: 0x04003E7E RID: 15998
		[Token(Token = "0x4003E7E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BuildingAudioSource;

		// Token: 0x04003E7F RID: 15999
		[Token(Token = "0x4003E7F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject StructureDebris;

		// Token: 0x04003E80 RID: 16000
		[Token(Token = "0x4003E80")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x166730", Offset = "0x165B30")]
		public Mesh ThpBodyMesh;

		// Token: 0x04003E81 RID: 16001
		[Token(Token = "0x4003E81")]
		[FieldOffset(Offset = "0x60")]
		public AGround Concrete;

		// Token: 0x04003E82 RID: 16002
		[Token(Token = "0x4003E82")]
		[FieldOffset(Offset = "0x68")]
		public AGround Water;

		// Token: 0x04003E83 RID: 16003
		[Token(Token = "0x4003E83")]
		[FieldOffset(Offset = "0x70")]
		public AGround Wood;

		// Token: 0x04003E84 RID: 16004
		[Token(Token = "0x4003E84")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SteeringWheelFP;

		// Token: 0x04003E85 RID: 16005
		[Token(Token = "0x4003E85")]
		[FieldOffset(Offset = "0x80")]
		public GameObject SpecCamera;

		// Token: 0x04003E86 RID: 16006
		[Token(Token = "0x4003E86")]
		[FieldOffset(Offset = "0x88")]
		public GameObject SpecModelCamera;

		// Token: 0x04003E87 RID: 16007
		[Token(Token = "0x4003E87")]
		[FieldOffset(Offset = "0x90")]
		public GameObject BladeMetalImpact;

		// Token: 0x04003E88 RID: 16008
		[Token(Token = "0x4003E88")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183060", Offset = "0x182460")]
		public GameObject Rope;

		// Token: 0x04003E89 RID: 16009
		[Token(Token = "0x4003E89")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ZiplineRope;
	}
}
