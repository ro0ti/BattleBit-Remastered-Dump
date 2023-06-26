using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	[ExecuteInEditMode]
	public class LoadoutToolLine : MonoBehaviour
	{
		// Token: 0x06013D64 RID: 81252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D64")]
		[Address(RVA = "0x17F8FD0", Offset = "0x17F83D0", VA = "0x1817F8FD0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06013D65 RID: 81253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D65")]
		[Address(RVA = "0x17F8790", Offset = "0x17F7B90", VA = "0x1817F8790")]
		private void FindBounds()
		{
		}

		// Token: 0x06013D66 RID: 81254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D66")]
		[Address(RVA = "0x17F8C50", Offset = "0x17F8050", VA = "0x1817F8C50")]
		private void FindStartPosition()
		{
		}

		// Token: 0x06013D67 RID: 81255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D67")]
		[Address(RVA = "0x17F89B0", Offset = "0x17F7DB0", VA = "0x1817F89B0")]
		private void FindEndPosition()
		{
		}

		// Token: 0x06013D68 RID: 81256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D68")]
		[Address(RVA = "0x17F85E0", Offset = "0x17F79E0", VA = "0x1817F85E0")]
		private void Apply()
		{
		}

		// Token: 0x06013D69 RID: 81257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D69")]
		[Address(RVA = "0x17F91A0", Offset = "0x17F85A0", VA = "0x1817F91A0")]
		public LoadoutToolLine()
		{
		}

		// Token: 0x04003C7C RID: 15484
		[Token(Token = "0x4003C7C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177660", Offset = "0x176A60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177660", Offset = "0x176A60")]
		public float T;

		// Token: 0x04003C7D RID: 15485
		[Token(Token = "0x4003C7D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177820", Offset = "0x176C20")]
		public RectTransform StartAsItem;

		// Token: 0x04003C7E RID: 15486
		[Token(Token = "0x4003C7E")]
		[FieldOffset(Offset = "0x28")]
		public Transform EndAsTransform;

		// Token: 0x04003C7F RID: 15487
		[Token(Token = "0x4003C7F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177910", Offset = "0x176D10")]
		[SerializeField]
		private RectTransform horizontalLine;

		// Token: 0x04003C80 RID: 15488
		[Token(Token = "0x4003C80")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform verticalLine;

		// Token: 0x04003C81 RID: 15489
		[Token(Token = "0x4003C81")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform Bounds;

		// Token: 0x04003C82 RID: 15490
		[Token(Token = "0x4003C82")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Canvas Canvas;

		// Token: 0x04003C83 RID: 15491
		[Token(Token = "0x4003C83")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 startPosition;

		// Token: 0x04003C84 RID: 15492
		[Token(Token = "0x4003C84")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 endPosition;

		// Token: 0x04003C85 RID: 15493
		[Token(Token = "0x4003C85")]
		[FieldOffset(Offset = "0x60")]
		private bool hadTargetLastFrame;

		// Token: 0x04003C86 RID: 15494
		[Token(Token = "0x4003C86")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] bounds;
	}
}
