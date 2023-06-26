using System;
using touching_your_mom;

namespace UserInterface.PauseMenu.Options
{
	// Token: 0x02000780 RID: 1920
	[Token(Token = "0x2000780")]
	public interface IOptionsElementValue<T>
	{
		// Token: 0x06013B76 RID: 80758
		[Token(Token = "0x6013B76")]
		T Get(bool save);

		// Token: 0x06013B77 RID: 80759
		[Token(Token = "0x6013B77")]
		void Set(T value);
	}
}
