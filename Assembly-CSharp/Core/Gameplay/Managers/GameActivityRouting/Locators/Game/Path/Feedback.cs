using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D9 RID: 4569
	[Token(Token = "0x20011D9")]
	public class Feedback : AbstractPathNode
	{
		// Token: 0x06006CB8 RID: 27832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB8")]
		[Address(RVA = "0xB7A4", Offset = "0xB7A4", VA = "0xB7A4", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB9")]
		[Address(RVA = "0xB7A5", Offset = "0xB7A5", VA = "0xB7A5", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBA")]
		[Address(RVA = "0xB7A6", Offset = "0xB7A6", VA = "0xB7A6")]
		public Feedback()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Feedback___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a5a71b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tutorial_Guide_View_Control_GuideControlWindow_GuideControlWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_GetWindows_GuideControlWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GuideControlWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12628);
		    DAT_ram_00a5a71b = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x81261061;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81261061:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x812610df;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x812610df:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar6 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar4,Method_UI_Windows_PopupController_GetWindows_GuideControlWindow___);
		  if (0 < *(int *)(iVar6 + 0xc)) {
		    do {
		      uVar4 = *(undefined4 *)(iVar6 + iVar8 * 4 + 0x10);
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar3 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar3) {
		            puVar2 = (uint *)(piVar3[1] * 8 + iVar7 + 0xe0);
		            goto code_r0x8126117c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8126117c:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar7 = *piVar3;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Application_IApp_TypeInfo == *piVar9) {
		            puVar2 = (uint *)(piVar9[1] * 8 + iVar7 + 0xe8);
		            goto code_r0x812611f6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x812611f6:
		      uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      UI_Windows_PopupController__CloseAll(uVar5,uVar4,0);
		      iVar8 = iVar8 + 1;
		    } while (iVar8 < *(int *)(iVar6 + 0xc));
		  }
		  uVar1 = 0;
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x8126128c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8126128c:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar8 = *piVar3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		        goto code_r0x8126130a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x8126130a:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = unnamed_function_1417
		                    (
		                    Gameplay_Tutorial_Guide_View_Control_GuideControlWindow_GuideControlWindowArgs_TypeInfo
		                    );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(uVar5,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar4,StringLiteral_12628,uVar5,
		             Method_UI_Windows_PopupController_Show_GuideControlWindow___);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
