using System;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104E RID: 4174
	[Token(Token = "0x200104E")]
	public class ExpectedCombatErrors : ExpectedDefaultError
	{
		// Token: 0x0600621D RID: 25117 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x600621D")]
		[Address(RVA = "0xAE48", Offset = "0xAE48", VA = "0xAE48", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		undefined4
		Core_Errors_Expected_ExpectedCombatErrors__Handle
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a36a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6908);
		    DAT_ram_00a5a36a = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_6908,1,0,1,0,0,0,0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600621E")]
		[Address(RVA = "0xAE49", Offset = "0xAE49", VA = "0xAE49", Slot = "5")]
		public virtual string GetInsufficientConditionsText(ICombat combat)
		{
			return null;
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600621F")]
		[Address(RVA = "0xAE4A", Offset = "0xAE4A", VA = "0xAE4A")]
		public ExpectedCombatErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedCombatErrors___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a36b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoDismantleArtifactAns_Types_Errors_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Errors_Expected_ExpectedCraftErrors__Handle_b__1_0__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6166);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13899);
		    Mono_Security_ASN1__get_Item(&StringLiteral_255);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6165);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6164);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7857);
		    DAT_ram_00a5a36b = '\x01';
		  }
		  if (param2 < -0xc9) {
		    if (param2 == -400) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = func_ii_7508(StringLiteral_13899,1,0,1,0,0,0,0);
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      Core_Application_App__get_ToastController(uVar2,2,uVar4,0);
		      return 1;
		    }
		    if (param2 == -0xca) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = func_ii_7508(StringLiteral_6166,1,0,1,0,0,0,0);
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      Core_Application_App__get_ToastController(uVar2,2,uVar4,0);
		      return 1;
		    }
		    if (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x179 <
		        s_struct_Uniforms___color__array<v_ram_00000aff + param2 + 0xb8) {
		      return 0;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		          goto code_r0x8120cf1d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8120cf1d:
		    iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		    uVar4 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),-1000 - param2,3,
		                       Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                      );
		    uVar2 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Core_Errors_Expected_ExpectedCraftErrors__Handle_b__1_0__,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar4,uVar2,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  }
		  else {
		    if (param2 == -3) {
		      iVar3 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		      UI_Windows_Alert__Show(iVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = func_ii_7508(StringLiteral_6165,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar3 + 0x1c) = uVar4;
		      UI_Windows_UnityInstantiator___ctor(iVar3,0);
		      return 1;
		    }
		    if (param2 == -2) {
		      iVar3 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		      UI_Windows_Alert__Show(iVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = func_ii_7508(StringLiteral_6164,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar3 + 0x1c) = uVar4;
		      UI_Windows_UnityInstantiator___ctor(iVar3,0);
		      return 1;
		    }
		    if (param2 != -1) {
		      if (param2 != -0x68) {
		        return 0;
		      }
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = func_ii_7508(StringLiteral_7857,1,0,1,0,0,0,0);
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      Core_Application_App__get_ToastController(uVar2,2,uVar4,0);
		      return 1;
		    }
		    local_8 = 0xffffffffffffffff;
		    local_c = Protocol_Craft_ProtoDismantleArtifactAns_Types_Errors_TypeInfo;
		    uVar4 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar4,StringLiteral_255,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  }
		  return 1;
		}
		*/

		}
	}
}
