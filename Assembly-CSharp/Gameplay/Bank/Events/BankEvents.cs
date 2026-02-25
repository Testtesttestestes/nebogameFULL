using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Events
{
	// Token: 0x02000C5E RID: 3166
	[Token(Token = "0x2000C5E")]
	public class BankEvents : AbstractMVCEvents
	{
		// Token: 0x06004D53 RID: 19795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D53")]
		[Address(RVA = "0x9B8C", Offset = "0x9B8C", VA = "0x9B8C")]
		public BankEvents()
		{
		}

		// Token: 0x04002A32 RID: 10802
		[Token(Token = "0x4002A32")]
		[FieldOffset(Offset = "0x14")]
		public Action OptionsRewardsChangedEvent;

		// Token: 0x04002A33 RID: 10803
		[Token(Token = "0x4002A33")]
		[FieldOffset(Offset = "0x18")]
		public Action<BankOptionData> SingleTimeSellOptionPurchaseStatusChangedEvent;

		// Token: 0x04002A34 RID: 10804
		[Token(Token = "0x4002A34")]
		[FieldOffset(Offset = "0x1C")]
		public Action ActivePromotionsReceivedEvent;

		// Token: 0x04002A35 RID: 10805
		[Token(Token = "0x4002A35")]
		[FieldOffset(Offset = "0x20")]
		public Action<uint> OptionArtikulsReceivedEvent;

		// Token: 0x04002A36 RID: 10806
		[Token(Token = "0x4002A36")]
		[FieldOffset(Offset = "0x24")]
		public Action AvailOptionsChangedEvent;

		// Token: 0x04002A37 RID: 10807
		[Token(Token = "0x4002A37")]
		[FieldOffset(Offset = "0x28")]
		public Action<BankOptionData> DoExchangeSuccessEvent;

		// Token: 0x04002A38 RID: 10808
		[Token(Token = "0x4002A38")]
		[FieldOffset(Offset = "0x2C")]
		public Action<int> EpNotificationsCountChangedEvent;
	}
}
