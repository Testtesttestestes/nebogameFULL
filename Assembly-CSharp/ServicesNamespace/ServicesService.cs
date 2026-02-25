using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Services;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public class ServicesService : AbstractService
	{
		// Token: 0x1400009A RID: 154
		// (add) Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009A")]
		public event Action<ProtoAuchanButtonBacklightEvt> AuchanBacklightChangedEvent
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x5A2E", Offset = "0x5A2E", VA = "0x5A2E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x5A2F", Offset = "0x5A2F", VA = "0x5A2F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009B RID: 155
		// (add) Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009B")]
		public event Action<AccountInfo> AccountChangedEvent
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x5A30", Offset = "0x5A30", VA = "0x5A30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x5A31", Offset = "0x5A31", VA = "0x5A31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009C RID: 156
		// (add) Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009C")]
		public event Action PaymentBonusAchievedEvent
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x5A32", Offset = "0x5A32", VA = "0x5A32")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x5A33", Offset = "0x5A33", VA = "0x5A33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009D RID: 157
		// (add) Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009D")]
		public event Action<RefPayEvt> RefPayEvent
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x5A34", Offset = "0x5A34", VA = "0x5A34")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x5A35", Offset = "0x5A35", VA = "0x5A35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009E RID: 158
		// (add) Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009E")]
		public event Action<AdTransactionClosedEvt> TransactionClosedEvent
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x5A36", Offset = "0x5A36", VA = "0x5A36")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x5A37", Offset = "0x5A37", VA = "0x5A37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009F RID: 159
		// (add) Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009F")]
		public event Action<ProtoPaymentRewardsChangedEvt> PaymentRewardsChangedEvent
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x5A38", Offset = "0x5A38", VA = "0x5A38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x5A39", Offset = "0x5A39", VA = "0x5A39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x170000AB")]
		public override short ServiceId
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x5A3A", Offset = "0x5A3A", VA = "0x5A3A", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x5A3B", Offset = "0x5A3B", VA = "0x5A3B", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x5A3C", Offset = "0x5A3C", VA = "0x5A3C")]
		public OpToken<IMessage, object> BuyUserSlots(uint quantity)
		{
			return null;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x5A3D", Offset = "0x5A3D", VA = "0x5A3D")]
		public OpToken<IMessage, object> BuyNextLevel()
		{
			return null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x5A3E", Offset = "0x5A3E", VA = "0x5A3E")]
		public OpToken<IMessage, object> ChangeNick(string nick, bool checkOnly)
		{
			return null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x5A3F", Offset = "0x5A3F", VA = "0x5A3F")]
		public OpToken<IMessage, object> ChangeApr(uint aprId, bool checkOnly)
		{
			return null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x5A40", Offset = "0x5A40", VA = "0x5A40")]
		public OpToken<IMessage, object> BuyMedal(uint medalId)
		{
			return null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x5A41", Offset = "0x5A41", VA = "0x5A41")]
		public OpToken<IMessage, object> ApplyMedalApr(uint medalId)
		{
			return null;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x5A42", Offset = "0x5A42", VA = "0x5A42")]
		public OpToken<IMessage, object> EvaluatePaymentRewards()
		{
			return null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x5A43", Offset = "0x5A43", VA = "0x5A43")]
		public OpToken<IMessage, object> GetPaymentBonus()
		{
			return null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x5A44", Offset = "0x5A44", VA = "0x5A44")]
		public OpToken<IMessage, object> GetPaymentData(List<OptionEntry> options, ProtoGetPaymentDataCmd.Types.Format format)
		{
			return null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x5A45", Offset = "0x5A45", VA = "0x5A45")]
		public OpToken<IMessage, object> DoExchange(uint optionId)
		{
			return null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x5A46", Offset = "0x5A46", VA = "0x5A46")]
		public OpToken<IMessage, object> GetOptionArtikuls(uint optionId)
		{
			return null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x5A47", Offset = "0x5A47", VA = "0x5A47")]
		public OpToken<IMessage, object> GetActivePromotions()
		{
			return null;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x5A48", Offset = "0x5A48", VA = "0x5A48")]
		public OpToken<IMessage, object> RepairUserItem(params uint[] slotIds)
		{
			return null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x5A49", Offset = "0x5A49", VA = "0x5A49")]
		public OpToken<IMessage, object> RestoreUserItem(uint slotId)
		{
			return null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x5A4A", Offset = "0x5A4A", VA = "0x5A4A")]
		public OpToken<IMessage, object> ReforgeUserItem(uint slotId)
		{
			return null;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x5A4B", Offset = "0x5A4B", VA = "0x5A4B")]
		public OpToken<IMessage, object> GetAccountOptions()
		{
			return null;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x5A4C", Offset = "0x5A4C", VA = "0x5A4C")]
		public OpToken<IMessage, object> BuyAccount(uint optionId)
		{
			return null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x5A4D", Offset = "0x5A4D", VA = "0x5A4D")]
		public OpToken<IMessage, object> GetSpecialOffer()
		{
			return null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x5A4E", Offset = "0x5A4E", VA = "0x5A4E")]
		public OpToken<IMessage, object> CancelSpecialOffer(uint optionId, bool purchased)
		{
			return null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x5A4F", Offset = "0x5A4F", VA = "0x5A4F")]
		public OpToken<IMessage, object> GetDiscounts()
		{
			return null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x5A50", Offset = "0x5A50", VA = "0x5A50")]
		public OpToken<IMessage, object> GetAssistantsStatus()
		{
			return null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x5A51", Offset = "0x5A51", VA = "0x5A51")]
		public OpToken<IMessage, object> BuyGolemSlots(uint quantity)
		{
			return null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x5A52", Offset = "0x5A52", VA = "0x5A52")]
		public OpToken<IMessage, object> RepairGolemItem(params uint[] slotIds)
		{
			return null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x5A53", Offset = "0x5A53", VA = "0x5A53")]
		public OpToken<IMessage, object> ReforgeGolemItem(uint slotId)
		{
			return null;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x5A54", Offset = "0x5A54", VA = "0x5A54")]
		public OpToken<IMessage, object> RestoreGolemItem(uint slotId)
		{
			return null;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x5A55", Offset = "0x5A55", VA = "0x5A55")]
		public OpToken<IMessage, object> PayoffBan()
		{
			return null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x5A56", Offset = "0x5A56", VA = "0x5A56")]
		public OpToken<IMessage, object> GetAdPlacementInfo(IEnumerable<uint> placementIds, uint sourceId)
		{
			return null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x5A57", Offset = "0x5A57", VA = "0x5A57")]
		public OpToken<IMessage, object> CreateAdPlacementTx(AdPlacement placementId, uint sourceId, uint optionId)
		{
			return null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x5A58", Offset = "0x5A58", VA = "0x5A58")]
		public OpToken<IMessage, object> RejectAdPlacement(string transactionId)
		{
			return null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x5A59", Offset = "0x5A59", VA = "0x5A59")]
		public OpToken<IMessage, object> GetEndlessPaymentOptions()
		{
			return null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5A5A", Offset = "0x5A5A", VA = "0x5A5A")]
		public OpToken<IMessage, object> GetNickPrice()
		{
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x5A5B", Offset = "0x5A5B", VA = "0x5A5B")]
		public ServicesService()
		{
		}
	}
}
