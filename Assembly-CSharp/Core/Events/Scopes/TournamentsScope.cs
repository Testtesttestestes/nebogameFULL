using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Events.Scopes
{
	// Token: 0x02001031 RID: 4145
	[Token(Token = "0x2001031")]
	public class TournamentsScope : AbstractEventBusScope
	{
		// Token: 0x060061D3 RID: 25043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061D3")]
		[Address(RVA = "0xADFE", Offset = "0xADFE", VA = "0xADFE", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061D4")]
		[Address(RVA = "0xADFF", Offset = "0xADFF", VA = "0xADFF")]
		public TournamentsScope()
		{
		}

		// Token: 0x040034A4 RID: 13476
		[Token(Token = "0x40034A4")]
		[FieldOffset(Offset = "0x8")]
		public Action<TournamentsScope.AddBetEventArgs> AddBetEvent;

		// Token: 0x040034A5 RID: 13477
		[Token(Token = "0x40034A5")]
		[FieldOffset(Offset = "0xC")]
		public Action<TournamentsScope.FinalCombatCompleteEventArgs> FinalCombatCompleteEvent;

		// Token: 0x040034A6 RID: 13478
		[Token(Token = "0x40034A6")]
		[FieldOffset(Offset = "0x10")]
		public Action<BaseEventBusEventArgs> LeaveTournamentEvent;

		// Token: 0x02001032 RID: 4146
		[Token(Token = "0x2001032")]
		public class AddBetEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001394 RID: 5012
			// (get) Token: 0x060061D5 RID: 25045 RVA: 0x00012228 File Offset: 0x00010428
			[Token(Token = "0x17001394")]
			public uint TournamentType
			{
				[Token(Token = "0x60061D5")]
				[Address(RVA = "0xAE00", Offset = "0xAE00", VA = "0xAE00")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17001395 RID: 5013
			// (get) Token: 0x060061D6 RID: 25046 RVA: 0x00012240 File Offset: 0x00010440
			[Token(Token = "0x17001395")]
			public uint TournamentId
			{
				[Token(Token = "0x60061D6")]
				[Address(RVA = "0xAE01", Offset = "0xAE01", VA = "0xAE01")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17001396 RID: 5014
			// (get) Token: 0x060061D7 RID: 25047 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001396")]
			public ResourceSet Bet
			{
				[Token(Token = "0x60061D7")]
				[Address(RVA = "0xAE02", Offset = "0xAE02", VA = "0xAE02")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060061D8 RID: 25048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061D8")]
			[Address(RVA = "0xAE03", Offset = "0xAE03", VA = "0xAE03")]
			public AddBetEventArgs(App app, IGame game, uint tournamentType, uint tournamentId, ResourceSet bet)
			{
			}
		}

		// Token: 0x02001033 RID: 4147
		[Token(Token = "0x2001033")]
		public class FinalCombatCompleteEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001397 RID: 5015
			// (get) Token: 0x060061D9 RID: 25049 RVA: 0x00012258 File Offset: 0x00010458
			[Token(Token = "0x17001397")]
			public uint TournamentType
			{
				[Token(Token = "0x60061D9")]
				[Address(RVA = "0xAE04", Offset = "0xAE04", VA = "0xAE04")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17001398 RID: 5016
			// (get) Token: 0x060061DA RID: 25050 RVA: 0x00012270 File Offset: 0x00010470
			[Token(Token = "0x17001398")]
			public ulong WinnerId
			{
				[Token(Token = "0x60061DA")]
				[Address(RVA = "0xAE05", Offset = "0xAE05", VA = "0xAE05")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17001399 RID: 5017
			// (get) Token: 0x060061DB RID: 25051 RVA: 0x00012288 File Offset: 0x00010488
			[Token(Token = "0x17001399")]
			public ulong LooserId
			{
				[Token(Token = "0x60061DB")]
				[Address(RVA = "0xAE06", Offset = "0xAE06", VA = "0xAE06")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x060061DC RID: 25052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061DC")]
			[Address(RVA = "0xAE07", Offset = "0xAE07", VA = "0xAE07")]
			public FinalCombatCompleteEventArgs(App app, IGame game, uint tournamentType, ulong winnerId, ulong looserId)
			{
			}
		}
	}
}
