using System;
using touching_your_mom;
using PlayerLoadout.Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	public class LoadoutAttachmentElement : MonoBehaviour
	{
		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06013CDB RID: 81115 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06013CDC RID: 81116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCE")]
		public \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 Item
		{
			[Token(Token = "0x6013CDB")]
			[Address(RVA = "0x9F53A0", Offset = "0x9F47A0", VA = "0x1809F53A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013CDC")]
			[Address(RVA = "0xABF340", Offset = "0xABE740", VA = "0x180ABF340")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06013CDD RID: 81117 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06013CDE RID: 81118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCF")]
		public AWeapon WeaponItem
		{
			[Token(Token = "0x6013CDD")]
			[Address(RVA = "0xAEB3E0", Offset = "0xAEA7E0", VA = "0x180AEB3E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013CDE")]
			[Address(RVA = "0xAEB990", Offset = "0xAEAD90", VA = "0x180AEB990")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x06013CDF RID: 81119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CDF")]
		[Address(RVA = "0x19417B0", Offset = "0x1940BB0", VA = "0x1819417B0")]
		private void Awake()
		{
		}

		// Token: 0x06013CE0 RID: 81120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE0")]
		[Address(RVA = "0x1941D60", Offset = "0x1941160", VA = "0x181941D60")]
		private void OnDisable()
		{
		}

		// Token: 0x06013CE1 RID: 81121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE1")]
		[Address(RVA = "0x1941840", Offset = "0x1940C40", VA = "0x181941840")]
		public void Init(AWeapon weapon, \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 item, bool isLocked, uint required, bool isSelected)
		{
		}

		// Token: 0x06013CE2 RID: 81122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE2")]
		[Address(RVA = "0x1941DF0", Offset = "0x19411F0", VA = "0x181941DF0")]
		public void OnHoverEnter()
		{
		}

		// Token: 0x06013CE3 RID: 81123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE3")]
		[Address(RVA = "0x1941EC0", Offset = "0x19412C0", VA = "0x181941EC0")]
		public void OnHoverExit()
		{
		}

		// Token: 0x06013CE4 RID: 81124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE4")]
		[Address(RVA = "0x1941CD0", Offset = "0x19410D0", VA = "0x181941CD0")]
		public void OnClick()
		{
		}

		// Token: 0x06013CE5 RID: 81125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE5")]
		[Address(RVA = "0x1941D60", Offset = "0x1941160", VA = "0x181941D60")]
		private void OnSendToPool()
		{
		}

		// Token: 0x06013CE6 RID: 81126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CE6")]
		[Address(RVA = "0x1941F50", Offset = "0x1941350", VA = "0x181941F50")]
		public LoadoutAttachmentElement()
		{
		}

		// Token: 0x04003BCA RID: 15306
		[Token(Token = "0x4003BCA")]
		[FieldOffset(Offset = "0x0")]
		public static LoadoutAttachmentElement Active;

		// Token: 0x04003BCB RID: 15307
		[Token(Token = "0x4003BCB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1667B0", Offset = "0x165BB0")]
		private TextMeshProUGUI MainLabelName;

		// Token: 0x04003BCC RID: 15308
		[Token(Token = "0x4003BCC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage MainImage;

		// Token: 0x04003BCD RID: 15309
		[Token(Token = "0x4003BCD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject MainIsLockedIcon;

		// Token: 0x04003BCE RID: 15310
		[Token(Token = "0x4003BCE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject MainIsNew;

		// Token: 0x04003BCF RID: 15311
		[Token(Token = "0x4003BCF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI MainKillRequirment;

		// Token: 0x04003BD0 RID: 15312
		[Token(Token = "0x4003BD0")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x176CA0", Offset = "0x1760A0")]
		[SerializeField]
		private Color NormalColor;

		// Token: 0x04003BD1 RID: 15313
		[Token(Token = "0x4003BD1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color SelectedColor;

		// Token: 0x04003BD2 RID: 15314
		[Token(Token = "0x4003BD2")]
		[FieldOffset(Offset = "0x60")]
		private CanvasGroup mCanvas;

		// Token: 0x04003BD3 RID: 15315
		[Token(Token = "0x4003BD3")]
		[FieldOffset(Offset = "0x68")]
		private RawImage mCurrentRawImage;

		// Token: 0x04003BD4 RID: 15316
		[Token(Token = "0x4003BD4")]
		[FieldOffset(Offset = "0x70")]
		private \u0307\u0301\u0303\u0301\u0308\u0302\u0301\u0303\u0304\u0306\u0304\u0306\u0305\u0304\u0307 mButton;

		// Token: 0x04003BD5 RID: 15317
		[Token(Token = "0x4003BD5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 <Item>k__BackingField;

		// Token: 0x04003BD6 RID: 15318
		[Token(Token = "0x4003BD6")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private AWeapon <WeaponItem>k__BackingField;

		// Token: 0x04003BD7 RID: 15319
		[Token(Token = "0x4003BD7")]
		[FieldOffset(Offset = "0x88")]
		private bool mIsSelected;

		// Token: 0x04003BD8 RID: 15320
		[Token(Token = "0x4003BD8")]
		[FieldOffset(Offset = "0x89")]
		private bool mIsLocked;

		// Token: 0x04003BD9 RID: 15321
		[Token(Token = "0x4003BD9")]
		[FieldOffset(Offset = "0x8A")]
		private bool mIsNew;
	}
}
