using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DE RID: 4574
	[Token(Token = "0x20011DE")]
	public class MarketBuilding : AbstractPathNode
	{
		// Token: 0x06006CCA RID: 27850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCA")]
		[Address(RVA = "0xB7B6", Offset = "0xB7B6", VA = "0xB7B6", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		/* --- GHIDRA: ExecuteTransition ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_MarketBuilding__ExecuteTransition
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a724 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a724 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x81261d44;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81261d44:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Gameplay_Isles_Base_Model_BaseIsleModel__GetBuildingLevel
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x20) + 0x10),3,&local_4,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x000140B8 File Offset: 0x000122B8
		[Token(Token = "0x6006CCB")]
		[Address(RVA = "0xB7B7", Offset = "0xB7B7", VA = "0xB7B7", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCC")]
		[Address(RVA = "0xB7B8", Offset = "0xB7B8", VA = "0xB7B8", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCD")]
		[Address(RVA = "0xB7B9", Offset = "0xB7B9", VA = "0xB7B9")]
		public MarketBuilding()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_MarketBuilding___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a5a725 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_GetWindows_MenuWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_MenuWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12653);
		    DAT_ram_00a5a725 = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x81261e39;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81261e39:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x81261eb9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81261eb9:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar6 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar4,Method_UI_Windows_PopupController_GetWindows_MenuWindow___);
		  if (*(int *)(iVar6 + 0xc) == 0) {
		    uVar1 = 0;
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x8126206e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8126206e:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    uVar1 = 0;
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		          goto code_r0x812620ea;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x812620ea:
		    uVar1 = 0;
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		          goto code_r0x8126216a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8126216a:
		    uVar1 = 0;
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    uVar5 = func_ii_7112(uVar5,0);
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x812621f2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812621f2:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    uVar1 = 0;
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x128);
		          goto code_r0x81262270;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xd);
		code_r0x81262270:
		    iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    param3_00 = *(undefined4 *)(iVar8 + 0xc);
		    param1_00 = unnamed_function_1417
		                          (Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs__get_Payload
		              (param1_00,uVar5,param3_00,0,0,0);
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar4,StringLiteral_12653,param1_00,
		               Method_UI_Windows_PopupController_Show_MenuWindow___);
		  }
		  else if (0 < *(int *)(iVar6 + 0xc)) {
		    do {
		      uVar4 = *(undefined4 *)(iVar6 + iVar8 * 4 + 0x10);
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar3 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar3) {
		            puVar2 = (uint *)(piVar3[1] * 8 + iVar7 + 0xe0);
		            goto code_r0x81261f5c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81261f5c:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar7 = *piVar3;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Application_IApp_TypeInfo == *piVar9) {
		            puVar2 = (uint *)(piVar9[1] * 8 + iVar7 + 0xe8);
		            goto code_r0x81261fd6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81261fd6:
		      uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      UI_Windows_PopupController__CloseAll(uVar5,uVar4,0);
		      iVar8 = iVar8 + 1;
		    } while (iVar8 < *(int *)(iVar6 + 0xc));
		  }
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
