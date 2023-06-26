using System;
using touching_your_mom;

namespace Networking.Core
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	public enum PackageType : byte
	{
		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		Browser_ServerInfoRequest = 128,
		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		Browser_PingRequest,
		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		Game_Hail = 127,
		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		Game_Reliable = 1,
		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		Game_Unreliable,
		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		Game_PingResponse = 5,
		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		Game_ReliableFragmantedData,
		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		Game_ReliableFragmantedEnd,
		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		Game_PingRequest,
		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		Game_Disconnect = 255,
		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		ServerDeployer_PingRequest = 200,
		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		ServerDeployer_ConsoleExecute,
		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		RemoteControl_Request = 233,
		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		MTUDiscovery_Request = 240,
		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		Connecting_Accepted = 244,
		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		Connecting_ReservedSlotExpired,
		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		Connecting_InvalidToken,
		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		Connecting_DenyJoin = 252,
		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		Connecting_QueueIndex,
		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		Connecting_MapRequest = 130,
		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		Connecting_KeepAlive,
		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		SlotReserving_SlotReserved = 247,
		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		SlotReserving_InvalidSteamTicket,
		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		SlotReserving_WrongPassword,
		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		SlotReserving_ServerFull,
		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		SlotReserving_ReserveSlot
	}
}
