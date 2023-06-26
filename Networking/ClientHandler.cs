using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using touching_your_mom;
using UnityEngine;

namespace Networking
{
	// Token: 0x020006BB RID: 1723
	[Token(Token = "0x20006BB")]
	public static class ClientHandler
	{
		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06012824 RID: 75812 RVA: 0x00073D3C File Offset: 0x00071F3C
		// (set) Token: 0x06012825 RID: 75813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A38")]
		public static bool isListening
		{
			[Token(Token = "0x6012824")]
			[Address(RVA = "0x1712800", Offset = "0x1711C00", VA = "0x181712800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6012825")]
			[Address(RVA = "0x1712DE0", Offset = "0x17121E0", VA = "0x181712DE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06012826 RID: 75814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012826")]
		[Address(RVA = "0x170EBD0", Offset = "0x170DFD0", VA = "0x18170EBD0")]
		public static void Init()
		{
		}

		// Token: 0x06012827 RID: 75815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012827")]
		[Address(RVA = "0x17112E0", Offset = "0x17106E0", VA = "0x1817112E0")]
		public static void Reset()
		{
		}

		// Token: 0x06012828 RID: 75816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012828")]
		[Address(RVA = "0x170F300", Offset = "0x170E700", VA = "0x18170F300")]
		public static void OnGameUpdate(float deltaTime)
		{
		}

		// Token: 0x06012829 RID: 75817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012829")]
		[Address(RVA = "0x170F590", Offset = "0x170E990", VA = "0x18170F590")]
		public static void OnLateGameUpdate()
		{
		}

		// Token: 0x0601282A RID: 75818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601282A")]
		[Address(RVA = "0x170ECE0", Offset = "0x170E0E0", VA = "0x18170ECE0")]
		public static void OnClientThreadUpdate()
		{
		}

		// Token: 0x0601282B RID: 75819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601282B")]
		[Address(RVA = "0x1711610", Offset = "0x1710A10", VA = "0x181711610")]
		public static void SendUnreliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset)
		{
		}

		// Token: 0x0601282C RID: 75820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601282C")]
		[Address(RVA = "0x17114E0", Offset = "0x17108E0", VA = "0x1817114E0")]
		public static void SendReliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset)
		{
		}

		// Token: 0x0601282D RID: 75821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601282D")]
		[Address(RVA = "0x1712860", Offset = "0x1711C60", VA = "0x181712860")]
		private static void mExecute(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck)
		{
		}

