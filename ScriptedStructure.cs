using System;
using System.Collections.Generic;
using touching_your_mom;
using UnityEngine;

// Token: 0x0200014D RID: 333
[Token(Token = "0x200014D")]
public class ScriptedStructure : MonoBehaviour, IFastListItemA
{
	// Token: 0x1700017B RID: 379
	// (get) Token: 0x060038FE RID: 14590 RVA: 0x00017954 File Offset: 0x00015B54
	// (set) Token: 0x060038FF RID: 14591 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700017B")]
	public int FastListIndexA
	{
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0xA6C3F0", Offset = "0xA6B7F0", VA = "0x180A6C3F0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0xABA5B0", Offset = "0xAB99B0", VA = "0x180ABA5B0", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06003900 RID: 14592 RVA: 0x0001796C File Offset: 0x00015B6C
	// (set) Token: 0x06003901 RID: 14593 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700017C")]
	public Vector3 Position
	{
		[Token(Token = "0x6003900")]
		[Address(RVA = "0x1879650", Offset = "0x1878A50", VA = "0x181879650")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6003901")]
		[Address(RVA = "0x1C968C0", Offset = "0x1C95CC0", VA = "0x181C968C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06003902 RID: 14594 RVA: 0x00017984 File Offset: 0x00015B84
	// (set) Token: 0x06003903 RID: 14595 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700017D")]
	public float DistanceToCamera
	{
		[Token(Token = "0x6003902")]
		[Address(RVA = "0xD00800", Offset = "0xCFFC00", VA = "0x180D00800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003903")]
		[Address(RVA = "0xD008B0", Offset = "0xCFFCB0", VA = "0x180D008B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06003904 RID: 14596 RVA: 0x0001799C File Offset: 0x00015B9C
	// (set) Token: 0x06003905 RID: 14597 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700017E")]
	public bool HasFallen
	{
		[Token(Token = "0x6003904")]
		[Address(RVA = "0xD27C20", Offset = "0xD27020", VA = "0x180D27C20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003905")]
		[Address(RVA = "0xE74830", Offset = "0xE73C30", VA = "0x180E74830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06003906 RID: 14598 RVA: 0x000179B4 File Offset: 0x00015BB4
	// (set) Token: 0x06003907 RID: 14599 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700017F")]
	public float FallNetworkStartTime
	{
		[Token(Token = "0x6003906")]
		[Address(RVA = "0xC3F1F0", Offset = "0xC3E5F0", VA = "0x180C3F1F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003907")]
		[Address(RVA = "0xC3F220", Offset = "0xC3E620", VA = "0x180C3F220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06003908 RID: 14600 RVA: 0x000179CC File Offset: 0x00015BCC
	// (set) Token: 0x06003909 RID: 14601 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000180")]
	public ulong Server_FallenBy
	{
		[Token(Token = "0x6003908")]
		[Address(RVA = "0x900D20", Offset = "0x900120", VA = "0x180900D20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0UL;
		}
		[Token(Token = "0x6003909")]
		[Address(RVA = "0x1018090", Offset = "0x1017490", VA = "0x181018090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x0600390A RID: 14602 RVA: 0x000179E4 File Offset: 0x00015BE4
	// (set) Token: 0x0600390B RID: 14603 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000181")]
	public bool IsPlayingAnimation
	{
		[Token(Token = "0x600390A")]
		[Address(RVA = "0xC103D0", Offset = "0xC0F7D0", VA = "0x180C103D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600390B")]
		[Address(RVA = "0x164CFD0", Offset = "0x164C3D0", VA = "0x18164CFD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x0600390C RID: 14604 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x0600390D RID: 14605 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000182")]
	public List<ValueTuple<ManagedBoxCollider, \u0306\u0301\u0306\u0304\u0303\u0304\u0304\u0301\u0308\u0305\u0302\u0303\u0308\u0307\u0304>> Colliders
	{
		[Token(Token = "0x600390C")]
		[Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600390D")]
		[Address(RVA = "0x8AD4E0", Offset = "0x8AC8E0", VA = "0x1808AD4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x0600390E RID: 14606 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x17000183")]
	public virtual \u0308\u0303\u0301\u0308\u0308\u0307\u0305\u0303\u0305\u0307\u0307\u0301\u0306\u0308\u0301 ExistanceProvider
	{
		[Token(Token = "0x600390E")]
		[Address(RVA = "0x9F53A0", Offset = "0x9F47A0", VA = "0x1809F53A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x0600390F RID: 14607 RVA: 0x000179FC File Offset: 0x00015BFC
	[Token(Token = "0x17000184")]
	public float TimeSinceFallen
	{
		[Token(Token = "0x600390F")]
		[Address(RVA = "0x1C95C60", Offset = "0x1C95060", VA = "0x181C95C60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06003910 RID: 14608 RVA: 0x00017A14 File Offset: 0x00015C14
	[Token(Token = "0x17000185")]
	public int NumberOfVariations
	{
		[Token(Token = "0x6003910")]
		[Address(RVA = "0x1C95C40", Offset = "0x1C95040", VA = "0x181C95C40")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06003911 RID: 14609 RVA: 0x00017A2C File Offset: 0x00015C2C
	// (set) Token: 0x06003912 RID: 14610 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000186")]
	public float AnimationLength
	{
		[Token(Token = "0x6003911")]
		[Address(RVA = "0xD00870", Offset = "0xCFFC70", VA = "0x180D00870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003912")]
		[Address(RVA = "0x1C968B0", Offset = "0x1C95CB0", VA = "0x181C968B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x06003913 RID: 14611 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003913")]
	[Address(RVA = "0x1C93890", Offset = "0x1C92C90", VA = "0x181C93890", Slot = "7")]
	public virtual void Awake()
	{
	}

	// Token: 0x06003914 RID: 14612 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003914")]
	[Address(RVA = "0x1C945D0", Offset = "0x1C939D0", VA = "0x181C945D0", Slot = "8")]
	public virtual void OnEnable()
	{
	}

	// Token: 0x06003915 RID: 14613 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003915")]
	[Address(RVA = "0x1C94550", Offset = "0x1C93950", VA = "0x181C94550", Slot = "9")]
	public virtual void OnDisable()
	{
	}

	// Token: 0x06003916 RID: 14614 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003916")]
	[Address(RVA = "0x1C94D20", Offset = "0x1C94120", VA = "0x181C94D20", Slot = "10")]
	public virtual void OnNetworkAwake()
	{
	}

	// Token: 0x06003917 RID: 14615 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003917")]
	[Address(RVA = "0x1C94650", Offset = "0x1C93A50", VA = "0x181C94650", Slot = "11")]
	public virtual void OnLateUpdateEnd()
	{
	}

	// Token: 0x06003918 RID: 14616 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003918")]
	[Address(RVA = "0x1C94440", Offset = "0x1C93840", VA = "0x181C94440", Slot = "12")]
	public virtual void OnClientThreadUpdate()
	{
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003919")]
	[Address(RVA = "0x1C95340", Offset = "0x1C94740", VA = "0x181C95340")]
	public void ServerSide_ApplyDamage(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 by, float damage, int index)
	{
	}

	// Token: 0x0600391A RID: 14618 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600391A")]
	[Address(RVA = "0x1C96050", Offset = "0x1C95450", VA = "0x181C96050")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void mReceivedFall(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
	{
	}

	// Token: 0x0600391B RID: 14619 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600391B")]
	[Address(RVA = "0x1C95940", Offset = "0x1C94D40", VA = "0x181C95940", Slot = "13")]
	public virtual void TeleportToEndState()
	{
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600391C")]
	[Address(RVA = "0x1C95510", Offset = "0x1C94910", VA = "0x181C95510", Slot = "14")]
	public virtual void StartPlaying(int index, bool isServerSide)
	{
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600391D")]
	[Address(RVA = "0x1C951E0", Offset = "0x1C945E0", VA = "0x181C951E0", Slot = "15")]
	public virtual void ResetState()
	{
	}

	// Token: 0x0600391E RID: 14622 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600391E")]
	[Address(RVA = "0x1C96470", Offset = "0x1C95870", VA = "0x181C96470")]
	private void mStopAnimation(bool isServerSide)
	{
	}

	// Token: 0x0600391F RID: 14623 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600391F")]
	[Address(RVA = "0x1C95D00", Offset = "0x1C95100", VA = "0x181C95D00")]
	private void mPlayParticles()
	{
	}

	// Token: 0x06003920 RID: 14624 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003920")]
	[Address(RVA = "0x1C96650", Offset = "0x1C95A50", VA = "0x181C96650")]
	private void mSwitchMeshes()
	{
	}

	// Token: 0x06003921 RID: 14625 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003921")]
	[Address(RVA = "0x1C96190", Offset = "0x1C95590", VA = "0x181C96190")]
	private void mSetAudioSources(bool isEnabled)
	{
	}

	// Token: 0x06003922 RID: 14626 RVA: 0x00017A44 File Offset: 0x00015C44
	[Token(Token = "0x6003922")]
	[Address(RVA = "0x1C95CC0", Offset = "0x1C950C0", VA = "0x181C95CC0")]
	private float mFadeInOut(float x)
	{
		return 0f;
	}

	// Token: 0x06003923 RID: 14627 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003923")]
	[Address(RVA = "0x1C95060", Offset = "0x1C94460", VA = "0x181C95060", Slot = "16")]
	public virtual void OnSnapshotWrite(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
	{
	}

	// Token: 0x06003924 RID: 14628 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003924")]
	[Address(RVA = "0x1C94E20", Offset = "0x1C94220", VA = "0x181C94E20", Slot = "17")]
	public virtual void OnSnapshotRead(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
	{
	}

	// Token: 0x06003925 RID: 14629 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003925")]
	[Address(RVA = "0x1C95C20", Offset = "0x1C95020", VA = "0x181C95C20")]
	public ScriptedStructure()
	{
	}

	// Token: 0x06003927 RID: 14631 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6003927")]
	[Address(RVA = "0x1C95AD0", Offset = "0x1C94ED0", VA = "0x181C95AD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private void <mPlayParticles>b__72_0()
	{
	}

	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x0")]
	public static FastListA<ScriptedStructure> Instances;

	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x18")]
	public ScriptedStructureItem Item;

	// Token: 0x04000863 RID: 2147
	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0x20")]
	public float HP;

	// Token: 0x04000864 RID: 2148
	[Token(Token = "0x4000864")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x140360", Offset = "0x13F760")]
	public Transform[] Parts;

	// Token: 0x04000865 RID: 2149
	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x140390", Offset = "0x13F790")]
	public ScriptedStructure.MeshIndex[] DestroyedMeshes;

	// Token: 0x04000866 RID: 2150
	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ScriptedStructure.ColliderMesh[] DestroyedColliders;

	// Token: 0x04000867 RID: 2151
	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] ObjectsToDestroyWhenFall;

	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private int <FastListIndexA>k__BackingField;

	// Token: 0x04000869 RID: 2153
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x50")]
	private PositionAndQuaternationStruct[] mDefaultStats;

	// Token: 0x0400086A RID: 2154
	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x58")]
	private \u0306\u0301\u0306\u0304\u0303\u0304\u0304\u0301\u0308\u0305\u0302\u0303\u0308\u0307\u0304.\u0303\u0301\u0303\u0303\u0304\u0303\u0307\u0305\u0304\u0307\u0306\u0305\u0308\u0307\u0307[] mVariations;

	// Token: 0x0400086B RID: 2155
	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x60")]
	private \u0304\u0301\u0302\u0304\u0307\u0303\u0303\u0306\u0302\u0305\u0301\u0301\u0305\u0301\u0305[] mHitReceivers;

	// Token: 0x0400086C RID: 2156
	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x68")]
	private \u0302\u0305\u0302\u0306\u0308\u0308\u0302\u0308\u0303\u0304\u0308\u0304\u0307\u0308\u0302 mNetView;

	// Token: 0x0400086D RID: 2157
	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x70")]
	private float mLastSampleTime;

	// Token: 0x0400086E RID: 2158
	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x74")]
	private int mFallenIndex;

	// Token: 0x0400086F RID: 2159
	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x78")]
	private \u0305\u0302\u0306\u0306\u0305\u0301\u0304\u0306\u0305\u0304\u0302\u0302\u0307\u0302\u0301 mProvider;

	// Token: 0x04000870 RID: 2160
	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x80")]
	private bool mIsActive;

	// Token: 0x04000871 RID: 2161
	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x81")]
	private bool mHasAudioSources;

	// Token: 0x04000872 RID: 2162
	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x88")]
	private AudioSource mRumbleAudioSource;

	// Token: 0x04000873 RID: 2163
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x90")]
	private AudioSource mActionAudioSource;

	// Token: 0x04000874 RID: 2164
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private Vector3 <Position>k__BackingField;

	// Token: 0x04000875 RID: 2165
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <DistanceToCamera>k__BackingField;

	// Token: 0x04000876 RID: 2166
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <HasFallen>k__BackingField;

	// Token: 0x04000877 RID: 2167
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <FallNetworkStartTime>k__BackingField;

	// Token: 0x04000878 RID: 2168
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private ulong <Server_FallenBy>k__BackingField;

	// Token: 0x04000879 RID: 2169
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <IsPlayingAnimation>k__BackingField;

	// Token: 0x0400087A RID: 2170
	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private List<ValueTuple<ManagedBoxCollider, \u0306\u0301\u0306\u0304\u0303\u0304\u0304\u0301\u0308\u0305\u0302\u0303\u0308\u0307\u0304>> <Colliders>k__BackingField;

	// Token: 0x0400087B RID: 2171
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <AnimationLength>k__BackingField;

	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	[Serializable]
	public struct MeshIndex
	{
		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x0")]
		public MeshRenderer MeshRenderer;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x8")]
		public Mesh DestroyedMesh;
	}

	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[Serializable]
	public struct ColliderMesh
	{
		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x0")]
		public MeshCollider MeshCollider;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x8")]
		public Mesh DestroyedMesh;
	}
}
