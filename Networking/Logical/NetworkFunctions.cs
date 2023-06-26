using System;
using touching_your_mom;
using UnityEngine;

namespace Networking.Logical
{
	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x20006C4")]
	public static class NetworkFunctions
	{
		// Token: 0x0601289F RID: 75935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x601289F")]
		[Address(RVA = "0x171D7F0", Offset = "0x171CBF0", VA = "0x18171D7F0")]
		public static void SafeDestroy(GameObject obj)
		{
		}

		// Token: 0x060128A0 RID: 75936 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x60128A0")]
		[Address(RVA = "0x171DB10", Offset = "0x171CF10", VA = "0x18171DB10")]
		public static GameObject SpawnNetworkObject(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 owner, ushort ID, string Prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x060128A1 RID: 75937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A1")]
		[Address(RVA = "0x171DC40", Offset = "0x171D040", VA = "0x18171DC40")]
		public static void SpawnOnSyncReadPlayer(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 owner)
		{
		}

		// Token: 0x060128A2 RID: 75938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A2")]
		[Address(RVA = "0x171DDF0", Offset = "0x171D1F0", VA = "0x18171DDF0")]
		public static void SpawnThePlayer(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client, \u0308\u0304\u0301\u0304\u0302\u0301\u0306\u0303\u0304\u0305\u0304\u0303\u0304\u0308\u0308 loadout, \u0303\u0305\u0304\u0304\u0301\u0301\u0302\u0301\u0302\u0306\u0306\u0306\u0308\u0304\u0306 skin, Vector3 position, Vector3 direction, \u0303\u0303\u0302\u0301\u0308\u0301\u0305\u0308\u0306\u0303\u0307\u0306\u0304\u0303\u0302 standing, float spawnProtection = 5f)
		{
		}

		// Token: 0x060128A3 RID: 75939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A3")]
		[Address(RVA = "0x171D470", Offset = "0x171C870", VA = "0x18171D470")]
		public static void Request_PlayerHit_ClientSide(ulong player, ushort shotID, \u0308\u0305\u0303\u0306\u0302\u0305\u0302\u0307\u0304\u0301\u0304\u0301\u0307\u0301\u0305 body)
		{
		}

		// Token: 0x060128A4 RID: 75940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A4")]
		[Address(RVA = "0x171C710", Offset = "0x171BB10", VA = "0x18171C710")]
		public static void Received_PlayerHitRequest_ServerSide(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender, ushort shotID, ulong target, \u0308\u0305\u0303\u0306\u0302\u0305\u0302\u0307\u0304\u0301\u0304\u0301\u0307\u0301\u0305 body)
		{
		}

		// Token: 0x060128A5 RID: 75941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A5")]
		[Address(RVA = "0x171D350", Offset = "0x171C750", VA = "0x18171D350")]
		public static void Request_ArmorHit_ClientSide(ulong player, ushort shotID, byte armorID)
		{
		}

		// Token: 0x060128A6 RID: 75942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A6")]
		[Address(RVA = "0x171C140", Offset = "0x171B540", VA = "0x18171C140")]
		public static void Received_ArmorHitRequest_ServerSide(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender, ushort shotID, ulong target, byte armorID)
		{
		}

		// Token: 0x060128A7 RID: 75943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A7")]
		[Address(RVA = "0x171D590", Offset = "0x171C990", VA = "0x18171D590")]
		public static void Request_ProjectileExlosion_ClientSide(ushort projectileID, \u0301\u0301\u0304\u0302\u0306\u0308\u0303\u0307\u0305\u0308\u0305\u0303\u0308\u0301\u0303.\u0301\u0305\u0305\u0305\u0306\u0301\u0307\u0308\u0304\u0306\u0308\u0304\u0302\u0305\u0304 args, Vector3 worldPosition, Vector3 worldNormal, bool isRelative, Vector3 relativePosition, Vector3 relativeNormal)
		{
		}

		// Token: 0x060128A8 RID: 75944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A8")]
		[Address(RVA = "0x171CC80", Offset = "0x171C080", VA = "0x18171CC80")]
		public static void Received_ProjectileExlosion_ServerSide(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 sender, \u0305\u0302\u0304\u0305\u0304\u0301\u0305\u0301\u0303\u0302\u0301\u0307\u0304\u0304\u0301 package, int packageSize)
		{
		}

		// Token: 0x060128A9 RID: 75945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128A9")]
		[Address(RVA = "0x171DA30", Offset = "0x171CE30", VA = "0x18171DA30")]
		public static void SendDamage_ServerSide(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 responsible, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 target, float damage, ushort toolID, \u0308\u0305\u0303\u0306\u0302\u0305\u0302\u0307\u0304\u0301\u0304\u0301\u0307\u0301\u0305 body, bool totalKill = false)
		{
		}

		// Token: 0x060128AA RID: 75946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128AA")]
		[Address(RVA = "0x171D9C0", Offset = "0x171CDC0", VA = "0x18171D9C0")]
		public static void SendArmorDurability_ServerSide(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 responsible, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 target, ushort toolID, byte armorID, float newDurability)
		{
		}

		// Token: 0x060128AB RID: 75947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128AB")]
		[Address(RVA = "0x171BD10", Offset = "0x171B110", VA = "0x18171BD10")]
		public static void OnAPlayerKilledAnotherPlayer(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 killer, ushort toolID, float distance, \u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client, PlayerNetwork.\u0301\u0304\u0301\u0303\u0302\u0308\u0303\u0301\u0307\u0308\u0307\u0306\u0302\u0306\u0306 reason, bool isFullDead)
		{
		}

		// Token: 0x060128AC RID: 75948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60128AC")]
		[Address(RVA = "0x171BC50", Offset = "0x171B050", VA = "0x18171BC50")]
		public static void OnAPlayerGivenUp(\u0305\u0307\u0306\u0308\u0304\u0305\u0304\u0301\u0301\u0307\u0306\u0307\u0301\u0302\u0304 client)
		{
		}
	}
}
