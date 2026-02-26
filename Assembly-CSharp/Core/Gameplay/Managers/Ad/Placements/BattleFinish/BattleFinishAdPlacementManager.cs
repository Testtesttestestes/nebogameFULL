using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Model;
using Gameplay.ArtifactDrop.Control;
using Il2CppDummyDll;
using UI.Toast;

namespace Core.Gameplay.Managers.Ad.Placements.BattleFinish
{
	// Token: 0x02001213 RID: 4627
	[Token(Token = "0x2001213")]
	public class BattleFinishAdPlacementManager : AbstractAdPlacementManager<BattleFinishAdPlacementModel, BattleFinishAdPlacementController, BattleFinishAdPlacementEvents>
	{
		// Token: 0x06006DB2 RID: 28082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB2")]
		[Address(RVA = "0xB872", Offset = "0xB872", VA = "0xB872")]
		private BattleFinishAdPlacementManager(IAdPlacementData adPlacementData, IArtifactDrop artifactDrop, ToastController toastController, IAdController adController, AdEvents adEvents, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager___ctor
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a795 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController_TypeInfo
		              );
		    DAT_ram_00a5a795 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController_TypeInfo
		                        );
		  if (DAT_ram_00a5a799 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a799 = '\x01';
		  }
		  Gameplay_Accounts_View_Banners_AbstractAccountBannerView_object___set_Data
		            (param1_00,param3,param2,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents___ctor__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0xB873", Offset = "0xB873", VA = "0xB873", Slot = "7")]
		protected override BattleFinishAdPlacementController CreateController(BattleFinishAdPlacementEvents events, BattleFinishAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: CreateController ---
		int Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager__CreateController
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined8 uVar1;
		  
		  if (DAT_ram_00a5a796 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleFinish_Model_BattleFinishAdPlacementModel_TypeInfo
		              );
		    DAT_ram_00a5a796 = '\x01';
		  }
		  uVar1 = *(undefined8 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BattleFinish_Model_BattleFinishAdPlacementModel_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2,0);
		  *(undefined8 *)(param1_00 + 0x10) = uVar1;
		  *(undefined4 *)(param1_00 + 0xc) = param3;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0xB874", Offset = "0xB874", VA = "0xB874", Slot = "8")]
		protected override BattleFinishAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
		/* --- GHIDRA: CreateModel ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager__CreateModel
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a797 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleFinish_Events_BattleFinishAdPlacementEvents_TypeInfo
		              );
		    DAT_ram_00a5a797 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Ad_Placements_BattleFinish_Events_BattleFinishAdPlacementEvents_TypeInfo
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB5")]
		[Address(RVA = "0xB875", Offset = "0xB875", VA = "0xB875", Slot = "9")]
		protected override BattleFinishAdPlacementEvents CreateEvents()
		{
		/* --- GHIDRA: CreateEvents ---
		int Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager__CreateEvents
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		              undefined4 param5,undefined4 param6,undefined4 param7)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a798 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents__Initialize__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager_TypeInfo
		              );
		    DAT_ram_00a5a798 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager_TypeInfo
		                        );
		  if (DAT_ram_00a5a794 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a794 = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1_00,param1,param4,param5,param6,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x28) = param3;
		  *(undefined4 *)(param1_00 + 0x24) = param2;
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___Dispose
		            (param1_00,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents__Initialize__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB6")]
		[Address(RVA = "0xB876", Offset = "0xB876", VA = "0xB876")]
		public static BattleFinishAdPlacementManager Create(IAdPlacementData adPlacementData, IArtifactDrop artifactDrop, ToastController toastController, IAdController adController, AdEvents adEvents, UserData user)
		{
		/* --- GHIDRA: Create ---
		void Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager__Create
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x14) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04003969 RID: 14697
		[Token(Token = "0x4003969")]
		[FieldOffset(Offset = "0x24")]
		private readonly IArtifactDrop _artifactDrop;

		// Token: 0x0400396A RID: 14698
		[Token(Token = "0x400396A")]
		[FieldOffset(Offset = "0x28")]
		private readonly ToastController _toastController;
	}
}
