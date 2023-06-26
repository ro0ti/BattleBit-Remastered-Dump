using System;
using touching_your_mom;
using PlayerLoadout.Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007B8 RID: 1976
	[Token(Token = "0x20007B8")]
	public class LoadoutSkinElement : MonoBehaviour
	{
		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06013D34 RID: 81204 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06013D35 RID: 81205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD2")]
		public \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 Item
		{
			[Token(Token = "0x6013D34")]
			[Address(RVA = "0xB33290", Offset = "0xB32690", VA = "0x180B33290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013D35")]
			[Address(RVA = "0x8F2DA0", Offset = "0x8F21A0", VA = "0x1808F2DA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06013D36 RID: 81206 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06013D37 RID: 81207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD3")]
		public AWeapon WeaponItem
		{
			[Token(Token = "0x6013D36")]
			[Address(RVA = "0x9F53A0", Offset = "0x9F47A0", VA = "0x1809F53A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013D37")]
			[Address(RVA = "0xABF340", Offset = "0xABE740", VA = "0x180ABF340")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x06013D38 RID: 81208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D38")]
		[Address(RVA = "0x17F7920", Offset = "0x17F6D20", VA = "0x1817F7920")]
		private void Awake()
		{
		}

		// Token: 0x06013D39 RID: 81209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D39")]
		[Address(RVA = "0x17F83F0", Offset = "0x17F77F0", VA = "0x1817F83F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06013D3A RID: 81210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D3A")]
		[Address(RVA = "0x17F7970", Offset = "0x17F6D70", VA = "0x1817F7970")]
		public void Init(AWeapon weapon, \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 item, Texture2D texture, bool isLocked, int requiredKill, bool isSelected, bool canView)
		{
		}

		// Token: 0x06013D3B RID: 81211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D3B")]
		[Address(RVA = "0x17F81F0", Offset = "0x17F75F0", VA = "0x1817F81F0")]
		public void LateUpdate()
		{
		}

		// Token: 0x06013D3C RID: 81212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D3C")]
		[Address(RVA = "0x17F8480", Offset = "0x17F7880", VA = "0x1817F8480")]
		public void OnHoverEnter()
		{
		}

		// Token: 0x06013D3D RID: 81213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D3D")]
		[Address(RVA = "0x17F8550", Offset = "0x17F7950", VA = "0x1817F8550")]
		public void OnHoverExit()
		{
		}

		// Token: 0x06013D3E RID: 81214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D3E")]
		[Address(RVA = "0x17F8350", Offset = "0x17F7750", VA = "0x1817F8350")]
		public void OnClick()
		{
		}

		// Token: 0x06013D3F RID: 81215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D3F")]
		[Address(RVA = "0x17F83F0", Offset = "0x17F77F0", VA = "0x1817F83F0")]
		private void OnSendToPool()
		{
		}

		// Token: 0x06013D40 RID: 81216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D40")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public LoadoutSkinElement()
		{
		}

		// Token: 0x04003C2A RID: 15402
		[Token(Token = "0x4003C2A")]
		[FieldOffset(Offset = "0x0")]
		public static LoadoutSkinElement Active;

		// Token: 0x04003C2B RID: 15403
		[Token(Token = "0x4003C2B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1667B0", Offset = "0x165BB0")]
		private CanvasGroup MainCanvas;

		// Token: 0x04003C2C RID: 15404
		[Token(Token = "0x4003C2C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup LockedCanvas;

		// Token: 0x04003C2D RID: 15405
		[Token(Token = "0x4003C2D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI MainLabelName;

		// Token: 0x04003C2E RID: 15406
		[Token(Token = "0x4003C2E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI LockedLabelName;

		// Token: 0x04003C2F RID: 15407
		[Token(Token = "0x4003C2F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RawImage MainImage;

		// Token: 0x04003C30 RID: 15408
		[Token(Token = "0x4003C30")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup ImageCanvas;

		// Token: 0x04003C31 RID: 15409
		[Token(Token = "0x4003C31")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject LockedProgressImage;

		// Token: 0x04003C32 RID: 15410
		[Token(Token = "0x4003C32")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject MainIsNew;

		// Token: 0x04003C33 RID: 15411
		[Token(Token = "0x4003C33")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform Progress;

		// Token: 0x04003C34 RID: 15412
		[Token(Token = "0x4003C34")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI MainKillRequirment;

		// Token: 0x04003C35 RID: 15413
		[Token(Token = "0x4003C35")]
		[FieldOffset(Offset = "0x68")]
		private \u0307\u0301\u0303\u0301\u0308\u0302\u0301\u0303\u0304\u0306\u0304\u0306\u0305\u0304\u0307 mButton;

		// Token: 0x04003C36 RID: 15414
		[Token(Token = "0x4003C36")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 <Item>k__BackingField;

		// Token: 0x04003C37 RID: 15415
		[Token(Token = "0x4003C37")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private AWeapon <WeaponItem>k__BackingField;

		// Token: 0x04003C38 RID: 15416
		[Token(Token = "0x4003C38")]
		[FieldOffset(Offset = "0x80")]
		private bool mIsSelected;

		// Token: 0x04003C39 RID: 15417
		[Token(Token = "0x4003C39")]
		[FieldOffset(Offset = "0x81")]
		private bool mIsLocked;

		// Token: 0x04003C3A RID: 15418
		[Token(Token = "0x4003C3A")]
		[FieldOffset(Offset = "0x82")]
		private bool mIsNew;

		// Token: 0x04003C3B RID: 15419
		[Token(Token = "0x4003C3B")]
		[FieldOffset(Offset = "0x83")]
		private bool mCanViewIt;
	}
}
