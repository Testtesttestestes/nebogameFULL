using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Services;

namespace Core.Events.Scopes
{
	// Token: 0x02000FD1 RID: 4049
	[Token(Token = "0x2000FD1")]
	public class BankScope : AbstractEventBusScope
	{
		// Token: 0x060060AD RID: 24749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AD")]
		[Address(RVA = "0xACD9", Offset = "0xACD9", VA = "0xACD9", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AE")]
		[Address(RVA = "0xACDA", Offset = "0xACDA", VA = "0xACDA")]
		public BankScope()
		{
		}

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0x8")]
		public Action<BankScope.ExchangeEventArgs> ExchangeSuccessEvent;

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0xC")]
		public Action<BankScope.PaymentBonusEventArgs> PaymentBonusReceivedEvent;

		// Token: 0x02000FD2 RID: 4050
		[Token(Token = "0x2000FD2")]
		public class ExchangeEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001307 RID: 4871
			// (get) Token: 0x060060AF RID: 24751 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001307")]
			public BankOptionData BankOptionData
			{
				[Token(Token = "0x60060AF")]
				[Address(RVA = "0xACDB", Offset = "0xACDB", VA = "0xACDB")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060060B0 RID: 24752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060B0")]
			[Address(RVA = "0xACDC", Offset = "0xACDC", VA = "0xACDC")]
			public ExchangeEventArgs(App app, IGame game, BankOptionData bankOptionData)
			{
			}
		}

		// Token: 0x02000FD3 RID: 4051
		[Token(Token = "0x2000FD3")]
		public class PaymentBonusEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001308 RID: 4872
			// (get) Token: 0x060060B1 RID: 24753 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001308")]
			public ProtoGetPaymentBonusAns Ans
			{
				[Token(Token = "0x60060B1")]
				[Address(RVA = "0xACDD", Offset = "0xACDD", VA = "0xACDD")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060060B2 RID: 24754 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060B2")]
			[Address(RVA = "0xACDE", Offset = "0xACDE", VA = "0xACDE")]
			public PaymentBonusEventArgs(App app, IGame game, ProtoGetPaymentBonusAns ans)
			{
			}
		}
	}
}
