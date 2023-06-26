using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.PauseMenu.Options
{
	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x200077E")]
	public class SettingsPresents : MonoBehaviour
	{
		// Token: 0x06013B70 RID: 80752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B70")]
		[Address(RVA = "0x1895280", Offset = "0x1894680", VA = "0x181895280")]
		public void Apply(int quality)
		{
		}

		// Token: 0x06013B71 RID: 80753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B71")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public SettingsPresents()
		{
		}

		// Token: 0x040039D6 RID: 14806
		[Token(Token = "0x40039D6")]
		[FieldOffset(Offset = "0x18")]
		public PauseMenuOptions Menu;
	}
}
