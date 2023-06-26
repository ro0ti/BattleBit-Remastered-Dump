using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using touching_your_mom;
using PlayerLoadout.Items;

// Token: 0x020003E0 RID: 992
[Token(Token = "0x20003E0")]
public class PlayerStats
{
	// Token: 0x0600A891 RID: 43153 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A891")]
	[Address(RVA = "0x1AF0AE0", Offset = "0x1AEFEE0", VA = "0x181AF0AE0")]
	public PlayerStats()
	{
	}

	// Token: 0x0600A892 RID: 43154 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A892")]
	[Address(RVA = "0x1AF0240", Offset = "0x1AEF640", VA = "0x181AF0240")]
	public void ReadFrom_MasterServer_ClientSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
	{
	}

	// Token: 0x0600A893 RID: 43155 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A893")]
	[Address(RVA = "0x1AF0480", Offset = "0x1AEF880", VA = "0x181AF0480")]
	public void ReadFrom_MasterServer_GameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
	{
	}

	// Token: 0x0600A894 RID: 43156 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A894")]
	[Address(RVA = "0x1AEFFF0", Offset = "0x1AEF3F0", VA = "0x181AEFFF0")]
	public void ReadFrom_GameServer_ClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser, bool readFull)
	{
	}

	// Token: 0x0600A895 RID: 43157 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A895")]
	[Address(RVA = "0x1AF09A0", Offset = "0x1AEFDA0", VA = "0x181AF09A0")]
	public void WriteTo_MasterServer_GameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
	{
	}

	// Token: 0x0600A896 RID: 43158 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A896")]
	[Address(RVA = "0x1AF0860", Offset = "0x1AEFC60", VA = "0x181AF0860")]
	public void WriteTo_Client_GameServerSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser, bool writeFull)
	{
	}

	// Token: 0x0600A897 RID: 43159 RVA: 0x00041024 File Offset: 0x0003F224
	[Token(Token = "0x600A897")]
	[Address(RVA = "0x1AEFD30", Offset = "0x1AEF130", VA = "0x181AEFD30")]
	public \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 MostPlayedClass(out uint val)
	{
		return \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304.Assault;
	}

	// Token: 0x0600A898 RID: 43160 RVA: 0x0004103C File Offset: 0x0003F23C
	[Token(Token = "0x600A898")]
	[Address(RVA = "0x1AEF830", Offset = "0x1AEEC30", VA = "0x181AEF830")]
	public \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 MostKillClass(out uint val)
	{
		return \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304.Assault;
	}

	// Token: 0x0600A899 RID: 43161 RVA: 0x00041054 File Offset: 0x0003F254
	[Token(Token = "0x600A899")]
	[Address(RVA = "0x1AEFE90", Offset = "0x1AEF290", VA = "0x181AEFE90")]
	public \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 MostScoredClass(out uint val)
	{
		return \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304.Assault;
	}

	// Token: 0x0600A89A RID: 43162 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x600A89A")]
	[Address(RVA = "0x1AEFC50", Offset = "0x1AEF050", VA = "0x181AEFC50")]
	public AWeapon MostKilledWeapon()
	{
		return null;
	}

	// Token: 0x0600A89B RID: 43163 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x600A89B")]
	[Address(RVA = "0x1AEFA80", Offset = "0x1AEEE80", VA = "0x181AEFA80")]
	public AGadget MostKilledGadget()
	{
		return null;
	}

	// Token: 0x0600A89C RID: 43164 RVA: 0x0000270E File Offset: 0x0000090E
	[Token(Token = "0x600A89C")]
	[Address(RVA = "0x1AEFB70", Offset = "0x1AEEF70", VA = "0x181AEFB70")]
	public Vehicle MostKilledVehicleWith()
	{
		return null;
	}

	// Token: 0x0600A89D RID: 43165 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A89D")]
	[Address(RVA = "0x1AEF810", Offset = "0x1AEEC10", VA = "0x181AEF810")]
	public void Check(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client)
	{
	}

	// Token: 0x0600A89E RID: 43166 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600A89E")]
	[Address(RVA = "0x1AF06E0", Offset = "0x1AEFAE0", VA = "0x181AF06E0")]
	public void Reset()
	{
	}

	// Token: 0x0600A89F RID: 43167 RVA: 0x0004106C File Offset: 0x0003F26C
	[Token(Token = "0x600A89F")]
	[Address(RVA = "0x1AF07A0", Offset = "0x1AEFBA0", VA = "0x181AF07A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <MostPlayedClass>g__isMost|17_0(uint value)
	{
		return default(bool);
	}

	// Token: 0x0600A8A0 RID: 43168 RVA: 0x00041084 File Offset: 0x0003F284
	[Token(Token = "0x600A8A0")]
	[Address(RVA = "0x1AF0710", Offset = "0x1AEFB10", VA = "0x181AF0710")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <MostKillClass>g__isMost|18_0(uint value)
	{
		return default(bool);
	}

	// Token: 0x0600A8A1 RID: 43169 RVA: 0x0004109C File Offset: 0x0003F29C
	[Token(Token = "0x600A8A1")]
	[Address(RVA = "0x1AF0800", Offset = "0x1AEFC00", VA = "0x181AF0800")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
	private bool <MostScoredClass>g__isMost|19_0(uint value)
	{
		return default(bool);
	}

	// Token: 0x04001D3B RID: 7483
	[Token(Token = "0x4001D3B")]
	[touching_your_mom.FieldOffset(Offset = "0x10")]
	public PlayerStats.PlayerProgess Progess;

	// Token: 0x04001D3C RID: 7484
	[Token(Token = "0x4001D3C")]
	[touching_your_mom.FieldOffset(Offset = "0x18")]
	public \u0304\u0302\u0303\u0301\u0304\u0303\u0308\u0302\u0307\u0302\u0306\u0302\u0308\u0306\u0305 ToolsProgess;

	// Token: 0x04001D3D RID: 7485
	[Token(Token = "0x4001D3D")]
	[touching_your_mom.FieldOffset(Offset = "0x20")]
	public PlayerStats.PlayerAchievements Achievements;

	// Token: 0x04001D3E RID: 7486
	[Token(Token = "0x4001D3E")]
	[touching_your_mom.FieldOffset(Offset = "0x28")]
	public PlayerStats.PlayerSelections Selections;

	// Token: 0x04001D3F RID: 7487
	[Token(Token = "0x4001D3F")]
	[touching_your_mom.FieldOffset(Offset = "0x30")]
	public PlayerStats.PlayerInventory Inventory;

	// Token: 0x04001D40 RID: 7488
	[Token(Token = "0x4001D40")]
	[touching_your_mom.FieldOffset(Offset = "0x38")]
	public PlayerStats.PlayerClan Clan;

	// Token: 0x04001D41 RID: 7489
	[Token(Token = "0x4001D41")]
	[touching_your_mom.FieldOffset(Offset = "0x40")]
	public bool isBanned;

	// Token: 0x04001D42 RID: 7490
	[Token(Token = "0x4001D42")]
	[touching_your_mom.FieldOffset(Offset = "0x41")]
	public bool isTimedout;

	// Token: 0x04001D43 RID: 7491
	[Token(Token = "0x4001D43")]
	[touching_your_mom.FieldOffset(Offset = "0x48")]
	public \u0304\u0307\u0306\u0305\u0305\u0304\u0308\u0305\u0302\u0304\u0308\u0303\u0306\u0303\u0304 Role;

	// Token: 0x04001D44 RID: 7492
	[Token(Token = "0x4001D44")]
	[touching_your_mom.FieldOffset(Offset = "0x50")]
	public string MasterServerUsername;

	// Token: 0x04001D45 RID: 7493
	[Token(Token = "0x4001D45")]
	[touching_your_mom.FieldOffset(Offset = "0x58")]
	public uint Runtime_RoundXP;

	// Token: 0x020003E1 RID: 993
	[Token(Token = "0x20003E1")]
	public class PlayerProgess
	{
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600A8A2 RID: 43170 RVA: 0x000410B4 File Offset: 0x0003F2B4
		[Token(Token = "0x17000674")]
		public uint FullRank
		{
			[Token(Token = "0x600A8A2")]
			[Address(RVA = "0x1AEDD20", Offset = "0x1AED120", VA = "0x181AEDD20")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8A3")]
		[Address(RVA = "0x1AED8A0", Offset = "0x1AECCA0", VA = "0x181AED8A0")]
		public void WriteTo_MasterServer_GameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8A4")]
		[Address(RVA = "0x1AECC40", Offset = "0x1AEC040", VA = "0x181AECC40")]
		public void ReadFrom_MasterServer_ClientSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8A5")]
		[Address(RVA = "0x1AECC40", Offset = "0x1AEC040", VA = "0x181AECC40")]
		public void ReadFrom_MasterServer_GameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8A6 RID: 43174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8A6")]
		[Address(RVA = "0x1AED460", Offset = "0x1AEC860", VA = "0x181AED460")]
		public void WriteTo_ClientFrom_GameServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser, bool writeFull)
		{
		}

		// Token: 0x0600A8A7 RID: 43175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8A7")]
		[Address(RVA = "0x1AEBE80", Offset = "0x1AEB280", VA = "0x181AEBE80")]
		public void ReadFrom_GameServer_ClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser, bool readFull)
		{
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x000410CC File Offset: 0x0003F2CC
		[Token(Token = "0x17000675")]
		public float KD
		{
			[Token(Token = "0x600A8A8")]
			[Address(RVA = "0x1AEDD40", Offset = "0x1AED140", VA = "0x181AEDD40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x000410E4 File Offset: 0x0003F2E4
		[Token(Token = "0x17000676")]
		public float WL
		{
			[Token(Token = "0x600A8A9")]
			[Address(RVA = "0x1AEDF50", Offset = "0x1AED350", VA = "0x181AEDF50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600A8AA RID: 43178 RVA: 0x000410FC File Offset: 0x0003F2FC
		[Token(Token = "0x17000677")]
		public float Accuracy
		{
			[Token(Token = "0x600A8AA")]
			[Address(RVA = "0x1AEDC70", Offset = "0x1AED070", VA = "0x181AEDC70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x00041114 File Offset: 0x0003F314
		[Token(Token = "0x17000678")]
		public int ScorePerMinute
		{
			[Token(Token = "0x600A8AB")]
			[Address(RVA = "0x1AEDEB0", Offset = "0x1AED2B0", VA = "0x181AEDEB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600A8AC RID: 43180 RVA: 0x0004112C File Offset: 0x0003F32C
		[Token(Token = "0x17000679")]
		public float KillPerMinute
		{
			[Token(Token = "0x600A8AC")]
			[Address(RVA = "0x1AEDDF0", Offset = "0x1AED1F0", VA = "0x181AEDDF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x00041144 File Offset: 0x0003F344
		[Token(Token = "0x1700067A")]
		public uint NumberOfRoundsPlayed
		{
			[Token(Token = "0x600A8AD")]
			[Address(RVA = "0x1AEDEA0", Offset = "0x1AED2A0", VA = "0x181AEDEA0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8AE")]
		[Address(RVA = "0x1AEBD30", Offset = "0x1AEB130", VA = "0x181AEBD30")]
		public void IncrementKill(\u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 role, int count = 1)
		{
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8AF")]
		[Address(RVA = "0x1AEBD90", Offset = "0x1AEB190", VA = "0x181AEBD90")]
		public void IncrementScore(\u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 role, int xp)
		{
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8B0")]
		[Address(RVA = "0x1AEBE10", Offset = "0x1AEB210", VA = "0x181AEBE10")]
		public void IncrementSecond(\u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 role, uint seconds = 1U)
		{
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8B1")]
		[Address(RVA = "0x1AED310", Offset = "0x1AEC710", VA = "0x181AED310")]
		public void Reset()
		{
		}

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8B2")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public PlayerProgess()
		{
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x0004115C File Offset: 0x0003F35C
		[Token(Token = "0x600A8B3")]
		[Address(RVA = "0x1AED440", Offset = "0x1AEC840", VA = "0x181AED440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static bool <ReadFrom_MasterServer_ClientSide>g__canRead|47_0(ref PlayerStats.PlayerProgess.<>c__DisplayClass47_0 A_0)
		{
			return default(bool);
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x00041174 File Offset: 0x0003F374
		[Token(Token = "0x600A8B4")]
		[Address(RVA = "0x1AED440", Offset = "0x1AEC840", VA = "0x181AED440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static bool <ReadFrom_MasterServer_GameServerSide>g__canRead|48_0(ref PlayerStats.PlayerProgess.<>c__DisplayClass48_0 A_0)
		{
			return default(bool);
		}

		// Token: 0x04001D46 RID: 7494
		[Token(Token = "0x4001D46")]
		private const uint ParamCount = 42U;

		// Token: 0x04001D47 RID: 7495
		[Token(Token = "0x4001D47")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		public ulong SteamID;

		// Token: 0x04001D48 RID: 7496
		[Token(Token = "0x4001D48")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		public PlayerStats.Pint KillCount;

		// Token: 0x04001D49 RID: 7497
		[Token(Token = "0x4001D49")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public PlayerStats.Pint LeaderKills;

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public PlayerStats.Pint AssaultKills;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public PlayerStats.Pint MedicKills;

		// Token: 0x04001D4C RID: 7500
		[Token(Token = "0x4001D4C")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public PlayerStats.Pint EngineerKills;

		// Token: 0x04001D4D RID: 7501
		[Token(Token = "0x4001D4D")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		public PlayerStats.Pint SupportKills;

		// Token: 0x04001D4E RID: 7502
		[Token(Token = "0x4001D4E")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		public PlayerStats.Pint ReconKills;

		// Token: 0x04001D4F RID: 7503
		[Token(Token = "0x4001D4F")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		public PlayerStats.Pint DeathCount;

		// Token: 0x04001D50 RID: 7504
		[Token(Token = "0x4001D50")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		public uint WinCount;

		// Token: 0x04001D51 RID: 7505
		[Token(Token = "0x4001D51")]
		[touching_your_mom.FieldOffset(Offset = "0x5C")]
		public uint LoseCount;

		// Token: 0x04001D52 RID: 7506
		[Token(Token = "0x4001D52")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		public PlayerStats.Pint FriendlyShots;

		// Token: 0x04001D53 RID: 7507
		[Token(Token = "0x4001D53")]
		[touching_your_mom.FieldOffset(Offset = "0x68")]
		public PlayerStats.Pint FriendlyKills;

		// Token: 0x04001D54 RID: 7508
		[Token(Token = "0x4001D54")]
		[touching_your_mom.FieldOffset(Offset = "0x70")]
		public PlayerStats.Pint Revived;

		// Token: 0x04001D55 RID: 7509
		[Token(Token = "0x4001D55")]
		[touching_your_mom.FieldOffset(Offset = "0x78")]
		public PlayerStats.Pint RevivedTeamMates;

		// Token: 0x04001D56 RID: 7510
		[Token(Token = "0x4001D56")]
		[touching_your_mom.FieldOffset(Offset = "0x80")]
		public PlayerStats.Pint Assists;

		// Token: 0x04001D57 RID: 7511
		[Token(Token = "0x4001D57")]
		[touching_your_mom.FieldOffset(Offset = "0x88")]
		public uint Prestige;

		// Token: 0x04001D58 RID: 7512
		[Token(Token = "0x4001D58")]
		[touching_your_mom.FieldOffset(Offset = "0x8C")]
		public uint Rank;

		// Token: 0x04001D59 RID: 7513
		[Token(Token = "0x4001D59")]
		[touching_your_mom.FieldOffset(Offset = "0x90")]
		public uint EXP;

		// Token: 0x04001D5A RID: 7514
		[Token(Token = "0x4001D5A")]
		[touching_your_mom.FieldOffset(Offset = "0x94")]
		public PlayerStats.Pint ShotsFired;

		// Token: 0x04001D5B RID: 7515
		[Token(Token = "0x4001D5B")]
		[touching_your_mom.FieldOffset(Offset = "0x9C")]
		public PlayerStats.Pint ShotsHit;

		// Token: 0x04001D5C RID: 7516
		[Token(Token = "0x4001D5C")]
		[touching_your_mom.FieldOffset(Offset = "0xA4")]
		public PlayerStats.Pint Headshots;

		// Token: 0x04001D5D RID: 7517
		[Token(Token = "0x4001D5D")]
		[touching_your_mom.FieldOffset(Offset = "0xAC")]
		public PlayerStats.Pint ObjectivesComplated;

		// Token: 0x04001D5E RID: 7518
		[Token(Token = "0x4001D5E")]
		[touching_your_mom.FieldOffset(Offset = "0xB4")]
		public PlayerStats.Pint HealedHPs;

		// Token: 0x04001D5F RID: 7519
		[Token(Token = "0x4001D5F")]
		[touching_your_mom.FieldOffset(Offset = "0xBC")]
		public PlayerStats.Pint RoadKills;

		// Token: 0x04001D60 RID: 7520
		[Token(Token = "0x4001D60")]
		[touching_your_mom.FieldOffset(Offset = "0xC4")]
		public PlayerStats.Pint Suicides;

		// Token: 0x04001D61 RID: 7521
		[Token(Token = "0x4001D61")]
		[touching_your_mom.FieldOffset(Offset = "0xCC")]
		public PlayerStats.Pint VehiclesDestroyed;

		// Token: 0x04001D62 RID: 7522
		[Token(Token = "0x4001D62")]
		[touching_your_mom.FieldOffset(Offset = "0xD4")]
		public PlayerStats.Pint VehicleHPRepaired;

		// Token: 0x04001D63 RID: 7523
		[Token(Token = "0x4001D63")]
		[touching_your_mom.FieldOffset(Offset = "0xDC")]
		public uint LongestKill;

		// Token: 0x04001D64 RID: 7524
		[Token(Token = "0x4001D64")]
		[touching_your_mom.FieldOffset(Offset = "0xE0")]
		public uint PlayTimeSeconds;

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[touching_your_mom.FieldOffset(Offset = "0xE4")]
		public uint LeaderPlayTime;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x4001D66")]
		[touching_your_mom.FieldOffset(Offset = "0xE8")]
		public uint AssaultPlayTime;

		// Token: 0x04001D67 RID: 7527
		[Token(Token = "0x4001D67")]
		[touching_your_mom.FieldOffset(Offset = "0xEC")]
		public uint MedicPlayTime;

		// Token: 0x04001D68 RID: 7528
		[Token(Token = "0x4001D68")]
		[touching_your_mom.FieldOffset(Offset = "0xF0")]
		public uint EngineerPlayTime;

		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		[touching_your_mom.FieldOffset(Offset = "0xF4")]
		public uint SupportPlayTime;

		// Token: 0x04001D6A RID: 7530
		[Token(Token = "0x4001D6A")]
		[touching_your_mom.FieldOffset(Offset = "0xF8")]
		public uint ReconPlayTime;

		// Token: 0x04001D6B RID: 7531
		[Token(Token = "0x4001D6B")]
		[touching_your_mom.FieldOffset(Offset = "0xFC")]
		public uint LeaderScore;

		// Token: 0x04001D6C RID: 7532
		[Token(Token = "0x4001D6C")]
		[touching_your_mom.FieldOffset(Offset = "0x100")]
		public uint AssaultScore;

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		[touching_your_mom.FieldOffset(Offset = "0x104")]
		public uint MedicScore;

		// Token: 0x04001D6E RID: 7534
		[Token(Token = "0x4001D6E")]
		[touching_your_mom.FieldOffset(Offset = "0x108")]
		public uint EngineerScore;

		// Token: 0x04001D6F RID: 7535
		[Token(Token = "0x4001D6F")]
		[touching_your_mom.FieldOffset(Offset = "0x10C")]
		public uint SupportScore;

		// Token: 0x04001D70 RID: 7536
		[Token(Token = "0x4001D70")]
		[touching_your_mom.FieldOffset(Offset = "0x110")]
		public uint ReconScore;

		// Token: 0x04001D71 RID: 7537
		[Token(Token = "0x4001D71")]
		[touching_your_mom.FieldOffset(Offset = "0x114")]
		public uint TotalScore;

		// Token: 0x020003E2 RID: 994
		[Token(Token = "0x20003E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[StructLayout(3)]
		private struct <>c__DisplayClass47_0
		{
			// Token: 0x04001D72 RID: 7538
			[Token(Token = "0x4001D72")]
			[touching_your_mom.FieldOffset(Offset = "0x0")]
			public \u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser;

			// Token: 0x04001D73 RID: 7539
			[Token(Token = "0x4001D73")]
			[touching_your_mom.FieldOffset(Offset = "0x8")]
			public int maxReadPosition;
		}

		// Token: 0x020003E3 RID: 995
		[Token(Token = "0x20003E3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[StructLayout(3)]
		private struct <>c__DisplayClass48_0
		{
			// Token: 0x04001D74 RID: 7540
			[Token(Token = "0x4001D74")]
			[touching_your_mom.FieldOffset(Offset = "0x0")]
			public \u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser;

			// Token: 0x04001D75 RID: 7541
			[Token(Token = "0x4001D75")]
			[touching_your_mom.FieldOffset(Offset = "0x8")]
			public int maxReadPosition;
		}
	}

	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	public class PlayerAchievements
	{
		// Token: 0x0600A8B5 RID: 43189 RVA: 0x0004118C File Offset: 0x0003F38C
		[Token(Token = "0x600A8B5")]
		[Address(RVA = "0x1AEB1D0", Offset = "0x1AEA5D0", VA = "0x181AEB1D0")]
		public bool isUnlocked(uint achievementID)
		{
			return default(bool);
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8B6")]
		[Address(RVA = "0x1AEAE20", Offset = "0x1AEA220", VA = "0x181AEAE20")]
		public void Unlock(uint achievementID)
		{
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8B7")]
		[Address(RVA = "0x1AEB030", Offset = "0x1AEA430", VA = "0x181AEB030")]
		public void WriteToMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8B8")]
		[Address(RVA = "0x1AEACC0", Offset = "0x1AEA0C0", VA = "0x181AEACC0")]
		public void ReadFromMasterServerClientSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8B9")]
		[Address(RVA = "0x1AEAD70", Offset = "0x1AEA170", VA = "0x181AEAD70")]
		public void ReadFromMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8BA RID: 43194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8BA")]
		[Address(RVA = "0x1AEAE90", Offset = "0x1AEA290", VA = "0x181AEAE90")]
		public void WriteToClientFromGameServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8BB")]
		[Address(RVA = "0x1AEABD0", Offset = "0x1AE9FD0", VA = "0x181AEABD0")]
		public void ReadFromGameServerClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8BC")]
		[Address(RVA = "0x1AEB160", Offset = "0x1AEA560", VA = "0x181AEB160")]
		public PlayerAchievements()
		{
		}

		// Token: 0x04001D76 RID: 7542
		[Token(Token = "0x4001D76")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		private HashSet<uint> active;
	}

	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	public class PlayerSelections
	{
		// Token: 0x0600A8BD RID: 43197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8BD")]
		[Address(RVA = "0x1AEF300", Offset = "0x1AEE700", VA = "0x181AEF300")]
		public PlayerSelections()
		{
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x000411A4 File Offset: 0x0003F3A4
		[Token(Token = "0x600A8BE")]
		[Address(RVA = "0x1AEEDD0", Offset = "0x1AEE1D0", VA = "0x181AEEDD0")]
		public static int ToKey(\u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 nation, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 role)
		{
			return 0;
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8BF")]
		[Address(RVA = "0x1AEEDE0", Offset = "0x1AEE1E0", VA = "0x181AEEDE0")]
		public static void ToValues(int key, out \u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 nation, out \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 role)
		{
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600A8C0")]
		[Address(RVA = "0x1AEE340", Offset = "0x1AED740", VA = "0x181AEE340")]
		public \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306 GetAttachments(ushort toolID)
		{
			return null;
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600A8C1")]
		[Address(RVA = "0x1AEE430", Offset = "0x1AED830", VA = "0x181AEE430")]
		public \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 GetLoadout(\u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 nation, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 role)
		{
			return null;
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600A8C2")]
		[Address(RVA = "0x1AEE590", Offset = "0x1AED990", VA = "0x181AEE590")]
		public \u0303\u0305\u0304\u0304\u0301\u0301\u0302\u0301\u0302\u0306\u0306\u0306\u0308\u0304\u0306 GetWearings(\u0303\u0303\u0302\u0307\u0307\u0301\u0304\u0301\u0302\u0303\u0305\u0306\u0308\u0305\u0306 nation, \u0306\u0302\u0307\u0306\u0303\u0308\u0301\u0308\u0304\u0307\u0301\u0304\u0307\u0308\u0304 role)
		{
			return null;
		}

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8C3")]
		[Address(RVA = "0x1AEE680", Offset = "0x1AEDA80", VA = "0x181AEE680")]
		private void Pack()
		{
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8C4")]
		[Address(RVA = "0x1AEEDF0", Offset = "0x1AEE1F0", VA = "0x181AEEDF0")]
		private void Unpack()
		{
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8C5")]
		[Address(RVA = "0x1AEDFE0", Offset = "0x1AED3E0", VA = "0x181AEDFE0")]
		public void Check(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client)
		{
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8C6")]
		[Address(RVA = "0x1AEF2A0", Offset = "0x1AEE6A0", VA = "0x181AEF2A0")]
		public void WriteToMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8C7")]
		[Address(RVA = "0x1AEED80", Offset = "0x1AEE180", VA = "0x181AEED80")]
		public void ReadFromMasterServerClientSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8C8")]
		[Address(RVA = "0x1AEED80", Offset = "0x1AEE180", VA = "0x181AEED80")]
		public void ReadFromMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8C9")]
		[Address(RVA = "0x1AEF1D0", Offset = "0x1AEE5D0", VA = "0x181AEF1D0")]
		public void WriteToClientFromGameServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8CA RID: 43210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8CA")]
		[Address(RVA = "0x1AEED00", Offset = "0x1AEE100", VA = "0x181AEED00")]
		public void ReadFromGameServerClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8CB RID: 43211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8CB")]
		[Address(RVA = "0x1AEF230", Offset = "0x1AEE630", VA = "0x181AEF230")]
		public void WriteToGameServerFromClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8CC RID: 43212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8CC")]
		[Address(RVA = "0x1AEEC90", Offset = "0x1AEE090", VA = "0x181AEEC90")]
		public void ReadFromClientFromGameServerSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8CD RID: 43213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8CD")]
		[Address(RVA = "0x1AEE2B0", Offset = "0x1AED6B0", VA = "0x181AEE2B0")]
		public void Clear()
		{
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x1700067B")]
		public static \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 CurrentLoadout
		{
			[Token(Token = "0x600A8CE")]
			[Address(RVA = "0x1AEF3F0", Offset = "0x1AEE7F0", VA = "0x181AEF3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600A8CF RID: 43215 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x1700067C")]
		public static \u0303\u0305\u0304\u0304\u0301\u0301\u0302\u0301\u0302\u0306\u0306\u0306\u0308\u0304\u0306 CurrentWearings
		{
			[Token(Token = "0x600A8CF")]
			[Address(RVA = "0x1AEF640", Offset = "0x1AEEA40", VA = "0x181AEF640")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001D77 RID: 7543
		[Token(Token = "0x4001D77")]
		private const int CurrentAttachmentsVersion = 1;

		// Token: 0x04001D78 RID: 7544
		[Token(Token = "0x4001D78")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		private Dictionary<ushort, \u0303\u0307\u0306\u0302\u0301\u0304\u0308\u0301\u0305\u0308\u0302\u0302\u0304\u0307\u0306> mAttachments;

		// Token: 0x04001D79 RID: 7545
		[Token(Token = "0x4001D79")]
		private const int CurrentLoadoutVersion = 1;

		// Token: 0x04001D7A RID: 7546
		[Token(Token = "0x4001D7A")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		private Dictionary<int, \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308> mLoadouts;

		// Token: 0x04001D7B RID: 7547
		[Token(Token = "0x4001D7B")]
		private const int CurrentWearingsVersion = 3;

		// Token: 0x04001D7C RID: 7548
		[Token(Token = "0x4001D7C")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		private Dictionary<int, \u0303\u0305\u0304\u0304\u0301\u0301\u0302\u0301\u0302\u0306\u0306\u0306\u0308\u0304\u0306> mWearings;

		// Token: 0x04001D7D RID: 7549
		[Token(Token = "0x4001D7D")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public byte[] Data;
	}

	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	public class PlayerInventory
	{
		// Token: 0x0600A8D0 RID: 43216 RVA: 0x000411BC File Offset: 0x0003F3BC
		[Token(Token = "0x600A8D0")]
		[Address(RVA = "0x1AEB500", Offset = "0x1AEA900", VA = "0x181AEB500")]
		public bool Has(string item, bool defaultValue = true)
		{
			return default(bool);
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D1")]
		[Address(RVA = "0x1AEBB80", Offset = "0x1AEAF80", VA = "0x181AEBB80")]
		public void WriteToMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 stream)
		{
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D2")]
		[Address(RVA = "0x1AEB750", Offset = "0x1AEAB50", VA = "0x181AEB750")]
		public void ReadFromMasterServerClientSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D3")]
		[Address(RVA = "0x1AEB820", Offset = "0x1AEAC20", VA = "0x181AEB820")]
		public void ReadFromMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D4")]
		[Address(RVA = "0x1AEB8F0", Offset = "0x1AEACF0", VA = "0x181AEB8F0")]
		public void WriteToClientFromGameServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 stream)
		{
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D5")]
		[Address(RVA = "0x1AEB590", Offset = "0x1AEA990", VA = "0x181AEB590")]
		public void ReadFromGameServerClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D6")]
		[Address(RVA = "0x1AEBCC0", Offset = "0x1AEB0C0", VA = "0x181AEBCC0")]
		public PlayerInventory()
		{
		}

		// Token: 0x04001D7E RID: 7550
		[Token(Token = "0x4001D7E")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		public HashSet<string> Items;
	}

	// Token: 0x020003E7 RID: 999
	[Token(Token = "0x20003E7")]
	public class PlayerClan
	{
		// Token: 0x0600A8D7 RID: 43223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D7")]
		[Address(RVA = "0x1AEB430", Offset = "0x1AEA830", VA = "0x181AEB430")]
		public void WriteToMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D8")]
		[Address(RVA = "0x1AEB2F0", Offset = "0x1AEA6F0", VA = "0x181AEB2F0")]
		public void ReadFromMasterServerClientSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8D9")]
		[Address(RVA = "0x1AEB2F0", Offset = "0x1AEA6F0", VA = "0x181AEB2F0")]
		public void ReadFromMasterServerGameServerSide(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 ser)
		{
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8DA")]
		[Address(RVA = "0x1AEB360", Offset = "0x1AEA760", VA = "0x181AEB360")]
		public void WriteToClientFromGameServer(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8DB")]
		[Address(RVA = "0x1AEB230", Offset = "0x1AEA630", VA = "0x181AEB230")]
		public void ReadFromGameServerClientSide(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600A8DC RID: 43228 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x1700067D")]
		public \u0305\u0305\u0306\u0301\u0305\u0306\u0308\u0306\u0305\u0301\u0303\u0304\u0308\u0304\u0302 Clan
		{
			[Token(Token = "0x600A8DC")]
			[Address(RVA = "0x1AEB490", Offset = "0x1AEA890", VA = "0x181AEB490")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8DD")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		public void Reset()
		{
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8DE")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public PlayerClan()
		{
		}

		// Token: 0x04001D7F RID: 7551
		[Token(Token = "0x4001D7F")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		public bool inClan;

		// Token: 0x04001D80 RID: 7552
		[Token(Token = "0x4001D80")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		public ulong ClanID;

		// Token: 0x04001D81 RID: 7553
		[Token(Token = "0x4001D81")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public \u0308\u0302\u0304\u0306\u0304\u0305\u0306\u0308\u0301\u0305\u0308\u0306\u0302\u0304\u0305 ClanRank;
	}

	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	public struct Pint
	{
		// Token: 0x0600A8DF RID: 43231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8DF")]
		[Address(RVA = "0x1AEAAF0", Offset = "0x1AE9EF0", VA = "0x181AEAAF0")]
		public void Increment(int value = 1)
		{
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x000411D4 File Offset: 0x0003F3D4
		[Token(Token = "0x1700067E")]
		public uint Value
		{
			[Token(Token = "0x600A8E0")]
			[Address(RVA = "0x1AEABB0", Offset = "0x1AE9FB0", VA = "0x181AEABB0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x000411EC File Offset: 0x0003F3EC
		[Token(Token = "0x600A8E1")]
		[Address(RVA = "0x1AEABC0", Offset = "0x1AE9FC0", VA = "0x181AEABC0")]
		public static implicit operator uint(PlayerStats.Pint v)
		{
			return 0U;
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x00041204 File Offset: 0x0003F404
		[Token(Token = "0x600A8E2")]
		[Address(RVA = "0xB6A480", Offset = "0xB69880", VA = "0x180B6A480")]
		public static implicit operator PlayerStats.Pint(uint v)
		{
			return default(PlayerStats.Pint);
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x600A8E3")]
		[Address(RVA = "0x1AEAB10", Offset = "0x1AE9F10", VA = "0x181AEAB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600A8E4")]
		[Address(RVA = "0x1AEAB00", Offset = "0x1AE9F00", VA = "0x181AEAB00")]
		public void Reset()
		{
		}

		// Token: 0x04001D82 RID: 7554
		[Token(Token = "0x4001D82")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public uint Base;

		// Token: 0x04001D83 RID: 7555
		[Token(Token = "0x4001D83")]
		[touching_your_mom.FieldOffset(Offset = "0x4")]
		public uint Additional;
	}
}
