using System;
using touching_your_mom;
using UnityEngine;

namespace Character.Skin
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	public abstract class ASkin : ScriptableObject
	{
		// Token: 0x06011952 RID: 72018 RVA: 0x0006A964 File Offset: 0x00068B64
		[Token(Token = "0x6011952")]
		[Address(RVA = "0x9932B0", Offset = "0x9926B0", VA = "0x1809932B0", Slot = "4")]
		public virtual \u0301\u0305\u0302\u0307\u0304\u0301\u0304\u0302\u0305\u0304\u0305\u0301\u0304\u0303\u0308 \u0308\u0305\u0306\u0305\u0303\u0304\u0304\u0308\u0301\u0301\u0306\u0307\u0306\u0303\u0302()
		{
			return \u0301\u0305\u0302\u0307\u0304\u0301\u0304\u0302\u0305\u0304\u0305\u0301\u0304\u0303\u0308.Skin;
		}

		// Token: 0x06011953 RID: 72019 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011953")]
		[Address(RVA = "0x3719680", Offset = "0x3718A80", VA = "0x183719680")]
		public string \u0306\u0304\u0305\u0303\u0307\u0307\u0305\u0302\u0308\u0302\u0302\u0301\u0302\u0301\u0301()
		{
			return null;
		}

		// Token: 0x06011954 RID: 72020 RVA: 0x0006A97C File Offset: 0x00068B7C
		[Token(Token = "0x6011954")]
		[Address(RVA = "0x3719610", Offset = "0x3718A10", VA = "0x183719610", Slot = "5")]
		public virtual bool \u0302\u0303\u0305\u0306\u0304\u0308\u0304\u0302\u0301\u0304\u0304\u0305\u0308\u0306\u0308()
		{
			return default(bool);
		}

		// Token: 0x06011955 RID: 72021 RVA: 0x0006A994 File Offset: 0x00068B94
		[Token(Token = "0x6011955")]
		[Address(RVA = "0x3719630", Offset = "0x3718A30", VA = "0x183719630", Slot = "6")]
		public virtual Vector2Int \u0302\u0305\u0306\u0304\u0307\u0308\u0308\u0305\u0306\u0305\u0308\u0305\u0305\u0307\u0307()
		{
			return default(Vector2Int);
		}

		// Token: 0x06011956 RID: 72022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011956")]
		[Address(RVA = "0x3719730", Offset = "0x3718B30", VA = "0x183719730")]
		protected ASkin()
		{
		}

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public int ID;

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		public int InstanceID;

		// Token: 0x04003045 RID: 12357
		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x20")]
		public int LanguageID;

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x28")]
		public Avaibility Permissions;

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D PrimaryAsset;
	}
}
