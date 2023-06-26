using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours.OverlaySub
{
	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	public class LogKill : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x06013CBC RID: 81084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CBC")]
		[Address(RVA = "0x167F950", Offset = "0x167ED50", VA = "0x18167F950")]
		public void InitKill(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 killer, Sprite tool, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 victim, PlayerNetwork.\u0301\u0304\u0301\u0303\u0302\u0308\u0303\u0301\u0307\u0308\u0307\u0306\u0302\u0306\u0306 reason)
		{
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06013CBD RID: 81085 RVA: 0x0007D624 File Offset: 0x0007B824
		// (set) Token: 0x06013CBE RID: 81086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCB")]
		public int TickIndex8
		{
			[Token(Token = "0x6013CBD")]
			[Address(RVA = "0xB45740", Offset = "0xB44B40", VA = "0x180B45740", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013CBE")]
			[Address(RVA = "0xB620F0", Offset = "0xB614F0", VA = "0x180B620F0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06013CBF RID: 81087 RVA: 0x0007D63C File Offset: 0x0007B83C
		// (set) Token: 0x06013CC0 RID: 81088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCC")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013CBF")]
			[Address(RVA = "0x1045720", Offset = "0x1044B20", VA = "0x181045720", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013CC0")]
			[Address(RVA = "0x1153600", Offset = "0x1152A00", VA = "0x181153600", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013CC1 RID: 81089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC1")]
		[Address(RVA = "0x167FC80", Offset = "0x167F080", VA = "0x18167FC80", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013CC2 RID: 81090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC2")]
		[Address(RVA = "0x167FC20", Offset = "0x167F020", VA = "0x18167FC20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06013CC3 RID: 81091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CC3")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public LogKill()
		{
		}

		// Token: 0x04003B9C RID: 15260
		[Token(Token = "0x4003B9C")]
		public const float VisibleFor = 3f;

		// Token: 0x04003B9D RID: 15261
		[Token(Token = "0x4003B9D")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform thisRect;

		// Token: 0x04003B9E RID: 15262
		[Token(Token = "0x4003B9E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI Killer;

		// Token: 0x04003B9F RID: 15263
		[Token(Token = "0x4003B9F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI Victim;

		// Token: 0x04003BA0 RID: 15264
		[Token(Token = "0x4003BA0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform VictimRect;

		// Token: 0x04003BA1 RID: 15265
		[Token(Token = "0x4003BA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image Tool;

		// Token: 0x04003BA2 RID: 15266
		[Token(Token = "0x4003BA2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public CanvasGroup Canvas;

		// Token: 0x04003BA3 RID: 15267
		[Token(Token = "0x4003BA3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x174EB0", Offset = "0x1742B0")]
		public Sprite Fall;

		// Token: 0x04003BA4 RID: 15268
		[Token(Token = "0x4003BA4")]
		[FieldOffset(Offset = "0x50")]
		public Sprite Death;

		// Token: 0x04003BA5 RID: 15269
		[Token(Token = "0x4003BA5")]
		[FieldOffset(Offset = "0x58")]
		private float timer;

		// Token: 0x04003BA6 RID: 15270
		[Token(Token = "0x4003BA6")]
		[FieldOffset(Offset = "0x5C")]
		private bool updateRunning;

		// Token: 0x04003BA7 RID: 15271
		[Token(Token = "0x4003BA7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003BA8 RID: 15272
		[Token(Token = "0x4003BA8")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
