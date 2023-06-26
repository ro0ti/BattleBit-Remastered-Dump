using System;
using System.Collections.Generic;
using Attachments;
using touching_your_mom;
using UnityEngine;

namespace PlayerLoadout.Items
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public class AWeapon : ToolItem, \u0308\u0301\u0304\u0304\u0302\u0302\u0306\u0305\u0307\u0307\u0306\u0301\u0306\u0308\u0301, IComparable<AWeapon>, IEqualityComparer<AWeapon>
	{
		// Token: 0x06011EC0 RID: 73408 RVA: 0x0006F4DC File Offset: 0x0006D6DC
		[Token(Token = "0x6011EC0")]
		[Address(RVA = "0x9BF2A0", Offset = "0x9BE6A0", VA = "0x1809BF2A0", Slot = "42")]
		public bool \u0303\u0303\u0303\u0308\u0308\u0301\u0303\u0307\u0301\u0302\u0301\u0304\u0302\u0306\u0305()
		{
			return default(bool);
		}

		// Token: 0x06011EC1 RID: 73409 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EC1")]
		[Address(RVA = "0x319BDA0", Offset = "0x319B1A0", VA = "0x18319BDA0")]
		public static AWeapon \u0305\u0304\u0303\u0307\u0301\u0301\u0302\u0304\u0304\u0306\u0302\u0307\u0308\u0304\u0305()
		{
			return null;
		}

		// Token: 0x06011EC2 RID: 73410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011EC2")]
		[Address(RVA = "0x3198940", Offset = "0x3197D40", VA = "0x183198940")]
		public void \u0302\u0306\u0306\u0303\u0308\u0303\u0302\u0302\u0307\u0303\u0304\u0305\u0305\u0307\u0303(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011EC3 RID: 73411 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EC3")]
		[Address(RVA = "0x319C550", Offset = "0x319B950", VA = "0x18319C550")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0306\u0307\u0307\u0302\u0302\u0305\u0308\u0303\u0301\u0302\u0307\u0305\u0301\u0305\u0306()
		{
			return null;
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06011EC4 RID: 73412 RVA: 0x0006F4F4 File Offset: 0x0006D6F4
		[Token(Token = "0x1700099C")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 Nation
		{
			[Token(Token = "0x6011EC4")]
			[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "34")]
			get
			{
				return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
			}
		}

		// Token: 0x06011EC5 RID: 73413 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EC5")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0")]
		public GameObject \u0307\u0307\u0302\u0307\u0308\u0306\u0305\u0302\u0306\u0305\u0306\u0306\u0306\u0305\u0303()
		{
			return null;
		}

		// Token: 0x06011EC6 RID: 73414 RVA: 0x0006F50C File Offset: 0x0006D70C
		[Token(Token = "0x6011EC6")]
		[Address(RVA = "0x319BDC0", Offset = "0x319B1C0", VA = "0x18319BDC0", Slot = "43")]
		public bool \u0305\u0304\u0305\u0306\u0305\u0307\u0305\u0304\u0305\u0308\u0307\u0307\u0307\u0304\u0301()
		{
			return default(bool);
		}

		// Token: 0x06011EC7 RID: 73415 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EC7")]
		[Address(RVA = "0x319C340", Offset = "0x319B740", VA = "0x18319C340", Slot = "44")]
		public virtual string \u0306\u0306\u0307\u0304\u0304\u0301\u0303\u0307\u0305\u0303\u0305\u0302\u0305\u0307\u0306()
		{
			return null;
		}

		// Token: 0x06011EC8 RID: 73416 RVA: 0x0006F524 File Offset: 0x0006D724
		[Token(Token = "0x6011EC8")]
		[Address(RVA = "0x2F9BF40", Offset = "0x2F9B340", VA = "0x182F9BF40", Slot = "45")]
		public int \u0304\u0306\u0301\u0303\u0303\u0305\u0307\u0301\u0305\u0304\u0301\u0304\u0304\u0306\u0305(AWeapon \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return 0;
		}

		// Token: 0x06011EC9 RID: 73417 RVA: 0x0006F53C File Offset: 0x0006D73C
		[Token(Token = "0x6011EC9")]
		[Address(RVA = "0x3198A20", Offset = "0x3197E20", VA = "0x183198A20", Slot = "46")]
		public float \u0304\u0308\u0305\u0308\u0306\u0308\u0302\u0304\u0308\u0306\u0304\u0308\u0306\u0307\u0308()
		{
			return 0f;
		}

		// Token: 0x06011ECA RID: 73418 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ECA")]
		[Address(RVA = "0x319E340", Offset = "0x319D740", VA = "0x18319E340", Slot = "47")]
		public virtual string \u0308\u0306\u0304\u0308\u0302\u0301\u0305\u0305\u0301\u0306\u0305\u0308\u0301\u0304\u0302()
		{
			return null;
		}

		// Token: 0x06011ECB RID: 73419 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ECB")]
		[Address(RVA = "0xAEB3E0", Offset = "0xAEA7E0", VA = "0x180AEB3E0", Slot = "48")]
		public Avaibility \u0302\u0302\u0301\u0304\u0308\u0305\u0306\u0307\u0303\u0304\u0303\u0302\u0307\u0302\u0301()
		{
			return null;
		}

		// Token: 0x06011ECC RID: 73420 RVA: 0x0006F554 File Offset: 0x0006D754
		[Token(Token = "0x6011ECC")]
		[Address(RVA = "0x2F9BF40", Offset = "0x2F9B340", VA = "0x182F9BF40", Slot = "39")]
		public int CompareTo(AWeapon \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return 0;
		}

		// Token: 0x06011ECD RID: 73421 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ECD")]
		[Address(RVA = "0x319A420", Offset = "0x3199820", VA = "0x18319A420")]
		public GameObject \u0304\u0302\u0302\u0307\u0304\u0305\u0306\u0301\u0301\u0306\u0308\u0303\u0302\u0304\u0301(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011ECE RID: 73422 RVA: 0x0006F56C File Offset: 0x0006D76C
		[Token(Token = "0x6011ECE")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "49")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0304\u0302\u0301\u0301\u0308\u0305\u0308\u0303\u0304\u0301\u0306\u0308\u0301\u0304\u0301()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011ECF RID: 73423 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ECF")]
		[Address(RVA = "0x319BAC0", Offset = "0x319AEC0", VA = "0x18319BAC0")]
		public static AWeapon \u0305\u0302\u0306\u0305\u0305\u0301\u0305\u0308\u0301\u0303\u0304\u0301\u0301\u0303\u0301()
		{
			return null;
		}

		// Token: 0x06011ED0 RID: 73424 RVA: 0x0006F584 File Offset: 0x0006D784
		[Token(Token = "0x6011ED0")]
		[Address(RVA = "0x319D700", Offset = "0x319CB00", VA = "0x18319D700", Slot = "50")]
		public bool \u0307\u0302\u0302\u0305\u0304\u0308\u0304\u0301\u0308\u0308\u0304\u0306\u0304\u0304\u0303()
		{
			return default(bool);
		}

		// Token: 0x06011ED1 RID: 73425 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ED1")]
		[Address(RVA = "0xA3E370", Offset = "0xA3D770", VA = "0x180A3E370", Slot = "51")]
		public ToolItem \u0302\u0307\u0303\u0301\u0306\u0302\u0303\u0306\u0302\u0302\u0302\u0306\u0301\u0306\u0302()
		{
			return null;
		}

		// Token: 0x06011ED2 RID: 73426 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ED2")]
		[Address(RVA = "0x319A570", Offset = "0x3199970", VA = "0x18319A570")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0307\u0308\u0305\u0302\u0301\u0307\u0301\u0306\u0307\u0306\u0305\u0302\u0305\u0307\u0305(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011ED3 RID: 73427 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ED3")]
		[Address(RVA = "0x3197320", Offset = "0x3196720", VA = "0x183197320")]
		public new static AWeapon \u0301\u0303\u0308\u0304\u0302\u0303\u0308\u0307\u0306\u0307\u0307\u0305\u0305\u0306\u0302(ushort \u0307\u0303\u0301\u0304\u0305\u0302\u0301\u0308\u0306\u0307\u0305\u0305\u0305\u0305\u0303)
		{
			return null;
		}

		// Token: 0x06011ED4 RID: 73428 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ED4")]
		[Address(RVA = "0x319BA20", Offset = "0x319AE20", VA = "0x18319BA20")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0305\u0302\u0305\u0307\u0307\u0302\u0308\u0307\u0303\u0307\u0304\u0308\u0303\u0304\u0301(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011ED5 RID: 73429 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ED5")]
		[Address(RVA = "0xAEB3E0", Offset = "0xAEA7E0", VA = "0x180AEB3E0", Slot = "52")]
		public Avaibility \u0303\u0308\u0305\u0304\u0305\u0305\u0303\u0308\u0306\u0306\u0305\u0308\u0306\u0301\u0305()
		{
			return null;
		}

		// Token: 0x06011ED6 RID: 73430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011ED6")]
		[Address(RVA = "0x31974F0", Offset = "0x31968F0", VA = "0x1831974F0")]
		public void \u0301\u0307\u0307\u0303\u0306\u0304\u0307\u0302\u0301\u0303\u0302\u0304\u0304\u0302\u0305(uint \u0302\u0304\u0307\u0301\u0308\u0304\u0303\u0307\u0303\u0303\u0303\u0304\u0304\u0303\u0303)
		{
		}

		// Token: 0x06011ED7 RID: 73431 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ED7")]
		[Address(RVA = "0x319F340", Offset = "0x319E740", VA = "0x18319F340", Slot = "53")]
		public virtual string \u0308\u0307\u0304\u0308\u0301\u0303\u0308\u0301\u0301\u0304\u0306\u0305\u0301\u0302\u0308()
		{
			return null;
		}

		// Token: 0x06011ED8 RID: 73432 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011ED8")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0")]
		public GameObject \u0308\u0302\u0302\u0308\u0305\u0301\u0306\u0305\u0302\u0305\u0308\u0303\u0307\u0302\u0307()
		{
			return null;
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06011ED9 RID: 73433 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x17000999")]
		public ToolItem Item
		{
			[Token(Token = "0x6011ED9")]
			[Address(RVA = "0xA3E370", Offset = "0xA3D770", VA = "0x180A3E370", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06011EDA RID: 73434 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x170009A3")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 Attachments
		{
			[Token(Token = "0x6011EDA")]
			[Address(RVA = "0x319F630", Offset = "0x319EA30", VA = "0x18319F630")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011EDB RID: 73435 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EDB")]
		[Address(RVA = "0x3198B60", Offset = "0x3197F60", VA = "0x183198B60")]
		public AWeaponMag \u0302\u0308\u0305\u0306\u0306\u0303\u0307\u0305\u0302\u0303\u0301\u0302\u0304\u0303\u0304(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011EDC RID: 73436 RVA: 0x0006F59C File Offset: 0x0006D79C
		[Token(Token = "0x6011EDC")]
		[Address(RVA = "0x319E050", Offset = "0x319D450", VA = "0x18319E050")]
		public uint \u0308\u0304\u0306\u0303\u0303\u0305\u0302\u0306\u0305\u0302\u0306\u0307\u0303\u0301\u0301()
		{
			return 0U;
		}

		// Token: 0x06011EDD RID: 73437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011EDD")]
		[Address(RVA = "0x319E480", Offset = "0x319D880", VA = "0x18319E480")]
		public void \u0308\u0307\u0303\u0301\u0307\u0306\u0306\u0304\u0302\u0307\u0304\u0302\u0306\u0305\u0306(uint \u0302\u0304\u0307\u0301\u0308\u0304\u0303\u0307\u0303\u0303\u0303\u0304\u0304\u0303\u0303)
		{
		}

		// Token: 0x06011EDE RID: 73438 RVA: 0x0006F5B4 File Offset: 0x0006D7B4
		[Token(Token = "0x6011EDE")]
		[Address(RVA = "0x2F9BFA0", Offset = "0x2F9B3A0", VA = "0x182F9BFA0", Slot = "54")]
		public int \u0304\u0304\u0303\u0308\u0308\u0302\u0305\u0302\u0308\u0301\u0302\u0307\u0305\u0305\u0303(AWeapon \u0305\u0303\u0307\u0301\u0308\u0307\u0307\u0307\u0304\u0308\u0306\u0302\u0308\u0307\u0304)
		{
			return 0;
		}

		// Token: 0x06011EDF RID: 73439 RVA: 0x0006F5CC File Offset: 0x0006D7CC
		[Token(Token = "0x6011EDF")]
		[Address(RVA = "0x319A6D0", Offset = "0x3199AD0", VA = "0x18319A6D0", Slot = "55")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 \u0308\u0308\u0307\u0305\u0302\u0308\u0308\u0302\u0304\u0301\u0306\u0302\u0304\u0308\u0308()
		{
			return \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302.Primary;
		}

		// Token: 0x06011EE0 RID: 73440 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EE0")]
		[Address(RVA = "0x900D10", Offset = "0x900110", VA = "0x180900D10", Slot = "56")]
		public GameObject \u0306\u0303\u0302\u0302\u0303\u0308\u0303\u0303\u0306\u0308\u0301\u0306\u0306\u0304\u0301()
		{
			return null;
		}

		// Token: 0x06011EE1 RID: 73441 RVA: 0x0006F5E4 File Offset: 0x0006D7E4
		[Token(Token = "0x6011EE1")]
		[Address(RVA = "0x9DD4A0", Offset = "0x9DC8A0", VA = "0x1809DD4A0", Slot = "4")]
		public override ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304 \u0306\u0307\u0303\u0305\u0302\u0308\u0306\u0305\u0304\u0303\u0307\u0303\u0308\u0306\u0307()
		{
			return ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304.None;
		}

		// Token: 0x06011EE2 RID: 73442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011EE2")]
		[Address(RVA = "0x31992C0", Offset = "0x31986C0", VA = "0x1831992C0")]
		public void \u0303\u0307\u0303\u0308\u0304\u0303\u0301\u0307\u0301\u0301\u0307\u0306\u0305\u0308\u0302(uint \u0302\u0304\u0307\u0301\u0308\u0304\u0303\u0307\u0303\u0303\u0303\u0304\u0304\u0303\u0303)
		{
		}

		// Token: 0x06011EE3 RID: 73443 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EE3")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0")]
		public GameObject \u0301\u0301\u0305\u0303\u0303\u0308\u0301\u0304\u0307\u0303\u0303\u0308\u0304\u0305\u0304()
		{
			return null;
		}

		// Token: 0x06011EE4 RID: 73444 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EE4")]
		[Address(RVA = "0x3198A40", Offset = "0x3197E40", VA = "0x183198A40")]
		public static AWeapon \u0305\u0308\u0305\u0308\u0301\u0304\u0307\u0308\u0308\u0308\u0306\u0303\u0306\u0307\u0307(ushort \u0307\u0303\u0301\u0304\u0305\u0302\u0301\u0308\u0306\u0307\u0305\u0305\u0305\u0305\u0303)
		{
			return null;
		}

		// Token: 0x06011EE5 RID: 73445 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EE5")]
		[Address(RVA = "0x31986C0", Offset = "0x3197AC0", VA = "0x1831986C0")]
		public static AWeapon \u0302\u0304\u0305\u0301\u0308\u0306\u0301\u0303\u0304\u0303\u0304\u0302\u0305\u0307\u0308(ushort \u0307\u0303\u0301\u0304\u0305\u0302\u0301\u0308\u0306\u0307\u0305\u0305\u0305\u0305\u0303)
		{
			return null;
		}

		// Token: 0x06011EE6 RID: 73446 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EE6")]
		[Address(RVA = "0x319F400", Offset = "0x319E800", VA = "0x18319F400")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0308\u0307\u0305\u0306\u0303\u0305\u0308\u0308\u0307\u0306\u0302\u0305\u0304\u0306\u0308(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011EE7 RID: 73447 RVA: 0x0006F5FC File Offset: 0x0006D7FC
		[Token(Token = "0x6011EE7")]
		[Address(RVA = "0x2F9BF70", Offset = "0x2F9B370", VA = "0x182F9BF70", Slot = "57")]
		public bool \u0306\u0301\u0305\u0302\u0304\u0305\u0306\u0307\u0308\u0303\u0305\u0301\u0305\u0302\u0305(AWeapon \u0305\u0302\u0307\u0301\u0306\u0307\u0305\u0302\u0301\u0301\u0307\u0304\u0306\u0308\u0308, AWeapon \u0302\u0302\u0301\u0305\u0303\u0301\u0304\u0307\u0303\u0303\u0302\u0303\u0307\u0304\u0308)
		{
			return default(bool);
		}

		// Token: 0x06011EE8 RID: 73448 RVA: 0x0006F614 File Offset: 0x0006D814
		[Token(Token = "0x6011EE8")]
		[Address(RVA = "0x319E120", Offset = "0x319D520", VA = "0x18319E120")]
		public uint \u0308\u0305\u0302\u0306\u0301\u0303\u0306\u0305\u0302\u0301\u0307\u0301\u0304\u0306\u0305()
		{
			return 0U;
		}

		// Token: 0x06011EE9 RID: 73449 RVA: 0x0006F62C File Offset: 0x0006D82C
		[Token(Token = "0x6011EE9")]
		[Address(RVA = "0x319DB90", Offset = "0x319CF90", VA = "0x18319DB90")]
		public uint \u0307\u0305\u0307\u0302\u0305\u0302\u0308\u0306\u0301\u0304\u0305\u0307\u0308\u0308\u0307()
		{
			return 0U;
		}

		// Token: 0x06011EEA RID: 73450 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EEA")]
		[Address(RVA = "0x319D8F0", Offset = "0x319CCF0", VA = "0x18319D8F0")]
		public static AWeapon \u0307\u0303\u0302\u0306\u0302\u0303\u0305\u0304\u0301\u0304\u0307\u0304\u0307\u0302\u0302(ushort \u0307\u0303\u0301\u0304\u0305\u0302\u0301\u0308\u0306\u0307\u0305\u0305\u0305\u0305\u0303)
		{
			return null;
		}

		// Token: 0x06011EEB RID: 73451 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EEB")]
		[Address(RVA = "0x1AFEAF0", Offset = "0x1AFDEF0", VA = "0x181AFEAF0", Slot = "58")]
		private string \u0304\u0305\u0304\u0307\u0303\u0302\u0303\u0307\u0305\u0308\u0303\u0303\u0308\u0304\u0303()
		{
			return null;
		}

		// Token: 0x06011EEC RID: 73452 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EEC")]
		[Address(RVA = "0xAEB3E0", Offset = "0xAEA7E0", VA = "0x180AEB3E0", Slot = "59")]
		public Avaibility \u0302\u0307\u0302\u0302\u0304\u0308\u0303\u0303\u0306\u0303\u0308\u0301\u0306\u0308\u0304()
		{
			return null;
		}

		// Token: 0x06011EED RID: 73453 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EED")]
		[Address(RVA = "0x319BB60", Offset = "0x319AF60", VA = "0x18319BB60", Slot = "60")]
		public virtual string \u0305\u0303\u0302\u0306\u0308\u0305\u0307\u0302\u0308\u0302\u0308\u0301\u0302\u0305\u0303()
		{
			return null;
		}

		// Token: 0x06011EEE RID: 73454 RVA: 0x0006F644 File Offset: 0x0006D844
		[Token(Token = "0x6011EEE")]
		[Address(RVA = "0x319B590", Offset = "0x319A990", VA = "0x18319B590", Slot = "61")]
		public virtual bool \u0304\u0306\u0305\u0306\u0305\u0304\u0306\u0307\u0302\u0302\u0303\u0307\u0307\u0306\u0302(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 \u0304\u0307\u0306\u0307\u0306\u0306\u0306\u0301\u0308\u0301\u0303\u0304\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06011EEF RID: 73455 RVA: 0x0006F65C File Offset: 0x0006D85C
		[Token(Token = "0x1700099D")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 Index
		{
			[Token(Token = "0x6011EEF")]
			[Address(RVA = "0x319A6D0", Offset = "0x3199AD0", VA = "0x18319A6D0", Slot = "35")]
			get
			{
				return \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302.Primary;
			}
		}

		// Token: 0x06011EF0 RID: 73456 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EF0")]
		[Address(RVA = "0x319DAF0", Offset = "0x319CEF0", VA = "0x18319DAF0")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0307\u0305\u0301\u0301\u0308\u0306\u0307\u0304\u0303\u0302\u0307\u0304\u0303\u0305\u0303(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011EF1 RID: 73457 RVA: 0x0006F674 File Offset: 0x0006D874
		[Token(Token = "0x6011EF1")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0", Slot = "62")]
		public virtual ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304 \u0303\u0304\u0301\u0308\u0302\u0307\u0305\u0301\u0303\u0307\u0303\u0302\u0305\u0305\u0302()
		{
			return ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304.None;
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06011EF2 RID: 73458 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x1700099B")]
		public GameObject RemotePrefab
		{
			[Token(Token = "0x6011EF2")]
			[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011EF3 RID: 73459 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EF3")]
		[Address(RVA = "0x900D10", Offset = "0x900110", VA = "0x180900D10", Slot = "63")]
		public GameObject \u0306\u0307\u0304\u0301\u0307\u0306\u0301\u0303\u0308\u0308\u0307\u0306\u0301\u0303\u0302()
		{
			return null;
		}

		// Token: 0x06011EF4 RID: 73460 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EF4")]
		[Address(RVA = "0xAEB3E0", Offset = "0xAEA7E0", VA = "0x180AEB3E0", Slot = "64")]
		public Avaibility \u0301\u0306\u0301\u0301\u0301\u0301\u0304\u0303\u0306\u0308\u0308\u0303\u0306\u0308\u0301()
		{
			return null;
		}

		// Token: 0x06011EF5 RID: 73461 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EF5")]
		[Address(RVA = "0x319DFD0", Offset = "0x319D3D0", VA = "0x18319DFD0")]
		public AWeaponSkin \u0308\u0303\u0308\u0303\u0307\u0305\u0302\u0307\u0301\u0308\u0301\u0307\u0308\u0307\u0301(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011EF6 RID: 73462 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EF6")]
		[Address(RVA = "0x3197010", Offset = "0x3196410", VA = "0x183197010")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0301\u0302\u0302\u0306\u0301\u0304\u0301\u0308\u0304\u0307\u0308\u0308\u0305\u0303\u0302(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011EF7 RID: 73463 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EF7")]
		[Address(RVA = "0x31970B0", Offset = "0x31964B0", VA = "0x1831970B0", Slot = "65")]
		public virtual string \u0301\u0302\u0305\u0301\u0302\u0302\u0308\u0302\u0305\u0302\u0306\u0303\u0304\u0303\u0303()
		{
			return null;
		}

		// Token: 0x06011EF8 RID: 73464 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EF8")]
		[Address(RVA = "0x319B830", Offset = "0x319AC30", VA = "0x18319B830")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0304\u0308\u0305\u0304\u0304\u0308\u0303\u0307\u0301\u0304\u0303\u0305\u0307\u0305\u0307()
		{
			return null;
		}

		// Token: 0x06011EF9 RID: 73465 RVA: 0x0006F68C File Offset: 0x0006D88C
		[Token(Token = "0x6011EF9")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "66")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0307\u0302\u0304\u0308\u0302\u0308\u0308\u0307\u0303\u0302\u0301\u0307\u0303\u0305\u0303()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011EFA RID: 73466 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EFA")]
		[Address(RVA = "0x319A270", Offset = "0x3199670", VA = "0x18319A270")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0304\u0301\u0305\u0307\u0304\u0304\u0305\u0307\u0302\u0307\u0306\u0308\u0306\u0301\u0308()
		{
			return null;
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06011EFB RID: 73467 RVA: 0x0006F6A4 File Offset: 0x0006D8A4
		[Token(Token = "0x1700099F")]
		public float WalkingSpeed
		{
			[Token(Token = "0x6011EFB")]
			[Address(RVA = "0x3198A20", Offset = "0x3197E20", VA = "0x183198A20", Slot = "33")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06011EFC RID: 73468 RVA: 0x0006F6BC File Offset: 0x0006D8BC
		[Token(Token = "0x6011EFC")]
		[Address(RVA = "0x1E05310", Offset = "0x1E04710", VA = "0x181E05310", Slot = "67")]
		public virtual int \u0304\u0301\u0304\u0307\u0304\u0301\u0305\u0306\u0302\u0304\u0304\u0307\u0308\u0306\u0307()
		{
			return 0;
		}

		// Token: 0x06011EFD RID: 73469 RVA: 0x0006F6D4 File Offset: 0x0006D8D4
		[Token(Token = "0x6011EFD")]
		[Address(RVA = "0x2F9BF70", Offset = "0x2F9B370", VA = "0x182F9BF70", Slot = "68")]
		public bool \u0307\u0302\u0307\u0301\u0306\u0308\u0306\u0305\u0301\u0306\u0308\u0307\u0301\u0308\u0304(AWeapon \u0305\u0302\u0307\u0301\u0306\u0307\u0305\u0302\u0301\u0301\u0307\u0304\u0306\u0308\u0308, AWeapon \u0302\u0302\u0301\u0305\u0303\u0301\u0304\u0307\u0303\u0303\u0302\u0303\u0307\u0304\u0308)
		{
			return default(bool);
		}

		// Token: 0x06011EFE RID: 73470 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011EFE")]
		[Address(RVA = "0xA3E370", Offset = "0xA3D770", VA = "0x180A3E370", Slot = "69")]
		public ToolItem \u0307\u0304\u0306\u0307\u0304\u0303\u0301\u0307\u0307\u0303\u0303\u0301\u0307\u0306\u0302()
		{
			return null;
		}

		// Token: 0x06011EFF RID: 73471 RVA: 0x0006F6EC File Offset: 0x0006D8EC
		[Token(Token = "0x6011EFF")]
		[Address(RVA = "0x319A6D0", Offset = "0x3199AD0", VA = "0x18319A6D0", Slot = "70")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 \u0304\u0306\u0305\u0307\u0308\u0308\u0305\u0302\u0301\u0301\u0305\u0306\u0303\u0303\u0305()
		{
			return \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302.Primary;
		}

		// Token: 0x06011F00 RID: 73472 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F00")]
		[Address(RVA = "0x1AFEAF0", Offset = "0x1AFDEF0", VA = "0x181AFEAF0", Slot = "29")]
		private string \u0306\u0307\u0302\u0302\u0303\u0302\u0305\u0306\u0303\u0303\u0304\u0305\u0306\u0308\u0302()
		{
			return null;
		}

		// Token: 0x06011F01 RID: 73473 RVA: 0x0006F704 File Offset: 0x0006D904
		[Token(Token = "0x6011F01")]
		[Address(RVA = "0x319B900", Offset = "0x319AD00", VA = "0x18319B900", Slot = "71")]
		public bool \u0304\u0308\u0308\u0307\u0306\u0304\u0302\u0306\u0305\u0302\u0308\u0304\u0302\u0307\u0301()
		{
			return default(bool);
		}

		// Token: 0x06011F02 RID: 73474 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F02")]
		[Address(RVA = "0x3198460", Offset = "0x3197860", VA = "0x183198460")]
		public AWeaponSkin \u0301\u0308\u0306\u0302\u0302\u0306\u0305\u0306\u0301\u0305\u0308\u0301\u0305\u0306\u0305(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011F03 RID: 73475 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F03")]
		[Address(RVA = "0x1AFEAF0", Offset = "0x1AFDEF0", VA = "0x181AFEAF0", Slot = "72")]
		private string \u0301\u0307\u0308\u0306\u0307\u0301\u0306\u0303\u0304\u0303\u0307\u0307\u0304\u0301\u0301()
		{
			return null;
		}

		// Token: 0x06011F04 RID: 73476 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F04")]
		[Address(RVA = "0x31990A0", Offset = "0x31984A0", VA = "0x1831990A0", Slot = "73")]
		public virtual string \u0303\u0304\u0307\u0303\u0304\u0304\u0304\u0305\u0304\u0305\u0304\u0301\u0308\u0304\u0304()
		{
			return null;
		}

		// Token: 0x06011F05 RID: 73477 RVA: 0x0006F71C File Offset: 0x0006D91C
		[Token(Token = "0x6011F05")]
		[Address(RVA = "0x319BCA0", Offset = "0x319B0A0", VA = "0x18319BCA0", Slot = "74")]
		public virtual bool \u0305\u0304\u0302\u0302\u0304\u0302\u0301\u0307\u0302\u0301\u0308\u0302\u0301\u0302\u0307(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 \u0304\u0307\u0306\u0307\u0306\u0306\u0306\u0301\u0308\u0301\u0303\u0304\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x06011F06 RID: 73478 RVA: 0x0006F734 File Offset: 0x0006D934
		[Token(Token = "0x6011F06")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "75")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0305\u0305\u0301\u0304\u0306\u0302\u0302\u0301\u0306\u0301\u0301\u0302\u0303\u0305\u0301()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F07 RID: 73479 RVA: 0x0006F74C File Offset: 0x0006D94C
		[Token(Token = "0x6011F07")]
		[Address(RVA = "0x2F9BFA0", Offset = "0x2F9B3A0", VA = "0x182F9BFA0", Slot = "76")]
		public int \u0307\u0301\u0302\u0306\u0304\u0306\u0303\u0306\u0301\u0301\u0305\u0307\u0304\u0305\u0304(AWeapon \u0305\u0303\u0307\u0301\u0308\u0307\u0307\u0307\u0304\u0308\u0306\u0302\u0308\u0307\u0304)
		{
			return 0;
		}

		// Token: 0x06011F08 RID: 73480 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F08")]
		[Address(RVA = "0x3199000", Offset = "0x3198400", VA = "0x183199000")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0303\u0304\u0306\u0308\u0308\u0307\u0305\u0302\u0307\u0302\u0307\u0307\u0304\u0306\u0303(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011F09 RID: 73481 RVA: 0x0006F764 File Offset: 0x0006D964
		[Token(Token = "0x6011F09")]
		[Address(RVA = "0x319A6D0", Offset = "0x3199AD0", VA = "0x18319A6D0", Slot = "77")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 \u0307\u0305\u0301\u0302\u0301\u0306\u0305\u0305\u0303\u0305\u0306\u0304\u0308\u0308\u0302()
		{
			return \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302.Primary;
		}

		// Token: 0x06011F0A RID: 73482 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F0A")]
		[Address(RVA = "0x31988A0", Offset = "0x3197CA0", VA = "0x1831988A0")]
		public Mesh \u0302\u0306\u0303\u0303\u0301\u0302\u0303\u0303\u0302\u0303\u0307\u0301\u0306\u0301\u0302(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F0B RID: 73483 RVA: 0x0006F77C File Offset: 0x0006D97C
		[Token(Token = "0x6011F0B")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "78")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0306\u0305\u0303\u0305\u0307\u0303\u0308\u0301\u0302\u0305\u0303\u0304\u0306\u0302\u0308()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F0C RID: 73484 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F0C")]
		[Address(RVA = "0x319D820", Offset = "0x319CC20", VA = "0x18319D820")]
		public AWeaponMag \u0307\u0302\u0307\u0301\u0306\u0304\u0305\u0306\u0301\u0301\u0306\u0308\u0302\u0302\u0306(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011F0D RID: 73485 RVA: 0x0006F794 File Offset: 0x0006D994
		[Token(Token = "0x6011F0D")]
		[Address(RVA = "0x2F9BFA0", Offset = "0x2F9B3A0", VA = "0x182F9BFA0", Slot = "79")]
		public int \u0305\u0303\u0307\u0305\u0305\u0303\u0307\u0301\u0308\u0301\u0301\u0304\u0306\u0304\u0304(AWeapon \u0305\u0303\u0307\u0301\u0308\u0307\u0307\u0307\u0304\u0308\u0306\u0302\u0308\u0307\u0304)
		{
			return 0;
		}

		// Token: 0x06011F0E RID: 73486 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F0E")]
		[Address(RVA = "0xA3E370", Offset = "0xA3D770", VA = "0x180A3E370", Slot = "80")]
		public ToolItem \u0305\u0303\u0307\u0304\u0306\u0307\u0302\u0304\u0307\u0303\u0301\u0302\u0301\u0301\u0305()
		{
			return null;
		}

		// Token: 0x06011F0F RID: 73487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F0F")]
		[Address(RVA = "0x319DC60", Offset = "0x319D060", VA = "0x18319DC60")]
		public void \u0307\u0307\u0308\u0301\u0304\u0305\u0308\u0301\u0302\u0301\u0306\u0305\u0304\u0302\u0305(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011F10 RID: 73488 RVA: 0x0006F7AC File Offset: 0x0006D9AC
		[Token(Token = "0x6011F10")]
		[Address(RVA = "0x2F9BF70", Offset = "0x2F9B370", VA = "0x182F9BF70", Slot = "40")]
		public bool Equals(AWeapon \u0305\u0302\u0307\u0301\u0306\u0307\u0305\u0302\u0301\u0301\u0307\u0304\u0306\u0308\u0308, AWeapon \u0302\u0302\u0301\u0305\u0303\u0301\u0304\u0307\u0303\u0303\u0302\u0303\u0307\u0304\u0308)
		{
			return default(bool);
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06011F11 RID: 73489 RVA: 0x0006F7C4 File Offset: 0x0006D9C4
		[Token(Token = "0x170009A2")]
		public bool IsToolEnabled
		{
			[Token(Token = "0x6011F11")]
			[Address(RVA = "0x9BF2A0", Offset = "0x9BE6A0", VA = "0x1809BF2A0", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011F12 RID: 73490 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F12")]
		[Address(RVA = "0x319E400", Offset = "0x319D800", VA = "0x18319E400")]
		public GameObject \u0308\u0306\u0308\u0302\u0308\u0308\u0305\u0306\u0303\u0304\u0305\u0308\u0303\u0308\u0305(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F13 RID: 73491 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F13")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0")]
		public GameObject \u0302\u0306\u0303\u0302\u0305\u0303\u0308\u0302\u0303\u0304\u0304\u0306\u0302\u0307\u0306()
		{
			return null;
		}

		// Token: 0x06011F14 RID: 73492 RVA: 0x0006F7DC File Offset: 0x0006D9DC
		[Token(Token = "0x6011F14")]
		[Address(RVA = "0x2F9BF40", Offset = "0x2F9B340", VA = "0x182F9BF40", Slot = "81")]
		public int \u0304\u0305\u0302\u0307\u0302\u0306\u0308\u0307\u0305\u0306\u0304\u0307\u0304\u0302\u0304(AWeapon \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return 0;
		}

		// Token: 0x06011F15 RID: 73493 RVA: 0x0006F7F4 File Offset: 0x0006D9F4
		[Token(Token = "0x6011F15")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "82")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0301\u0304\u0303\u0307\u0302\u0307\u0307\u0302\u0302\u0302\u0303\u0304\u0306\u0301\u0303()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F16 RID: 73494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F16")]
		[Address(RVA = "0x319F540", Offset = "0x319E940", VA = "0x18319F540")]
		public AWeapon()
		{
		}

		// Token: 0x06011F17 RID: 73495 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F17")]
		[Address(RVA = "0x3198A90", Offset = "0x3197E90", VA = "0x183198A90")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0302\u0307\u0308\u0305\u0307\u0307\u0308\u0301\u0303\u0301\u0302\u0304\u0306\u0308\u0301()
		{
			return null;
		}

		// Token: 0x06011F18 RID: 73496 RVA: 0x0006F80C File Offset: 0x0006DA0C
		[Token(Token = "0x6011F18")]
		[Address(RVA = "0xCBCD50", Offset = "0xCBC150", VA = "0x180CBCD50")]
		public \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304 \u0301\u0307\u0304\u0302\u0305\u0303\u0303\u0307\u0305\u0304\u0308\u0304\u0301\u0301\u0302()
		{
			return \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304.Rifle;
		}

		// Token: 0x06011F19 RID: 73497 RVA: 0x0006F824 File Offset: 0x0006DA24
		[Token(Token = "0x6011F19")]
		[Address(RVA = "0x9BF2A0", Offset = "0x9BE6A0", VA = "0x1809BF2A0", Slot = "83")]
		public bool \u0305\u0303\u0308\u0303\u0303\u0307\u0303\u0308\u0304\u0306\u0301\u0305\u0307\u0305\u0306()
		{
			return default(bool);
		}

		// Token: 0x06011F1A RID: 73498 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F1A")]
		[Address(RVA = "0x3197250", Offset = "0x3196650", VA = "0x183197250")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0301\u0303\u0303\u0307\u0303\u0305\u0302\u0306\u0304\u0306\u0303\u0304\u0307\u0304\u0302()
		{
			return null;
		}

		// Token: 0x06011F1B RID: 73499 RVA: 0x0006F83C File Offset: 0x0006DA3C
		[Token(Token = "0x6011F1B")]
		[Address(RVA = "0x2F9BF70", Offset = "0x2F9B370", VA = "0x182F9BF70", Slot = "84")]
		public bool \u0301\u0304\u0302\u0304\u0301\u0301\u0308\u0303\u0302\u0307\u0305\u0303\u0306\u0303\u0301(AWeapon \u0305\u0302\u0307\u0301\u0306\u0307\u0305\u0302\u0301\u0301\u0307\u0304\u0306\u0308\u0308, AWeapon \u0302\u0302\u0301\u0305\u0303\u0301\u0304\u0307\u0303\u0303\u0302\u0303\u0307\u0304\u0308)
		{
			return default(bool);
		}

		// Token: 0x06011F1C RID: 73500 RVA: 0x0006F854 File Offset: 0x0006DA54
		[Token(Token = "0x6011F1C")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0", Slot = "85")]
		public virtual ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304 \u0302\u0306\u0301\u0305\u0307\u0302\u0305\u0306\u0304\u0303\u0307\u0301\u0308\u0307\u0305()
		{
			return ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304.None;
		}

		// Token: 0x06011F1D RID: 73501 RVA: 0x0006F86C File Offset: 0x0006DA6C
		[Token(Token = "0x6011F1D")]
		[Address(RVA = "0x2F9BFA0", Offset = "0x2F9B3A0", VA = "0x182F9BFA0", Slot = "41")]
		public int GetHashCode(AWeapon \u0305\u0303\u0307\u0301\u0308\u0307\u0307\u0307\u0304\u0308\u0306\u0302\u0308\u0307\u0304)
		{
			return 0;
		}

		// Token: 0x06011F1E RID: 73502 RVA: 0x0006F884 File Offset: 0x0006DA84
		[Token(Token = "0x6011F1E")]
		[Address(RVA = "0x2F9BFA0", Offset = "0x2F9B3A0", VA = "0x182F9BFA0", Slot = "86")]
		public int \u0306\u0302\u0302\u0307\u0306\u0306\u0302\u0305\u0305\u0301\u0305\u0305\u0304\u0307\u0301(AWeapon \u0305\u0303\u0307\u0301\u0308\u0307\u0307\u0307\u0304\u0308\u0306\u0302\u0308\u0307\u0304)
		{
			return 0;
		}

		// Token: 0x06011F1F RID: 73503 RVA: 0x0006F89C File Offset: 0x0006DA9C
		[Token(Token = "0x6011F1F")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0", Slot = "87")]
		public virtual ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304 \u0304\u0301\u0307\u0307\u0301\u0302\u0303\u0306\u0303\u0306\u0304\u0302\u0304\u0304\u0302()
		{
			return ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304.None;
		}

		// Token: 0x06011F20 RID: 73504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F20")]
		[Address(RVA = "0x319DEF0", Offset = "0x319D2F0", VA = "0x18319DEF0")]
		public void \u0308\u0303\u0303\u0307\u0308\u0301\u0307\u0306\u0301\u0305\u0301\u0304\u0301\u0306\u0304(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011F21 RID: 73505 RVA: 0x0006F8B4 File Offset: 0x0006DAB4
		[Token(Token = "0x6011F21")]
		[Address(RVA = "0x1E05310", Offset = "0x1E04710", VA = "0x181E05310", Slot = "88")]
		public virtual int \u0308\u0301\u0307\u0305\u0301\u0303\u0305\u0305\u0307\u0301\u0305\u0307\u0304\u0301\u0304()
		{
			return 0;
		}

		// Token: 0x06011F22 RID: 73506 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F22")]
		[Address(RVA = "0x3199160", Offset = "0x3198560", VA = "0x183199160", Slot = "89")]
		public virtual string \u0303\u0305\u0306\u0307\u0305\u0301\u0304\u0301\u0301\u0301\u0304\u0308\u0302\u0303\u0308()
		{
			return null;
		}

		// Token: 0x06011F23 RID: 73507 RVA: 0x0006F8CC File Offset: 0x0006DACC
		[Token(Token = "0x6011F23")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "90")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0302\u0307\u0301\u0302\u0306\u0304\u0302\u0303\u0302\u0305\u0307\u0303\u0301\u0304\u0308()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F24 RID: 73508 RVA: 0x0006F8E4 File Offset: 0x0006DAE4
		[Token(Token = "0x6011F24")]
		[Address(RVA = "0x3198A20", Offset = "0x3197E20", VA = "0x183198A20", Slot = "91")]
		public float \u0304\u0302\u0305\u0302\u0307\u0307\u0302\u0305\u0301\u0301\u0308\u0305\u0305\u0301\u0301()
		{
			return 0f;
		}

		// Token: 0x06011F25 RID: 73509 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F25")]
		[Address(RVA = "0x319E1F0", Offset = "0x319D5F0", VA = "0x18319E1F0")]
		public static AWeapon \u0308\u0305\u0307\u0303\u0307\u0304\u0302\u0301\u0303\u0301\u0307\u0302\u0302\u0308\u0307(ushort \u0307\u0303\u0301\u0304\u0305\u0302\u0301\u0308\u0306\u0307\u0305\u0305\u0305\u0305\u0303)
		{
			return null;
		}

		// Token: 0x06011F26 RID: 73510 RVA: 0x0006F8FC File Offset: 0x0006DAFC
		[Token(Token = "0x6011F26")]
		[Address(RVA = "0x9DD4A0", Offset = "0x9DC8A0", VA = "0x1809DD4A0", Slot = "92")]
		public virtual ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304 \u0307\u0304\u0305\u0305\u0302\u0307\u0304\u0302\u0308\u0304\u0305\u0304\u0302\u0306\u0305()
		{
			return ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304.None;
		}

		// Token: 0x06011F27 RID: 73511 RVA: 0x0006F914 File Offset: 0x0006DB14
		[Token(Token = "0x6011F27")]
		[Address(RVA = "0x2F9BF40", Offset = "0x2F9B340", VA = "0x182F9BF40", Slot = "93")]
		public int \u0303\u0306\u0307\u0306\u0302\u0304\u0306\u0301\u0301\u0308\u0306\u0304\u0304\u0305\u0307(AWeapon \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return 0;
		}

		// Token: 0x06011F28 RID: 73512 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F28")]
		[Address(RVA = "0x319D5A0", Offset = "0x319C9A0", VA = "0x18319D5A0")]
		public Mesh \u0307\u0301\u0302\u0301\u0302\u0304\u0303\u0308\u0302\u0302\u0305\u0305\u0307\u0302\u0304(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F29 RID: 73513 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F29")]
		[Address(RVA = "0x3198390", Offset = "0x3197790", VA = "0x183198390")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0301\u0308\u0304\u0301\u0308\u0308\u0307\u0308\u0304\u0303\u0306\u0308\u0304\u0305\u0304()
		{
			return null;
		}

		// Token: 0x06011F2A RID: 73514 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F2A")]
		[Address(RVA = "0x319C4C0", Offset = "0x319B8C0", VA = "0x18319C4C0")]
		public AWeaponSkin \u0306\u0307\u0304\u0301\u0304\u0303\u0306\u0305\u0303\u0303\u0302\u0304\u0304\u0304\u0303(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06011F2B RID: 73515 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x170009A0")]
		public Avaibility Avaibility
		{
			[Token(Token = "0x6011F2B")]
			[Address(RVA = "0xAEB3E0", Offset = "0xAEA7E0", VA = "0x180AEB3E0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011F2C RID: 73516 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F2C")]
		[Address(RVA = "0x3198DF0", Offset = "0x31981F0", VA = "0x183198DF0")]
		public Mesh \u0303\u0302\u0308\u0302\u0301\u0308\u0304\u0305\u0304\u0307\u0308\u0308\u0302\u0301\u0303(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F2D RID: 73517 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F2D")]
		[Address(RVA = "0x319D640", Offset = "0x319CA40", VA = "0x18319D640", Slot = "94")]
		public virtual string \u0307\u0301\u0306\u0306\u0301\u0306\u0305\u0301\u0301\u0305\u0305\u0306\u0308\u0305\u0301()
		{
			return null;
		}

		// Token: 0x06011F2E RID: 73518 RVA: 0x0006F92C File Offset: 0x0006DB2C
		[Token(Token = "0x6011F2E")]
		[Address(RVA = "0x319A6D0", Offset = "0x3199AD0", VA = "0x18319A6D0", Slot = "95")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 \u0308\u0304\u0305\u0304\u0308\u0302\u0306\u0302\u0301\u0307\u0308\u0301\u0302\u0302\u0302()
		{
			return \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302.Primary;
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06011F2F RID: 73519 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x170009A6")]
		public static AWeapon EmptyGun
		{
			[Token(Token = "0x6011F2F")]
			[Address(RVA = "0x319F700", Offset = "0x319EB00", VA = "0x18319F700")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011F30 RID: 73520 RVA: 0x0006F944 File Offset: 0x0006DB44
		[Token(Token = "0x6011F30")]
		[Address(RVA = "0x3198E90", Offset = "0x3198290", VA = "0x183198E90")]
		public uint \u0303\u0303\u0308\u0303\u0305\u0305\u0303\u0302\u0301\u0308\u0308\u0302\u0308\u0305\u0306()
		{
			return 0U;
		}

		// Token: 0x06011F31 RID: 73521 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F31")]
		[Address(RVA = "0x319D510", Offset = "0x319C910", VA = "0x18319D510")]
		public AWeaponSkin \u0306\u0308\u0306\u0308\u0308\u0307\u0307\u0301\u0304\u0302\u0307\u0305\u0307\u0306\u0305(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011F32 RID: 73522 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F32")]
		[Address(RVA = "0x1AFEAF0", Offset = "0x1AFDEF0", VA = "0x181AFEAF0", Slot = "96")]
		private string \u0304\u0303\u0305\u0304\u0304\u0302\u0301\u0304\u0308\u0307\u0304\u0302\u0307\u0304\u0306()
		{
			return null;
		}

		// Token: 0x06011F33 RID: 73523 RVA: 0x0006F95C File Offset: 0x0006DB5C
		[Token(Token = "0x6011F33")]
		[Address(RVA = "0x319DA20", Offset = "0x319CE20", VA = "0x18319DA20")]
		public uint \u0307\u0304\u0307\u0302\u0304\u0305\u0306\u0306\u0307\u0301\u0307\u0305\u0304\u0301\u0303()
		{
			return 0U;
		}

		// Token: 0x06011F34 RID: 73524 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F34")]
		[Address(RVA = "0x319BC20", Offset = "0x319B020", VA = "0x18319BC20")]
		public AWeaponSkin \u0305\u0303\u0308\u0307\u0302\u0301\u0306\u0302\u0306\u0305\u0308\u0305\u0301\u0302\u0308(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011F35 RID: 73525 RVA: 0x0006F974 File Offset: 0x0006DB74
		[Token(Token = "0x6011F35")]
		[Address(RVA = "0x8BAAE0", Offset = "0x8B9EE0", VA = "0x1808BAAE0", Slot = "97")]
		public virtual ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304 \u0308\u0308\u0305\u0308\u0305\u0307\u0304\u0302\u0306\u0308\u0306\u0306\u0306\u0302\u0308()
		{
			return ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304.None;
		}

		// Token: 0x06011F36 RID: 73526 RVA: 0x0006F98C File Offset: 0x0006DB8C
		[Token(Token = "0x6011F36")]
		[Address(RVA = "0x3198C30", Offset = "0x3198030", VA = "0x183198C30", Slot = "98")]
		public virtual bool \u0303\u0301\u0303\u0304\u0303\u0303\u0308\u0304\u0304\u0305\u0304\u0304\u0303\u0303\u0304(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 \u0304\u0307\u0306\u0307\u0306\u0306\u0306\u0301\u0308\u0301\u0303\u0304\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x06011F37 RID: 73527 RVA: 0x0006F9A4 File Offset: 0x0006DBA4
		[Token(Token = "0x6011F37")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "99")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0305\u0303\u0301\u0307\u0302\u0306\u0307\u0307\u0308\u0307\u0304\u0302\u0306\u0307\u0305()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F38 RID: 73528 RVA: 0x0006F9BC File Offset: 0x0006DBBC
		[Token(Token = "0x6011F38")]
		[Address(RVA = "0x2F9BF40", Offset = "0x2F9B340", VA = "0x182F9BF40", Slot = "100")]
		public int \u0307\u0304\u0303\u0307\u0308\u0304\u0301\u0307\u0308\u0304\u0304\u0302\u0307\u0305\u0303(AWeapon \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return 0;
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06011F67 RID: 73575 RVA: 0x0006FBB4 File Offset: 0x0006DDB4
		// (set) Token: 0x06011F39 RID: 73529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009A5")]
		public uint LongestKill
		{
			[Token(Token = "0x6011F67")]
			[Address(RVA = "0x319F7F0", Offset = "0x319EBF0", VA = "0x18319F7F0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6011F39")]
			[Address(RVA = "0x319FAC0", Offset = "0x319EEC0", VA = "0x18319FAC0")]
			set
			{
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06011F3A RID: 73530 RVA: 0x0006F9D4 File Offset: 0x0006DBD4
		// (set) Token: 0x06011F4E RID: 73550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009A4")]
		public uint Kills
		{
			[Token(Token = "0x6011F3A")]
			[Address(RVA = "0x319F720", Offset = "0x319EB20", VA = "0x18319F720")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6011F4E")]
			[Address(RVA = "0x319F9E0", Offset = "0x319EDE0", VA = "0x18319F9E0")]
			set
			{
			}
		}

		// Token: 0x06011F3B RID: 73531 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F3B")]
		[Address(RVA = "0x319A610", Offset = "0x3199A10", VA = "0x18319A610", Slot = "101")]
		public virtual string \u0304\u0304\u0302\u0308\u0307\u0304\u0308\u0308\u0308\u0303\u0308\u0305\u0304\u0301\u0308()
		{
			return null;
		}

		// Token: 0x06011F3C RID: 73532 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F3C")]
		[Address(RVA = "0x900D10", Offset = "0x900110", VA = "0x180900D10", Slot = "102")]
		public GameObject \u0301\u0304\u0308\u0301\u0308\u0303\u0302\u0305\u0305\u0304\u0303\u0302\u0305\u0303\u0306()
		{
			return null;
		}

		// Token: 0x06011F3D RID: 73533 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F3D")]
		[Address(RVA = "0x900D10", Offset = "0x900110", VA = "0x180900D10", Slot = "103")]
		public GameObject \u0302\u0304\u0304\u0304\u0304\u0305\u0306\u0301\u0308\u0305\u0301\u0301\u0304\u0306\u0302()
		{
			return null;
		}

		// Token: 0x06011F3E RID: 73534 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F3E")]
		[Address(RVA = "0x319A570", Offset = "0x3199970", VA = "0x18319A570")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0304\u0304\u0302\u0305\u0304\u0302\u0302\u0302\u0302\u0307\u0301\u0302\u0304\u0304\u0304(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011F3F RID: 73535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F3F")]
		[Address(RVA = "0x3197170", Offset = "0x3196570", VA = "0x183197170")]
		public void \u0301\u0302\u0306\u0301\u0305\u0307\u0307\u0302\u0308\u0304\u0305\u0304\u0308\u0302\u0307(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011F40 RID: 73536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F40")]
		[Address(RVA = "0x319DD40", Offset = "0x319D140", VA = "0x18319DD40")]
		public void \u0308\u0302\u0304\u0301\u0306\u0304\u0304\u0305\u0304\u0308\u0305\u0301\u0302\u0306\u0307(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011F41 RID: 73537 RVA: 0x0006F9EC File Offset: 0x0006DBEC
		[Token(Token = "0x6011F41")]
		[Address(RVA = "0x1E05310", Offset = "0x1E04710", VA = "0x181E05310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06011F42 RID: 73538 RVA: 0x0006FA04 File Offset: 0x0006DC04
		[Token(Token = "0x6011F42")]
		[Address(RVA = "0xCBCD50", Offset = "0xCBC150", VA = "0x180CBCD50")]
		public \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304 \u0306\u0305\u0306\u0301\u0301\u0304\u0307\u0301\u0307\u0304\u0305\u0308\u0303\u0303\u0306()
		{
			return \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304.Rifle;
		}

		// Token: 0x06011F43 RID: 73539 RVA: 0x0006FA1C File Offset: 0x0006DC1C
		[Token(Token = "0x6011F43")]
		[Address(RVA = "0x319E240", Offset = "0x319D640", VA = "0x18319E240", Slot = "104")]
		public virtual bool \u0308\u0306\u0301\u0307\u0306\u0305\u0308\u0303\u0302\u0302\u0307\u0307\u0307\u0304\u0306(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 \u0304\u0307\u0306\u0307\u0306\u0306\u0306\u0301\u0308\u0301\u0303\u0304\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x06011F44 RID: 73540 RVA: 0x0006FA34 File Offset: 0x0006DC34
		[Token(Token = "0x6011F44")]
		[Address(RVA = "0x319DE20", Offset = "0x319D220", VA = "0x18319DE20")]
		public uint \u0308\u0302\u0304\u0307\u0306\u0303\u0305\u0305\u0301\u0304\u0304\u0308\u0305\u0305\u0302()
		{
			return 0U;
		}

		// Token: 0x06011F45 RID: 73541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F45")]
		[Address(RVA = "0x3197410", Offset = "0x3196810", VA = "0x183197410")]
		public void \u0301\u0307\u0302\u0304\u0302\u0306\u0305\u0305\u0301\u0304\u0304\u0306\u0304\u0308\u0306(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011F46 RID: 73542 RVA: 0x0006FA4C File Offset: 0x0006DC4C
		[Token(Token = "0x6011F46")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "105")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0301\u0305\u0305\u0302\u0308\u0304\u0305\u0301\u0305\u0305\u0304\u0302\u0303\u0307\u0301()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F47 RID: 73543 RVA: 0x0006FA64 File Offset: 0x0006DC64
		[Token(Token = "0x6011F47")]
		[Address(RVA = "0x2F9BF40", Offset = "0x2F9B340", VA = "0x182F9BF40", Slot = "106")]
		public int \u0301\u0301\u0308\u0308\u0304\u0301\u0305\u0306\u0303\u0301\u0303\u0308\u0301\u0305\u0305(AWeapon \u0301\u0304\u0302\u0308\u0301\u0304\u0304\u0303\u0308\u0301\u0302\u0308\u0306\u0304\u0305)
		{
			return 0;
		}

		// Token: 0x06011F48 RID: 73544 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F48")]
		[Address(RVA = "0x319BAE0", Offset = "0x319AEE0", VA = "0x18319BAE0")]
		public GameObject \u0305\u0302\u0307\u0303\u0306\u0305\u0302\u0308\u0307\u0301\u0301\u0304\u0305\u0303\u0301(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F49 RID: 73545 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F49")]
		[Address(RVA = "0x319F4A0", Offset = "0x319E8A0", VA = "0x18319F4A0")]
		public Mesh \u0308\u0307\u0308\u0304\u0302\u0306\u0306\u0307\u0303\u0308\u0302\u0302\u0302\u0304\u0301(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F4A RID: 73546 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F4A")]
		[Address(RVA = "0x3198600", Offset = "0x3197A00", VA = "0x183198600", Slot = "23")]
		public override string \u0302\u0303\u0304\u0307\u0303\u0306\u0306\u0306\u0303\u0308\u0304\u0303\u0305\u0301\u0306()
		{
			return null;
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06011F4B RID: 73547 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x1700099A")]
		public GameObject LocalPrefab
		{
			[Token(Token = "0x6011F4B")]
			[Address(RVA = "0x900D10", Offset = "0x900110", VA = "0x180900D10", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011F4C RID: 73548 RVA: 0x0006FA7C File Offset: 0x0006DC7C
		[Token(Token = "0x6011F4C")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "107")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0304\u0306\u0308\u0306\u0303\u0308\u0301\u0306\u0306\u0303\u0302\u0305\u0304\u0305\u0305()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F4D RID: 73549 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F4D")]
		[Address(RVA = "0x3197370", Offset = "0x3196770", VA = "0x183197370")]
		public Mesh \u0301\u0305\u0304\u0307\u0301\u0304\u0302\u0305\u0304\u0304\u0308\u0302\u0306\u0305\u0308(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F4F RID: 73551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F4F")]
		[Address(RVA = "0x319C620", Offset = "0x319BA20", VA = "0x18319C620")]
		public void \u0306\u0307\u0307\u0308\u0308\u0306\u0306\u0301\u0307\u0305\u0303\u0302\u0301\u0305\u0306(uint \u0302\u0304\u0307\u0301\u0308\u0304\u0303\u0307\u0303\u0303\u0303\u0304\u0304\u0303\u0303)
		{
		}

		// Token: 0x06011F50 RID: 73552 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F50")]
		[Address(RVA = "0x319C170", Offset = "0x319B570", VA = "0x18319C170")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0306\u0302\u0302\u0307\u0305\u0304\u0303\u0305\u0302\u0307\u0306\u0304\u0306\u0308\u0302()
		{
			return null;
		}

		// Token: 0x06011F51 RID: 73553 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F51")]
		[Address(RVA = "0x319B7B0", Offset = "0x319ABB0", VA = "0x18319B7B0")]
		public AWeaponSkin \u0304\u0307\u0305\u0303\u0304\u0302\u0304\u0306\u0306\u0307\u0305\u0308\u0307\u0301\u0302(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011F52 RID: 73554 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F52")]
		[Address(RVA = "0x3198A40", Offset = "0x3197E40", VA = "0x183198A40")]
		public static AWeapon \u0302\u0306\u0307\u0306\u0302\u0305\u0308\u0304\u0303\u0307\u0308\u0307\u0308\u0305\u0303(ushort \u0307\u0303\u0301\u0304\u0305\u0302\u0301\u0308\u0306\u0307\u0305\u0305\u0305\u0305\u0303)
		{
			return null;
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06011F53 RID: 73555 RVA: 0x0006FA94 File Offset: 0x0006DC94
		[Token(Token = "0x170009A1")]
		public bool isUnlocked
		{
			[Token(Token = "0x6011F53")]
			[Address(RVA = "0x319F8C0", Offset = "0x319ECC0", VA = "0x18319F8C0", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011F54 RID: 73556 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F54")]
		[Address(RVA = "0x3199220", Offset = "0x3198620", VA = "0x183199220")]
		public \u0307\u0305\u0303\u0301\u0302\u0303\u0304\u0307\u0307\u0302\u0308\u0301\u0303\u0308\u0307.\u0306\u0306\u0308\u0302\u0307\u0306\u0305\u0303\u0302\u0301\u0304\u0308\u0304\u0304\u0308[] \u0303\u0307\u0302\u0306\u0302\u0305\u0302\u0305\u0303\u0307\u0304\u0307\u0308\u0301\u0302(int \u0308\u0304\u0301\u0303\u0308\u0303\u0307\u0302\u0304\u0304\u0306\u0307\u0301\u0306\u0307 = 0, int \u0301\u0306\u0305\u0306\u0305\u0306\u0304\u0308\u0301\u0308\u0306\u0305\u0303\u0301\u0303 = 0)
		{
			return null;
		}

		// Token: 0x06011F55 RID: 73557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F55")]
		[Address(RVA = "0x319A6E0", Offset = "0x3199AE0", VA = "0x18319A6E0")]
		public void \u0304\u0306\u0303\u0308\u0301\u0304\u0302\u0307\u0301\u0304\u0301\u0307\u0302\u0307\u0306(uint \u0302\u0304\u0307\u0301\u0308\u0304\u0303\u0307\u0303\u0303\u0303\u0304\u0304\u0303\u0303)
		{
		}

		// Token: 0x06011F56 RID: 73558 RVA: 0x0006FAAC File Offset: 0x0006DCAC
		[Token(Token = "0x6011F56")]
		[Address(RVA = "0x319BFA0", Offset = "0x319B3A0", VA = "0x18319BFA0", Slot = "12")]
		public override bool \u0305\u0308\u0301\u0306\u0305\u0307\u0303\u0306\u0302\u0307\u0301\u0307\u0307\u0306\u0305(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 \u0304\u0307\u0306\u0307\u0306\u0306\u0306\u0301\u0308\u0301\u0303\u0304\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x06011F57 RID: 73559 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F57")]
		[Address(RVA = "0x319C400", Offset = "0x319B800", VA = "0x18319C400", Slot = "108")]
		public virtual string \u0306\u0307\u0301\u0303\u0308\u0303\u0301\u0307\u0301\u0308\u0308\u0304\u0307\u0305\u0301()
		{
			return null;
		}

		// Token: 0x06011F58 RID: 73560 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F58")]
		[Address(RVA = "0xAEB3E0", Offset = "0xAEA7E0", VA = "0x180AEB3E0", Slot = "109")]
		public Avaibility \u0305\u0304\u0306\u0305\u0302\u0303\u0303\u0303\u0301\u0304\u0304\u0301\u0304\u0305\u0301()
		{
			return null;
		}

		// Token: 0x06011F59 RID: 73561 RVA: 0x0006FAC4 File Offset: 0x0006DCC4
		[Token(Token = "0x6011F59")]
		[Address(RVA = "0x31984E0", Offset = "0x31978E0", VA = "0x1831984E0", Slot = "110")]
		public bool \u0302\u0302\u0308\u0308\u0305\u0302\u0303\u0303\u0306\u0301\u0308\u0304\u0303\u0306\u0305()
		{
			return default(bool);
		}

		// Token: 0x06011F5A RID: 73562 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F5A")]
		[Address(RVA = "0x3198F60", Offset = "0x3198360", VA = "0x183198F60")]
		public Mesh \u0303\u0304\u0303\u0301\u0304\u0303\u0308\u0307\u0301\u0303\u0308\u0308\u0307\u0305\u0308(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307)
		{
			return null;
		}

		// Token: 0x06011F5B RID: 73563 RVA: 0x0006FADC File Offset: 0x0006DCDC
		[Token(Token = "0x6011F5B")]
		[Address(RVA = "0xCBCD50", Offset = "0xCBC150", VA = "0x180CBCD50")]
		public \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304 \u0306\u0306\u0304\u0304\u0302\u0308\u0306\u0302\u0301\u0307\u0305\u0308\u0303\u0307\u0304()
		{
			return \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304.Rifle;
		}

		// Token: 0x06011F5C RID: 73564 RVA: 0x0006FAF4 File Offset: 0x0006DCF4
		[Token(Token = "0x6011F5C")]
		[Address(RVA = "0x319A6D0", Offset = "0x3199AD0", VA = "0x18319A6D0", Slot = "111")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 \u0304\u0304\u0303\u0303\u0302\u0307\u0304\u0306\u0308\u0308\u0304\u0303\u0305\u0304\u0304()
		{
			return \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302.Primary;
		}

		// Token: 0x06011F5D RID: 73565 RVA: 0x0006FB0C File Offset: 0x0006DD0C
		[Token(Token = "0x6011F5D")]
		[Address(RVA = "0x1E05310", Offset = "0x1E04710", VA = "0x181E05310", Slot = "112")]
		public virtual int \u0301\u0304\u0304\u0304\u0301\u0303\u0308\u0307\u0306\u0308\u0302\u0302\u0304\u0303\u0302()
		{
			return 0;
		}

		// Token: 0x06011F5E RID: 73566 RVA: 0x0006FB24 File Offset: 0x0006DD24
		[Token(Token = "0x6011F5E")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "113")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0305\u0306\u0306\u0305\u0302\u0304\u0302\u0308\u0305\u0302\u0302\u0308\u0301\u0301\u0308()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F5F RID: 73567 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F5F")]
		[Address(RVA = "0xA3E370", Offset = "0xA3D770", VA = "0x180A3E370", Slot = "114")]
		public ToolItem \u0301\u0308\u0308\u0306\u0302\u0306\u0303\u0308\u0301\u0304\u0307\u0305\u0303\u0301\u0305()
		{
			return null;
		}

		// Token: 0x06011F60 RID: 73568 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F60")]
		[Address(RVA = "0x319C0A0", Offset = "0x319B4A0", VA = "0x18319C0A0")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0306\u0302\u0301\u0302\u0305\u0306\u0305\u0306\u0304\u0306\u0301\u0307\u0302\u0307\u0308()
		{
			return null;
		}

		// Token: 0x06011F61 RID: 73569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F61")]
		[Address(RVA = "0x319A190", Offset = "0x3199590", VA = "0x18319A190")]
		public void \u0304\u0301\u0302\u0302\u0306\u0304\u0303\u0305\u0305\u0307\u0307\u0303\u0304\u0302\u0304(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06011F62 RID: 73570 RVA: 0x0006FB3C File Offset: 0x0006DD3C
		[Token(Token = "0x1700099E")]
		public \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304 getWeaponType
		{
			[Token(Token = "0x6011F62")]
			[Address(RVA = "0xCBCD50", Offset = "0xCBC150", VA = "0x180CBCD50")]
			get
			{
				return \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304.Rifle;
			}
		}

		// Token: 0x06011F63 RID: 73571 RVA: 0x0006FB54 File Offset: 0x0006DD54
		[Token(Token = "0x6011F63")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "115")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0302\u0305\u0301\u0308\u0304\u0302\u0305\u0308\u0308\u0303\u0303\u0304\u0306\u0301\u0302()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x06011F64 RID: 73572 RVA: 0x0006FB6C File Offset: 0x0006DD6C
		[Token(Token = "0x6011F64")]
		[Address(RVA = "0x3198A20", Offset = "0x3197E20", VA = "0x183198A20", Slot = "116")]
		public float \u0308\u0307\u0307\u0302\u0301\u0308\u0304\u0304\u0303\u0308\u0301\u0302\u0302\u0302\u0304()
		{
			return 0f;
		}

		// Token: 0x06011F65 RID: 73573 RVA: 0x0006FB84 File Offset: 0x0006DD84
		[Token(Token = "0x6011F65")]
		[Address(RVA = "0x9DD4A0", Offset = "0x9DC8A0", VA = "0x1809DD4A0", Slot = "117")]
		public virtual ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304 \u0303\u0303\u0302\u0303\u0305\u0306\u0301\u0302\u0302\u0305\u0306\u0305\u0302\u0301\u0304()
		{
			return ToolItem.\u0303\u0308\u0301\u0303\u0305\u0304\u0307\u0303\u0302\u0301\u0301\u0302\u0307\u0307\u0304.None;
		}

		// Token: 0x06011F66 RID: 73574 RVA: 0x0006FB9C File Offset: 0x0006DD9C
		[Token(Token = "0x6011F66")]
		[Address(RVA = "0x319C240", Offset = "0x319B640", VA = "0x18319C240", Slot = "118")]
		public virtual bool \u0306\u0304\u0301\u0307\u0305\u0301\u0306\u0301\u0301\u0302\u0304\u0308\u0305\u0301\u0301(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0302\u0302\u0306\u0302\u0305\u0304\u0304\u0308\u0308\u0303\u0304\u0308\u0307\u0308\u0308, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 \u0304\u0307\u0306\u0307\u0306\u0306\u0306\u0301\u0308\u0301\u0303\u0304\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x06011F68 RID: 73576 RVA: 0x0006FBCC File Offset: 0x0006DDCC
		[Token(Token = "0x6011F68")]
		[Address(RVA = "0xCBCD50", Offset = "0xCBC150", VA = "0x180CBCD50")]
		public \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304 \u0306\u0303\u0303\u0304\u0308\u0306\u0302\u0308\u0303\u0305\u0308\u0306\u0305\u0305\u0304()
		{
			return \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304.Rifle;
		}

		// Token: 0x06011F69 RID: 73577 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F69")]
		[Address(RVA = "0x319A4A0", Offset = "0x31998A0", VA = "0x18319A4A0")]
		public AWeaponMag \u0304\u0302\u0307\u0308\u0308\u0301\u0304\u0301\u0302\u0307\u0302\u0304\u0305\u0306\u0303(int \u0308\u0303\u0302\u0304\u0301\u0302\u0301\u0307\u0305\u0303\u0305\u0303\u0305\u0303\u0307, bool \u0301\u0304\u0307\u0307\u0304\u0302\u0302\u0302\u0304\u0308\u0303\u0305\u0307\u0305\u0301 = false)
		{
			return null;
		}

		// Token: 0x06011F6A RID: 73578 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F6A")]
		[Address(RVA = "0x3198710", Offset = "0x3197B10", VA = "0x183198710")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 \u0302\u0304\u0305\u0308\u0303\u0307\u0305\u0308\u0308\u0303\u0301\u0308\u0303\u0301\u0307()
		{
			return null;
		}

		// Token: 0x06011F6B RID: 73579 RVA: 0x0006FBE4 File Offset: 0x0006DDE4
		[Token(Token = "0x6011F6B")]
		[Address(RVA = "0x3198A20", Offset = "0x3197E20", VA = "0x183198A20", Slot = "119")]
		public float \u0302\u0306\u0307\u0302\u0304\u0308\u0304\u0301\u0301\u0302\u0306\u0306\u0307\u0306\u0306()
		{
			return 0f;
		}

		// Token: 0x06011F6C RID: 73580 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F6C")]
		[Address(RVA = "0xA3E370", Offset = "0xA3D770", VA = "0x180A3E370", Slot = "120")]
		public ToolItem \u0301\u0301\u0304\u0302\u0302\u0302\u0307\u0303\u0305\u0301\u0303\u0302\u0308\u0305\u0307()
		{
			return null;
		}

		// Token: 0x06011F6D RID: 73581 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F6D")]
		[Address(RVA = "0x1AFEAF0", Offset = "0x1AFDEF0", VA = "0x181AFEAF0", Slot = "121")]
		private string \u0302\u0301\u0306\u0305\u0307\u0307\u0308\u0303\u0304\u0301\u0305\u0306\u0308\u0301\u0306()
		{
			return null;
		}

		// Token: 0x06011F6E RID: 73582 RVA: 0x0006FBFC File Offset: 0x0006DDFC
		[Token(Token = "0x6011F6E")]
		[Address(RVA = "0x2F9BF70", Offset = "0x2F9B370", VA = "0x182F9BF70", Slot = "122")]
		public bool \u0303\u0304\u0305\u0302\u0304\u0301\u0302\u0304\u0302\u0308\u0306\u0308\u0303\u0304\u0301(AWeapon \u0305\u0302\u0307\u0301\u0306\u0307\u0305\u0302\u0301\u0301\u0307\u0304\u0306\u0308\u0308, AWeapon \u0302\u0302\u0301\u0305\u0303\u0301\u0304\u0307\u0303\u0303\u0302\u0303\u0307\u0304\u0308)
		{
			return default(bool);
		}

		// Token: 0x06011F6F RID: 73583 RVA: 0x0006FC14 File Offset: 0x0006DE14
		[Token(Token = "0x6011F6F")]
		[Address(RVA = "0x319B690", Offset = "0x319AA90", VA = "0x18319B690", Slot = "123")]
		public bool \u0304\u0307\u0303\u0304\u0305\u0302\u0302\u0303\u0301\u0302\u0302\u0308\u0305\u0306\u0308()
		{
			return default(bool);
		}

		// Token: 0x06011F70 RID: 73584 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F70")]
		[Address(RVA = "0x319BEE0", Offset = "0x319B2E0", VA = "0x18319BEE0", Slot = "124")]
		public virtual string \u0305\u0305\u0303\u0303\u0301\u0307\u0303\u0302\u0302\u0302\u0305\u0302\u0305\u0302\u0301()
		{
			return null;
		}

		// Token: 0x06011F71 RID: 73585 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6011F71")]
		[Address(RVA = "0x31987E0", Offset = "0x3197BE0", VA = "0x1831987E0", Slot = "125")]
		public virtual string \u0302\u0304\u0307\u0307\u0303\u0307\u0306\u0308\u0308\u0305\u0307\u0308\u0304\u0308\u0307()
		{
			return null;
		}

		// Token: 0x06011F72 RID: 73586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F72")]
		[Address(RVA = "0x319D940", Offset = "0x319CD40", VA = "0x18319D940")]
		public void \u0307\u0304\u0306\u0303\u0303\u0308\u0306\u0302\u0303\u0307\u0303\u0308\u0305\u0302\u0307(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011F73 RID: 73587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6011F73")]
		[Address(RVA = "0x319A340", Offset = "0x3199740", VA = "0x18319A340")]
		public void \u0304\u0301\u0308\u0308\u0306\u0308\u0303\u0305\u0307\u0308\u0302\u0308\u0304\u0301\u0304(uint \u0308\u0302\u0308\u0307\u0305\u0302\u0307\u0303\u0307\u0301\u0302\u0308\u0303\u0301\u0305)
		{
		}

		// Token: 0x06011F74 RID: 73588 RVA: 0x0006FC2C File Offset: 0x0006DE2C
		[Token(Token = "0x6011F74")]
		[Address(RVA = "0x2F9BF70", Offset = "0x2F9B370", VA = "0x182F9BF70", Slot = "126")]
		public bool \u0306\u0301\u0306\u0308\u0305\u0308\u0301\u0305\u0308\u0306\u0307\u0303\u0304\u0306\u0303(AWeapon \u0305\u0302\u0307\u0301\u0306\u0307\u0305\u0302\u0301\u0301\u0307\u0304\u0306\u0308\u0308, AWeapon \u0302\u0302\u0301\u0305\u0303\u0301\u0304\u0307\u0303\u0303\u0302\u0303\u0307\u0304\u0308)
		{
			return default(bool);
		}

		// Token: 0x06011F75 RID: 73589 RVA: 0x0006FC44 File Offset: 0x0006DE44
		[Token(Token = "0x6011F75")]
		[Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450", Slot = "127")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 \u0304\u0307\u0305\u0301\u0305\u0304\u0304\u0308\u0303\u0308\u0305\u0308\u0306\u0303\u0302()
		{
			return \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306.Russian;
		}

		// Token: 0x040030FE RID: 12542
		[Token(Token = "0x40030FE")]
		[FieldOffset(Offset = "0x78")]
		public AWeaponAllowedAttachment AllowedAttachments;

		// Token: 0x040030FF RID: 12543
		[Token(Token = "0x40030FF")]
		[FieldOffset(Offset = "0x80")]
		public Avaibility Permissions;

		// Token: 0x04003100 RID: 12544
		[Token(Token = "0x4003100")]
		[FieldOffset(Offset = "0x88")]
		public AWeaponSounds Sounds;

		// Token: 0x04003101 RID: 12545
		[Token(Token = "0x4003101")]
		[FieldOffset(Offset = "0x90")]
		public WeaponStats Stats;

		// Token: 0x04003102 RID: 12546
		[Token(Token = "0x4003102")]
		[FieldOffset(Offset = "0x98")]
		public \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 BelongNation;

		// Token: 0x04003103 RID: 12547
		[Token(Token = "0x4003103")]
		[FieldOffset(Offset = "0x99")]
		public \u0301\u0306\u0306\u0303\u0305\u0303\u0301\u0307\u0306\u0301\u0305\u0307\u0304\u0304\u0302 LoadoutIndex;

		// Token: 0x04003104 RID: 12548
		[Token(Token = "0x4003104")]
		[FieldOffset(Offset = "0x9C")]
		public \u0308\u0304\u0307\u0305\u0302\u0303\u0306\u0306\u0308\u0301\u0307\u0308\u0305\u0308\u0304 WeaponType;

		// Token: 0x04003105 RID: 12549
		[Token(Token = "0x4003105")]
		[FieldOffset(Offset = "0xA0")]
		public WeaponAssetAnimations Animations;

		// Token: 0x04003106 RID: 12550
		[Token(Token = "0x4003106")]
		[FieldOffset(Offset = "0xA8")]
		public List<AWeaponSkin> Skins;

		// Token: 0x04003107 RID: 12551
		[Token(Token = "0x4003107")]
		[FieldOffset(Offset = "0xB0")]
		public List<AWeaponMag> Magazines;

		// Token: 0x04003108 RID: 12552
		[Token(Token = "0x4003108")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject LocalPrefabAsset;

		// Token: 0x04003109 RID: 12553
		[Token(Token = "0x4003109")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject DefaultMagazineVisual;

		// Token: 0x0400310A RID: 12554
		[Token(Token = "0x400310A")]
		[FieldOffset(Offset = "0xC8")]
		public int MagazineAtStartup;

		// Token: 0x0400310B RID: 12555
		[Token(Token = "0x400310B")]
		[FieldOffset(Offset = "0xCC")]
		public int DefaultRoundsPerMagazine;

		// Token: 0x0400310C RID: 12556
		[Token(Token = "0x400310C")]
		[FieldOffset(Offset = "0xD0")]
		public int DefaultMagazineSupplyCost;

		// Token: 0x0400310D RID: 12557
		[Token(Token = "0x400310D")]
		[FieldOffset(Offset = "0xD8")]
		private string mCacheName;

		// Token: 0x0400310E RID: 12558
		[Token(Token = "0x400310E")]
		[FieldOffset(Offset = "0xE0")]
		private bool mCacheSet;
	}
}
