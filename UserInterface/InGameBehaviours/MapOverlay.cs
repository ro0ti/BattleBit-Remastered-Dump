using System;
using touching_your_mom;
using TMPro;
using UnityEngine;

namespace UserInterface.InGameBehaviours
{
	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x2000796")]
	public class MapOverlay : MonoBehaviour
	{
		// Token: 0x06013C26 RID: 80934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C26")]
		[Address(RVA = "0x1687C50", Offset = "0x1687050", VA = "0x181687C50")]
		private void Awake()
		{
		}

		// Token: 0x06013C27 RID: 80935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C27")]
		[Address(RVA = "0x1687FF0", Offset = "0x16873F0", VA = "0x181687FF0")]
		private void Start()
		{
		}

		// Token: 0x06013C28 RID: 80936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C28")]
		[Address(RVA = "0x1687F90", Offset = "0x1687390", VA = "0x181687F90")]
		private void OnEnable()
		{
		}

		// Token: 0x06013C29 RID: 80937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C29")]
		[Address(RVA = "0x1687F30", Offset = "0x1687330", VA = "0x181687F30")]
		private void OnDisable()
		{
		}

		// Token: 0x06013C2A RID: 80938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C2A")]
		[Address(RVA = "0x1687ED0", Offset = "0x16872D0", VA = "0x181687ED0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06013C2B RID: 80939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C2B")]
		[Address(RVA = "0x1687CB0", Offset = "0x16870B0", VA = "0x181687CB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06013C2C RID: 80940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C2C")]
		[Address(RVA = "0x1688870", Offset = "0x1687C70", VA = "0x181688870")]
		private void UpdateMouseInput()
		{
		}

		// Token: 0x06013C2D RID: 80941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C2D")]
		[Address(RVA = "0x1688050", Offset = "0x1687450", VA = "0x181688050")]
		private void UpdateCursor()
		{
		}

		// Token: 0x06013C2E RID: 80942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C2E")]
		[Address(RVA = "0x1688A90", Offset = "0x1687E90", VA = "0x181688A90")]
		public MapOverlay()
		{
		}

		// Token: 0x04003AD0 RID: 15056
		[Token(Token = "0x4003AD0")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsMapCursorVisible;

		// Token: 0x04003AD1 RID: 15057
		[Token(Token = "0x4003AD1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16F280", Offset = "0x16E680")]
		public RectTransform CursorRect;

		// Token: 0x04003AD2 RID: 15058
		[Token(Token = "0x4003AD2")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform CursorChildRect;

		// Token: 0x04003AD3 RID: 15059
		[Token(Token = "0x4003AD3")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup CursorGroup;

		// Token: 0x04003AD4 RID: 15060
		[Token(Token = "0x4003AD4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16F350", Offset = "0x16E750")]
		public RectTransform LineRect;

		// Token: 0x04003AD5 RID: 15061
		[Token(Token = "0x4003AD5")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup LineGroup;

		// Token: 0x04003AD6 RID: 15062
		[Token(Token = "0x4003AD6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x16F3D0", Offset = "0x16E7D0")]
		public TextMeshProUGUI TextMesh;

		// Token: 0x04003AD7 RID: 15063
		[Token(Token = "0x4003AD7")]
		[FieldOffset(Offset = "0x48")]
		private bool mWasHolding;

		// Token: 0x04003AD8 RID: 15064
		[Token(Token = "0x4003AD8")]
		[FieldOffset(Offset = "0x4C")]
		private float mLastClick;

		// Token: 0x04003AD9 RID: 15065
		[Token(Token = "0x4003AD9")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 mLastClickPosition;

		// Token: 0x04003ADA RID: 15066
		[Token(Token = "0x4003ADA")]
		[FieldOffset(Offset = "0x5C")]
		private bool mMouseClickHandeled;

		// Token: 0x04003ADB RID: 15067
		[Token(Token = "0x4003ADB")]
		[FieldOffset(Offset = "0x5D")]
		private bool mAcceptMouseDown;

		// Token: 0x04003ADC RID: 15068
		[Token(Token = "0x4003ADC")]
		[FieldOffset(Offset = "0x60")]
		private float mCursorScale;
	}
}
