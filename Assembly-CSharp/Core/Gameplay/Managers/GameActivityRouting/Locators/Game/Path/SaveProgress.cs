using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E3 RID: 4579
	[Token(Token = "0x20011E3")]
	public class SaveProgress : AbstractPathNode
	{
		// Token: 0x06006CDA RID: 27866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDA")]
		[Address(RVA = "0xB7C6", Offset = "0xB7C6", VA = "0xB7C6", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDB")]
		[Address(RVA = "0xB7C7", Offset = "0xB7C7", VA = "0xB7C7", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDC")]
		[Address(RVA = "0xB7C8", Offset = "0xB7C8", VA = "0xB7C8")]
		public SaveProgress()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_SaveProgress___ctor
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
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
		  if (DAT_ram_00a5a72a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_MenuWindow___);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_GetWindows_AccountLinkerWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_GetWindows_MenuWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12653);
		    DAT_ram_00a5a72a = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x81262f98;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81262f98:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x81263018;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81263018:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar6 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar4,Method_UI_Windows_PopupController_GetWindows_AccountLinkerWindow___);
		  if (*(int *)(iVar6 + 0xc) == 0) {
		    uVar1 = 0;
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x812631cd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812631cd:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    uVar1 = 0;
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		          goto code_r0x8126324b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x8126324b:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar4 = UI_Windows_PopupController__GetLastWindow_object_
		                      (uVar4,Method_UI_Windows_PopupController_GetWindows_MenuWindow___);
		    uVar4 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                      (uVar4,Method_System_Linq_Enumerable_FirstOrDefault_MenuWindow___);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar8 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		    if (iVar8 == 0) {
		      uVar1 = 0;
		      iVar8 = *param2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		            goto code_r0x81263311;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81263311:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      uVar1 = 0;
		      iVar8 = *piVar3;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		            goto code_r0x8126338d;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x8126338d:
		      uVar1 = 0;
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      piVar3 = *(int **)(param1 + 0x10);
		      iVar8 = *piVar3;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		            goto code_r0x81263412;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81263412:
		      uVar1 = 0;
		      uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      uVar5 = func_ii_7112(uVar5,0);
		      piVar3 = *(int **)(param1 + 0x10);
		      iVar8 = *piVar3;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		            goto code_r0x8126349d;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8126349d:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      uVar1 = 0;
		      iVar8 = *piVar3;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x128);
		            goto code_r0x8126351f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xd);
		code_r0x8126351f:
		      iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      param3_00 = *(undefined4 *)(iVar8 + 0xc);
		      param1_00 = unnamed_function_1417
		                            (Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		      Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs__get_Payload
		                (param1_00,uVar5,param3_00,1,0,0);
		      UI_Windows_PopupController__set_TopWindow(uVar4,StringLiteral_12653,param1_00,0,0);
		    }
		    else {
		      Gameplay_UserInterface_View_Menu_MenuWindow__OnClose(uVar4,1,param4,0);
		    }
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
		            goto code_r0x812630bb;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812630bb:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar7 = *piVar3;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Application_IApp_TypeInfo == *piVar9) {
		            puVar2 = (uint *)(piVar9[1] * 8 + iVar7 + 0xe8);
		            goto code_r0x81263135;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81263135:
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
