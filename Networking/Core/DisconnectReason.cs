using System;
using touching_your_mom;

namespace Networking.Core
{
	// Token: 0x020006CB RID: 1739
	[Token(Token = "0x20006CB")]
	public enum DisconnectReason
	{
		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		Unknown,
		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		RemoteConnectionRequestedToTerminate,
		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		Timeout,
		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		ManyExceptions,
		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		TooManyUnverifiedPackages,
		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		WeirdPackageIndex,
		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		SyncPackageWasNull,
		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x400335F")]
		ServerIsEndingGame,
		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		BannedFromServer,
		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		KickedFromServer,
		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		AntiCheatAuthFail,
		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		ServerChangedMap,
		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		WasAlreadyInGame,
		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		VersionDoesNotMatch,
		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		CorruptedGameFiles,
		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		ServerFull,
		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		PingLimit,
		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		AfkLimit
	}
}
