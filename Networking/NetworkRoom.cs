using System;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006B5 RID: 1717
	[Token(Token = "0x20006B5")]
	public class NetworkRoom
	{
		// Token: 0x06012811 RID: 75793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012811")]
		[Address(RVA = "0x171F5E0", Offset = "0x171E9E0", VA = "0x18171F5E0")]
		public NetworkRoom(string roomName, string map, \u0305\u0303\u0301\u0307\u0304\u0304\u0308\u0308\u0304\u0303\u0302\u0301\u0301\u0301\u0303 time, \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304 mode, \u0302\u0303\u0306\u0307\u0301\u0301\u0305\u0304\u0303\u0301\u0308\u0304\u0305\u0305\u0302 type)
		{
		}

		// Token: 0x06012812 RID: 75794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012812")]
		[Address(RVA = "0x171F650", Offset = "0x171EA50", VA = "0x18171F650")]
		public NetworkRoom(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x06012813 RID: 75795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6012813")]
		[Address(RVA = "0x171F550", Offset = "0x171E950", VA = "0x18171F550")]
		public void WriteTo(ref \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 serializer)
		{
		}

		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		[FieldOffset(Offset = "0x10")]
		public string RoomName;

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0x18")]
		public string Map;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0x20")]
		public \u0305\u0303\u0301\u0307\u0304\u0304\u0308\u0308\u0304\u0303\u0302\u0301\u0301\u0301\u0303 MapTime;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x24")]
		public \u0306\u0304\u0308\u0308\u0303\u0308\u0304\u0308\u0308\u0306\u0303\u0305\u0302\u0306\u0304 GameMode;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x25")]
		public \u0302\u0303\u0306\u0307\u0301\u0301\u0305\u0304\u0303\u0301\u0308\u0304\u0305\u0305\u0302 GameType;
	}
}
