using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Controller;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.DailyQuests
{
	// Token: 0x0200120F RID: 4623
	[Token(Token = "0x200120F")]
	public class DailyQuestsAdPlacementManager : AbstractAdPlacementManager<DailyQuestsAdPlacementModel, DailyQuestsAdPlacementController, DailyQuestsAdPlacementEvents>
	{
		// Token: 0x06006DA9 RID: 28073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA9")]
		[Address(RVA = "0xB869", Offset = "0xB869", VA = "0xB869")]
		private DailyQuestsAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a78e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_DailyQuests_Events_DailyQuestsAdPlacementEvents_TypeInfo
		              );
		    DAT_ram_00a5a78e = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Ad_Placements_DailyQuests_Events_DailyQuestsAdPlacementEvents_TypeInfo
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAA")]
		[Address(RVA = "0xB86A", Offset = "0xB86A", VA = "0xB86A", Slot = "9")]
		protected override DailyQuestsAdPlacementEvents CreateEvents()
		{
		/* --- GHIDRA: CreateEvents ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager__CreateEvents
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a78f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_DailyQuests_Controller_DailyQuestsAdPlacementController_TypeInfo
		              );
		    DAT_ram_00a5a78f = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_DailyQuests_Controller_DailyQuestsAdPlacementController_TypeInfo
		                        );
		  if (DAT_ram_00a5a792 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a792 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1_00,param3,param2,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents___ctor__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAB")]
		[Address(RVA = "0xB86B", Offset = "0xB86B", VA = "0xB86B", Slot = "7")]
		protected override DailyQuestsAdPlacementController CreateController(DailyQuestsAdPlacementEvents events, DailyQuestsAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: CreateController ---
		int Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager__CreateController
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a790 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_DailyQuests_Model_DailyQuestsAdPlacementModel_TypeInfo
		              );
		    DAT_ram_00a5a790 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_DailyQuests_Model_DailyQuestsAdPlacementModel_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2,0);
		  *(undefined4 *)(param1_00 + 0xc) = param3;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAC")]
		[Address(RVA = "0xB86C", Offset = "0xB86C", VA = "0xB86C", Slot = "8")]
		protected override DailyQuestsAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
		/* --- GHIDRA: CreateModel ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager__CreateModel
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a791 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents__Initialize__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		              );
		    DAT_ram_00a5a791 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		                        );
		  if (DAT_ram_00a5a78d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a78d = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1_00,param1,param2,param3,param4,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents___ctor__
		            );
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___Dispose
		            (param1_00,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents__Initialize__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAD")]
		[Address(RVA = "0xB86D", Offset = "0xB86D", VA = "0xB86D")]
		public static DailyQuestsAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}
	}
}
