using System;
using touching_your_mom;

// Token: 0x02000413 RID: 1043
[Token(Token = "0x2000413")]
[Serializable]
public class AttachmentSettings
{
	// Token: 0x0600AEAC RID: 44716 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600AEAC")]
	[Address(RVA = "0x1F10270", Offset = "0x1F0F670", VA = "0x181F10270")]
	public AttachmentSettings()
	{
	}

	// Token: 0x04001E84 RID: 7812
	[Token(Token = "0x4001E84")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x195640", Offset = "0x194A40")]
	public AttachmentSettings.Variable ReloadSpeed;

	// Token: 0x04001E85 RID: 7813
	[Token(Token = "0x4001E85")]
	[FieldOffset(Offset = "0x18")]
	public AttachmentSettings.Variable DrawSpeed;

	// Token: 0x04001E86 RID: 7814
	[Token(Token = "0x4001E86")]
	[FieldOffset(Offset = "0x20")]
	public AttachmentSettings.Variable AimDownTime;

	// Token: 0x04001E87 RID: 7815
	[Token(Token = "0x4001E87")]
	[FieldOffset(Offset = "0x28")]
	public AttachmentSettings.Variable SwayWeigth;

	// Token: 0x04001E88 RID: 7816
	[Token(Token = "0x4001E88")]
	[FieldOffset(Offset = "0x30")]
	public AttachmentSettings.Variable RunningSpeed;

	// Token: 0x04001E89 RID: 7817
	[Token(Token = "0x4001E89")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x18F860", Offset = "0x18EC60")]
	public AttachmentSettings.Variable VerticalRecoil;

	// Token: 0x04001E8A RID: 7818
	[Token(Token = "0x4001E8A")]
	[FieldOffset(Offset = "0x40")]
	public AttachmentSettings.Variable HorizontalRecoil;

	// Token: 0x04001E8B RID: 7819
	[Token(Token = "0x4001E8B")]
	[FieldOffset(Offset = "0x48")]
	public AttachmentSettings.Variable FirstShotRecoil;

	// Token: 0x04001E8C RID: 7820
	[Token(Token = "0x4001E8C")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x195720", Offset = "0x194B20")]
	public AttachmentSettings.Variable Firerate;

	// Token: 0x04001E8D RID: 7821
	[Token(Token = "0x4001E8D")]
	[FieldOffset(Offset = "0x58")]
	public AttachmentSettings.Variable GunShotSoundDistance;

	// Token: 0x04001E8E RID: 7822
	[Token(Token = "0x4001E8E")]
	[FieldOffset(Offset = "0x60")]
	public AttachmentSettings.Variable MuzzleScale;

	// Token: 0x04001E8F RID: 7823
	[Token(Token = "0x4001E8F")]
	[FieldOffset(Offset = "0x68")]
	public bool EnableSuppressor;

	// Token: 0x04001E90 RID: 7824
	[Token(Token = "0x4001E90")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x195780", Offset = "0x194B80")]
	public AttachmentSettings.Variable ProjectileVelocity;

	// Token: 0x04001E91 RID: 7825
	[Token(Token = "0x4001E91")]
	[FieldOffset(Offset = "0x74")]
	public AttachmentSettings.Variable ProjectileGravity;

	// Token: 0x04001E92 RID: 7826
	[Token(Token = "0x4001E92")]
	[FieldOffset(Offset = "0x7C")]
	public AttachmentSettings.Variable ProjectileAccuracy;

	// Token: 0x04001E93 RID: 7827
	[Token(Token = "0x4001E93")]
	[FieldOffset(Offset = "0x84")]
	public AttachmentSettings.Variable ProjectileDrag;

	// Token: 0x04001E94 RID: 7828
	[Token(Token = "0x4001E94")]
	[FieldOffset(Offset = "0x8C")]
	public AttachmentSettings.Variable ProjectileBodyDamage;

	// Token: 0x04001E95 RID: 7829
	[Token(Token = "0x4001E95")]
	[FieldOffset(Offset = "0x94")]
	public AttachmentSettings.Variable ProjectileLightVehicleDamage;

	// Token: 0x04001E96 RID: 7830
	[Token(Token = "0x4001E96")]
	[FieldOffset(Offset = "0x9C")]
	public AttachmentSettings.Variable ProjectileHeavyVehicleDamage;

	// Token: 0x04001E97 RID: 7831
	[Token(Token = "0x4001E97")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x17D970", Offset = "0x17CD70")]
	public AttachmentSettings.Variable BoltActionSpeed;

	// Token: 0x04001E98 RID: 7832
	[Token(Token = "0x4001E98")]
	[FieldOffset(Offset = "0xAC")]
	public bool EnableAutoBoltAction;

	// Token: 0x04001E99 RID: 7833
	[Token(Token = "0x4001E99")]
	[FieldOffset(Offset = "0xAD")]
	public bool EnableActionWhileAiming;

	// Token: 0x02000414 RID: 1044
	[Token(Token = "0x2000414")]
	[Serializable]
	public struct Variable
	{
		// Token: 0x0600AEAD RID: 44717 RVA: 0x00042D7C File Offset: 0x00040F7C
		[Token(Token = "0x600AEAD")]
		[Address(RVA = "0x1F108F0", Offset = "0x1F0FCF0", VA = "0x181F108F0")]
		public float \u0308\u0305\u0303\u0303\u0302\u0308\u0304\u0307\u0307\u0304\u0302\u0301\u0305\u0303\u0305(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x00042D94 File Offset: 0x00040F94
		[Token(Token = "0x600AEAE")]
		[Address(RVA = "0x1F108F0", Offset = "0x1F0FCF0", VA = "0x181F108F0")]
		public float \u0305\u0306\u0308\u0301\u0302\u0301\u0303\u0306\u0301\u0305\u0305\u0303\u0305\u0304\u0305(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x00042DAC File Offset: 0x00040FAC
		[Token(Token = "0x600AEAF")]
		[Address(RVA = "0x1F10920", Offset = "0x1F0FD20", VA = "0x181F10920")]
		public float \u0308\u0304\u0306\u0301\u0305\u0307\u0308\u0308\u0304\u0302\u0306\u0305\u0306\u0308\u0307(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEB0")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0301\u0305\u0306\u0305\u0302\u0307\u0308\u0308\u0308\u0304\u0301\u0307\u0306\u0305\u0303(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEB1")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0307\u0307\u0306\u0306\u0306\u0305\u0302\u0302\u0307\u0303\u0306\u0308\u0304\u0308\u0306(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x00042DC4 File Offset: 0x00040FC4
		[Token(Token = "0x600AEB2")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0308\u0305\u0303\u0304\u0304\u0303\u0305\u0301\u0303\u0305\u0301\u0308\u0303\u0304\u0303(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEB3 RID: 44723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEB3")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0304\u0305\u0305\u0302\u0308\u0306\u0303\u0305\u0304\u0304\u0304\u0304\u0303\u0308\u0302(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEB4 RID: 44724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEB4")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0304\u0306\u0306\u0302\u0303\u0302\u0306\u0304\u0301\u0308\u0305\u0301\u0307\u0307\u0305(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEB5 RID: 44725 RVA: 0x00042DDC File Offset: 0x00040FDC
		[Token(Token = "0x600AEB5")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0304\u0303\u0308\u0301\u0304\u0308\u0304\u0307\u0304\u0308\u0304\u0301\u0302\u0304\u0301(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEB6 RID: 44726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEB6")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0306\u0308\u0301\u0305\u0308\u0304\u0307\u0307\u0302\u0303\u0308\u0301\u0302\u0303\u0304(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEB7 RID: 44727 RVA: 0x00042DF4 File Offset: 0x00040FF4
		[Token(Token = "0x600AEB7")]
		[Address(RVA = "0x1F108F0", Offset = "0x1F0FCF0", VA = "0x181F108F0")]
		public float \u0301\u0301\u0305\u0307\u0303\u0305\u0307\u0301\u0307\u0307\u0308\u0305\u0304\u0302\u0307(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x00042E0C File Offset: 0x0004100C
		[Token(Token = "0x600AEB8")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0307\u0303\u0305\u0303\u0304\u0304\u0308\u0303\u0308\u0302\u0304\u0305\u0303\u0301\u0303(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x00042E24 File Offset: 0x00041024
		[Token(Token = "0x600AEB9")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0303\u0305\u0307\u0304\u0303\u0304\u0304\u0308\u0305\u0308\u0307\u0304\u0303\u0305\u0306(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEBA RID: 44730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEBA")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0306\u0308\u0301\u0305\u0308\u0304\u0307\u0307\u0302\u0303\u0308\u0301\u0302\u0303\u0304(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEBB RID: 44731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEBB")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0306\u0307\u0308\u0306\u0307\u0306\u0305\u0305\u0302\u0305\u0301\u0307\u0308\u0308\u0305(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEBC RID: 44732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEBC")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0301\u0306\u0303\u0304\u0307\u0307\u0306\u0304\u0305\u0303\u0308\u0302\u0302\u0304\u0307(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEBD")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0305\u0303\u0306\u0303\u0303\u0305\u0305\u0304\u0303\u0304\u0302\u0308\u0306\u0307\u0305(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEBE")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0302\u0304\u0307\u0302\u0308\u0305\u0305\u0308\u0304\u0302\u0302\u0301\u0301\u0303\u0307(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEBF RID: 44735 RVA: 0x00042E3C File Offset: 0x0004103C
		[Token(Token = "0x600AEBF")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0306\u0308\u0301\u0305\u0308\u0304\u0307\u0307\u0302\u0303\u0308\u0301\u0302\u0303\u0304(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x00042E54 File Offset: 0x00041054
		[Token(Token = "0x600AEC0")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0307\u0303\u0301\u0308\u0303\u0305\u0306\u0304\u0302\u0307\u0308\u0303\u0304\u0301\u0306(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEC1")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0301\u0307\u0302\u0305\u0302\u0305\u0306\u0301\u0302\u0307\u0304\u0307\u0302\u0303\u0304(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x00042E6C File Offset: 0x0004106C
		[Token(Token = "0x600AEC2")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0305\u0307\u0302\u0304\u0308\u0306\u0301\u0305\u0302\u0308\u0306\u0308\u0302\u0302\u0305(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEC3")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0302\u0308\u0307\u0305\u0306\u0304\u0304\u0306\u0303\u0307\u0305\u0307\u0303\u0308\u0304(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEC4")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0302\u0304\u0307\u0304\u0301\u0306\u0308\u0303\u0301\u0303\u0301\u0307\u0302\u0306\u0307(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEC5")]
		[Address(RVA = "0x91B400", Offset = "0x91A800", VA = "0x18091B400")]
		public Variable(float \u0302\u0303\u0303\u0304\u0301\u0303\u0306\u0306\u0307\u0306\u0306\u0308\u0304\u0306\u0305, float \u0306\u0307\u0303\u0303\u0308\u0307\u0307\u0307\u0301\u0304\u0306\u0302\u0308\u0305\u0306)
		{
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEC6")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0308\u0306\u0302\u0301\u0303\u0306\u0305\u0303\u0307\u0308\u0304\u0303\u0304\u0305\u0302(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEC7")]
		[Address(RVA = "0x1F10980", Offset = "0x1F0FD80", VA = "0x181F10980")]
		public void \u0307\u0303\u0302\u0303\u0305\u0305\u0306\u0305\u0303\u0302\u0302\u0308\u0301\u0304\u0302(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x00042E84 File Offset: 0x00041084
		[Token(Token = "0x600AEC8")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0303\u0306\u0308\u0302\u0302\u0301\u0304\u0303\u0306\u0301\u0301\u0302\u0302\u0305\u0305(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEC9")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0301\u0308\u0307\u0307\u0302\u0306\u0302\u0307\u0307\u0304\u0304\u0308\u0305\u0303\u0304(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x00042E9C File Offset: 0x0004109C
		[Token(Token = "0x600AECA")]
		[Address(RVA = "0x1F108F0", Offset = "0x1F0FCF0", VA = "0x181F108F0")]
		public float \u0303\u0301\u0306\u0308\u0305\u0308\u0306\u0303\u0301\u0308\u0301\u0304\u0306\u0304\u0305(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x00042EB4 File Offset: 0x000410B4
		[Token(Token = "0x600AECB")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0307\u0308\u0301\u0303\u0304\u0302\u0301\u0307\u0304\u0301\u0308\u0308\u0305\u0306\u0304(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AECC")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0304\u0303\u0307\u0301\u0304\u0305\u0307\u0303\u0302\u0305\u0303\u0305\u0302\u0308\u0308(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AECD")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0302\u0308\u0302\u0305\u0301\u0302\u0308\u0306\u0305\u0306\u0306\u0305\u0308\u0304\u0304(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AECE")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0303\u0306\u0302\u0305\u0303\u0301\u0304\u0301\u0307\u0302\u0305\u0307\u0306\u0303\u0304(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AECF RID: 44751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AECF")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0306\u0306\u0305\u0305\u0302\u0308\u0307\u0307\u0303\u0301\u0305\u0304\u0302\u0302\u0307(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x00042ECC File Offset: 0x000410CC
		[Token(Token = "0x600AED0")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0303\u0303\u0308\u0307\u0301\u0302\u0306\u0308\u0306\u0306\u0308\u0305\u0305\u0307\u0304(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x00042EE4 File Offset: 0x000410E4
		[Token(Token = "0x600AED1")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0302\u0306\u0307\u0305\u0308\u0304\u0301\u0301\u0303\u0308\u0307\u0305\u0308\u0301\u0303(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AED2")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0308\u0302\u0302\u0302\u0307\u0303\u0307\u0303\u0306\u0303\u0307\u0306\u0301\u0301\u0306(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AED3")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0306\u0305\u0304\u0303\u0308\u0301\u0308\u0304\u0303\u0304\u0301\u0307\u0305\u0307\u0303(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AED4")]
		[Address(RVA = "0x1F10980", Offset = "0x1F0FD80", VA = "0x181F10980")]
		public void \u0308\u0305\u0301\u0308\u0306\u0302\u0301\u0308\u0303\u0306\u0308\u0306\u0304\u0306\u0305(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AED5")]
		[Address(RVA = "0x1F10980", Offset = "0x1F0FD80", VA = "0x181F10980")]
		public void \u0308\u0306\u0305\u0301\u0301\u0304\u0305\u0304\u0308\u0304\u0306\u0301\u0307\u0308\u0302(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x00042EFC File Offset: 0x000410FC
		[Token(Token = "0x600AED6")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0301\u0306\u0307\u0305\u0305\u0304\u0303\u0307\u0306\u0302\u0306\u0304\u0301\u0307\u0304(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AED7 RID: 44759 RVA: 0x00042F14 File Offset: 0x00041114
		[Token(Token = "0x600AED7")]
		[Address(RVA = "0x1F10920", Offset = "0x1F0FD20", VA = "0x181F10920")]
		public float \u0305\u0306\u0308\u0304\u0303\u0303\u0308\u0306\u0306\u0307\u0304\u0304\u0307\u0307\u0301(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x00042F2C File Offset: 0x0004112C
		[Token(Token = "0x600AED8")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0301\u0308\u0306\u0302\u0307\u0307\u0304\u0308\u0305\u0306\u0302\u0307\u0304\u0305\u0303(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AED9")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0305\u0307\u0302\u0304\u0308\u0306\u0301\u0305\u0302\u0308\u0306\u0308\u0302\u0302\u0305(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEDA")]
		[Address(RVA = "0x1F10980", Offset = "0x1F0FD80", VA = "0x181F10980")]
		public void \u0305\u0303\u0304\u0306\u0304\u0303\u0305\u0305\u0305\u0306\u0301\u0307\u0306\u0307\u0308(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEDB")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0305\u0301\u0303\u0307\u0308\u0304\u0302\u0307\u0303\u0301\u0301\u0304\u0302\u0306\u0308(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x00042F44 File Offset: 0x00041144
		[Token(Token = "0x600AEDC")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0305\u0308\u0301\u0305\u0302\u0302\u0302\u0304\u0302\u0301\u0301\u0305\u0307\u0301\u0308(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x00042F5C File Offset: 0x0004115C
		[Token(Token = "0x600AEDD")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0305\u0301\u0304\u0306\u0307\u0306\u0306\u0306\u0306\u0304\u0308\u0308\u0304\u0308\u0304(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEDE")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0304\u0304\u0306\u0302\u0308\u0308\u0307\u0302\u0305\u0305\u0302\u0304\u0307\u0308\u0308(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x00042F74 File Offset: 0x00041174
		[Token(Token = "0x600AEDF")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0308\u0303\u0305\u0308\u0308\u0302\u0306\u0301\u0304\u0307\u0302\u0301\u0306\u0302\u0303(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x00042F8C File Offset: 0x0004118C
		[Token(Token = "0x600AEE0")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0301\u0301\u0301\u0302\u0305\u0301\u0303\u0307\u0308\u0304\u0307\u0307\u0303\u0306\u0301(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEE1")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0308\u0303\u0301\u0305\u0305\u0308\u0301\u0302\u0305\u0304\u0305\u0301\u0307\u0307\u0306(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x00042FA4 File Offset: 0x000411A4
		[Token(Token = "0x600AEE2")]
		[Address(RVA = "0x1F10920", Offset = "0x1F0FD20", VA = "0x181F10920")]
		public float \u0305\u0301\u0307\u0304\u0307\u0303\u0307\u0305\u0308\u0303\u0307\u0306\u0301\u0308\u0306(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEE3")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0305\u0308\u0305\u0306\u0302\u0308\u0307\u0305\u0302\u0305\u0302\u0304\u0304\u0305\u0304(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x00042FBC File Offset: 0x000411BC
		[Token(Token = "0x600AEE4")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0307\u0303\u0301\u0308\u0304\u0302\u0304\u0306\u0308\u0302\u0308\u0303\u0306\u0308\u0304(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEE5")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0303\u0304\u0307\u0301\u0301\u0302\u0301\u0307\u0306\u0306\u0303\u0306\u0302\u0304\u0305(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEE6")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0303\u0304\u0304\u0303\u0302\u0307\u0307\u0302\u0307\u0306\u0307\u0305\u0303\u0308\u0306(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEE7")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0301\u0308\u0304\u0302\u0301\u0307\u0306\u0302\u0307\u0304\u0308\u0304\u0308\u0306\u0307(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEE8")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0305\u0302\u0305\u0306\u0305\u0303\u0301\u0301\u0301\u0304\u0301\u0304\u0303\u0307\u0307(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEE9 RID: 44777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEE9")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0303\u0303\u0303\u0306\u0303\u0305\u0304\u0301\u0304\u0301\u0304\u0301\u0308\u0301\u0304(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEEA RID: 44778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEEA")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0306\u0308\u0307\u0306\u0306\u0304\u0308\u0306\u0301\u0306\u0302\u0301\u0304\u0303\u0305(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEEB RID: 44779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEEB")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0308\u0304\u0302\u0303\u0306\u0302\u0302\u0304\u0303\u0305\u0303\u0302\u0307\u0307\u0304(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x00042FD4 File Offset: 0x000411D4
		[Token(Token = "0x600AEEC")]
		[Address(RVA = "0x1F10920", Offset = "0x1F0FD20", VA = "0x181F10920")]
		public float \u0307\u0302\u0306\u0308\u0305\u0307\u0306\u0307\u0303\u0307\u0308\u0308\u0308\u0305\u0306(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEED")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0304\u0301\u0304\u0306\u0303\u0307\u0302\u0305\u0305\u0303\u0301\u0305\u0304\u0306\u0306(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x00042FEC File Offset: 0x000411EC
		[Token(Token = "0x600AEEE")]
		[Address(RVA = "0x1F10920", Offset = "0x1F0FD20", VA = "0x181F10920")]
		public float \u0302\u0305\u0307\u0305\u0302\u0303\u0303\u0304\u0301\u0308\u0308\u0306\u0305\u0302\u0302(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEEF RID: 44783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEEF")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0307\u0308\u0302\u0303\u0302\u0305\u0305\u0307\u0306\u0307\u0302\u0305\u0301\u0302\u0308(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEF0")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0304\u0308\u0305\u0301\u0302\u0303\u0301\u0301\u0307\u0308\u0306\u0303\u0303\u0303\u0306(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEF1")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0306\u0304\u0303\u0302\u0307\u0305\u0304\u0305\u0301\u0304\u0307\u0307\u0308\u0306\u0302(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x00043004 File Offset: 0x00041204
		[Token(Token = "0x600AEF2")]
		[Address(RVA = "0x1F108F0", Offset = "0x1F0FCF0", VA = "0x181F108F0")]
		public float \u0306\u0308\u0301\u0305\u0308\u0304\u0307\u0307\u0302\u0303\u0308\u0301\u0302\u0303\u0304(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEF3")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0308\u0308\u0304\u0304\u0307\u0302\u0306\u0303\u0303\u0306\u0301\u0305\u0306\u0303\u0302(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEF4")]
		[Address(RVA = "0x1F10980", Offset = "0x1F0FD80", VA = "0x181F10980")]
		public void \u0306\u0302\u0301\u0305\u0308\u0307\u0307\u0301\u0301\u0308\u0308\u0304\u0306\u0303\u0303(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEF5")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0304\u0303\u0303\u0301\u0305\u0304\u0308\u0304\u0306\u0307\u0306\u0305\u0307\u0308\u0302(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x0004301C File Offset: 0x0004121C
		[Token(Token = "0x600AEF6")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0306\u0305\u0308\u0301\u0308\u0302\u0301\u0305\u0304\u0305\u0304\u0306\u0304\u0307\u0301(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEF7 RID: 44791 RVA: 0x00043034 File Offset: 0x00041234
		[Token(Token = "0x600AEF7")]
		[Address(RVA = "0x1F109F0", Offset = "0x1F0FDF0", VA = "0x181F109F0")]
		public float \u0305\u0301\u0306\u0303\u0308\u0307\u0305\u0307\u0304\u0306\u0308\u0305\u0306\u0302\u0303(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEF8 RID: 44792 RVA: 0x0004304C File Offset: 0x0004124C
		[Token(Token = "0x600AEF8")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0306\u0301\u0301\u0303\u0302\u0306\u0303\u0304\u0308\u0305\u0306\u0302\u0306\u0305\u0306(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEF9 RID: 44793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEF9")]
		[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", VA = "0x181F109D0")]
		public void \u0306\u0307\u0303\u0306\u0303\u0307\u0307\u0307\u0304\u0303\u0302\u0304\u0302\u0307\u0308(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEFA RID: 44794 RVA: 0x00043064 File Offset: 0x00041264
		[Token(Token = "0x600AEFA")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0303\u0308\u0302\u0305\u0304\u0308\u0304\u0303\u0306\u0307\u0308\u0308\u0305\u0306\u0308(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEFB RID: 44795 RVA: 0x0004307C File Offset: 0x0004127C
		[Token(Token = "0x600AEFB")]
		[Address(RVA = "0x1F108F0", Offset = "0x1F0FCF0", VA = "0x181F108F0")]
		public float \u0308\u0301\u0306\u0306\u0305\u0301\u0303\u0303\u0301\u0303\u0301\u0304\u0308\u0307\u0302(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AEFC RID: 44796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEFC")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0301\u0304\u0302\u0304\u0303\u0308\u0305\u0307\u0304\u0305\u0304\u0307\u0306\u0302\u0308(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEFD")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0304\u0308\u0306\u0306\u0307\u0301\u0303\u0303\u0302\u0302\u0308\u0308\u0306\u0303\u0303(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEFE")]
		[Address(RVA = "0x1F10980", Offset = "0x1F0FD80", VA = "0x181F10980")]
		public void \u0301\u0305\u0301\u0302\u0305\u0303\u0306\u0304\u0301\u0302\u0306\u0302\u0307\u0302\u0307(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AEFF RID: 44799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AEFF")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0308\u0302\u0301\u0306\u0307\u0308\u0306\u0303\u0307\u0305\u0306\u0308\u0302\u0307\u0308(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AF00 RID: 44800 RVA: 0x00043094 File Offset: 0x00041294
		[Token(Token = "0x600AF00")]
		[Address(RVA = "0x1F10920", Offset = "0x1F0FD20", VA = "0x181F10920")]
		public float \u0302\u0303\u0304\u0302\u0303\u0303\u0303\u0307\u0302\u0306\u0301\u0304\u0301\u0303\u0306(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AF01 RID: 44801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AF01")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0305\u0301\u0307\u0301\u0305\u0302\u0306\u0302\u0302\u0305\u0307\u0301\u0307\u0301\u0306(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AF02")]
		[Address(RVA = "0x1F10950", Offset = "0x1F0FD50", VA = "0x181F10950")]
		public void \u0304\u0305\u0305\u0307\u0307\u0301\u0306\u0301\u0305\u0307\u0303\u0304\u0306\u0307\u0304(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x000430AC File Offset: 0x000412AC
		[Token(Token = "0x600AF03")]
		[Address(RVA = "0x1F108E0", Offset = "0x1F0FCE0", VA = "0x181F108E0")]
		public float \u0303\u0308\u0305\u0305\u0307\u0306\u0303\u0307\u0305\u0303\u0306\u0308\u0302\u0302\u0305(float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AF04")]
		[Address(RVA = "0x1F109B0", Offset = "0x1F0FDB0", VA = "0x181F109B0")]
		public void \u0306\u0305\u0304\u0305\u0302\u0305\u0301\u0304\u0308\u0301\u0301\u0306\u0308\u0307\u0306(ref float \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600AF05")]
		[Address(RVA = "0x1F10980", Offset = "0x1F0FD80", VA = "0x181F10980")]
		public void \u0305\u0307\u0302\u0304\u0308\u0306\u0301\u0305\u0302\u0308\u0306\u0308\u0302\u0302\u0305(ref int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x0600AF06 RID: 44806 RVA: 0x000430C4 File Offset: 0x000412C4
		[Token(Token = "0x600AF06")]
		[Address(RVA = "0x1F10920", Offset = "0x1F0FD20", VA = "0x181F10920")]
		public float \u0301\u0304\u0301\u0302\u0303\u0304\u0308\u0306\u0301\u0304\u0302\u0308\u0306\u0302\u0303(int \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
			return 0f;
		}

		// Token: 0x04001E9A RID: 7834
		[Token(Token = "0x4001E9A")]
		[FieldOffset(Offset = "0x0")]
		public float Addition;

		// Token: 0x04001E9B RID: 7835
		[Token(Token = "0x4001E9B")]
		[FieldOffset(Offset = "0x4")]
		public float Multiplier;
	}
}
