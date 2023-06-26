using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Global.Resources
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	[Serializable]
	public class IconsUI
	{
		// Token: 0x06013E23 RID: 81443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013E23")]
		[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
		public IconsUI()
		{
		}

		// Token: 0x04003D6B RID: 15723
		[Token(Token = "0x4003D6B")]
		[FieldOffset(Offset = "0x10")]
		public IconsUI.General GeneralIcons;

		// Token: 0x04003D6C RID: 15724
		[Token(Token = "0x4003D6C")]
		[FieldOffset(Offset = "0x18")]
		public IconsUI.PlayerRanks PlayerRankIcons;

		// Token: 0x04003D6D RID: 15725
		[Token(Token = "0x4003D6D")]
		[FieldOffset(Offset = "0x20")]
		public IconsUI.PlayerPrestige PlayerPrestigeIcons;

		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		[FieldOffset(Offset = "0x28")]
		public IconsUI.PlayerRoles RoleIcons;

		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		[FieldOffset(Offset = "0x30")]
		public IconsUI.Scoreboard ScoreboardIcons;

		// Token: 0x04003D70 RID: 15728
		[Token(Token = "0x4003D70")]
		[FieldOffset(Offset = "0x38")]
		public IconsUI.Overlay OverlayIcons;

		// Token: 0x04003D71 RID: 15729
		[Token(Token = "0x4003D71")]
		[FieldOffset(Offset = "0x40")]
		public IconsUI.Attachments AttachmentIcons;

		// Token: 0x04003D72 RID: 15730
		[Token(Token = "0x4003D72")]
		[FieldOffset(Offset = "0x48")]
		public IconsUI.Input Inputs;

		// Token: 0x04003D73 RID: 15731
		[Token(Token = "0x4003D73")]
		[FieldOffset(Offset = "0x50")]
		public IconsUI.EndOfRound EndOfRoundIcons;

		// Token: 0x04003D74 RID: 15732
		[Token(Token = "0x4003D74")]
		[FieldOffset(Offset = "0x58")]
		public IconsUI.Clan ClanIcons;

		// Token: 0x04003D75 RID: 15733
		[Token(Token = "0x4003D75")]
		[FieldOffset(Offset = "0x60")]
		public IconsUI.Map MapIcons;

		// Token: 0x04003D76 RID: 15734
		[Token(Token = "0x4003D76")]
		[FieldOffset(Offset = "0x68")]
		public IconsUI.Region RegionIcons;

		// Token: 0x020007DD RID: 2013
		[Token(Token = "0x20007DD")]
		[Serializable]
		public class General
		{
			// Token: 0x06013E24 RID: 81444 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E24")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public General()
			{
			}

			// Token: 0x04003D77 RID: 15735
			[Token(Token = "0x4003D77")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17FAF0", Offset = "0x17EEF0")]
			public Sprite FlagAmerican;

			// Token: 0x04003D78 RID: 15736
			[Token(Token = "0x4003D78")]
			[FieldOffset(Offset = "0x18")]
			public Sprite FlagRussain;

			// Token: 0x04003D79 RID: 15737
			[Token(Token = "0x4003D79")]
			[FieldOffset(Offset = "0x20")]
			public Sprite FlagTerrorist;

			// Token: 0x04003D7A RID: 15738
			[Token(Token = "0x4003D7A")]
			[FieldOffset(Offset = "0x28")]
			public Sprite FlagNone;

			// Token: 0x04003D7B RID: 15739
			[Token(Token = "0x4003D7B")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17FBF0", Offset = "0x17EFF0")]
			public Sprite Locked;

			// Token: 0x04003D7C RID: 15740
			[Token(Token = "0x4003D7C")]
			[FieldOffset(Offset = "0x38")]
			public Sprite Unlocked;

			// Token: 0x04003D7D RID: 15741
			[Token(Token = "0x4003D7D")]
			[FieldOffset(Offset = "0x40")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17FC50", Offset = "0x17F050")]
			public Texture2D English;
		}

		// Token: 0x020007DE RID: 2014
		[Token(Token = "0x20007DE")]
		[Serializable]
		public class PlayerRanks
		{
			// Token: 0x06013E25 RID: 81445 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E25")]
			[Address(RVA = "0x1942670", Offset = "0x1941A70", VA = "0x181942670")]
			public Sprite Get(uint rank)
			{
				return null;
			}

			// Token: 0x06013E26 RID: 81446 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E26")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public PlayerRanks()
			{
			}

			// Token: 0x04003D7E RID: 15742
			[Token(Token = "0x4003D7E")]
			[FieldOffset(Offset = "0x10")]
			public Sprite _0;

			// Token: 0x04003D7F RID: 15743
			[Token(Token = "0x4003D7F")]
			[FieldOffset(Offset = "0x18")]
			public Sprite _1;

			// Token: 0x04003D80 RID: 15744
			[Token(Token = "0x4003D80")]
			[FieldOffset(Offset = "0x20")]
			public Sprite _2;

			// Token: 0x04003D81 RID: 15745
			[Token(Token = "0x4003D81")]
			[FieldOffset(Offset = "0x28")]
			public Sprite _3;

			// Token: 0x04003D82 RID: 15746
			[Token(Token = "0x4003D82")]
			[FieldOffset(Offset = "0x30")]
			public Sprite _4;

			// Token: 0x04003D83 RID: 15747
			[Token(Token = "0x4003D83")]
			[FieldOffset(Offset = "0x38")]
			public Sprite _5;

			// Token: 0x04003D84 RID: 15748
			[Token(Token = "0x4003D84")]
			[FieldOffset(Offset = "0x40")]
			public Sprite _6;

			// Token: 0x04003D85 RID: 15749
			[Token(Token = "0x4003D85")]
			[FieldOffset(Offset = "0x48")]
			public Sprite _7;

			// Token: 0x04003D86 RID: 15750
			[Token(Token = "0x4003D86")]
			[FieldOffset(Offset = "0x50")]
			public Sprite _8;

			// Token: 0x04003D87 RID: 15751
			[Token(Token = "0x4003D87")]
			[FieldOffset(Offset = "0x58")]
			public Sprite _9;

			// Token: 0x04003D88 RID: 15752
			[Token(Token = "0x4003D88")]
			[FieldOffset(Offset = "0x60")]
			public Sprite _10;

			// Token: 0x04003D89 RID: 15753
			[Token(Token = "0x4003D89")]
			[FieldOffset(Offset = "0x68")]
			public Sprite _11;

			// Token: 0x04003D8A RID: 15754
			[Token(Token = "0x4003D8A")]
			[FieldOffset(Offset = "0x70")]
			public Sprite _12;

			// Token: 0x04003D8B RID: 15755
			[Token(Token = "0x4003D8B")]
			[FieldOffset(Offset = "0x78")]
			public Sprite _14;

			// Token: 0x04003D8C RID: 15756
			[Token(Token = "0x4003D8C")]
			[FieldOffset(Offset = "0x80")]
			public Sprite _16;

			// Token: 0x04003D8D RID: 15757
			[Token(Token = "0x4003D8D")]
			[FieldOffset(Offset = "0x88")]
			public Sprite _18;

			// Token: 0x04003D8E RID: 15758
			[Token(Token = "0x4003D8E")]
			[FieldOffset(Offset = "0x90")]
			public Sprite _20;

			// Token: 0x04003D8F RID: 15759
			[Token(Token = "0x4003D8F")]
			[FieldOffset(Offset = "0x98")]
			public Sprite _25;

			// Token: 0x04003D90 RID: 15760
			[Token(Token = "0x4003D90")]
			[FieldOffset(Offset = "0xA0")]
			public Sprite _30;

			// Token: 0x04003D91 RID: 15761
			[Token(Token = "0x4003D91")]
			[FieldOffset(Offset = "0xA8")]
			public Sprite _40;

			// Token: 0x04003D92 RID: 15762
			[Token(Token = "0x4003D92")]
			[FieldOffset(Offset = "0xB0")]
			public Sprite _50;

			// Token: 0x04003D93 RID: 15763
			[Token(Token = "0x4003D93")]
			[FieldOffset(Offset = "0xB8")]
			public Sprite _60;

			// Token: 0x04003D94 RID: 15764
			[Token(Token = "0x4003D94")]
			[FieldOffset(Offset = "0xC0")]
			public Sprite _70;

			// Token: 0x04003D95 RID: 15765
			[Token(Token = "0x4003D95")]
			[FieldOffset(Offset = "0xC8")]
			public Sprite _80;

			// Token: 0x04003D96 RID: 15766
			[Token(Token = "0x4003D96")]
			[FieldOffset(Offset = "0xD0")]
			public Sprite _90;

			// Token: 0x04003D97 RID: 15767
			[Token(Token = "0x4003D97")]
			[FieldOffset(Offset = "0xD8")]
			public Sprite _100;

			// Token: 0x04003D98 RID: 15768
			[Token(Token = "0x4003D98")]
			[FieldOffset(Offset = "0xE0")]
			public Sprite _120;

			// Token: 0x04003D99 RID: 15769
			[Token(Token = "0x4003D99")]
			[FieldOffset(Offset = "0xE8")]
			public Sprite _130;

			// Token: 0x04003D9A RID: 15770
			[Token(Token = "0x4003D9A")]
			[FieldOffset(Offset = "0xF0")]
			public Sprite _140;

			// Token: 0x04003D9B RID: 15771
			[Token(Token = "0x4003D9B")]
			[FieldOffset(Offset = "0xF8")]
			public Sprite _150;

			// Token: 0x04003D9C RID: 15772
			[Token(Token = "0x4003D9C")]
			[FieldOffset(Offset = "0x100")]
			public Sprite _160;

			// Token: 0x04003D9D RID: 15773
			[Token(Token = "0x4003D9D")]
			[FieldOffset(Offset = "0x108")]
			public Sprite _170;

			// Token: 0x04003D9E RID: 15774
			[Token(Token = "0x4003D9E")]
			[FieldOffset(Offset = "0x110")]
			public Sprite _180;

			// Token: 0x04003D9F RID: 15775
			[Token(Token = "0x4003D9F")]
			[FieldOffset(Offset = "0x118")]
			public Sprite _200;

			// Token: 0x04003DA0 RID: 15776
			[Token(Token = "0x4003DA0")]
			[FieldOffset(Offset = "0x120")]
			public Sprite _225;

			// Token: 0x04003DA1 RID: 15777
			[Token(Token = "0x4003DA1")]
			[FieldOffset(Offset = "0x128")]
			public Sprite _250;
		}

		// Token: 0x020007DF RID: 2015
		[Token(Token = "0x20007DF")]
		[Serializable]
		public class PlayerPrestige
		{
			// Token: 0x06013E27 RID: 81447 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E27")]
			[Address(RVA = "0x1942620", Offset = "0x1941A20", VA = "0x181942620")]
			public Sprite Get(uint prestige)
			{
				return null;
			}

			// Token: 0x06013E28 RID: 81448 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E28")]
			[Address(RVA = "0x1942580", Offset = "0x1941980", VA = "0x181942580")]
			public Sprite Get2(uint prestige)
			{
				return null;
			}

			// Token: 0x06013E29 RID: 81449 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E29")]
			[Address(RVA = "0x19425D0", Offset = "0x19419D0", VA = "0x1819425D0")]
			public Sprite Get3(uint prestige)
			{
				return null;
			}

			// Token: 0x06013E2A RID: 81450 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E2A")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public PlayerPrestige()
			{
			}

			// Token: 0x04003DA2 RID: 15778
			[Token(Token = "0x4003DA2")]
			[FieldOffset(Offset = "0x10")]
			public Sprite[] Sprites;

			// Token: 0x04003DA3 RID: 15779
			[Token(Token = "0x4003DA3")]
			[FieldOffset(Offset = "0x18")]
			public Sprite[] Sprites2;

			// Token: 0x04003DA4 RID: 15780
			[Token(Token = "0x4003DA4")]
			[FieldOffset(Offset = "0x20")]
			public Sprite[] Sprites3;
		}

		// Token: 0x020007E0 RID: 2016
		[Token(Token = "0x20007E0")]
		[Serializable]
		public class PlayerRoles
		{
			// Token: 0x06013E2B RID: 81451 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E2B")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public PlayerRoles()
			{
			}

			// Token: 0x04003DA5 RID: 15781
			[Token(Token = "0x4003DA5")]
			[FieldOffset(Offset = "0x10")]
			public Sprite[] Roles;

			// Token: 0x04003DA6 RID: 15782
			[Token(Token = "0x4003DA6")]
			[FieldOffset(Offset = "0x18")]
			public Sprite[] RolesInCircle;
		}

		// Token: 0x020007E1 RID: 2017
		[Token(Token = "0x20007E1")]
		[Serializable]
		public class Scoreboard
		{
			// Token: 0x06013E2C RID: 81452 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E2C")]
			[Address(RVA = "0x1944620", Offset = "0x1943A20", VA = "0x181944620")]
			public Texture GetPingTexture(int ping)
			{
				return null;
			}

			// Token: 0x06013E2D RID: 81453 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E2D")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Scoreboard()
			{
			}

			// Token: 0x04003DA7 RID: 15783
			[Token(Token = "0x4003DA7")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x16DF30", Offset = "0x16D330")]
			public Texture2D PointCollapsed;

			// Token: 0x04003DA8 RID: 15784
			[Token(Token = "0x4003DA8")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D PointExpanded;

			// Token: 0x04003DA9 RID: 15785
			[Token(Token = "0x4003DA9")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x169060", Offset = "0x168460")]
			public Texture2D Muted;

			// Token: 0x04003DAA RID: 15786
			[Token(Token = "0x4003DAA")]
			[FieldOffset(Offset = "0x28")]
			public Texture2D Unmuted;

			// Token: 0x04003DAB RID: 15787
			[Token(Token = "0x4003DAB")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17FD50", Offset = "0x17F150")]
			public Texture2D ExpandedLine;

			// Token: 0x04003DAC RID: 15788
			[Token(Token = "0x4003DAC")]
			[FieldOffset(Offset = "0x38")]
			public Texture2D ExpandedLineEnd;

			// Token: 0x04003DAD RID: 15789
			[Token(Token = "0x4003DAD")]
			[FieldOffset(Offset = "0x40")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17FDF0", Offset = "0x17F1F0")]
			public Texture Ping4;

			// Token: 0x04003DAE RID: 15790
			[Token(Token = "0x4003DAE")]
			[FieldOffset(Offset = "0x48")]
			public Texture Ping3;

			// Token: 0x04003DAF RID: 15791
			[Token(Token = "0x4003DAF")]
			[FieldOffset(Offset = "0x50")]
			public Texture Ping2;

			// Token: 0x04003DB0 RID: 15792
			[Token(Token = "0x4003DB0")]
			[FieldOffset(Offset = "0x58")]
			public Texture Ping1;
		}

		// Token: 0x020007E2 RID: 2018
		[Token(Token = "0x20007E2")]
		[Serializable]
		public class Overlay
		{
			// Token: 0x06013E2E RID: 81454 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E2E")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Overlay()
			{
			}

			// Token: 0x04003DB1 RID: 15793
			[Token(Token = "0x4003DB1")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17FEF0", Offset = "0x17F2F0")]
			public Texture2D ConnectedIcon;

			// Token: 0x04003DB2 RID: 15794
			[Token(Token = "0x4003DB2")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D DisconnectedIcon;
		}

		// Token: 0x020007E3 RID: 2019
		[Token(Token = "0x20007E3")]
		[Serializable]
		public class Attachments
		{
			// Token: 0x06013E2F RID: 81455 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E2F")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Attachments()
			{
			}

			// Token: 0x04003DB3 RID: 15795
			[Token(Token = "0x4003DB3")]
			[FieldOffset(Offset = "0x10")]
			public Sprite MagIcon;

			// Token: 0x04003DB4 RID: 15796
			[Token(Token = "0x4003DB4")]
			[FieldOffset(Offset = "0x18")]
			public Sprite BoltActionIcon;
		}

		// Token: 0x020007E4 RID: 2020
		[Token(Token = "0x20007E4")]
		[Serializable]
		public class Input
		{
			// Token: 0x06013E30 RID: 81456 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E30")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Input()
			{
			}

			// Token: 0x04003DB5 RID: 15797
			[Token(Token = "0x4003DB5")]
			[FieldOffset(Offset = "0x10")]
			public Sprite LeftMouseButton;

			// Token: 0x04003DB6 RID: 15798
			[Token(Token = "0x4003DB6")]
			[FieldOffset(Offset = "0x18")]
			public Sprite RightMouseButton;

			// Token: 0x04003DB7 RID: 15799
			[Token(Token = "0x4003DB7")]
			[FieldOffset(Offset = "0x20")]
			public Sprite MiddleMouseButton;

			// Token: 0x04003DB8 RID: 15800
			[Token(Token = "0x4003DB8")]
			[FieldOffset(Offset = "0x28")]
			public Sprite IdleMouseButton;

			// Token: 0x04003DB9 RID: 15801
			[Token(Token = "0x4003DB9")]
			[FieldOffset(Offset = "0x30")]
			public Sprite KeyboardButton;

			// Token: 0x04003DBA RID: 15802
			[Token(Token = "0x4003DBA")]
			[FieldOffset(Offset = "0x38")]
			public Sprite KeyboardButtonBorder;

			// Token: 0x04003DBB RID: 15803
			[Token(Token = "0x4003DBB")]
			[FieldOffset(Offset = "0x40")]
			public Sprite KeyboardButton2;

			// Token: 0x04003DBC RID: 15804
			[Token(Token = "0x4003DBC")]
			[FieldOffset(Offset = "0x48")]
			public Sprite ControllerButton;
		}

		// Token: 0x020007E5 RID: 2021
		[Token(Token = "0x20007E5")]
		[Serializable]
		public class EndOfRound
		{
			// Token: 0x06013E31 RID: 81457 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E31")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public EndOfRound()
			{
			}

			// Token: 0x04003DBD RID: 15805
			[Token(Token = "0x4003DBD")]
			[FieldOffset(Offset = "0x10")]
			public Sprite HeadShot;

			// Token: 0x04003DBE RID: 15806
			[Token(Token = "0x4003DBE")]
			[FieldOffset(Offset = "0x18")]
			public Sprite ObjectivePlay;

			// Token: 0x04003DBF RID: 15807
			[Token(Token = "0x4003DBF")]
			[FieldOffset(Offset = "0x20")]
			public Sprite Heal;
		}

		// Token: 0x020007E6 RID: 2022
		[Token(Token = "0x20007E6")]
		[Serializable]
		public class Clan
		{
			// Token: 0x06013E32 RID: 81458 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E32")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Clan()
			{
			}

			// Token: 0x04003DC0 RID: 15808
			[Token(Token = "0x4003DC0")]
			[FieldOffset(Offset = "0x10")]
			public Sprite Owner;

			// Token: 0x04003DC1 RID: 15809
			[Token(Token = "0x4003DC1")]
			[FieldOffset(Offset = "0x18")]
			public Sprite Officer;

			// Token: 0x04003DC2 RID: 15810
			[Token(Token = "0x4003DC2")]
			[FieldOffset(Offset = "0x20")]
			public Sprite SnOfficer;
		}

		// Token: 0x020007E7 RID: 2023
		[Token(Token = "0x20007E7")]
		[Serializable]
		public class Map
		{
			// Token: 0x06013E33 RID: 81459 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E33")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Map()
			{
			}

			// Token: 0x04003DC3 RID: 15811
			[Token(Token = "0x4003DC3")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17C680", Offset = "0x17BA80")]
			public Texture2D TeamMate;

			// Token: 0x04003DC4 RID: 15812
			[Token(Token = "0x4003DC4")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D SquadMate;

			// Token: 0x04003DC5 RID: 15813
			[Token(Token = "0x4003DC5")]
			[FieldOffset(Offset = "0x20")]
			public Texture2D DownMate;
		}

		// Token: 0x020007E8 RID: 2024
		[Token(Token = "0x20007E8")]
		[Serializable]
		public class Region
		{
			// Token: 0x06013E34 RID: 81460 RVA: 0x0000270E File Offset: 0x0000090E
			[Token(Token = "0x6013E34")]
			[Address(RVA = "0x1942A30", Offset = "0x1941E30", VA = "0x181942A30")]
			public Texture2D Get(\u0306\u0302\u0302\u0302\u0305\u0304\u0307\u0303\u0306\u0307\u0306\u0301\u0303\u0307\u0306 region)
			{
				return null;
			}

			// Token: 0x06013E35 RID: 81461 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6013E35")]
			[Address(RVA = "0x8A9040", Offset = "0x8A8440", VA = "0x1808A9040")]
			public Region()
			{
			}

			// Token: 0x04003DC6 RID: 15814
			[Token(Token = "0x4003DC6")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x180010", Offset = "0x17F410")]
			public Texture2D Developer_Server;

			// Token: 0x04003DC7 RID: 15815
			[Token(Token = "0x4003DC7")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x1800D0", Offset = "0x17F4D0")]
			public Texture2D Europe_Central;

			// Token: 0x04003DC8 RID: 15816
			[Token(Token = "0x4003DC8")]
			[FieldOffset(Offset = "0x20")]
			public Texture2D Europe_North;

			// Token: 0x04003DC9 RID: 15817
			[Token(Token = "0x4003DC9")]
			[FieldOffset(Offset = "0x28")]
			public Texture2D Europe_South;

			// Token: 0x04003DCA RID: 15818
			[Token(Token = "0x4003DCA")]
			[FieldOffset(Offset = "0x30")]
			public Texture2D Europe_West;

			// Token: 0x04003DCB RID: 15819
			[Token(Token = "0x4003DCB")]
			[FieldOffset(Offset = "0x38")]
			public Texture2D Europe_East;

			// Token: 0x04003DCC RID: 15820
			[Token(Token = "0x4003DCC")]
			[FieldOffset(Offset = "0x40")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x17BE80", Offset = "0x17B280")]
			public Texture2D America_Central;

			// Token: 0x04003DCD RID: 15821
			[Token(Token = "0x4003DCD")]
			[FieldOffset(Offset = "0x48")]
			public Texture2D America_North;

			// Token: 0x04003DCE RID: 15822
			[Token(Token = "0x4003DCE")]
			[FieldOffset(Offset = "0x50")]
			public Texture2D America_South;

			// Token: 0x04003DCF RID: 15823
			[Token(Token = "0x4003DCF")]
			[FieldOffset(Offset = "0x58")]
			public Texture2D America_West;

			// Token: 0x04003DD0 RID: 15824
			[Token(Token = "0x4003DD0")]
			[FieldOffset(Offset = "0x60")]
			public Texture2D America_East;

			// Token: 0x04003DD1 RID: 15825
			[Token(Token = "0x4003DD1")]
			[FieldOffset(Offset = "0x68")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x1801E0", Offset = "0x17F5E0")]
			public Texture2D Brazil_Central;

			// Token: 0x04003DD2 RID: 15826
			[Token(Token = "0x4003DD2")]
			[FieldOffset(Offset = "0x70")]
			public Texture2D Brazil_North;

			// Token: 0x04003DD3 RID: 15827
			[Token(Token = "0x4003DD3")]
			[FieldOffset(Offset = "0x78")]
			public Texture2D Brazil_South;

			// Token: 0x04003DD4 RID: 15828
			[Token(Token = "0x4003DD4")]
			[FieldOffset(Offset = "0x80")]
			public Texture2D Brazil_West;

			// Token: 0x04003DD5 RID: 15829
			[Token(Token = "0x4003DD5")]
			[FieldOffset(Offset = "0x88")]
			public Texture2D Brazil_East;

			// Token: 0x04003DD6 RID: 15830
			[Token(Token = "0x4003DD6")]
			[FieldOffset(Offset = "0x90")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x1804F0", Offset = "0x17F8F0")]
			public Texture2D Asia_Central;

			// Token: 0x04003DD7 RID: 15831
			[Token(Token = "0x4003DD7")]
			[FieldOffset(Offset = "0x98")]
			public Texture2D Asia_North;

			// Token: 0x04003DD8 RID: 15832
			[Token(Token = "0x4003DD8")]
			[FieldOffset(Offset = "0xA0")]
			public Texture2D Asia_South;

			// Token: 0x04003DD9 RID: 15833
			[Token(Token = "0x4003DD9")]
			[FieldOffset(Offset = "0xA8")]
			public Texture2D Asia_West;

			// Token: 0x04003DDA RID: 15834
			[Token(Token = "0x4003DDA")]
			[FieldOffset(Offset = "0xB0")]
			public Texture2D Asia_East;

			// Token: 0x04003DDB RID: 15835
			[Token(Token = "0x4003DDB")]
			[FieldOffset(Offset = "0xB8")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x180560", Offset = "0x17F960")]
			public Texture2D Japan_Central;

			// Token: 0x04003DDC RID: 15836
			[Token(Token = "0x4003DDC")]
			[FieldOffset(Offset = "0xC0")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x180590", Offset = "0x17F990")]
			public Texture2D Australia_Central;

			// Token: 0x04003DDD RID: 15837
			[Token(Token = "0x4003DDD")]
			[FieldOffset(Offset = "0xC8")]
			[Attribute(Name = "HeaderAttribute", RVA = "0x180680", Offset = "0x17FA80")]
			public Texture2D Africa_Central;
		}
	}
}
