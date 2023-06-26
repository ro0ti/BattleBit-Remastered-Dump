using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;
using UserInterface.Global.Interfaces;

namespace UserInterface.Global.SelectableGroup
{
	// Token: 0x020007D6 RID: 2006
	[Token(Token = "0x20007D6")]
	public class SelectableGroup : MonoBehaviour, ISelectableGroup
	{
		// Token: 0x06013E0D RID: 81421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E0D")]
		[Address(RVA = "0x1944650", Offset = "0x1943A50", VA = "0x181944650")]
		private void Awake()
		{
		}

		// Token: 0x06013E0E RID: 81422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E0E")]
		[Address(RVA = "0x1944840", Offset = "0x1943C40", VA = "0x181944840", Slot = "4")]
		public void Select(ISelectable element)
		{
		}

		// Token: 0x06013E0F RID: 81423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E0F")]
		[Address(RVA = "0x1944970", Offset = "0x1943D70", VA = "0x181944970")]
		public SelectableGroup()
		{
		}

		// Token: 0x04003D57 RID: 15703
		[Token(Token = "0x4003D57")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> Selectables;

		// Token: 0x04003D58 RID: 15704
		[Token(Token = "0x4003D58")]
		[FieldOffset(Offset = "0x20")]
		public List<ISelectable> _selectables;
	}
}
