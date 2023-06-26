using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.Events;

namespace UserInterface.MainMenu
{
	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	public class MainMenuStatsTitle : MonoBehaviour
	{
		// Token: 0x06013A6E RID: 80494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A6E")]
		[Address(RVA = "0x16806B0", Offset = "0x167FAB0", VA = "0x1816806B0")]
		public void OnClicked()
		{
		}

		// Token: 0x06013A6F RID: 80495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A6F")]
		[Address(RVA = "0x1680950", Offset = "0x167FD50", VA = "0x181680950")]
		public void UnSelect()
		{
		}

		// Token: 0x06013A70 RID: 80496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A70")]
		[Address(RVA = "0x1680860", Offset = "0x167FC60", VA = "0x181680860")]
		public void OnSelect()
		{
		}

		// Token: 0x06013A71 RID: 80497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A71")]
		[Address(RVA = "0x16806E0", Offset = "0x167FAE0", VA = "0x1816806E0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013A72 RID: 80498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A72")]
		[Address(RVA = "0x1680780", Offset = "0x167FB80", VA = "0x181680780")]
		public void OnItemClicked(MainMenuStatsTitleItem item)
		{
		}

		// Token: 0x06013A73 RID: 80499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013A73")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public MainMenuStatsTitle()
		{
		}

		// Token: 0x04003802 RID: 14338
		[Token(Token = "0x4003802")]
		[FieldOffset(Offset = "0x18")]
		public MainMenuStats Parent;

		// Token: 0x04003803 RID: 14339
		[Token(Token = "0x4003803")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelectedGameObj;

		// Token: 0x04003804 RID: 14340
		[Token(Token = "0x4003804")]
		[FieldOffset(Offset = "0x28")]
		public GameObject List;

		// Token: 0x04003805 RID: 14341
		[Token(Token = "0x4003805")]
		[FieldOffset(Offset = "0x30")]
		public GameObject TargetPage;

		// Token: 0x04003806 RID: 14342
		[Token(Token = "0x4003806")]
		[FieldOffset(Offset = "0x38")]
		public MainMenuStatsTitleItem[] Items;

		// Token: 0x04003807 RID: 14343
		[Token(Token = "0x4003807")]
		[FieldOffset(Offset = "0x40")]
		private bool wasSelected;

		// Token: 0x04003808 RID: 14344
		[Token(Token = "0x4003808")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public MainMenuStatsTitleItem selected;

		// Token: 0x04003809 RID: 14345
		[Token(Token = "0x4003809")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnNewItemSelected;
	}
}
