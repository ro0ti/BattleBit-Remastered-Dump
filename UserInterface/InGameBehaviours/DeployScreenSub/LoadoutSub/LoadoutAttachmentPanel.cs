using System;
using System.Collections.Generic;
using touching_your_mom;
using PlayerLoadout.Items;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Extentions;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x20007AC")]
	public class LoadoutAttachmentPanel : MonoBehaviour
	{
		// Token: 0x06013CF3 RID: 81139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF3")]
		[Address(RVA = "0x17EC910", Offset = "0x17EBD10", VA = "0x1817EC910")]
		private void Awake()
		{
		}

		// Token: 0x06013CF4 RID: 81140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF4")]
		[Address(RVA = "0x17F1500", Offset = "0x17F0900", VA = "0x1817F1500")]
		private void OnDisable()
		{
		}

		// Token: 0x06013CF5 RID: 81141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF5")]
		[Address(RVA = "0x17F1560", Offset = "0x17F0960", VA = "0x1817F1560")]
		private void Update()
		{
		}

		// Token: 0x06013CF6 RID: 81142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF6")]
		[Address(RVA = "0x17ED070", Offset = "0x17EC470", VA = "0x1817ED070")]
		public void Flush()
		{
		}

		// Token: 0x06013CF7 RID: 81143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF7")]
		[Address(RVA = "0x17F1350", Offset = "0x17F0750", VA = "0x1817F1350")]
		public void Load(\u0303\u0305\u0307\u0303\u0307\u0301\u0308\u0308\u0303\u0302\u0301\u0306\u0301\u0305\u0301 type, AWeapon item)
		{
		}

		// Token: 0x06013CF8 RID: 81144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF8")]
		[Address(RVA = "0x17EED10", Offset = "0x17EE110", VA = "0x1817EED10")]
		private void LoadScopes(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013CF9 RID: 81145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CF9")]
		[Address(RVA = "0x17F0A70", Offset = "0x17EFE70", VA = "0x1817F0A70")]
		private void LoadTopScopes(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013CFA RID: 81146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CFA")]
		[Address(RVA = "0x17EE3F0", Offset = "0x17ED7F0", VA = "0x1817EE3F0")]
		private void LoadCantedScopes(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013CFB RID: 81147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CFB")]
		[Address(RVA = "0x17ED5B0", Offset = "0x17EC9B0", VA = "0x1817ED5B0")]
		private void LoadBarrels(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013CFC RID: 81148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CFC")]
		[Address(RVA = "0x17F0EE0", Offset = "0x17F02E0", VA = "0x1817F0EE0")]
		private void LoadUnderRails(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013CFD RID: 81149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CFD")]
		[Address(RVA = "0x17EFF90", Offset = "0x17EF390", VA = "0x1817EFF90")]
		private void LoadSideRails(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013CFE RID: 81150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CFE")]
		[Address(RVA = "0x17EDFA0", Offset = "0x17ED3A0", VA = "0x1817EDFA0")]
		private void LoadBoltActions(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013CFF RID: 81151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013CFF")]
		[Address(RVA = "0x17EE860", Offset = "0x17EDC60", VA = "0x1817EE860")]
		private void LoadMagazines(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013D00 RID: 81152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D00")]
		[Address(RVA = "0x17F03E0", Offset = "0x17EF7E0", VA = "0x1817F03E0")]
		private void LoadSkins(uint kills, AWeapon Item)
		{
		}

		// Token: 0x06013D01 RID: 81153 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013D01")]
		[Address(RVA = "0x17ECEA0", Offset = "0x17EC2A0", VA = "0x1817ECEA0")]
		private GameObject CreateTitle(string title, float height = 60f, float font = 18f)
		{
			return null;
		}

		// Token: 0x06013D02 RID: 81154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D02")]
		[Address(RVA = "0x17ECFD0", Offset = "0x17EC3D0", VA = "0x1817ECFD0")]
		private void DeleteTitle(GameObject obj)
		{
		}

		// Token: 0x06013D03 RID: 81155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D03")]
		[Address(RVA = "0x17ECAC0", Offset = "0x17EBEC0", VA = "0x1817ECAC0")]
		private void CreateElement(AWeapon weapon, \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 item, bool isLocked, int requiredKill, bool isSelected)
		{
		}

		// Token: 0x06013D04 RID: 81156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D04")]
		[Address(RVA = "0x17ECC20", Offset = "0x17EC020", VA = "0x1817ECC20")]
		private void CreateSkin(AWeapon weapon, \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 item, Texture2D texture, bool isLocked, int requiredKill, bool isSelected, bool canView)
		{
		}

		// Token: 0x06013D05 RID: 81157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D05")]
		[Address(RVA = "0x17F1890", Offset = "0x17F0C90", VA = "0x1817F1890")]
		public LoadoutAttachmentPanel()
		{
		}

		// Token: 0x04003BED RID: 15341
		[Token(Token = "0x4003BED")]
		[FieldOffset(Offset = "0x0")]
		public static int ItemCount;

		// Token: 0x04003BEE RID: 15342
		[Token(Token = "0x4003BEE")]
		[FieldOffset(Offset = "0x18")]
		public Canvas Canvas;

		// Token: 0x04003BEF RID: 15343
		[Token(Token = "0x4003BEF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Panel;

		// Token: 0x04003BF0 RID: 15344
		[Token(Token = "0x4003BF0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x178E70", Offset = "0x178270")]
		public Transform ContentParent;

		// Token: 0x04003BF1 RID: 15345
		[Token(Token = "0x4003BF1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PrefabTitle;

		// Token: 0x04003BF2 RID: 15346
		[Token(Token = "0x4003BF2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject PrefabElement;

		// Token: 0x04003BF3 RID: 15347
		[Token(Token = "0x4003BF3")]
		[FieldOffset(Offset = "0x40")]
		public GameObject PrefabSkinList;

		// Token: 0x04003BF4 RID: 15348
		[Token(Token = "0x4003BF4")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PrefabSkinElement;

		// Token: 0x04003BF5 RID: 15349
		[Token(Token = "0x4003BF5")]
		[FieldOffset(Offset = "0x50")]
		public VerticalLayoutGroup VerticaList;

		// Token: 0x04003BF6 RID: 15350
		[Token(Token = "0x4003BF6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x178FA0", Offset = "0x1783A0")]
		public Texture2D PreviewingSkins;

		// Token: 0x04003BF7 RID: 15351
		[Token(Token = "0x4003BF7")]
		[FieldOffset(Offset = "0x60")]
		private RectTransform mThisRect;

		// Token: 0x04003BF8 RID: 15352
		[Token(Token = "0x4003BF8")]
		[FieldOffset(Offset = "0x68")]
		private \u0303\u0305\u0307\u0303\u0307\u0301\u0308\u0308\u0303\u0302\u0301\u0306\u0301\u0305\u0301 mLatestType;

		// Token: 0x04003BF9 RID: 15353
		[Token(Token = "0x4003BF9")]
		[FieldOffset(Offset = "0x70")]
		private LoadoutSkinList mCurrentList;

		// Token: 0x04003BFA RID: 15354
		[Token(Token = "0x4003BFA")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<\u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302, RectTransform> mRegisteredObjects;

		// Token: 0x04003BFB RID: 15355
		[Token(Token = "0x4003BFB")]
		[FieldOffset(Offset = "0x80")]
		private List<LoadoutAttachmentTitle> mSpawnedTitles;

		// Token: 0x04003BFC RID: 15356
		[Token(Token = "0x4003BFC")]
		[FieldOffset(Offset = "0x88")]
		private List<LoadoutAttachmentElement> mSpawnedItems;

		// Token: 0x04003BFD RID: 15357
		[Token(Token = "0x4003BFD")]
		[FieldOffset(Offset = "0x90")]
		private List<LoadoutSkinList> mSpawnedSkinLists;

		// Token: 0x04003BFE RID: 15358
		[Token(Token = "0x4003BFE")]
		[FieldOffset(Offset = "0x98")]
		private List<LoadoutSkinElement> mSpawnedSkinElements;

		// Token: 0x04003BFF RID: 15359
		[Token(Token = "0x4003BFF")]
		[FieldOffset(Offset = "0xA0")]
		private UIPool<LoadoutAttachmentTitle> mTitlePool;

		// Token: 0x04003C00 RID: 15360
		[Token(Token = "0x4003C00")]
		[FieldOffset(Offset = "0xA8")]
		private UIPool<LoadoutAttachmentElement> mItemPool;

		// Token: 0x04003C01 RID: 15361
		[Token(Token = "0x4003C01")]
		[FieldOffset(Offset = "0xB0")]
		private UIPool<LoadoutSkinList> mSkinListPool;

		// Token: 0x04003C02 RID: 15362
		[Token(Token = "0x4003C02")]
		[FieldOffset(Offset = "0xB8")]
		private UIPool<LoadoutSkinElement> mSkinElementPool;

		// Token: 0x020007AD RID: 1965
		[Token(Token = "0x20007AD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06013D07 RID: 81159 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D07")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x06013D08 RID: 81160 RVA: 0x0007D654 File Offset: 0x0007B854
			[Token(Token = "0x6013D08")]
			[Address(RVA = "0x1803EE0", Offset = "0x18032E0", VA = "0x181803EE0")]
			internal int <LoadScopes>b__0(AScope x, AScope y)
			{
				return 0;
			}

			// Token: 0x06013D09 RID: 81161 RVA: 0x0007D66C File Offset: 0x0007B86C
			[Token(Token = "0x6013D09")]
			[Address(RVA = "0x1803EE0", Offset = "0x18032E0", VA = "0x181803EE0")]
			internal int <LoadScopes>b__1(AScope x, AScope y)
			{
				return 0;
			}

			// Token: 0x06013D0A RID: 81162 RVA: 0x0007D684 File Offset: 0x0007B884
			[Token(Token = "0x6013D0A")]
			[Address(RVA = "0x1803EE0", Offset = "0x18032E0", VA = "0x181803EE0")]
			internal int <LoadScopes>b__2(AScope x, AScope y)
			{
				return 0;
			}

			// Token: 0x06013D0B RID: 81163 RVA: 0x0007D69C File Offset: 0x0007B89C
			[Token(Token = "0x6013D0B")]
			[Address(RVA = "0x1803EE0", Offset = "0x18032E0", VA = "0x181803EE0")]
			internal int <LoadScopes>b__3(AScope x, AScope y)
			{
				return 0;
			}

			// Token: 0x04003C03 RID: 15363
			[Token(Token = "0x4003C03")]
			[FieldOffset(Offset = "0x10")]
			public AWeapon Item;
		}

		// Token: 0x020007AE RID: 1966
		[Token(Token = "0x20007AE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06013D0C RID: 81164 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D0C")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06013D0D RID: 81165 RVA: 0x0007D6B4 File Offset: 0x0007B8B4
			[Token(Token = "0x6013D0D")]
			[Address(RVA = "0x1803F90", Offset = "0x1803390", VA = "0x181803F90")]
			internal int <LoadTopScopes>b__0(ATopSight x, ATopSight y)
			{
				return 0;
			}

			// Token: 0x04003C04 RID: 15364
			[Token(Token = "0x4003C04")]
			[FieldOffset(Offset = "0x10")]
			public AWeapon Item;
		}

		// Token: 0x020007AF RID: 1967
		[Token(Token = "0x20007AF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06013D0E RID: 81166 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D0E")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x06013D0F RID: 81167 RVA: 0x0007D6CC File Offset: 0x0007B8CC
			[Token(Token = "0x6013D0F")]
			[Address(RVA = "0x1804040", Offset = "0x1803440", VA = "0x181804040")]
			internal int <LoadCantedScopes>b__0(ACanted x, ACanted y)
			{
				return 0;
			}

			// Token: 0x04003C05 RID: 15365
			[Token(Token = "0x4003C05")]
			[FieldOffset(Offset = "0x10")]
			public AWeapon Item;
		}

		// Token: 0x020007B0 RID: 1968
		[Token(Token = "0x20007B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x06013D10 RID: 81168 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D10")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x06013D11 RID: 81169 RVA: 0x0007D6E4 File Offset: 0x0007B8E4
			[Token(Token = "0x6013D11")]
			[Address(RVA = "0x18040F0", Offset = "0x18034F0", VA = "0x1818040F0")]
			internal int <LoadBarrels>b__0(ABarrel x, ABarrel y)
			{
				return 0;
			}

			// Token: 0x06013D12 RID: 81170 RVA: 0x0007D6FC File Offset: 0x0007B8FC
			[Token(Token = "0x6013D12")]
			[Address(RVA = "0x18040F0", Offset = "0x18034F0", VA = "0x1818040F0")]
			internal int <LoadBarrels>b__1(ABarrel x, ABarrel y)
			{
				return 0;
			}

			// Token: 0x04003C06 RID: 15366
			[Token(Token = "0x4003C06")]
			[FieldOffset(Offset = "0x10")]
			public AWeapon Item;
		}

		// Token: 0x020007B1 RID: 1969
		[Token(Token = "0x20007B1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06013D13 RID: 81171 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D13")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06013D14 RID: 81172 RVA: 0x0007D714 File Offset: 0x0007B914
			[Token(Token = "0x6013D14")]
			[Address(RVA = "0x18041A0", Offset = "0x18035A0", VA = "0x1818041A0")]
			internal int <LoadUnderRails>b__0(AUnderRail x, AUnderRail y)
			{
				return 0;
			}

			// Token: 0x04003C07 RID: 15367
			[Token(Token = "0x4003C07")]
			[FieldOffset(Offset = "0x10")]
			public AWeapon Item;
		}

		// Token: 0x020007B2 RID: 1970
		[Token(Token = "0x20007B2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass32_0
		{
			// Token: 0x06013D15 RID: 81173 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D15")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass32_0()
			{
			}

			// Token: 0x06013D16 RID: 81174 RVA: 0x0007D72C File Offset: 0x0007B92C
			[Token(Token = "0x6013D16")]
			[Address(RVA = "0x1804250", Offset = "0x1803650", VA = "0x181804250")]
			internal int <LoadSideRails>b__0(ASideRail x, ASideRail y)
			{
				return 0;
			}

			// Token: 0x04003C08 RID: 15368
			[Token(Token = "0x4003C08")]
			[FieldOffset(Offset = "0x10")]
			public AWeapon Item;
		}

		// Token: 0x020007B3 RID: 1971
		[Token(Token = "0x20007B3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06013D17 RID: 81175 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D17")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x06013D18 RID: 81176 RVA: 0x0007D744 File Offset: 0x0007B944
			[Token(Token = "0x6013D18")]
			[Address(RVA = "0x1804300", Offset = "0x1803700", VA = "0x181804300")]
			internal int <LoadBoltActions>b__0(ABoltAction x, ABoltAction y)
			{
				return 0;
			}

			// Token: 0x04003C09 RID: 15369
			[Token(Token = "0x4003C09")]
			[FieldOffset(Offset = "0x10")]
			public AWeapon Item;
		}

		// Token: 0x020007B4 RID: 1972
		[Token(Token = "0x20007B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06013D1A RID: 81178 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013D1A")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c()
			{
			}

			// Token: 0x06013D1B RID: 81179 RVA: 0x0007D75C File Offset: 0x0007B95C
			[Token(Token = "0x6013D1B")]
			[Address(RVA = "0x1803780", Offset = "0x1802B80", VA = "0x181803780")]
			internal int <LoadMagazines>b__34_0(AWeaponMag x, AWeaponMag y)
			{
				return 0;
			}

			// Token: 0x06013D1C RID: 81180 RVA: 0x0007D774 File Offset: 0x0007B974
			[Token(Token = "0x6013D1C")]
			[Address(RVA = "0x18037C0", Offset = "0x1802BC0", VA = "0x1818037C0")]
			internal int <LoadSkins>b__35_0(AWeaponSkin x, AWeaponSkin y)
			{
				return 0;
			}

			// Token: 0x04003C0A RID: 15370
			[Token(Token = "0x4003C0A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LoadoutAttachmentPanel.<>c <>9;

			// Token: 0x04003C0B RID: 15371
			[Token(Token = "0x4003C0B")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AWeaponMag> <>9__34_0;

			// Token: 0x04003C0C RID: 15372
			[Token(Token = "0x4003C0C")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<AWeaponSkin> <>9__35_0;
		}
	}
}
