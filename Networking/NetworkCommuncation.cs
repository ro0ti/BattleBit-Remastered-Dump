using System;
using touching_your_mom;

namespace Networking
{
	// Token: 0x020006BC RID: 1724
	[Token(Token = "0x20006BC")]
	public enum NetworkCommuncation : byte
	{
		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		NetworkPadding,
		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		ClientConnected,
		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		ClientDisconnected,
		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		RPC,
		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		Stream,
		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		SpawnObject,
		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		DestroyObject,
		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		VoiceOverIP,
		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		PlayerSpawn,
		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		ForceSpawn,
		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		VehicleStream,
		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		PlayerPositionStream,
		// Token: 0x040032BF RID: 12991
		[Token(Token = "0x40032BF")]
		BodyHitRequest,
		// Token: 0x040032C0 RID: 12992
		[Token(Token = "0x40032C0")]
		ArmorHitRequest,
		// Token: 0x040032C1 RID: 12993
		[Token(Token = "0x40032C1")]
		SetTime,
		// Token: 0x040032C2 RID: 12994
		[Token(Token = "0x40032C2")]
		SpawnVehicle,
		// Token: 0x040032C3 RID: 12995
		[Token(Token = "0x40032C3")]
		SavePrefs,
		// Token: 0x040032C4 RID: 12996
		[Token(Token = "0x40032C4")]
		GadgetRPC,
		// Token: 0x040032C5 RID: 12997
		[Token(Token = "0x40032C5")]
		CombinedReliable,
		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		ThrownGadgetStream,
		// Token: 0x040032C7 RID: 12999
		[Token(Token = "0x40032C7")]
		ReplicaGadgetStream,
		// Token: 0x040032C8 RID: 13000
		[Token(Token = "0x40032C8")]
		VehicleDebrisStream,
		// Token: 0x040032C9 RID: 13001
		[Token(Token = "0x40032C9")]
		VehicleSeatBehaviourStream,
		// Token: 0x040032CA RID: 13002
		[Token(Token = "0x40032CA")]
		PlayerPerspective,
		// Token: 0x040032CB RID: 13003
		[Token(Token = "0x40032CB")]
		MagazineStream,
		// Token: 0x040032CC RID: 13004
		[Token(Token = "0x40032CC")]
		DroneStream,
		// Token: 0x040032CD RID: 13005
		[Token(Token = "0x40032CD")]
		ThrowableStream,
		// Token: 0x040032CE RID: 13006
		[Token(Token = "0x40032CE")]
		PickableStream,
		// Token: 0x040032CF RID: 13007
		[Token(Token = "0x40032CF")]
		TreeStream,
		// Token: 0x040032D0 RID: 13008
		[Token(Token = "0x40032D0")]
		SupplyBoxStream,
		// Token: 0x040032D1 RID: 13009
		[Token(Token = "0x40032D1")]
		AntiCheatSnapshot,
		// Token: 0x040032D2 RID: 13010
		[Token(Token = "0x40032D2")]
		ServerSnapshot,
		// Token: 0x040032D3 RID: 13011
		[Token(Token = "0x40032D3")]
		ClientTick,
		// Token: 0x040032D4 RID: 13012
		[Token(Token = "0x40032D4")]
		ProjectileExplosionRequest,
		// Token: 0x040032D5 RID: 13013
		[Token(Token = "0x40032D5")]
		PlayerSpectatorData,
		// Token: 0x040032D6 RID: 13014
		[Token(Token = "0x40032D6")]
		Count
	}
}
