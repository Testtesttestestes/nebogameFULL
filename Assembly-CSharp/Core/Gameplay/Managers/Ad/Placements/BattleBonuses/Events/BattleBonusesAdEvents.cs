using System;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events
{
	// Token: 0x02001219 RID: 4633
	[Token(Token = "0x2001219")]
	public class BattleBonusesAdEvents : AdPlacementEvents
	{
		// Token: 0x06006DC8 RID: 28104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC8")]
		[Address(RVA = "0xB887", Offset = "0xB887", VA = "0xB887")]
		public BattleBonusesAdEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Events_BattleBonusesAdEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a7a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents___ctor__
		              );
		    DAT_ram_00a5a7a7 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04003976 RID: 14710
		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0x1C")]
		public Action BonusAchievedChangedEvent;
	}
}
