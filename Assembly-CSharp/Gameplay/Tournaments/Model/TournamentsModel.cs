using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Tournaments;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Tournaments;
using UI.Tabs;
using Utils;

namespace Gameplay.Tournaments.Model
{
	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	public class TournamentsModel : AbstractModel
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000524")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x6E06", Offset = "0x6E06", VA = "0x6E06")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x6E07", Offset = "0x6E07", VA = "0x6E07")]
		public TournamentsModel(UserData user)
		{
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000525")]
		public TournamentHistory History
		{
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x6E08", Offset = "0x6E08", VA = "0x6E08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C8A")]
			[Address(RVA = "0x6E09", Offset = "0x6E09", VA = "0x6E09")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00005F88 File Offset: 0x00004188
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000526")]
		public uint HistoryTournamentTypeId
		{
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x6E0A", Offset = "0x6E0A", VA = "0x6E0A")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x6E0B", Offset = "0x6E0B", VA = "0x6E0B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00005FA0 File Offset: 0x000041A0
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000527")]
		public bool UIBlocked
		{
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x6E0C", Offset = "0x6E0C", VA = "0x6E0C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x6E0D", Offset = "0x6E0D", VA = "0x6E0D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00005FB8 File Offset: 0x000041B8
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000528")]
		public uint CurrentTournamentType
		{
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x6E0E", Offset = "0x6E0E", VA = "0x6E0E")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C90")]
			[Address(RVA = "0x6E0F", Offset = "0x6E0F", VA = "0x6E0F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000529")]
		public TournamentData CurrentTournament
		{
			[Token(Token = "0x6001C91")]
			[Address(RVA = "0x6E10", Offset = "0x6E10", VA = "0x6E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00005FD0 File Offset: 0x000041D0
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052A")]
		public float PrizeCoef
		{
			[Token(Token = "0x6001C92")]
			[Address(RVA = "0x6E11", Offset = "0x6E11", VA = "0x6E11")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x6E12", Offset = "0x6E12", VA = "0x6E12")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00005FE8 File Offset: 0x000041E8
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052B")]
		public UserTNMStatus PlayerStatus
		{
			[Token(Token = "0x6001C94")]
			[Address(RVA = "0x6E13", Offset = "0x6E13", VA = "0x6E13")]
			[CompilerGenerated]
			get
			{
				return UserTNMStatus.Nobody;
			}
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x6E14", Offset = "0x6E14", VA = "0x6E14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052C")]
		public BackTime NextStateBacktime
		{
			[Token(Token = "0x6001C96")]
			[Address(RVA = "0x6E15", Offset = "0x6E15", VA = "0x6E15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C97")]
			[Address(RVA = "0x6E16", Offset = "0x6E16", VA = "0x6E16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x6E17", Offset = "0x6E17", VA = "0x6E17")]
		public void SetStateInfo(ProtoStateChangedEvt evt)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x6E18", Offset = "0x6E18", VA = "0x6E18")]
		public void PopulateTournaments(ProtoGetTournamentListAns msg, TournamentInfo activeTournament)
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x6E19", Offset = "0x6E19", VA = "0x6E19")]
		public void PopulateHistory(TournamentHistory history, uint tournamentTypeId)
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x6E1A", Offset = "0x6E1A", VA = "0x6E1A")]
		public string GetPlayerStatusLocalization(uint tournamentTypeId, ResourceSet minBet)
		{
			return null;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x6E1B", Offset = "0x6E1B", VA = "0x6E1B")]
		public string GetCurrentRoundLocalization(uint currentRound)
		{
			return null;
		}

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		private const string LOCALIZATION_GLADIATORS_TOURNAMENT = "TOURNAMENTS/GLADIATORS_TOURNAMENT";

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		private const string LOCALIATION_NOBODY = "TOURNAMENTS/NOBODY";

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		private const string LOCALIATION_GLADIATOR = "TOURNAMENTS/GLADIATOR";

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		private const string LOCALIATION_VIEWER = "TOURNAMENTS/VIEWER";

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		private const string LOCALIZATION_TOURNAMENT_ROUND = "TOURNAMENTS/TOURNAMENT_ROUND";

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		private const string LOCALIZATION_TOURNAMENTS_FINAL = "TOURNAMENTS/FINAL";

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		private const string LOCALIZATION_TOURNAMENTS_SEMIFINAL = "TOURNAMENTS/SEMIFINAL";

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<uint, TournamentData> TournamentsByTypeId;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x10")]
		private DictManager _dictManager;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x30")]
		public TabBarItemData[] TabBarData;
	}
}
