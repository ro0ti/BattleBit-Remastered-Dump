using System;
using touching_your_mom;
using PlayerLoadout.Items;
using UnityEngine;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
public class GungameList : ScriptableObject
{
	// Token: 0x0600164C RID: 5708 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600164C")]
	[Address(RVA = "0x9210C0", Offset = "0x9204C0", VA = "0x1809210C0")]
	public GungameList()
	{
	}

	// Token: 0x04000339 RID: 825
	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public ushort RuntimeID;

	// Token: 0x0400033A RID: 826
	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x20")]
	public GungameList.Step[] Steps;

	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[Serializable]
	public struct Step : IEquatable<GungameList.Step>
	{
		// Token: 0x0600164D RID: 5709 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x1781560", Offset = "0x1780960", VA = "0x181781560")]
		public ToolItem \u0302\u0305\u0302\u0307\u0302\u0303\u0301\u0308\u0308\u0306\u0307\u0301\u0307\u0304\u0303()
		{
			return null;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x1787220", Offset = "0x1786620", VA = "0x181787220")]
		public void \u0308\u0304\u0303\u0301\u0308\u0302\u0303\u0304\u0308\u0308\u0301\u0303\u0301\u0301\u0301(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x1782A00", Offset = "0x1781E00", VA = "0x181782A00")]
		public void \u0303\u0306\u0304\u0305\u0307\u0307\u0301\u0305\u0305\u0302\u0301\u0302\u0301\u0306\u0308(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x1785BC0", Offset = "0x1784FC0", VA = "0x181785BC0")]
		public void \u0306\u0301\u0307\u0303\u0303\u0305\u0302\u0301\u0302\u0303\u0304\u0302\u0307\u0304\u0307(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0000A5A4 File Offset: 0x000087A4
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x1783B10", Offset = "0x1782F10", VA = "0x181783B10", Slot = "5")]
		public bool \u0304\u0302\u0304\u0304\u0307\u0308\u0303\u0304\u0305\u0306\u0305\u0308\u0305\u0301\u0301(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x1787BA0", Offset = "0x1786FA0", VA = "0x181787BA0")]
		public void \u0308\u0308\u0304\u0301\u0307\u0302\u0301\u0301\u0305\u0304\u0306\u0303\u0304\u0307\u0308(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0000A5BC File Offset: 0x000087BC
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x1784150", Offset = "0x1783550", VA = "0x181784150", Slot = "6")]
		public bool \u0304\u0307\u0306\u0308\u0303\u0304\u0306\u0308\u0301\u0306\u0307\u0302\u0303\u0306\u0305(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x1787150", Offset = "0x1786550", VA = "0x181787150")]
		public void \u0308\u0303\u0303\u0307\u0301\u0303\u0301\u0308\u0303\u0304\u0307\u0304\u0307\u0305\u0308(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0000A5D4 File Offset: 0x000087D4
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x1785AB0", Offset = "0x1784EB0", VA = "0x181785AB0", Slot = "7")]
		public bool \u0306\u0301\u0305\u0302\u0304\u0305\u0306\u0307\u0308\u0303\u0305\u0301\u0305\u0302\u0305(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x1786D60", Offset = "0x1786160", VA = "0x181786D60")]
		public void \u0308\u0302\u0305\u0307\u0308\u0307\u0306\u0307\u0308\u0307\u0305\u0304\u0308\u0307\u0307(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x1785C90", Offset = "0x1785090", VA = "0x181785C90")]
		public void \u0306\u0302\u0305\u0302\u0301\u0303\u0302\u0306\u0308\u0302\u0307\u0308\u0308\u0306\u0303(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x1785640", Offset = "0x1784A40", VA = "0x181785640")]
		public ToolItem \u0305\u0308\u0305\u0304\u0308\u0304\u0306\u0304\u0303\u0306\u0306\u0303\u0308\u0301\u0304()
		{
			return null;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x1786B00", Offset = "0x1785F00", VA = "0x181786B00")]
		public void \u0307\u0306\u0301\u0301\u0304\u0304\u0306\u0307\u0302\u0302\u0301\u0304\u0301\u0308\u0306(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x1780FB0", Offset = "0x17803B0", VA = "0x181780FB0")]
		public ToolItem \u0302\u0302\u0307\u0306\u0307\u0303\u0303\u0304\u0307\u0304\u0305\u0302\u0305\u0301\u0305()
		{
			return null;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0000A5EC File Offset: 0x000087EC
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x1784980", Offset = "0x1783D80", VA = "0x181784980", Slot = "8")]
		public bool \u0305\u0301\u0305\u0304\u0301\u0305\u0308\u0304\u0306\u0303\u0302\u0307\u0308\u0308\u0303(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x17830C0", Offset = "0x17824C0", VA = "0x1817830C0")]
		public void \u0303\u0308\u0308\u0305\u0301\u0306\u0308\u0305\u0306\u0305\u0303\u0301\u0304\u0308\u0307(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0000A604 File Offset: 0x00008804
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x1786110", Offset = "0x1785510", VA = "0x181786110", Slot = "9")]
		public bool \u0307\u0302\u0301\u0302\u0305\u0304\u0307\u0303\u0307\u0304\u0308\u0306\u0301\u0307\u0307(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x1784260", Offset = "0x1783660", VA = "0x181784260")]
		public void \u0304\u0308\u0302\u0308\u0305\u0307\u0301\u0307\u0305\u0302\u0303\u0306\u0303\u0306\u0306(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x17857D0", Offset = "0x1784BD0", VA = "0x1817857D0")]
		public void \u0306\u0301\u0302\u0305\u0307\u0308\u0308\u0303\u0307\u0304\u0308\u0302\u0308\u0302\u0302(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x1785040", Offset = "0x1784440", VA = "0x181785040")]
		public void \u0305\u0305\u0306\u0305\u0303\u0304\u0305\u0303\u0302\u0308\u0307\u0303\u0304\u0305\u0305(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x1782AD0", Offset = "0x1781ED0", VA = "0x181782AD0")]
		public void \u0303\u0306\u0307\u0304\u0305\u0305\u0304\u0302\u0308\u0307\u0301\u0301\u0302\u0304\u0304(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x1784610", Offset = "0x1783A10", VA = "0x181784610")]
		public void \u0304\u0308\u0304\u0304\u0305\u0303\u0306\u0304\u0305\u0302\u0308\u0307\u0307\u0304\u0303(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x1782E70", Offset = "0x1782270", VA = "0x181782E70")]
		public void \u0303\u0308\u0303\u0304\u0303\u0306\u0307\u0304\u0307\u0303\u0303\u0306\u0308\u0302\u0301(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0000A61C File Offset: 0x0000881C
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x17862A0", Offset = "0x17856A0", VA = "0x1817862A0", Slot = "10")]
		public bool \u0307\u0302\u0303\u0301\u0308\u0303\u0307\u0305\u0307\u0302\u0301\u0302\u0308\u0308\u0307(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x17832D0", Offset = "0x17826D0", VA = "0x1817832D0")]
		public void \u0304\u0301\u0304\u0304\u0305\u0303\u0304\u0306\u0306\u0308\u0302\u0307\u0306\u0303\u0304(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x17806C0", Offset = "0x177FAC0", VA = "0x1817806C0")]
		public void \u0301\u0304\u0303\u0306\u0308\u0308\u0303\u0305\u0308\u0305\u0304\u0301\u0306\u0307\u0305(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x17875A0", Offset = "0x17869A0", VA = "0x1817875A0")]
		public void \u0308\u0306\u0308\u0302\u0305\u0305\u0304\u0305\u0305\u0307\u0306\u0301\u0306\u0308\u0301(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0000A634 File Offset: 0x00008834
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x1782D60", Offset = "0x1782160", VA = "0x181782D60", Slot = "11")]
		public bool \u0303\u0307\u0306\u0308\u0301\u0307\u0303\u0303\u0308\u0302\u0308\u0301\u0301\u0305\u0306(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x1787C70", Offset = "0x1787070", VA = "0x181787C70")]
		public ToolItem \u0308\u0308\u0308\u0306\u0304\u0304\u0305\u0308\u0306\u0305\u0308\u0304\u0307\u0306\u0303()
		{
			return null;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600166A")]
		[Address(RVA = "0x1784FC0", Offset = "0x17843C0", VA = "0x181784FC0")]
		public ToolItem \u0305\u0304\u0307\u0304\u0304\u0306\u0305\u0303\u0306\u0302\u0305\u0301\u0301\u0304\u0308()
		{
			return null;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0000A64C File Offset: 0x0000884C
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x1785E70", Offset = "0x1785270", VA = "0x181785E70", Slot = "12")]
		public bool \u0306\u0304\u0302\u0305\u0303\u0307\u0306\u0303\u0304\u0308\u0301\u0303\u0308\u0305\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000A664 File Offset: 0x00008864
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x1786E30", Offset = "0x1786230", VA = "0x181786E30", Slot = "13")]
		public bool \u0308\u0302\u0308\u0308\u0305\u0302\u0301\u0307\u0304\u0303\u0305\u0307\u0308\u0304\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0000A67C File Offset: 0x0000887C
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x1786000", Offset = "0x1785400", VA = "0x181786000", Slot = "14")]
		public bool \u0307\u0301\u0303\u0307\u0304\u0304\u0306\u0301\u0308\u0301\u0301\u0307\u0305\u0303\u0305(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x17816B0", Offset = "0x1780AB0", VA = "0x1817816B0")]
		public void \u0302\u0306\u0303\u0304\u0302\u0301\u0302\u0306\u0307\u0302\u0305\u0303\u0307\u0301\u0304(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x1782300", Offset = "0x1781700", VA = "0x181782300")]
		public ToolItem \u0303\u0304\u0308\u0303\u0303\u0307\u0308\u0304\u0301\u0305\u0301\u0303\u0305\u0307\u0301()
		{
			return null;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x1782CE0", Offset = "0x17820E0", VA = "0x181782CE0")]
		public ToolItem \u0303\u0307\u0303\u0307\u0305\u0303\u0301\u0301\u0303\u0304\u0307\u0303\u0303\u0304\u0306()
		{
			return null;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x17874D0", Offset = "0x17868D0", VA = "0x1817874D0")]
		public void \u0308\u0306\u0307\u0301\u0301\u0307\u0304\u0304\u0305\u0305\u0305\u0301\u0304\u0304\u0301(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001672")]
		[Address(RVA = "0x1786220", Offset = "0x1785620", VA = "0x181786220")]
		public ToolItem \u0307\u0302\u0301\u0305\u0303\u0302\u0307\u0303\u0302\u0304\u0302\u0305\u0305\u0307\u0307()
		{
			return null;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x1785F80", Offset = "0x1785380", VA = "0x181785F80")]
		public ToolItem \u0306\u0308\u0301\u0305\u0305\u0307\u0303\u0304\u0302\u0301\u0302\u0304\u0302\u0304\u0303()
		{
			return null;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x17804B0", Offset = "0x177F8B0", VA = "0x1817804B0")]
		public ToolItem \u0301\u0301\u0308\u0306\u0307\u0306\u0306\u0303\u0306\u0301\u0305\u0308\u0308\u0301\u0303()
		{
			return null;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x1781BF0", Offset = "0x1780FF0", VA = "0x181781BF0")]
		public ToolItem \u0303\u0302\u0302\u0308\u0307\u0305\u0307\u0304\u0307\u0302\u0301\u0306\u0306\u0307\u0301()
		{
			return null;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x1781780", Offset = "0x1780B80", VA = "0x181781780")]
		public ToolItem \u0302\u0307\u0302\u0306\u0307\u0307\u0305\u0305\u0302\u0303\u0302\u0304\u0308\u0303\u0307()
		{
			return null;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x17852E0", Offset = "0x17846E0", VA = "0x1817852E0")]
		public void \u0305\u0307\u0307\u0301\u0305\u0308\u0305\u0303\u0308\u0308\u0307\u0307\u0307\u0302\u0306(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x1784C60", Offset = "0x1784060", VA = "0x181784C60")]
		public void \u0305\u0302\u0307\u0307\u0302\u0303\u0306\u0303\u0302\u0306\u0308\u0301\u0305\u0308\u0305(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x1780860", Offset = "0x177FC60", VA = "0x181780860")]
		public void \u0301\u0304\u0304\u0305\u0307\u0301\u0304\u0308\u0301\u0304\u0301\u0308\u0302\u0305\u0307(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0000A694 File Offset: 0x00008894
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x1781030", Offset = "0x1780430", VA = "0x181781030", Slot = "15")]
		public bool \u0302\u0303\u0304\u0304\u0308\u0305\u0307\u0306\u0307\u0306\u0308\u0307\u0305\u0305\u0307(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0000A6AC File Offset: 0x000088AC
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x1781C70", Offset = "0x1781070", VA = "0x181781C70", Slot = "16")]
		public bool \u0303\u0303\u0302\u0305\u0303\u0308\u0303\u0302\u0303\u0308\u0306\u0308\u0302\u0304\u0308(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0000A6C4 File Offset: 0x000088C4
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x17847F0", Offset = "0x1783BF0", VA = "0x1817847F0", Slot = "17")]
		public bool \u0304\u0308\u0308\u0308\u0306\u0302\u0308\u0306\u0307\u0308\u0303\u0306\u0307\u0305\u0308(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0000A6DC File Offset: 0x000088DC
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x17846E0", Offset = "0x1783AE0", VA = "0x1817846E0", Slot = "18")]
		public bool \u0304\u0308\u0306\u0303\u0302\u0307\u0308\u0304\u0305\u0303\u0301\u0306\u0307\u0307\u0302(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0000A6F4 File Offset: 0x000088F4
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x17864C0", Offset = "0x17858C0", VA = "0x1817864C0", Slot = "19")]
		public bool \u0307\u0304\u0304\u0303\u0303\u0302\u0305\u0308\u0308\u0304\u0307\u0308\u0308\u0307\u0301(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x1781D80", Offset = "0x1781180", VA = "0x181781D80")]
		public void \u0303\u0304\u0302\u0308\u0307\u0305\u0305\u0304\u0307\u0301\u0303\u0302\u0303\u0308\u0301(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0000A70C File Offset: 0x0000890C
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x1781800", Offset = "0x1780C00", VA = "0x181781800", Slot = "20")]
		public bool \u0302\u0307\u0303\u0308\u0303\u0303\u0304\u0303\u0306\u0301\u0308\u0305\u0305\u0304\u0307(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0000A724 File Offset: 0x00008924
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x1782820", Offset = "0x1781C20", VA = "0x181782820", Slot = "21")]
		public bool \u0303\u0305\u0305\u0303\u0308\u0308\u0303\u0307\u0304\u0308\u0305\u0306\u0303\u0306\u0308(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0000A73C File Offset: 0x0000893C
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x17859A0", Offset = "0x1784DA0", VA = "0x1817859A0", Slot = "22")]
		public bool \u0306\u0301\u0304\u0308\u0301\u0303\u0308\u0307\u0306\u0307\u0308\u0301\u0301\u0306\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x17811C0", Offset = "0x17805C0", VA = "0x1817811C0")]
		public void \u0302\u0303\u0308\u0307\u0302\u0308\u0304\u0302\u0306\u0308\u0308\u0304\u0306\u0301\u0306(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0000A754 File Offset: 0x00008954
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x1780EA0", Offset = "0x17802A0", VA = "0x181780EA0", Slot = "23")]
		public bool \u0302\u0302\u0306\u0308\u0303\u0301\u0302\u0307\u0301\u0302\u0307\u0304\u0302\u0304\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x17837B0", Offset = "0x1782BB0", VA = "0x1817837B0")]
		public void \u0304\u0301\u0308\u0303\u0303\u0304\u0308\u0308\u0305\u0307\u0301\u0304\u0308\u0301\u0306(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0000A76C File Offset: 0x0000896C
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x17802D0", Offset = "0x177F6D0", VA = "0x1817802D0", Slot = "24")]
		public bool \u0301\u0301\u0303\u0306\u0303\u0307\u0308\u0302\u0301\u0308\u0301\u0306\u0305\u0308\u0307(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x1784400", Offset = "0x1783800", VA = "0x181784400")]
		public void \u0304\u0308\u0304\u0303\u0301\u0301\u0304\u0303\u0304\u0303\u0307\u0301\u0307\u0302\u0302(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x1780B80", Offset = "0x177FF80", VA = "0x181780B80")]
		public ToolItem \u0301\u0305\u0301\u0308\u0305\u0302\u0306\u0304\u0307\u0306\u0306\u0303\u0308\u0306\u0303()
		{
			return null;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x1780C00", Offset = "0x1780000", VA = "0x181780C00")]
		public ToolItem \u0301\u0306\u0303\u0304\u0303\u0304\u0303\u0305\u0301\u0307\u0308\u0305\u0302\u0301\u0304()
		{
			return null;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x1783F40", Offset = "0x1783340", VA = "0x181783F40")]
		public void \u0304\u0307\u0306\u0306\u0305\u0305\u0302\u0306\u0308\u0308\u0302\u0307\u0304\u0301\u0308(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x17815E0", Offset = "0x17809E0", VA = "0x1817815E0")]
		public void \u0302\u0305\u0307\u0308\u0301\u0303\u0301\u0304\u0307\u0301\u0303\u0303\u0306\u0307\u0305(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x1780D00", Offset = "0x1780100", VA = "0x181780D00")]
		public void \u0301\u0308\u0308\u0301\u0306\u0305\u0307\u0303\u0306\u0307\u0304\u0302\u0305\u0306\u0305(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x1782930", Offset = "0x1781D30", VA = "0x181782930")]
		public void \u0303\u0305\u0308\u0304\u0302\u0308\u0304\u0301\u0308\u0301\u0303\u0303\u0304\u0307\u0301(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x1783520", Offset = "0x1782920", VA = "0x181783520")]
		public void \u0304\u0301\u0304\u0306\u0308\u0302\u0306\u0301\u0305\u0301\u0303\u0304\u0304\u0304\u0304(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0000A784 File Offset: 0x00008984
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x17863B0", Offset = "0x17857B0", VA = "0x1817863B0", Slot = "25")]
		public bool \u0307\u0302\u0307\u0301\u0306\u0308\u0306\u0305\u0301\u0306\u0308\u0307\u0301\u0308\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0000A79C File Offset: 0x0000899C
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x1787880", Offset = "0x1786C80", VA = "0x181787880", Slot = "26")]
		public bool \u0308\u0307\u0306\u0303\u0302\u0308\u0304\u0303\u0303\u0301\u0305\u0308\u0303\u0303\u0301(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x17868F0", Offset = "0x1785CF0", VA = "0x1817868F0")]
		public void \u0307\u0305\u0305\u0304\u0307\u0307\u0308\u0304\u0302\u0303\u0302\u0301\u0301\u0306\u0306(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0000A7B4 File Offset: 0x000089B4
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x17872F0", Offset = "0x17866F0", VA = "0x1817872F0", Slot = "27")]
		public bool \u0308\u0304\u0305\u0304\u0304\u0304\u0302\u0308\u0301\u0302\u0303\u0305\u0302\u0301\u0308(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x1780AB0", Offset = "0x177FEB0", VA = "0x181780AB0")]
		public void \u0301\u0304\u0307\u0303\u0307\u0304\u0305\u0303\u0306\u0302\u0304\u0302\u0305\u0303\u0301(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x1780DD0", Offset = "0x17801D0", VA = "0x181780DD0")]
		public void \u0302\u0301\u0305\u0308\u0307\u0302\u0302\u0308\u0303\u0305\u0308\u0306\u0308\u0306\u0303(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0000A7CC File Offset: 0x000089CC
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x1783D20", Offset = "0x1783120", VA = "0x181783D20", Slot = "28")]
		public bool \u0304\u0307\u0304\u0301\u0306\u0304\u0301\u0305\u0304\u0306\u0308\u0307\u0302\u0308\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x1780640", Offset = "0x177FA40", VA = "0x181780640")]
		public ToolItem \u0301\u0302\u0307\u0304\u0305\u0306\u0308\u0304\u0308\u0305\u0302\u0306\u0308\u0303\u0304()
		{
			return null;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x1782380", Offset = "0x1781780", VA = "0x181782380")]
		public void \u0303\u0305\u0302\u0301\u0301\u0302\u0301\u0303\u0301\u0301\u0307\u0304\u0306\u0302\u0301(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6001698")]
		[Address(RVA = "0x1781AF0", Offset = "0x1780EF0", VA = "0x181781AF0")]
		public ToolItem \u0303\u0301\u0306\u0308\u0302\u0301\u0305\u0305\u0302\u0304\u0305\u0302\u0308\u0301\u0306()
		{
			return null;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x1786F40", Offset = "0x1786340", VA = "0x181786F40")]
		public void \u0308\u0303\u0302\u0307\u0303\u0304\u0302\u0305\u0303\u0306\u0302\u0307\u0306\u0301\u0302(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0000A7E4 File Offset: 0x000089E4
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x17820E0", Offset = "0x17814E0", VA = "0x1817820E0", Slot = "29")]
		public bool \u0303\u0304\u0306\u0302\u0306\u0301\u0305\u0305\u0302\u0307\u0304\u0306\u0303\u0305\u0301(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0000A7FC File Offset: 0x000089FC
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x1785530", Offset = "0x1784930", VA = "0x181785530", Slot = "30")]
		public bool \u0305\u0308\u0304\u0303\u0302\u0302\u0307\u0308\u0305\u0303\u0301\u0303\u0302\u0304\u0302(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x1785110", Offset = "0x1784510", VA = "0x181785110")]
		public void \u0305\u0305\u0307\u0301\u0301\u0305\u0302\u0301\u0303\u0307\u0301\u0306\u0301\u0307\u0307(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0000A814 File Offset: 0x00008A14
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x17821F0", Offset = "0x17815F0", VA = "0x1817821F0", Slot = "31")]
		public bool \u0303\u0304\u0307\u0307\u0307\u0302\u0305\u0304\u0301\u0307\u0306\u0308\u0304\u0308\u0308(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0000A82C File Offset: 0x00008A2C
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x1786C50", Offset = "0x1786050", VA = "0x181786C50", Slot = "32")]
		public bool \u0307\u0306\u0308\u0308\u0306\u0302\u0308\u0301\u0303\u0306\u0303\u0303\u0301\u0306\u0307(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x1781B70", Offset = "0x1780F70", VA = "0x181781B70")]
		public ToolItem \u0303\u0301\u0307\u0305\u0304\u0303\u0302\u0302\u0302\u0304\u0304\u0301\u0302\u0307\u0308()
		{
			return null;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x1787990", Offset = "0x1786D90", VA = "0x181787990")]
		public void \u0308\u0307\u0307\u0302\u0302\u0306\u0303\u0307\u0307\u0308\u0305\u0304\u0302\u0306\u0301(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x1784A90", Offset = "0x1783E90", VA = "0x181784A90")]
		public void \u0305\u0302\u0302\u0305\u0302\u0304\u0308\u0304\u0306\u0301\u0305\u0302\u0308\u0308\u0308(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0000A844 File Offset: 0x00008A44
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x1781FD0", Offset = "0x17813D0", VA = "0x181781FD0", Slot = "33")]
		public bool \u0303\u0304\u0305\u0302\u0304\u0301\u0302\u0304\u0302\u0308\u0306\u0308\u0303\u0304\u0301(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x17865D0", Offset = "0x17859D0", VA = "0x1817865D0")]
		public void \u0307\u0304\u0305\u0306\u0302\u0302\u0304\u0308\u0306\u0302\u0308\u0306\u0306\u0305\u0308(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0000A85C File Offset: 0x00008A5C
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x17813D0", Offset = "0x17807D0", VA = "0x1817813D0", Slot = "34")]
		public bool \u0302\u0304\u0307\u0305\u0304\u0306\u0305\u0305\u0308\u0308\u0303\u0304\u0303\u0302\u0303(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0000A874 File Offset: 0x00008A74
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x1783E30", Offset = "0x1783230", VA = "0x181783E30", Slot = "35")]
		public bool \u0304\u0307\u0304\u0302\u0308\u0302\u0306\u0307\u0303\u0307\u0303\u0308\u0306\u0305\u0303(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0000A88C File Offset: 0x00008A8C
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x1785D60", Offset = "0x1785160", VA = "0x181785D60", Slot = "36")]
		public bool \u0306\u0303\u0302\u0308\u0308\u0306\u0308\u0307\u0305\u0303\u0308\u0302\u0304\u0307\u0305(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x17856C0", Offset = "0x1784AC0", VA = "0x1817856C0", Slot = "37")]
		public bool \u0305\u0308\u0307\u0302\u0308\u0302\u0306\u0308\u0308\u0306\u0302\u0303\u0301\u0308\u0301(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x17803E0", Offset = "0x177F7E0", VA = "0x1817803E0")]
		public void \u0301\u0301\u0307\u0303\u0304\u0305\u0307\u0308\u0301\u0303\u0307\u0301\u0302\u0307\u0302(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x1780790", Offset = "0x177FB90", VA = "0x181780790")]
		public void \u0301\u0304\u0304\u0305\u0307\u0301\u0304\u0308\u0301\u0304\u0301\u0308\u0302\u0305\u0307(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0000A8BC File Offset: 0x00008ABC
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x1784EB0", Offset = "0x17842B0", VA = "0x181784EB0", Slot = "38")]
		public bool \u0305\u0303\u0305\u0301\u0308\u0307\u0302\u0301\u0305\u0308\u0301\u0307\u0308\u0304\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x1780530", Offset = "0x177F930", VA = "0x181780530", Slot = "39")]
		public bool \u0301\u0302\u0301\u0307\u0304\u0308\u0306\u0301\u0302\u0306\u0304\u0303\u0307\u0306\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x1786820", Offset = "0x1785C20", VA = "0x181786820")]
		public void \u0307\u0304\u0306\u0301\u0308\u0308\u0301\u0305\u0304\u0302\u0305\u0306\u0308\u0304\u0302(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x1784900", Offset = "0x1783D00", VA = "0x181784900")]
		public ToolItem \u0305\u0301\u0303\u0307\u0307\u0306\u0306\u0308\u0307\u0304\u0305\u0307\u0304\u0308\u0304()
		{
			return null;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x1786BD0", Offset = "0x1785FD0", VA = "0x181786BD0")]
		public ToolItem \u0307\u0306\u0308\u0304\u0305\u0308\u0305\u0302\u0308\u0303\u0306\u0308\u0302\u0308\u0301()
		{
			return null;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x1783730", Offset = "0x1782B30", VA = "0x181783730")]
		public ToolItem \u0304\u0301\u0307\u0305\u0308\u0303\u0304\u0304\u0306\u0307\u0302\u0304\u0308\u0301\u0304()
		{
			return null;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x1781140", Offset = "0x1780540", VA = "0x181781140")]
		public ToolItem \u0302\u0303\u0306\u0308\u0301\u0302\u0306\u0307\u0303\u0303\u0302\u0308\u0308\u0301\u0301()
		{
			return null;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x17814E0", Offset = "0x17808E0", VA = "0x1817814E0")]
		public ToolItem \u0302\u0304\u0308\u0303\u0302\u0306\u0308\u0303\u0304\u0308\u0303\u0303\u0304\u0303\u0304()
		{
			return null;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x1781A20", Offset = "0x1780E20", VA = "0x181781A20")]
		public void \u0303\u0301\u0301\u0306\u0307\u0307\u0302\u0308\u0307\u0301\u0306\u0301\u0308\u0304\u0305(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x1787400", Offset = "0x1786800", VA = "0x181787400")]
		public void \u0308\u0305\u0304\u0307\u0303\u0306\u0304\u0302\u0301\u0301\u0302\u0306\u0305\u0305\u0307(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0000A8EC File Offset: 0x00008AEC
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x17801C0", Offset = "0x177F5C0", VA = "0x1817801C0", Slot = "4")]
		public bool Equals(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0000A904 File Offset: 0x00008B04
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x1781910", Offset = "0x1780D10", VA = "0x181781910", Slot = "40")]
		public bool \u0302\u0308\u0305\u0306\u0308\u0305\u0306\u0305\u0304\u0303\u0301\u0305\u0303\u0303\u0304(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x1787670", Offset = "0x1786A70", VA = "0x181787670")]
		public void \u0308\u0307\u0302\u0306\u0305\u0301\u0308\u0301\u0303\u0305\u0307\u0302\u0307\u0301\u0302(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x1784330", Offset = "0x1783730", VA = "0x181784330")]
		public void \u0304\u0308\u0304\u0302\u0306\u0305\u0301\u0303\u0302\u0301\u0307\u0301\u0304\u0303\u0308(PlayerNetwork \u0308\u0305\u0301\u0301\u0303\u0308\u0305\u0307\u0303\u0308\u0307\u0308\u0303\u0303\u0305)
		{
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x1783C20", Offset = "0x1783020", VA = "0x181783C20")]
		public ToolItem \u0304\u0303\u0301\u0305\u0308\u0305\u0304\u0304\u0303\u0301\u0303\u0301\u0307\u0306\u0305()
		{
			return null;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0000A91C File Offset: 0x00008B1C
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x1783A00", Offset = "0x1782E00", VA = "0x181783A00", Slot = "41")]
		public bool \u0304\u0302\u0302\u0302\u0306\u0307\u0305\u0304\u0308\u0308\u0303\u0301\u0307\u0306\u0302(GungameList.Step \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return default(bool);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x1783CA0", Offset = "0x17830A0", VA = "0x181783CA0")]
		public ToolItem \u0304\u0305\u0308\u0302\u0301\u0303\u0303\u0306\u0307\u0308\u0307\u0302\u0304\u0304\u0307()
		{
			return null;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x1780C80", Offset = "0x1780080", VA = "0x181780C80")]
		public ToolItem \u0301\u0308\u0302\u0304\u0301\u0304\u0307\u0303\u0307\u0308\u0304\u0304\u0305\u0308\u0301()
		{
			return null;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x17825D0", Offset = "0x17819D0", VA = "0x1817825D0")]
		public void \u0303\u0305\u0304\u0308\u0304\u0302\u0306\u0306\u0304\u0305\u0305\u0305\u0308\u0306\u0307(ref \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 \u0304\u0305\u0301\u0305\u0305\u0301\u0306\u0308\u0306\u0307\u0307\u0308\u0301\u0301\u0307)
		{
		}

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x167180", Offset = "0x166580")]
		public AWeapon Weapon;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x8")]
		public WeaponAttachmentData WeaponAttachments;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17A8A0", Offset = "0x179CA0")]
		public AGadget Gadget;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17A8D0", Offset = "0x179CD0")]
		public int ExtraSupplies;
	}
}
