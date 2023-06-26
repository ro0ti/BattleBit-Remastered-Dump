using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.MainMenu.Cards
{
	// Token: 0x0200076B RID: 1899
	[Token(Token = "0x200076B")]
	public class CardSlider : MonoBehaviour
	{
		// Token: 0x06013AB3 RID: 80563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AB3")]
		[Address(RVA = "0x167D910", Offset = "0x167CD10", VA = "0x18167D910")]
		private void Awake()
		{
		}

		// Token: 0x06013AB4 RID: 80564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AB4")]
		[Address(RVA = "0x167DE00", Offset = "0x167D200", VA = "0x18167DE00")]
		private void Update()
		{
		}

		// Token: 0x06013AB5 RID: 80565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AB5")]
		[Address(RVA = "0x167DC80", Offset = "0x167D080", VA = "0x18167DC80")]
		private void UpdateScreenWidth(float width)
		{
		}

		// Token: 0x06013AB6 RID: 80566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AB6")]
		[Address(RVA = "0xA84680", Offset = "0xA83A80", VA = "0x180A84680")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x06013AB7 RID: 80567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013AB7")]
		[Address(RVA = "0x167E070", Offset = "0x167D470", VA = "0x18167E070")]
		public CardSlider()
		{
		}

		// Token: 0x04003873 RID: 14451
		[Token(Token = "0x4003873")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform[] Childs;

		// Token: 0x04003874 RID: 14452
		[Token(Token = "0x4003874")]
		[FieldOffset(Offset = "0x20")]
		public int Index;

		// Token: 0x04003875 RID: 14453
		[Token(Token = "0x4003875")]
		[FieldOffset(Offset = "0x24")]
		public float Speed;

		// Token: 0x04003876 RID: 14454
		[Token(Token = "0x4003876")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 position;

		// Token: 0x04003877 RID: 14455
		[Token(Token = "0x4003877")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform rect;

		// Token: 0x04003878 RID: 14456
		[Token(Token = "0x4003878")]
		[FieldOffset(Offset = "0x38")]
		private CanvasGroup[] ChildsGroups;

		// Token: 0x04003879 RID: 14457
		[Token(Token = "0x4003879")]
		[FieldOffset(Offset = "0x40")]
		private float lastAppliedWidth;
	}
}
