using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.MainMenu
{
	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x2000767")]
	public class ServerListSortItem : MonoBehaviour
	{
		// Token: 0x06013AA2 RID: 80546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA2")]
		[Address(RVA = "0x1695540", Offset = "0x1694940", VA = "0x181695540")]
		public void Click()
		{
		}

		// Token: 0x06013AA3 RID: 80547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA3")]
		[Address(RVA = "0x1695570", Offset = "0x1694970", VA = "0x181695570")]
		public void Disable()
		{
		}

		// Token: 0x06013AA4 RID: 80548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA4")]
		[Address(RVA = "0x16955A0", Offset = "0x16949A0", VA = "0x1816955A0")]
		public void Enable()
		{
		}

		// Token: 0x06013AA5 RID: 80549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AA5")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public ServerListSortItem()
		{
		}

		// Token: 0x04003858 RID: 14424
		[Token(Token = "0x4003858")]
		[FieldOffset(Offset = "0x18")]
		public ServerList Parent;

		// Token: 0x04003859 RID: 14425
		[Token(Token = "0x4003859")]
		[FieldOffset(Offset = "0x20")]
		public RawImage Icon;

		// Token: 0x0400385A RID: 14426
		[Token(Token = "0x400385A")]
		[FieldOffset(Offset = "0x28")]
		public ServerList.Sorting SortType;

		// Token: 0x0400385B RID: 14427
		[Token(Token = "0x400385B")]
		[FieldOffset(Offset = "0x2C")]
		public bool Flag;

		// Token: 0x0400385C RID: 14428
		[Token(Token = "0x400385C")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D Up;

		// Token: 0x0400385D RID: 14429
		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D Down;
	}
}
