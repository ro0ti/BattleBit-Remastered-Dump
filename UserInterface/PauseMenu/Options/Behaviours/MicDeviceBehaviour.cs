using System;
using touching_your_mom;
using TMPro;
using UnityEngine.UI;

namespace UserInterface.PauseMenu.Options.Behaviours
{
	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x2000788")]
	public class MicDeviceBehaviour : OptionsElement, IOptionsElement, IOptionsElementValue<int>
	{
		// Token: 0x06013B9F RID: 80799 RVA: 0x0007D33C File Offset: 0x0007B53C
		[Token(Token = "0x6013B9F")]
		[Address(RVA = "0x188D950", Offset = "0x188CD50", VA = "0x18188D950", Slot = "9")]
		public int Get(bool save = false)
		{
			return 0;
		}

		// Token: 0x06013BA0 RID: 80800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA0")]
		[Address(RVA = "0x188DC10", Offset = "0x188D010", VA = "0x18188DC10", Slot = "10")]
		public void Set(int value)
		{
		}

		// Token: 0x06013BA1 RID: 80801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA1")]
		[Address(RVA = "0x188D9C0", Offset = "0x188CDC0", VA = "0x18188D9C0", Slot = "6")]
		public void Load()
		{
		}

		// Token: 0x06013BA2 RID: 80802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA2")]
		[Address(RVA = "0x188D9A0", Offset = "0x188CDA0", VA = "0x18188D9A0", Slot = "7")]
		public void LoadDefault()
		{
		}

		// Token: 0x06013BA3 RID: 80803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA3")]
		[Address(RVA = "0x188DA50", Offset = "0x188CE50", VA = "0x18188DA50", Slot = "5")]
		public void Save()
		{
		}

		// Token: 0x06013BA4 RID: 80804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA4")]
		[Address(RVA = "0x188DC20", Offset = "0x188D020", VA = "0x18188DC20")]
		private void Update()
		{
		}

		// Token: 0x06013BA5 RID: 80805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA5")]
		[Address(RVA = "0x188D9F0", Offset = "0x188CDF0", VA = "0x18188D9F0")]
		public void OnNextPressed()
		{
		}

		// Token: 0x06013BA6 RID: 80806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA6")]
		[Address(RVA = "0x188DA20", Offset = "0x188CE20", VA = "0x18188DA20")]
		public void OnPreviousPressed()
		{
		}

		// Token: 0x06013BA7 RID: 80807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA7")]
		[Address(RVA = "0x188DA70", Offset = "0x188CE70", VA = "0x18188DA70")]
		private void SetVisual(int index)
		{
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06013BA8 RID: 80808 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x17000BAE")]
		private string[] elements
		{
			[Token(Token = "0x6013BA8")]
			[Address(RVA = "0x188DCD0", Offset = "0x188D0D0", VA = "0x18188DCD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06013BA9 RID: 80809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BA9")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public MicDeviceBehaviour()
		{
		}

		// Token: 0x04003A22 RID: 14882
		[Token(Token = "0x4003A22")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		// Token: 0x04003A23 RID: 14883
		[Token(Token = "0x4003A23")]
		[FieldOffset(Offset = "0x28")]
		public Button Next;

		// Token: 0x04003A24 RID: 14884
		[Token(Token = "0x4003A24")]
		[FieldOffset(Offset = "0x30")]
		public Button Previous;

		// Token: 0x04003A25 RID: 14885
		[Token(Token = "0x4003A25")]
		[FieldOffset(Offset = "0x38")]
		private float lastUpdate;

		// Token: 0x04003A26 RID: 14886
		[Token(Token = "0x4003A26")]
		[FieldOffset(Offset = "0x3C")]
		private int currentIndex;
	}
}
