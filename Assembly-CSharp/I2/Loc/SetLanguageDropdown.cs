using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020013B6 RID: 5046
	[Token(Token = "0x20013B6")]
	[AddComponentMenu("I2/Localization/SetLanguage Dropdown")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		// Token: 0x060077F2 RID: 30706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F2")]
		[Address(RVA = "0xC149", Offset = "0xC149", VA = "0xC149")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void I2_Loc_SetLanguageDropdown__OnEnable(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54e2d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Dropdown___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Dropdown_OptionData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e2d = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Dropdown___);
		  if (param2 < 0) {
		    UnityEngine_UI_Dropdown__get_value(uVar1,0,0);
		    param2 = 0;
		  }
		  uVar1 = I2_Loc_LocalizationManager__TryGetTranslation(uVar1,0);
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_List_Dropdown_OptionData__get_Item__);
		  uVar1 = *(undefined4 *)(iVar2 + 8);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__get_CurrentLanguage(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F3")]
		[Address(RVA = "0xC14A", Offset = "0xC14A", VA = "0xC14A")]
		private void OnValueChanged(int index)
		{
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F4")]
		[Address(RVA = "0xC14B", Offset = "0xC14B", VA = "0xC14B")]
		public SetLanguageDropdown()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_SetLanguageDropdown___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_01;
		  
		  if (DAT_ram_00a54e2f == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_StringObfucator_TypeInfo);
		    DAT_ram_00a54e2f = '\x01';
		  }
		  if (*(int *)(I2_Loc_StringObfucator_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               I2_Loc_StringObfucator_TypeInfo);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) goto code_r0x80b24630;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x80b24630:
		    if (DAT_ram_00a54e31 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Convert_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a54e31 = '\x01';
		        goto code_r0x80b24675;
		      }
		    }
		    else {
		code_r0x80b24675:
		      if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Convert_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80b247a5;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 0xba,param1,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = (int *)import::env::invoke_ii
		                                     (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x22c,0);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iiiiii
		                            (*(undefined4 *)(*param2_00 + 0x1f0),param2_00,iVar1,0,
		                             *(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(*param2_00 + 500));
		          iVar1 = DAT_ram_009d3e38;
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x127,uVar2,iVar1);
		            iVar1 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar1 != 1) {
		              DAT_ram_009d3e38 = 0;
		              return uVar2;
		            }
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80b247ad;
		          }
		        }
		      }
		    }
		code_r0x80b247a5:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x80b247ad:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar3 != 0) {
		          import::env::__cxa_end_catch();
		          return 0;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80b248b6;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80b248b6:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
