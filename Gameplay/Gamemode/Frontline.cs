using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using touching_your_mom;
using UnityEngine;

namespace Gameplay.Gamemode
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	public class Frontline : GameplayMode
	{
		// Token: 0x06013328 RID: 78632 RVA: 0x0007943C File Offset: 0x0007763C
		[Token(Token = "0x6013328")]
		[Address(RVA = "0x25AD330", Offset = "0x25AC730", VA = "0x1825AD330", Slot = "81")]
		public override bool OnClientShowTicketsOnDeath(out int \u0308\u0304\u0307\u0303\u0305\u0305\u0303\u0301\u0305\u0301\u0305\u0301\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x06013329 RID: 78633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013329")]
		[Address(RVA = "0x25B08D0", Offset = "0x25AFCD0", VA = "0x1825B08D0", Slot = "93")]
		public virtual void \u0307\u0308\u0305\u0307\u0303\u0308\u0307\u0307\u0303\u0307\u0303\u0305\u0307\u0301\u0304(bool \u0303\u0305\u0303\u0308\u0302\u0305\u0305\u0302\u0307\u0301\u0305\u0303\u0301\u0306\u0308)
		{
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0601332A RID: 78634 RVA: 0x00079454 File Offset: 0x00077654
		[Token(Token = "0x17000B05")]
		public override \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304 \u0308\u0308\u0301\u0301\u0304\u0301\u0301\u0303\u0305\u0306\u0308\u0307\u0303\u0306\u0303
		{
			[Token(Token = "0x601332A")]
			[Address(RVA = "0x2379DF0", Offset = "0x23791F0", VA = "0x182379DF0", Slot = "41")]
			get
			{
				return \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304.Null;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0601332B RID: 78635 RVA: 0x0007946C File Offset: 0x0007766C
		// (set) Token: 0x06013373 RID: 78707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B0C")]
		public int \u0301\u0301\u0308\u0304\u0305\u0307\u0305\u0303\u0303\u0301\u0306\u0304\u0304\u0301\u0304
		{
			[Token(Token = "0x601332B")]
			[Address(RVA = "0xA67550", Offset = "0xA66950", VA = "0x180A67550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013373")]
			[Address(RVA = "0xD768A0", Offset = "0xD75CA0", VA = "0x180D768A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x0601332C RID: 78636 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x601332C")]
		[Address(RVA = "0x25B0590", Offset = "0x25AF990", VA = "0x1825B0590")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x156880", Offset = "0x155C80")]
		private IEnumerable<ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>> \u0307\u0304\u0303\u0303\u0308\u0304\u0301\u0304\u0302\u0305\u0308\u0304\u0302\u0308\u0304()
		{
			return null;
		}

		// Token: 0x0601332D RID: 78637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601332D")]
		[Address(RVA = "0x25AD3C0", Offset = "0x25AC7C0", VA = "0x1825AD3C0", Slot = "37")]
		public override void OnClientSideUpdate()
		{
		}

		// Token: 0x0601332E RID: 78638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601332E")]
		[Address(RVA = "0x25B0C80", Offset = "0x25B0080", VA = "0x1825B0C80", Slot = "94")]
		public virtual void \u0308\u0306\u0307\u0308\u0308\u0302\u0308\u0304\u0304\u0303\u0302\u0307\u0305\u0304\u0305()
		{
		}

		// Token: 0x0601332F RID: 78639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601332F")]
		[Address(RVA = "0x25B06D0", Offset = "0x25AFAD0", VA = "0x1825B06D0", Slot = "95")]
		public virtual void \u0307\u0306\u0304\u0303\u0307\u0304\u0302\u0305\u0305\u0302\u0301\u0301\u0302\u0302\u0308()
		{
		}

		// Token: 0x06013330 RID: 78640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013330")]
		[Address(RVA = "0x25AE400", Offset = "0x25AD800", VA = "0x1825AE400", Slot = "96")]
		public virtual void \u0301\u0302\u0303\u0308\u0301\u0301\u0305\u0301\u0306\u0304\u0303\u0303\u0302\u0303\u0303(bool \u0303\u0305\u0303\u0308\u0302\u0305\u0305\u0302\u0307\u0301\u0305\u0303\u0301\u0306\u0308)
		{
		}

		// Token: 0x06013331 RID: 78641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013331")]
		[Address(RVA = "0x25AF060", Offset = "0x25AE460", VA = "0x1825AF060", Slot = "97")]
		public virtual void \u0302\u0307\u0306\u0302\u0302\u0306\u0306\u0303\u0303\u0301\u0306\u0304\u0302\u0301\u0301(bool \u0303\u0305\u0303\u0308\u0302\u0305\u0305\u0302\u0307\u0301\u0305\u0303\u0301\u0306\u0308)
		{
		}

		// Token: 0x06013332 RID: 78642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013332")]
		[Address(RVA = "0x25B04A0", Offset = "0x25AF8A0", VA = "0x1825B04A0", Slot = "98")]
		public virtual void \u0306\u0305\u0302\u0305\u0306\u0307\u0304\u0302\u0308\u0308\u0301\u0301\u0301\u0306\u0304()
		{
		}

		// Token: 0x06013333 RID: 78643 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013333")]
		[Address(RVA = "0x25AE8F0", Offset = "0x25ADCF0", VA = "0x1825AE8F0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1569E0", Offset = "0x155DE0")]
		private IEnumerable<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> \u0301\u0308\u0308\u0303\u0305\u0307\u0301\u0304\u0305\u0305\u0303\u0307\u0307\u0306\u0302()
		{
			return null;
		}

		// Token: 0x06013334 RID: 78644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013334")]
		[Address(RVA = "0x1C80670", Offset = "0x1C7FA70", VA = "0x181C80670", Slot = "89")]
		public override void OnStartGameModeClientSide()
		{
		}

		// Token: 0x06013335 RID: 78645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013335")]
		[Address(RVA = "0x25B0190", Offset = "0x25AF590", VA = "0x1825B0190", Slot = "99")]
		public virtual void \u0305\u0303\u0305\u0303\u0301\u0305\u0307\u0303\u0307\u0307\u0304\u0307\u0304\u0304\u0306(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
		{
		}

		// Token: 0x06013336 RID: 78646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013336")]
		[Address(RVA = "0x25B1180", Offset = "0x25B0580", VA = "0x1825B1180")]
		[Attribute(Name = "̆̅̇̆̈̅́̃̅̃̇̈́́̅", RVA = "0x1426C0", Offset = "0x141AC0")]
		private void mReceivedNewIndex(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
		{
		}

		// Token: 0x06013337 RID: 78647 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013337")]
		[Address(RVA = "0x25B0520", Offset = "0x25AF920", VA = "0x1825B0520")]
		private IEnumerable<Flag> \u0306\u0307\u0307\u0306\u0308\u0303\u0307\u0301\u0304\u0303\u0306\u0306\u0301\u0307\u0301()
		{
			return null;
		}

		// Token: 0x06013338 RID: 78648 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013338")]
		[Address(RVA = "0x25AE7A0", Offset = "0x25ADBA0", VA = "0x1825AE7A0")]
		private IEnumerable<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> \u0301\u0306\u0304\u0306\u0305\u0303\u0308\u0308\u0302\u0308\u0302\u0302\u0305\u0304\u0305()
		{
			return null;
		}

		// Token: 0x06013339 RID: 78649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013339")]
		[Address(RVA = "0x25AFF80", Offset = "0x25AF380", VA = "0x1825AFF80")]
		private void \u0304\u0304\u0307\u0304\u0304\u0306\u0303\u0308\u0308\u0308\u0301\u0305\u0307\u0304\u0305()
		{
		}

		// Token: 0x0601333A RID: 78650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601333A")]
		[Address(RVA = "0x25AE9D0", Offset = "0x25ADDD0", VA = "0x1825AE9D0", Slot = "100")]
		public virtual void \u0302\u0302\u0306\u0307\u0302\u0302\u0303\u0304\u0305\u0302\u0306\u0308\u0307\u0303\u0306()
		{
		}

		// Token: 0x0601333B RID: 78651 RVA: 0x00079484 File Offset: 0x00077684
		[Token(Token = "0x601333B")]
		[Address(RVA = "0x25AF3B0", Offset = "0x25AE7B0", VA = "0x1825AF3B0", Slot = "101")]
		public virtual bool \u0302\u0307\u0307\u0305\u0305\u0301\u0305\u0304\u0302\u0306\u0305\u0308\u0301\u0304\u0304(out int \u0308\u0304\u0307\u0303\u0305\u0305\u0303\u0301\u0305\u0301\u0305\u0301\u0305\u0307\u0301)
		{
			return default(bool);
		}

		// Token: 0x0601333C RID: 78652 RVA: 0x0007949C File Offset: 0x0007769C
		[Token(Token = "0x601333C")]
		[Address(RVA = "0x25AD170", Offset = "0x25AC570", VA = "0x1825AD170", Slot = "25")]
		public override bool OnClientAskingToChangeTeam(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0303\u0307\u0306\u0308\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0301\u0304\u0308\u0307, out int \u0304\u0305\u0303\u0308\u0304\u0308\u0302\u0305\u0307\u0303\u0308\u0306\u0305\u0308\u0307, out float \u0308\u0304\u0301\u0307\u0301\u0301\u0306\u0304\u0301\u0302\u0307\u0302\u0306\u0305\u0305)
		{
			return default(bool);
		}

		// Token: 0x0601333D RID: 78653 RVA: 0x000794B4 File Offset: 0x000776B4
		[Token(Token = "0x601333D")]
		[Address(RVA = "0x25ACFF0", Offset = "0x25AC3F0", VA = "0x1825ACFF0", Slot = "35")]
		public override int GetTimeInSeconds()
		{
			return 0;
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0601333E RID: 78654 RVA: 0x000794CC File Offset: 0x000776CC
		[Token(Token = "0x17000B07")]
		public override bool \u0307\u0302\u0306\u0305\u0303\u0308\u0303\u0305\u0306\u0305\u0306\u0306\u0302\u0307\u0301
		{
			[Token(Token = "0x601333E")]
			[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0601333F RID: 78655 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x17000B0A")]
		public \u0301\u0302\u0307\u0307\u0302\u0303\u0302\u0308\u0304\u0304\u0306\u0302\u0303\u0303\u0306 \u0304\u0307\u0306\u0304\u0305\u0302\u0308\u0301\u0303\u0302\u0307\u0301\u0301\u0306\u0305
		{
			[Token(Token = "0x601333F")]
			[Address(RVA = "0x25B1050", Offset = "0x25B0450", VA = "0x1825B1050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06013340 RID: 78656 RVA: 0x000794E4 File Offset: 0x000776E4
		[Token(Token = "0x17000B0D")]
		public int \u0305\u0304\u0305\u0305\u0305\u0303\u0301\u0302\u0301\u0301\u0307\u0301\u0304\u0305\u0305
		{
			[Token(Token = "0x6013340")]
			[Address(RVA = "0x25B0FF0", Offset = "0x25B03F0", VA = "0x1825B0FF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06013341 RID: 78657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013341")]
		[Address(RVA = "0x1C806B0", Offset = "0x1C7FAB0", VA = "0x181C806B0", Slot = "18")]
		public override void OnStartGameModeServerSide()
		{
		}

		// Token: 0x06013342 RID: 78658 RVA: 0x000794FC File Offset: 0x000776FC
		[Token(Token = "0x6013342")]
		[Address(RVA = "0x25B0600", Offset = "0x25AFA00", VA = "0x1825B0600")]
		private bool \u0307\u0305\u0308\u0304\u0303\u0306\u0305\u0304\u0304\u0305\u0301\u0304\u0301\u0306\u0304(out \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0306\u0304\u0304\u0303\u0305\u0302\u0302\u0302\u0308\u0301\u0307\u0304\u0305\u0306\u0305)
		{
			return default(bool);
		}

		// Token: 0x06013343 RID: 78659 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013343")]
		[Address(RVA = "0x25AE730", Offset = "0x25ADB30", VA = "0x1825AE730")]
		public \u0303\u0304\u0308\u0301\u0303\u0302\u0308\u0303\u0306\u0306\u0304\u0306\u0304\u0307\u0308 \u0301\u0303\u0306\u0303\u0308\u0308\u0304\u0307\u0301\u0305\u0303\u0303\u0306\u0305\u0306()
		{
			return null;
		}

		// Token: 0x06013344 RID: 78660 RVA: 0x00079514 File Offset: 0x00077714
		[Token(Token = "0x6013344")]
		[Address(RVA = "0x2379DF0", Offset = "0x23791F0", VA = "0x182379DF0", Slot = "102")]
		public virtual \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304 \u0305\u0303\u0303\u0303\u0305\u0306\u0303\u0302\u0307\u0306\u0302\u0302\u0303\u0308\u0308()
		{
			return \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304.Null;
		}

		// Token: 0x06013345 RID: 78661 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013345")]
		[Address(RVA = "0x25B0430", Offset = "0x25AF830", VA = "0x1825B0430")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x156B90", Offset = "0x155F90")]
		private IEnumerable<Flag> \u0306\u0301\u0304\u0307\u0304\u0306\u0308\u0304\u0306\u0307\u0305\u0304\u0305\u0303\u0302()
		{
			return null;
		}

		// Token: 0x06013346 RID: 78662 RVA: 0x0007952C File Offset: 0x0007772C
		[Token(Token = "0x6013346")]
		[Address(RVA = "0x25AD2A0", Offset = "0x25AC6A0", VA = "0x1825AD2A0", Slot = "45")]
		public override bool OnClientAskingToSpawn(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0303\u0307\u0306\u0308\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0301\u0304\u0308\u0307, out Vector3 \u0303\u0308\u0308\u0308\u0305\u0304\u0308\u0305\u0308\u0302\u0301\u0306\u0307\u0308\u0301, out Vector3 \u0304\u0306\u0302\u0307\u0308\u0305\u0306\u0302\u0301\u0305\u0304\u0304\u0304\u0307\u0303, out float \u0308\u0308\u0306\u0302\u0302\u0307\u0305\u0307\u0307\u0307\u0307\u0303\u0308\u0307\u0307, out int \u0304\u0305\u0303\u0308\u0304\u0308\u0302\u0305\u0307\u0303\u0308\u0306\u0305\u0308\u0307, out float \u0308\u0304\u0301\u0307\u0301\u0301\u0306\u0304\u0301\u0302\u0307\u0302\u0306\u0305\u0305)
		{
			return default(bool);
		}

		// Token: 0x06013347 RID: 78663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013347")]
		[Address(RVA = "0xC49BC0", Offset = "0xC48FC0", VA = "0x180C49BC0", Slot = "42")]
		public override void OnClientSideTeamChanged(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0308\u0306\u0304\u0306\u0302\u0303\u0306\u0305\u0308\u0308\u0303\u0303\u0306\u0308\u0308)
		{
		}

		// Token: 0x06013348 RID: 78664 RVA: 0x00079544 File Offset: 0x00077744
		[Token(Token = "0x6013348")]
		[Address(RVA = "0x25B02C0", Offset = "0x25AF6C0", VA = "0x1825B02C0", Slot = "103")]
		public virtual \u0305\u0301\u0306\u0306\u0302\u0305\u0308\u0306\u0307\u0308\u0301\u0301\u0303\u0302\u0307 \u0305\u0305\u0304\u0308\u0306\u0305\u0304\u0305\u0306\u0306\u0306\u0308\u0308\u0301\u0307(out int \u0301\u0305\u0301\u0305\u0306\u0304\u0305\u0308\u0302\u0306\u0307\u0303\u0306\u0307\u0301, out int \u0307\u0302\u0308\u0301\u0308\u0305\u0303\u0301\u0303\u0303\u0302\u0306\u0308\u0308\u0302, out int \u0305\u0306\u0304\u0304\u0307\u0307\u0308\u0302\u0305\u0304\u0303\u0303\u0301\u0302\u0302)
		{
			return \u0305\u0301\u0306\u0306\u0302\u0305\u0308\u0306\u0307\u0308\u0301\u0301\u0303\u0302\u0307.TeamA;
		}

		// Token: 0x06013349 RID: 78665 RVA: 0x0007955C File Offset: 0x0007775C
		[Token(Token = "0x6013349")]
		[Address(RVA = "0x1C83F50", Offset = "0x1C83350", VA = "0x181C83F50", Slot = "104")]
		public virtual \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304 \u0308\u0304\u0305\u0308\u0301\u0305\u0305\u0304\u0302\u0308\u0308\u0303\u0307\u0306\u0306()
		{
			return \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304.Null;
		}

		// Token: 0x0601334A RID: 78666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601334A")]
		[Address(RVA = "0x25AED30", Offset = "0x25AE130", VA = "0x1825AED30")]
		private void \u0302\u0305\u0302\u0303\u0308\u0306\u0307\u0306\u0301\u0301\u0305\u0306\u0303\u0308\u0302()
		{
		}

		// Token: 0x0601334B RID: 78667 RVA: 0x00079574 File Offset: 0x00077774
		[Token(Token = "0x601334B")]
		[Address(RVA = "0x25AFE40", Offset = "0x25AF240", VA = "0x1825AFE40", Slot = "105")]
		public virtual int \u0304\u0301\u0302\u0304\u0306\u0308\u0302\u0304\u0301\u0302\u0305\u0306\u0305\u0304\u0306()
		{
			return 0;
		}

		// Token: 0x0601334C RID: 78668 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x601334C")]
		[Address(RVA = "0x25AF440", Offset = "0x25AE840", VA = "0x1825AF440")]
		private IEnumerable<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> \u0302\u0308\u0301\u0302\u0304\u0305\u0305\u0301\u0304\u0307\u0307\u0306\u0304\u0306\u0303()
		{
			return null;
		}

		// Token: 0x0601334D RID: 78669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601334D")]
		[Address(RVA = "0xC49BC0", Offset = "0xC48FC0", VA = "0x180C49BC0", Slot = "106")]
		public virtual void \u0305\u0308\u0303\u0303\u0302\u0301\u0308\u0307\u0304\u0302\u0303\u0302\u0302\u0305\u0308(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0308\u0306\u0304\u0306\u0302\u0303\u0306\u0305\u0308\u0308\u0303\u0303\u0306\u0308\u0308)
		{
		}

		// Token: 0x0601334E RID: 78670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601334E")]
		[Address(RVA = "0x25ADA10", Offset = "0x25ACE10", VA = "0x1825ADA10", Slot = "90")]
		public override void OnWrite(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
		{
		}

		// Token: 0x0601334F RID: 78671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601334F")]
		[Address(RVA = "0x25B0FD0", Offset = "0x25B03D0", VA = "0x1825B0FD0")]
		public Frontline()
		{
		}

		// Token: 0x06013350 RID: 78672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013350")]
		[Address(RVA = "0x25ADA10", Offset = "0x25ACE10", VA = "0x1825ADA10", Slot = "107")]
		public virtual void \u0304\u0301\u0306\u0304\u0307\u0306\u0303\u0305\u0307\u0308\u0305\u0306\u0302\u0304\u0308(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
		{
		}

		// Token: 0x06013351 RID: 78673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013351")]
		[Address(RVA = "0xC49BC0", Offset = "0xC48FC0", VA = "0x180C49BC0", Slot = "108")]
		public virtual void \u0301\u0308\u0305\u0305\u0302\u0302\u0301\u0308\u0301\u0304\u0305\u0304\u0308\u0307\u0301(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0308\u0306\u0304\u0306\u0302\u0303\u0306\u0305\u0308\u0308\u0303\u0303\u0306\u0308\u0308)
		{
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06013352 RID: 78674 RVA: 0x0007958C File Offset: 0x0007778C
		[Token(Token = "0x17000B09")]
		public override int \u0306\u0303\u0302\u0303\u0303\u0306\u0306\u0302\u0305\u0307\u0304\u0301\u0308\u0306\u0307
		{
			[Token(Token = "0x6013352")]
			[Address(RVA = "0x25B0FE0", Offset = "0x25B03E0", VA = "0x1825B0FE0", Slot = "40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06013353 RID: 78675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013353")]
		[Address(RVA = "0x25AF4B0", Offset = "0x25AE8B0", VA = "0x1825AF4B0")]
		public void \u0303\u0304\u0301\u0302\u0302\u0301\u0304\u0307\u0301\u0308\u0304\u0302\u0304\u0307\u0305(int \u0305\u0307\u0307\u0306\u0306\u0301\u0308\u0305\u0308\u0304\u0307\u0305\u0306\u0303\u0305, bool \u0302\u0301\u0308\u0303\u0301\u0302\u0305\u0307\u0307\u0302\u0308\u0302\u0305\u0301\u0305 = true)
		{
		}

		// Token: 0x06013354 RID: 78676 RVA: 0x000795A4 File Offset: 0x000777A4
		[Token(Token = "0x6013354")]
		[Address(RVA = "0xA67550", Offset = "0xA66950", VA = "0x180A67550")]
		public int \u0307\u0305\u0306\u0301\u0305\u0307\u0301\u0302\u0305\u0306\u0301\u0304\u0306\u0302\u0303()
		{
			return 0;
		}

		// Token: 0x06013355 RID: 78677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013355")]
		[Address(RVA = "0x25ADA60", Offset = "0x25ACE60", VA = "0x1825ADA60")]
		public void SetLayer(int \u0305\u0307\u0307\u0306\u0306\u0301\u0308\u0305\u0308\u0304\u0307\u0305\u0306\u0303\u0305, bool \u0302\u0301\u0308\u0303\u0301\u0302\u0305\u0307\u0307\u0302\u0308\u0302\u0305\u0301\u0305 = true)
		{
		}

		// Token: 0x06013356 RID: 78678 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013356")]
		[Address(RVA = "0x25AE880", Offset = "0x25ADC80", VA = "0x1825AE880")]
		private IEnumerable<Flag> \u0301\u0307\u0305\u0308\u0301\u0307\u0305\u0308\u0304\u0303\u0304\u0301\u0303\u0306\u0304()
		{
			return null;
		}

		// Token: 0x06013357 RID: 78679 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013357")]
		[Address(RVA = "0x25AFDD0", Offset = "0x25AF1D0", VA = "0x1825AFDD0")]
		private IEnumerable<ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>> \u0303\u0308\u0308\u0307\u0307\u0305\u0301\u0301\u0303\u0306\u0307\u0303\u0308\u0301\u0302()
		{
			return null;
		}

		// Token: 0x06013358 RID: 78680 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013358")]
		[Address(RVA = "0x25AE960", Offset = "0x25ADD60", VA = "0x1825AE960")]
		public \u0303\u0304\u0308\u0301\u0303\u0302\u0308\u0303\u0306\u0306\u0304\u0306\u0304\u0307\u0308 \u0302\u0302\u0304\u0302\u0304\u0306\u0308\u0304\u0307\u0305\u0302\u0304\u0308\u0304\u0302()
		{
			return null;
		}

		// Token: 0x06013359 RID: 78681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013359")]
		[Address(RVA = "0x25AD5C0", Offset = "0x25AC9C0", VA = "0x1825AD5C0", Slot = "54")]
		public override void OnLateUpdateEnd()
		{
		}

		// Token: 0x0601335A RID: 78682 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x601335A")]
		[Address(RVA = "0x25B0370", Offset = "0x25AF770", VA = "0x1825B0370")]
		public \u0301\u0302\u0307\u0307\u0302\u0303\u0302\u0308\u0304\u0304\u0306\u0302\u0303\u0303\u0306 \u0305\u0305\u0307\u0305\u0308\u0308\u0305\u0306\u0301\u0306\u0308\u0302\u0302\u0304\u0305()
		{
			return null;
		}

		// Token: 0x0601335B RID: 78683 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x601335B")]
		[Address(RVA = "0x25B0EB0", Offset = "0x25B02B0", VA = "0x1825B0EB0")]
		private IEnumerable<ValueTuple<bool, Flag>> \u0308\u0308\u0302\u0308\u0303\u0302\u0302\u0303\u0302\u0307\u0301\u0305\u0305\u0306\u0307()
		{
			return null;
		}

		// Token: 0x0601335C RID: 78684 RVA: 0x000795BC File Offset: 0x000777BC
		[Token(Token = "0x601335C")]
		[Address(RVA = "0x25AE2D0", Offset = "0x25AD6D0", VA = "0x1825AE2D0", Slot = "109")]
		public virtual bool \u0301\u0301\u0306\u0305\u0303\u0304\u0305\u0304\u0305\u0307\u0306\u0304\u0307\u0302\u0307(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 \u0303\u0307\u0306\u0308\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0301\u0304\u0308\u0307, out int \u0304\u0305\u0303\u0308\u0304\u0308\u0302\u0305\u0307\u0303\u0308\u0306\u0305\u0308\u0307, out float \u0308\u0304\u0301\u0307\u0301\u0301\u0306\u0304\u0301\u0302\u0307\u0302\u0306\u0305\u0305)
		{
			return default(bool);
		}

		// Token: 0x0601335D RID: 78685 RVA: 0x000795D4 File Offset: 0x000777D4
		[Token(Token = "0x601335D")]
		[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "110")]
		public virtual bool \u0308\u0305\u0306\u0303\u0304\u0304\u0305\u0308\u0301\u0303\u0306\u0302\u0301\u0305\u0302()
		{
			return default(bool);
		}

		// Token: 0x0601335E RID: 78686 RVA: 0x000795EC File Offset: 0x000777EC
		[Token(Token = "0x601335E")]
		[Address(RVA = "0x25B0F20", Offset = "0x25B0320", VA = "0x1825B0F20", Slot = "111")]
		public virtual \u0305\u0301\u0306\u0306\u0302\u0305\u0308\u0306\u0307\u0308\u0301\u0301\u0303\u0302\u0307 \u0308\u0308\u0304\u0303\u0306\u0308\u0308\u0306\u0304\u0302\u0306\u0302\u0304\u0305\u0304(out int \u0301\u0305\u0301\u0305\u0306\u0304\u0305\u0308\u0302\u0306\u0307\u0303\u0306\u0307\u0301, out int \u0307\u0302\u0308\u0301\u0308\u0305\u0303\u0301\u0303\u0303\u0302\u0306\u0308\u0308\u0302, out int \u0305\u0306\u0304\u0304\u0307\u0307\u0308\u0302\u0305\u0304\u0303\u0303\u0301\u0302\u0302)
		{
			return \u0305\u0301\u0306\u0306\u0302\u0305\u0308\u0306\u0307\u0308\u0301\u0301\u0303\u0302\u0307.TeamA;
		}

		// Token: 0x0601335F RID: 78687 RVA: 0x00079604 File Offset: 0x00077804
		[Token(Token = "0x601335F")]
		[Address(RVA = "0x902FF0", Offset = "0x9023F0", VA = "0x180902FF0", Slot = "112")]
		public virtual bool \u0306\u0302\u0305\u0305\u0308\u0302\u0304\u0305\u0301\u0301\u0308\u0305\u0308\u0303\u0301()
		{
			return default(bool);
		}

		// Token: 0x06013360 RID: 78688 RVA: 0x0007961C File Offset: 0x0007781C
		[Token(Token = "0x6013360")]
		[Address(RVA = "0xA67550", Offset = "0xA66950", VA = "0x180A67550")]
		public int \u0305\u0303\u0308\u0308\u0303\u0302\u0305\u0305\u0308\u0304\u0306\u0308\u0304\u0301\u0308()
		{
			return 0;
		}

		// Token: 0x06013361 RID: 78689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013361")]
		[Address(RVA = "0x25AFD60", Offset = "0x25AF160", VA = "0x1825AFD60", Slot = "113")]
		public virtual void \u0303\u0306\u0308\u0301\u0303\u0306\u0307\u0305\u0305\u0306\u0306\u0306\u0303\u0305\u0305()
		{
		}

		// Token: 0x06013362 RID: 78690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013362")]
		[Address(RVA = "0x25AEC00", Offset = "0x25AE000", VA = "0x1825AEC00", Slot = "114")]
		public virtual void \u0302\u0302\u0308\u0306\u0307\u0306\u0306\u0302\u0304\u0302\u0306\u0306\u0303\u0307\u0303(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
		{
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06013363 RID: 78691 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x17000B0B")]
		public \u0303\u0304\u0308\u0301\u0303\u0302\u0308\u0303\u0306\u0306\u0304\u0306\u0304\u0307\u0308 \u0307\u0301\u0308\u0308\u0305\u0306\u0307\u0307\u0302\u0306\u0305\u0306\u0303\u0301\u0303
		{
			[Token(Token = "0x6013363")]
			[Address(RVA = "0x25B1110", Offset = "0x25B0510", VA = "0x1825B1110")]
			get
			{
				return null;
			}
		}

		// Token: 0x06013364 RID: 78692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013364")]
		[Address(RVA = "0x25ACF70", Offset = "0x25AC370", VA = "0x1825ACF70", Slot = "17")]
		public override void Awake()
		{
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06013365 RID: 78693 RVA: 0x00079634 File Offset: 0x00077834
		[Token(Token = "0x17000B08")]
		public override bool \u0304\u0308\u0304\u0303\u0306\u0304\u0305\u0306\u0308\u0306\u0305\u0304\u0303\u0301\u0308
		{
			[Token(Token = "0x6013365")]
			[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06013366 RID: 78694 RVA: 0x0007964C File Offset: 0x0007784C
		[Token(Token = "0x6013366")]
		[Address(RVA = "0x902FF0", Offset = "0x9023F0", VA = "0x180902FF0", Slot = "115")]
		public virtual bool \u0303\u0301\u0301\u0305\u0304\u0304\u0307\u0304\u0304\u0301\u0304\u0304\u0303\u0305\u0305()
		{
			return default(bool);
		}

		// Token: 0x06013367 RID: 78695 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013367")]
		[Address(RVA = "0x25B0C10", Offset = "0x25B0010", VA = "0x1825B0C10")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x156D20", Offset = "0x156120")]
		private IEnumerable<Flag> \u0308\u0306\u0302\u0305\u0305\u0303\u0303\u0307\u0302\u0305\u0307\u0308\u0301\u0304\u0304()
		{
			return null;
		}

		// Token: 0x06013368 RID: 78696 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013368")]
		[Address(RVA = "0x25AE810", Offset = "0x25ADC10", VA = "0x1825AE810")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x156E90", Offset = "0x156290")]
		private IEnumerable<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> \u0301\u0306\u0306\u0308\u0306\u0302\u0307\u0307\u0307\u0308\u0302\u0303\u0304\u0303\u0303()
		{
			return null;
		}

		// Token: 0x06013369 RID: 78697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013369")]
		[Address(RVA = "0x25AEF50", Offset = "0x25AE350", VA = "0x1825AEF50")]
		private void \u0302\u0307\u0305\u0307\u0308\u0302\u0305\u0308\u0308\u0303\u0306\u0304\u0304\u0307\u0304(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0302\u0308\u0301\u0304\u0302\u0303\u0304\u0306\u0308\u0303\u0308\u0305\u0307\u0307\u0302)
		{
		}

		// Token: 0x0601336A RID: 78698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601336A")]
		[Address(RVA = "0x25AD7E0", Offset = "0x25ACBE0", VA = "0x1825AD7E0", Slot = "24")]
		public override void OnServerSideUpdate()
		{
		}

		// Token: 0x0601336B RID: 78699 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x601336B")]
		[Address(RVA = "0x25AFF10", Offset = "0x25AF310", VA = "0x1825AFF10")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x157050", Offset = "0x156450")]
		private IEnumerable<ValueTuple<bool, Flag>> \u0304\u0301\u0307\u0306\u0301\u0305\u0305\u0304\u0305\u0305\u0304\u0307\u0304\u0305\u0307()
		{
			return null;
		}

		// Token: 0x0601336C RID: 78700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601336C")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "60")]
		public override void OnGameEnded(bool \u0303\u0305\u0303\u0308\u0302\u0305\u0305\u0302\u0307\u0301\u0305\u0303\u0301\u0306\u0308, \u0305\u0301\u0306\u0306\u0302\u0305\u0308\u0306\u0307\u0308\u0301\u0301\u0303\u0302\u0307 \u0304\u0301\u0302\u0306\u0308\u0303\u0304\u0305\u0307\u0305\u0301\u0301\u0307\u0308\u0303)
		{
		}

		// Token: 0x0601336D RID: 78701 RVA: 0x00079664 File Offset: 0x00077864
		[Token(Token = "0x601336D")]
		[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "116")]
		public virtual bool \u0304\u0302\u0305\u0303\u0307\u0307\u0305\u0307\u0306\u0302\u0304\u0306\u0306\u0303\u0302()
		{
			return default(bool);
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0601336E RID: 78702 RVA: 0x0007967C File Offset: 0x0007787C
		[Token(Token = "0x17000B06")]
		public override bool \u0306\u0304\u0304\u0301\u0304\u0302\u0307\u0303\u0301\u0303\u0306\u0305\u0302\u0301\u0304
		{
			[Token(Token = "0x601336E")]
			[Address(RVA = "0x8FB760", Offset = "0x8FAB60", VA = "0x1808FB760", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601336F RID: 78703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601336F")]
		[Address(RVA = "0x25AD6B0", Offset = "0x25ACAB0", VA = "0x1825AD6B0", Slot = "27")]
		public override void OnRead(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 \u0305\u0308\u0307\u0302\u0304\u0302\u0305\u0304\u0306\u0304\u0301\u0301\u0307\u0303\u0307)
		{
		}

		// Token: 0x06013370 RID: 78704 RVA: 0x00079694 File Offset: 0x00077894
		[Token(Token = "0x6013370")]
		[Address(RVA = "0x1C80750", Offset = "0x1C7FB50", VA = "0x181C80750")]
		public int TicketsOf(\u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 \u0308\u0306\u0304\u0306\u0302\u0303\u0306\u0305\u0308\u0308\u0303\u0303\u0306\u0308\u0308)
		{
			return 0;
		}

		// Token: 0x06013371 RID: 78705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013371")]
		[Address(RVA = "0x25ACBF0", Offset = "0x25ABFF0", VA = "0x1825ACBF0", Slot = "50")]
		public override void Activate(bool \u0303\u0305\u0303\u0308\u0302\u0305\u0305\u0302\u0307\u0301\u0305\u0303\u0301\u0306\u0308)
		{
		}

		// Token: 0x06013372 RID: 78706 RVA: 0x000796AC File Offset: 0x000778AC
		[Token(Token = "0x6013372")]
		[Address(RVA = "0x902FF0", Offset = "0x9023F0", VA = "0x180902FF0", Slot = "117")]
		public virtual bool \u0303\u0306\u0303\u0304\u0306\u0308\u0307\u0301\u0308\u0307\u0306\u0306\u0303\u0308\u0308()
		{
			return default(bool);
		}

		// Token: 0x06013374 RID: 78708 RVA: 0x000796C4 File Offset: 0x000778C4
		[Token(Token = "0x6013374")]
		[Address(RVA = "0x25AD0C0", Offset = "0x25AC4C0", VA = "0x1825AD0C0", Slot = "29")]
		public override \u0305\u0301\u0306\u0306\u0302\u0305\u0308\u0306\u0307\u0308\u0301\u0301\u0303\u0302\u0307 GetWonTeam(out int \u0301\u0305\u0301\u0305\u0306\u0304\u0305\u0308\u0302\u0306\u0307\u0303\u0306\u0307\u0301, out int \u0307\u0302\u0308\u0301\u0308\u0305\u0303\u0301\u0303\u0303\u0302\u0306\u0308\u0308\u0302, out int \u0305\u0306\u0304\u0304\u0307\u0307\u0308\u0302\u0305\u0304\u0303\u0303\u0301\u0302\u0302)
		{
			return \u0305\u0301\u0306\u0306\u0302\u0305\u0308\u0306\u0307\u0308\u0301\u0301\u0303\u0302\u0307.TeamA;
		}

		// Token: 0x0400368F RID: 13967
		[Token(Token = "0x400368F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <\u0301\u0304\u0308\u0307\u0303\u0308\u0306\u0302\u0307\u0302\u0302\u0307\u0305\u0305\u0301>k__BackingField;

		// Token: 0x04003690 RID: 13968
		[Token(Token = "0x4003690")]
		[FieldOffset(Offset = "0x58")]
		public \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301[] \u0303\u0304\u0305\u0305\u0302\u0303\u0306\u0303\u0305\u0308\u0305\u0305\u0306\u0303\u0301;

		// Token: 0x04003691 RID: 13969
		[Token(Token = "0x4003691")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public \u0306\u0304\u0302\u0303\u0307\u0302\u0303\u0305\u0304\u0308\u0305\u0305\u0301\u0303\u0305 \u0306\u0303\u0305\u0303\u0301\u0307\u0307\u0305\u0302\u0301\u0303\u0307\u0308\u0301\u0302;

		// Token: 0x04003692 RID: 13970
		[Token(Token = "0x4003692")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public int \u0301\u0308\u0303\u0307\u0304\u0308\u0301\u0308\u0305\u0304\u0303\u0302\u0306\u0304\u0301;

		// Token: 0x04003693 RID: 13971
		[Token(Token = "0x4003693")]
		[FieldOffset(Offset = "0x6C")]
		[NonSerialized]
		public int \u0304\u0301\u0307\u0305\u0308\u0305\u0304\u0305\u0306\u0306\u0308\u0308\u0304\u0307\u0307;

		// Token: 0x04003694 RID: 13972
		[Token(Token = "0x4003694")]
		[FieldOffset(Offset = "0x70")]
		private int \u0303\u0301\u0304\u0303\u0305\u0302\u0306\u0306\u0301\u0308\u0307\u0306\u0305\u0304\u0307;

		// Token: 0x04003695 RID: 13973
		[Token(Token = "0x4003695")]
		[FieldOffset(Offset = "0x74")]
		private int \u0307\u0307\u0308\u0305\u0307\u0308\u0303\u0305\u0304\u0307\u0308\u0308\u0307\u0306\u0303;

		// Token: 0x04003696 RID: 13974
		[Token(Token = "0x4003696")]
		[FieldOffset(Offset = "0x78")]
		private int \u0301\u0308\u0303\u0308\u0303\u0305\u0306\u0308\u0308\u0302\u0304\u0308\u0306\u0308\u0308;

		// Token: 0x04003697 RID: 13975
		[Token(Token = "0x4003697")]
		[FieldOffset(Offset = "0x7C")]
		private float \u0306\u0303\u0304\u0302\u0307\u0303\u0302\u0302\u0308\u0302\u0308\u0301\u0304\u0304\u0306;

		// Token: 0x0200073E RID: 1854
		[Token(Token = "0x200073E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class \u0301\u0308\u0306\u0305\u0304\u0305\u0305\u0305\u0307\u0301\u0306\u0307\u0304\u0306\u0302 : IEnumerable<ValueTuple<bool, Flag>>, IEnumerable, IEnumerator<ValueTuple<bool, Flag>>, IEnumerator, IDisposable
		{
			// Token: 0x06013375 RID: 78709 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013375")]
			[Address(RVA = "0xEDB890", Offset = "0xEDAC90", VA = "0x180EDB890")]
			[DebuggerHidden]
			public \u0301\u0308\u0306\u0305\u0304\u0305\u0305\u0305\u0307\u0301\u0306\u0307\u0304\u0306\u0302(int <>1__state)
			{
			}

			// Token: 0x06013376 RID: 78710 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013376")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013377 RID: 78711 RVA: 0x000796DC File Offset: 0x000778DC
			[Token(Token = "0x6013377")]
			[Address(RVA = "0x25B8480", Offset = "0x25B7880", VA = "0x1825B8480", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06013378 RID: 78712 RVA: 0x000796F4 File Offset: 0x000778F4
			[Token(Token = "0x17000B0E")]
			private ValueTuple<bool, Flag> Current
			{
				[Token(Token = "0x6013378")]
				[Address(RVA = "0x8D1DC0", Offset = "0x8D11C0", VA = "0x1808D1DC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ValueTuple<bool, Flag>);
				}
			}

			// Token: 0x06013379 RID: 78713 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013379")]
			[Address(RVA = "0x25B87E0", Offset = "0x25B7BE0", VA = "0x1825B87E0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x0601337A RID: 78714 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B0F")]
			private object Current
			{
				[Token(Token = "0x601337A")]
				[Address(RVA = "0x25B8830", Offset = "0x25B7C30", VA = "0x1825B8830", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0601337B RID: 78715 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x601337B")]
			[Address(RVA = "0x25B8740", Offset = "0x25B7B40", VA = "0x1825B8740", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ValueTuple<bool, Flag>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0601337C RID: 78716 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x601337C")]
			[Address(RVA = "0x25B8740", Offset = "0x25B7B40", VA = "0x1825B8740", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04003698 RID: 13976
			[Token(Token = "0x4003698")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04003699 RID: 13977
			[Token(Token = "0x4003699")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x157350", Offset = "0x156750")]
			private ValueTuple<bool, Flag> <>2__current;

			// Token: 0x0400369A RID: 13978
			[Token(Token = "0x400369A")]
			[FieldOffset(Offset = "0x28")]
			private int <>l__initialThreadId;

			// Token: 0x0400369B RID: 13979
			[Token(Token = "0x400369B")]
			[FieldOffset(Offset = "0x30")]
			public Frontline <>4__this;

			// Token: 0x0400369C RID: 13980
			[Token(Token = "0x400369C")]
			[FieldOffset(Offset = "0x38")]
			private int <i>5__2;

			// Token: 0x0400369D RID: 13981
			[Token(Token = "0x400369D")]
			[FieldOffset(Offset = "0x40")]
			private Flag[] <flags>5__3;

			// Token: 0x0400369E RID: 13982
			[Token(Token = "0x400369E")]
			[FieldOffset(Offset = "0x48")]
			private bool <isActive>5__4;

			// Token: 0x0400369F RID: 13983
			[Token(Token = "0x400369F")]
			[FieldOffset(Offset = "0x4C")]
			private int <x>5__5;

			// Token: 0x040036A0 RID: 13984
			[Token(Token = "0x40036A0")]
			[FieldOffset(Offset = "0x50")]
			private int <x>5__6;
		}

		// Token: 0x0200073F RID: 1855
		[Token(Token = "0x200073F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class \u0308\u0306\u0301\u0303\u0308\u0304\u0302\u0303\u0304\u0302\u0303\u0307\u0306\u0308\u0306 : IEnumerable<Flag>, IEnumerable, IEnumerator<Flag>, IEnumerator, IDisposable
		{
			// Token: 0x0601337D RID: 78717 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601337D")]
			[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
			[DebuggerHidden]
			public \u0308\u0306\u0301\u0303\u0308\u0304\u0302\u0303\u0304\u0302\u0303\u0307\u0306\u0308\u0306(int <>1__state)
			{
			}

			// Token: 0x0601337E RID: 78718 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601337E")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0601337F RID: 78719 RVA: 0x0007970C File Offset: 0x0007790C
			[Token(Token = "0x601337F")]
			[Address(RVA = "0x25B9120", Offset = "0x25B8520", VA = "0x1825B9120", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x06013380 RID: 78720 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B10")]
			private Flag Current
			{
				[Token(Token = "0x6013380")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013381 RID: 78721 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013381")]
			[Address(RVA = "0x25B9470", Offset = "0x25B8870", VA = "0x1825B9470", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x06013382 RID: 78722 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B11")]
			private object Current
			{
				[Token(Token = "0x6013382")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013383 RID: 78723 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013383")]
			[Address(RVA = "0x25B93D0", Offset = "0x25B87D0", VA = "0x1825B93D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Flag> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06013384 RID: 78724 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013384")]
			[Address(RVA = "0x25B93D0", Offset = "0x25B87D0", VA = "0x1825B93D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040036A1 RID: 13985
			[Token(Token = "0x40036A1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040036A2 RID: 13986
			[Token(Token = "0x40036A2")]
			[FieldOffset(Offset = "0x18")]
			private Flag <>2__current;

			// Token: 0x040036A3 RID: 13987
			[Token(Token = "0x40036A3")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x040036A4 RID: 13988
			[Token(Token = "0x40036A4")]
			[FieldOffset(Offset = "0x28")]
			public Frontline <>4__this;

			// Token: 0x040036A5 RID: 13989
			[Token(Token = "0x40036A5")]
			[FieldOffset(Offset = "0x30")]
			private Flag[] <flags>5__2;

			// Token: 0x040036A6 RID: 13990
			[Token(Token = "0x40036A6")]
			[FieldOffset(Offset = "0x38")]
			private int <x>5__3;

			// Token: 0x040036A7 RID: 13991
			[Token(Token = "0x40036A7")]
			[FieldOffset(Offset = "0x3C")]
			private int <x>5__4;
		}

		// Token: 0x02000740 RID: 1856
		[Token(Token = "0x2000740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class \u0303\u0308\u0304\u0308\u0305\u0305\u0305\u0308\u0305\u0308\u0304\u0304\u0307\u0306\u0305 : IEnumerable<Flag>, IEnumerable, IEnumerator<Flag>, IEnumerator, IDisposable
		{
			// Token: 0x06013385 RID: 78725 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013385")]
			[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
			[DebuggerHidden]
			public \u0303\u0308\u0304\u0308\u0305\u0305\u0305\u0308\u0305\u0308\u0304\u0304\u0307\u0306\u0305(int <>1__state)
			{
			}

			// Token: 0x06013386 RID: 78726 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013386")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013387 RID: 78727 RVA: 0x00079724 File Offset: 0x00077924
			[Token(Token = "0x6013387")]
			[Address(RVA = "0x25B8880", Offset = "0x25B7C80", VA = "0x1825B8880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x06013388 RID: 78728 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B12")]
			private Flag Current
			{
				[Token(Token = "0x6013388")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013389 RID: 78729 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013389")]
			[Address(RVA = "0x25B8B60", Offset = "0x25B7F60", VA = "0x1825B8B60", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x0601338A RID: 78730 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B13")]
			private object Current
			{
				[Token(Token = "0x601338A")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0601338B RID: 78731 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x601338B")]
			[Address(RVA = "0x25B8AC0", Offset = "0x25B7EC0", VA = "0x1825B8AC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Flag> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0601338C RID: 78732 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x601338C")]
			[Address(RVA = "0x25B8AC0", Offset = "0x25B7EC0", VA = "0x1825B8AC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040036A8 RID: 13992
			[Token(Token = "0x40036A8")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040036A9 RID: 13993
			[Token(Token = "0x40036A9")]
			[FieldOffset(Offset = "0x18")]
			private Flag <>2__current;

			// Token: 0x040036AA RID: 13994
			[Token(Token = "0x40036AA")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x040036AB RID: 13995
			[Token(Token = "0x40036AB")]
			[FieldOffset(Offset = "0x28")]
			public Frontline <>4__this;

			// Token: 0x040036AC RID: 13996
			[Token(Token = "0x40036AC")]
			[FieldOffset(Offset = "0x30")]
			private int <i>5__2;

			// Token: 0x040036AD RID: 13997
			[Token(Token = "0x40036AD")]
			[FieldOffset(Offset = "0x38")]
			private Flag[] <flags>5__3;

			// Token: 0x040036AE RID: 13998
			[Token(Token = "0x40036AE")]
			[FieldOffset(Offset = "0x40")]
			private int <x>5__4;

			// Token: 0x040036AF RID: 13999
			[Token(Token = "0x40036AF")]
			[FieldOffset(Offset = "0x44")]
			private int <x>5__5;
		}

		// Token: 0x02000741 RID: 1857
		[Token(Token = "0x2000741")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class \u0305\u0307\u0305\u0306\u0306\u0303\u0307\u0301\u0301\u0307\u0308\u0307\u0303\u0301\u0307 : IEnumerable<ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>>, IEnumerable, IEnumerator<ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>>, IEnumerator, IDisposable
		{
			// Token: 0x0601338D RID: 78733 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601338D")]
			[Address(RVA = "0xEDB890", Offset = "0xEDAC90", VA = "0x180EDB890")]
			[DebuggerHidden]
			public \u0305\u0307\u0305\u0306\u0306\u0303\u0307\u0301\u0301\u0307\u0308\u0307\u0303\u0301\u0307(int <>1__state)
			{
			}

			// Token: 0x0601338E RID: 78734 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601338E")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0601338F RID: 78735 RVA: 0x0007973C File Offset: 0x0007793C
			[Token(Token = "0x601338F")]
			[Address(RVA = "0x25B8BB0", Offset = "0x25B7FB0", VA = "0x1825B8BB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x06013390 RID: 78736 RVA: 0x00079754 File Offset: 0x00077954
			[Token(Token = "0x17000B14")]
			private ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> Current
			{
				[Token(Token = "0x6013390")]
				[Address(RVA = "0x8D1DC0", Offset = "0x8D11C0", VA = "0x1808D1DC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>);
				}
			}

			// Token: 0x06013391 RID: 78737 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013391")]
			[Address(RVA = "0x25B8E10", Offset = "0x25B8210", VA = "0x1825B8E10", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x06013392 RID: 78738 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B15")]
			private object Current
			{
				[Token(Token = "0x6013392")]
				[Address(RVA = "0x25B8E60", Offset = "0x25B8260", VA = "0x1825B8E60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013393 RID: 78739 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013393")]
			[Address(RVA = "0x25B8D70", Offset = "0x25B8170", VA = "0x1825B8D70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06013394 RID: 78740 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013394")]
			[Address(RVA = "0x25B8D70", Offset = "0x25B8170", VA = "0x1825B8D70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040036B0 RID: 14000
			[Token(Token = "0x40036B0")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040036B1 RID: 14001
			[Token(Token = "0x40036B1")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x157ED0", Offset = "0x1572D0")]
			private ValueTuple<bool, \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> <>2__current;

			// Token: 0x040036B2 RID: 14002
			[Token(Token = "0x40036B2")]
			[FieldOffset(Offset = "0x28")]
			private int <>l__initialThreadId;

			// Token: 0x040036B3 RID: 14003
			[Token(Token = "0x40036B3")]
			[FieldOffset(Offset = "0x30")]
			public Frontline <>4__this;

			// Token: 0x040036B4 RID: 14004
			[Token(Token = "0x40036B4")]
			[FieldOffset(Offset = "0x38")]
			private int <i>5__2;

			// Token: 0x040036B5 RID: 14005
			[Token(Token = "0x40036B5")]
			[FieldOffset(Offset = "0x3C")]
			private int <i>5__3;
		}

		// Token: 0x02000742 RID: 1858
		[Token(Token = "0x2000742")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class \u0301\u0305\u0302\u0303\u0302\u0301\u0303\u0301\u0301\u0306\u0308\u0303\u0305\u0308\u0301 : IEnumerable<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>, IEnumerable, IEnumerator<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>, IEnumerator, IDisposable
		{
			// Token: 0x06013395 RID: 78741 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013395")]
			[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
			[DebuggerHidden]
			public \u0301\u0305\u0302\u0303\u0302\u0301\u0303\u0301\u0301\u0306\u0308\u0303\u0305\u0308\u0301(int <>1__state)
			{
			}

			// Token: 0x06013396 RID: 78742 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013396")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06013397 RID: 78743 RVA: 0x0007976C File Offset: 0x0007796C
			[Token(Token = "0x6013397")]
			[Address(RVA = "0x25B8240", Offset = "0x25B7640", VA = "0x1825B8240", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x06013398 RID: 78744 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B16")]
			private \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301 Current
			{
				[Token(Token = "0x6013398")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06013399 RID: 78745 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013399")]
			[Address(RVA = "0x25B8430", Offset = "0x25B7830", VA = "0x1825B8430", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x0601339A RID: 78746 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B17")]
			private object Current
			{
				[Token(Token = "0x601339A")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0601339B RID: 78747 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x601339B")]
			[Address(RVA = "0x25B8390", Offset = "0x25B7790", VA = "0x1825B8390", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0601339C RID: 78748 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x601339C")]
			[Address(RVA = "0x25B8390", Offset = "0x25B7790", VA = "0x1825B8390", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040036B6 RID: 14006
			[Token(Token = "0x40036B6")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040036B7 RID: 14007
			[Token(Token = "0x40036B7")]
			[FieldOffset(Offset = "0x18")]
			private \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301 <>2__current;

			// Token: 0x040036B8 RID: 14008
			[Token(Token = "0x40036B8")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x040036B9 RID: 14009
			[Token(Token = "0x40036B9")]
			[FieldOffset(Offset = "0x28")]
			public Frontline <>4__this;

			// Token: 0x040036BA RID: 14010
			[Token(Token = "0x40036BA")]
			[FieldOffset(Offset = "0x30")]
			private int <secondIndex>5__2;
		}

		// Token: 0x02000743 RID: 1859
		[Token(Token = "0x2000743")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class \u0307\u0308\u0303\u0304\u0306\u0306\u0303\u0303\u0305\u0307\u0302\u0307\u0304\u0307\u0308 : IEnumerable<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>, IEnumerable, IEnumerator<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301>, IEnumerator, IDisposable
		{
			// Token: 0x0601339D RID: 78749 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601339D")]
			[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
			[DebuggerHidden]
			public \u0307\u0308\u0303\u0304\u0306\u0306\u0303\u0303\u0305\u0307\u0302\u0307\u0304\u0307\u0308(int <>1__state)
			{
			}

			// Token: 0x0601339E RID: 78750 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601339E")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0601339F RID: 78751 RVA: 0x00079784 File Offset: 0x00077984
			[Token(Token = "0x601339F")]
			[Address(RVA = "0x25B8EE0", Offset = "0x25B82E0", VA = "0x1825B8EE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x060133A0 RID: 78752 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B18")]
			private \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301 Current
			{
				[Token(Token = "0x60133A0")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060133A1 RID: 78753 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60133A1")]
			[Address(RVA = "0x25B90D0", Offset = "0x25B84D0", VA = "0x1825B90D0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x060133A2 RID: 78754 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000B19")]
			private object Current
			{
				[Token(Token = "0x60133A2")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060133A3 RID: 78755 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x60133A3")]
			[Address(RVA = "0x25B9030", Offset = "0x25B8430", VA = "0x1825B9030", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<\u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060133A4 RID: 78756 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x60133A4")]
			[Address(RVA = "0x25B9030", Offset = "0x25B8430", VA = "0x1825B9030", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040036BB RID: 14011
			[Token(Token = "0x40036BB")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040036BC RID: 14012
			[Token(Token = "0x40036BC")]
			[FieldOffset(Offset = "0x18")]
			private \u0304\u0301\u0301\u0304\u0308\u0301\u0307\u0307\u0306\u0301\u0306\u0305\u0303\u0303\u0301 <>2__current;

			// Token: 0x040036BD RID: 14013
			[Token(Token = "0x40036BD")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x040036BE RID: 14014
			[Token(Token = "0x40036BE")]
			[FieldOffset(Offset = "0x28")]
			public Frontline <>4__this;

			// Token: 0x040036BF RID: 14015
			[Token(Token = "0x40036BF")]
			[FieldOffset(Offset = "0x30")]
			private int <i>5__2;

			// Token: 0x040036C0 RID: 14016
			[Token(Token = "0x40036C0")]
			[FieldOffset(Offset = "0x34")]
			private int <i>5__3;
		}

		// Token: 0x02000744 RID: 1860
		[Token(Token = "0x2000744")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class \u0307\u0306\u0302\u0308\u0304\u0306\u0306\u0303\u0305\u0306\u0304\u0303\u0307\u0304\u0302
		{
			// Token: 0x060133A5 RID: 78757 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60133A5")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public \u0307\u0306\u0302\u0308\u0304\u0306\u0306\u0303\u0305\u0306\u0304\u0303\u0307\u0304\u0302()
			{
			}

			// Token: 0x060133A6 RID: 78758 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60133A6")]
			[Address(RVA = "0x25B8EB0", Offset = "0x25B82B0", VA = "0x1825B8EB0")]
			internal void \u0308\u0305\u0301\u0302\u0303\u0303\u0306\u0308\u0302\u0302\u0308\u0305\u0301\u0302\u0308()
			{
			}

			// Token: 0x040036C1 RID: 14017
			[Token(Token = "0x40036C1")]
			[FieldOffset(Offset = "0x10")]
			public bool myTeamWon;
		}
	}
}
