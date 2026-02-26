using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D8 RID: 4568
	[Token(Token = "0x20011D8")]
	internal class EndlessOptions : AbstractPathNode
	{
		// Token: 0x06006CB4 RID: 27828 RVA: 0x00014088 File Offset: 0x00012288
		[Token(Token = "0x6006CB4")]
		[Address(RVA = "0xB7A0", Offset = "0xB7A0", VA = "0xB7A0", Slot = "4")]
		public override bool Check()
		{
		/* --- GHIDRA: Check ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_EndlessOptions__Check
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a719 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    DAT_ram_00a5a719 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x298);
		        goto code_r0x81260aff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x81260aff:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (*(int *)(iVar3 + 0x14) != 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__UpdateOptions
		              (*(int *)(iVar3 + 0x14),0);
		  }
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB5")]
		[Address(RVA = "0xB7A1", Offset = "0xB7A1", VA = "0xB7A1", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB6")]
		[Address(RVA = "0xB7A2", Offset = "0xB7A2", VA = "0xB7A2", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB7")]
		[Address(RVA = "0xB7A3", Offset = "0xB7A3", VA = "0xB7A3")]
		public EndlessOptions()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_EndlessOptions___ctor
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
		  
		  if (DAT_ram_00a5a71a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_MenuWindow___);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_GetWindows_MenuWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12653);
		    DAT_ram_00a5a71a = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x81260bf7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81260bf7:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x81260c75;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81260c75:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar4 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar4,Method_UI_Windows_PopupController_GetWindows_MenuWindow___);
		  uVar4 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar4,Method_System_Linq_Enumerable_FirstOrDefault_MenuWindow___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar6 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		  if (iVar6 == 0) {
		    uVar1 = 0;
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		          goto code_r0x81260d3d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81260d3d:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    uVar1 = 0;
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		          goto code_r0x81260db9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81260db9:
		    uVar1 = 0;
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    piVar3 = *(int **)(param1 + 0x10);
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x81260e3e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81260e3e:
		    uVar1 = 0;
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar5 = func_ii_7112(uVar5,0);
		    piVar3 = *(int **)(param1 + 0x10);
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		          goto code_r0x81260ec9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81260ec9:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x128);
		          goto code_r0x81260f4b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xd);
		code_r0x81260f4b:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    param3_00 = *(undefined4 *)(iVar6 + 0xc);
		    param1_00 = unnamed_function_1417
		                          (Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs__get_Payload
		              (param1_00,uVar5,param3_00,4,0,0);
		    UI_Windows_PopupController__set_TopWindow(uVar4,StringLiteral_12653,param1_00,0,0);
		  }
		  else {
		    Gameplay_UserInterface_View_Menu_MenuWindow__OnClose(uVar4,4,param4,0);
		  }
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
