using System;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BankOptions.Events
{
	// Token: 0x02001220 RID: 4640
	[Token(Token = "0x2001220")]
	public class BankOptionsAdPlacementEvents : AdPlacementEvents
	{
		// Token: 0x06006DDF RID: 28127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DDF")]
		[Address(RVA = "0xB898", Offset = "0xB898", VA = "0xB898")]
		public BankOptionsAdPlacementEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_BankOptions_Events_BankOptionsAdPlacementEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a7b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a7b2 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
