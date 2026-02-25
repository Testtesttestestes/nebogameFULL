using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Tournaments;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;
using UI.Tabs;
using Utils;

namespace Gameplay.BlitzTournament.Model
{
	// Token: 0x02000BD2 RID: 3026
	[Token(Token = "0x2000BD2")]
	public class BlitzTournamentModel : AbstractModel
	{
		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A26 RID: 18982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F01")]
		public ProtoGetTournamentInfoAns.Types.TournamentInfo TournamentInfo
		{
			[Token(Token = "0x6004A25")]
			[Address(RVA = "0x9887", Offset = "0x9887", VA = "0x9887")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A26")]
			[Address(RVA = "0x9888", Offset = "0x9888", VA = "0x9888")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		// (set) Token: 0x06004A28 RID: 18984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F02")]
		public bool InQueue
		{
			[Token(Token = "0x6004A27")]
			[Address(RVA = "0x9889", Offset = "0x9889", VA = "0x9889")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A28")]
			[Address(RVA = "0x988A", Offset = "0x988A", VA = "0x988A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F03")]
		public BackTime NextStateBackTime
		{
			[Token(Token = "0x6004A29")]
			[Address(RVA = "0x988B", Offset = "0x988B", VA = "0x988B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A2A")]
			[Address(RVA = "0x988C", Offset = "0x988C", VA = "0x988C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F04")]
		public BlitzTournamentData CurrentTournament
		{
			[Token(Token = "0x6004A2B")]
			[Address(RVA = "0x988D", Offset = "0x988D", VA = "0x988D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A2C")]
			[Address(RVA = "0x988E", Offset = "0x988E", VA = "0x988E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F05")]
		public bool UIBlocked
		{
			[Token(Token = "0x6004A2D")]
			[Address(RVA = "0x988F", Offset = "0x988F", VA = "0x988F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A2E")]
			[Address(RVA = "0x9890", Offset = "0x9890", VA = "0x9890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		// (set) Token: 0x06004A30 RID: 18992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F06")]
		public TournamentStates TournamentState
		{
			[Token(Token = "0x6004A2F")]
			[Address(RVA = "0x9891", Offset = "0x9891", VA = "0x9891")]
			[CompilerGenerated]
			get
			{
				return TournamentStates.UnknownTournamentState;
			}
			[Token(Token = "0x6004A30")]
			[Address(RVA = "0x9892", Offset = "0x9892", VA = "0x9892")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F07")]
		public int RoundsCount
		{
			[Token(Token = "0x6004A31")]
			[Address(RVA = "0x9893", Offset = "0x9893", VA = "0x9893")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004A32")]
			[Address(RVA = "0x9894", Offset = "0x9894", VA = "0x9894")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x9895", Offset = "0x9895", VA = "0x9895")]
		public BlitzTournamentModel(UserData user)
		{
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x9896", Offset = "0x9896", VA = "0x9896")]
		public void SetTournamentInfo(ProtoGetTournamentInfoAns.Types.TournamentInfo tournamentInfo)
		{
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x9897", Offset = "0x9897", VA = "0x9897")]
		public void PopulateTournaments(ProtoGetTournamentListAns msg)
		{
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x9898", Offset = "0x9898", VA = "0x9898")]
		public void SetBackTime(uint milliseconds)
		{
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x9899", Offset = "0x9899", VA = "0x9899")]
		public string GetCurrentRoundLocalization(uint currentRound)
		{
			return null;
		}

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		private const string LOCALIZATION_BLITZ_TOURNAMENT = "BLITZ/BLITZ_TOURNAMENT";

		// Token: 0x04002864 RID: 10340
		[Token(Token = "0x4002864")]
		private const string LOCALIZATION_TOURNAMENT_ROUND = "BLITZ/TOURNAMENT_ROUND";

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		private const string LOCALIZATION_TOURNAMENTS_FINAL = "TOURNAMENTS/FINAL";

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		private const string LOCALIZATION_TOURNAMENTS_SEMIFINAL = "TOURNAMENTS/SEMIFINAL";

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0xC")]
		public BlitzTournamentData[] BlitzTournaments;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x2C")]
		public TabBarItemData[] TabBarData;
	}
}
