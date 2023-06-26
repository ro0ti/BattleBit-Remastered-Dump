using System;
using System.Runtime.InteropServices;
using touching_your_mom;
using PlayerLoadout.Items;
using TMPro;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class LoadoutScreenBehaviour : MonoBehaviour
	{
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06013D48 RID: 81224 RVA: 0x0007D7D4 File Offset: 0x0007B9D4
		[Token(Token = "0x17000BD5")]
		public static bool inLoadoutScreen
		{
			[Token(Token = "0x6013D48")]
			[Address(RVA = "0x17F6D20", Offset = "0x17F6120", VA = "0x1817F6D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06013D49 RID: 81225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D49")]
		[Address(RVA = "0x17F6AB0", Offset = "0x17F5EB0", VA = "0x1817F6AB0")]
		public LoadoutScreenBehaviour()
		{
		}

		// Token: 0x06013D4A RID: 81226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D4A")]
		[Address(RVA = "0x17F4040", Offset = "0x17F3440", VA = "0x1817F4040")]
		private void Awake()
		{
		}

		// Token: 0x06013D4B RID: 81227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D4B")]
		[Address(RVA = "0x17F5500", Offset = "0x17F4900", VA = "0x1817F5500")]
		private void Start()
		{
		}

		// Token: 0x06013D4C RID: 81228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D4C")]
		[Address(RVA = "0x17F5500", Offset = "0x17F4900", VA = "0x1817F5500")]
		private void OnEnable()
		{
		}

		// Token: 0x06013D4D RID: 81229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D4D")]
		[Address(RVA = "0x17F5470", Offset = "0x17F4870", VA = "0x1817F5470")]
		private void OnDisable()
		{
		}

		// Token: 0x06013D4E RID: 81230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D4E")]
		[Address(RVA = "0x17F5600", Offset = "0x17F4A00", VA = "0x1817F5600")]
		public void OnPrimarySelected()
		{
		}

		// Token: 0x06013D4F RID: 81231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D4F")]
		[Address(RVA = "0x17F5620", Offset = "0x17F4A20", VA = "0x1817F5620")]
		public void OnSecondarySelected()
		{
		}

		// Token: 0x06013D50 RID: 81232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D50")]
		[Address(RVA = "0x17F55E0", Offset = "0x17F49E0", VA = "0x1817F55E0")]
		public void OnFirstAidSelected()
		{
		}

		// Token: 0x06013D51 RID: 81233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D51")]
		[Address(RVA = "0x17F5660", Offset = "0x17F4A60", VA = "0x1817F5660")]
		public void OnToolASelected()
		{
		}

		// Token: 0x06013D52 RID: 81234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D52")]
		[Address(RVA = "0x17F5680", Offset = "0x17F4A80", VA = "0x1817F5680")]
		public void OnToolBSelected()
		{
		}

		// Token: 0x06013D53 RID: 81235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D53")]
		[Address(RVA = "0x17F5640", Offset = "0x17F4A40", VA = "0x1817F5640")]
		public void OnThrowableSelected()
		{
		}

		// Token: 0x06013D54 RID: 81236
		[Token(Token = "0x6013D54")]
		[Address(RVA = "0x17F5910", Offset = "0x17F4D10", VA = "0x1817F5910")]
		[PreserveSig]
		private static extern bool SetCursorPos(int X, int Y);

		// Token: 0x06013D55 RID: 81237
		[Token(Token = "0x6013D55")]
		[Address(RVA = "0x17F4290", Offset = "0x17F3690", VA = "0x1817F4290")]
		[PreserveSig]
		private static extern bool GetCursorPos(out Vector2Int point);

		// Token: 0x06013D56 RID: 81238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D56")]
		[Address(RVA = "0x17F5F20", Offset = "0x17F5320", VA = "0x1817F5F20")]
		private void Update()
		{
		}

		// Token: 0x06013D57 RID: 81239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D57")]
		[Address(RVA = "0x17F4310", Offset = "0x17F3710", VA = "0x1817F4310")]
		private void LateUpdate()
		{
		}

		// Token: 0x06013D58 RID: 81240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D58")]
		[Address(RVA = "0x17F56A0", Offset = "0x17F4AA0", VA = "0x1817F56A0")]
		public void RefreshContent()
		{
		}

		// Token: 0x06013D59 RID: 81241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D59")]
		[Address(RVA = "0x17F40B0", Offset = "0x17F34B0", VA = "0x1817F40B0")]
		private void FlushTool(bool resetRot)
		{
		}

		// Token: 0x06013D5A RID: 81242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D5A")]
		[Address(RVA = "0x17F4CF0", Offset = "0x17F40F0", VA = "0x1817F4CF0")]
		private void LoadTool(AWeapon weapon)
		{
		}

		// Token: 0x06013D5B RID: 81243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D5B")]
		[Address(RVA = "0x17F46D0", Offset = "0x17F3AD0", VA = "0x1817F46D0")]
		private void LoadGadget(AGadget gadget)
		{
		}

		// Token: 0x06013D5C RID: 81244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D5C")]
		[Address(RVA = "0x17F59A0", Offset = "0x17F4DA0", VA = "0x1817F59A0")]
		private void UpdateVisual()
		{
		}

		// Token: 0x04003C3E RID: 15422
		[Token(Token = "0x4003C3E")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public static ToolItem Active;

		// Token: 0x04003C3F RID: 15423
		[Token(Token = "0x4003C3F")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public static bool isActive;

		// Token: 0x04003C40 RID: 15424
		[Token(Token = "0x4003C40")]
		[touching_your_mom.FieldOffset(Offset = "0x9")]
		public static bool RefreshFlag;

		// Token: 0x04003C41 RID: 15425
		[Token(Token = "0x4003C41")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		public static LoadoutScreenBehaviour Instance;

		// Token: 0x04003C42 RID: 15426
		[Token(Token = "0x4003C42")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		private bool awakeCalled;

		// Token: 0x04003C43 RID: 15427
		[Token(Token = "0x4003C43")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public Camera LoadoutCamera;

		// Token: 0x04003C44 RID: 15428
		[Token(Token = "0x4003C44")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17A360", Offset = "0x179760")]
		public Transform ContentParent;

		// Token: 0x04003C45 RID: 15429
		[Token(Token = "0x4003C45")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI Title;

		// Token: 0x04003C46 RID: 15430
		[Token(Token = "0x4003C46")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI KillCount;

		// Token: 0x04003C47 RID: 15431
		[Token(Token = "0x4003C47")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1722E0", Offset = "0x1716E0")]
		public LoadoutAttachmentManager AttachmentManager;

		// Token: 0x04003C48 RID: 15432
		[Token(Token = "0x4003C48")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		public LoadoutWeaponStatsManager StatsManager;

		// Token: 0x04003C49 RID: 15433
		[Token(Token = "0x4003C49")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		public LoadoutToolSelection ToolSelection;

		// Token: 0x04003C4A RID: 15434
		[Token(Token = "0x4003C4A")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		public WeaponRangeTable TableRange;

		// Token: 0x04003C4B RID: 15435
		[Token(Token = "0x4003C4B")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x161890", Offset = "0x160C90")]
		public GameObject Points;

		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		[touching_your_mom.FieldOffset(Offset = "0x68")]
		public GameObject AttachmentList;

		// Token: 0x04003C4D RID: 15437
		[Token(Token = "0x4003C4D")]
		[touching_your_mom.FieldOffset(Offset = "0x70")]
		public GameObject WeaponStats;

		// Token: 0x04003C4E RID: 15438
		[Token(Token = "0x4003C4E")]
		[touching_your_mom.FieldOffset(Offset = "0x78")]
		public GameObject ShootingHelper;

		// Token: 0x04003C4F RID: 15439
		[Token(Token = "0x4003C4F")]
		[touching_your_mom.FieldOffset(Offset = "0x80")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17A510", Offset = "0x179910")]
		public GameObject primarySelected;

		// Token: 0x04003C50 RID: 15440
		[Token(Token = "0x4003C50")]
		[touching_your_mom.FieldOffset(Offset = "0x88")]
		public GameObject secondarySelected;

		// Token: 0x04003C51 RID: 15441
		[Token(Token = "0x4003C51")]
		[touching_your_mom.FieldOffset(Offset = "0x90")]
		public GameObject firstAidSelected;

		// Token: 0x04003C52 RID: 15442
		[Token(Token = "0x4003C52")]
		[touching_your_mom.FieldOffset(Offset = "0x98")]
		public GameObject toolASelected;

		// Token: 0x04003C53 RID: 15443
		[Token(Token = "0x4003C53")]
		[touching_your_mom.FieldOffset(Offset = "0xA0")]
		public GameObject toolBSelected;

		// Token: 0x04003C54 RID: 15444
		[Token(Token = "0x4003C54")]
		[touching_your_mom.FieldOffset(Offset = "0xA8")]
		public GameObject throwableSelected;

		// Token: 0x04003C55 RID: 15445
		[Token(Token = "0x4003C55")]
		[touching_your_mom.FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17A590", Offset = "0x179990")]
		public GameObject primaryNew;

		// Token: 0x04003C56 RID: 15446
		[Token(Token = "0x4003C56")]
		[touching_your_mom.FieldOffset(Offset = "0xB8")]
		public GameObject secondaryNew;

		// Token: 0x04003C57 RID: 15447
		[Token(Token = "0x4003C57")]
		[touching_your_mom.FieldOffset(Offset = "0xC0")]
		public GameObject firstAidNew;

		// Token: 0x04003C58 RID: 15448
		[Token(Token = "0x4003C58")]
		[touching_your_mom.FieldOffset(Offset = "0xC8")]
		public GameObject toolANew;

		// Token: 0x04003C59 RID: 15449
		[Token(Token = "0x4003C59")]
		[touching_your_mom.FieldOffset(Offset = "0xD0")]
		public GameObject toolBNew;

		// Token: 0x04003C5A RID: 15450
		[Token(Token = "0x4003C5A")]
		[touching_your_mom.FieldOffset(Offset = "0xD8")]
		public GameObject throwableNew;

		// Token: 0x04003C5B RID: 15451
		[Token(Token = "0x4003C5B")]
		[touching_your_mom.FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 currentIndex;

		// Token: 0x04003C5C RID: 15452
		[Token(Token = "0x4003C5C")]
		[touching_your_mom.FieldOffset(Offset = "0xE4")]
		private Vector3 eulars;

		// Token: 0x04003C5D RID: 15453
		[Token(Token = "0x4003C5D")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		public static bool isDragging;

		// Token: 0x04003C5E RID: 15454
		[Token(Token = "0x4003C5E")]
		[touching_your_mom.FieldOffset(Offset = "0x19")]
		public static bool isHovering;

		// Token: 0x04003C5F RID: 15455
		[Token(Token = "0x4003C5F")]
		[touching_your_mom.FieldOffset(Offset = "0xF0")]
		private Vector2Int dragStartMouse;

		// Token: 0x04003C60 RID: 15456
		[Token(Token = "0x4003C60")]
		[touching_your_mom.FieldOffset(Offset = "0xF8")]
		private \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 lastNation;

		// Token: 0x04003C61 RID: 15457
		[Token(Token = "0x4003C61")]
		[touching_your_mom.FieldOffset(Offset = "0xF9")]
		private \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 lastRole;

		// Token: 0x04003C62 RID: 15458
		[Token(Token = "0x4003C62")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public static GameObject currentContent;

		// Token: 0x04003C63 RID: 15459
		[Token(Token = "0x4003C63")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public static MeshRenderer focusedBody;

		// Token: 0x04003C64 RID: 15460
		[Token(Token = "0x4003C64")]
		[touching_your_mom.FieldOffset(Offset = "0x100")]
		private Vector2[] AspectRatioAreas;
	}
}
