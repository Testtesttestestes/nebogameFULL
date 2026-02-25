using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000C60")]
	public class AdOptionInBankValidatorViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, AdOptionInBankValidatorView>
	{
		// Token: 0x06004D55 RID: 19797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D55")]
		[Address(RVA = "0x9B8E", Offset = "0x9B8E", VA = "0x9B8E")]
		public AdOptionInBankValidatorViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		}

		// Token: 0x17000FAB RID: 4011
		// (set) Token: 0x06004D56 RID: 19798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAB")]
		public override AdOptionInBankValidatorView View
		{
			[Token(Token = "0x6004D56")]
			[Address(RVA = "0x9B8F", Offset = "0x9B8F", VA = "0x9B8F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (set) Token: 0x06004D57 RID: 19799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAC")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D57")]
			[Address(RVA = "0x9B90", Offset = "0x9B90", VA = "0x9B90", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D58")]
		[Address(RVA = "0x9B91", Offset = "0x9B91", VA = "0x9B91")]
		private void ValidateState()
		{
		}
	}
}
