using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UserInterface.PauseMenu.Options.Behaviours;

namespace UserInterface.PauseMenu.Options
{
	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	public class Binding : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x06013B5C RID: 80732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B5C")]
		[Address(RVA = "0x18803C0", Offset = "0x187F7C0", VA = "0x1818803C0")]
		public void OnPressed()
		{
		}

		// Token: 0x06013B5D RID: 80733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B5D")]
		[Address(RVA = "0x1880350", Offset = "0x187F750", VA = "0x181880350")]
		private void OnEnable()
		{
		}

		// Token: 0x06013B5E RID: 80734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B5E")]
		[Address(RVA = "0x18802F0", Offset = "0x187F6F0", VA = "0x1818802F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06013B5F RID: 80735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B5F")]
		[Address(RVA = "0x18803B0", Offset = "0x187F7B0", VA = "0x1818803B0", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013B60 RID: 80736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B60")]
		[Address(RVA = "0x187F9B0", Offset = "0x187EDB0", VA = "0x18187F9B0")]
		private void Listen()
		{
		}

		// Token: 0x06013B61 RID: 80737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B61")]
		[Address(RVA = "0x1880500", Offset = "0x187F900", VA = "0x181880500")]
		private void OnStartedListening()
		{
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06013B62 RID: 80738 RVA: 0x0007D234 File Offset: 0x0007B434
		// (set) Token: 0x06013B63 RID: 80739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA7")]
		public KeyCode Button
		{
			[Token(Token = "0x6013B62")]
			[Address(RVA = "0x919690", Offset = "0x918A90", VA = "0x180919690")]
			get
			{
				return KeyCode.None;
			}
			[Token(Token = "0x6013B63")]
			[Address(RVA = "0x18806D0", Offset = "0x187FAD0", VA = "0x1818806D0")]
			set
			{
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06013B64 RID: 80740 RVA: 0x0007D24C File Offset: 0x0007B44C
		// (set) Token: 0x06013B65 RID: 80741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA8")]
		public InputAxis Axis
		{
			[Token(Token = "0x6013B64")]
			[Address(RVA = "0x9C90F0", Offset = "0x9C84F0", VA = "0x1809C90F0")]
			get
			{
				return InputAxis.None;
			}
			[Token(Token = "0x6013B65")]
			[Address(RVA = "0x18805B0", Offset = "0x187F9B0", VA = "0x1818805B0")]
			set
			{
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06013B66 RID: 80742 RVA: 0x0007D264 File Offset: 0x0007B464
		// (set) Token: 0x06013B67 RID: 80743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BA9")]
		public bool isAxis
		{
			[Token(Token = "0x6013B66")]
			[Address(RVA = "0x919560", Offset = "0x918960", VA = "0x180919560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013B67")]
			[Address(RVA = "0x9196B0", Offset = "0x918AB0", VA = "0x1809196B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06013B68 RID: 80744 RVA: 0x0007D27C File Offset: 0x0007B47C
		// (set) Token: 0x06013B69 RID: 80745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAA")]
		public bool isAxisPositive
		{
			[Token(Token = "0x6013B68")]
			[Address(RVA = "0xAA0B10", Offset = "0xA9FF10", VA = "0x180AA0B10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013B69")]
			[Address(RVA = "0xAA0B20", Offset = "0xA9FF20", VA = "0x180AA0B20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06013B6A RID: 80746 RVA: 0x0007D294 File Offset: 0x0007B494
		[Token(Token = "0x17000BAB")]
		public bool isButton
		{
			[Token(Token = "0x6013B6A")]
			[Address(RVA = "0x18805A0", Offset = "0x187F9A0", VA = "0x1818805A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06013B6B RID: 80747 RVA: 0x0007D2AC File Offset: 0x0007B4AC
		// (set) Token: 0x06013B6C RID: 80748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAC")]
		public int TickIndex8
		{
			[Token(Token = "0x6013B6B")]
			[Address(RVA = "0xA69700", Offset = "0xA68B00", VA = "0x180A69700", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013B6C")]
			[Address(RVA = "0xA84660", Offset = "0xA83A60", VA = "0x180A84660", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06013B6D RID: 80749 RVA: 0x0007D2C4 File Offset: 0x0007B4C4
		// (set) Token: 0x06013B6E RID: 80750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAD")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013B6D")]
			[Address(RVA = "0x99D720", Offset = "0x99CB20", VA = "0x18099D720", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013B6E")]
			[Address(RVA = "0xABF360", Offset = "0xABE760", VA = "0x180ABF360", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013B6F RID: 80751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013B6F")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public Binding()
		{
		}

		// Token: 0x040039CD RID: 14797
		[Token(Token = "0x40039CD")]
		[FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		// Token: 0x040039CE RID: 14798
		[Token(Token = "0x40039CE")]
		[FieldOffset(Offset = "0x20")]
		private bool isListening;

		// Token: 0x040039CF RID: 14799
		[Token(Token = "0x40039CF")]
		[FieldOffset(Offset = "0x24")]
		private float lastPress;

		// Token: 0x040039D0 RID: 14800
		[Token(Token = "0x40039D0")]
		[FieldOffset(Offset = "0x28")]
		private KeyCode _key;

		// Token: 0x040039D1 RID: 14801
		[Token(Token = "0x40039D1")]
		[FieldOffset(Offset = "0x2C")]
		private InputAxis _axis;

		// Token: 0x040039D2 RID: 14802
		[Token(Token = "0x40039D2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <isAxis>k__BackingField;

		// Token: 0x040039D3 RID: 14803
		[Token(Token = "0x40039D3")]
		[FieldOffset(Offset = "0x31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <isAxisPositive>k__BackingField;

		// Token: 0x040039D4 RID: 14804
		[Token(Token = "0x40039D4")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x040039D5 RID: 14805
		[Token(Token = "0x40039D5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
