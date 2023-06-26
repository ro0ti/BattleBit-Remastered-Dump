using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using touching_your_mom;
using Steamworks;
using UnityEngine;

namespace MasterClient
{
	// Token: 0x020006D8 RID: 1752
	[Token(Token = "0x20006D8")]
	public class MasterServerConnectionPlayer
	{
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060129BB RID: 76219 RVA: 0x0007415C File Offset: 0x0007235C
		// (set) Token: 0x060129BC RID: 76220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A4E")]
		public static bool UnableToRetriveTicket
		{
			[Token(Token = "0x60129BB")]
			[Address(RVA = "0x2F4FF00", Offset = "0x2F4F300", VA = "0x182F4FF00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60129BC")]
			[Address(RVA = "0x2F510F0", Offset = "0x2F504F0", VA = "0x182F510F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060129BD RID: 76221 RVA: 0x00074174 File Offset: 0x00072374
		// (set) Token: 0x060129BE RID: 76222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A4F")]
		public static bool IsSteamDown
		{
			[Token(Token = "0x60129BD")]
			[Address(RVA = "0x2F4FE40", Offset = "0x2F4F240", VA = "0x182F4FE40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60129BE")]
			[Address(RVA = "0x2F51060", Offset = "0x2F50460", VA = "0x182F51060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060129BF RID: 76223 RVA: 0x0007418C File Offset: 0x0007238C
		// (set) Token: 0x060129C0 RID: 76224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A50")]
		public static bool IsAccountNew
		{
			[Token(Token = "0x60129BF")]
			[Address(RVA = "0x2F4FD80", Offset = "0x2F4F180", VA = "0x182F4FD80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60129C0")]
			[Address(RVA = "0x2F50FE0", Offset = "0x2F503E0", VA = "0x182F50FE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060129C1 RID: 76225 RVA: 0x000741A4 File Offset: 0x000723A4
		// (set) Token: 0x060129C2 RID: 76226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A51")]
		public static bool FamilyShareNotSupported
		{
			[Token(Token = "0x60129C1")]
			[Address(RVA = "0x2F4FD00", Offset = "0x2F4F100", VA = "0x182F4FD00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60129C2")]
			[Address(RVA = "0x2F50F60", Offset = "0x2F50360", VA = "0x182F50F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060129C3 RID: 76227 RVA: 0x000741BC File Offset: 0x000723BC
		// (set) Token: 0x060129C4 RID: 76228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A52")]
		public static bool IsDemandingForGameServer
		{
			[Token(Token = "0x60129C3")]
			[Address(RVA = "0x2F4FDC0", Offset = "0x2F4F1C0", VA = "0x182F4FDC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60129C4")]
			[Address(RVA = "0x2F51020", Offset = "0x2F50420", VA = "0x182F51020")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060129C5 RID: 76229 RVA: 0x000741D4 File Offset: 0x000723D4
		// (set) Token: 0x060129C6 RID: 76230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A53")]
		public static float LastDemandGameServer
		{
			[Token(Token = "0x60129C5")]
			[Address(RVA = "0x2F4FE80", Offset = "0x2F4F280", VA = "0x182F4FE80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60129C6")]
			[Address(RVA = "0x2F510A0", Offset = "0x2F504A0", VA = "0x182F510A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060129C7 RID: 76231 RVA: 0x000741EC File Offset: 0x000723EC
		// (set) Token: 0x060129C8 RID: 76232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A54")]
		public static bool HasToken
		{
			[Token(Token = "0x60129C7")]
			[Address(RVA = "0x2F4FD40", Offset = "0x2F4F140", VA = "0x182F4FD40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60129C8")]
			[Address(RVA = "0x2F50FA0", Offset = "0x2F503A0", VA = "0x182F50FA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060129C9 RID: 76233 RVA: 0x00074204 File Offset: 0x00072404
		[Token(Token = "0x17000A55")]
		public bool IsRequesting
		{
			[Token(Token = "0x60129C9")]
			[Address(RVA = "0x2F4FE00", Offset = "0x2F4F200", VA = "0x182F4FE00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060129CA RID: 76234 RVA: 0x0007421C File Offset: 0x0007241C
		[Token(Token = "0x17000A56")]
		public int NumbersOfRequests
		{
			[Token(Token = "0x60129CA")]
			[Address(RVA = "0x2F4FEC0", Offset = "0x2F4F2C0", VA = "0x182F4FEC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060129CB RID: 76235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129CB")]
		[Address(RVA = "0x2F4FBE0", Offset = "0x2F4EFE0", VA = "0x182F4FBE0")]
		public MasterServerConnectionPlayer()
		{
		}

		// Token: 0x060129CC RID: 76236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129CC")]
		[Address(RVA = "0x2F4F820", Offset = "0x2F4EC20", VA = "0x182F4F820")]
		public void Update()
		{
		}

		// Token: 0x060129CD RID: 76237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129CD")]
		[Address(RVA = "0x2F4D170", Offset = "0x2F4C570", VA = "0x182F4D170")]
		public void RequestStats(Action<PlayerStats, \u0308\u0302\u0308\u0302\u0303\u0302\u0307\u0305\u0305\u0302\u0304\u0304\u0302\u0304\u0304> OnStatsReceived)
		{
		}

		// Token: 0x060129CE RID: 76238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129CE")]
		[Address(RVA = "0x2F4D050", Offset = "0x2F4C450", VA = "0x182F4D050")]
		public void RequestServerList(Action<DateTime, List<\u0306\u0304\u0301\u0306\u0304\u0301\u0305\u0301\u0308\u0305\u0304\u0303\u0303\u0303\u0301>> OnServerListReceived)
		{
		}

		// Token: 0x060129CF RID: 76239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129CF")]
		[Address(RVA = "0x2F4D670", Offset = "0x2F4CA70", VA = "0x182F4D670")]
		public void RequestToCreateClan(string ClanName, string ClanTag, Color color, byte[] photo, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129D0 RID: 76240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D0")]
		[Address(RVA = "0x2F4D3E0", Offset = "0x2F4C7E0", VA = "0x182F4D3E0")]
		public void RequestToCreateClan(string ClanName, string ClanTag, Color color, string filePath, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129D1 RID: 76241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D1")]
		[Address(RVA = "0x2F4DE30", Offset = "0x2F4D230", VA = "0x182F4DE30")]
		public void RequestToLeaveClan(Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129D2 RID: 76242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D2")]
		[Address(RVA = "0x2F4D840", Offset = "0x2F4CC40", VA = "0x182F4D840")]
		public void RequestToCreateInviteCode(DateTime expire, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305, \u0302\u0307\u0303\u0305\u0303\u0302\u0304\u0308\u0307\u0308\u0301\u0306\u0301\u0302\u0306> OnResponseReceived)
		{
		}

		// Token: 0x060129D3 RID: 76243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D3")]
		[Address(RVA = "0x2F4E3E0", Offset = "0x2F4D7E0", VA = "0x182F4E3E0")]
		public void RequestToSetClanMemberRank(ulong targetSteamID, \u0308\u0302\u0304\u0306\u0304\u0305\u0306\u0308\u0301\u0305\u0308\u0306\u0302\u0304\u0305 rank, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129D4 RID: 76244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D4")]
		[Address(RVA = "0x2F4DBD0", Offset = "0x2F4CFD0", VA = "0x182F4DBD0")]
		public void RequestToJoinClanWithInviteCode(byte[] code, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129D5 RID: 76245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D5")]
		[Address(RVA = "0x2F4C8B0", Offset = "0x2F4BCB0", VA = "0x182F4C8B0")]
		public void RequestMembersOfClan(Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305, List<\u0305\u0305\u0306\u0303\u0303\u0301\u0308\u0303\u0308\u0305\u0302\u0308\u0308\u0304\u0303>> OnResponseReceived)
		{
		}

		// Token: 0x060129D6 RID: 76246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D6")]
		[Address(RVA = "0x2F4C4E0", Offset = "0x2F4B8E0", VA = "0x182F4C4E0")]
		public void RequestClanInfo(ulong clanID, Action<\u0305\u0305\u0306\u0301\u0305\u0306\u0308\u0306\u0305\u0301\u0303\u0304\u0308\u0304\u0302> OnResponseReceived)
		{
		}

		// Token: 0x060129D7 RID: 76247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D7")]
		[Address(RVA = "0x2F4DD10", Offset = "0x2F4D110", VA = "0x182F4DD10")]
		public void RequestToKick(ulong steamID, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129D8 RID: 76248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D8")]
		[Address(RVA = "0x2F4DAC0", Offset = "0x2F4CEC0", VA = "0x182F4DAC0")]
		public void RequestToGetAllInviteCodes(Action<List<\u0302\u0307\u0303\u0305\u0303\u0302\u0304\u0308\u0307\u0308\u0301\u0306\u0301\u0302\u0306>> OnResponseReceived)
		{
		}

		// Token: 0x060129D9 RID: 76249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129D9")]
		[Address(RVA = "0x2F4D980", Offset = "0x2F4CD80", VA = "0x182F4D980")]
		public void RequestToDeleteInviteCode(byte[] code, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129DA RID: 76250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129DA")]
		[Address(RVA = "0x2F4E520", Offset = "0x2F4D920", VA = "0x182F4E520")]
		public void RequestToUpdateClanColor(Color newColor, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129DB RID: 76251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129DB")]
		[Address(RVA = "0x2F4E8A0", Offset = "0x2F4DCA0", VA = "0x182F4E8A0")]
		public void RequestToUpdateClanPhoto(string filePath, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129DC RID: 76252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129DC")]
		[Address(RVA = "0x2F4E650", Offset = "0x2F4DA50", VA = "0x182F4E650")]
		public void RequestToUpdateClanPhoto(byte[] photo, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129DD RID: 76253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129DD")]
		[Address(RVA = "0x2F4DF40", Offset = "0x2F4D340", VA = "0x182F4DF40")]
		public void RequestToPrestigeUp(Action<bool> OnResponseReceived)
		{
		}

		// Token: 0x060129DE RID: 76254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129DE")]
		[Address(RVA = "0x2F4E180", Offset = "0x2F4D580", VA = "0x182F4E180")]
		public void RequestToRefreshInventory(Action OnResponseReceived)
		{
		}

		// Token: 0x060129DF RID: 76255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129DF")]
		[Address(RVA = "0x2F4E050", Offset = "0x2F4D450", VA = "0x182F4E050")]
		public void RequestToRedeemCode(ulong a, ulong b, Action<string> OnResponseReceived)
		{
		}

		// Token: 0x060129E0 RID: 76256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E0")]
		[Address(RVA = "0x2F4E290", Offset = "0x2F4D690", VA = "0x182F4E290")]
		public void RequestToReportPlayer(ulong steamID, \u0304\u0308\u0305\u0307\u0304\u0302\u0306\u0306\u0307\u0304\u0303\u0303\u0304\u0308\u0301 reason, string userText, Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived)
		{
		}

		// Token: 0x060129E1 RID: 76257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E1")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		public void RequestToReportPlayerServer()
		{
		}

		// Token: 0x060129E2 RID: 76258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E2")]
		[Address(RVA = "0x2F4CCF0", Offset = "0x2F4C0F0", VA = "0x182F4CCF0")]
		public void RequestPlayerReports(ulong steamID, Action<List<\u0304\u0302\u0301\u0306\u0303\u0302\u0303\u0305\u0306\u0305\u0305\u0301\u0307\u0304\u0306>> OnReportsReceived)
		{
		}

		// Token: 0x060129E3 RID: 76259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E3")]
		[Address(RVA = "0x2F4CF30", Offset = "0x2F4C330", VA = "0x182F4CF30")]
		public void RequestRegisterDiscordID(string token, Action<bool, \u0304\u0307\u0306\u0305\u0305\u0304\u0308\u0305\u0302\u0304\u0308\u0303\u0306\u0303\u0304> OnReceivedResponse)
		{
		}

		// Token: 0x060129E4 RID: 76260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E4")]
		[Address(RVA = "0x2F4EAD0", Offset = "0x2F4DED0", VA = "0x182F4EAD0")]
		public void RequestUnlinkDiscord(Action OnReceivedResponse)
		{
		}

		// Token: 0x060129E5 RID: 76261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E5")]
		[Address(RVA = "0x2F4EBE0", Offset = "0x2F4DFE0", VA = "0x182F4EBE0")]
		public void RequestUnlinkTwitch(Action OnReceivedResponse)
		{
		}

		// Token: 0x060129E6 RID: 76262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E6")]
		[Address(RVA = "0x2F4D280", Offset = "0x2F4C680", VA = "0x182F4D280")]
		public void RequestToBan(ulong steamID, DateTime until, string reason, \u0304\u0301\u0308\u0308\u0306\u0303\u0306\u0301\u0301\u0304\u0308\u0306\u0307\u0306\u0308 reasonID, Action<bool, \u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnReceivedResponse)
		{
		}

		// Token: 0x060129E7 RID: 76263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E7")]
		[Address(RVA = "0x2F4C9C0", Offset = "0x2F4BDC0", VA = "0x182F4C9C0")]
		public void RequestMyBan(Action<bool, DateTime, string> OnReceivedResponse)
		{
		}

		// Token: 0x060129E8 RID: 76264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E8")]
		[Address(RVA = "0x2F4CAD0", Offset = "0x2F4BED0", VA = "0x182F4CAD0")]
		public void RequestMyTimeout(Action<bool, string> OnReceivedResponse)
		{
		}

		// Token: 0x060129E9 RID: 76265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129E9")]
		[Address(RVA = "0x2F4E9A0", Offset = "0x2F4DDA0", VA = "0x182F4E9A0")]
		public void RequestToWarn(ulong steamID, string comment, Action<bool> OnReceivedResponse)
		{
		}

		// Token: 0x060129EA RID: 76266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129EA")]
		[Address(RVA = "0x2F4CE10", Offset = "0x2F4C210", VA = "0x182F4CE10")]
		public void RequestPlayerWarns(ulong steamID, Action<List<\u0308\u0306\u0308\u0304\u0305\u0307\u0306\u0303\u0305\u0307\u0301\u0307\u0307\u0303\u0303>> OnWarnsReceived)
		{
		}

		// Token: 0x060129EB RID: 76267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129EB")]
		[Address(RVA = "0x2F4C110", Offset = "0x2F4B510", VA = "0x182F4C110")]
		public void GetNews(Action<\u0304\u0308\u0301\u0306\u0305\u0301\u0301\u0306\u0307\u0306\u0301\u0305\u0301\u0303\u0308> OnNewReceived)
		{
		}

		// Token: 0x060129EC RID: 76268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129EC")]
		[Address(RVA = "0x2F4C400", Offset = "0x2F4B800", VA = "0x182F4C400")]
		public void ReportLog(string log)
		{
		}

		// Token: 0x060129ED RID: 76269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129ED")]
		[Address(RVA = "0x2F4C220", Offset = "0x2F4B620", VA = "0x182F4C220")]
		public void GetPublicKeyForGameServer(IPEndPoint serverEP, Action<\u0301\u0305\u0303\u0303\u0308\u0304\u0305\u0305\u0303\u0303\u0303\u0308\u0304\u0306\u0305> OnPublicKeyReceived)
		{
		}

		// Token: 0x060129EE RID: 76270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129EE")]
		[Address(RVA = "0x2F4C610", Offset = "0x2F4BA10", VA = "0x182F4C610")]
		public void RequestDemandForGameServer(\u0306\u0302\u0302\u0302\u0305\u0304\u0307\u0303\u0306\u0307\u0306\u0301\u0303\u0307\u0306 region, \u0308\u0302\u0303\u0304\u0302\u0307\u0306\u0304\u0306\u0302\u0302\u0303\u0307\u0301\u0307 size, bool isAfk, \u0308\u0308\u0302\u0303\u0303\u0305\u0308\u0305\u0306\u0301\u0305\u0308\u0303\u0303\u0302 page, Action<int, int> OnServerCountReceived)
		{
		}

		// Token: 0x060129EF RID: 76271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129EF")]
		[Address(RVA = "0x2F4ECF0", Offset = "0x2F4E0F0", VA = "0x182F4ECF0")]
		public void StopDemandForGameServer()
		{
		}

		// Token: 0x060129F0 RID: 76272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F0")]
		[Address(RVA = "0x2F4CBE0", Offset = "0x2F4BFE0", VA = "0x182F4CBE0")]
		public void RequestPingServers(Action<Dictionary<\u0306\u0302\u0302\u0302\u0305\u0304\u0307\u0303\u0306\u0307\u0306\u0301\u0303\u0307\u0306, List<IPAddress>>> OnReceivedResponse)
		{
		}

		// Token: 0x060129F1 RID: 76273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F1")]
		[Address(RVA = "0x2F4FA40", Offset = "0x2F4EE40", VA = "0x182F4FA40")]
		public void VoiceTransmit(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 pck)
		{
		}

		// Token: 0x060129F2 RID: 76274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F2")]
		[Address(RVA = "0x2F4C000", Offset = "0x2F4B400", VA = "0x182F4C000")]
		public void GetEventState(Action<\u0302\u0302\u0308\u0301\u0307\u0305\u0304\u0302\u0306\u0308\u0306\u0301\u0302\u0307\u0308> OnEventStateReceived)
		{
		}

		// Token: 0x060129F3 RID: 76275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F3")]
		[Address(RVA = "0x2F50440", Offset = "0x2F4F840", VA = "0x182F50440")]
		private void mRefreshToken()
		{
		}

		// Token: 0x060129F4 RID: 76276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F4")]
		[Address(RVA = "0x2F50A60", Offset = "0x2F4FE60", VA = "0x182F50A60")]
		private void mSendAndWaitForResponseNoToken(string url, \u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 package, Action<\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303> onRead)
		{
		}

		// Token: 0x060129F5 RID: 76277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F5")]
		[Address(RVA = "0x2F50B90", Offset = "0x2F4FF90", VA = "0x182F50B90")]
		private void mSendAndWaitForResponse(string url, \u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 package, Action<\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308> onRead)
		{
		}

		// Token: 0x060129F6 RID: 76278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F6")]
		[Address(RVA = "0x2F50DD0", Offset = "0x2F501D0", VA = "0x182F50DD0")]
		private void mSendRequest(MasterServerConnectionPlayer.mRequest request, bool writeToken)
		{
		}

		// Token: 0x060129F7 RID: 76279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129F7")]
		[Address(RVA = "0x2F50CC0", Offset = "0x2F500C0", VA = "0x182F50CC0")]
		private void mSendRequestNoToken(MasterServerConnectionPlayer.mRequestNoToken request)
		{
		}

		// Token: 0x060129F8 RID: 76280 RVA: 0x00074234 File Offset: 0x00072434
		[Token(Token = "0x60129F8")]
		[Address(RVA = "0x2F50110", Offset = "0x2F4F510", VA = "0x182F50110")]
		private bool mHandleOutgoingRequestResponse(MasterServerConnectionPlayer.mRequest request, bool writeToken)
		{
			return default(bool);
		}

		// Token: 0x060129F9 RID: 76281 RVA: 0x0007424C File Offset: 0x0007244C
		[Token(Token = "0x60129F9")]
		[Address(RVA = "0x2F4FF40", Offset = "0x2F4F340", VA = "0x182F4FF40")]
		private bool mHandleOutgoingNoTokenRequestResponse(MasterServerConnectionPlayer.mRequestNoToken request)
		{
			return default(bool);
		}

		// Token: 0x060129FA RID: 76282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129FA")]
		[Address(RVA = "0x2F4BFE0", Offset = "0x2F4B3E0", VA = "0x182F4BFE0")]
		public void AddCooldown(float time)
		{
		}

		// Token: 0x060129FB RID: 76283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129FB")]
		[Address(RVA = "0x2F4BFF0", Offset = "0x2F4B3F0", VA = "0x182F4BFF0")]
		public void AddNonTokenRequestCooldown(float time)
		{
		}

		// Token: 0x060129FC RID: 76284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129FC")]
		[Address(RVA = "0x2F503D0", Offset = "0x2F4F7D0", VA = "0x182F503D0")]
		private void mLog(string log)
		{
		}

		// Token: 0x060129FD RID: 76285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60129FD")]
		[Address(RVA = "0x2F50360", Offset = "0x2F4F760", VA = "0x182F50360")]
		private void mLogError(string log)
		{
		}

		// Token: 0x060129FE RID: 76286 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60129FE")]
		[Address(RVA = "0x2F4EF00", Offset = "0x2F4E300", VA = "0x182F4EF00")]
		public static string ToHex(byte[] buffer, int offset, int length)
		{
			return null;
		}

		// Token: 0x060129FF RID: 76287 RVA: 0x00074264 File Offset: 0x00072464
		[Token(Token = "0x60129FF")]
		[Address(RVA = "0xE13200", Offset = "0xE12600", VA = "0x180E13200")]
		private static char GetHexValue(int i)
		{
			return '\0';
		}

		// Token: 0x06012A00 RID: 76288 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6012A00")]
		[Address(RVA = "0x2F4C350", Offset = "0x2F4B750", VA = "0x182F4C350")]
		public static byte[] Hash(string str)
		{
			return null;
		}

		// Token: 0x06012A01 RID: 76289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012A01")]
		[Address(RVA = "0x2F4F030", Offset = "0x2F4E430", VA = "0x182F4F030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private void <mRefreshToken>b__89_0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
		{
		}

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x0")]
		public static ulong BuildID;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x8")]
		public static uint PlaytimeSeconds;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <UnableToRetriveTicket>k__BackingField;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0xD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <IsSteamDown>k__BackingField;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0xE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <IsAccountNew>k__BackingField;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0xF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <FamilyShareNotSupported>k__BackingField;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <IsDemandingForGameServer>k__BackingField;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static float <LastDemandGameServer>k__BackingField;

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <HasToken>k__BackingField;

		// Token: 0x040033B3 RID: 13235
		[Token(Token = "0x40033B3")]
		private const string Domain = "https://api.battlebit.cloud/";

		// Token: 0x040033B4 RID: 13236
		[Token(Token = "0x40033B4")]
		private const int MaxReportSize = 2000;

		// Token: 0x040033B5 RID: 13237
		[Token(Token = "0x40033B5")]
		private const float GameServerDemandTimeout = 5f;

		// Token: 0x040033B6 RID: 13238
		[Token(Token = "0x40033B6")]
		[FieldOffset(Offset = "0x10")]
		private Queue<MasterServerConnectionPlayer.mRequestNoToken> mQueuedNoTokenRequests;

		// Token: 0x040033B7 RID: 13239
		[Token(Token = "0x40033B7")]
		[FieldOffset(Offset = "0x18")]
		private Queue<MasterServerConnectionPlayer.mRequest> mQueuedRequests;

		// Token: 0x040033B8 RID: 13240
		[Token(Token = "0x40033B8")]
		[FieldOffset(Offset = "0x20")]
		private \u0306\u0302\u0302\u0302\u0305\u0304\u0307\u0303\u0306\u0307\u0306\u0301\u0303\u0307\u0306 Region;

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0x28")]
		private MasterServerConnectionPlayer.mRequest mTokenRequest;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[FieldOffset(Offset = "0x30")]
		private ulong mServerToken;

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0x38")]
		private long mServerTokenAliveUntilMs;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0x40")]
		private ulong mServerTokenBuild;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0x48")]
		private Task<AuthTicket> mAuthTicket;

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[FieldOffset(Offset = "0x50")]
		private float mCooldown;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[FieldOffset(Offset = "0x54")]
		private float mNonTokenCooldown;

		// Token: 0x040033C0 RID: 13248
		[Token(Token = "0x40033C0")]
		[FieldOffset(Offset = "0x58")]
		private List<\u0306\u0304\u0301\u0306\u0304\u0301\u0305\u0301\u0308\u0305\u0304\u0303\u0303\u0303\u0301> mServerList;

		// Token: 0x040033C1 RID: 13249
		[Token(Token = "0x40033C1")]
		[FieldOffset(Offset = "0x60")]
		private Queue<string> mReportLogQueue;

		// Token: 0x020006D9 RID: 1753
		[Token(Token = "0x20006D9")]
		private class mRequest
		{
			// Token: 0x06012A02 RID: 76290 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A02")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public mRequest()
			{
			}

			// Token: 0x040033C2 RID: 13250
			[Token(Token = "0x40033C2")]
			[FieldOffset(Offset = "0x10")]
			public string URL;

			// Token: 0x040033C3 RID: 13251
			[Token(Token = "0x40033C3")]
			[FieldOffset(Offset = "0x18")]
			public \u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 OutgoingPackage;

			// Token: 0x040033C4 RID: 13252
			[Token(Token = "0x40033C4")]
			[FieldOffset(Offset = "0x20")]
			public Action<\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308> OnReadIncomingPackage;

			// Token: 0x040033C5 RID: 13253
			[Token(Token = "0x40033C5")]
			[FieldOffset(Offset = "0x28")]
			public Task<WebRequestResponse> WebRequest;

			// Token: 0x040033C6 RID: 13254
			[Token(Token = "0x40033C6")]
			[FieldOffset(Offset = "0x30")]
			public double WebRequestSendTime;
		}

		// Token: 0x020006DA RID: 1754
		[Token(Token = "0x20006DA")]
		private class mRequestNoToken
		{
			// Token: 0x06012A03 RID: 76291 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A03")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public mRequestNoToken()
			{
			}

			// Token: 0x040033C7 RID: 13255
			[Token(Token = "0x40033C7")]
			[FieldOffset(Offset = "0x10")]
			public string URL;

			// Token: 0x040033C8 RID: 13256
			[Token(Token = "0x40033C8")]
			[FieldOffset(Offset = "0x18")]
			public \u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 OutgoingPackage;

			// Token: 0x040033C9 RID: 13257
			[Token(Token = "0x40033C9")]
			[FieldOffset(Offset = "0x20")]
			public Action<\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303> OnReadIncomingPackage;

			// Token: 0x040033CA RID: 13258
			[Token(Token = "0x40033CA")]
			[FieldOffset(Offset = "0x28")]
			public Task<WebRequestResponse> WebRequest;

			// Token: 0x040033CB RID: 13259
			[Token(Token = "0x40033CB")]
			[FieldOffset(Offset = "0x30")]
			public double WebRequestSendTime;
		}

		// Token: 0x020006DB RID: 1755
		[Token(Token = "0x20006DB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x06012A04 RID: 76292 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A04")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x06012A05 RID: 76293 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A05")]
			[Address(RVA = "0x2F51130", Offset = "0x2F50530", VA = "0x182F51130")]
			internal void <RequestStats>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033CC RID: 13260
			[Token(Token = "0x40033CC")]
			[FieldOffset(Offset = "0x10")]
			public Action<PlayerStats, \u0308\u0302\u0308\u0302\u0303\u0302\u0307\u0305\u0305\u0302\u0304\u0304\u0302\u0304\u0304> OnStatsReceived;
		}

		// Token: 0x020006DC RID: 1756
		[Token(Token = "0x20006DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x06012A06 RID: 76294 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A06")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x06012A07 RID: 76295 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A07")]
			[Address(RVA = "0x2F51210", Offset = "0x2F50610", VA = "0x182F51210")]
			internal void <RequestServerList>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033CD RID: 13261
			[Token(Token = "0x40033CD")]
			[FieldOffset(Offset = "0x10")]
			public MasterServerConnectionPlayer <>4__this;

			// Token: 0x040033CE RID: 13262
			[Token(Token = "0x40033CE")]
			[FieldOffset(Offset = "0x18")]
			public Action<DateTime, List<\u0306\u0304\u0301\u0306\u0304\u0301\u0305\u0301\u0308\u0305\u0304\u0303\u0303\u0303\u0301>> OnServerListReceived;
		}

		// Token: 0x020006DD RID: 1757
		[Token(Token = "0x20006DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06012A08 RID: 76296 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A08")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x06012A09 RID: 76297 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A09")]
			[Address(RVA = "0x2F51360", Offset = "0x2F50760", VA = "0x182F51360")]
			internal void <RequestToCreateClan>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033CF RID: 13263
			[Token(Token = "0x40033CF")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006DE RID: 1758
		[Token(Token = "0x20006DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass55_0
		{
			// Token: 0x06012A0A RID: 76298 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A0A")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass55_0()
			{
			}

			// Token: 0x06012A0B RID: 76299 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A0B")]
			[Address(RVA = "0x2F513E0", Offset = "0x2F507E0", VA = "0x182F513E0")]
			internal void <RequestToLeaveClan>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033D0 RID: 13264
			[Token(Token = "0x40033D0")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006DF RID: 1759
		[Token(Token = "0x20006DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x06012A0C RID: 76300 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A0C")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x06012A0D RID: 76301 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A0D")]
			[Address(RVA = "0x2F51460", Offset = "0x2F50860", VA = "0x182F51460")]
			internal void <RequestToCreateInviteCode>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033D1 RID: 13265
			[Token(Token = "0x40033D1")]
			[FieldOffset(Offset = "0x10")]
			public DateTime expire;

			// Token: 0x040033D2 RID: 13266
			[Token(Token = "0x40033D2")]
			[FieldOffset(Offset = "0x18")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305, \u0302\u0307\u0303\u0305\u0303\u0302\u0304\u0308\u0307\u0308\u0301\u0306\u0301\u0302\u0306> OnResponseReceived;
		}

		// Token: 0x020006E0 RID: 1760
		[Token(Token = "0x20006E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass57_0
		{
			// Token: 0x06012A0E RID: 76302 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A0E")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass57_0()
			{
			}

			// Token: 0x06012A0F RID: 76303 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A0F")]
			[Address(RVA = "0x2F51560", Offset = "0x2F50960", VA = "0x182F51560")]
			internal void <RequestToSetClanMemberRank>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033D3 RID: 13267
			[Token(Token = "0x40033D3")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006E1 RID: 1761
		[Token(Token = "0x20006E1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass58_0
		{
			// Token: 0x06012A10 RID: 76304 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A10")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass58_0()
			{
			}

			// Token: 0x06012A11 RID: 76305 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A11")]
			[Address(RVA = "0x1BF04D0", Offset = "0x1BEF8D0", VA = "0x181BF04D0")]
			internal void <RequestToJoinClanWithInviteCode>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033D4 RID: 13268
			[Token(Token = "0x40033D4")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006E2 RID: 1762
		[Token(Token = "0x20006E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x06012A12 RID: 76306 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A12")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x06012A13 RID: 76307 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A13")]
			[Address(RVA = "0x1BF0550", Offset = "0x1BEF950", VA = "0x181BF0550")]
			internal void <RequestMembersOfClan>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033D5 RID: 13269
			[Token(Token = "0x40033D5")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305, List<\u0305\u0305\u0306\u0303\u0303\u0301\u0308\u0303\u0308\u0305\u0302\u0308\u0308\u0304\u0303>> OnResponseReceived;
		}

		// Token: 0x020006E3 RID: 1763
		[Token(Token = "0x20006E3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass60_0
		{
			// Token: 0x06012A14 RID: 76308 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A14")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x06012A15 RID: 76309 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A15")]
			[Address(RVA = "0x1BF06F0", Offset = "0x1BEFAF0", VA = "0x181BF06F0")]
			internal void <RequestClanInfo>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033D6 RID: 13270
			[Token(Token = "0x40033D6")]
			[FieldOffset(Offset = "0x10")]
			public ulong clanID;

			// Token: 0x040033D7 RID: 13271
			[Token(Token = "0x40033D7")]
			[FieldOffset(Offset = "0x18")]
			public Action<\u0305\u0305\u0306\u0301\u0305\u0306\u0308\u0306\u0305\u0301\u0303\u0304\u0308\u0304\u0302> OnResponseReceived;

			// Token: 0x040033D8 RID: 13272
			[Token(Token = "0x40033D8")]
			[FieldOffset(Offset = "0x20")]
			public MasterServerConnectionPlayer <>4__this;
		}

		// Token: 0x020006E4 RID: 1764
		[Token(Token = "0x20006E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x06012A16 RID: 76310 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A16")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x06012A17 RID: 76311 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A17")]
			[Address(RVA = "0x1BF0880", Offset = "0x1BEFC80", VA = "0x181BF0880")]
			internal void <RequestToKick>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033D9 RID: 13273
			[Token(Token = "0x40033D9")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006E5 RID: 1765
		[Token(Token = "0x20006E5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x06012A18 RID: 76312 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A18")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass62_0()
			{
			}

			// Token: 0x06012A19 RID: 76313 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A19")]
			[Address(RVA = "0x1BF0900", Offset = "0x1BEFD00", VA = "0x181BF0900")]
			internal void <RequestToGetAllInviteCodes>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033DA RID: 13274
			[Token(Token = "0x40033DA")]
			[FieldOffset(Offset = "0x10")]
			public Action<List<\u0302\u0307\u0303\u0305\u0303\u0302\u0304\u0308\u0307\u0308\u0301\u0306\u0301\u0302\u0306>> OnResponseReceived;
		}

		// Token: 0x020006E6 RID: 1766
		[Token(Token = "0x20006E6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x06012A1A RID: 76314 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A1A")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x06012A1B RID: 76315 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A1B")]
			[Address(RVA = "0x1BF0A90", Offset = "0x1BEFE90", VA = "0x181BF0A90")]
			internal void <RequestToDeleteInviteCode>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033DB RID: 13275
			[Token(Token = "0x40033DB")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006E7 RID: 1767
		[Token(Token = "0x20006E7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x06012A1C RID: 76316 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A1C")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x06012A1D RID: 76317 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A1D")]
			[Address(RVA = "0x1BF0B10", Offset = "0x1BEFF10", VA = "0x181BF0B10")]
			internal void <RequestToUpdateClanColor>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033DC RID: 13276
			[Token(Token = "0x40033DC")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006E8 RID: 1768
		[Token(Token = "0x20006E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass66_0
		{
			// Token: 0x06012A1E RID: 76318 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A1E")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass66_0()
			{
			}

			// Token: 0x06012A1F RID: 76319 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A1F")]
			[Address(RVA = "0x1BF0B90", Offset = "0x1BEFF90", VA = "0x181BF0B90")]
			internal void <RequestToUpdateClanPhoto>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033DD RID: 13277
			[Token(Token = "0x40033DD")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006E9 RID: 1769
		[Token(Token = "0x20006E9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass67_0
		{
			// Token: 0x06012A20 RID: 76320 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A20")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass67_0()
			{
			}

			// Token: 0x06012A21 RID: 76321 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A21")]
			[Address(RVA = "0x1BF0C10", Offset = "0x1BF0010", VA = "0x181BF0C10")]
			internal void <RequestToPrestigeUp>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033DE RID: 13278
			[Token(Token = "0x40033DE")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> OnResponseReceived;
		}

		// Token: 0x020006EA RID: 1770
		[Token(Token = "0x20006EA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass68_0
		{
			// Token: 0x06012A22 RID: 76322 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A22")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass68_0()
			{
			}

			// Token: 0x06012A23 RID: 76323 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A23")]
			[Address(RVA = "0x1BF0C90", Offset = "0x1BF0090", VA = "0x181BF0C90")]
			internal void <RequestToRefreshInventory>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033DF RID: 13279
			[Token(Token = "0x40033DF")]
			[FieldOffset(Offset = "0x10")]
			public Action OnResponseReceived;
		}

		// Token: 0x020006EB RID: 1771
		[Token(Token = "0x20006EB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass69_0
		{
			// Token: 0x06012A24 RID: 76324 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A24")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass69_0()
			{
			}

			// Token: 0x06012A25 RID: 76325 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A25")]
			[Address(RVA = "0x1BF0CC0", Offset = "0x1BF00C0", VA = "0x181BF0CC0")]
			internal void <RequestToRedeemCode>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E0 RID: 13280
			[Token(Token = "0x40033E0")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> OnResponseReceived;
		}

		// Token: 0x020006EC RID: 1772
		[Token(Token = "0x20006EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass70_0
		{
			// Token: 0x06012A26 RID: 76326 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A26")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass70_0()
			{
			}

			// Token: 0x06012A27 RID: 76327 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A27")]
			[Address(RVA = "0x1BF0D60", Offset = "0x1BF0160", VA = "0x181BF0D60")]
			internal void <RequestToReportPlayer>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E1 RID: 13281
			[Token(Token = "0x40033E1")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnResponseReceived;
		}

		// Token: 0x020006ED RID: 1773
		[Token(Token = "0x20006ED")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass72_0
		{
			// Token: 0x06012A28 RID: 76328 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A28")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass72_0()
			{
			}

			// Token: 0x06012A29 RID: 76329 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A29")]
			[Address(RVA = "0x1BF0DF0", Offset = "0x1BF01F0", VA = "0x181BF0DF0")]
			internal void <RequestPlayerReports>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E2 RID: 13282
			[Token(Token = "0x40033E2")]
			[FieldOffset(Offset = "0x10")]
			public ulong steamID;

			// Token: 0x040033E3 RID: 13283
			[Token(Token = "0x40033E3")]
			[FieldOffset(Offset = "0x18")]
			public Action<List<\u0304\u0302\u0301\u0306\u0303\u0302\u0303\u0305\u0306\u0305\u0305\u0301\u0307\u0304\u0306>> OnReportsReceived;
		}

		// Token: 0x020006EE RID: 1774
		[Token(Token = "0x20006EE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass73_0
		{
			// Token: 0x06012A2A RID: 76330 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A2A")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass73_0()
			{
			}

			// Token: 0x06012A2B RID: 76331 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A2B")]
			[Address(RVA = "0x1BF0FC0", Offset = "0x1BF03C0", VA = "0x181BF0FC0")]
			internal void <RequestRegisterDiscordID>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E4 RID: 13284
			[Token(Token = "0x40033E4")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, \u0304\u0307\u0306\u0305\u0305\u0304\u0308\u0305\u0302\u0304\u0308\u0303\u0306\u0303\u0304> OnReceivedResponse;
		}

		// Token: 0x020006EF RID: 1775
		[Token(Token = "0x20006EF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass74_0
		{
			// Token: 0x06012A2C RID: 76332 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A2C")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass74_0()
			{
			}

			// Token: 0x06012A2D RID: 76333 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A2D")]
			[Address(RVA = "0xA75850", Offset = "0xA74C50", VA = "0x180A75850")]
			internal void <RequestUnlinkDiscord>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E5 RID: 13285
			[Token(Token = "0x40033E5")]
			[FieldOffset(Offset = "0x10")]
			public Action OnReceivedResponse;
		}

		// Token: 0x020006F0 RID: 1776
		[Token(Token = "0x20006F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass75_0
		{
			// Token: 0x06012A2E RID: 76334 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A2E")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass75_0()
			{
			}

			// Token: 0x06012A2F RID: 76335 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A2F")]
			[Address(RVA = "0xA75850", Offset = "0xA74C50", VA = "0x180A75850")]
			internal void <RequestUnlinkTwitch>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E6 RID: 13286
			[Token(Token = "0x40033E6")]
			[FieldOffset(Offset = "0x10")]
			public Action OnReceivedResponse;
		}

		// Token: 0x020006F1 RID: 1777
		[Token(Token = "0x20006F1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass76_0
		{
			// Token: 0x06012A30 RID: 76336 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A30")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass76_0()
			{
			}

			// Token: 0x06012A31 RID: 76337 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A31")]
			[Address(RVA = "0x1BF1080", Offset = "0x1BF0480", VA = "0x181BF1080")]
			internal void <RequestToBan>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E7 RID: 13287
			[Token(Token = "0x40033E7")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, \u0307\u0303\u0307\u0306\u0305\u0302\u0301\u0307\u0305\u0305\u0302\u0308\u0305\u0305\u0305> OnReceivedResponse;
		}

		// Token: 0x020006F2 RID: 1778
		[Token(Token = "0x20006F2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass77_0
		{
			// Token: 0x06012A32 RID: 76338 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A32")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass77_0()
			{
			}

			// Token: 0x06012A33 RID: 76339 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A33")]
			[Address(RVA = "0x1BF1130", Offset = "0x1BF0530", VA = "0x181BF1130")]
			internal void <RequestMyBan>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E8 RID: 13288
			[Token(Token = "0x40033E8")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, DateTime, string> OnReceivedResponse;
		}

		// Token: 0x020006F3 RID: 1779
		[Token(Token = "0x20006F3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x06012A34 RID: 76340 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A34")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass78_0()
			{
			}

			// Token: 0x06012A35 RID: 76341 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A35")]
			[Address(RVA = "0x1BF1250", Offset = "0x1BF0650", VA = "0x181BF1250")]
			internal void <RequestMyTimeout>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033E9 RID: 13289
			[Token(Token = "0x40033E9")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, string> OnReceivedResponse;
		}

		// Token: 0x020006F4 RID: 1780
		[Token(Token = "0x20006F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass79_0
		{
			// Token: 0x06012A36 RID: 76342 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A36")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass79_0()
			{
			}

			// Token: 0x06012A37 RID: 76343 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A37")]
			[Address(RVA = "0x1BF1310", Offset = "0x1BF0710", VA = "0x181BF1310")]
			internal void <RequestToWarn>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033EA RID: 13290
			[Token(Token = "0x40033EA")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> OnReceivedResponse;
		}

		// Token: 0x020006F5 RID: 1781
		[Token(Token = "0x20006F5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x06012A38 RID: 76344 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A38")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x06012A39 RID: 76345 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A39")]
			[Address(RVA = "0x1BF13A0", Offset = "0x1BF07A0", VA = "0x181BF13A0")]
			internal void <RequestPlayerWarns>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033EB RID: 13291
			[Token(Token = "0x40033EB")]
			[FieldOffset(Offset = "0x10")]
			public ulong steamID;

			// Token: 0x040033EC RID: 13292
			[Token(Token = "0x40033EC")]
			[FieldOffset(Offset = "0x18")]
			public Action<List<\u0308\u0306\u0308\u0304\u0305\u0307\u0306\u0303\u0305\u0307\u0301\u0307\u0307\u0303\u0303>> OnWarnsReceived;
		}

		// Token: 0x020006F6 RID: 1782
		[Token(Token = "0x20006F6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass81_0
		{
			// Token: 0x06012A3A RID: 76346 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A3A")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass81_0()
			{
			}

			// Token: 0x06012A3B RID: 76347 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A3B")]
			[Address(RVA = "0x1BF1590", Offset = "0x1BF0990", VA = "0x181BF1590")]
			internal void <GetNews>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033ED RID: 13293
			[Token(Token = "0x40033ED")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0304\u0308\u0301\u0306\u0305\u0301\u0301\u0306\u0307\u0306\u0301\u0305\u0301\u0303\u0308> OnNewReceived;
		}

		// Token: 0x020006F7 RID: 1783
		[Token(Token = "0x20006F7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass83_0
		{
			// Token: 0x06012A3C RID: 76348 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A3C")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass83_0()
			{
			}

			// Token: 0x06012A3D RID: 76349 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A3D")]
			[Address(RVA = "0x1BF16D0", Offset = "0x1BF0AD0", VA = "0x181BF16D0")]
			internal void <GetPublicKeyForGameServer>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033EE RID: 13294
			[Token(Token = "0x40033EE")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0301\u0305\u0303\u0303\u0308\u0304\u0305\u0305\u0303\u0303\u0303\u0308\u0304\u0306\u0305> OnPublicKeyReceived;
		}

		// Token: 0x020006F8 RID: 1784
		[Token(Token = "0x20006F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass84_0
		{
			// Token: 0x06012A3E RID: 76350 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A3E")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass84_0()
			{
			}

			// Token: 0x06012A3F RID: 76351 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A3F")]
			[Address(RVA = "0x1BF1790", Offset = "0x1BF0B90", VA = "0x181BF1790")]
			internal void <RequestDemandForGameServer>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033EF RID: 13295
			[Token(Token = "0x40033EF")]
			[FieldOffset(Offset = "0x10")]
			public Action<int, int> OnServerCountReceived;
		}

		// Token: 0x020006F9 RID: 1785
		[Token(Token = "0x20006F9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06012A41 RID: 76353 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A41")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c()
			{
			}

			// Token: 0x06012A42 RID: 76354 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A42")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
			internal void <StopDemandForGameServer>b__85_0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x06012A43 RID: 76355 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A43")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
			internal void <VoiceTransmit>b__87_0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033F0 RID: 13296
			[Token(Token = "0x40033F0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MasterServerConnectionPlayer.<>c <>9;

			// Token: 0x040033F1 RID: 13297
			[Token(Token = "0x40033F1")]
			[FieldOffset(Offset = "0x8")]
			public static Action<\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308> <>9__85_0;

			// Token: 0x040033F2 RID: 13298
			[Token(Token = "0x40033F2")]
			[FieldOffset(Offset = "0x10")]
			public static Action<\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308> <>9__87_0;
		}

		// Token: 0x020006FA RID: 1786
		[Token(Token = "0x20006FA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass86_0
		{
			// Token: 0x06012A44 RID: 76356 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A44")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass86_0()
			{
			}

			// Token: 0x06012A45 RID: 76357 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A45")]
			[Address(RVA = "0x1BF1820", Offset = "0x1BF0C20", VA = "0x181BF1820")]
			internal void <RequestPingServers>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x, \u0304\u0307\u0308\u0303\u0305\u0305\u0307\u0301\u0306\u0307\u0308\u0306\u0302\u0302\u0308 y)
			{
			}

			// Token: 0x040033F3 RID: 13299
			[Token(Token = "0x40033F3")]
			[FieldOffset(Offset = "0x10")]
			public Action<Dictionary<\u0306\u0302\u0302\u0302\u0305\u0304\u0307\u0303\u0306\u0307\u0306\u0301\u0303\u0307\u0306, List<IPAddress>>> OnReceivedResponse;
		}

		// Token: 0x020006FB RID: 1787
		[Token(Token = "0x20006FB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass88_0
		{
			// Token: 0x06012A46 RID: 76358 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A46")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass88_0()
			{
			}

			// Token: 0x06012A47 RID: 76359 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012A47")]
			[Address(RVA = "0x1BF1A10", Offset = "0x1BF0E10", VA = "0x181BF1A10")]
			internal void <GetEventState>b__0(\u0303\u0306\u0305\u0305\u0308\u0306\u0304\u0307\u0306\u0306\u0304\u0303\u0304\u0303\u0303 x)
			{
			}

			// Token: 0x040033F4 RID: 13300
			[Token(Token = "0x40033F4")]
			[FieldOffset(Offset = "0x10")]
			public Action<\u0302\u0302\u0308\u0301\u0307\u0305\u0304\u0302\u0306\u0308\u0306\u0301\u0302\u0307\u0308> OnEventStateReceived;
		}
	}
}
