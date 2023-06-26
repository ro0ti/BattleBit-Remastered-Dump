using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours.OverlaySub
{
	// Token: 0x020007A4 RID: 1956
	[Token(Token = "0x20007A4")]
	public class LogConnection : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x06013CB2 RID: 81074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CB2")]
		[Address(RVA = "0x167F500", Offset = "0x167E900", VA = "0x18167F500")]
		public void InitConnect(string player)
		{
		}

		// Token: 0x06013CB3 RID: 81075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CB3")]
		[Address(RVA = "0x167F5F0", Offset = "0x167E9F0", VA = "0x18167F5F0")]
		public void InitDisconnect(string player)
		{
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06013CB4 RID: 81076 RVA: 0x0007D5F4 File Offset: 0x0007B7F4
		// (set) Token: 0x06013CB5 RID: 81077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC9")]
		public int TickIndex8
		{
			[Token(Token = "0x6013CB4")]
			[Address(RVA = "0xA13840", Offset = "0xA12C40", VA = "0x180A13840", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013CB5")]
			[Address(RVA = "0xCA3840", Offset = "0xCA2C40", VA = "0x180CA3840", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06013CB6 RID: 81078 RVA: 0x0007D60C File Offset: 0x0007B80C
		// (set) Token: 0x06013CB7 RID: 81079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCA")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013CB6")]
			[Address(RVA = "0xDFA3C0", Offset = "0xDF97C0", VA = "0x180DFA3C0", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013CB7")]
			[Address(RVA = "0xDFA430", Offset = "0xDF9830", VA = "0x180DFA430", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013CB8 RID: 81080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CB8")]
		[Address(RVA = "0x167F740", Offset = "0x167EB40", VA = "0x18167F740", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013CB9 RID: 81081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CB9")]
		[Address(RVA = "0x167F8B0", Offset = "0x167ECB0", VA = "0x18167F8B0")]
		private void UpdateIcon(bool isJoin)
		{
		}

		// Token: 0x06013CBA RID: 81082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CBA")]
		[Address(RVA = "0x167F6E0", Offset = "0x167EAE0", VA = "0x18167F6E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06013CBB RID: 81083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CBB")]
		[Address(RVA = "0x167F940", Offset = "0x167ED40", VA = "0x18167F940")]
		public LogConnection()
		{
		}

		// Token: 0x04003B93 RID: 15251
		[Token(Token = "0x4003B93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI PlayerLabel;

		// Token: 0x04003B94 RID: 15252
		[Token(Token = "0x4003B94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage Tool;

		// Token: 0x04003B95 RID: 15253
		[Token(Token = "0x4003B95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup Canvas;

		// Token: 0x04003B96 RID: 15254
		[Token(Token = "0x4003B96")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform thisRect;

		// Token: 0x04003B97 RID: 15255
		[Token(Token = "0x4003B97")]
		[FieldOffset(Offset = "0x38")]
		private float timer;

		// Token: 0x04003B98 RID: 15256
		[Token(Token = "0x4003B98")]
		[FieldOffset(Offset = "0x3C")]
		private bool updateRunning;

		// Token: 0x04003B99 RID: 15257
		[Token(Token = "0x4003B99")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003B9A RID: 15258
		[Token(Token = "0x4003B9A")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;

		// Token: 0x04003B9B RID: 15259
		[Token(Token = "0x4003B9B")]
		[FieldOffset(Offset = "0x45")]
		private bool _lockedIsJoin;
	}
}
