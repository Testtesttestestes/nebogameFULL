using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.WorldAxis.Office.View.History;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Combat;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	public class HistoryModel : AbstractModel
	{
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027C")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60010E6")]
			[Address(RVA = "0x62E3", Offset = "0x62E3", VA = "0x62E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x000046E0 File Offset: 0x000028E0
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		public uint NextPageNumber
		{
			[Token(Token = "0x60010E7")]
			[Address(RVA = "0x62E4", Offset = "0x62E4", VA = "0x62E4")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x62E5", Offset = "0x62E5", VA = "0x62E5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027E")]
		public BattleHistoryListElement.BattleHistoryListElementArgs[] LastRequestedBattles
		{
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x62E6", Offset = "0x62E6", VA = "0x62E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x62E7", Offset = "0x62E7", VA = "0x62E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027F")]
		public FilterWithIconListElement.FilterWithIconData[] ColossusFilters
		{
			[Token(Token = "0x60010EB")]
			[Address(RVA = "0x62E8", Offset = "0x62E8", VA = "0x62E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000280")]
		public HistoryModel.BattleFullInfo CurrentBattleInfo
		{
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x62E9", Offset = "0x62E9", VA = "0x62E9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010ED")]
			[Address(RVA = "0x62EA", Offset = "0x62EA", VA = "0x62EA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x62EB", Offset = "0x62EB", VA = "0x62EB")]
		public HistoryModel(UserData user)
		{
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x62EC", Offset = "0x62EC", VA = "0x62EC")]
		private FilterWithIconListElement.FilterWithIconData CreateFilterDatas(ColossusDic dic)
		{
			return null;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x62ED", Offset = "0x62ED", VA = "0x62ED")]
		public void CreateBattlesList(ProtoGetColossusBattlesAns msg)
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x62EE", Offset = "0x62EE", VA = "0x62EE")]
		public void AddBattles(ProtoGetColossusBattlesAns msg)
		{
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x62EF", Offset = "0x62EF", VA = "0x62EF")]
		private BattleHistoryListElement.BattleHistoryListElementArgs ConstructArgs(ProtoGetColossusBattlesAns.Types.ColossusBattle battle)
		{
			return null;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x62F0", Offset = "0x62F0", VA = "0x62F0")]
		public void PopulateParticipants(IList<ProtoGetColossusBattleInfoAns.Types.BattleParticipants> participants, BattleHistoryListElement.BattleHistoryListElementArgs battle)
		{
		}

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0xC")]
		private ClansManager _clansManager;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x10")]
		private DictManager _dictManager;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x14")]
		private ColossusRatingDic[] _validRatings;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, ColossusDic> _colossusById;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x28")]
		private readonly int _maxPlayers;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x2C")]
		public readonly List<BattleHistoryListElement.BattleHistoryListElementArgs> Battles;

		// Token: 0x020002CD RID: 717
		[Token(Token = "0x20002CD")]
		public class Participant
		{
			// Token: 0x060010F4 RID: 4340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010F4")]
			[Address(RVA = "0x62F1", Offset = "0x62F1", VA = "0x62F1")]
			public Participant()
			{
			}

			// Token: 0x040008C0 RID: 2240
			[Token(Token = "0x40008C0")]
			[FieldOffset(Offset = "0x8")]
			public ProtoGetColossusBattleInfoAns.Types.BattleParticipants Info;

			// Token: 0x040008C1 RID: 2241
			[Token(Token = "0x40008C1")]
			[FieldOffset(Offset = "0xC")]
			public bool IsDead;

			// Token: 0x040008C2 RID: 2242
			[Token(Token = "0x40008C2")]
			[FieldOffset(Offset = "0x10")]
			public StonesTypes StoneType;

			// Token: 0x040008C3 RID: 2243
			[Token(Token = "0x40008C3")]
			[FieldOffset(Offset = "0x14")]
			public Sprite DollSprite;
		}

		// Token: 0x020002CE RID: 718
		[Token(Token = "0x20002CE")]
		public class BattleFullInfo
		{
			// Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010F5")]
			[Address(RVA = "0x62F2", Offset = "0x62F2", VA = "0x62F2")]
			public BattleFullInfo(IList<ProtoGetColossusBattleInfoAns.Types.BattleParticipants> participants, BattleHistoryListElement.BattleHistoryListElementArgs battle, int maxPlayers, Dictionaries dict)
			{
			}

			// Token: 0x040008C4 RID: 2244
			[Token(Token = "0x40008C4")]
			[FieldOffset(Offset = "0x8")]
			public BattleHistoryListElement.BattleHistoryListElementArgs Battle;

			// Token: 0x040008C5 RID: 2245
			[Token(Token = "0x40008C5")]
			[FieldOffset(Offset = "0xC")]
			public HistoryModel.Participant[] WinSquad;

			// Token: 0x040008C6 RID: 2246
			[Token(Token = "0x40008C6")]
			[FieldOffset(Offset = "0x10")]
			public HistoryModel.Participant[] LoseSquad;

			// Token: 0x040008C7 RID: 2247
			[Token(Token = "0x40008C7")]
			[FieldOffset(Offset = "0x14")]
			public int MaxPlayers;
		}
	}
}
