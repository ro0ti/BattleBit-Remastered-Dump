using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.Global.Updaters
{
	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x20007D2")]
	[ExecuteInEditMode]
	public class ConstantFitterUpdater : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06013DE9 RID: 81385 RVA: 0x0007DAEC File Offset: 0x0007BCEC
		// (set) Token: 0x06013DEA RID: 81386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE3")]
		public int TickIndex8
		{
			[Token(Token = "0x6013DE9")]
			[Address(RVA = "0x938790", Offset = "0x937B90", VA = "0x180938790", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013DEA")]
			[Address(RVA = "0xA84680", Offset = "0xA83A80", VA = "0x180A84680", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06013DEB RID: 81387 RVA: 0x0007DB04 File Offset: 0x0007BD04
		// (set) Token: 0x06013DEC RID: 81388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE4")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013DEB")]
			[Address(RVA = "0xA84650", Offset = "0xA83A50", VA = "0x180A84650", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013DEC")]
			[Address(RVA = "0xCAFCD0", Offset = "0xCAF0D0", VA = "0x180CAFCD0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013DED RID: 81389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DED")]
		[Address(RVA = "0x193CBE0", Offset = "0x193BFE0", VA = "0x18193CBE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013DEE RID: 81390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DEE")]
		[Address(RVA = "0x193CB80", Offset = "0x193BF80", VA = "0x18193CB80")]
		private void OnDisable()
		{
		}

		// Token: 0x06013DEF RID: 81391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DEF")]
		[Address(RVA = "0x193CB30", Offset = "0x193BF30", VA = "0x18193CB30")]
		private void Awake()
		{
		}

		// Token: 0x06013DF0 RID: 81392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DF0")]
		[Address(RVA = "0x193CC40", Offset = "0x193C040", VA = "0x18193CC40", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013DF1 RID: 81393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DF1")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public ConstantFitterUpdater()
		{
		}

		// Token: 0x04003D44 RID: 15684
		[Token(Token = "0x4003D44")]
		[FieldOffset(Offset = "0x18")]
		private ContentSizeFitter _fitter;

		// Token: 0x04003D45 RID: 15685
		[Token(Token = "0x4003D45")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003D46 RID: 15686
		[Token(Token = "0x4003D46")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
