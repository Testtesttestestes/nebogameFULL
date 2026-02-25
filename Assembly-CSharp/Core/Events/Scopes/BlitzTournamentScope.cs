using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data.Tournaments;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FDC RID: 4060
	[Token(Token = "0x2000FDC")]
	public class BlitzTournamentScope : AbstractEventBusScope
	{
		// Token: 0x060060CE RID: 24782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0xACFA", Offset = "0xACFA", VA = "0xACFA", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CF")]
		[Address(RVA = "0xACFB", Offset = "0xACFB", VA = "0xACFB")]
		public BlitzTournamentScope()
		{
		}

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0x8")]
		public Action<BlitzTournamentScope.JoinedQueueEventArgs> JoinedQueueEvent;

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[FieldOffset(Offset = "0xC")]
		public Action<BaseEventBusEventArgs> LeftQueueEvent;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[FieldOffset(Offset = "0x10")]
		public Action<BlitzTournamentScope.FinalCombatCompleteEventArgs> FinalCombatCompleteEvent;

		// Token: 0x02000FDD RID: 4061
		[Token(Token = "0x2000FDD")]
		public class JoinedQueueEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001312 RID: 4882
			// (get) Token: 0x060060D0 RID: 24784 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001312")]
			public BlitzTournamentData BlitzTournamentData
			{
				[Token(Token = "0x60060D0")]
				[Address(RVA = "0xACFC", Offset = "0xACFC", VA = "0xACFC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060060D1 RID: 24785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060D1")]
			[Address(RVA = "0xACFD", Offset = "0xACFD", VA = "0xACFD")]
			public JoinedQueueEventArgs(App app, IGame game, BlitzTournamentData tournamentData)
			{
			}
		}

		// Token: 0x02000FDE RID: 4062
		[Token(Token = "0x2000FDE")]
		public class FinalCombatCompleteEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001313 RID: 4883
			// (get) Token: 0x060060D2 RID: 24786 RVA: 0x000119E8 File Offset: 0x0000FBE8
			[Token(Token = "0x17001313")]
			public uint TournamentType
			{
				[Token(Token = "0x60060D2")]
				[Address(RVA = "0xACFE", Offset = "0xACFE", VA = "0xACFE")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17001314 RID: 4884
			// (get) Token: 0x060060D3 RID: 24787 RVA: 0x00011A00 File Offset: 0x0000FC00
			[Token(Token = "0x17001314")]
			public ulong WinnerId
			{
				[Token(Token = "0x60060D3")]
				[Address(RVA = "0xACFF", Offset = "0xACFF", VA = "0xACFF")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17001315 RID: 4885
			// (get) Token: 0x060060D4 RID: 24788 RVA: 0x00011A18 File Offset: 0x0000FC18
			[Token(Token = "0x17001315")]
			public ulong LooserId
			{
				[Token(Token = "0x60060D4")]
				[Address(RVA = "0xAD00", Offset = "0xAD00", VA = "0xAD00")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x060060D5 RID: 24789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060D5")]
			[Address(RVA = "0xAD01", Offset = "0xAD01", VA = "0xAD01")]
			public FinalCombatCompleteEventArgs(App app, IGame game, uint tournamentType, ulong winnerId, ulong looserId)
			{
			}
		}
	}
}
