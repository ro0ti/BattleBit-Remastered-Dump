using System;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006B6 RID: 1718
	[Token(Token = "0x20006B6")]
	public enum NetworkFail : byte
	{
		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		UnknownError,
		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		NoResponse,
		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		ServerIsFull,
		// Token: 0x04003281 RID: 12929
		[Token(Token = "0x4003281")]
		UnmatchVersion,
		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		Banned,
		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		SameSteamIDPlayerAlreadyPlaying,
		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		SteamVacAuthFail,
		// Token: 0x04003285 RID: 12933
		[Token(Token = "0x4003285")]
		HailSteamIDsDoesNotMatch,
		// Token: 0x04003286 RID: 12934
		[Token(Token = "0x4003286")]
		VersionMatchFail,
		// Token: 0x04003287 RID: 12935
		[Token(Token = "0x4003287")]
		SteamWebApiFail,
		// Token: 0x04003288 RID: 12936
		[Token(Token = "0x4003288")]
		BannedFromMasterServer,
		// Token: 0x04003289 RID: 12937
		[Token(Token = "0x4003289")]
		UnableToParseMasterServerData,
		// Token: 0x0400328A RID: 12938
		[Token(Token = "0x400328A")]
		RankUnmatch,
		// Token: 0x0400328B RID: 12939
		[Token(Token = "0x400328B")]
		AntiCheatAuthFail,
		// Token: 0x0400328C RID: 12940
		[Token(Token = "0x400328C")]
		SteamVerifyFail,
		// Token: 0x0400328D RID: 12941
		[Token(Token = "0x400328D")]
		QueueCanceled,
		// Token: 0x0400328E RID: 12942
		[Token(Token = "0x400328E")]
		QueueOrderMismatch,
		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		ServerChangedMap,
		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		MissingTicket,
		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		AlreadyInGame,
		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		CorruptedGameFiles,
		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		InvalidToken = 246,
		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		InvalidSteamTicket = 248,
		// Token: 0x04003295 RID: 12949
		[Token(Token = "0x4003295")]
		AlreadyInQueue,
		// Token: 0x04003296 RID: 12950
		[Token(Token = "0x4003296")]
		ServerFull,
		// Token: 0x04003297 RID: 12951
		[Token(Token = "0x4003297")]
		ReservedSlotExpired,
		// Token: 0x04003298 RID: 12952
		[Token(Token = "0x4003298")]
		Success = 127,
		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		WrongMapLoaded = 252
	}
}
