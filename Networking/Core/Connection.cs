using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using touching_your_mom;

namespace Networking.Core
{
	// Token: 0x020006C7 RID: 1735
	[Token(Token = "0x20006C7")]
	public class Connection
	{
		// Token: 0x060128B9 RID: 75961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128B9")]
		[Address(RVA = "0x17167E0", Offset = "0x1715BE0", VA = "0x1817167E0")]
		public Connection()
		{
		}

		// Token: 0x060128BA RID: 75962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128BA")]
		[Address(RVA = "0x1713250", Offset = "0x1712650", VA = "0x181713250")]
		public void Connect(UDPSocket socket, EndPoint destination, \u0303\u0304\u0306\u0302\u0304\u0302\u0305\u0305\u0304\u0308\u0301\u0308\u0306\u0302\u0304 mtu, bool isAppServer)
		{
		}

		// Token: 0x060128BB RID: 75963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128BB")]
		[Address(RVA = "0x1714B70", Offset = "0x1713F70", VA = "0x181714B70")]
		public void TickThread()
		{
		}

		// Token: 0x060128BC RID: 75964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128BC")]
		[Address(RVA = "0x1713590", Offset = "0x1712990", VA = "0x181713590")]
		public void EnqueueIncomingRawPackage(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck)
		{
		}

		// Token: 0x060128BD RID: 75965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128BD")]
		[Address(RVA = "0x17144C0", Offset = "0x17138C0", VA = "0x1817144C0")]
		public void SendUnreliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset)
		{
		}

		// Token: 0x060128BE RID: 75966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128BE")]
		[Address(RVA = "0x1713720", Offset = "0x1712B20", VA = "0x181713720")]
		public void SendReliable(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, int offset)
		{
		}

		// Token: 0x060128BF RID: 75967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128BF")]
		[Address(RVA = "0x1713430", Offset = "0x1712830", VA = "0x181713430")]
		public void Disconnect(bool sendBye, bool isUnityThread)
		{
		}

		// Token: 0x060128C0 RID: 75968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128C0")]
		[Address(RVA = "0x1712E40", Offset = "0x1712240", VA = "0x181712E40")]
		public void CollectPackagesClient(ref Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> reliablePackages, ref Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> unreliablePackages)
		{
		}

		// Token: 0x060128C1 RID: 75969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128C1")]
		[Address(RVA = "0x1713070", Offset = "0x1712470", VA = "0x181713070")]
		public void CollectPackagesServer(ref Queue<NetworkPackage> reliablePackages, ref Queue<NetworkPackage> unreliablePackages)
		{
		}

		// Token: 0x060128C2 RID: 75970 RVA: 0x00073F04 File Offset: 0x00072104
		[Token(Token = "0x60128C2")]
		[Address(RVA = "0x1716230", Offset = "0x1715630", VA = "0x181716230")]
		public bool TryCollectReliablePackage(out \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck)
		{
			return default(bool);
		}

