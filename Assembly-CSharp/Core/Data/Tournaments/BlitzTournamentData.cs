using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using Protocol.Dic;

namespace Core.Data.Tournaments
{
	// Token: 0x020010CA RID: 4298
	[Token(Token = "0x20010CA")]
	public class BlitzTournamentData : ITournament
	{
		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064A4 RID: 25764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001457")]
		public BlitzTournamentsDic Dic
		{
			[Token(Token = "0x60064A3")]
			[Address(RVA = "0xB08C", Offset = "0xB08C", VA = "0xB08C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A4")]
			[Address(RVA = "0xB08D", Offset = "0xB08D", VA = "0xB08D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064A6 RID: 25766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001458")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x60064A5")]
			[Address(RVA = "0xB08E", Offset = "0xB08E", VA = "0xB08E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A6")]
			[Address(RVA = "0xB08F", Offset = "0xB08F", VA = "0xB08F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x17001459")]
		public uint TypeId
		{
			[Token(Token = "0x60064A7")]
			[Address(RVA = "0xB090", Offset = "0xB090", VA = "0xB090", Slot = "4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A8")]
		[Address(RVA = "0xB091", Offset = "0xB091", VA = "0xB091")]
		private BlitzTournamentData()
		{
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064A9")]
		[Address(RVA = "0xB092", Offset = "0xB092", VA = "0xB092")]
		public static BlitzTournamentData Create(ProtoGetTournamentListAns.Types.TournamentListItem tournament)
		{
			return null;
		}
	}
}
