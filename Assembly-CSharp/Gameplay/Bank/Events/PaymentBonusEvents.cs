using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Events
{
	// Token: 0x02000C5F RID: 3167
	[Token(Token = "0x2000C5F")]
	public class PaymentBonusEvents : AbstractMVCEvents
	{
		// Token: 0x06004D54 RID: 19796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D54")]
		[Address(RVA = "0x9B8D", Offset = "0x9B8D", VA = "0x9B8D")]
		public PaymentBonusEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Events_PaymentBonusEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a597d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView___ctor__
		              );
		    DAT_ram_00a597d6 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		[FieldOffset(Offset = "0x14")]
		public Action PaymentBonusChangedEvent;
	}
}
