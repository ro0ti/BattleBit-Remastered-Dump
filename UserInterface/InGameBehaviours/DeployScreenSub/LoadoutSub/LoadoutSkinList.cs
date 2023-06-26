using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	public class LoadoutSkinList : MonoBehaviour
	{
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06013D41 RID: 81217 RVA: 0x0007D7BC File Offset: 0x0007B9BC
		// (set) Token: 0x06013D42 RID: 81218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD4")]
		public int ItemCount
		{
			[Token(Token = "0x6013D41")]
			[Address(RVA = "0x8ADF50", Offset = "0x8AD350", VA = "0x1808ADF50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013D42")]
			[Address(RVA = "0xA019B0", Offset = "0xA00DB0", VA = "0x180A019B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013D43 RID: 81219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D43")]
		[Address(RVA = "0x102AD20", Offset = "0x102A120", VA = "0x18102AD20")]
		public void Reset()
		{
		}

		// Token: 0x06013D44 RID: 81220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D44")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public LoadoutSkinList()
		{
		}

		// Token: 0x04003C3C RID: 15420
		[Token(Token = "0x4003C3C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <ItemCount>k__BackingField;
	}
}
