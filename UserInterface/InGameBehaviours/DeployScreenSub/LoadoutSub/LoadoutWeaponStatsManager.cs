using System;
using touching_your_mom;
using PlayerLoadout.Items;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x20007C6")]
	public class LoadoutWeaponStatsManager : MonoBehaviour
	{
		// Token: 0x06013DA2 RID: 81314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DA2")]
		[Address(RVA = "0x17FEA00", Offset = "0x17FDE00", VA = "0x1817FEA00")]
		public LoadoutWeaponStatsManager()
		{
		}

		// Token: 0x06013DA3 RID: 81315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DA3")]
		[Address(RVA = "0x17FDBE0", Offset = "0x17FCFE0", VA = "0x1817FDBE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06013DA4 RID: 81316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DA4")]
		[Address(RVA = "0x17FDAE0", Offset = "0x17FCEE0", VA = "0x1817FDAE0")]
		public void Focus(AWeapon item)
		{
		}

		// Token: 0x04003CDB RID: 15579
		[Token(Token = "0x4003CDB")]
		[FieldOffset(Offset = "0x0")]
		public static LoadoutWeaponStatsManager Instance;

		// Token: 0x04003CDC RID: 15580
		[Token(Token = "0x4003CDC")]
		[FieldOffset(Offset = "0x8")]
		public static \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 PrimaryAttachments;

		// Token: 0x04003CDD RID: 15581
		[Token(Token = "0x4003CDD")]
		[FieldOffset(Offset = "0x10")]
		public static \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 SecondaryAttachments;

		// Token: 0x04003CDE RID: 15582
		[Token(Token = "0x4003CDE")]
		[FieldOffset(Offset = "0x18")]
		public LoadoutWeaponStatsSlider DamageBody;

		// Token: 0x04003CDF RID: 15583
		[Token(Token = "0x4003CDF")]
		[FieldOffset(Offset = "0x20")]
		public LoadoutWeaponStatsSlider DamageArmor;

		// Token: 0x04003CE0 RID: 15584
		[Token(Token = "0x4003CE0")]
		[FieldOffset(Offset = "0x28")]
		public LoadoutWeaponStatsSlider DamageLightVehicle;

		// Token: 0x04003CE1 RID: 15585
		[Token(Token = "0x4003CE1")]
		[FieldOffset(Offset = "0x30")]
		public LoadoutWeaponStatsSlider DamageHeavyVehicle;

		// Token: 0x04003CE2 RID: 15586
		[Token(Token = "0x4003CE2")]
		[FieldOffset(Offset = "0x38")]
		public LoadoutWeaponStatsSlider VerticalRecoil;

		// Token: 0x04003CE3 RID: 15587
		[Token(Token = "0x4003CE3")]
		[FieldOffset(Offset = "0x40")]
		public LoadoutWeaponStatsSlider HorizontalRecoil;

		// Token: 0x04003CE4 RID: 15588
		[Token(Token = "0x4003CE4")]
		[FieldOffset(Offset = "0x48")]
		public LoadoutWeaponStatsSlider FirstShotKick;

		// Token: 0x04003CE5 RID: 15589
		[Token(Token = "0x4003CE5")]
		[FieldOffset(Offset = "0x50")]
		public LoadoutWeaponStatsSlider Controll;

		// Token: 0x04003CE6 RID: 15590
		[Token(Token = "0x4003CE6")]
		[FieldOffset(Offset = "0x58")]
		public LoadoutWeaponStatsSlider DrawSpeed;

		// Token: 0x04003CE7 RID: 15591
		[Token(Token = "0x4003CE7")]
		[FieldOffset(Offset = "0x60")]
		public LoadoutWeaponStatsSlider Accuracy;

		// Token: 0x04003CE8 RID: 15592
		[Token(Token = "0x4003CE8")]
		[FieldOffset(Offset = "0x68")]
		public LoadoutWeaponStatsSlider Firerate;

		// Token: 0x04003CE9 RID: 15593
		[Token(Token = "0x4003CE9")]
		[FieldOffset(Offset = "0x70")]
		public LoadoutWeaponStatsSlider ShotSoundDistance;

		// Token: 0x04003CEA RID: 15594
		[Token(Token = "0x4003CEA")]
		[FieldOffset(Offset = "0x78")]
		public LoadoutWeaponStatsSlider MuzzleScale;

		// Token: 0x04003CEB RID: 15595
		[Token(Token = "0x4003CEB")]
		[FieldOffset(Offset = "0x80")]
		public LoadoutWeaponStatsSlider Velocity;

		// Token: 0x04003CEC RID: 15596
		[Token(Token = "0x4003CEC")]
		[FieldOffset(Offset = "0x88")]
		public LoadoutWeaponStatsSlider AimDownTime;

		// Token: 0x04003CED RID: 15597
		[Token(Token = "0x4003CED")]
		[FieldOffset(Offset = "0x90")]
		public LoadoutWeaponStatsSlider RunningSpeed;

		// Token: 0x04003CEE RID: 15598
		[Token(Token = "0x4003CEE")]
		[FieldOffset(Offset = "0x98")]
		public LoadoutWeaponStatsSlider ReloadTime;

		// Token: 0x04003CEF RID: 15599
		[Token(Token = "0x4003CEF")]
		[FieldOffset(Offset = "0xA0")]
		public LoadoutWeaponStatsSlider BoltActionSpeed;

		// Token: 0x04003CF0 RID: 15600
		[Token(Token = "0x4003CF0")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject AutoBoltActionSpace;

		// Token: 0x04003CF1 RID: 15601
		[Token(Token = "0x4003CF1")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject AutoBoltAction;

		// Token: 0x04003CF2 RID: 15602
		[Token(Token = "0x4003CF2")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject BoltActionWhileADS;

		// Token: 0x04003CF3 RID: 15603
		[Token(Token = "0x4003CF3")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17C960", Offset = "0x17BD60")]
		public WeaponRangeTable Table;

		// Token: 0x04003CF4 RID: 15604
		[Token(Token = "0x4003CF4")]
		[FieldOffset(Offset = "0xC8")]
		private AWeapon mWeapon;

		// Token: 0x04003CF5 RID: 15605
		[Token(Token = "0x4003CF5")]
		[FieldOffset(Offset = "0xD0")]
		private \u0303\u0303\u0303\u0302\u0304\u0303\u0306\u0307\u0301\u0306\u0302\u0301\u0303\u0308\u0302 mLastHoverAttachmentItem;
	}
}
