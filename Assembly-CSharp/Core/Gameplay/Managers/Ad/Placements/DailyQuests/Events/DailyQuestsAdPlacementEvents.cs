using System;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.DailyQuests.Events
{
	// Token: 0x02001211 RID: 4625
	[Token(Token = "0x2001211")]
	public class DailyQuestsAdPlacementEvents : AdPlacementEvents
	{
		// Token: 0x06006DAF RID: 28079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DAF")]
		[Address(RVA = "0xB86F", Offset = "0xB86F", VA = "0xB86F")]
		public DailyQuestsAdPlacementEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_DailyQuests_Events_DailyQuestsAdPlacementEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a792 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a792 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
