using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200137A RID: 4986
	[Token(Token = "0x200137A")]
	[AddComponentMenu("I2/Localization/Localize Dropdown")]
	public class LocalizeDropdown : MonoBehaviour
	{
		// Token: 0x06007684 RID: 30340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007684")]
		[Address(RVA = "0xBFFB", Offset = "0xBFFB", VA = "0xBFFB")]
		public void Start()
		{
		/* --- GHIDRA: Start ---
		void I2_Loc_LocalizeDropdown__Start(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a604db == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeDropdown_OnLocalize__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		    DAT_ram_00a604db = '\x01';
		  }
		  param1_00 = unnamed_function_1417(I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		  iVar2 = Method_I2_Loc_LocalizeDropdown_OnLocalize__;
		  uVar3 = *(undefined4 *)(Method_I2_Loc_LocalizeDropdown_OnLocalize__ + 4);
		  *(int *)(param1_00 + 0x14) = Method_I2_Loc_LocalizeDropdown_OnLocalize__;
		  *(undefined4 *)(param1_00 + 8) = uVar3;
		  *(int *)(param1_00 + 0x10) = param1;
		  cVar1 = *(char *)(iVar2 + 0x2e);
		  *(int *)(param1_00 + 0x20) = param1_00;
		  iVar2 = func_ii_4538(iVar2);
		  if (iVar2 == 0) {
		    if (param1 == 0) {
		      uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                        (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(undefined4 *)(param1_00 + 0xc) = *(undefined4 *)(param1_00 + 8);
		    *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1_00 + 0x10);
		  }
		  else if (cVar1 == '\0') {
		    *(char **)(param1_00 + 0xc) = s___Scripting__UnityEngine__Contex_ram_0000360b + 3;
		  }
		  else {
		    *(undefined4 *)(param1_00 + 0xc) = *(undefined4 *)(param1_00 + 8);
		    *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1_00 + 0x10);
		  }
		  *(char **)(param1_00 + 0x1c) = s___Scripting__UnityEngine__Contex_ram_0000360b + 4;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__add_OnLocalizeEvent(param1_00,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007685")]
		[Address(RVA = "0xBFFC", Offset = "0xBFFC", VA = "0xBFFC")]
		public void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void I2_Loc_LocalizeDropdown__OnDestroy(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a604dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Count__);
		    DAT_ram_00a604dc = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x10) + 0xc) == 0) {
		    I2_Loc_LocalizeDropdown__OnLocalize(param1,param1);
		  }
		  I2_Loc_LocalizeDropdown__OnEnable(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007686")]
		[Address(RVA = "0xBFFD", Offset = "0xBFFD", VA = "0xBFFD")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void I2_Loc_LocalizeDropdown__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a604dd == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a604dd = '\x01';
		  }
		  iVar1 = UnityEngine_Awaitable___c____cctor_b__76_1(param1,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = func_ii_3812(uVar2,0,0);
		    if (iVar1 == 0) {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		      iVar1 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar2,0);
		      if (iVar1 != 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        if (DAT_ram_00a604e6 == '\0') {
		          Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		          DAT_ram_00a604e6 = '\x01';
		        }
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        I2_Loc_LocalizeDropdown___ctor(param1);
		        iVar1 = func_ii_4769(**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),0);
		        if (iVar1 == 0) {
		          I2_Loc_LocalizeDropdown__FillValues(param1,param1);
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007687 RID: 30343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007687")]
		[Address(RVA = "0xBFFE", Offset = "0xBFFE", VA = "0xBFFE")]
		public void OnLocalize()
		{
		/* --- GHIDRA: OnLocalize ---
		void I2_Loc_LocalizeDropdown__OnLocalize(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  uint uVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a604de == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Dropdown___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Dropdown_OptionData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Dropdown_OptionData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Dropdown_OptionData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Dropdown_OptionData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a604de = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Dropdown___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar1,0,0);
		  if ((iVar2 != 0) && (iVar2 = I2_Loc_LanguageSourceData__Import_CSV(0), iVar2 != 0)) {
		    I2_Loc_LocalizeDropdown__UpdateLocalizationTMPro(param1,uVar1);
		    return;
		  }
		  uVar1 = I2_Loc_LocalizationManager__TryGetTranslation(uVar1,0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,uVar1,
		             Method_System_Collections_Generic_List_Dropdown_OptionData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_Dropdown_OptionData__MoveNext__
		                        );
		      iVar4 = DAT_ram_009d3e38;
		      iVar2 = Method_System_Collections_Generic_List_string__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81c9d601;
		      }
		      iVar4 = local_18;
		      if (iVar3 == 0) goto code_r0x81c9d64a;
		      uVar1 = *(undefined4 *)(local_8._4_4_ + 8);
		      iVar4 = *(int *)(param1 + 0x10);
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar4 + 0xc);
		      if (*(uint *)(*(int *)(iVar4 + 8) + 0xc) <= uVar6) break;
		      *(uint *)(iVar4 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(iVar4 + 8) + uVar6 * 4 + 0x10) = uVar1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,uVar1,
		               *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c9d601:
		  iVar2 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x81c9d64a:
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 9,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007688")]
		[Address(RVA = "0xBFFF", Offset = "0xBFFF", VA = "0xBFFF")]
		private void FillValues()
		{
		/* --- GHIDRA: FillValues ---
		void I2_Loc_LocalizeDropdown__FillValues(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  undefined1 auStack_30 [8];
		  int local_28;
		  undefined1 *puStack_24;
		  undefined8 local_20;
		  undefined1 local_18 [8];
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a604df == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Dropdown___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Dropdown_OptionData__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Dropdown_OptionData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_Dropdown_OptionData_TypeInfo);
		    DAT_ram_00a604df = '\x01';
		  }
		  param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Dropdown___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(param1_00,0,0);
		  if (iVar2 != 0) {
		    I2_Loc_LocalizeDropdown__UpdateLocalization(param1,auStack_30);
		    return;
		  }
		  iVar2 = I2_Loc_LocalizationManager__TryGetTranslation(param1_00,0);
		  iVar5 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar5) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar5,0);
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_28,*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_List_string__GetEnumerator__);
		  local_10 = local_20;
		  local_28 = 0;
		  puStack_24 = local_18;
		code_r0x81c9ceb6:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_18,
		                       Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c9d15f;
		    }
		    if (iVar5 == 0) {
		      iVar5 = 5;
		      iVar2 = local_28;
		      goto code_r0x81c9d1ac;
		    }
		    uVar3 = local_10._4_4_;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_LocalizationManager_TypeInfo);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81c9d15f;
		      }
		    }
		    if (DAT_ram_00a60519 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&I2_Loc_LocalizationManager_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a60519 = '\x01';
		        goto code_r0x81c9cf7c;
		      }
		code_r0x81c9d139:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c9d15f;
		    }
		code_r0x81c9cf7c:
		    local_4 = 0;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_LocalizationManager_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81c9d139;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiiiiiiiiii
		              (s___Scripting__UnityEngine__Contex_ram_0000360b + 5,uVar3,&local_4,1,0,1,0,0,0,1,
		               auStack_30);
		    uVar3 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81c9d139;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = I2_Loc_LocalizationManager__TryGetTranslation(param1_00,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c9d15f;
		    }
		    DAT_ram_009d3e38 = 0;
		    param1_01 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           UnityEngine_UI_Dropdown_OptionData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81c9d14d;
		    DAT_ram_009d3e38 = 0;
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_01,uVar3,0);
		    iVar2 = Method_System_Collections_Generic_List_Dropdown_OptionData__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81c9d14d;
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar5 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		      *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = param1_01;
		      goto code_r0x81c9ceb6;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,param1_01,
		               *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81c9d14d:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c9d15f:
		      iVar2 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar5) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        iVar5 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x81c9d1ac:
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar5 != 0) {
		            if (iVar5 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 != 5) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		          UnityEngine_UI_Dropdown__OnDisable(param1_00,0);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 8,&local_28);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06007689 RID: 30345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007689")]
		[Address(RVA = "0xC000", Offset = "0xC000", VA = "0xC000")]
		public void UpdateLocalization()
		{
		/* --- GHIDRA: UpdateLocalization ---
		void I2_Loc_LocalizeDropdown__UpdateLocalization(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  undefined1 auStack_30 [8];
		  int local_28;
		  undefined1 *puStack_24;
		  undefined8 local_20;
		  undefined1 local_18 [8];
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a604e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TMP_Dropdown___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_Dropdown_OptionData_TypeInfo);
		    DAT_ram_00a604e0 = '\x01';
		  }
		  param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TMP_Dropdown___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(param1_00,0,0);
		  if (iVar2 != 0) {
		    return;
		  }
		  iVar2 = func_ii_13845(param1_00,0);
		  iVar5 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar5) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar5,0);
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_28,*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_List_string__GetEnumerator__);
		  local_10 = local_20;
		  local_28 = 0;
		  puStack_24 = local_18;
		code_r0x81c9da8a:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_18,
		                       Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c9dd34;
		    }
		    if (iVar5 == 0) {
		      iVar5 = 5;
		      iVar2 = local_28;
		      goto code_r0x81c9dd81;
		    }
		    uVar3 = local_10._4_4_;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_LocalizationManager_TypeInfo);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81c9dd34;
		      }
		    }
		    if (DAT_ram_00a60519 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&I2_Loc_LocalizationManager_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a60519 = '\x01';
		        goto code_r0x81c9db50;
		      }
		code_r0x81c9dd0e:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c9dd34;
		    }
		code_r0x81c9db50:
		    local_4 = 0;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_LocalizationManager_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81c9dd0e;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiiiiiiiiii
		              (s___Scripting__UnityEngine__Contex_ram_0000360b + 5,uVar3,&local_4,1,0,1,0,0,0,1,
		               auStack_30);
		    uVar3 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81c9dd0e;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = func_ii_13845(param1_00,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c9dd34;
		    }
		    DAT_ram_009d3e38 = 0;
		    param1_01 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           TMPro_TMP_Dropdown_OptionData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81c9dd22;
		    DAT_ram_009d3e38 = 0;
		    System_UInt32__ToString(param1_01,uVar3,0);
		    iVar2 = Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81c9dd22;
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar5 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		      *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = param1_01;
		      goto code_r0x81c9da8a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,param1_01,
		               *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81c9dd22:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c9dd34:
		      iVar2 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar5) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        iVar5 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x81c9dd81:
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar5 != 0) {
		            if (iVar5 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar5 != 5) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		          TMPro_TMP_Dropdown__OnDisable(param1_00,0);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0xc,&local_28);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x0600768A RID: 30346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768A")]
		[Address(RVA = "0xC001", Offset = "0xC001", VA = "0xC001")]
		public void UpdateLocalizationTMPro()
		{
		/* --- GHIDRA: UpdateLocalizationTMPro ---
		void I2_Loc_LocalizeDropdown__UpdateLocalizationTMPro(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  uint uVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a604e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TMP_Dropdown___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TMP_Dropdown_OptionData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TMP_Dropdown_OptionData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TMP_Dropdown_OptionData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a604e1 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TMP_Dropdown___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar1,0,0);
		  if (iVar2 != 0) {
		    return;
		  }
		  uVar1 = func_ii_13845(uVar1,0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,uVar1,
		             Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_TMP_Dropdown_OptionData__MoveNext__
		                        );
		      iVar4 = DAT_ram_009d3e38;
		      iVar2 = Method_System_Collections_Generic_List_string__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81c9d87a;
		      }
		      iVar4 = local_18;
		      if (iVar3 == 0) goto code_r0x81c9d8c3;
		      uVar1 = *(undefined4 *)(local_8._4_4_ + 8);
		      iVar4 = *(int *)(param1 + 0x10);
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar4 + 0xc);
		      if (*(uint *)(*(int *)(iVar4 + 8) + 0xc) <= uVar6) break;
		      *(uint *)(iVar4 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(iVar4 + 8) + uVar6 * 4 + 0x10) = uVar1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,uVar1,
		               *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c9d87a:
		  iVar2 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x81c9d8c3:
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 10,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768B")]
		[Address(RVA = "0xC002", Offset = "0xC002", VA = "0xC002")]
		private void FillValuesTMPro()
		{
		/* --- GHIDRA: FillValuesTMPro ---
		void I2_Loc_LocalizeDropdown__FillValuesTMPro(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a604e2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600768C RID: 30348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768C")]
		[Address(RVA = "0xC003", Offset = "0xC003", VA = "0xC003")]
		public LocalizeDropdown()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeDropdown___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a604e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e3 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = func_ii_4769(**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),0);
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) != 0)
		    {
		      return;
		    }
		  }
		  iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__PreviewLanguage(iVar1);
		  if (DAT_ram_00a60508 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60508 = '\x01';
		  }
		  iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__UpdateSources(iVar1);
		  I2_Loc_LocalizationManager__RegisterSceneSources(iVar1);
		  I2_Loc_LocalizationManager__UnregisterDeletededSources(iVar1);
		  I2_Loc_LocalizationManager__SetCurrentCultureInfo(iVar1);
		  return;
		}
		*/

		}

		// Token: 0x04003E24 RID: 15908
		[Token(Token = "0x4003E24")]
		[FieldOffset(Offset = "0x10")]
		public List<string> _Terms;
	}
}
