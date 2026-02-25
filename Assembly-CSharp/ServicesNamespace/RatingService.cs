using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Rating;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public class RatingService : AbstractService
	{
		// Token: 0x14000092 RID: 146
		// (add) Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000092")]
		public event Action<ProtoTotalRatingChangedEvt> TotalRatingChangedEvent
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x5A04", Offset = "0x5A04", VA = "0x5A04")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x5A05", Offset = "0x5A05", VA = "0x5A05")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000093")]
		public event Action<ProtoGreatRatingTopChangedEvt> GreatRatingTopChangedEvent
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x5A06", Offset = "0x5A06", VA = "0x5A06")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x5A07", Offset = "0x5A07", VA = "0x5A07")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000094")]
		public event Action<ProtoGreatRatingSetChangedEvt> GreatRatingSetChangedEvent
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x5A08", Offset = "0x5A08", VA = "0x5A08")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x5A09", Offset = "0x5A09", VA = "0x5A09")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000095")]
		public event Action<ProtoCompetitionRatingChangedEvt> CompetitionRatingChangedEvent
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x5A0A", Offset = "0x5A0A", VA = "0x5A0A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x5A0B", Offset = "0x5A0B", VA = "0x5A0B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x170000A9")]
		public override short ServiceId
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x5A0C", Offset = "0x5A0C", VA = "0x5A0C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x5A0D", Offset = "0x5A0D", VA = "0x5A0D", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x5A0E", Offset = "0x5A0E", VA = "0x5A0E")]
		public OpToken<IMessage, object> RequestUsersRating(uint ratingType, RatingPeriods periods)
		{
			return null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x5A0F", Offset = "0x5A0F", VA = "0x5A0F")]
		public OpToken<IMessage, object> RequestCultRating(uint ratingType, RatingPeriods periods)
		{
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x5A10", Offset = "0x5A10", VA = "0x5A10")]
		public OpToken<IMessage, object> RequestClansRating(uint ratingType, RatingPeriods periods)
		{
			return null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x5A11", Offset = "0x5A11", VA = "0x5A11")]
		public OpToken<IMessage, object> GetUserTdRating(RatingPeriods periods)
		{
			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x5A12", Offset = "0x5A12", VA = "0x5A12")]
		public OpToken<IMessage, object> GetAllUsersTdRating(RatingPeriods periods)
		{
			return null;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5A13", Offset = "0x5A13", VA = "0x5A13")]
		public OpToken<IMessage, object> GetUserPortalRating()
		{
			return null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x5A14", Offset = "0x5A14", VA = "0x5A14")]
		public OpToken<IMessage, object> GetAllUsersPortalRating()
		{
			return null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000612")]
		private OpToken<IMessage, object> GetRating<TAns>(RatingCommands command, uint ratingType, RatingPeriods periods) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5A15", Offset = "0x5A15", VA = "0x5A15")]
		public OpToken<IMessage, object> GetGreatTop()
		{
			return null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5A16", Offset = "0x5A16", VA = "0x5A16")]
		public OpToken<IMessage, object> SetGreatSetId(uint greatSetId)
		{
			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x5A17", Offset = "0x5A17", VA = "0x5A17")]
		public OpToken<IMessage, object> VoteGreatRating(ulong userId)
		{
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x5A18", Offset = "0x5A18", VA = "0x5A18")]
		public OpToken<IMessage, object> ExitGreatRating()
		{
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x5A19", Offset = "0x5A19", VA = "0x5A19")]
		public OpToken<IMessage, object> VoteRTRating(ulong userId, bool isLike)
		{
			return null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x5A1A", Offset = "0x5A1A", VA = "0x5A1A")]
		public OpToken<IMessage, object> GetVoteRTRating(RatingPeriods period, bool ownerOnly)
		{
			return null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5A1B", Offset = "0x5A1B", VA = "0x5A1B")]
		public OpToken<IMessage, object> GetCompetitionRatingCounter()
		{
			return null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x5A1C", Offset = "0x5A1C", VA = "0x5A1C")]
		public OpToken<IMessage, object> GetCompetitionRating()
		{
			return null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x5A1D", Offset = "0x5A1D", VA = "0x5A1D")]
		public RatingService()
		{
		}
	}
}