		// Token: 0x0601282E RID: 75822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601282E")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		private static void OnNetworkPaddingReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601282F RID: 75823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601282F")]
		[Address(RVA = "0x1710620", Offset = "0x170FA20", VA = "0x181710620")]
		private static void OnSharpPlayerConnect(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012830 RID: 75824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012830")]
		[Address(RVA = "0x17107A0", Offset = "0x170FBA0", VA = "0x1817107A0")]
		private static void OnSharpPlayerDisconnected(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012831 RID: 75825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012831")]
		[Address(RVA = "0x17119F0", Offset = "0x1710DF0", VA = "0x1817119F0")]
		private static void VoipReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012832 RID: 75826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012832")]
		[Address(RVA = "0x1710080", Offset = "0x170F480", VA = "0x181710080")]
		private static void OnRPCReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012833 RID: 75827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012833")]
		[Address(RVA = "0x17108E0", Offset = "0x170FCE0", VA = "0x1817108E0")]
		private static void OnSpawnObjectReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012834 RID: 75828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012834")]
		[Address(RVA = "0x170EF40", Offset = "0x170E340", VA = "0x18170EF40")]
		private static void OnDestroyObjectReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012835 RID: 75829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012835")]
		[Address(RVA = "0x170F9C0", Offset = "0x170EDC0", VA = "0x18170F9C0")]
		private static void OnPlayerSpawnReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012836 RID: 75830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012836")]
		[Address(RVA = "0x1711200", Offset = "0x1710600", VA = "0x181711200")]
		private static void OnVehicleStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012837 RID: 75831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012837")]
		[Address(RVA = "0x170F8F0", Offset = "0x170ECF0", VA = "0x18170F8F0")]
		private static void OnPlayerPositionStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012838 RID: 75832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012838")]
		[Address(RVA = "0x1711740", Offset = "0x1710B40", VA = "0x181711740")]
		private static void SetTimeReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012839 RID: 75833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012839")]
		[Address(RVA = "0x1710E50", Offset = "0x1710250", VA = "0x181710E50")]
		private static void OnVehicleSpawnReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601283A RID: 75834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601283A")]
		[Address(RVA = "0x170F1A0", Offset = "0x170E5A0", VA = "0x18170F1A0")]
		private static void OnGadgetRPCReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601283B RID: 75835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601283B")]
		[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580")]
		private static void OnCombinedReliableReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601283C RID: 75836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601283C")]
		[Address(RVA = "0x1710540", Offset = "0x170F940", VA = "0x181710540")]
		private static void OnReplicaStreamRecived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601283D RID: 75837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601283D")]
		[Address(RVA = "0x1710C10", Offset = "0x1710010", VA = "0x181710C10")]
		private static void OnVehicleDebrisStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601283E RID: 75838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601283E")]
		[Address(RVA = "0x1710C80", Offset = "0x1710080", VA = "0x181710C80")]
		private static void OnVehicleSeatBehaviourReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x0601283F RID: 75839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601283F")]
		[Address(RVA = "0x170F810", Offset = "0x170EC10", VA = "0x18170F810")]
		private static void OnMagazineStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012840 RID: 75840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012840")]
		[Address(RVA = "0x170F080", Offset = "0x170E480", VA = "0x18170F080")]
		private static void OnDroneStreamReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012841 RID: 75841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012841")]
		[Address(RVA = "0x1710480", Offset = "0x170F880", VA = "0x181710480")]
		private static void OnReceivedThrowableStream(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012842 RID: 75842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012842")]
		[Address(RVA = "0x1710360", Offset = "0x170F760", VA = "0x181710360")]
		private static void OnReceivedPickableStream(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012843 RID: 75843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012843")]
		[Address(RVA = "0x17104E0", Offset = "0x170F8E0", VA = "0x1817104E0")]
		private static void OnReceivedTreeStream(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012844 RID: 75844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012844")]
		[Address(RVA = "0x17103B0", Offset = "0x170F7B0", VA = "0x1817103B0")]
		private static void OnReceivedSupplyBoxStream(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012845 RID: 75845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012845")]
		[Address(RVA = "0x1710260", Offset = "0x170F660", VA = "0x181710260")]
		private static void OnReceivedAntiCheatPackage(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012846 RID: 75846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012846")]
		[Address(RVA = "0x170FD70", Offset = "0x170F170", VA = "0x18170FD70")]
		private static void OnPlayerSpectatorDataReceived(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 ser)
		{
		}

		// Token: 0x06012847 RID: 75847 RVA: 0x00073D54 File Offset: 0x00071F54
		[Token(Token = "0x6012847")]
		[Address(RVA = "0x170E940", Offset = "0x170DD40", VA = "0x18170E940")]
		public static byte GetEmptyRelativeID()
		{
			return 0;
		}

		// Token: 0x06012848 RID: 75848 RVA: 0x00073D6C File Offset: 0x00071F6C
		[Token(Token = "0x6012848")]
		[Address(RVA = "0x170E7D0", Offset = "0x170DBD0", VA = "0x18170E7D0")]
		public static ushort GetEmptyRelativeIDForNetwork()
		{
			return 0;
		}

		// Token: 0x06012849 RID: 75849 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6012849")]
		[Address(RVA = "0x170EAC0", Offset = "0x170DEC0", VA = "0x18170EAC0")]
		public static \u0302\u0305\u0302\u0306\u0308\u0308\u0302\u0308\u0303\u0304\u0308\u0304\u0307\u0308\u0302 GetMyRelativeObject(byte relativeID)
		{
			return null;
		}

		// Token: 0x0601284A RID: 75850 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x601284A")]
		[Address(RVA = "0x1711800", Offset = "0x1710C00", VA = "0x181711800")]
		public static ReplicaGadget SpawnReplica(GameObject prefab, byte relativeID, [Optional] Vector3 position, [Optional] Quaternion rotation)
		{
			return null;
		}

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private static bool <isListening>k__BackingField;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[touching_your_mom.FieldOffset(Offset = "0x4")]
		public static int ServerHz;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[touching_your_mom.FieldOffset(Offset = "0x8")]
		public static Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mExecutableReliablePackages;

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		public static Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mExecutableUnreliablePackages;

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		private static Queue<\u0302\u0301\u0303\u0306\u0303\u0305\u0306\u0308\u0307\u0303\u0307\u0301\u0301\u0305\u0305> mSpectatorDatas;

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		private static Action<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301>[] Functions;
	}
}