		// Token: 0x060128C3 RID: 75971 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128C3")]
		[Address(RVA = "0x1716750", Offset = "0x1715B50", VA = "0x181716750")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1448B0", Offset = "0x143CB0")]
		public IEnumerable WaitForReliablePackage(LO<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> package)
		{
			return null;
		}

		// Token: 0x060128C4 RID: 75972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128C4")]
		[Address(RVA = "0x17175E0", Offset = "0x17169E0", VA = "0x1817175E0")]
		private void mWriteVerifyIndexes()
		{
		}

		// Token: 0x060128C5 RID: 75973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128C5")]
		[Address(RVA = "0x1717440", Offset = "0x1716840", VA = "0x181717440")]
		private void mSendUnreliableAndReset()
		{
		}

		// Token: 0x060128C6 RID: 75974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128C6")]
		[Address(RVA = "0x1716D40", Offset = "0x1716140", VA = "0x181716D40")]
		private void mReset()
		{
		}

		// Token: 0x060128C7 RID: 75975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128C7")]
		[Address(RVA = "0x1716390", Offset = "0x1715790", VA = "0x181716390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private void <TickThread>g__processReliable|41_0(\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 pck, PackageType type)
		{
		}

		// Token: 0x060128C8 RID: 75976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128C8")]
		[Address(RVA = "0x17166B0", Offset = "0x1715AB0", VA = "0x1817166B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private void <TickThread>g__processVerifyIndex|41_1(uint index)
		{
		}

		// Token: 0x04003324 RID: 13092
		[Token(Token = "0x4003324")]
		public const int MaxPing = 600;

		// Token: 0x04003325 RID: 13093
		[Token(Token = "0x4003325")]
		public const int MaxUnverifiedPackageCount = 4096;

		// Token: 0x04003326 RID: 13094
		[Token(Token = "0x4003326")]
		public const int Timeout = 32000;

		// Token: 0x04003327 RID: 13095
		[Token(Token = "0x4003327")]
		public const int MaxFutureIndexPackage = 256;

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		public const int VerifyPackageBatchTick = 64;

		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		public const int VerifyPackageBatchTickTimeout = 256;

		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		[FieldOffset(Offset = "0x10")]
		public UDPSocket Socket;

		// Token: 0x0400332B RID: 13099
		[Token(Token = "0x400332B")]
		[FieldOffset(Offset = "0x18")]
		public \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 GameClient;

		// Token: 0x0400332C RID: 13100
		[Token(Token = "0x400332C")]
		[FieldOffset(Offset = "0x20")]
		public bool IsConnected;

		// Token: 0x0400332D RID: 13101
		[Token(Token = "0x400332D")]
		[FieldOffset(Offset = "0x28")]
		public EndPoint Destination;

		// Token: 0x0400332E RID: 13102
		[Token(Token = "0x400332E")]
		[FieldOffset(Offset = "0x30")]
		public long PingMs;

		// Token: 0x0400332F RID: 13103
		[Token(Token = "0x400332F")]
		[FieldOffset(Offset = "0x38")]
		public float PingFloat;

		// Token: 0x04003330 RID: 13104
		[Token(Token = "0x4003330")]
		[FieldOffset(Offset = "0x3C")]
		public DisconnectReason Reason;

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[FieldOffset(Offset = "0x40")]
		public int MTU;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[FieldOffset(Offset = "0x48")]
		private object mOperationLock;

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[FieldOffset(Offset = "0x50")]
		private int mMaxUnreliableDelay;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[FieldOffset(Offset = "0x54")]
		private int mMaxReliableDelay;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[FieldOffset(Offset = "0x58")]
		private long mLastUnreliableSent;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x60")]
		private long mLastReliableSent;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x68")]
		private uint mUploadReliableSequanceIndex;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x6C")]
		private uint mDownloadReliableSequanceIndex;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x70")]
		private long mLastPingSent;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x78")]
		private bool mDisconnectFlag;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x79")]
		private bool mIsServer;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x80")]
		private long mLastVerifyIndexesBroadcasted;

		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x400333D")]
		[FieldOffset(Offset = "0x88")]
		private long mLastPackageReceived;

		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x400333E")]
		[FieldOffset(Offset = "0x90")]
		private Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mIncomingRawPackages;

		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x400333F")]
		[FieldOffset(Offset = "0x98")]
		private Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mFragmentedPackages;

		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x4003340")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<uint, \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mReceivedFuturePackages;

		// Token: 0x04003341 RID: 13121
		[Token(Token = "0x4003341")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<uint, Connection.mUnverifiedPacakge> mOutgoingUnverifiedPackages;

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[FieldOffset(Offset = "0xB0")]
		private Queue<uint> mOutgoingUnverifiedPackagesResetQueue;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0xB8")]
		private Connection.mVerifyIndexQueue mOutgoingVerifyIndexes;

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[FieldOffset(Offset = "0xC0")]
		private Stopwatch mPingCounter;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[FieldOffset(Offset = "0xC8")]
		private byte[] mPingRequestBuffer;

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[FieldOffset(Offset = "0xD0")]
		private \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 mReliableStream;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[FieldOffset(Offset = "0xD8")]
		private \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 mUnreliableStream;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[FieldOffset(Offset = "0xE0")]
		private Random mRandom;

		// Token: 0x04003349 RID: 13129
		[Token(Token = "0x4003349")]
		[FieldOffset(Offset = "0xE8")]
		private Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mExecutableReliablePackages;

		// Token: 0x0400334A RID: 13130
		[Token(Token = "0x400334A")]
		[FieldOffset(Offset = "0xF0")]
		private Queue<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> mExecutableUnreliablePackages;

		// Token: 0x020006C8 RID: 1736
		[Token(Token = "0x20006C8")]
		private struct mUnverifiedPacakge
		{
			// Token: 0x060128C9 RID: 75977 RVA: 0x00073F1C File Offset: 0x0007211C
			[Token(Token = "0x60128C9")]
			[Address(RVA = "0x1732EC0", Offset = "0x17322C0", VA = "0x181732EC0")]
			public static long GetResendTime(long ping)
			{
				return 0L;
			}

			// Token: 0x0400334B RID: 13131
			[Token(Token = "0x400334B")]
			[FieldOffset(Offset = "0x0")]
			public long ResendTime;

			// Token: 0x0400334C RID: 13132
			[Token(Token = "0x400334C")]
			[FieldOffset(Offset = "0x8")]
			public \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 Package;
		}

		// Token: 0x020006C9 RID: 1737
		[Token(Token = "0x20006C9")]
		private class mVerifyIndexQueue
		{
			// Token: 0x060128CA RID: 75978 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60128CA")]
			[Address(RVA = "0x1733100", Offset = "0x1732500", VA = "0x181733100")]
			public mVerifyIndexQueue()
			{
			}

			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x060128CB RID: 75979 RVA: 0x00073F34 File Offset: 0x00072134
			[Token(Token = "0x17000A44")]
			public int Count
			{
				[Token(Token = "0x60128CB")]
				[Address(RVA = "0x17331A0", Offset = "0x17325A0", VA = "0x1817331A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060128CC RID: 75980 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60128CC")]
			[Address(RVA = "0x1733070", Offset = "0x1732470", VA = "0x181733070")]
			public void Enqueue(uint index)
			{
			}

			// Token: 0x060128CD RID: 75981 RVA: 0x00073F4C File Offset: 0x0007214C
			[Token(Token = "0x60128CD")]
			[Address(RVA = "0x1732FF0", Offset = "0x17323F0", VA = "0x181732FF0")]
			public uint Dequeue()
			{
				return 0U;
			}

			// Token: 0x060128CE RID: 75982 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60128CE")]
			[Address(RVA = "0x1732F90", Offset = "0x1732390", VA = "0x181732F90")]
			public void Clear()
			{
			}

			// Token: 0x0400334D RID: 13133
			[Token(Token = "0x400334D")]
			[FieldOffset(Offset = "0x10")]
			private HashSet<uint> mMap;

			// Token: 0x0400334E RID: 13134
			[Token(Token = "0x400334E")]
			[FieldOffset(Offset = "0x18")]
			private Queue<uint> mQueue;
		}

		// Token: 0x020006CA RID: 1738
		[Token(Token = "0x20006CA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private sealed class <WaitForReliablePackage>d__49 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060128CF RID: 75983 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60128CF")]
			[Address(RVA = "0xA978A0", Offset = "0xA96CA0", VA = "0x180A978A0")]
			[DebuggerHidden]
			public <WaitForReliablePackage>d__49(int <>1__state)
			{
			}

			// Token: 0x060128D0 RID: 75984 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60128D0")]
			[Address(RVA = "0x8AA580", Offset = "0x8A9980", VA = "0x1808AA580", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060128D1 RID: 75985 RVA: 0x00073F64 File Offset: 0x00072164
			[Token(Token = "0x60128D1")]
			[Address(RVA = "0x1732C80", Offset = "0x1732080", VA = "0x181732C80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x060128D2 RID: 75986 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000A45")]
			private object Current
			{
				[Token(Token = "0x60128D2")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060128D3 RID: 75987 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60128D3")]
			[Address(RVA = "0x1732E70", Offset = "0x1732270", VA = "0x181732E70", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x060128D4 RID: 75988 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x17000A46")]
			private object Current
			{
				[Token(Token = "0x60128D4")]
				[Address(RVA = "0x8ADC40", Offset = "0x8AD040", VA = "0x1808ADC40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060128D5 RID: 75989 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x60128D5")]
			[Address(RVA = "0x1732DC0", Offset = "0x17321C0", VA = "0x181732DC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060128D6 RID: 75990 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x60128D6")]
			[Address(RVA = "0x1732DC0", Offset = "0x17321C0", VA = "0x181732DC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400334F RID: 13135
			[Token(Token = "0x400334F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04003350 RID: 13136
			[Token(Token = "0x4003350")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04003351 RID: 13137
			[Token(Token = "0x4003351")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04003352 RID: 13138
			[Token(Token = "0x4003352")]
			[FieldOffset(Offset = "0x28")]
			public Connection <>4__this;

			// Token: 0x04003353 RID: 13139
			[Token(Token = "0x4003353")]
			[FieldOffset(Offset = "0x30")]
			private LO<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> package;

			// Token: 0x04003354 RID: 13140
			[Token(Token = "0x4003354")]
			[FieldOffset(Offset = "0x38")]
			public LO<\u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301> <>3__package;

			// Token: 0x04003355 RID: 13141
			[Token(Token = "0x4003355")]
			[FieldOffset(Offset = "0x40")]
			private Stopwatch <clock>5__2;

			// Token: 0x04003356 RID: 13142
			[Token(Token = "0x4003356")]
			[FieldOffset(Offset = "0x48")]
			private \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 <pck>5__3;
		}
	}
}
