using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using touching_your_mom;

namespace Networking.Core
{
	// Token: 0x020006CC RID: 1740
	[Token(Token = "0x20006CC")]
	public class NativeUDPSocket : IDisposable
	{
		// Token: 0x060128D7 RID: 75991
		[Token(Token = "0x60128D7")]
		[Address(RVA = "0x171A180", Offset = "0x1719580", VA = "0x18171A180")]
		[PreserveSig]
		private static extern IntPtr WSASocket([In] AddressFamily addressFamily, [In] SocketType socketType, [In] ProtocolType protocolType, [In] IntPtr protocolInfo, [In] uint group, [In] NativeUDPSocket.SocketConstructorFlags flags);

		// Token: 0x060128D8 RID: 75992
		[Token(Token = "0x60128D8")]
		[Address(RVA = "0x171AD10", Offset = "0x171A110", VA = "0x18171AD10")]
		[Attribute(Name = "ReliabilityContractAttribute", RVA = "0x144E80", Offset = "0x144280")]
		[PreserveSig]
		private static extern SocketError ioctlsocket([In] IntPtr socketHandle, [In] int cmd, [In] [Out] ref int argp);

		// Token: 0x060128D9 RID: 75993
		[Token(Token = "0x60128D9")]
		[Address(RVA = "0x171A780", Offset = "0x1719B80", VA = "0x18171A780")]
		[PreserveSig]
		private static extern SocketError bind([In] IntPtr socketHandle, [In] byte[] socketAddress, [In] int socketAddressSize);

		// Token: 0x060128DA RID: 75994
		[Token(Token = "0x60128DA")]
		[Address(RVA = "0x171AEE0", Offset = "0x171A2E0", VA = "0x18171AEE0")]
		[PreserveSig]
		private unsafe static extern int sendto([In] IntPtr socketHandle, [In] byte* pinnedBuffer, [In] int len, [In] SocketFlags socketFlags, [In] byte[] socketAddress, [In] int socketAddressSize);

		// Token: 0x060128DB RID: 75995
		[Token(Token = "0x60128DB")]
		[Address(RVA = "0x171ADB0", Offset = "0x171A1B0", VA = "0x18171ADB0")]
		[PreserveSig]
		private unsafe static extern int recvfrom([In] IntPtr socketHandle, [In] byte* pinnedBuffer, [In] int len, [In] SocketFlags socketFlags, [Out] byte[] socketAddress, [In] [Out] ref int socketAddressSize);

		// Token: 0x060128DC RID: 75996
		[Token(Token = "0x60128DC")]
		[Address(RVA = "0x171A250", Offset = "0x1719650", VA = "0x18171A250")]
		[PreserveSig]
		private static extern SocketError WSAStartup([In] short wVersionRequested, out NativeUDPSocket.WSAData lpWSAData);

		// Token: 0x060128DD RID: 75997
		[Token(Token = "0x60128DD")]
		[Address(RVA = "0x171B1D0", Offset = "0x171A5D0", VA = "0x18171B1D0")]
		[PreserveSig]
		private static extern SocketError shutdown([In] IntPtr socketHandle, [In] int how);

		// Token: 0x060128DE RID: 75998
		[Token(Token = "0x60128DE")]
		[Address(RVA = "0x171AC50", Offset = "0x171A050", VA = "0x18171AC50")]
		[PreserveSig]
		private static extern SocketError getsockopt([In] IntPtr socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, out int optionValue, [In] [Out] ref int optionLength);

		// Token: 0x060128DF RID: 75999
		[Token(Token = "0x60128DF")]
		[Address(RVA = "0x171B110", Offset = "0x171A510", VA = "0x18171B110")]
		[PreserveSig]
		internal static extern SocketError setsockopt([In] IntPtr socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] ref int optionValue, [In] int optionLength);

		// Token: 0x060128E0 RID: 76000
		[Token(Token = "0x60128E0")]
		[Address(RVA = "0x171A830", Offset = "0x1719C30", VA = "0x18171A830")]
		[PreserveSig]
		public static extern int closesocket(IntPtr s);

		// Token: 0x060128E1 RID: 76001
		[Token(Token = "0x60128E1")]
		[Address(RVA = "0x171A110", Offset = "0x1719510", VA = "0x18171A110")]
		[PreserveSig]
		private static extern int WSAGetLastError();

