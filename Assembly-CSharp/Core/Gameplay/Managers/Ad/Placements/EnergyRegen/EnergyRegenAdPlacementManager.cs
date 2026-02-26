using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Controller;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.EnergyRegen
{
	// Token: 0x0200120B RID: 4619
	[Token(Token = "0x200120B")]
	public class EnergyRegenAdPlacementManager : AbstractAdPlacementManager<EnergyRegenAdPlacementModel, EnergyRegenAdPlacementController, EnergyRegenAdPlacementEvents>
	{
		// Token: 0x06006D9F RID: 28063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D9F")]
		[Address(RVA = "0xB85F", Offset = "0xB85F", VA = "0xB85F")]
		private EnergyRegenAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager___ctor
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a786 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Controller_EnergyRegenAdPlacementController_TypeInfo
		              );
		    DAT_ram_00a5a786 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Controller_EnergyRegenAdPlacementController_TypeInfo
		                        );
		  if (DAT_ram_00a5a78b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a78b = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1_00,param3,param2,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents___ctor__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA0")]
		[Address(RVA = "0xB860", Offset = "0xB860", VA = "0xB860", Slot = "7")]
		protected override EnergyRegenAdPlacementController CreateController(EnergyRegenAdPlacementEvents events, EnergyRegenAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: CreateController ---
		int Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager__CreateController
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a787 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Model_EnergyRegenAdPlacementModel_TypeInfo
		              );
		    DAT_ram_00a5a787 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Model_EnergyRegenAdPlacementModel_TypeInfo
		                        );
		  *(undefined4 *)(param1_00 + 0x10) = 3;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2,0);
		  *(undefined4 *)(param1_00 + 0xc) = param3;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA1")]
		[Address(RVA = "0xB861", Offset = "0xB861", VA = "0xB861", Slot = "8")]
		protected override EnergyRegenAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
		/* --- GHIDRA: CreateModel ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager__CreateModel
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a788 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Events_EnergyRegenAdPlacementEvents_TypeInfo
		              );
		    DAT_ram_00a5a788 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Events_EnergyRegenAdPlacementEvents_TypeInfo
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA2")]
		[Address(RVA = "0xB862", Offset = "0xB862", VA = "0xB862", Slot = "9")]
		protected override EnergyRegenAdPlacementEvents CreateEvents()
		{
		/* --- GHIDRA: CreateEvents ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager__CreateEvents
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a789 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents__Initialize__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		              );
		    DAT_ram_00a5a789 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		                        );
		  if (DAT_ram_00a5a785 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a785 = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1_00,param1,param2,param3,param4,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents___ctor__
		            );
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___Dispose
		            (param1_00,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents__Initialize__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA3")]
		[Address(RVA = "0xB863", Offset = "0xB863", VA = "0xB863")]
		public static EnergyRegenAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		/* --- GHIDRA: Create ---
		void Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager__Create
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x10) = 3;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/

			return null;
		}
	}
}
