using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using touching_your_mom;
using PlayerLoadout.Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UserInterface.Extentions;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x20007BC")]
	public class WeaponRangeTable : MonoBehaviour
	{
		// Token: 0x06013D5E RID: 81246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D5E")]
		[Address(RVA = "0x1804470", Offset = "0x1803870", VA = "0x181804470")]
		private void Awake()
		{
		}

		// Token: 0x06013D5F RID: 81247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D5F")]
		[Address(RVA = "0x1804670", Offset = "0x1803A70", VA = "0x181804670")]
		public void Set(AWeapon weapon, ToolStats original, ToolStats newStats)
		{
		}

		// Token: 0x06013D60 RID: 81248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D60")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public WeaponRangeTable()
		{
		}

		// Token: 0x06013D61 RID: 81249 RVA: 0x0007D7EC File Offset: 0x0007B9EC
		[Token(Token = "0x6013D61")]
		[Address(RVA = "0x1804DA0", Offset = "0x18041A0", VA = "0x181804DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <Set>g__Return|18_0(ref WeaponRangeTable.<>c__DisplayClass18_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x06013D62 RID: 81250 RVA: 0x0007D804 File Offset: 0x0007BA04
		[Token(Token = "0x6013D62")]
		[Address(RVA = "0x1804EA0", Offset = "0x18042A0", VA = "0x181804EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private float <Set>g__sampleDamage|18_1(AnimationCurve c, float x, float y, ref WeaponRangeTable.<>c__DisplayClass18_0 A_4)
		{
			return 0f;
		}

		// Token: 0x06013D63 RID: 81251 RVA: 0x0007D81C File Offset: 0x0007BA1C
		[Token(Token = "0x6013D63")]
		[Address(RVA = "0x1804F30", Offset = "0x1804330", VA = "0x181804F30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private float <Set>g__sampleDrop|18_2(AnimationCurve c, float x, float y, ref WeaponRangeTable.<>c__DisplayClass18_0 A_4)
		{
			return 0f;
		}

		// Token: 0x04003C65 RID: 15461
		[Token(Token = "0x4003C65")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		private static Texture2D mTexture;

		// Token: 0x04003C66 RID: 15462
		[Token(Token = "0x4003C66")]
		private const int HorizontalZoom = 4;

		// Token: 0x04003C67 RID: 15463
		[Token(Token = "0x4003C67")]
		private const int VerticalZoom = 1;

		// Token: 0x04003C68 RID: 15464
		[Token(Token = "0x4003C68")]
		private const int Width = 250;

		// Token: 0x04003C69 RID: 15465
		[Token(Token = "0x4003C69")]
		private const int Height = 200;

		// Token: 0x04003C6A RID: 15466
		[Token(Token = "0x4003C6A")]
		private const float Thickness = 2f;

		// Token: 0x04003C6B RID: 15467
		[Token(Token = "0x4003C6B")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		public RawImage Output;

		// Token: 0x04003C6C RID: 15468
		[Token(Token = "0x4003C6C")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public GameObject ItemPrefab;

		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		private UIPool<TextMeshProUGUI> mPool;

		// Token: 0x04003C6E RID: 15470
		[Token(Token = "0x4003C6E")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		private List<TextMeshProUGUI> mAcitve;

		// Token: 0x04003C6F RID: 15471
		[Token(Token = "0x4003C6F")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		private AWeapon mLastWeapon;

		// Token: 0x04003C70 RID: 15472
		[Token(Token = "0x4003C70")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private float mLastOriginalVelocity;

		// Token: 0x04003C71 RID: 15473
		[Token(Token = "0x4003C71")]
		[touching_your_mom.FieldOffset(Offset = "0x44")]
		private float mLastOriginalGravity;

		// Token: 0x04003C72 RID: 15474
		[Token(Token = "0x4003C72")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		private float mLastOriginalDrag;

		// Token: 0x04003C73 RID: 15475
		[Token(Token = "0x4003C73")]
		[touching_your_mom.FieldOffset(Offset = "0x4C")]
		private float mLastNewVelocity;

		// Token: 0x04003C74 RID: 15476
		[Token(Token = "0x4003C74")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		private float mLastNewGravity;

		// Token: 0x04003C75 RID: 15477
		[Token(Token = "0x4003C75")]
		[touching_your_mom.FieldOffset(Offset = "0x54")]
		private float mLastNewDrag;

		// Token: 0x020007BD RID: 1981
		[Token(Token = "0x20007BD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[StructLayout(3)]
		private struct <>c__DisplayClass18_0
		{
			// Token: 0x04003C76 RID: 15478
			[Token(Token = "0x4003C76")]
			[touching_your_mom.FieldOffset(Offset = "0x0")]
			public AWeapon weapon;

			// Token: 0x04003C77 RID: 15479
			[Token(Token = "0x4003C77")]
			[touching_your_mom.FieldOffset(Offset = "0x8")]
			public WeaponRangeTable <>4__this;

			// Token: 0x04003C78 RID: 15480
			[Token(Token = "0x4003C78")]
			[touching_your_mom.FieldOffset(Offset = "0x10")]
			public ToolStats original;

			// Token: 0x04003C79 RID: 15481
			[Token(Token = "0x4003C79")]
			[touching_your_mom.FieldOffset(Offset = "0x18")]
			public ToolStats newStats;

			// Token: 0x04003C7A RID: 15482
			[Token(Token = "0x4003C7A")]
			[touching_your_mom.FieldOffset(Offset = "0x20")]
			public float k;

			// Token: 0x04003C7B RID: 15483
			[Token(Token = "0x4003C7B")]
			[touching_your_mom.FieldOffset(Offset = "0x24")]
			public float damage;
		}
	}
}
