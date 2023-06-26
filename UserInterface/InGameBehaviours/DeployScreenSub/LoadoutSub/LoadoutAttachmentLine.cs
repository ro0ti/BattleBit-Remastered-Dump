using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	[ExecuteInEditMode]
	public class LoadoutAttachmentLine : MonoBehaviour
	{
		// Token: 0x06013CE7 RID: 81127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE7")]
		[Address(RVA = "0x17EB490", Offset = "0x17EA890", VA = "0x1817EB490")]
		private void LateUpdate()
		{
		}

		// Token: 0x06013CE8 RID: 81128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE8")]
		[Address(RVA = "0x17EB5C0", Offset = "0x17EA9C0", VA = "0x1817EB5C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06013CE9 RID: 81129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE9")]
		[Address(RVA = "0x17EB080", Offset = "0x17EA480", VA = "0x1817EB080")]
		private void FindPositions()
		{
		}

		// Token: 0x06013CEA RID: 81130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CEA")]
		[Address(RVA = "0x17EAD20", Offset = "0x17EA120", VA = "0x1817EAD20")]
		private void Apply()
		{
		}

		// Token: 0x06013CEB RID: 81131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CEB")]
		[Address(RVA = "0xE80C00", Offset = "0xE80000", VA = "0x180E80C00")]
		public LoadoutAttachmentLine()
		{
		}

		// Token: 0x04003BDA RID: 15322
		[Token(Token = "0x4003BDA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177660", Offset = "0x176A60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177660", Offset = "0x176A60")]
		public float T;

		// Token: 0x04003BDB RID: 15323
		[Token(Token = "0x4003BDB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177820", Offset = "0x176C20")]
		public RectTransform Start;

		// Token: 0x04003BDC RID: 15324
		[Token(Token = "0x4003BDC")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform EndAsItem;

		// Token: 0x04003BDD RID: 15325
		[Token(Token = "0x4003BDD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x177910", Offset = "0x176D10")]
		[SerializeField]
		private RectTransform horizontalLine;

		// Token: 0x04003BDE RID: 15326
		[Token(Token = "0x4003BDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform verticalLine;

		// Token: 0x04003BDF RID: 15327
		[Token(Token = "0x4003BDF")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 startPosition;

		// Token: 0x04003BE0 RID: 15328
		[Token(Token = "0x4003BE0")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 endPosition;

		// Token: 0x04003BE1 RID: 15329
		[Token(Token = "0x4003BE1")]
		[FieldOffset(Offset = "0x50")]
		private bool hadTargetLastFrame;

		// Token: 0x04003BE2 RID: 15330
		[Token(Token = "0x4003BE2")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 currentEndPosition;

		// Token: 0x04003BE3 RID: 15331
		[Token(Token = "0x4003BE3")]
		[FieldOffset(Offset = "0x5C")]
		private bool isLocked;
	}
}
