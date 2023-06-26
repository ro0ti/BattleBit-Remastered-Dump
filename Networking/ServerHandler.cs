using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using touching_your_mom;
using Networking.Core;
using UnityEngine;

namespace Networking
{
	// Token: 0x020006BE RID: 1726
	[Token(Token = "0x20006BE")]
	public static class ServerHandler
	{
		// Token: 0x0601284C RID: 75852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601284C")]
		[Address(RVA = "0x1724B00", Offset = "0x1723F00", VA = "0x181724B00")]
		private static void InitBuffers()
		{
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0601284D RID: 75853 RVA: 0x00073D84 File Offset: 0x00071F84
		// (set) Token: 0x0601284E RID: 75854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A39")]
		public static bool isWorking
		{
			[Token(Token = "0x601284D")]
			[Address(RVA = "0x1731DF0", Offset = "0x17311F0", VA = "0x181731DF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601284E")]
			[Address(RVA = "0x1732640", Offset = "0x1731A40", VA = "0x181732640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x0601284F RID: 75855 RVA: 0x00073D9C File Offset: 0x00071F9C
		// (set) Token: 0x06012850 RID: 75856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A3A")]
		public static int Port
		{
			[Token(Token = "0x601284F")]
			[Address(RVA = "0x1731A80", Offset = "0x1730E80", VA = "0x181731A80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6012850")]
			[Address(RVA = "0x1732520", Offset = "0x1731920", VA = "0x181732520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06012851 RID: 75857 RVA: 0x00073DB4 File Offset: 0x00071FB4
		[Token(Token = "0x17000A3B")]
		public static int UserCount
		{
			[Token(Token = "0x6012851")]
			[Address(RVA = "0x1731DA0", Offset = "0x17311A0", VA = "0x181731DA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06012852 RID: 75858 RVA: 0x00073DCC File Offset: 0x00071FCC
		[Token(Token = "0x17000A3C")]
		public static int QueueCount
		{
			[Token(Token = "0x6012852")]
			[Address(RVA = "0x1731AE0", Offset = "0x1730EE0", VA = "0x181731AE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06012853 RID: 75859 RVA: 0x00073DE4 File Offset: 0x00071FE4
		[Token(Token = "0x17000A3D")]
		public static int ReservedCount
		{
			[Token(Token = "0x6012853")]
			[Address(RVA = "0x1731B30", Offset = "0x1730F30", VA = "0x181731B30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06012854 RID: 75860 RVA: 0x00073DFC File Offset: 0x00071FFC
		// (set) Token: 0x06012855 RID: 75861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A3E")]
		public static int InconnectingCount
		{
			[Token(Token = "0x6012854")]
			[Address(RVA = "0x17319C0", Offset = "0x1730DC0", VA = "0x1817319C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6012855")]
			[Address(RVA = "0x17324C0", Offset = "0x17318C0", VA = "0x1817324C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06012856 RID: 75862 RVA: 0x00073E14 File Offset: 0x00072014
		// (set) Token: 0x06012857 RID: 75863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A3F")]
		public static \u0308\u0308\u0303\u0303\u0301\u0304\u0308\u0306\u0307\u0306\u0302\u0301\u0304\u0302\u0305 ServerBrowserState
		{
			[Token(Token = "0x6012856")]
			[Address(RVA = "0x1731B80", Offset = "0x1730F80", VA = "0x181731B80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return \u0308\u0308\u0303\u0303\u0301\u0304\u0308\u0306\u0307\u0306\u0302\u0301\u0304\u0302\u0305.None;
			}
			[Token(Token = "0x6012857")]
			[Address(RVA = "0x1732580", Offset = "0x1731980", VA = "0x181732580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06012858 RID: 75864 RVA: 0x00073E2C File Offset: 0x0007202C
		[Token(Token = "0x17000A40")]
		public static int TotalConnectedPlayers
		{
			[Token(Token = "0x6012858")]
			[Address(RVA = "0x1731BE0", Offset = "0x1730FE0", VA = "0x181731BE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06012859 RID: 75865 RVA: 0x00073E44 File Offset: 0x00072044
		[Token(Token = "0x17000A41")]
		public static int TotalInQueuePlayers
		{
			[Token(Token = "0x6012859")]
			[Address(RVA = "0x1731C70", Offset = "0x1731070", VA = "0x181731C70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601285A RID: 75866 RVA: 0x00073E5C File Offset: 0x0007205C
		[Token(Token = "0x601285A")]
		[Address(RVA = "0x1724D40", Offset = "0x1724140", VA = "0x181724D40")]
		public static bool Init(int port)
		{
			return default(bool);
		}

		// Token: 0x0601285B RID: 75867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601285B")]
		[Address(RVA = "0x172AD90", Offset = "0x172A190", VA = "0x18172AD90")]
		public static void OnHosted()
		{
		}

		// Token: 0x0601285C RID: 75868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601285C")]
		[Address(RVA = "0x172EDA0", Offset = "0x172E1A0", VA = "0x18172EDA0")]
		public static void Reset()
		{
		}

		// Token: 0x0601285D RID: 75869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601285D")]
		[Address(RVA = "0x1728CB0", Offset = "0x17280B0", VA = "0x181728CB0")]
		public static void OnGameUpdateFrameStart(float deltaTime)
		{
		}

		// Token: 0x0601285E RID: 75870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601285E")]
		[Address(RVA = "0x17289A0", Offset = "0x1727DA0", VA = "0x1817289A0")]
		public static void OnGameUpdateFrameEnd()
		{
		}

		// Token: 0x0601285F RID: 75871 RVA: 0x00073E74 File Offset: 0x00072074
		[Token(Token = "0x601285F")]
		[Address(RVA = "0x1725890", Offset = "0x1724C90", VA = "0x181725890")]
		public static bool OnConsoleCommand(string cmd)
		{
			return default(bool);
		}

		// Token: 0x06012860 RID: 75872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012860")]
		[Address(RVA = "0x1723630", Offset = "0x1722A30", VA = "0x181723630")]
		public static void ChangeMaximumPlayers(bool force = false)
		{
		}

		// Token: 0x06012861 RID: 75873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012861")]
		[Address(RVA = "0x172F6B0", Offset = "0x172EAB0", VA = "0x18172F6B0")]
		public static void SetPingHailPackage(string map)
		{
		}

		// Token: 0x06012862 RID: 75874 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6012862")]
		[Address(RVA = "0x1725790", Offset = "0x1724B90", VA = "0x181725790")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x144270", Offset = "0x143670")]
		public static IEnumerator OnClientConnecting(\u0302\u0304\u0305\u0303\u0303\u0302\u0303\u0306\u0302\u0304\u0307\u0308\u0302\u0305\u0305 user)
		{
			return null;
		}

		// Token: 0x06012863 RID: 75875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012863")]
		[Address(RVA = "0x1724480", Offset = "0x1723880", VA = "0x181724480")]
		public static void DisconnectUser(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client, bool wasKicked)
		{
		}

		// Token: 0x06012864 RID: 75876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012864")]
		[Address(RVA = "0x1723540", Offset = "0x1722940", VA = "0x181723540")]
		public static void BroadcastUnreliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset)
		{
		}

		// Token: 0x06012865 RID: 75877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012865")]
		[Address(RVA = "0x17231A0", Offset = "0x17225A0", VA = "0x1817231A0")]
		public static void BroadcastUnreliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 except)
		{
		}

		// Token: 0x06012866 RID: 75878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012866")]
		[Address(RVA = "0x1723360", Offset = "0x1722760", VA = "0x181723360")]
		public static void BroadcastUnreliable(\u0303\u0303\u0304\u0303\u0306\u0301\u0308\u0306\u0305\u0305\u0304\u0303\u0301\u0303\u0301 stream, \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset)
		{
		}

		// Token: 0x06012867 RID: 75879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012867")]
		[Address(RVA = "0x1722F90", Offset = "0x1722390", VA = "0x181722F90")]
		public static void BroadcastUnreliableWriteHeader(\u0303\u0303\u0304\u0303\u0306\u0301\u0308\u0306\u0305\u0305\u0304\u0303\u0301\u0303\u0301 stream, \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset, int rateOffset)
		{
		}

		// Token: 0x06012868 RID: 75880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012868")]
		[Address(RVA = "0x1722EA0", Offset = "0x17222A0", VA = "0x181722EA0")]
		public static void BroadcastReliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset)
		{
		}

		// Token: 0x06012869 RID: 75881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012869")]
		[Address(RVA = "0x1722CF0", Offset = "0x17220F0", VA = "0x181722CF0")]
		public static void BroadcastReliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset, \u0307\u0308\u0308\u0304\u0303\u0308\u0302\u0302\u0302\u0302\u0302\u0305\u0307\u0304\u0303 squad)
		{
		}

		// Token: 0x0601286A RID: 75882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601286A")]
		[Address(RVA = "0x17229F0", Offset = "0x1721DF0", VA = "0x1817229F0")]
		public static void BroadcastReliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset, \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 team)
		{
		}

		// Token: 0x0601286B RID: 75883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601286B")]
		[Address(RVA = "0x1722B60", Offset = "0x1721F60", VA = "0x181722B60")]
		public static void BroadcastReliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 except)
		{
		}

		// Token: 0x0601286C RID: 75884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601286C")]
		[Address(RVA = "0x172F670", Offset = "0x172EA70", VA = "0x18172F670")]
		public static void SendReliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 destination)
		{
		}

		// Token: 0x0601286D RID: 75885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601286D")]
		[Address(RVA = "0x1732170", Offset = "0x1731570", VA = "0x181732170")]
		private static void mExecute(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601286E RID: 75886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601286E")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		private static void OnNetworkPaddingReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601286F RID: 75887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601286F")]
		[Address(RVA = "0x172D500", Offset = "0x172C900", VA = "0x18172D500")]
		private static void OnRPCReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012870 RID: 75888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012870")]
		[Address(RVA = "0x172E6C0", Offset = "0x172DAC0", VA = "0x18172E6C0")]
		private static void OnVehicleStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012871 RID: 75889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012871")]
		[Address(RVA = "0x172B580", Offset = "0x172A980", VA = "0x18172B580")]
		private static void OnPlayerSpawn(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 package, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012872 RID: 75890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012872")]
		[Address(RVA = "0x172B4B0", Offset = "0x172A8B0", VA = "0x18172B4B0")]
		private static void OnPlayerPositionStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 package, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012873 RID: 75891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012873")]
		[Address(RVA = "0x1725630", Offset = "0x1724A30", VA = "0x181725630")]
		private static void OnBodyHitRequest(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012874 RID: 75892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012874")]
		[Address(RVA = "0x17254D0", Offset = "0x17248D0", VA = "0x1817254D0")]
		private static void OnArmorHitRequest(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012875 RID: 75893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012875")]
		[Address(RVA = "0x172E830", Offset = "0x172DC30", VA = "0x18172E830")]
		private static void OnVoipReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 senderClient)
		{
		}

		// Token: 0x06012876 RID: 75894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012876")]
		[Address(RVA = "0x172DC90", Offset = "0x172D090", VA = "0x18172DC90")]
		private static void OnSavePrefs(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012877 RID: 75895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012877")]
		[Address(RVA = "0x1728730", Offset = "0x1727B30", VA = "0x181728730")]
		private static void OnGadgetRPCReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012878 RID: 75896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012878")]
		[Address(RVA = "0x172DB90", Offset = "0x172CF90", VA = "0x18172DB90")]
		private static void OnReplicaStreamRecived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012879 RID: 75897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012879")]
		[Address(RVA = "0x172E070", Offset = "0x172D470", VA = "0x18172E070")]
		private static void OnVehicleSeatBehaviourStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601287A RID: 75898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601287A")]
		[Address(RVA = "0x172AE60", Offset = "0x172A260", VA = "0x18172AE60")]
		private static void OnPlayerPerspectiveReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601287B RID: 75899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601287B")]
		[Address(RVA = "0x17285C0", Offset = "0x17279C0", VA = "0x1817285C0")]
		private static void OnDroneStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601287C RID: 75900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601287C")]
		[Address(RVA = "0x17253C0", Offset = "0x17247C0", VA = "0x1817253C0")]
		private static void OnAntiCheatPackageReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601287D RID: 75901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601287D")]
		[Address(RVA = "0x1725820", Offset = "0x1724C20", VA = "0x181725820")]
		private static void OnClientTickReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601287E RID: 75902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601287E")]
		[Address(RVA = "0x172D4E0", Offset = "0x172C8E0", VA = "0x18172D4E0")]
		private static void OnProjectileExplosionRequestReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x0601287F RID: 75903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601287F")]
		[Address(RVA = "0x172DCD0", Offset = "0x172D0D0", VA = "0x18172DCD0")]
		private static void OnSpectatorDataReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer, int packageSize, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender)
		{
		}

		// Token: 0x06012880 RID: 75904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012880")]
		[Address(RVA = "0x1723B90", Offset = "0x1722F90", VA = "0x181723B90")]
		public static void ClearCache(ulong SteamID)
		{
		}

		// Token: 0x06012881 RID: 75905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012881")]
		[Address(RVA = "0x17251B0", Offset = "0x17245B0", VA = "0x1817251B0")]
		public static void Kick(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client, DisconnectReason reason = DisconnectReason.KickedFromServer, bool sendBye = true)
		{
		}

		// Token: 0x06012882 RID: 75906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012882")]
		[Address(RVA = "0x17250E0", Offset = "0x17244E0", VA = "0x1817250E0")]
		public static void KickAntiCheat(ulong steamID, DisconnectReason reason, \u0305\u0303\u0301\u0306\u0301\u0301\u0304\u0308\u0304\u0308\u0303\u0307\u0307\u0302\u0307 flag)
		{
		}

		// Token: 0x06012883 RID: 75907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012883")]
		[Address(RVA = "0x1730BE0", Offset = "0x172FFE0", VA = "0x181730BE0")]
		public static void Unban(ulong steamID)
		{
		}

		// Token: 0x06012884 RID: 75908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012884")]
		[Address(RVA = "0x1722950", Offset = "0x1721D50", VA = "0x181722950")]
		public static void Ban(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client)
		{
		}

		// Token: 0x06012885 RID: 75909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012885")]
		[Address(RVA = "0x1723BF0", Offset = "0x1722FF0", VA = "0x181723BF0")]
		public static void ConnectBot(string botName, int rank, \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 team = \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307.TeamB)
		{
		}

		// Token: 0x06012886 RID: 75910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012886")]
		[Address(RVA = "0x17241D0", Offset = "0x17235D0", VA = "0x1817241D0")]
		public static void DisconnectBot(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client)
		{
		}

		// Token: 0x06012887 RID: 75911 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6012887")]
		[Address(RVA = "0x172FA30", Offset = "0x172EE30", VA = "0x18172FA30")]
		public static GameObject SpawnAndBroadcastToPlayers(string Prefab, Vector3 position, Quaternion rotation, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 owner)
		{
			return null;
		}

		// Token: 0x06012888 RID: 75912 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6012888")]
		[Address(RVA = "0x172FCD0", Offset = "0x172F0D0", VA = "0x18172FCD0")]
		public static GameObject SpawnAndBroadcastToPlayers(string Prefab, ushort SpawnID, Vector3 position, Quaternion rotation, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 owner)
		{
			return null;
		}

		// Token: 0x06012889 RID: 75913 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6012889")]
		[Address(RVA = "0x1730430", Offset = "0x172F830", VA = "0x181730430")]
		public static VehicleInstance SpawnVehicleAndBroadcastToPlayers(Vehicle vehicle, Vector3 position, Quaternion rotation, \u0307\u0304\u0304\u0305\u0301\u0307\u0303\u0302\u0308\u0304\u0302\u0307\u0308\u0304\u0307 team)
		{
			return null;
		}

		// Token: 0x0601288A RID: 75914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601288A")]
		[Address(RVA = "0x172FF40", Offset = "0x172F340", VA = "0x18172FF40")]
		public static void SpawnThePlayer_server2Clients(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client, \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 loadout, \u0303\u0305\u0304\u0304\u0301\u0301\u0302\u0301\u0302\u0306\u0306\u0306\u0308\u0304\u0306 skin, Vector3 position, Vector3 direction, \u0303\u0303\u0302\u0301\u0308\u0301\u0305\u0308\u0306\u0303\u0307\u0306\u0304\u0303\u0302 standing, float spawnProtection)
		{
		}

		// Token: 0x0601288B RID: 75915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601288B")]
		[Address(RVA = "0x1730290", Offset = "0x172F690", VA = "0x181730290")]
		public static void SpawnThePlayer_server2Clients(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client, \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 loadout, \u0303\u0305\u0304\u0304\u0301\u0301\u0302\u0301\u0302\u0306\u0306\u0306\u0308\u0304\u0306 skin, float spawnProtection, \u0307\u0303\u0308\u0305\u0302\u0301\u0306\u0304\u0308\u0305\u0305\u0304\u0305\u0301\u0303 seat)
		{
		}

		// Token: 0x0601288C RID: 75916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601288C")]
		[Address(RVA = "0x1731E50", Offset = "0x1731250", VA = "0x181731E50")]
		private static void mCheckUserPings()
		{
		}

		// Token: 0x0601288E RID: 75918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601288E")]
		[Address(RVA = "0x1730B60", Offset = "0x172FF60", VA = "0x181730B60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static void <OnPlayerSpawn>g__SendIgnore|87_0(int languageIndex, ref ServerHandler.<>c__DisplayClass87_0 A_1)
		{
		}

		// Token: 0x0601288F RID: 75919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601288F")]
		[Address(RVA = "0x1730AD0", Offset = "0x172FED0", VA = "0x181730AD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static void <OnPlayerSpawn>g__ClampPoint|87_1(ref Vector3 spawnPoint, bool doReport, ref ServerHandler.<>c__DisplayClass87_0 A_2)
		{
		}

		// Token: 0x06012890 RID: 75920 RVA: 0x00073E8C File Offset: 0x0007208C
		[Token(Token = "0x6012890")]
		[Address(RVA = "0x1730A20", Offset = "0x172FE20", VA = "0x181730A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static int <OnPlayerPerspectiveReceived>g__read|96_0(ref ServerHandler.<>c__DisplayClass96_0 A_0)
		{
			return 0;
		}

		// Token: 0x06012891 RID: 75921 RVA: 0x00073EA4 File Offset: 0x000720A4
		[Token(Token = "0x6012891")]
		[Address(RVA = "0x1730950", Offset = "0x172FD50", VA = "0x181730950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		internal static byte <ConnectBot>g__GetNextRoomID|107_0()
		{
			return 0;
		}

		// Token: 0x040032D9 RID: 13017
		[Token(Token = "0x40032D9")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <isWorking>k__BackingField;

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[touching_your_mom.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static int <Port>k__BackingField;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public static int Hz;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[touching_your_mom.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static int <InconnectingCount>k__BackingField;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static \u0308\u0308\u0303\u0303\u0301\u0304\u0308\u0306\u0307\u0306\u0302\u0301\u0304\u0302\u0305 <ServerBrowserState>k__BackingField;

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		public static string ServerVersion;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		public static string MapBeingPlayed;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		public static int FPS;

		// Token: 0x040032E1 RID: 13025
		[Token(Token = "0x40032E1")]
		[touching_your_mom.FieldOffset(Offset = "0x2C")]
		public static int NumberOfModeratorsInServer;

		// Token: 0x040032E2 RID: 13026
		[Token(Token = "0x40032E2")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public static int NumberOfContentCreatorsInServer;

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[touching_your_mom.FieldOffset(Offset = "0x34")]
		private static bool m_buffersInitialized;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		private static Queue<Connection> mConnectionPool;

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[touching_your_mom.FieldOffset(Offset = "0x40")]
		private static Queue<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304> mDisconnectQueue;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[touching_your_mom.FieldOffset(Offset = "0x48")]
		private static List<Connection> mConnectionList;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[touching_your_mom.FieldOffset(Offset = "0x50")]
		private static Dictionary<EndPoint, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304> mEndPoint2Client;

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[touching_your_mom.FieldOffset(Offset = "0x58")]
		private static List<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304> mBots;

		// Token: 0x040032E9 RID: 13033
		[Token(Token = "0x40032E9")]
		[touching_your_mom.FieldOffset(Offset = "0x60")]
		private static Queue<NetworkPackage> mExecutableReliablePackages;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[touching_your_mom.FieldOffset(Offset = "0x68")]
		private static Queue<NetworkPackage> mExecutableUnreliablePackages;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		[touching_your_mom.FieldOffset(Offset = "0x70")]
		private static Queue<\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304> mPingKickQueue;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		[touching_your_mom.FieldOffset(Offset = "0x78")]
		private static float mLastConnectingPlayersReportSent;

		// Token: 0x040032ED RID: 13037
		[Token(Token = "0x40032ED")]
		[touching_your_mom.FieldOffset(Offset = "0x80")]
		private static ulong mBotIndex;

		// Token: 0x040032EE RID: 13038
		[Token(Token = "0x40032EE")]
		[touching_your_mom.FieldOffset(Offset = "0x88")]
		private static string mCacheIP;

		// Token: 0x040032EF RID: 13039
		[Token(Token = "0x40032EF")]
		[touching_your_mom.FieldOffset(Offset = "0x90")]
		private static bool mSinTime;

		// Token: 0x040032F0 RID: 13040
		[Token(Token = "0x40032F0")]
		[touching_your_mom.FieldOffset(Offset = "0x94")]
		private static float mSinTimeSpeed;

		// Token: 0x040032F1 RID: 13041
		[Token(Token = "0x40032F1")]
		[touching_your_mom.FieldOffset(Offset = "0x98")]
		private static float mSinTimeSpeedOffset;

		// Token: 0x040032F2 RID: 13042
		[Token(Token = "0x40032F2")]
		[touching_your_mom.FieldOffset(Offset = "0x9C")]
		private static float mSinTimeSpeedScale;

		// Token: 0x040032F3 RID: 13043
		[Token(Token = "0x40032F3")]
		[touching_your_mom.FieldOffset(Offset = "0xA0")]
		private static float mFPSCounter;

		// Token: 0x040032F4 RID: 13044
		[Token(Token = "0x40032F4")]
		[touching_your_mom.FieldOffset(Offset = "0xA4")]
		private static bool mFirstConnectionDone;

		// Token: 0x040032F5 RID: 13045
		[Token(Token = "0x40032F5")]
		[touching_your_mom.FieldOffset(Offset = "0xA8")]
		private static int mFpsCounter;

		// Token: 0x040032F6 RID: 13046
		[Token(Token = "0x40032F6")]
		[touching_your_mom.FieldOffset(Offset = "0xAC")]
		private static float mLastPingChecked;

		// Token: 0x040032F7 RID: 13047
		[Token(Token = "0x40032F7")]
		[touching_your_mom.FieldOffset(Offset = "0xB0")]
		private static bool mRandomFPSEnabled;

		// Token: 0x040032F8 RID: 13048
		[Token(Token = "0x40032F8")]
		[touching_your_mom.FieldOffset(Offset = "0xB4")]
		private static float mRandomFPSCounter;

		// Token: 0x040032F9 RID: 13049
		[Token(Token = "0x40032F9")]
		[touching_your_mom.FieldOffset(Offset = "0xB8")]
		private static Vector2Int mRandomFPS;

		// Token: 0x040032FA RID: 13050
		[Token(Token = "0x40032FA")]
		[touching_your_mom.FieldOffset(Offset = "0xC0")]
		private static Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mSnapshotPackages;

		// Token: 0x040032FB RID: 13051
		[Token(Token = "0x40032FB")]
		[touching_your_mom.FieldOffset(Offset = "0xC8")]
		public static Stopwatch ClientConnectingClock;

		// Token: 0x040032FC RID: 13052
		[Token(Token = "0x40032FC")]
		[touching_your_mom.FieldOffset(Offset = "0xD0")]
		public static ulong LastConnectionSteamID;

		// Token: 0x040032FD RID: 13053
		[Token(Token = "0x40032FD")]
		[touching_your_mom.FieldOffset(Offset = "0xD8")]
		public static Coroutine LastConnectionCoroutine;

		// Token: 0x040032FE RID: 13054
		[Token(Token = "0x40032FE")]
		[touching_your_mom.FieldOffset(Offset = "0xE0")]
		public static IPEndPoint LastConnectionEP;

		// Token: 0x040032FF RID: 13055
		[Token(Token = "0x40032FF")]
		[touching_your_mom.FieldOffset(Offset = "0xE8")]
		public static \u0306\u0303\u0301\u0303\u0305\u0302\u0301\u0302\u0306\u0308\u0305\u0301\u0301\u0308\u0305 LastConnectionPhase;

		// Token: 0x04003300 RID: 13056
		[Token(Token = "0x4003300")]
		[touching_your_mom.FieldOffset(Offset = "0xF0")]
		private static Action<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301, int, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304>[] Functions;

		// Token: 0x04003301 RID: 13057
		[Token(Token = "0x4003301")]
		[touching_your_mom.FieldOffset(Offset = "0xF8")]
		private static bool[] FunctionMap;

		// Token: 0x020006BF RID: 1727
		[Token(Token = "0x20006BF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass70_0
		{
			// Token: 0x06012892 RID: 75922 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012892")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass70_0()
			{
			}

			// Token: 0x06012893 RID: 75923 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012893")]
			[Address(RVA = "0x164A530", Offset = "0x1649930", VA = "0x18164A530")]
			internal void <OnClientConnecting>g__CloseConnection|0(NetworkFail report)
			{
			}

			// Token: 0x06012894 RID: 75924 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012894")]
			[Address(RVA = "0x8AD670", Offset = "0x8ACA70", VA = "0x1808AD670")]
			internal void <OnClientConnecting>b__1(PlayerStats x)
			{
			}

			// Token: 0x06012895 RID: 75925 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012895")]
			[Address(RVA = "0x935660", Offset = "0x934A60", VA = "0x180935660")]
			internal void <OnClientConnecting>b__2(\u0305\u0305\u0306\u0301\u0305\u0306\u0308\u0306\u0305\u0301\u0303\u0304\u0308\u0304\u0302 x)
			{
			}

			// Token: 0x06012896 RID: 75926 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012896")]
			[Address(RVA = "0x164A4D0", Offset = "0x16498D0", VA = "0x18164A4D0")]
			internal void <OnClientConnecting>b__3()
			{
			}

			// Token: 0x04003302 RID: 13058
			[Token(Token = "0x4003302")]
			[touching_your_mom.FieldOffset(Offset = "0x10")]
			public bool steamSessionBegin;

			// Token: 0x04003303 RID: 13059
			[Token(Token = "0x4003303")]
			[touching_your_mom.FieldOffset(Offset = "0x18")]
			public \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 hailPackage;

			// Token: 0x04003304 RID: 13060
			[Token(Token = "0x4003304")]
			[touching_your_mom.FieldOffset(Offset = "0x20")]
			public IPEndPoint sender;

			// Token: 0x04003305 RID: 13061
			[Token(Token = "0x4003305")]
			[touching_your_mom.FieldOffset(Offset = "0x28")]
			public ulong steamID;

			// Token: 0x04003306 RID: 13062
			[Token(Token = "0x4003306")]
			[touching_your_mom.FieldOffset(Offset = "0x30")]
			public PlayerStats playerStats;

			// Token: 0x04003307 RID: 13063
			[Token(Token = "0x4003307")]
			[touching_your_mom.FieldOffset(Offset = "0x38")]
			public \u0305\u0305\u0306\u0301\u0305\u0306\u0308\u0306\u0305\u0301\u0303\u0304\u0308\u0304\u0302 playerClan;
		}

		// Token: 0x020006C0 RID: 1728
		[Token(Token = "0x20006C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <OnClientConnecting>d__70 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06012897 RID: 75927 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012897")]
			[Address(RVA = "0x8D0E00", Offset = "0x8D0200", VA = "0x1808D0E00")]
			[DebuggerHidden]
			public <OnClientConnecting>d__70(int <>1__state)
			{
			}

			// Token: 0x06012898 RID: 75928 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6012898")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06012899 RID: 75929 RVA: 0x00073EBC File Offset: 0x000720BC
			[Token(Token = "0x6012899")]
			[Address(RVA = "0x1647AE0", Offset = "0x1646EE0", VA = "0x181647AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x0601289A RID: 75930 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000A42")]
			private object Current
			{
				[Token(Token = "0x601289A")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0601289B RID: 75931 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601289B")]
			[Address(RVA = "0x1649E20", Offset = "0x1649220", VA = "0x181649E20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x0601289C RID: 75932 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000A43")]
			private object Current
			{
				[Token(Token = "0x601289C")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04003308 RID: 13064
			[Token(Token = "0x4003308")]
			[touching_your_mom.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04003309 RID: 13065
			[Token(Token = "0x4003309")]
			[touching_your_mom.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400330A RID: 13066
			[Token(Token = "0x400330A")]
			[touching_your_mom.FieldOffset(Offset = "0x20")]
			public \u0302\u0304\u0305\u0303\u0303\u0302\u0303\u0306\u0302\u0304\u0307\u0308\u0302\u0305\u0305 user;

			// Token: 0x0400330B RID: 13067
			[Token(Token = "0x400330B")]
			[touching_your_mom.FieldOffset(Offset = "0x48")]
			private ServerHandler.<>c__DisplayClass70_0 <>8__1;

			// Token: 0x0400330C RID: 13068
			[Token(Token = "0x400330C")]
			[touching_your_mom.FieldOffset(Offset = "0x50")]
			private bool <sameUserAlreadyInGame>5__2;

			// Token: 0x0400330D RID: 13069
			[Token(Token = "0x400330D")]
			[touching_your_mom.FieldOffset(Offset = "0x58")]
			private \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 <oldClient>5__3;

			// Token: 0x0400330E RID: 13070
			[Token(Token = "0x400330E")]
			[touching_your_mom.FieldOffset(Offset = "0x60")]
			private bool <isDev>5__4;

			// Token: 0x0400330F RID: 13071
			[Token(Token = "0x400330F")]
			[touching_your_mom.FieldOffset(Offset = "0x61")]
			private bool <inParty>5__5;

			// Token: 0x04003310 RID: 13072
			[Token(Token = "0x4003310")]
			[touching_your_mom.FieldOffset(Offset = "0x62")]
			private bool <isPartyLeader>5__6;

			// Token: 0x04003311 RID: 13073
			[Token(Token = "0x4003311")]
			[touching_your_mom.FieldOffset(Offset = "0x68")]
			private ulong <partyID>5__7;

			// Token: 0x04003312 RID: 13074
			[Token(Token = "0x4003312")]
			[touching_your_mom.FieldOffset(Offset = "0x70")]
			private string <nickname>5__8;

			// Token: 0x04003313 RID: 13075
			[Token(Token = "0x4003313")]
			[touching_your_mom.FieldOffset(Offset = "0x78")]
			private string <networkVersion>5__9;
		}

		// Token: 0x020006C1 RID: 1729
		[Token(Token = "0x20006C1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[StructLayout(3)]
		private struct <>c__DisplayClass87_0
		{
			// Token: 0x04003314 RID: 13076
			[Token(Token = "0x4003314")]
			[touching_your_mom.FieldOffset(Offset = "0x0")]
			public \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender;
		}

		// Token: 0x020006C2 RID: 1730
		[Token(Token = "0x20006C2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		[StructLayout(3)]
		private struct <>c__DisplayClass96_0
		{
			// Token: 0x04003315 RID: 13077
			[Token(Token = "0x4003315")]
			[touching_your_mom.FieldOffset(Offset = "0x0")]
			public int counter;

			// Token: 0x04003316 RID: 13078
			[Token(Token = "0x4003316")]
			[touching_your_mom.FieldOffset(Offset = "0x4")]
			public int current;

			// Token: 0x04003317 RID: 13079
			[Token(Token = "0x4003317")]
			[touching_your_mom.FieldOffset(Offset = "0x8")]
			public \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer;
		}

		// Token: 0x020006C3 RID: 1731
		[Token(Token = "0x20006C3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <>c__DisplayClass104_0
		{
			// Token: 0x0601289D RID: 75933 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601289D")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public <>c__DisplayClass104_0()
			{
			}

			// Token: 0x0601289E RID: 75934 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x601289E")]
			[Address(RVA = "0x1649E70", Offset = "0x1649270", VA = "0x181649E70")]
			internal void <KickAntiCheat>b__0()
			{
			}

			// Token: 0x04003318 RID: 13080
			[Token(Token = "0x4003318")]
			[touching_your_mom.FieldOffset(Offset = "0x10")]
			public ulong steamID;

			// Token: 0x04003319 RID: 13081
			[Token(Token = "0x4003319")]
			[touching_your_mom.FieldOffset(Offset = "0x18")]
			public \u0305\u0303\u0301\u0306\u0301\u0301\u0304\u0308\u0304\u0308\u0303\u0307\u0307\u0302\u0307 flag;

			// Token: 0x0400331A RID: 13082
			[Token(Token = "0x400331A")]
			[touching_your_mom.FieldOffset(Offset = "0x1C")]
			public DisconnectReason reason;
		}
	}
}
