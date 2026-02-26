using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TradeAndCraft.Events
{
	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200049D")]
	public class TradeAndCraftEvents : AbstractMVCEvents
	{
		// Token: 0x06001BE8 RID: 7144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE8")]
		[Address(RVA = "0x6D67", Offset = "0x6D67", VA = "0x6D67")]
		public TradeAndCraftEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TradeAndCraft_Events_TradeAndCraftEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a584cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__CraftOptionsWindow___ctor__
		              );
		    DAT_ram_00a584cd = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__CraftOptionsWindow___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
