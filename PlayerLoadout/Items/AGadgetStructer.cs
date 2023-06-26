using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

namespace PlayerLoadout.Items
{
	// Token: 0x02000687 RID: 1671
	[Token(Token = "0x2000687")]
	public class AGadgetStructer : ScriptableObject
	{
		// Token: 0x06012072 RID: 73842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012072")]
		[Address(RVA = "0x3193A40", Offset = "0x3192E40", VA = "0x183193A40")]
		public AGadgetStructer()
		{
		}

		// Token: 0x04003153 RID: 12627
		[Token(Token = "0x4003153")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<Field> fields;
	}
}
