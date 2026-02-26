using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Controller;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BankOptions
{
	// Token: 0x0200121E RID: 4638
	[Token(Token = "0x200121E")]
	public class BankOptionsAdPlacementManager : AbstractAdPlacementManager<BankOptionsAdPlacementModel, BankOptionsAdPlacementController, BankOptionsAdPlacementEvents>
	{
		// Token: 0x06006DD9 RID: 28121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD9")]
		[Address(RVA = "0xB892", Offset = "0xB892", VA = "0xB892")]
		private BankOptionsAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BankOptions_Events_BankOptionsAdPlacementEvents_TypeInfo
		              );
		    DAT_ram_00a5a7ae = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Ad_Placements_BankOptions_Events_BankOptionsAdPlacementEvents_TypeInfo
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDA")]
		[Address(RVA = "0xB893", Offset = "0xB893", VA = "0xB893", Slot = "9")]
		protected override BankOptionsAdPlacementEvents CreateEvents()
		{
		/* --- GHIDRA: CreateEvents ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager__CreateEvents
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a7af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BankOptions_Controller_BankOptionsAdPlacementController_TypeInfo
		              );
		    DAT_ram_00a5a7af = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BankOptions_Controller_BankOptionsAdPlacementController_TypeInfo
		                        );
		  if (DAT_ram_00a5a7b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a7b2 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1_00,param3,param2,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents___ctor__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDB")]
		[Address(RVA = "0xB894", Offset = "0xB894", VA = "0xB894", Slot = "7")]
		protected override BankOptionsAdPlacementController CreateController(BankOptionsAdPlacementEvents events, BankOptionsAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: CreateController ---
		int Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager__CreateController
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a7b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BankOptions_Model_BankOptionsAdPlacementModel_TypeInfo
		              );
		    DAT_ram_00a5a7b0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BankOptions_Model_BankOptionsAdPlacementModel_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2,0);
		  *(undefined4 *)(param1_00 + 0xc) = param3;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDC")]
		[Address(RVA = "0xB895", Offset = "0xB895", VA = "0xB895", Slot = "8")]
		protected override BankOptionsAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
		/* --- GHIDRA: CreateModel ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager__CreateModel
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a7b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents__Initialize__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		              );
		    DAT_ram_00a5a7b1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		                        );
		  if (DAT_ram_00a5a7ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a7ad = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1_00,param1,param2,param3,param4,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents___ctor__
		            );
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___Dispose
		            (param1_00,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents__Initialize__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDD")]
		[Address(RVA = "0xB896", Offset = "0xB896", VA = "0xB896")]
		public static BankOptionsAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}
	}
}
