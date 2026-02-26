using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Billing
{
	// Token: 0x02001090 RID: 4240
	[Token(Token = "0x2001090")]
	public class HvExpectedGetPaymentDataErrors : ExpectedGetPaymentDataErrors
	{
		// Token: 0x060062B3 RID: 25267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B3")]
		[Address(RVA = "0xAED8", Offset = "0xAED8", VA = "0xAED8", Slot = "5")]
		protected override void LogUnhandledError(ExpectedGetPaymentDataErrors.ExpectedGetPaymentDataErrorsArgs args)
		{
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B4")]
		[Address(RVA = "0xAED9", Offset = "0xAED9", VA = "0xAED9")]
		public HvExpectedGetPaymentDataErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Billing_HvExpectedGetPaymentDataErrors___ctor
		               (int param1,undefined1 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  int *piVar4;
		  undefined4 local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a6073a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Errors_Expected_Auth_ExpectedLoginErrors_HandleTestModeWindowOnClose__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_LoginCmd_Types_Result_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28601);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2788);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7675);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15005);
		    DAT_ram_00a6073a = '\x01';
		  }
		  *param2 = 0;
		  if (param1 == 0) goto code_r0x81cd829a;
		  if (param1 != 2) {
		    if (param1 == 3) {
		      if (DAT_ram_00a6073c == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Application_Update_AppUpdateRequired_TypeInfo);
		        DAT_ram_00a6073c = '\x01';
		      }
		      piVar4 = (int *)unnamed_function_1417(Core_Application_Update_AppUpdateRequired_TypeInfo);
		      (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf8) * 4))
		                (piVar4,*(undefined4 *)(*piVar4 + 0xfc));
		      goto code_r0x81cd829a;
		    }
		    if (param1 != 4) {
		      if (param1 == 5) {
		        iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		        UI_Windows_Alert__Show(iVar1,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = func_ii_7508(StringLiteral_15005,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar1 + 0x18) = uVar2;
		        uVar2 = func_ii_7508(StringLiteral_15004,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		        uVar2 = UI_Windows_UnityInstantiator___ctor(iVar1,0);
		        uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		        UnityEngine_Events_UnityEvent__AddListener
		                  (uVar3,0,
		                   Method_Core_Errors_Expected_Auth_ExpectedLoginErrors_HandleTestModeWindowOnClose__
		                   ,0);
		        UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar2,uVar3,0);
		      }
		      else if (param1 == 6) {
		        local_c = 6;
		        uVar2 = func_ii_1081(Protocol_Auth2_LoginCmd_Types_Result_TypeInfo,&local_c);
		        uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                          (StringLiteral_28601,StringLiteral_7675,uVar2,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7830(uVar2,0);
		      }
		      else if (param1 == 7) {
		        Core_Errors_Expected_Auth_ExpectedLoginErrors__HandleRequiredUpdate(7);
		      }
		      else {
		        *param2 = 1;
		      }
		      goto code_r0x81cd829a;
		    }
		  }
		  iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(iVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_2788,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  local_8 = 0xffffffff;
		  local_c = Protocol_Auth2_LoginCmd_Types_Result_TypeInfo;
		  local_4 = param1;
		  param3_00 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar3,StringLiteral_22980,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar3,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                    );
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar2,0,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  *(undefined4 *)(iVar1 + 0x24) = uVar2;
		  UI_Windows_UnityInstantiator___ctor(iVar1,0);
		code_r0x81cd829a:
		  return (uint)(param1 != 0);
		}
		*/

		}
	}
}
