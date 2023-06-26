using System;
using touching_your_mom;

namespace UserInterface.Global.Interfaces
{
	// Token: 0x020007D7 RID: 2007
	[Token(Token = "0x20007D7")]
	public interface ISelectable
	{
		// Token: 0x06013E10 RID: 81424
		[Token(Token = "0x6013E10")]
		void Select();

		// Token: 0x06013E11 RID: 81425
		[Token(Token = "0x6013E11")]
		void Deselect();

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06013E12 RID: 81426
		[Token(Token = "0x17000BEB")]
		bool isSelected { [Token(Token = "0x6013E12")] get; }

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06013E13 RID: 81427
		// (set) Token: 0x06013E14 RID: 81428
		[Token(Token = "0x17000BEC")]
		ISelectableGroup Parent { [Token(Token = "0x6013E13")] get; [Token(Token = "0x6013E14")] set; }
	}
}
