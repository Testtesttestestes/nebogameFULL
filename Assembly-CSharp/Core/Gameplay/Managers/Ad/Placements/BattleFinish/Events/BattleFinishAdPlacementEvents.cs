using System;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events
{
	// Token: 0x02001215 RID: 4629
	[Token(Token = "0x2001215")]
	public class BattleFinishAdPlacementEvents : AdPlacementEvents
	{
		// Token: 0x06006DB8 RID: 28088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB8")]
		[Address(RVA = "0xB878", Offset = "0xB878", VA = "0xB878")]
		public BattleFinishAdPlacementEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_BattleFinish_Events_BattleFinishAdPlacementEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a799 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a799 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400396D RID: 14701
		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x1C")]
		public Action DropRemovedEvent;
	}
}