		// Token: 0x060128E2 RID: 76002
		[Token(Token = "0x60128E2")]
		[Address(RVA = "0x1718640", Offset = "0x1717A40", VA = "0x181718640")]
		[PreserveSig]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x060128E3 RID: 76003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128E3")]
		[Address(RVA = "0x171A4D0", Offset = "0x17198D0", VA = "0x18171A4D0")]
		public NativeUDPSocket(bool blockingMode, int bufferSize)
		{
		}

		// Token: 0x060128E4 RID: 76004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128E4")]
		[Address(RVA = "0x171A3D0", Offset = "0x17197D0", VA = "0x18171A3D0")]
		public NativeUDPSocket(IntPtr handle, object writeObject)
		{
		}

		// Token: 0x060128E5 RID: 76005 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128E5")]
		[Address(RVA = "0x1718F10", Offset = "0x1718310", VA = "0x181718F10")]
		private object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			return null;
		}

		// Token: 0x060128E6 RID: 76006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128E6")]
		[Address(RVA = "0x17199C0", Offset = "0x1718DC0", VA = "0x1817199C0")]
		private void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060128E7 RID: 76007 RVA: 0x00073F7C File Offset: 0x0007217C
		// (set) Token: 0x060128E8 RID: 76008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A47")]
		public int ReceiveBufferSize
		{
			[Token(Token = "0x60128E7")]
			[Address(RVA = "0x171AB50", Offset = "0x1719F50", VA = "0x18171AB50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60128E8")]
			[Address(RVA = "0x171AFF0", Offset = "0x171A3F0", VA = "0x18171AFF0")]
			set
			{
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060128E9 RID: 76009 RVA: 0x00073F94 File Offset: 0x00072194
		// (set) Token: 0x060128EA RID: 76010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A48")]
		public int SendBufferSize
		{
			[Token(Token = "0x60128E9")]
			[Address(RVA = "0x171ABD0", Offset = "0x1719FD0", VA = "0x18171ABD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60128EA")]
			[Address(RVA = "0x171B080", Offset = "0x171A480", VA = "0x18171B080")]
			set
			{
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060128EB RID: 76011 RVA: 0x00073FAC File Offset: 0x000721AC
		// (set) Token: 0x060128EC RID: 76012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A49")]
		public bool DontFragment
		{
			[Token(Token = "0x60128EB")]
			[Address(RVA = "0x171AAD0", Offset = "0x1719ED0", VA = "0x18171AAD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60128EC")]
			[Address(RVA = "0x171AFC0", Offset = "0x171A3C0", VA = "0x18171AFC0")]
			set
			{
			}
		}

		// Token: 0x060128ED RID: 76013 RVA: 0x00073FC4 File Offset: 0x000721C4
		[Token(Token = "0x60128ED")]
		[Address(RVA = "0x1719530", Offset = "0x1718930", VA = "0x181719530")]
		public int SendTo(byte[] buffer, int offset, int size, ref EndPoint endPoint)
		{
			return 0;
		}

		// Token: 0x060128EE RID: 76014 RVA: 0x00073FDC File Offset: 0x000721DC
		[Token(Token = "0x60128EE")]
		[Address(RVA = "0x1719390", Offset = "0x1718790", VA = "0x181719390")]
		public int ReceiveFrom(byte[] buffer, int offset, int size, ref EndPoint sender)
		{
			return 0;
		}

		// Token: 0x060128EF RID: 76015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128EF")]
		[Address(RVA = "0x1719AE0", Offset = "0x1718EE0", VA = "0x181719AE0")]
		public void Shutdown(SocketShutdown how)
		{
		}

		// Token: 0x060128F0 RID: 76016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128F0")]
		[Address(RVA = "0x17186C0", Offset = "0x1717AC0", VA = "0x1817186C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060128F1 RID: 76017 RVA: 0x00073FF4 File Offset: 0x000721F4
		[Token(Token = "0x60128F1")]
		[Address(RVA = "0x1718940", Offset = "0x1717D40", VA = "0x181718940")]
		public int GetAvailable()
		{
			return 0;
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060128F2 RID: 76018 RVA: 0x0007400C File Offset: 0x0007220C
		[Token(Token = "0x17000A4A")]
		public int Available
		{
			[Token(Token = "0x60128F2")]
			[Address(RVA = "0x1718940", Offset = "0x1717D40", VA = "0x181718940")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060128F3 RID: 76019 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128F3")]
		[Address(RVA = "0x171A8C0", Offset = "0x1719CC0", VA = "0x18171A8C0")]
		private byte[] getAddressBytesFromCache(EndPoint ep)
		{
			return null;
		}

		// Token: 0x060128F4 RID: 76020 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128F4")]
		[Address(RVA = "0x171A9E0", Offset = "0x1719DE0", VA = "0x18171A9E0")]
		private EndPoint getEndPointFromCache(byte[] bytes)
		{
			return null;
		}

		// Token: 0x060128F5 RID: 76021 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128F5")]
		[Address(RVA = "0x1718A10", Offset = "0x1717E10", VA = "0x181718A10")]
		public EndPoint GetEndPointFromHash(ulong hash)
		{
			return null;
		}

		// Token: 0x060128F6 RID: 76022 RVA: 0x00074024 File Offset: 0x00072224
		[Token(Token = "0x60128F6")]
		[Address(RVA = "0x1718B60", Offset = "0x1717F60", VA = "0x181718B60")]
		public ulong GetHashFromEndPoint(EndPoint destination)
		{
			return 0UL;
		}

		// Token: 0x060128F7 RID: 76023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128F7")]
		[Address(RVA = "0x1719130", Offset = "0x1718530", VA = "0x181719130")]
		private static void InitializeSockets()
		{
		}

		// Token: 0x060128F8 RID: 76024 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128F8")]
		[Address(RVA = "0x1719920", Offset = "0x1718D20", VA = "0x181719920")]
		public static byte[] Serialize(SocketAddress add)
		{
			return null;
		}

		// Token: 0x060128F9 RID: 76025 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128F9")]
		[Address(RVA = "0x1719820", Offset = "0x1718C20", VA = "0x181719820")]
		public static byte[] Serialize(EndPoint point)
		{
			return null;
		}

		// Token: 0x060128FA RID: 76026 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128FA")]
		[Address(RVA = "0x17198A0", Offset = "0x1718CA0", VA = "0x1817198A0")]
		public static byte[] Serialize(IPEndPoint point)
		{
			return null;
		}

		// Token: 0x060128FB RID: 76027 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128FB")]
		[Address(RVA = "0x1719C50", Offset = "0x1719050", VA = "0x181719C50")]
		public static EndPoint ToEndPoint(byte[] bytes)
		{
			return null;
		}

		// Token: 0x060128FC RID: 76028 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128FC")]
		[Address(RVA = "0x1719F60", Offset = "0x1719360", VA = "0x181719F60")]
		public static IPEndPoint ToIPEndPoint(byte[] bytes)
		{
			return null;
		}

		// Token: 0x060128FD RID: 76029 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128FD")]
		[Address(RVA = "0x1719BF0", Offset = "0x1718FF0", VA = "0x181719BF0")]
		public static byte[] ToBytes(ulong hash)
		{
			return null;
		}

		// Token: 0x060128FE RID: 76030 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128FE")]
		[Address(RVA = "0x1719EB0", Offset = "0x17192B0", VA = "0x181719EB0")]
		public static IPEndPoint ToIPEndPoint(ulong hash)
		{
			return null;
		}

		// Token: 0x060128FF RID: 76031 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128FF")]
		[Address(RVA = "0x1719E00", Offset = "0x1719200", VA = "0x181719E00")]
		public static EndPoint ToEndPoint(ulong hash)
		{
			return null;
		}

		// Token: 0x06012900 RID: 76032 RVA: 0x0007403C File Offset: 0x0007223C
		[Token(Token = "0x6012900")]
		[Address(RVA = "0x1718BD0", Offset = "0x1717FD0", VA = "0x181718BD0")]
		public static ulong GetHash(byte[] buffer)
		{
			return 0UL;
		}

		// Token: 0x06012901 RID: 76033 RVA: 0x00074054 File Offset: 0x00072254
		[Token(Token = "0x6012901")]
		[Address(RVA = "0x1718EC0", Offset = "0x17182C0", VA = "0x181718EC0")]
		public static int GetPort(byte[] buffer)
		{
			return 0;
		}

		// Token: 0x06012902 RID: 76034 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6012902")]
		[Address(RVA = "0x1718DB0", Offset = "0x17181B0", VA = "0x181718DB0")]
		public static IPAddress GetIPv4Address(byte[] buffer)
		{
			return null;
		}

		// Token: 0x06012903 RID: 76035 RVA: 0x0007406C File Offset: 0x0007226C
		[Token(Token = "0x6012903")]
		[Address(RVA = "0x1718D10", Offset = "0x1718110", VA = "0x181718D10")]
		public static long GetIPv4AddressLong(byte[] buffer)
		{
			return 0L;
		}

		// Token: 0x06012904 RID: 76036 RVA: 0x00074084 File Offset: 0x00072284
		[Token(Token = "0x6012904")]
		[Address(RVA = "0x1719A50", Offset = "0x1718E50", VA = "0x181719A50")]
		public static SocketError SetSocketOption(IntPtr handle, SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			return SocketError.Success;
		}

		// Token: 0x06012905 RID: 76037 RVA: 0x0007409C File Offset: 0x0007229C
		[Token(Token = "0x6012905")]
		[Address(RVA = "0x1719030", Offset = "0x1718430", VA = "0x181719030")]
		public static int GetSocketOption(IntPtr handle, SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			return 0;
		}

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		private const string WS2_32 = "ws2_32.dll";

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		private const string mswsock = "mswsock.dll";

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[touching_your_mom.FieldOffset(Offset = "0x10")]
		private bool m_Disposed;

		// Token: 0x0400336D RID: 13165
		[Token(Token = "0x400336D")]
		[touching_your_mom.FieldOffset(Offset = "0x18")]
		private Dictionary<EndPoint, byte[]> m_AddressCache;

		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		[touching_your_mom.FieldOffset(Offset = "0x20")]
		private Dictionary<ulong, EndPoint> m_AddressLongMap;

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[touching_your_mom.FieldOffset(Offset = "0x28")]
		private Dictionary<ulong, EndPoint> m_AddressMap;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[touching_your_mom.FieldOffset(Offset = "0x30")]
		public IntPtr m_Handle;

		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		[touching_your_mom.FieldOffset(Offset = "0x38")]
		public object mWriteObject;

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		private static bool s_Initialized;

		// Token: 0x020006CD RID: 1741
		[Token(Token = "0x20006CD")]
		[Flags]
		private enum SocketConstructorFlags
		{
			// Token: 0x04003374 RID: 13172
			[Token(Token = "0x4003374")]
			WSA_FLAG_OVERLAPPED = 1,
			// Token: 0x04003375 RID: 13173
			[Token(Token = "0x4003375")]
			WSA_FLAG_MULTIPOINT_C_ROOT = 2,
			// Token: 0x04003376 RID: 13174
			[Token(Token = "0x4003376")]
			WSA_FLAG_MULTIPOINT_C_LEAF = 4,
			// Token: 0x04003377 RID: 13175
			[Token(Token = "0x4003377")]
			WSA_FLAG_MULTIPOINT_D_ROOT = 8,
			// Token: 0x04003378 RID: 13176
			[Token(Token = "0x4003378")]
			WSA_FLAG_MULTIPOINT_D_LEAF = 16
		}

		// Token: 0x020006CE RID: 1742
		[Token(Token = "0x20006CE")]
		private struct WSAData
		{
			// Token: 0x04003379 RID: 13177
			[Token(Token = "0x4003379")]
			[touching_your_mom.FieldOffset(Offset = "0x0")]
			internal short wVersion;

			// Token: 0x0400337A RID: 13178
			[Token(Token = "0x400337A")]
			[touching_your_mom.FieldOffset(Offset = "0x2")]
			internal short wHighVersion;

			// Token: 0x0400337B RID: 13179
			[Token(Token = "0x400337B")]
			[touching_your_mom.FieldOffset(Offset = "0x8")]
			internal string szDescription;

			// Token: 0x0400337C RID: 13180
			[Token(Token = "0x400337C")]
			[touching_your_mom.FieldOffset(Offset = "0x10")]
			internal string szSystemStatus;

			// Token: 0x0400337D RID: 13181
			[Token(Token = "0x400337D")]
			[touching_your_mom.FieldOffset(Offset = "0x18")]
			internal short iMaxSockets;

			// Token: 0x0400337E RID: 13182
			[Token(Token = "0x400337E")]
			[touching_your_mom.FieldOffset(Offset = "0x1A")]
			internal short iMaxUdpDg;

			// Token: 0x0400337F RID: 13183
			[Token(Token = "0x400337F")]
			[touching_your_mom.FieldOffset(Offset = "0x20")]
			internal IntPtr lpVendorInfo;
		}
	}
}
