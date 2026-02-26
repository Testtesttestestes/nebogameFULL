using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020013B5 RID: 5045
	[Token(Token = "0x20013B5")]
	[AddComponentMenu("I2/Localization/SetLanguage Button")]
	public class SetLanguage : MonoBehaviour
	{
		// Token: 0x060077EF RID: 30703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077EF")]
		[Address(RVA = "0xC146", Offset = "0xC146", VA = "0xC146")]
		private void OnClick()
		{
		/* --- GHIDRA: OnClick ---
		void I2_Loc_SetLanguage__OnClick(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e2b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e2b = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = I2_Loc_LocalizationManager__SelectStartupLanguage(uVar2,1,1,1,0);
		  if (iVar1 != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__get_CurrentLanguage(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F0")]
		[Address(RVA = "0xC147", Offset = "0xC147", VA = "0xC147")]
		public void ApplyLanguage()
		{
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F1")]
		[Address(RVA = "0xC148", Offset = "0xC148", VA = "0xC148")]
		public SetLanguage()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_SetLanguage___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a54e2c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Dropdown___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_SetLanguageDropdown_OnValueChanged__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		    DAT_ram_00a54e2c = '\x01';
		  }
		  param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Dropdown___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(param1_00,0,0);
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    uVar2 = I2_Loc_LocalizationManager__GetWebServiceURL(0);
		    if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) == 0)
		    {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      I2_Loc_LocalizationManager__IsRTL(0);
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    uVar3 = I2_Loc_LocalizationManager__GetLanguageFromCode(1,0);
		    UnityEngine_UI_Dropdown__AddOptions(param1_00,0);
		    UnityEngine_UI_Dropdown__AddOptions(param1_00,uVar3,0);
		    uVar2 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (uVar3,uVar2,Method_System_Collections_Generic_List_string__IndexOf__);
		    UnityEngine_UI_Dropdown__get_value(param1_00,uVar2,0);
		    uVar3 = *(undefined4 *)(param1_00 + 0xd0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		    UnityEngine_Events_UnityAction_Color___Invoke
		              (uVar2,param1,Method_I2_Loc_SetLanguageDropdown_OnValueChanged__,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar2,Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		    uVar3 = *(undefined4 *)(param1_00 + 0xd0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		    UnityEngine_Events_UnityAction_Color___Invoke
		              (uVar2,param1,Method_I2_Loc_SetLanguageDropdown_OnValueChanged__,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar2,Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04003EE5 RID: 16101
		[Token(Token = "0x4003EE5")]
		[FieldOffset(Offset = "0x10")]
		public string _Language;
	}
}
