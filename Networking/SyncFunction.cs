using System;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006BA RID: 1722
	[Token(Token = "0x20006BA")]
	public class SyncFunction : IComparable<SyncFunction>
	{
		// Token: 0x06012822 RID: 75810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012822")]
		[Address(RVA = "0x1647420", Offset = "0x1646820", VA = "0x181647420")]
		public SyncFunction(\u0302\u0305\u0302\u0306\u0308\u0308\u0302\u0308\u0303\u0304\u0308\u0304\u0307\u0308\u0302 view, string prefabName, ushort ID, Action<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> OnWrite, Action<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> OnRead, \u0308\u0304\u0303\u0306\u0307\u0305\u0302\u0308\u0301\u0301\u0304\u0304\u0302\u0306\u0305 Order, Type type)
		{
		}

		// Token: 0x06012823 RID: 75811 RVA: 0x00073D24 File Offset: 0x00071F24
		[Token(Token = "0x6012823")]
		[Address(RVA = "0x16473F0", Offset = "0x16467F0", VA = "0x1816473F0", Slot = "4")]
		public int CompareTo(SyncFunction other)
		{
			return 0;
		}

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x10")]
		public string PrefabName;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x18")]
		public \u0302\u0305\u0302\u0306\u0308\u0308\u0302\u0308\u0303\u0304\u0308\u0304\u0307\u0308\u0302 view;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x20")]
		public string Hash;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x28")]
		public \u0308\u0304\u0303\u0306\u0307\u0305\u0302\u0308\u0301\u0301\u0304\u0304\u0302\u0306\u0305 Order;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x30")]
		public Action<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> OnWrite;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x38")]
		public Action<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> OnRead;
	}
}
