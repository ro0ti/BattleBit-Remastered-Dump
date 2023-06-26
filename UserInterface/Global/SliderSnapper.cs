using System;
using touching_your_mom;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.Global
{
	// Token: 0x020007CF RID: 1999
	[Token(Token = "0x20007CF")]
	public class SliderSnapper : MonoBehaviour, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06013DD8 RID: 81368 RVA: 0x0007DAA4 File Offset: 0x0007BCA4
		// (set) Token: 0x06013DD9 RID: 81369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE1")]
		public int TickIndex8
		{
			[Token(Token = "0x6013DD8")]
			[Address(RVA = "0xA69700", Offset = "0xA68B00", VA = "0x180A69700", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013DD9")]
			[Address(RVA = "0xA84660", Offset = "0xA83A60", VA = "0x180A84660", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06013DDA RID: 81370 RVA: 0x0007DABC File Offset: 0x0007BCBC
		// (set) Token: 0x06013DDB RID: 81371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE2")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013DDA")]
			[Address(RVA = "0x99D720", Offset = "0x99CB20", VA = "0x18099D720", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013DDB")]
			[Address(RVA = "0xABF360", Offset = "0xABE760", VA = "0x180ABF360", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013DDC RID: 81372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DDC")]
		[Address(RVA = "0x1944AA0", Offset = "0x1943EA0", VA = "0x181944AA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013DDD RID: 81373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DDD")]
		[Address(RVA = "0x1944A40", Offset = "0x1943E40", VA = "0x181944A40")]
		private void OnDisable()
		{
		}

		// Token: 0x06013DDE RID: 81374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DDE")]
		[Address(RVA = "0x1944B00", Offset = "0x1943F00", VA = "0x181944B00", Slot = "8")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013DDF RID: 81375 RVA: 0x0007DAD4 File Offset: 0x0007BCD4
		[Token(Token = "0x6013DDF")]
		[Address(RVA = "0x19449E0", Offset = "0x1943DE0", VA = "0x1819449E0")]
		private bool InRange(float snapValue)
		{
			return default(bool);
		}

		// Token: 0x06013DE0 RID: 81376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DE0")]
		[Address(RVA = "0x1944C60", Offset = "0x1944060", VA = "0x181944C60")]
		public SliderSnapper()
		{
		}

		// Token: 0x04003D2F RID: 15663
		[Token(Token = "0x4003D2F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x14D850", Offset = "0x14CC50")]
		public Slider Slider;

		// Token: 0x04003D30 RID: 15664
		[Token(Token = "0x4003D30")]
		[FieldOffset(Offset = "0x20")]
		public float Range;

		// Token: 0x04003D31 RID: 15665
		[Token(Token = "0x4003D31")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x157430", Offset = "0x156830")]
		public float[] SnapValues;

		// Token: 0x04003D32 RID: 15666
		[Token(Token = "0x4003D32")]
		[FieldOffset(Offset = "0x30")]
		private float latestNumber;

		// Token: 0x04003D33 RID: 15667
		[Token(Token = "0x4003D33")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003D34 RID: 15668
		[Token(Token = "0x4003D34")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
