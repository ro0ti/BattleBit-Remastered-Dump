using System;
using touching_your_mom;

namespace UserInterface.PauseMenu.Options
{
	// Token: 0x0200077F RID: 1919
	[Token(Token = "0x200077F")]
	public interface IOptionsElement
	{
		// Token: 0x06013B72 RID: 80754
		[Token(Token = "0x6013B72")]
		void Save();

		// Token: 0x06013B73 RID: 80755
		[Token(Token = "0x6013B73")]
		void Load();

		// Token: 0x06013B74 RID: 80756
		[Token(Token = "0x6013B74")]
		void LoadDefault();

		// Token: 0x06013B75 RID: 80757
		[Token(Token = "0x6013B75")]
		void Apply(SettingsQuality v);
	}
}
