using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.PauseMenu.Options
{
	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	public class OptionsElement : MonoBehaviour
	{
		// Token: 0x06013B78 RID: 80760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B78")]
		[Address(RVA = "0x188E030", Offset = "0x188D430", VA = "0x18188E030")]
		public void OnChangedValue()
		{
		}

		// Token: 0x06013B79 RID: 80761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B79")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "4")]
		public virtual void Apply(SettingsQuality v)
		{
		}

		// Token: 0x06013B7A RID: 80762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B7A")]
		[Address(RVA = "0x187F960", Offset = "0x187ED60", VA = "0x18187F960")]
		public OptionsElement()
		{
		}

		// Token: 0x040039D7 RID: 14807
		[Token(Token = "0x40039D7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16B270", Offset = "0x16A670")]
		public string Key;
	}
}
