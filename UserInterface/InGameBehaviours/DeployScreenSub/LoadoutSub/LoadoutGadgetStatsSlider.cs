using System;
using touching_your_mom;
using TMPro;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	[ExecuteInEditMode]
	public class LoadoutGadgetStatsSlider : MonoBehaviour
	{
		// Token: 0x06013D9D RID: 81309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D9D")]
		[Address(RVA = "0xA3D5C0", Offset = "0xA3C9C0", VA = "0x180A3D5C0")]
		private void Awake()
		{
		}

		// Token: 0x06013D9E RID: 81310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D9E")]
		[Address(RVA = "0x17F3CE0", Offset = "0x17F30E0", VA = "0x1817F3CE0")]
		public void Update()
		{
		}

		// Token: 0x06013D9F RID: 81311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D9F")]
		[Address(RVA = "0x17F3BA0", Offset = "0x17F2FA0", VA = "0x1817F3BA0")]
		private void Set(float value)
		{
		}

		// Token: 0x06013DA0 RID: 81312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DA0")]
		[Address(RVA = "0x17F4020", Offset = "0x17F3420", VA = "0x1817F4020")]
		public LoadoutGadgetStatsSlider()
		{
		}

		// Token: 0x04003CD0 RID: 15568
		[Token(Token = "0x4003CD0")]
		[FieldOffset(Offset = "0x0")]
		private static Color Positive;

		// Token: 0x04003CD1 RID: 15569
		[Token(Token = "0x4003CD1")]
		[FieldOffset(Offset = "0x10")]
		private static Color Negative;

		// Token: 0x04003CD2 RID: 15570
		[Token(Token = "0x4003CD2")]
		[FieldOffset(Offset = "0x18")]
		public float referanceWidth;

		// Token: 0x04003CD3 RID: 15571
		[Token(Token = "0x4003CD3")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x157430", Offset = "0x156830")]
		public float MaxValue;

		// Token: 0x04003CD4 RID: 15572
		[Token(Token = "0x4003CD4")]
		[FieldOffset(Offset = "0x20")]
		public float Value;

		// Token: 0x04003CD5 RID: 15573
		[Token(Token = "0x4003CD5")]
		[FieldOffset(Offset = "0x24")]
		public bool isFloat;

		// Token: 0x04003CD6 RID: 15574
		[Token(Token = "0x4003CD6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17C6B0", Offset = "0x17BAB0")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17C6B0", Offset = "0x17BAB0")]
		private float percentValue;

		// Token: 0x04003CD7 RID: 15575
		[Token(Token = "0x4003CD7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1667B0", Offset = "0x165BB0")]
		private RectTransform ValueRect;

		// Token: 0x04003CD8 RID: 15576
		[Token(Token = "0x4003CD8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform CursorRect;

		// Token: 0x04003CD9 RID: 15577
		[Token(Token = "0x4003CD9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI ValueText;

		// Token: 0x04003CDA RID: 15578
		[Token(Token = "0x4003CDA")]
		[FieldOffset(Offset = "0x48")]
		private float currentValue;
	}
}
