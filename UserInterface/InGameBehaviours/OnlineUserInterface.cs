using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours
{
	// Token: 0x02000797 RID: 1943
	[Token(Token = "0x2000797")]
	public class OnlineUserInterface : MonoBehaviour
	{
		// Token: 0x06013C30 RID: 80944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C30")]
		[Address(RVA = "0x168A1A0", Offset = "0x16895A0", VA = "0x18168A1A0")]
		private void Awake()
		{
		}

		// Token: 0x06013C31 RID: 80945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C31")]
		[Address(RVA = "0x168A290", Offset = "0x1689690", VA = "0x18168A290")]
		public void OnLateUpdateUI()
		{
		}

		// Token: 0x06013C32 RID: 80946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C32")]
		[Address(RVA = "0x168A770", Offset = "0x1689B70", VA = "0x18168A770")]
		public void OnSpawn()
		{
		}

		// Token: 0x06013C33 RID: 80947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C33")]
		[Address(RVA = "0x168A7A0", Offset = "0x1689BA0", VA = "0x18168A7A0")]
		private void SetDeploy(bool value)
		{
		}

		// Token: 0x06013C34 RID: 80948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C34")]
		[Address(RVA = "0x168A7D0", Offset = "0x1689BD0", VA = "0x18168A7D0")]
		private void SetGame(bool value)
		{
		}

		// Token: 0x06013C35 RID: 80949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013C35")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public OnlineUserInterface()
		{
		}

		// Token: 0x04003ADD RID: 15069
		[Token(Token = "0x4003ADD")]
		[FieldOffset(Offset = "0x0")]
		public static OnlineUserInterface Instance;

		// Token: 0x04003ADE RID: 15070
		[Token(Token = "0x4003ADE")]
		[FieldOffset(Offset = "0x18")]
		public GameObject DeployScreen;

		// Token: 0x04003ADF RID: 15071
		[Token(Token = "0x4003ADF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GameOverlay;

		// Token: 0x04003AE0 RID: 15072
		[Token(Token = "0x4003AE0")]
		[FieldOffset(Offset = "0x8")]
		public static Canvas MainCanvas;

		// Token: 0x04003AE1 RID: 15073
		[Token(Token = "0x4003AE1")]
		[FieldOffset(Offset = "0x10")]
		public static RectTransform MainCanvasRect;

		// Token: 0x04003AE2 RID: 15074
		[Token(Token = "0x4003AE2")]
		[FieldOffset(Offset = "0x18")]
		public static Vector2 MainCanvasRectSize;

		// Token: 0x04003AE3 RID: 15075
		[Token(Token = "0x4003AE3")]
		[FieldOffset(Offset = "0x20")]
		public static CanvasScaler MainCanvasScaler;

		// Token: 0x04003AE4 RID: 15076
		[Token(Token = "0x4003AE4")]
		[FieldOffset(Offset = "0x28")]
		private bool _depoyScreenEnabled;

		// Token: 0x04003AE5 RID: 15077
		[Token(Token = "0x4003AE5")]
		[FieldOffset(Offset = "0x29")]
		private bool _gameScreenEnabled;
	}
}
