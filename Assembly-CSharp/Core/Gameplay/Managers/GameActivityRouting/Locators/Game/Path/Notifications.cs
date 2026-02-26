using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E2 RID: 4578
	[Token(Token = "0x20011E2")]
	public class Notifications : AbstractPathNode
	{
		// Token: 0x06006CD7 RID: 27863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD7")]
		[Address(RVA = "0xB7C3", Offset = "0xB7C3", VA = "0xB7C3", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD8")]
		[Address(RVA = "0xB7C4", Offset = "0xB7C4", VA = "0xB7C4", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD9")]
		[Address(RVA = "0xB7C5", Offset = "0xB7C5", VA = "0xB7C5")]
		public Notifications()
		{
		/* --- GHIDRA: .ctor ---
		void OKG_Heavens_External_Notifications___ctor(undefined4 *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a647b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__11107CA6504348480AE12FFBC466C72F955F80A486EAB15920F75E7E13A6EA6F
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__6607F51C6FE009ACDB4F6B006AD01A3C4BF48002ADA8B5999FAE48A95E5747EA
		              );
		    DAT_ram_00a647b3 = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid(byte___TypeInfo,0x247);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_00,
		             Field__PrivateImplementationDetails__11107CA6504348480AE12FFBC466C72F955F80A486EAB15920F75E7E13A6EA6F
		             ,0);
		  param1_01 = Mono_Security_ASN1Convert__ToOid(byte___TypeInfo,0x1c8);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_01,
		             Field__PrivateImplementationDetails__6607F51C6FE009ACDB4F6B006AD01A3C4BF48002ADA8B5999FAE48A95E5747EA
		             ,0);
		  param1[4] = 0;
		  *(undefined8 *)(param1 + 2) = 0xb0000000d;
		  param1[1] = param1_01;
		  *param1 = param1_00;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Notifications___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a729 == '\0') {
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
		    DAT_ram_00a5a729 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  uVar2 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar2,Method_UI_Windows_PopupController_GetWindows_MenuWindow___);
		  uVar2 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar2,Method_System_Linq_Enumerable_FirstOrDefault_MenuWindow___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar3 == 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    piVar6 = *(int **)(param1 + 0x10);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		          goto code_r0x81262d65;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81262d65:
		    uVar1 = 0;
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    uVar5 = func_ii_7112(uVar5,0);
		    piVar6 = *(int **)(param1 + 0x10);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x81262df0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81262df0:
		    piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    uVar1 = 0;
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x128);
		          goto code_r0x81262e72;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0xd);
		code_r0x81262e72:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    param3_00 = *(undefined4 *)(iVar3 + 0xc);
		    param1_00 = unnamed_function_1417
		                          (Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs__get_Payload
		              (param1_00,uVar5,param3_00,1,0,0);
		    UI_Windows_PopupController__set_TopWindow(uVar2,StringLiteral_12653,param1_00,0,0);
		  }
		  else {
		    Gameplay_UserInterface_View_Menu_MenuWindow__OnClose(uVar2,1,param4,0);
		  }
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
