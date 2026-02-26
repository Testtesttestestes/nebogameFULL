using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses
{
	// Token: 0x02001217 RID: 4631
	[Token(Token = "0x2001217")]
	public class BattleBonusesAdPlacementManager : AbstractAdPlacementManager<BattleBonusesAdModel, BattleBonusesAdController, BattleBonusesAdEvents>
	{
		// Token: 0x06006DBE RID: 28094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBE")]
		[Address(RVA = "0xB87E", Offset = "0xB87E", VA = "0xB87E")]
		private BattleBonusesAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user, MedalsManager medalsManager, IDictProvider dictProvider, IRequirementValidator requirementValidator)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager___ctor
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a79e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_TypeInfo
		              );
		    DAT_ram_00a5a79e = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_TypeInfo
		                        );
		  if (DAT_ram_00a5a7a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents___ctor__
		              );
		    DAT_ram_00a5a7a7 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1_00,param3,param2,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents___ctor__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DBF")]
		[Address(RVA = "0xB87F", Offset = "0xB87F", VA = "0xB87F", Slot = "7")]
		protected override BattleBonusesAdController CreateController(BattleBonusesAdEvents events, BattleBonusesAdModel model, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: CreateController ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager__CreateController
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param6;
		  undefined4 param5;
		  undefined4 param4_00;
		  
		  if (DAT_ram_00a5a79f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel_TypeInfo
		              );
		    DAT_ram_00a5a79f = '\x01';
		  }
		  param6 = *(undefined4 *)(param1 + 0x2c);
		  param5 = *(undefined4 *)(param1 + 0x24);
		  param4_00 = *(undefined4 *)(param1 + 0x28);
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel_TypeInfo
		                        );
		  Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager__Create
		            (param1_00,param2,param3,param4_00,param5,param6,param4_00);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DC0 RID: 28096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC0")]
		[Address(RVA = "0xB880", Offset = "0xB880", VA = "0xB880", Slot = "8")]
		protected override BattleBonusesAdModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
		/* --- GHIDRA: CreateModel ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager__CreateModel
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Events_BattleBonusesAdEvents_TypeInfo
		              );
		    DAT_ram_00a5a7a0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Events_BattleBonusesAdEvents_TypeInfo
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC1")]
		[Address(RVA = "0xB881", Offset = "0xB881", VA = "0xB881", Slot = "9")]
		protected override BattleBonusesAdEvents CreateEvents()
		{
		/* --- GHIDRA: CreateEvents ---
		int Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager__CreateEvents
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		              undefined4 param5,undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a7a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents__Initialize__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		              );
		    DAT_ram_00a5a7a1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		                        );
		  if (DAT_ram_00a5a79d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents___ctor__
		              );
		    DAT_ram_00a5a79d = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1_00,param1,param2,param3,param4,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x2c) = param7;
		  *(undefined4 *)(param1_00 + 0x28) = param6;
		  *(undefined4 *)(param1_00 + 0x24) = param5;
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___Dispose
		            (param1_00,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents__Initialize__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC2")]
		[Address(RVA = "0xB882", Offset = "0xB882", VA = "0xB882")]
		public static BattleBonusesAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user, MedalsManager medalsManager, IDictProvider dictProvider, IRequirementValidator requirementValidator)
		{
		/* --- GHIDRA: Create ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager__Create
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalData__TypeInfo);
		    DAT_ram_00a5a7a2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_PropertyPath___get_Count
		            (uVar1,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_MedalData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_MedalData___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x20) = param6;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel___ctor
		            (param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400396E RID: 14702
		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x24")]
		private readonly MedalsManager _medalsManager;

		// Token: 0x0400396F RID: 14703
		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x28")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04003970 RID: 14704
		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x2C")]
		private readonly IRequirementValidator _requirementValidator;
	}
}
