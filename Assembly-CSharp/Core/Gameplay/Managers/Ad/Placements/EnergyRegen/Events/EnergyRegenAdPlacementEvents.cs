using System;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Events
{
	// Token: 0x0200120D RID: 4621
	[Token(Token = "0x200120D")]
	public class EnergyRegenAdPlacementEvents : AdPlacementEvents
	{
		// Token: 0x06006DA6 RID: 28070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA6")]
		[Address(RVA = "0xB866", Offset = "0xB866", VA = "0xB866")]
		public EnergyRegenAdPlacementEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Events_EnergyRegenAdPlacementEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a78b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a78b = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
