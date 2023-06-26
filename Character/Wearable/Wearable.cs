using System;
using touching_your_mom;
using UnityEngine;

namespace Character.Wearable
{
	// Token: 0x0200065D RID: 1629
	[Token(Token = "0x200065D")]
	public abstract class Wearable : ScriptableObject
	{
		// Token: 0x0601170D RID: 71437 RVA: 0x000688F4 File Offset: 0x00066AF4
		[Token(Token = "0x601170D")]
		[Address(RVA = "0x902FF0", Offset = "0x9023F0", VA = "0x180902FF0", Slot = "4")]
		public virtual bool \u0301\u0307\u0307\u0305\u0303\u0307\u0308\u0303\u0304\u0304\u0306\u0307\u0301\u0306\u0307()
		{
			return default(bool);
		}

		// Token: 0x0601170E RID: 71438 RVA: 0x0006890C File Offset: 0x00066B0C
		[Token(Token = "0x601170E")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0", Slot = "5")]
		public virtual \u0301\u0301\u0303\u0303\u0301\u0302\u0308\u0307\u0308\u0301\u0302\u0302\u0304\u0306\u0301 \u0305\u0301\u0308\u0304\u0307\u0306\u0301\u0305\u0308\u0303\u0304\u0302\u0307\u0307\u0308()
		{
			return \u0301\u0301\u0303\u0303\u0301\u0302\u0308\u0307\u0308\u0301\u0302\u0302\u0304\u0306\u0301.Head;
		}

		// Token: 0x0601170F RID: 71439 RVA: 0x00068924 File Offset: 0x00066B24
		[Token(Token = "0x601170F")]
		[Address(RVA = "0x902FF0", Offset = "0x9023F0", VA = "0x180902FF0", Slot = "6")]
		public virtual \u0308\u0305\u0303\u0306\u0302\u0305\u0302\u0307\u0304\u0301\u0304\u0301\u0307\u0301\u0305 \u0306\u0306\u0305\u0302\u0307\u0308\u0304\u0306\u0301\u0307\u0308\u0302\u0302\u0305\u0306()
		{
			return \u0308\u0305\u0303\u0306\u0302\u0305\u0302\u0307\u0304\u0301\u0304\u0301\u0307\u0301\u0305.None;
		}

		// Token: 0x06011710 RID: 71440 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011710")]
		[Address(RVA = "0x3731EE0", Offset = "0x37312E0", VA = "0x183731EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06011711 RID: 71441 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011711")]
		[Address(RVA = "0x3731F50", Offset = "0x3731350", VA = "0x183731F50")]
		public static Wearable \u0301\u0303\u0308\u0304\u0302\u0303\u0308\u0307\u0306\u0307\u0307\u0305\u0305\u0306\u0302(int \u0302\u0303\u0305\u0302\u0308\u0303\u0307\u0306\u0304\u0307\u0303\u0301\u0305\u0308\u0305)
		{
			return null;
		}

		// Token: 0x06011712 RID: 71442 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011712")]
		[Address(RVA = "0x3732010", Offset = "0x3731410", VA = "0x183732010", Slot = "7")]
		public virtual string \u0306\u0304\u0305\u0303\u0307\u0307\u0305\u0302\u0308\u0302\u0302\u0301\u0302\u0301\u0301()
		{
			return null;
		}

		// Token: 0x06011713 RID: 71443 RVA: 0x0006893C File Offset: 0x00066B3C
		[Token(Token = "0x6011713")]
		[Address(RVA = "0x3731FF0", Offset = "0x37313F0", VA = "0x183731FF0", Slot = "8")]
		public virtual bool \u0302\u0303\u0305\u0306\u0304\u0308\u0304\u0302\u0301\u0304\u0304\u0305\u0308\u0306\u0308()
		{
			return default(bool);
		}

		// Token: 0x06011714 RID: 71444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011714")]
		[Address(RVA = "0x3732100", Offset = "0x3731500", VA = "0x183732100")]
		protected Wearable()
		{
		}

		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public int ID;

		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		public int InstanceID;

		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		[FieldOffset(Offset = "0x20")]
		public string DisplayName;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x28")]
		public int LanguageID;

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[FieldOffset(Offset = "0x30")]
		public Avaibility Permissions;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Prefab;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0x40")]
		public WearableStats Stats;
	}
}
