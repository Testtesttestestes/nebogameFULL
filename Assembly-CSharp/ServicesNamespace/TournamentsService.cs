using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Tournaments;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public class TournamentsService : AbstractService
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x170000B2")]
		public override short ServiceId
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x5A9C", Offset = "0x5A9C", VA = "0x5A9C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AC")]
		public event Action<ProtoBetChangedEvt> BetChangedEvent
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x5A9D", Offset = "0x5A9D", VA = "0x5A9D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x5A9E", Offset = "0x5A9E", VA = "0x5A9E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AD")]
		public event Action<ProtoBetChangedOnPlayerEvt> BetChangedOnPlayerEvent
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x5A9F", Offset = "0x5A9F", VA = "0x5A9F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x5AA0", Offset = "0x5AA0", VA = "0x5AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AE")]
		public event Action<ProtoHealtChangedEvt> HealthChangedEvent
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x5AA1", Offset = "0x5AA1", VA = "0x5AA1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x5AA2", Offset = "0x5AA2", VA = "0x5AA2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AF")]
		public event Action<ProtoStateChangedEvt> StateChangedEvent
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x5AA3", Offset = "0x5AA3", VA = "0x5AA3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x5AA4", Offset = "0x5AA4", VA = "0x5AA4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B0")]
		public event Action<ProtoCurrentTnmCombatCompleteEvt> CurrentCombatCompleteEvent
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x5AA5", Offset = "0x5AA5", VA = "0x5AA5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x5AA6", Offset = "0x5AA6", VA = "0x5AA6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B1")]
		public event Action<ProtoFinalTnmCombatCompleteEvt> FinalCombatCompleteEvent
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x5AA7", Offset = "0x5AA7", VA = "0x5AA7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x5AA8", Offset = "0x5AA8", VA = "0x5AA8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x5AA9", Offset = "0x5AA9", VA = "0x5AA9", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x5AAA", Offset = "0x5AAA", VA = "0x5AAA")]
		public OpToken<IMessage, object> GetTournamentsList()
		{
			return null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x5AAB", Offset = "0x5AAB", VA = "0x5AAB")]
		public OpToken<IMessage, object> AddBet(uint tournamentTypeId, ResourceSet betValue)
		{
			return null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x5AAC", Offset = "0x5AAC", VA = "0x5AAC")]
		public OpToken<IMessage, object> SetBet(uint tournamentTypeId, ulong userId)
		{
			return null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x5AAD", Offset = "0x5AAD", VA = "0x5AAD")]
		public OpToken<IMessage, object> BrowseCombat(ulong userId)
		{
			return null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x5AAE", Offset = "0x5AAE", VA = "0x5AAE")]
		public OpToken<IMessage, object> LeaveCombatBrowsing()
		{
			return null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x5AAF", Offset = "0x5AAF", VA = "0x5AAF")]
		public OpToken<IMessage, object> GetTournamentHistory(uint tournamentTypeId)
		{
			return null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x5AB0", Offset = "0x5AB0", VA = "0x5AB0")]
		public OpToken<IMessage, object> Subscribe()
		{
			return null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x5AB1", Offset = "0x5AB1", VA = "0x5AB1")]
		public OpToken<IMessage, object> Unsubscribe()
		{
			return null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x5AB2", Offset = "0x5AB2", VA = "0x5AB2")]
		public OpToken<IMessage, object> LeaveTournament()
		{
			return null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x5AB3", Offset = "0x5AB3", VA = "0x5AB3")]
		public TournamentsService()
		{
		}
	}
}
