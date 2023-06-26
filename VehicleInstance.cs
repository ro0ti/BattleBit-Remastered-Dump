using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UnityEngine;

// Token: 0x02000333 RID: 819
[Token(Token = "0x2000333")]
public abstract class VehicleInstance : SeatManager, \u0304\u0304\u0302\u0306\u0302\u0308\u0308\u0307\u0306\u0305\u0306\u0306\u0303\u0301\u0308, IComparable<VehicleInstance>, IFastListItemA, \u0306\u0305\u0308\u0307\u0301\u0302\u0302\u0307\u0302\u0302\u0306\u0305\u0307\u0302\u0303
{
	// Token: 0x0600925C RID: 37468 RVA: 0x000383FC File Offset: 0x000365FC
	[Token(Token = "0x600925C")]
	[Address(RVA = "0x1836250", Offset = "0x1835650", VA = "0x181836250")]
	public static int GetEmptyVehicleID()
	{
		return 0;
	}

	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x0600925D RID: 37469 RVA: 0x00038414 File Offset: 0x00036614
	// (set) Token: 0x0600925E RID: 37470 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000568")]
	public static int \u0307\u0304\u0303\u0302\u0305\u0307\u0307\u0302\u0301\u0305\u0308\u0304\u0301\u0304\u0307
	{
		[Token(Token = "0x600925D")]
		[Address(RVA = "0x18402D0", Offset = "0x183F6D0", VA = "0x1818402D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600925E")]
		[Address(RVA = "0x183EF40", Offset = "0x183E340", VA = "0x18183EF40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x0600925F RID: 37471 RVA: 0x0003842C File Offset: 0x0003662C
	// (set) Token: 0x06009260 RID: 37472 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000569")]
	public int \u0305\u0302\u0302\u0304\u0301\u0303\u0307\u0306\u0302\u0304\u0307\u0304\u0308\u0302\u0306
	{
		[Token(Token = "0x600925F")]
		[Address(RVA = "0xABA1B0", Offset = "0xAB95B0", VA = "0x180ABA1B0", Slot = "50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6009260")]
		[Address(RVA = "0xABA640", Offset = "0xAB9A40", VA = "0x180ABA640", Slot = "51")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x06009261 RID: 37473 RVA: 0x00038444 File Offset: 0x00036644
	[Token(Token = "0x1700056A")]
	public virtual bool \u0301\u0307\u0303\u0304\u0307\u0307\u0307\u0306\u0307\u0301\u0302\u0303\u0304\u0302\u0306
	{
		[Token(Token = "0x6009261")]
		[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x06009262 RID: 37474 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009263 RID: 37475 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700056B")]
	public Transform \u0301\u0304\u0303\u0307\u0305\u0303\u0305\u0308\u0307\u0307\u0302\u0306\u0308\u0306\u0304
	{
		[Token(Token = "0x6009262")]
		[Address(RVA = "0xABA1A0", Offset = "0xAB95A0", VA = "0x180ABA1A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009263")]
		[Address(RVA = "0xABA630", Offset = "0xAB9A30", VA = "0x180ABA630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x06009264 RID: 37476 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009265 RID: 37477 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700056C")]
	public Transform \u0306\u0301\u0305\u0307\u0307\u0303\u0302\u0304\u0303\u0307\u0304\u0307\u0307\u0301\u0302
	{
		[Token(Token = "0x6009264")]
		[Address(RVA = "0x933490", Offset = "0x932890", VA = "0x180933490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009265")]
		[Address(RVA = "0x933630", Offset = "0x932A30", VA = "0x180933630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x06009266 RID: 37478 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009267 RID: 37479 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700056D")]
	public Transform \u0306\u0304\u0308\u0301\u0304\u0307\u0302\u0306\u0307\u0305\u0307\u0308\u0305\u0308\u0304
	{
		[Token(Token = "0x6009266")]
		[Address(RVA = "0xABA170", Offset = "0xAB9570", VA = "0x180ABA170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009267")]
		[Address(RVA = "0xABA5F0", Offset = "0xAB99F0", VA = "0x180ABA5F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x06009268 RID: 37480 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009269 RID: 37481 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700056E")]
	public Transform \u0303\u0302\u0307\u0304\u0307\u0305\u0307\u0303\u0304\u0308\u0306\u0301\u0306\u0308\u0301
	{
		[Token(Token = "0x6009268")]
		[Address(RVA = "0x900D20", Offset = "0x900120", VA = "0x180900D20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009269")]
		[Address(RVA = "0x8AD4D0", Offset = "0x8AC8D0", VA = "0x1808AD4D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x0600926A RID: 37482 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x0600926B RID: 37483 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700056F")]
	public \u0304\u0305\u0304\u0304\u0307\u0303\u0307\u0303\u0302\u0308\u0304\u0303\u0303\u0303\u0302 \u0305\u0308\u0306\u0306\u0304\u0305\u0304\u0303\u0308\u0305\u0304\u0303\u0307\u0301\u0301
	{
		[Token(Token = "0x600926A")]
		[Address(RVA = "0x900D10", Offset = "0x900110", VA = "0x180900D10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600926B")]
		[Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x0600926C RID: 37484 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x0600926D RID: 37485 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000570")]
	public \u0304\u0304\u0307\u0305\u0302\u0307\u0303\u0306\u0305\u0303\u0307\u0308\u0306\u0303\u0306 \u0301\u0306\u0306\u0304\u0301\u0305\u0302\u0304\u0306\u0305\u0305\u0304\u0301\u0305\u0308
	{
		[Token(Token = "0x600926C")]
		[Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600926D")]
		[Address(RVA = "0x8AD4E0", Offset = "0x8AC8E0", VA = "0x1808AD4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x0600926E RID: 37486 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x0600926F RID: 37487 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000571")]
	public \u0307\u0302\u0301\u0302\u0308\u0302\u0307\u0301\u0304\u0302\u0302\u0301\u0301\u0306\u0305 \u0306\u0301\u0307\u0304\u0305\u0308\u0306\u0303\u0303\u0306\u0301\u0302\u0303\u0302\u0302
	{
		[Token(Token = "0x600926E")]
		[Address(RVA = "0x8AF350", Offset = "0x8AE750", VA = "0x1808AF350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600926F")]
		[Address(RVA = "0x8AF7F0", Offset = "0x8AEBF0", VA = "0x1808AF7F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x06009270 RID: 37488 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009271 RID: 37489 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000572")]
	public \u0307\u0308\u0307\u0307\u0305\u0304\u0301\u0305\u0306\u0306\u0302\u0307\u0302\u0301\u0303[] \u0306\u0306\u0306\u0303\u0302\u0304\u0303\u0301\u0307\u0302\u0303\u0307\u0307\u0307\u0307
	{
		[Token(Token = "0x6009270")]
		[Address(RVA = "0x8AF590", Offset = "0x8AE990", VA = "0x1808AF590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009271")]
		[Address(RVA = "0x8AF950", Offset = "0x8AED50", VA = "0x1808AF950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x06009272 RID: 37490 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009273 RID: 37491 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000573")]
	public MeshRenderer[] \u0301\u0307\u0303\u0305\u0304\u0303\u0308\u0304\u0302\u0306\u0306\u0302\u0308\u0301\u0303
	{
		[Token(Token = "0x6009272")]
		[Address(RVA = "0x8CE350", Offset = "0x8CD750", VA = "0x1808CE350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009273")]
		[Address(RVA = "0x8CFD20", Offset = "0x8CF120", VA = "0x1808CFD20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x06009274 RID: 37492 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009275 RID: 37493 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000574")]
	public List<GameObject> \u0301\u0304\u0301\u0304\u0301\u0304\u0303\u0305\u0301\u0306\u0308\u0301\u0307\u0308\u0305
	{
		[Token(Token = "0x6009274")]
		[Address(RVA = "0x8AE690", Offset = "0x8ADA90", VA = "0x1808AE690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009275")]
		[Address(RVA = "0x164D230", Offset = "0x164C630", VA = "0x18164D230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x06009276 RID: 37494 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009277 RID: 37495 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000575")]
	public \u0307\u0304\u0305\u0304\u0304\u0304\u0302\u0302\u0305\u0302\u0305\u0302\u0301\u0307\u0308 \u0304\u0303\u0306\u0308\u0307\u0308\u0308\u0304\u0305\u0301\u0308\u0305\u0303\u0301\u0302
	{
		[Token(Token = "0x6009276")]
		[Address(RVA = "0x8AF330", Offset = "0x8AE730", VA = "0x1808AF330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009277")]
		[Address(RVA = "0x933560", Offset = "0x932960", VA = "0x180933560")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06009278 RID: 37496 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x06009279 RID: 37497 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000576")]
	public \u0305\u0302\u0305\u0303\u0307\u0302\u0307\u0304\u0307\u0307\u0304\u0302\u0301\u0307\u0306 \u0305\u0302\u0305\u0303\u0307\u0302\u0307\u0304\u0307\u0307\u0304\u0302\u0301\u0307\u0306
	{
		[Token(Token = "0x6009278")]
		[Address(RVA = "0x8AF340", Offset = "0x8AE740", VA = "0x1808AF340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009279")]
		[Address(RVA = "0x8AF7E0", Offset = "0x8AEBE0", VA = "0x1808AF7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x0600927A RID: 37498 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x0600927B RID: 37499 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000577")]
	public \u0304\u0302\u0303\u0303\u0302\u0307\u0303\u0308\u0301\u0308\u0301\u0302\u0303\u0304\u0306 \u0303\u0305\u0304\u0305\u0307\u0305\u0301\u0302\u0303\u0303\u0308\u0302\u0302\u0302\u0308
	{
		[Token(Token = "0x600927A")]
		[Address(RVA = "0x927C00", Offset = "0x927000", VA = "0x180927C00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600927B")]
		[Address(RVA = "0xC28DD0", Offset = "0xC281D0", VA = "0x180C28DD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x0600927C RID: 37500 RVA: 0x0003845C File Offset: 0x0003665C
	// (set) Token: 0x0600927D RID: 37501 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000578")]
	public float \u0304\u0303\u0304\u0307\u0305\u0304\u0302\u0307\u0305\u0304\u0303\u0307\u0305\u0302\u0301
	{
		[Token(Token = "0x600927C")]
		[Address(RVA = "0x18402A0", Offset = "0x183F6A0", VA = "0x1818402A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600927D")]
		[Address(RVA = "0x183F450", Offset = "0x183E850", VA = "0x18183F450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x0600927E RID: 37502 RVA: 0x00038474 File Offset: 0x00036674
	[Token(Token = "0x600927E")]
	[Address(RVA = "0x1836830", Offset = "0x1835C30", VA = "0x181836830")]
	public Vector2 GetUserInputs()
	{
		return default(Vector2);
	}

	// Token: 0x0600927F RID: 37503 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600927F")]
	[Address(RVA = "0x1838830", Offset = "0x1837C30", VA = "0x181838830", Slot = "39")]
	public override void OnPickedFromPool()
	{
	}

	// Token: 0x06009280 RID: 37504 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009280")]
	[Address(RVA = "0x1839620", Offset = "0x1838A20", VA = "0x181839620", Slot = "38")]
	public override void OnSentToPool()
	{
	}

	// Token: 0x06009281 RID: 37505 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009281")]
	[Address(RVA = "0x1834DD0", Offset = "0x18341D0", VA = "0x181834DD0", Slot = "21")]
	public override void Awake()
	{
	}

	// Token: 0x06009282 RID: 37506 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009282")]
	[Address(RVA = "0x1837870", Offset = "0x1836C70", VA = "0x181837870", Slot = "40")]
	public override void OnDestroy()
	{
	}

	// Token: 0x06009283 RID: 37507 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009283")]
	[Address(RVA = "0x1838210", Offset = "0x1837610", VA = "0x181838210", Slot = "24")]
	public override void OnNetworkViewInitialized()
	{
	}

	// Token: 0x06009284 RID: 37508 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009284")]
	[Address(RVA = "0x183C740", Offset = "0x183BB40", VA = "0x18183C740")]
	public void RegisterVehicle(int \u0306\u0305\u0306\u0306\u0308\u0302\u0302\u0302\u0304\u0307\u0303\u0307\u0307\u0304\u0305)
	{
	}

	// Token: 0x06009285 RID: 37509 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009285")]
	[Address(RVA = "0x183F490", Offset = "0x183E890", VA = "0x18183F490")]
	public void UnregisterVehicle()
	{
	}

	// Token: 0x06009286 RID: 37510 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009286")]
	[Address(RVA = "0x183FB30", Offset = "0x183EF30", VA = "0x18183FB30")]
	public void __onFixedUpdate()
	{
	}

	// Token: 0x06009287 RID: 37511 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009287")]
	[Address(RVA = "0x183F9A0", Offset = "0x183EDA0", VA = "0x18183F9A0")]
	public void __onClientThreadGameUpdate()
	{
	}

	// Token: 0x06009288 RID: 37512 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009288")]
	[Address(RVA = "0x1838100", Offset = "0x1837500", VA = "0x181838100")]
	public void OnLogicUpdate()
	{
	}

	// Token: 0x06009289 RID: 37513 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x6009289")]
	[Address(RVA = "0x183FF10", Offset = "0x183F310", VA = "0x18183FF10", Slot = "45")]
	public \u0304\u0305\u0302\u0301\u0301\u0303\u0307\u0304\u0301\u0306\u0305\u0301\u0302\u0305\u0305 getBinding(bool \u0302\u0304\u0303\u0307\u0302\u0305\u0302\u0305\u0301\u0303\u0302\u0307\u0302\u0301\u0306)
	{
		return null;
	}

	// Token: 0x0600928A RID: 37514 RVA: 0x0003848C File Offset: 0x0003668C
	[Token(Token = "0x600928A")]
	[Address(RVA = "0x183FFD0", Offset = "0x183F3D0", VA = "0x18183FFD0", Slot = "43")]
	public bool getCanBeFocused(bool \u0302\u0304\u0303\u0307\u0302\u0305\u0302\u0305\u0301\u0303\u0302\u0307\u0302\u0301\u0306)
	{
		return default(bool);
	}

	// Token: 0x0600928B RID: 37515 RVA: 0x000384A4 File Offset: 0x000366A4
	[Token(Token = "0x600928B")]
	[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "48")]
	public bool networkCompensationBinding()
	{
		return default(bool);
	}

	// Token: 0x0600928C RID: 37516 RVA: 0x000384BC File Offset: 0x000366BC
	[Token(Token = "0x600928C")]
	[Address(RVA = "0x1840080", Offset = "0x183F480", VA = "0x181840080", Slot = "44")]
	public float getHoldingTime(bool \u0302\u0304\u0303\u0307\u0302\u0305\u0302\u0305\u0301\u0303\u0302\u0307\u0302\u0301\u0306)
	{
		return 0f;
	}

	// Token: 0x0600928D RID: 37517 RVA: 0x000384D4 File Offset: 0x000366D4
	[Token(Token = "0x600928D")]
	[Address(RVA = "0x18400C0", Offset = "0x183F4C0", VA = "0x1818400C0", Slot = "46")]
	public int getLangID(bool \u0302\u0304\u0303\u0307\u0302\u0305\u0302\u0305\u0301\u0303\u0302\u0307\u0302\u0301\u0306)
	{
		return 0;
	}

	// Token: 0x0600928E RID: 37518 RVA: 0x000384EC File Offset: 0x000366EC
	[Token(Token = "0x600928E")]
	[Address(RVA = "0x1836770", Offset = "0x1835B70", VA = "0x181836770", Slot = "42")]
	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	// Token: 0x0600928F RID: 37519 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600928F")]
	[Address(RVA = "0x1838BF0", Offset = "0x1837FF0", VA = "0x181838BF0", Slot = "47")]
	public void OnPlayerInteract(bool \u0302\u0304\u0303\u0307\u0302\u0305\u0302\u0305\u0301\u0303\u0302\u0307\u0302\u0301\u0306)
	{
	}

	// Token: 0x06009290 RID: 37520 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x6009290")]
	[Address(RVA = "0xC10430", Offset = "0xC0F830", VA = "0x180C10430", Slot = "52")]
	public \u0308\u0303\u0301\u0308\u0308\u0307\u0305\u0303\u0305\u0307\u0307\u0301\u0306\u0308\u0301 GetProvider(Vector3 \u0303\u0302\u0304\u0305\u0303\u0303\u0301\u0307\u0302\u0308\u0303\u0302\u0302\u0301\u0307)
	{
		return null;
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x06009291 RID: 37521 RVA: 0x00038504 File Offset: 0x00036704
	// (set) Token: 0x06009292 RID: 37522 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000579")]
	public int \u0302\u0304\u0308\u0303\u0306\u0305\u0302\u0304\u0301\u0302\u0306\u0307\u0307\u0308\u0304
	{
		[Token(Token = "0x6009291")]
		[Address(RVA = "0x18403C0", Offset = "0x183F7C0", VA = "0x1818403C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6009292")]
		[Address(RVA = "0x183F460", Offset = "0x183E860", VA = "0x18183F460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x06009293 RID: 37523 RVA: 0x0003851C File Offset: 0x0003671C
	// (set) Token: 0x06009294 RID: 37524 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700057A")]
	public Vector3 \u0304\u0307\u0308\u0308\u0301\u0303\u0307\u0307\u0301\u0308\u0304\u0301\u0303\u0308\u0305
	{
		[Token(Token = "0x6009293")]
		[Address(RVA = "0x1840390", Offset = "0x183F790", VA = "0x181840390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6009294")]
		[Address(RVA = "0x1841320", Offset = "0x1840720", VA = "0x181841320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x06009295 RID: 37525 RVA: 0x00038534 File Offset: 0x00036734
	// (set) Token: 0x06009296 RID: 37526 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700057B")]
	public bool \u0303\u0307\u0303\u0305\u0307\u0301\u0301\u0308\u0304\u0303\u0301\u0308\u0302\u0306\u0302
	{
		[Token(Token = "0x6009295")]
		[Address(RVA = "0x18403B0", Offset = "0x183F7B0", VA = "0x1818403B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009296")]
		[Address(RVA = "0x1841340", Offset = "0x1840740", VA = "0x181841340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x06009297 RID: 37527 RVA: 0x0003854C File Offset: 0x0003674C
	// (set) Token: 0x06009298 RID: 37528 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700057C")]
	public bool \u0306\u0308\u0305\u0303\u0301\u0305\u0306\u0304\u0302\u0306\u0304\u0301\u0305\u0307\u0307
	{
		[Token(Token = "0x6009297")]
		[Address(RVA = "0x1840580", Offset = "0x183F980", VA = "0x181840580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009298")]
		[Address(RVA = "0x183EC70", Offset = "0x183E070", VA = "0x18183EC70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x06009299 RID: 37529 RVA: 0x00038564 File Offset: 0x00036764
	// (set) Token: 0x0600929A RID: 37530 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700057D")]
	public float \u0308\u0308\u0303\u0304\u0303\u0307\u0304\u0305\u0302\u0305\u0308\u0301\u0301\u0303\u0301
	{
		[Token(Token = "0x6009299")]
		[Address(RVA = "0x18401E0", Offset = "0x183F5E0", VA = "0x1818401E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600929A")]
		[Address(RVA = "0x183F440", Offset = "0x183E840", VA = "0x18183F440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x0600929B RID: 37531 RVA: 0x0003857C File Offset: 0x0003677C
	// (set) Token: 0x0600929C RID: 37532 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700057E")]
	public float \u0304\u0301\u0303\u0305\u0304\u0303\u0302\u0304\u0302\u0307\u0305\u0304\u0307\u0305\u0308
	{
		[Token(Token = "0x600929B")]
		[Address(RVA = "0x18401F0", Offset = "0x183F5F0", VA = "0x1818401F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600929C")]
		[Address(RVA = "0x183EDD0", Offset = "0x183E1D0", VA = "0x18183EDD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x0600929D RID: 37533 RVA: 0x00038594 File Offset: 0x00036794
	// (set) Token: 0x0600929E RID: 37534 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700057F")]
	public bool \u0301\u0303\u0306\u0303\u0301\u0302\u0306\u0308\u0307\u0305\u0301\u0302\u0308\u0301\u0302
	{
		[Token(Token = "0x600929D")]
		[Address(RVA = "0x18405C0", Offset = "0x183F9C0", VA = "0x1818405C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600929E")]
		[Address(RVA = "0x183EF20", Offset = "0x183E320", VA = "0x18183EF20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x0600929F RID: 37535 RVA: 0x000385AC File Offset: 0x000367AC
	// (set) Token: 0x060092A0 RID: 37536 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000580")]
	public float \u0306\u0303\u0303\u0308\u0305\u0304\u0306\u0305\u0303\u0305\u0301\u0303\u0305\u0304\u0301
	{
		[Token(Token = "0x600929F")]
		[Address(RVA = "0x18400F0", Offset = "0x183F4F0", VA = "0x1818400F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60092A0")]
		[Address(RVA = "0x183EFA0", Offset = "0x183E3A0", VA = "0x18183EFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x060092A1 RID: 37537 RVA: 0x000385C4 File Offset: 0x000367C4
	[Token(Token = "0x17000581")]
	public bool \u0304\u0305\u0305\u0305\u0303\u0306\u0307\u0301\u0303\u0307\u0304\u0308\u0303\u0305\u0306
	{
		[Token(Token = "0x60092A1")]
		[Address(RVA = "0x18403D0", Offset = "0x183F7D0", VA = "0x1818403D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x060092A2 RID: 37538 RVA: 0x000385DC File Offset: 0x000367DC
	[Token(Token = "0x17000582")]
	public float \u0308\u0306\u0305\u0302\u0303\u0302\u0306\u0301\u0301\u0301\u0301\u0302\u0303\u0308\u0304
	{
		[Token(Token = "0x60092A2")]
		[Address(RVA = "0x1840100", Offset = "0x183F500", VA = "0x181840100")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x060092A3 RID: 37539 RVA: 0x000385F4 File Offset: 0x000367F4
	[Token(Token = "0x17000583")]
	public \u0307\u0304\u0303\u0304\u0301\u0304\u0308\u0306\u0307\u0301\u0301\u0307\u0301\u0308\u0305 \u0307\u0305\u0306\u0308\u0305\u0306\u0301\u0303\u0303\u0305\u0308\u0308\u0301\u0306\u0303
	{
		[Token(Token = "0x60092A3")]
		[Address(RVA = "0x1840210", Offset = "0x183F610", VA = "0x181840210")]
		get
		{
			return \u0307\u0304\u0303\u0304\u0301\u0304\u0308\u0306\u0307\u0301\u0301\u0307\u0301\u0308\u0305.Light;
		}
	}

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x060092A4 RID: 37540 RVA: 0x0003860C File Offset: 0x0003680C
	[Token(Token = "0x17000584")]
	public virtual float \u0305\u0302\u0302\u0306\u0307\u0305\u0308\u0302\u0305\u0303\u0304\u0305\u0301\u0304\u0302
	{
		[Token(Token = "0x60092A4")]
		[Address(RVA = "0xDF9A00", Offset = "0xDF8E00", VA = "0x180DF9A00", Slot = "54")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x060092A5 RID: 37541 RVA: 0x00038624 File Offset: 0x00036824
	[Token(Token = "0x17000585")]
	public virtual bool \u0303\u0301\u0307\u0308\u0308\u0306\u0305\u0306\u0304\u0307\u0301\u0305\u0308\u0302\u0303
	{
		[Token(Token = "0x60092A5")]
		[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "55")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x060092A6 RID: 37542 RVA: 0x0000270E File Offset: 0x0000090E
	// (set) Token: 0x060092A7 RID: 37543 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000586")]
	public \u0305\u0308\u0305\u0307\u0305\u0305\u0302\u0304\u0305\u0306\u0307\u0307\u0307\u0304\u0304 \u0301\u0307\u0301\u0306\u0304\u0306\u0308\u0308\u0307\u0303\u0308\u0301\u0301\u0301\u0302
	{
		[Token(Token = "0x60092A6")]
		[Address(RVA = "0x9DD5C0", Offset = "0x9DC9C0", VA = "0x1809DD5C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60092A7")]
		[Address(RVA = "0x1841310", Offset = "0x1840710", VA = "0x181841310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x060092A8 RID: 37544 RVA: 0x0003863C File Offset: 0x0003683C
	// (set) Token: 0x060092A9 RID: 37545 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000587")]
	public \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0306\u0302\u0303\u0304\u0306\u0301\u0308\u0305\u0308\u0303\u0306\u0305\u0308\u0302\u0301
	{
		[Token(Token = "0x60092A8")]
		[Address(RVA = "0x1840330", Offset = "0x183F730", VA = "0x181840330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307.TeamA;
		}
		[Token(Token = "0x60092A9")]
		[Address(RVA = "0x183EFC0", Offset = "0x183E3C0", VA = "0x18183EFC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x060092AA RID: 37546 RVA: 0x00038654 File Offset: 0x00036854
	[Token(Token = "0x17000588")]
	public \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0305\u0304\u0308\u0307\u0308\u0303\u0306\u0305\u0301\u0303\u0301\u0301\u0303\u0307\u0305
	{
		[Token(Token = "0x60092AA")]
		[Address(RVA = "0x18400D0", Offset = "0x183F4D0", VA = "0x1818400D0")]
		get
		{
			return \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307.TeamA;
		}
	}

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x060092AB RID: 37547 RVA: 0x0003866C File Offset: 0x0003686C
	// (set) Token: 0x060092AC RID: 37548 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000589")]
	public \u0306\u0306\u0304\u0304\u0308\u0308\u0305\u0306\u0308\u0303\u0307\u0302\u0303\u0304\u0301 \u0301\u0302\u0308\u0307\u0301\u0301\u0303\u0301\u0303\u0307\u0301\u0306\u0302\u0308\u0307
	{
		[Token(Token = "0x60092AB")]
		[Address(RVA = "0x1840200", Offset = "0x183F600", VA = "0x181840200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return \u0306\u0306\u0304\u0304\u0308\u0308\u0305\u0306\u0308\u0303\u0307\u0302\u0303\u0304\u0301.Off;
		}
		[Token(Token = "0x60092AC")]
		[Address(RVA = "0x183F470", Offset = "0x183E870", VA = "0x18183F470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x060092AD RID: 37549 RVA: 0x00038684 File Offset: 0x00036884
	// (set) Token: 0x060092AE RID: 37550 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700058A")]
	public \u0301\u0308\u0306\u0303\u0304\u0302\u0308\u0306\u0306\u0308\u0301\u0302\u0301\u0302\u0305 \u0305\u0305\u0301\u0308\u0304\u0307\u0305\u0304\u0304\u0301\u0306\u0305\u0307\u0301\u0308
	{
		[Token(Token = "0x60092AD")]
		[Address(RVA = "0xB41600", Offset = "0xB40A00", VA = "0x180B41600")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return \u0301\u0308\u0306\u0303\u0304\u0302\u0308\u0306\u0306\u0308\u0301\u0302\u0301\u0302\u0305.Off;
		}
		[Token(Token = "0x60092AE")]
		[Address(RVA = "0x183DFB0", Offset = "0x183D3B0", VA = "0x18183DFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700058B RID: 1419
	// (get) Token: 0x060092AF RID: 37551 RVA: 0x0003869C File Offset: 0x0003689C
	// (set) Token: 0x060092B0 RID: 37552 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700058B")]
	public float \u0308\u0305\u0308\u0304\u0301\u0305\u0303\u0302\u0307\u0304\u0302\u0307\u0303\u0301\u0303
	{
		[Token(Token = "0x60092AF")]
		[Address(RVA = "0x1840270", Offset = "0x183F670", VA = "0x181840270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60092B0")]
		[Address(RVA = "0x183EF30", Offset = "0x183E330", VA = "0x18183EF30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700058C RID: 1420
	// (get) Token: 0x060092B1 RID: 37553 RVA: 0x000386B4 File Offset: 0x000368B4
	// (set) Token: 0x060092B2 RID: 37554 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700058C")]
	public float \u0303\u0303\u0303\u0303\u0305\u0308\u0301\u0302\u0306\u0306\u0303\u0307\u0306\u0308\u0302
	{
		[Token(Token = "0x60092B1")]
		[Address(RVA = "0x1840340", Offset = "0x183F740", VA = "0x181840340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60092B2")]
		[Address(RVA = "0x183EF00", Offset = "0x183E300", VA = "0x18183EF00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x1700058D RID: 1421
	// (get) Token: 0x060092B3 RID: 37555 RVA: 0x000386CC File Offset: 0x000368CC
	[Token(Token = "0x1700058D")]
	public float \u0306\u0303\u0303\u0305\u0301\u0304\u0305\u0302\u0303\u0306\u0302\u0303\u0302\u0304\u0304
	{
		[Token(Token = "0x60092B3")]
		[Address(RVA = "0x18402B0", Offset = "0x183F6B0", VA = "0x1818402B0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x060092B4 RID: 37556 RVA: 0x000386E4 File Offset: 0x000368E4
	[Token(Token = "0x1700058E")]
	public float \u0306\u0306\u0301\u0301\u0307\u0306\u0303\u0307\u0308\u0308\u0306\u0304\u0304\u0301\u0307
	{
		[Token(Token = "0x60092B4")]
		[Address(RVA = "0x1840240", Offset = "0x183F640", VA = "0x181840240")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x060092B5 RID: 37557 RVA: 0x000386FC File Offset: 0x000368FC
	[Token(Token = "0x1700058F")]
	public new bool \u0307\u0307\u0301\u0301\u0304\u0301\u0302\u0302\u0302\u0304\u0307\u0307\u0305\u0308\u0304
	{
		[Token(Token = "0x60092B5")]
		[Address(RVA = "0x18404E0", Offset = "0x183F8E0", VA = "0x1818404E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x060092B6 RID: 37558 RVA: 0x00038714 File Offset: 0x00036914
	[Token(Token = "0x17000590")]
	public bool \u0307\u0306\u0307\u0307\u0305\u0303\u0305\u0307\u0302\u0303\u0307\u0307\u0305\u0306\u0305
	{
		[Token(Token = "0x60092B6")]
		[Address(RVA = "0x1840590", Offset = "0x183F990", VA = "0x181840590")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x060092B7 RID: 37559 RVA: 0x0003872C File Offset: 0x0003692C
	[Token(Token = "0x17000591")]
	public bool \u0303\u0304\u0303\u0306\u0304\u0306\u0304\u0304\u0304\u0307\u0308\u0302\u0307\u0306\u0302
	{
		[Token(Token = "0x60092B7")]
		[Address(RVA = "0x18404F0", Offset = "0x183F8F0", VA = "0x1818404F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x060092B8 RID: 37560 RVA: 0x00038744 File Offset: 0x00036944
	[Token(Token = "0x17000592")]
	public bool \u0301\u0305\u0302\u0303\u0305\u0304\u0306\u0301\u0308\u0302\u0302\u0304\u0308\u0308\u0304
	{
		[Token(Token = "0x60092B8")]
		[Address(RVA = "0x1840500", Offset = "0x183F900", VA = "0x181840500")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x060092B9 RID: 37561 RVA: 0x0003875C File Offset: 0x0003695C
	[Token(Token = "0x17000593")]
	public bool \u0305\u0302\u0304\u0302\u0301\u0301\u0306\u0303\u0307\u0305\u0304\u0302\u0304\u0305\u0308
	{
		[Token(Token = "0x60092B9")]
		[Address(RVA = "0x18403F0", Offset = "0x183F7F0", VA = "0x1818403F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x060092BA RID: 37562 RVA: 0x00038774 File Offset: 0x00036974
	[Token(Token = "0x17000594")]
	public float \u0308\u0307\u0304\u0307\u0307\u0306\u0303\u0301\u0301\u0303\u0304\u0306\u0302\u0301\u0305
	{
		[Token(Token = "0x60092BA")]
		[Address(RVA = "0x1840290", Offset = "0x183F690", VA = "0x181840290")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x060092BB RID: 37563 RVA: 0x0003878C File Offset: 0x0003698C
	// (set) Token: 0x060092BC RID: 37564 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000595")]
	public float \u0302\u0306\u0301\u0304\u0304\u0304\u0303\u0308\u0307\u0303\u0304\u0307\u0307\u0303\u0305
	{
		[Token(Token = "0x60092BB")]
		[Address(RVA = "0x8CD990", Offset = "0x8CCD90", VA = "0x1808CD990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60092BC")]
		[Address(RVA = "0x183EF10", Offset = "0x183E310", VA = "0x18183EF10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x060092BD RID: 37565 RVA: 0x000387A4 File Offset: 0x000369A4
	// (set) Token: 0x060092BE RID: 37566 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000596")]
	public float \u0304\u0306\u0304\u0302\u0305\u0303\u0307\u0301\u0301\u0307\u0305\u0307\u0307\u0304\u0301
	{
		[Token(Token = "0x60092BD")]
		[Address(RVA = "0x1840280", Offset = "0x183F680", VA = "0x181840280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60092BE")]
		[Address(RVA = "0x1841300", Offset = "0x1840700", VA = "0x181841300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		set
		{
		}
	}

	// Token: 0x17000597 RID: 1431
	// (get) Token: 0x060092BF RID: 37567 RVA: 0x000387BC File Offset: 0x000369BC
	// (set) Token: 0x060092C0 RID: 37568 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000597")]
	public float \u0304\u0305\u0308\u0303\u0305\u0303\u0301\u0302\u0305\u0302\u0305\u0304\u0306\u0306\u0306
	{
		[Token(Token = "0x60092BF")]
		[Address(RVA = "0x1840350", Offset = "0x183F750", VA = "0x181840350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60092C0")]
		[Address(RVA = "0x183ECB0", Offset = "0x183E0B0", VA = "0x18183ECB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000598 RID: 1432
	// (get) Token: 0x060092C1 RID: 37569 RVA: 0x000387D4 File Offset: 0x000369D4
	// (set) Token: 0x060092C2 RID: 37570 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000598")]
	public ulong \u0308\u0301\u0303\u0301\u0308\u0305\u0308\u0307\u0304\u0305\u0304\u0307\u0304\u0308\u0305
	{
		[Token(Token = "0x60092C1")]
		[Address(RVA = "0x1840360", Offset = "0x183F760", VA = "0x181840360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0UL;
		}
		[Token(Token = "0x60092C2")]
		[Address(RVA = "0x183F020", Offset = "0x183E420", VA = "0x18183F020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x17000599 RID: 1433
	// (get) Token: 0x060092C3 RID: 37571 RVA: 0x000387EC File Offset: 0x000369EC
	// (set) Token: 0x060092C4 RID: 37572 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000599")]
	public ushort \u0305\u0304\u0304\u0305\u0301\u0307\u0308\u0303\u0303\u0308\u0305\u0303\u0303\u0303\u0305
	{
		[Token(Token = "0x60092C3")]
		[Address(RVA = "0x1840370", Offset = "0x183F770", VA = "0x181840370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60092C4")]
		[Address(RVA = "0x183F480", Offset = "0x183E880", VA = "0x18183F480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x060092C5 RID: 37573 RVA: 0x00038804 File Offset: 0x00036A04
	[Token(Token = "0x60092C5")]
	[Address(RVA = "0x1836190", Offset = "0x1835590", VA = "0x181836190")]
	public float GetDamageMultiplier(Vector3 \u0303\u0302\u0304\u0305\u0303\u0303\u0301\u0307\u0302\u0308\u0303\u0302\u0302\u0301\u0307)
	{
		return 0f;
	}

	// Token: 0x060092C6 RID: 37574 RVA: 0x0003881C File Offset: 0x00036A1C
	[Token(Token = "0x60092C6")]
	[Address(RVA = "0x1835B00", Offset = "0x1834F00", VA = "0x181835B00")]
	public bool CanSpawn(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0303\u0303\u0302\u0304\u0306\u0303\u0305\u0306\u0302\u0305\u0305\u0302\u0308\u0302\u0301)
	{
		return default(bool);
	}

	// Token: 0x060092C7 RID: 37575 RVA: 0x00038834 File Offset: 0x00036A34
	[Token(Token = "0x60092C7")]
	[Address(RVA = "0x1835870", Offset = "0x1834C70", VA = "0x181835870", Slot = "56")]
	public virtual bool CanNonSquadTeamMemberSpawnOnThis(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0303\u0303\u0302\u0304\u0306\u0303\u0305\u0306\u0302\u0305\u0305\u0302\u0308\u0302\u0301)
	{
		return default(bool);
	}

	// Token: 0x060092C8 RID: 37576 RVA: 0x0003884C File Offset: 0x00036A4C
	[Token(Token = "0x60092C8")]
	[Address(RVA = "0x1836230", Offset = "0x1835630", VA = "0x181836230", Slot = "30")]
	public override float GetDistanceToCamera()
	{
		return 0f;
	}

	// Token: 0x060092C9 RID: 37577 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092C9")]
	[Address(RVA = "0x183CF90", Offset = "0x183C390", VA = "0x18183CF90", Slot = "57")]
	public virtual void ServerSideWorldColliderOnCollisionEnter(Collision \u0302\u0302\u0307\u0307\u0303\u0304\u0306\u0307\u0305\u0303\u0305\u0302\u0306\u0308\u0304)
	{
	}

	// Token: 0x060092CA RID: 37578 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092CA")]
	[Address(RVA = "0x1838E30", Offset = "0x1838230", VA = "0x181838E30", Slot = "58")]
	public virtual void OnProjectileHitClientSide(Vector3 \u0301\u0308\u0304\u0301\u0307\u0308\u0304\u0301\u0305\u0301\u0306\u0305\u0303\u0306\u0305, Vector3 \u0301\u0304\u0308\u0305\u0302\u0306\u0308\u0301\u0308\u0301\u0303\u0304\u0303\u0301\u0306, \u0308\u0305\u0306\u0302\u0308\u0305\u0304\u0305\u0307\u0305\u0302\u0302\u0306\u0306\u0301 \u0305\u0308\u0301\u0304\u0306\u0302\u0305\u0306\u0303\u0305\u0303\u0304\u0302\u0305\u0307)
	{
	}

	// Token: 0x060092CB RID: 37579 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092CB")]
	[Address(RVA = "0x1837C00", Offset = "0x1837000", VA = "0x181837C00", Slot = "59")]
	public virtual void OnHitServerSide(Vector3 \u0301\u0308\u0304\u0301\u0307\u0308\u0304\u0301\u0305\u0301\u0306\u0305\u0303\u0306\u0305, Vector3 \u0301\u0304\u0308\u0305\u0302\u0306\u0308\u0301\u0308\u0301\u0303\u0304\u0303\u0301\u0306, \u0308\u0305\u0306\u0302\u0308\u0305\u0304\u0305\u0307\u0305\u0302\u0302\u0306\u0306\u0301 \u0305\u0308\u0301\u0304\u0306\u0302\u0305\u0306\u0303\u0305\u0303\u0304\u0302\u0305\u0307)
	{
	}

	// Token: 0x060092CC RID: 37580 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092CC")]
	[Address(RVA = "0x18405D0", Offset = "0x183F9D0", VA = "0x1818405D0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x13E750", Offset = "0x13DB50")]
	private void mOnReceivedProjectileHitFromClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092CD RID: 37581 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092CD")]
	[Address(RVA = "0x1840840", Offset = "0x183FC40", VA = "0x181840840")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x13E750", Offset = "0x13DB50")]
	private void mReceivedHitPackage(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092CE RID: 37582 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092CE")]
	[Address(RVA = "0x1839050", Offset = "0x1838450", VA = "0x181839050", Slot = "60")]
	public virtual void OnReceivedHit(Vector3 \u0303\u0302\u0304\u0305\u0303\u0303\u0301\u0307\u0302\u0308\u0303\u0302\u0302\u0301\u0307, Vector3 \u0304\u0306\u0302\u0307\u0308\u0305\u0306\u0302\u0301\u0305\u0304\u0304\u0304\u0307\u0303, \u0303\u0308\u0301\u0305\u0304\u0302\u0306\u0308\u0302\u0306\u0304\u0307\u0308\u0301\u0306 \u0308\u0307\u0307\u0301\u0304\u0303\u0303\u0303\u0307\u0306\u0307\u0305\u0303\u0308\u0302)
	{
	}

	// Token: 0x060092CF RID: 37583 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092CF")]
	[Address(RVA = "0x183A910", Offset = "0x1839D10", VA = "0x18183A910", Slot = "61")]
	public virtual void OnStartedSimulating()
	{
	}

	// Token: 0x060092D0 RID: 37584 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D0")]
	[Address(RVA = "0x183ABA0", Offset = "0x1839FA0", VA = "0x18183ABA0", Slot = "62")]
	public virtual void OnStoppedSimulating()
	{
	}

	// Token: 0x060092D1 RID: 37585 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D1")]
	[Address(RVA = "0x183FB60", Offset = "0x183EF60", VA = "0x18183FB60")]
	public void __onUploadFromClient()
	{
	}

	// Token: 0x060092D2 RID: 37586 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D2")]
	[Address(RVA = "0x183FC10", Offset = "0x183F010", VA = "0x18183FC10")]
	public void __onUploadFromServer()
	{
	}

	// Token: 0x060092D3 RID: 37587 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D3")]
	[Address(RVA = "0x183DE90", Offset = "0x183D290", VA = "0x18183DE90")]
	private void \u0301\u0302\u0303\u0301\u0303\u0304\u0301\u0305\u0301\u0305\u0304\u0307\u0306\u0305\u0303()
	{
	}

	// Token: 0x060092D4 RID: 37588 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D4")]
	[Address(RVA = "0x18399D0", Offset = "0x1838DD0", VA = "0x1818399D0", Slot = "63")]
	public virtual void OnSimulatingFixedUpdate()
	{
	}

	// Token: 0x060092D5 RID: 37589 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D5")]
	[Address(RVA = "0x183A1A0", Offset = "0x18395A0", VA = "0x18183A1A0", Slot = "64")]
	public virtual void OnSimulatingGameUpdate(bool \u0304\u0308\u0306\u0303\u0301\u0303\u0306\u0306\u0305\u0308\u0302\u0304\u0302\u0302\u0305)
	{
	}

	// Token: 0x060092D6 RID: 37590 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D6")]
	[Address(RVA = "0x18384E0", Offset = "0x18378E0", VA = "0x1818384E0", Slot = "65")]
	public virtual void OnNonSimulatingGameUpdate(bool \u0304\u0308\u0306\u0303\u0301\u0303\u0306\u0306\u0305\u0308\u0302\u0304\u0302\u0302\u0305)
	{
	}

	// Token: 0x060092D7 RID: 37591 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D7")]
	[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "66")]
	public virtual void OnDriverSendSnapshotToServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092D8 RID: 37592 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D8")]
	[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "67")]
	public virtual void OnServerReceiveSnapshotFromDriver(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092D9 RID: 37593 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092D9")]
	[Address(RVA = "0x1839990", Offset = "0x1838D90", VA = "0x181839990", Slot = "68")]
	public virtual void OnServerBroadcastSnapshotToClients(\u0303\u0303\u0304\u0303\u0306\u0301\u0308\u0306\u0305\u0305\u0304\u0303\u0301\u0303\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307, \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0303\u0302\u0303\u0306\u0308\u0308\u0306\u0303\u0305\u0307\u0308\u0307\u0307\u0305)
	{
	}

	// Token: 0x060092DA RID: 37594 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092DA")]
	[Address(RVA = "0x18377F0", Offset = "0x1836BF0", VA = "0x1818377F0", Slot = "69")]
	public virtual void OnClientReceiveSnapshotFromServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092DB RID: 37595 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092DB")]
	[Address(RVA = "0x183AE40", Offset = "0x183A240", VA = "0x18183AE40", Slot = "70")]
	public virtual void OnValidatePosition()
	{
	}

	// Token: 0x060092DC RID: 37596 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092DC")]
	[Address(RVA = "0x1836E20", Offset = "0x1836220", VA = "0x181836E20", Slot = "71")]
	public virtual void HandleServerInterpolation()
	{
	}

	// Token: 0x060092DD RID: 37597 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092DD")]
	[Address(RVA = "0x1836880", Offset = "0x1835C80", VA = "0x181836880", Slot = "72")]
	public virtual void HandleDriverInterpolation()
	{
	}

	// Token: 0x060092DE RID: 37598 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092DE")]
	[Address(RVA = "0x183F730", Offset = "0x183EB30", VA = "0x18183F730", Slot = "73")]
	public virtual void WriteJobInput(ref \u0308\u0305\u0304\u0304\u0307\u0306\u0302\u0303\u0303\u0307\u0306\u0308\u0303\u0306\u0307 \u0301\u0306\u0306\u0306\u0305\u0307\u0308\u0305\u0301\u0302\u0305\u0308\u0308\u0304\u0303)
	{
	}

	// Token: 0x060092DF RID: 37599 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092DF")]
	[Address(RVA = "0x183D910", Offset = "0x183CD10", VA = "0x18183D910", Slot = "74")]
	public virtual void SetJobOutput(ref \u0308\u0305\u0304\u0304\u0307\u0306\u0302\u0303\u0303\u0307\u0306\u0308\u0303\u0306\u0307 \u0306\u0308\u0307\u0304\u0304\u0304\u0305\u0304\u0307\u0306\u0302\u0307\u0307\u0302\u0306)
	{
	}

	// Token: 0x060092E0 RID: 37600 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E0")]
	[Address(RVA = "0x183CA10", Offset = "0x183BE10", VA = "0x18183CA10")]
	public void RequestToOnOffEngine(bool \u0301\u0306\u0307\u0306\u0308\u0307\u0301\u0306\u0308\u0305\u0308\u0301\u0305\u0305\u0304)
	{
	}

	// Token: 0x060092E1 RID: 37601 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E1")]
	[Address(RVA = "0x183C1C0", Offset = "0x183B5C0", VA = "0x18183C1C0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x13E750", Offset = "0x13DB50")]
	private void ReceivedRequestToChangeEngine(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092E2 RID: 37602 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E2")]
	[Address(RVA = "0x183CD90", Offset = "0x183C190", VA = "0x18183CD90")]
	public void ServerSendNewEngineState(bool \u0303\u0301\u0304\u0307\u0303\u0302\u0302\u0303\u0306\u0301\u0302\u0307\u0306\u0306\u0302)
	{
	}

	// Token: 0x060092E3 RID: 37603 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E3")]
	[Address(RVA = "0x183BA50", Offset = "0x183AE50", VA = "0x18183BA50")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void ReceivedNewEngineState(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092E4 RID: 37604 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E4")]
	[Address(RVA = "0x183EFD0", Offset = "0x183E3D0", VA = "0x18183EFD0")]
	private void \u0306\u0304\u0305\u0304\u0308\u0303\u0307\u0307\u0304\u0303\u0306\u0308\u0301\u0304\u0302(bool \u0303\u0301\u0304\u0307\u0303\u0302\u0302\u0303\u0306\u0301\u0302\u0307\u0306\u0306\u0302)
	{
	}

	// Token: 0x060092E5 RID: 37605 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E5")]
	[Address(RVA = "0x18379B0", Offset = "0x1836DB0", VA = "0x1818379B0", Slot = "75")]
	public virtual void OnEngineStateChanged(bool \u0303\u0301\u0304\u0307\u0303\u0302\u0302\u0303\u0306\u0301\u0302\u0307\u0306\u0306\u0302)
	{
	}

	// Token: 0x060092E6 RID: 37606 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E6")]
	[Address(RVA = "0x183DFC0", Offset = "0x183D3C0", VA = "0x18183DFC0")]
	private void \u0301\u0306\u0302\u0302\u0303\u0306\u0304\u0303\u0307\u0305\u0302\u0307\u0303\u0307\u0301(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0301\u0306\u0306\u0303\u0305\u0308\u0308\u0306\u0302\u0304\u0305\u0305\u0301\u0308\u0301, ToolItem \u0308\u0305\u0305\u0305\u0307\u0302\u0301\u0308\u0307\u0305\u0302\u0307\u0303\u0304\u0306, float \u0302\u0303\u0308\u0303\u0301\u0307\u0304\u0302\u0302\u0306\u0307\u0308\u0307\u0304\u0303, float \u0306\u0307\u0305\u0301\u0303\u0301\u0304\u0303\u0308\u0306\u0302\u0301\u0308\u0303\u0303, byte \u0306\u0303\u0302\u0306\u0308\u0303\u0307\u0304\u0307\u0303\u0302\u0303\u0305\u0306\u0308, bool \u0303\u0304\u0308\u0307\u0302\u0301\u0307\u0308\u0303\u0303\u0301\u0303\u0301\u0306\u0302)
	{
	}

	// Token: 0x060092E7 RID: 37607 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E7")]
	[Address(RVA = "0x183D240", Offset = "0x183C640", VA = "0x18183D240")]
	public void ServerSide_ApplyDamage(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0301\u0306\u0306\u0303\u0305\u0308\u0308\u0306\u0302\u0304\u0305\u0305\u0301\u0308\u0301, ToolItem \u0308\u0305\u0305\u0305\u0307\u0302\u0301\u0308\u0307\u0305\u0302\u0307\u0303\u0304\u0306, float \u0308\u0308\u0302\u0302\u0308\u0307\u0302\u0308\u0306\u0304\u0301\u0305\u0302\u0302\u0304, bool \u0302\u0302\u0308\u0308\u0304\u0301\u0305\u0301\u0303\u0302\u0307\u0302\u0306\u0306\u0304)
	{
	}

	// Token: 0x060092E8 RID: 37608 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E8")]
	[Address(RVA = "0x183B6A0", Offset = "0x183AAA0", VA = "0x18183B6A0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void ReceivedApplyDamageFromServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092E9 RID: 37609 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092E9")]
	[Address(RVA = "0x183D620", Offset = "0x183CA20", VA = "0x18183D620")]
	public void ServerSide_ApplyHeal(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0301\u0306\u0306\u0303\u0305\u0308\u0308\u0306\u0302\u0304\u0305\u0305\u0301\u0308\u0301, ToolItem \u0308\u0305\u0305\u0305\u0307\u0302\u0301\u0308\u0307\u0305\u0302\u0307\u0303\u0304\u0306, float \u0304\u0306\u0307\u0306\u0307\u0308\u0308\u0304\u0304\u0302\u0302\u0307\u0307\u0301\u0304)
	{
	}

	// Token: 0x060092EA RID: 37610 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092EA")]
	[Address(RVA = "0x183C490", Offset = "0x183B890", VA = "0x18183C490")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void RecievedApplyHealFromServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092EB RID: 37611 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092EB")]
	[Address(RVA = "0x183CE70", Offset = "0x183C270", VA = "0x18183CE70")]
	public void ServerSideRepair(float \u0304\u0306\u0307\u0306\u0307\u0308\u0308\u0304\u0304\u0302\u0302\u0307\u0307\u0301\u0304)
	{
	}

	// Token: 0x060092EC RID: 37612 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092EC")]
	[Address(RVA = "0x183C3C0", Offset = "0x183B7C0", VA = "0x18183C3C0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void ReceivedServerHeal()
	{
	}

	// Token: 0x060092ED RID: 37613 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x60092ED")]
	[Address(RVA = "0x1836700", Offset = "0x1835B00", VA = "0x181836700")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x17C270", Offset = "0x17B670")]
	public IEnumerable<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304> GetPeopleRepairing()
	{
		return null;
	}

	// Token: 0x060092EE RID: 37614 RVA: 0x00038864 File Offset: 0x00036A64
	[Token(Token = "0x60092EE")]
	[Address(RVA = "0x18357F0", Offset = "0x1834BF0", VA = "0x1818357F0", Slot = "76")]
	public virtual bool CanBeRepaired(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0301\u0304\u0306\u0306\u0303\u0308\u0302\u0308\u0302\u0301\u0306\u0301\u0306\u0301\u0303)
	{
		return default(bool);
	}

	// Token: 0x060092EF RID: 37615 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092EF")]
	[Address(RVA = "0x183C650", Offset = "0x183BA50", VA = "0x18183C650")]
	public void RegisterRepair(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0301\u0304\u0306\u0306\u0303\u0308\u0302\u0308\u0302\u0301\u0306\u0301\u0306\u0301\u0303, float \u0308\u0307\u0308\u0305\u0304\u0304\u0302\u0303\u0302\u0308\u0308\u0305\u0301\u0308\u0307)
	{
	}

	// Token: 0x060092F0 RID: 37616 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F0")]
	[Address(RVA = "0x183F030", Offset = "0x183E430", VA = "0x18183F030")]
	private void \u0307\u0302\u0301\u0301\u0302\u0308\u0301\u0306\u0301\u0302\u0305\u0304\u0302\u0303\u0304()
	{
	}

	// Token: 0x060092F1 RID: 37617 RVA: 0x0003887C File Offset: 0x00036A7C
	[Token(Token = "0x60092F1")]
	[Address(RVA = "0x902FF0", Offset = "0x9023F0", VA = "0x180902FF0", Slot = "77")]
	public virtual bool ShouldReceiveAutoDamageServer(ref float \u0308\u0305\u0303\u0302\u0304\u0303\u0308\u0302\u0306\u0304\u0302\u0307\u0305\u0301\u0306)
	{
		return default(bool);
	}

	// Token: 0x060092F2 RID: 37618 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F2")]
	[Address(RVA = "0x1837BD0", Offset = "0x1836FD0", VA = "0x181837BD0", Slot = "78")]
	public virtual void OnHealthChanged()
	{
	}

	// Token: 0x060092F3 RID: 37619 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F3")]
	[Address(RVA = "0x18375E0", Offset = "0x18369E0", VA = "0x1818375E0", Slot = "35")]
	public override void OnASeatOwnerChanged(\u0307\u0303\u0308\u0305\u0302\u0301\u0306\u0304\u0308\u0305\u0305\u0304\u0305\u0301\u0303 \u0308\u0303\u0303\u0302\u0302\u0305\u0308\u0301\u0308\u0304\u0302\u0303\u0305\u0305\u0304, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, bool \u0304\u0302\u0301\u0305\u0305\u0301\u0306\u0306\u0302\u0306\u0302\u0308\u0301\u0301\u0305)
	{
	}

	// Token: 0x060092F4 RID: 37620 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F4")]
	[Address(RVA = "0x183B100", Offset = "0x183A500", VA = "0x18183B100", Slot = "79")]
	public virtual void OnVehicleExplode(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0305\u0301\u0301\u0305\u0301\u0304\u0306\u0303\u0301\u0305\u0303\u0305\u0302\u0306\u0303)
	{
	}

	// Token: 0x060092F5 RID: 37621 RVA: 0x00038894 File Offset: 0x00036A94
	[Token(Token = "0x60092F5")]
	[Address(RVA = "0x1836370", Offset = "0x1835770", VA = "0x181836370", Slot = "29")]
	public override bool GetExitPosition(\u0307\u0303\u0308\u0305\u0302\u0301\u0306\u0304\u0308\u0305\u0305\u0304\u0305\u0301\u0303 \u0308\u0303\u0303\u0302\u0302\u0305\u0308\u0301\u0308\u0304\u0302\u0303\u0305\u0305\u0304, bool \u0306\u0302\u0304\u0301\u0306\u0307\u0306\u0307\u0304\u0301\u0303\u0303\u0307\u0305\u0305, out Vector3 \u0302\u0307\u0305\u0308\u0307\u0308\u0301\u0307\u0305\u0304\u0305\u0306\u0305\u0305\u0305)
	{
		return default(bool);
	}

	// Token: 0x060092F6 RID: 37622 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F6")]
	[Address(RVA = "0x1838C80", Offset = "0x1838080", VA = "0x181838C80", Slot = "37")]
	public override void OnPlayerLeft(\u0307\u0303\u0308\u0305\u0302\u0301\u0306\u0304\u0308\u0305\u0305\u0304\u0305\u0301\u0303 \u0308\u0303\u0303\u0302\u0302\u0305\u0308\u0301\u0308\u0304\u0302\u0303\u0305\u0305\u0304, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, bool \u0304\u0307\u0308\u0307\u0305\u0306\u0305\u0305\u0301\u0305\u0306\u0306\u0307\u0305\u0306)
	{
	}

	// Token: 0x060092F7 RID: 37623 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F7")]
	[Address(RVA = "0x18394F0", Offset = "0x18388F0", VA = "0x1818394F0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x146E90", Offset = "0x146290")]
	public void OnSeatShotRPCReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092F8 RID: 37624 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F8")]
	[Address(RVA = "0x18393C0", Offset = "0x18387C0", VA = "0x1818393C0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x146E90", Offset = "0x146290")]
	public void OnSeatRPCReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092F9 RID: 37625 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092F9")]
	[Address(RVA = "0x1839290", Offset = "0x1838690", VA = "0x181839290")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	public void OnSeatRPCReceivedFromServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x060092FA RID: 37626 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092FA")]
	[Address(RVA = "0x1835D50", Offset = "0x1835150", VA = "0x181835D50")]
	public void DisableColliders()
	{
	}

	// Token: 0x060092FB RID: 37627 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092FB")]
	[Address(RVA = "0x1835E00", Offset = "0x1835200", VA = "0x181835E00")]
	public void EnableColliders()
	{
	}

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x060092FC RID: 37628 RVA: 0x000388AC File Offset: 0x00036AAC
	// (set) Token: 0x060092FD RID: 37629 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x1700059A")]
	public \u0305\u0307\u0308\u0302\u0301\u0308\u0307\u0308\u0306\u0305\u0305\u0302\u0308\u0305\u0303 \u0306\u0303\u0304\u0308\u0303\u0304\u0306\u0304\u0304\u0306\u0305\u0305\u0304\u0307\u0303
	{
		[Token(Token = "0x60092FC")]
		[Address(RVA = "0x1840380", Offset = "0x183F780", VA = "0x181840380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		get
		{
			return \u0305\u0307\u0308\u0302\u0301\u0308\u0307\u0308\u0306\u0305\u0305\u0302\u0308\u0305\u0303.Forest;
		}
		[Token(Token = "0x60092FD")]
		[Address(RVA = "0x183EFB0", Offset = "0x183E3B0", VA = "0x18183EFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private set
		{
		}
	}

	// Token: 0x060092FE RID: 37630 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092FE")]
	[Address(RVA = "0x183EDE0", Offset = "0x183E1E0", VA = "0x18183EDE0")]
	private void \u0304\u0301\u0307\u0306\u0301\u0306\u0305\u0302\u0302\u0301\u0308\u0307\u0308\u0301\u0307(\u0305\u0307\u0308\u0302\u0301\u0308\u0307\u0308\u0306\u0305\u0305\u0302\u0308\u0305\u0303 \u0306\u0307\u0308\u0303\u0301\u0302\u0303\u0303\u0308\u0307\u0308\u0307\u0304\u0306\u0304)
	{
	}

	// Token: 0x060092FF RID: 37631 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x60092FF")]
	[Address(RVA = "0x183ECC0", Offset = "0x183E0C0", VA = "0x18183ECC0")]
	private void \u0303\u0301\u0304\u0304\u0301\u0305\u0303\u0306\u0302\u0305\u0302\u0303\u0303\u0306\u0308()
	{
	}

	// Token: 0x06009300 RID: 37632 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009300")]
	[Address(RVA = "0x183DAC0", Offset = "0x183CEC0", VA = "0x18183DAC0")]
	public void SetNewFrontLights(\u0306\u0306\u0304\u0304\u0308\u0308\u0305\u0306\u0308\u0303\u0307\u0302\u0303\u0304\u0301 \u0303\u0304\u0303\u0302\u0305\u0307\u0307\u0308\u0306\u0305\u0305\u0304\u0305\u0303\u0307)
	{
	}

	// Token: 0x06009301 RID: 37633 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009301")]
	[Address(RVA = "0x183D990", Offset = "0x183CD90", VA = "0x18183D990")]
	public void SetNewBackLights(\u0301\u0308\u0306\u0303\u0304\u0302\u0308\u0306\u0306\u0308\u0301\u0302\u0301\u0302\u0305 \u0303\u0304\u0303\u0302\u0305\u0307\u0307\u0308\u0306\u0305\u0305\u0304\u0305\u0303\u0307)
	{
	}

	// Token: 0x06009302 RID: 37634 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009302")]
	[Address(RVA = "0x183B990", Offset = "0x183AD90", VA = "0x18183B990")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x146E90", Offset = "0x146290")]
	private void ReceivedFrontLightRequest(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x06009303 RID: 37635 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009303")]
	[Address(RVA = "0x183B8D0", Offset = "0x183ACD0", VA = "0x18183B8D0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x146E90", Offset = "0x146290")]
	private void ReceivedBackLightRequest(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x06009304 RID: 37636 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009304")]
	[Address(RVA = "0x183EFF0", Offset = "0x183E3F0", VA = "0x18183EFF0")]
	private void \u0306\u0307\u0304\u0304\u0303\u0302\u0305\u0304\u0306\u0302\u0304\u0307\u0302\u0307\u0305(\u0306\u0306\u0304\u0304\u0308\u0308\u0305\u0306\u0308\u0303\u0307\u0302\u0303\u0304\u0301 \u0303\u0304\u0303\u0302\u0305\u0307\u0307\u0308\u0306\u0305\u0305\u0304\u0305\u0303\u0307)
	{
	}

	// Token: 0x06009305 RID: 37637 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009305")]
	[Address(RVA = "0x183EC80", Offset = "0x183E080", VA = "0x18183EC80")]
	private void \u0302\u0308\u0307\u0308\u0302\u0304\u0301\u0308\u0308\u0302\u0308\u0305\u0301\u0302\u0302(\u0301\u0308\u0306\u0303\u0304\u0302\u0308\u0306\u0306\u0308\u0301\u0302\u0301\u0302\u0305 \u0303\u0304\u0303\u0302\u0305\u0307\u0307\u0308\u0306\u0305\u0305\u0304\u0305\u0303\u0307)
	{
	}

	// Token: 0x06009306 RID: 37638 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009306")]
	[Address(RVA = "0x1836DA0", Offset = "0x18361A0", VA = "0x181836DA0", Slot = "80")]
	public virtual void HandleFloatingWaterPhysics()
	{
	}

	// Token: 0x06009307 RID: 37639 RVA: 0x000388C4 File Offset: 0x00036AC4
	[Token(Token = "0x6009307")]
	[Address(RVA = "0x183FEE0", Offset = "0x183F2E0", VA = "0x18183FEE0", Slot = "31")]
	public override bool canAnyoneGetIn()
	{
		return default(bool);
	}

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06009308 RID: 37640 RVA: 0x000388DC File Offset: 0x00036ADC
	[Token(Token = "0x1700059B")]
	public bool \u0305\u0303\u0303\u0304\u0304\u0302\u0307\u0301\u0303\u0302\u0308\u0304\u0301\u0301\u0305
	{
		[Token(Token = "0x6009308")]
		[Address(RVA = "0x1840460", Offset = "0x183F860", VA = "0x181840460")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06009309 RID: 37641 RVA: 0x000388F4 File Offset: 0x00036AF4
	[Token(Token = "0x6009309")]
	[Address(RVA = "0x1837520", Offset = "0x1836920", VA = "0x181837520")]
	public bool NeedsAmmo()
	{
		return default(bool);
	}

	// Token: 0x0600930A RID: 37642 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600930A")]
	[Address(RVA = "0x183CBE0", Offset = "0x183BFE0", VA = "0x18183CBE0")]
	public void SendSupply()
	{
	}

	// Token: 0x0600930B RID: 37643 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600930B")]
	[Address(RVA = "0x183DD40", Offset = "0x183D140", VA = "0x18183DD40")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void Supply()
	{
	}

	// Token: 0x0600930C RID: 37644 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600930C")]
	[Address(RVA = "0x183CB60", Offset = "0x183BF60", VA = "0x18183CB60")]
	public void RequestToPush()
	{
	}

	// Token: 0x0600930D RID: 37645 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600930D")]
	[Address(RVA = "0x183BCC0", Offset = "0x183B0C0", VA = "0x18183BCC0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x13E750", Offset = "0x13DB50")]
	private void ReceivedPushRequest()
	{
	}

	// Token: 0x0600930E RID: 37646 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600930E")]
	[Address(RVA = "0x183BFA0", Offset = "0x183B3A0", VA = "0x18183BFA0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void ReceivedPush()
	{
	}

	// Token: 0x0600930F RID: 37647 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600930F")]
	[Address(RVA = "0x183EBC0", Offset = "0x183DFC0", VA = "0x18183EBC0")]
	private void \u0301\u0307\u0304\u0302\u0307\u0303\u0302\u0301\u0303\u0301\u0308\u0305\u0306\u0306\u0304(FoliageItem \u0308\u0305\u0305\u0305\u0307\u0302\u0301\u0308\u0307\u0305\u0302\u0307\u0303\u0304\u0306)
	{
	}

	// Token: 0x06009310 RID: 37648 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009310")]
	[Address(RVA = "0x183BB00", Offset = "0x183AF00", VA = "0x18183BB00")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void ReceivedPlayFoliageSound(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x06009311 RID: 37649 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009311")]
	[Address(RVA = "0x1835CE0", Offset = "0x18350E0", VA = "0x181835CE0")]
	public void ClearSpotLocal()
	{
	}

	// Token: 0x06009312 RID: 37650 RVA: 0x0003890C File Offset: 0x00036B0C
	[Token(Token = "0x6009312")]
	[Address(RVA = "0x1835C50", Offset = "0x1835050", VA = "0x181835C50")]
	public bool CanSpot()
	{
		return default(bool);
	}

	// Token: 0x06009313 RID: 37651 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009313")]
	[Address(RVA = "0x183DCC0", Offset = "0x183D0C0", VA = "0x18183DCC0")]
	public void Spot()
	{
	}

	// Token: 0x06009314 RID: 37652 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009314")]
	[Address(RVA = "0x1840CE0", Offset = "0x18400E0", VA = "0x181840CE0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x13E750", Offset = "0x13DB50")]
	private void mReceivedSpotRequest()
	{
	}

	// Token: 0x06009315 RID: 37653 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009315")]
	[Address(RVA = "0x183C430", Offset = "0x183B830", VA = "0x18183C430")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void ReceivedSpot(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x06009316 RID: 37654 RVA: 0x00038924 File Offset: 0x00036B24
	[Token(Token = "0x6009316")]
	[Address(RVA = "0x1835F00", Offset = "0x1835300", VA = "0x181835F00")]
	public Vector3 GetClosestPoint(Vector3 \u0303\u0308\u0308\u0308\u0305\u0304\u0308\u0305\u0308\u0302\u0301\u0306\u0307\u0308\u0301, out float \u0306\u0301\u0307\u0303\u0304\u0307\u0304\u0302\u0308\u0304\u0305\u0308\u0304\u0307\u0305)
	{
		return default(Vector3);
	}

	// Token: 0x06009317 RID: 37655 RVA: 0x0003893C File Offset: 0x00036B3C
	[Token(Token = "0x6009317")]
	[Address(RVA = "0x1835850", Offset = "0x1834C50", VA = "0x181835850", Slot = "28")]
	public override bool CanGetInToSeat(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, \u0307\u0303\u0308\u0305\u0302\u0301\u0306\u0304\u0308\u0305\u0305\u0304\u0305\u0301\u0303 \u0308\u0303\u0303\u0302\u0302\u0305\u0308\u0301\u0308\u0304\u0302\u0303\u0305\u0305\u0304)
	{
		return default(bool);
	}

	// Token: 0x06009318 RID: 37656 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009318")]
	[Address(RVA = "0x183DBF0", Offset = "0x183CFF0", VA = "0x18183DBF0")]
	public void SetNewSpawnTeam(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0304\u0304\u0301\u0305\u0302\u0304\u0308\u0306\u0302\u0306\u0301\u0308\u0304\u0306\u0302, bool \u0307\u0304\u0308\u0301\u0304\u0307\u0302\u0305\u0301\u0303\u0308\u0307\u0303\u0308\u0306 = true)
	{
	}

	// Token: 0x06009319 RID: 37657 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009319")]
	[Address(RVA = "0x183BAB0", Offset = "0x183AEB0", VA = "0x18183BAB0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void ReceivedNewSpawnTeam(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x0600931A RID: 37658 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600931A")]
	[Address(RVA = "0x1837F90", Offset = "0x1837390", VA = "0x181837F90")]
	public void OnLocalHitWindow(int \u0307\u0301\u0308\u0308\u0301\u0305\u0308\u0301\u0308\u0307\u0301\u0304\u0307\u0307\u0305, Vector3 \u0303\u0303\u0304\u0303\u0306\u0305\u0305\u0303\u0305\u0303\u0301\u0307\u0305\u0305\u0302, Vector3 \u0301\u0305\u0304\u0303\u0303\u0304\u0308\u0306\u0301\u0303\u0305\u0304\u0307\u0305\u0306, Vector2 \u0304\u0306\u0305\u0307\u0303\u0303\u0304\u0305\u0306\u0303\u0307\u0301\u0304\u0308\u0304, ushort \u0307\u0305\u0304\u0307\u0301\u0305\u0306\u0304\u0302\u0301\u0304\u0301\u0301\u0306\u0302)
	{
	}

	// Token: 0x0600931B RID: 37659 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600931B")]
	[Address(RVA = "0x1840920", Offset = "0x183FD20", VA = "0x181840920")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x13E750", Offset = "0x13DB50")]
	private void mReceivedHitWindowRequest(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x0600931C RID: 37660 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600931C")]
	[Address(RVA = "0x1840FF0", Offset = "0x18403F0", VA = "0x181840FF0")]
	[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
	private void mReceivedWindowHit(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x0600931D RID: 37661 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600931D")]
	[Address(RVA = "0x183F7A0", Offset = "0x183EBA0", VA = "0x18183F7A0", Slot = "32")]
	public override void WriteSnapshot(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x0600931E RID: 37662 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600931E")]
	[Address(RVA = "0x183B2B0", Offset = "0x183A6B0", VA = "0x18183B2B0", Slot = "33")]
	public override void ReadSnapshot(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
	{
	}

	// Token: 0x0600931F RID: 37663 RVA: 0x00038954 File Offset: 0x00036B54
	[Token(Token = "0x600931F")]
	[Address(RVA = "0x1835D10", Offset = "0x1835110", VA = "0x181835D10", Slot = "49")]
	public int CompareTo(VehicleInstance \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
	{
		return 0;
	}

	// Token: 0x06009320 RID: 37664 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6009320")]
	[Address(RVA = "0x183FDE0", Offset = "0x183F1E0", VA = "0x18183FDE0")]
	protected VehicleInstance()
	{
	}

	// Token: 0x0400175D RID: 5981
	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x58")]
	public \u0303\u0308\u0303\u0307\u0301\u0304\u0303\u0306\u0304\u0303\u0303\u0302\u0302\u0303\u0303 \u0302\u0307\u0302\u0303\u0307\u0308\u0306\u0308\u0301\u0305\u0302\u0302\u0305\u0308\u0301;

	// Token: 0x0400175E RID: 5982
	[Token(Token = "0x400175E")]
	public const float \u0303\u0302\u0307\u0308\u0305\u0302\u0301\u0306\u0306\u0308\u0306\u0306\u0301\u0307\u0305 = 5f;

	// Token: 0x0400175F RID: 5983
	[Token(Token = "0x400175F")]
	[FieldOffset(Offset = "0x0")]
	public static VehicleInstance \u0301\u0302\u0303\u0307\u0305\u0303\u0306\u0306\u0301\u0303\u0301\u0303\u0304\u0304\u0306;

	// Token: 0x04001760 RID: 5984
	[Token(Token = "0x4001760")]
	[FieldOffset(Offset = "0x8")]
	public static FastListA<VehicleInstance> \u0305\u0302\u0303\u0305\u0303\u0307\u0305\u0305\u0301\u0308\u0301\u0305\u0303\u0308\u0302;

	// Token: 0x04001761 RID: 5985
	[Token(Token = "0x4001761")]
	[FieldOffset(Offset = "0x10")]
	public static VehicleInstance[] \u0307\u0302\u0303\u0303\u0307\u0308\u0307\u0304\u0308\u0303\u0308\u0307\u0305\u0307\u0307;

	// Token: 0x04001762 RID: 5986
	[Token(Token = "0x4001762")]
	[FieldOffset(Offset = "0x18")]
	public static SortedList<int, VehicleInstance> \u0301\u0307\u0307\u0302\u0301\u0303\u0308\u0303\u0305\u0302\u0303\u0305\u0308\u0306\u0305;

	// Token: 0x04001763 RID: 5987
	[Token(Token = "0x4001763")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<ulong, float> \u0307\u0307\u0305\u0305\u0304\u0306\u0303\u0307\u0301\u0305\u0303\u0301\u0304\u0304\u0305;

	// Token: 0x04001764 RID: 5988
	[Token(Token = "0x4001764")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private static int <\u0307\u0304\u0304\u0307\u0307\u0301\u0306\u0306\u0304\u0308\u0308\u0304\u0301\u0303\u0303>k__BackingField;

	// Token: 0x04001765 RID: 5989
	[Token(Token = "0x4001765")]
	[FieldOffset(Offset = "0x60")]
	public MeshRenderer[] \u0307\u0307\u0301\u0307\u0305\u0303\u0305\u0303\u0304\u0306\u0308\u0306\u0302\u0301\u0306;

	// Token: 0x04001766 RID: 5990
	[Token(Token = "0x4001766")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1749D0", Offset = "0x173DD0")]
	private GameObject FrontLights;

	// Token: 0x04001767 RID: 5991
	[Token(Token = "0x4001767")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject BackLights;

	// Token: 0x04001768 RID: 5992
	[Token(Token = "0x4001768")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private int <\u0307\u0308\u0302\u0303\u0303\u0306\u0306\u0308\u0303\u0304\u0303\u0305\u0308\u0304\u0306>k__BackingField;

	// Token: 0x04001769 RID: 5993
	[Token(Token = "0x4001769")]
	[FieldOffset(Offset = "0x7C")]
	[NonSerialized]
	public int \u0307\u0301\u0305\u0306\u0306\u0306\u0305\u0301\u0303\u0301\u0306\u0303\u0302\u0305\u0303;

	// Token: 0x0400176A RID: 5994
	[Token(Token = "0x400176A")]
	[FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public bool \u0306\u0306\u0301\u0304\u0308\u0308\u0306\u0302\u0305\u0301\u0307\u0307\u0308\u0307\u0305;

	// Token: 0x0400176B RID: 5995
	[Token(Token = "0x400176B")]
	[FieldOffset(Offset = "0x81")]
	[NonSerialized]
	public bool \u0301\u0303\u0305\u0305\u0301\u0301\u0308\u0302\u0308\u0307\u0304\u0305\u0308\u0307\u0306;

	// Token: 0x0400176C RID: 5996
	[Token(Token = "0x400176C")]
	[FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public \u0307\u0307\u0306\u0307\u0306\u0306\u0306\u0306\u0305\u0304\u0307\u0307\u0303\u0302\u0303 \u0302\u0308\u0303\u0308\u0308\u0306\u0304\u0304\u0308\u0304\u0304\u0305\u0301\u0304\u0305;

	// Token: 0x0400176D RID: 5997
	[Token(Token = "0x400176D")]
	[FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public \u0306\u0304\u0307\u0303\u0306\u0303\u0302\u0301\u0301\u0303\u0305\u0307\u0301\u0305\u0308[] \u0308\u0303\u0302\u0303\u0303\u0303\u0308\u0303\u0303\u0303\u0304\u0302\u0306\u0302\u0303;

	// Token: 0x0400176E RID: 5998
	[Token(Token = "0x400176E")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private Transform <\u0304\u0303\u0308\u0301\u0307\u0305\u0306\u0301\u0303\u0306\u0303\u0308\u0307\u0307\u0304>k__BackingField;

	// Token: 0x0400176F RID: 5999
	[Token(Token = "0x400176F")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private Transform <\u0306\u0304\u0305\u0301\u0307\u0304\u0305\u0306\u0302\u0303\u0308\u0308\u0308\u0302\u0305>k__BackingField;

	// Token: 0x04001770 RID: 6000
	[Token(Token = "0x4001770")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private Transform <\u0308\u0302\u0301\u0307\u0301\u0306\u0308\u0304\u0301\u0304\u0307\u0308\u0304\u0306\u0308>k__BackingField;

	// Token: 0x04001771 RID: 6001
	[Token(Token = "0x4001771")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private Transform <\u0308\u0308\u0306\u0307\u0307\u0303\u0306\u0302\u0303\u0306\u0305\u0304\u0304\u0301\u0308>k__BackingField;

	// Token: 0x04001772 RID: 6002
	[Token(Token = "0x4001772")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0304\u0305\u0304\u0304\u0307\u0303\u0307\u0303\u0302\u0308\u0304\u0303\u0303\u0303\u0302 <\u0306\u0305\u0304\u0307\u0302\u0303\u0307\u0307\u0303\u0304\u0303\u0303\u0308\u0304\u0302>k__BackingField;

	// Token: 0x04001773 RID: 6003
	[Token(Token = "0x4001773")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0304\u0304\u0307\u0305\u0302\u0307\u0303\u0306\u0305\u0303\u0307\u0308\u0306\u0303\u0306 <\u0303\u0308\u0307\u0302\u0307\u0306\u0304\u0301\u0308\u0308\u0303\u0302\u0305\u0301\u0306>k__BackingField;

	// Token: 0x04001774 RID: 6004
	[Token(Token = "0x4001774")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0307\u0302\u0301\u0302\u0308\u0302\u0307\u0301\u0304\u0302\u0302\u0301\u0301\u0306\u0305 <\u0301\u0304\u0304\u0304\u0306\u0307\u0303\u0301\u0305\u0307\u0302\u0302\u0302\u0308\u0304>k__BackingField;

	// Token: 0x04001775 RID: 6005
	[Token(Token = "0x4001775")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0307\u0308\u0307\u0307\u0305\u0304\u0301\u0305\u0306\u0306\u0302\u0307\u0302\u0301\u0303[] <\u0306\u0303\u0304\u0308\u0306\u0303\u0304\u0301\u0301\u0306\u0303\u0304\u0302\u0304\u0304>k__BackingField;

	// Token: 0x04001776 RID: 6006
	[Token(Token = "0x4001776")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private MeshRenderer[] <\u0304\u0308\u0302\u0303\u0304\u0306\u0307\u0306\u0304\u0303\u0304\u0305\u0302\u0307\u0308>k__BackingField;

	// Token: 0x04001777 RID: 6007
	[Token(Token = "0x4001777")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private List<GameObject> <\u0307\u0303\u0303\u0302\u0305\u0305\u0302\u0306\u0301\u0303\u0303\u0308\u0301\u0306\u0305>k__BackingField;

	// Token: 0x04001778 RID: 6008
	[Token(Token = "0x4001778")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0307\u0304\u0305\u0304\u0304\u0304\u0302\u0302\u0305\u0302\u0305\u0302\u0301\u0307\u0308 <\u0307\u0306\u0306\u0306\u0305\u0303\u0302\u0301\u0303\u0305\u0308\u0302\u0306\u0301\u0307>k__BackingField;

	// Token: 0x04001779 RID: 6009
	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0305\u0302\u0305\u0303\u0307\u0302\u0307\u0304\u0307\u0307\u0304\u0302\u0301\u0307\u0306 <\u0303\u0306\u0301\u0305\u0303\u0307\u0307\u0306\u0307\u0307\u0307\u0305\u0308\u0306\u0307>k__BackingField;

	// Token: 0x0400177A RID: 6010
	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0304\u0302\u0303\u0303\u0302\u0307\u0303\u0308\u0301\u0308\u0301\u0302\u0303\u0304\u0306 <\u0303\u0305\u0305\u0303\u0303\u0305\u0306\u0304\u0305\u0305\u0302\u0305\u0303\u0307\u0301>k__BackingField;

	// Token: 0x0400177B RID: 6011
	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0308\u0303\u0301\u0305\u0306\u0306\u0306\u0305\u0302\u0302\u0304\u0301\u0307\u0308\u0305>k__BackingField;

	// Token: 0x0400177C RID: 6012
	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0x104")]
	[NonSerialized]
	public Vector3 \u0303\u0307\u0301\u0305\u0302\u0306\u0306\u0304\u0301\u0307\u0304\u0307\u0307\u0307\u0302;

	// Token: 0x0400177D RID: 6013
	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x110")]
	[NonSerialized]
	public Quaternion \u0304\u0302\u0308\u0306\u0305\u0304\u0302\u0306\u0304\u0305\u0304\u0308\u0306\u0308\u0306;

	// Token: 0x0400177E RID: 6014
	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x120")]
	[NonSerialized]
	public \u0303\u0303\u0304\u0303\u0306\u0301\u0308\u0306\u0305\u0305\u0304\u0303\u0301\u0303\u0301 \u0304\u0301\u0303\u0302\u0306\u0307\u0308\u0304\u0301\u0304\u0301\u0305\u0301\u0306\u0305;

	// Token: 0x0400177F RID: 6015
	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0x128")]
	[NonSerialized]
	public \u0305\u0306\u0305\u0307\u0306\u0306\u0308\u0304\u0306\u0302\u0301\u0301\u0304\u0301\u0302 \u0305\u0306\u0305\u0307\u0306\u0306\u0308\u0304\u0306\u0302\u0301\u0301\u0304\u0301\u0302;

	// Token: 0x04001780 RID: 6016
	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x130")]
	[NonSerialized]
	public \u0303\u0307\u0307\u0301\u0301\u0307\u0308\u0308\u0305\u0302\u0302\u0304\u0306\u0305\u0306 \u0301\u0304\u0308\u0308\u0301\u0306\u0305\u0306\u0301\u0303\u0305\u0302\u0305\u0307\u0306;

	// Token: 0x04001781 RID: 6017
	[Token(Token = "0x4001781")]
	[FieldOffset(Offset = "0x138")]
	[NonSerialized]
	public Dictionary<ulong, ValueTuple<float, ushort>> \u0301\u0308\u0307\u0308\u0306\u0306\u0305\u0307\u0304\u0302\u0304\u0303\u0307\u0307\u0306;

	// Token: 0x04001782 RID: 6018
	[Token(Token = "0x4001782")]
	[FieldOffset(Offset = "0x140")]
	[NonSerialized]
	public Vector3[] \u0307\u0303\u0304\u0305\u0308\u0306\u0307\u0307\u0302\u0307\u0301\u0308\u0306\u0307\u0302;

	// Token: 0x04001783 RID: 6019
	[Token(Token = "0x4001783")]
	[FieldOffset(Offset = "0x148")]
	[NonSerialized]
	public \u0306\u0308\u0303\u0307\u0306\u0308\u0302\u0307\u0307\u0302\u0307\u0308\u0303\u0303\u0307[] \u0304\u0308\u0302\u0305\u0301\u0305\u0305\u0301\u0306\u0302\u0302\u0305\u0305\u0307\u0305;

	// Token: 0x04001784 RID: 6020
	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0x150")]
	[NonSerialized]
	public \u0303\u0306\u0308\u0303\u0306\u0305\u0301\u0305\u0303\u0305\u0302\u0308\u0301\u0302\u0307 \u0303\u0301\u0307\u0304\u0302\u0307\u0302\u0307\u0305\u0305\u0306\u0307\u0304\u0303\u0304;

	// Token: 0x04001785 RID: 6021
	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0x158")]
	private \u0303\u0304\u0308\u0308\u0302\u0308\u0306\u0305\u0305\u0302\u0308\u0306\u0301\u0307\u0305 \u0305\u0305\u0302\u0302\u0303\u0302\u0303\u0301\u0303\u0307\u0301\u0304\u0308\u0308\u0306;

	// Token: 0x04001786 RID: 6022
	[Token(Token = "0x4001786")]
	[FieldOffset(Offset = "0x160")]
	private bool \u0308\u0306\u0305\u0301\u0305\u0303\u0307\u0307\u0304\u0303\u0304\u0306\u0303\u0306\u0305;

	// Token: 0x04001787 RID: 6023
	[Token(Token = "0x4001787")]
	[FieldOffset(Offset = "0x168")]
	private Dictionary<ulong, float> \u0304\u0307\u0308\u0307\u0303\u0304\u0303\u0302\u0303\u0306\u0306\u0305\u0304\u0307\u0305;

	// Token: 0x04001788 RID: 6024
	[Token(Token = "0x4001788")]
	[FieldOffset(Offset = "0x170")]
	private bool \u0308\u0302\u0306\u0303\u0304\u0307\u0302\u0302\u0302\u0308\u0303\u0307\u0301\u0302\u0304;

	// Token: 0x04001789 RID: 6025
	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0x171")]
	private bool \u0306\u0303\u0306\u0303\u0308\u0306\u0306\u0304\u0306\u0308\u0307\u0306\u0301\u0302\u0303;

	// Token: 0x0400178A RID: 6026
	[Token(Token = "0x400178A")]
	[FieldOffset(Offset = "0x172")]
	private bool \u0307\u0303\u0302\u0307\u0304\u0303\u0304\u0304\u0308\u0305\u0305\u0308\u0308\u0305\u0305;

	// Token: 0x0400178B RID: 6027
	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0x174")]
	private float \u0308\u0304\u0304\u0305\u0303\u0304\u0302\u0302\u0306\u0308\u0307\u0302\u0303\u0308\u0302;

	// Token: 0x0400178C RID: 6028
	[Token(Token = "0x400178C")]
	[FieldOffset(Offset = "0x178")]
	private float \u0302\u0306\u0302\u0306\u0307\u0307\u0302\u0306\u0307\u0303\u0305\u0301\u0306\u0304\u0305;

	// Token: 0x0400178D RID: 6029
	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x180")]
	private ulong \u0306\u0303\u0302\u0306\u0306\u0307\u0302\u0306\u0308\u0305\u0308\u0301\u0307\u0305\u0308;

	// Token: 0x0400178E RID: 6030
	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x188")]
	private int \u0306\u0301\u0303\u0303\u0307\u0302\u0306\u0303\u0306\u0303\u0302\u0301\u0304\u0307\u0305;

	// Token: 0x0400178F RID: 6031
	[Token(Token = "0x400178F")]
	[FieldOffset(Offset = "0x18C")]
	private int \u0301\u0303\u0305\u0303\u0303\u0306\u0308\u0304\u0308\u0305\u0305\u0307\u0305\u0304\u0304;

	// Token: 0x04001790 RID: 6032
	[Token(Token = "0x4001790")]
	[FieldOffset(Offset = "0x190")]
	private float \u0308\u0303\u0303\u0307\u0305\u0302\u0304\u0302\u0304\u0306\u0305\u0304\u0303\u0308\u0301;

	// Token: 0x04001791 RID: 6033
	[Token(Token = "0x4001791")]
	[FieldOffset(Offset = "0x194")]
	private float \u0301\u0307\u0301\u0303\u0308\u0305\u0307\u0307\u0303\u0308\u0302\u0302\u0305\u0305\u0304;

	// Token: 0x04001792 RID: 6034
	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x198")]
	private float \u0307\u0307\u0308\u0306\u0307\u0307\u0308\u0308\u0307\u0307\u0303\u0303\u0306\u0307\u0304;

	// Token: 0x04001793 RID: 6035
	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x19C")]
	private float \u0302\u0301\u0307\u0306\u0305\u0301\u0306\u0304\u0301\u0303\u0301\u0308\u0302\u0306\u0303;

	// Token: 0x04001794 RID: 6036
	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x1A0")]
	private int \u0301\u0305\u0303\u0306\u0306\u0301\u0308\u0302\u0302\u0301\u0302\u0304\u0304\u0308\u0308;

	// Token: 0x04001795 RID: 6037
	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x1A4")]
	private float \u0305\u0303\u0303\u0308\u0302\u0306\u0308\u0308\u0307\u0305\u0301\u0306\u0308\u0307\u0303;

	// Token: 0x04001796 RID: 6038
	[Token(Token = "0x4001796")]
	[FieldOffset(Offset = "0x1A8")]
	protected float \u0302\u0308\u0303\u0308\u0301\u0308\u0305\u0305\u0302\u0301\u0308\u0304\u0303\u0308\u0306;

	// Token: 0x04001797 RID: 6039
	[Token(Token = "0x4001797")]
	[FieldOffset(Offset = "0x1AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private int <\u0305\u0301\u0308\u0304\u0304\u0308\u0304\u0306\u0304\u0306\u0302\u0301\u0308\u0302\u0305>k__BackingField;

	// Token: 0x04001798 RID: 6040
	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0x1B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private Vector3 <\u0302\u0302\u0302\u0304\u0306\u0302\u0306\u0304\u0305\u0306\u0308\u0302\u0308\u0307\u0306>k__BackingField;

	// Token: 0x04001799 RID: 6041
	[Token(Token = "0x4001799")]
	[FieldOffset(Offset = "0x1BC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <\u0301\u0303\u0306\u0307\u0301\u0305\u0303\u0302\u0301\u0305\u0308\u0302\u0306\u0306\u0302>k__BackingField;

	// Token: 0x0400179A RID: 6042
	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0x1BD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <\u0302\u0308\u0303\u0307\u0308\u0307\u0306\u0306\u0302\u0303\u0302\u0308\u0301\u0306\u0307>k__BackingField;

	// Token: 0x0400179B RID: 6043
	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x1C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0305\u0305\u0302\u0305\u0307\u0302\u0301\u0301\u0308\u0301\u0307\u0302\u0308\u0304\u0306>k__BackingField;

	// Token: 0x0400179C RID: 6044
	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x1C4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0304\u0307\u0306\u0304\u0301\u0308\u0306\u0306\u0304\u0301\u0306\u0305\u0303\u0302\u0305>k__BackingField;

	// Token: 0x0400179D RID: 6045
	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x1C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <\u0306\u0305\u0303\u0303\u0306\u0306\u0301\u0306\u0302\u0304\u0304\u0301\u0308\u0302\u0307>k__BackingField;

	// Token: 0x0400179E RID: 6046
	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x1CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0308\u0306\u0308\u0303\u0302\u0302\u0304\u0302\u0305\u0301\u0307\u0304\u0304\u0307\u0303>k__BackingField;

	// Token: 0x0400179F RID: 6047
	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x1D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0305\u0308\u0305\u0307\u0305\u0305\u0302\u0304\u0305\u0306\u0307\u0307\u0307\u0304\u0304 <\u0303\u0305\u0302\u0302\u0304\u0307\u0308\u0302\u0305\u0305\u0301\u0306\u0307\u0302\u0304>k__BackingField;

	// Token: 0x040017A0 RID: 6048
	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x1D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 <\u0307\u0308\u0308\u0306\u0302\u0302\u0303\u0305\u0305\u0301\u0304\u0308\u0308\u0304\u0307>k__BackingField;

	// Token: 0x040017A1 RID: 6049
	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x1DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0306\u0306\u0304\u0304\u0308\u0308\u0305\u0306\u0308\u0303\u0307\u0302\u0303\u0304\u0301 <\u0302\u0303\u0304\u0306\u0301\u0308\u0307\u0306\u0308\u0303\u0306\u0304\u0307\u0307\u0302>k__BackingField;

	// Token: 0x040017A2 RID: 6050
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x1E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0301\u0308\u0306\u0303\u0304\u0302\u0308\u0306\u0306\u0308\u0301\u0302\u0301\u0302\u0305 <\u0308\u0307\u0304\u0307\u0303\u0306\u0304\u0302\u0303\u0302\u0307\u0307\u0304\u0301\u0301>k__BackingField;

	// Token: 0x040017A3 RID: 6051
	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x1E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0302\u0302\u0307\u0305\u0303\u0306\u0303\u0301\u0306\u0306\u0307\u0305\u0304\u0306\u0305>k__BackingField;

	// Token: 0x040017A4 RID: 6052
	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x1E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0301\u0304\u0301\u0308\u0306\u0304\u0308\u0304\u0306\u0308\u0306\u0307\u0301\u0308\u0304>k__BackingField;

	// Token: 0x040017A5 RID: 6053
	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x1EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0305\u0308\u0301\u0301\u0301\u0306\u0304\u0305\u0303\u0303\u0307\u0302\u0301\u0301\u0306>k__BackingField;

	// Token: 0x040017A6 RID: 6054
	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x1F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0306\u0306\u0304\u0303\u0302\u0307\u0307\u0308\u0307\u0307\u0305\u0304\u0302\u0304\u0302>k__BackingField;

	// Token: 0x040017A7 RID: 6055
	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x1F4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private float <\u0303\u0306\u0302\u0302\u0308\u0302\u0308\u0304\u0303\u0301\u0308\u0308\u0302\u0308\u0304>k__BackingField;

	// Token: 0x040017A8 RID: 6056
	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x1F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private ulong <\u0306\u0301\u0307\u0306\u0306\u0304\u0306\u0302\u0308\u0301\u0304\u0303\u0306\u0305\u0305>k__BackingField;

	// Token: 0x040017A9 RID: 6057
	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x200")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private ushort <\u0304\u0307\u0308\u0305\u0304\u0308\u0307\u0301\u0305\u0302\u0302\u0307\u0303\u0301\u0307>k__BackingField;

	// Token: 0x040017AA RID: 6058
	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0x202")]
	private bool \u0303\u0303\u0308\u0306\u0307\u0302\u0305\u0307\u0302\u0304\u0303\u0301\u0302\u0307\u0304;

	// Token: 0x040017AB RID: 6059
	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0x204")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private \u0305\u0307\u0308\u0302\u0301\u0308\u0307\u0308\u0306\u0305\u0305\u0302\u0308\u0305\u0303 <\u0308\u0302\u0301\u0305\u0305\u0304\u0303\u0301\u0306\u0308\u0302\u0305\u0306\u0307\u0306>k__BackingField;

	// Token: 0x040017AC RID: 6060
	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0x208")]
	private float \u0307\u0307\u0306\u0302\u0304\u0304\u0302\u0303\u0306\u0306\u0302\u0305\u0301\u0306\u0303;

	// Token: 0x040017AD RID: 6061
	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0x20C")]
	private float \u0301\u0303\u0304\u0302\u0308\u0306\u0303\u0301\u0304\u0302\u0306\u0304\u0306\u0306\u0308;

	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private sealed class \u0302\u0307\u0303\u0305\u0307\u0308\u0304\u0307\u0305\u0303\u0303\u0302\u0307\u0306\u0303 : IEnumerable<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304>, IEnumerable, IEnumerator<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304>, IEnumerator, IDisposable
	{
		// Token: 0x06009322 RID: 37666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6009322")]
		[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
		[DebuggerHidden]
		public \u0302\u0307\u0303\u0305\u0307\u0308\u0304\u0307\u0305\u0303\u0303\u0302\u0307\u0306\u0303(int <>1__state)
		{
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6009323")]
		[Address(RVA = "0x1DF76E0", Offset = "0x1DF6AE0", VA = "0x181DF76E0", Slot = "7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x0003896C File Offset: 0x00036B6C
		[Token(Token = "0x6009324")]
		[Address(RVA = "0x1DF73F0", Offset = "0x1DF67F0", VA = "0x181DF73F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6009325")]
		[Address(RVA = "0x1DF7780", Offset = "0x1DF6B80", VA = "0x181DF7780")]
		private void \u0303\u0302\u0304\u0303\u0301\u0306\u0304\u0307\u0304\u0304\u0307\u0302\u0301\u0302\u0303()
		{
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06009326 RID: 37670 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x1700059C")]
		private \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 Current
		{
			[Token(Token = "0x6009326")]
			[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6009327")]
		[Address(RVA = "0x1DF7690", Offset = "0x1DF6A90", VA = "0x181DF7690", Slot = "10")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06009328 RID: 37672 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x1700059D")]
		private object Current
		{
			[Token(Token = "0x6009328")]
			[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6009329")]
		[Address(RVA = "0x1DF75F0", Offset = "0x1DF69F0", VA = "0x181DF75F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600932A")]
		[Address(RVA = "0x1DF75F0", Offset = "0x1DF69F0", VA = "0x181DF75F0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040017AE RID: 6062
		[Token(Token = "0x40017AE")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040017AF RID: 6063
		[Token(Token = "0x40017AF")]
		[FieldOffset(Offset = "0x18")]
		private \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 <>2__current;

		// Token: 0x040017B0 RID: 6064
		[Token(Token = "0x40017B0")]
		[FieldOffset(Offset = "0x20")]
		private int <>l__initialThreadId;

		// Token: 0x040017B1 RID: 6065
		[Token(Token = "0x40017B1")]
		[FieldOffset(Offset = "0x28")]
		public VehicleInstance <>4__this;

		// Token: 0x040017B2 RID: 6066
		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x30")]
		private float <now>5__2;

		// Token: 0x040017B3 RID: 6067
		[Token(Token = "0x40017B3")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ulong, float>.Enumerator <>7__wrap2;
	}
}
