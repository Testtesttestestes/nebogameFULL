using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001356 RID: 4950
	[Token(Token = "0x2001356")]
	[Serializable]
	public class EventCallback
	{
		// Token: 0x0600758B RID: 30091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600758B")]
		[Address(RVA = "0xBF1B", Offset = "0xBF1B", VA = "0xBF1B")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		/* --- GHIDRA: Execute ---
		uint I2_Loc_EventCallback__Execute(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5972c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5972c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 8);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = func_ii_4769(*(undefined4 *)(param1 + 0xc),0);
		    uVar2 = uVar2 ^ 1;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600758C RID: 30092 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x600758C")]
		[Address(RVA = "0xBF1C", Offset = "0xBF1C", VA = "0xBF1C")]
		public bool HasCallback()
		{
		/* --- GHIDRA: HasCallback ---
		void I2_Loc_EventCallback__HasCallback(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0xc) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600758D")]
		[Address(RVA = "0xBF1D", Offset = "0xBF1D", VA = "0xBF1D")]
		public EventCallback()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_EventCallback___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5972d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_867);
		    Mono_Security_ASN1__get_Item(&StringLiteral_184);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10354);
		    DAT_ram_00a5972d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    uVar2 = System_Globalization_TextInfo__ToTitleCase(param1,0);
		    uVar3 = I2_Loc_StringObfucator__XoREncode(StringLiteral_184,0);
		    uVar2 = Facebook_Unity_FBLocation__FromDictionary(uVar2,uVar3,0);
		    if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_Skin_SkinEntry__int___FindEntry
		              (&local_28,**(undefined4 **)(I2_Loc_GoogleLanguages_TypeInfo + 0x5c),
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		              );
		    local_30 = 0;
		    local_2c = &local_28;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x356,&local_28,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81054371:
		        iVar1 = global_1;
		        iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 == iVar4) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar4 = *piVar5;
		          DAT_ram_009d3e38 = 0;
		          local_30 = iVar4;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		            if (iVar4 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		              do {
		                halt_trap();
		              } while( true );
		            }
		joined_r0x81054364:
		            DAT_ram_009d3e38 = 0;
		            if (param2 != 0) {
		              DAT_ram_009d3e38 = 0;
		              uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                                (StringLiteral_10354,param1,StringLiteral_867,0);
		              if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		                func_ii_306000(OKG_Logs_Debug_TypeInfo);
		              }
		              System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		            }
		            return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x358,&local_30);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar4 == 0) goto joined_r0x81054364;
		      uVar6 = (undefined4)local_18;
		      uVar3 = local_20._4_4_;
		      if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   I2_Loc_GoogleLanguages_TypeInfo);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81054371;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x357,uVar3,uVar2,
		                         &local_30);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81054371;
		      }
		    } while (iVar4 == 0);
		  }
		  else {
		    uVar6 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  return uVar6;
		}
		*/

		}

		// Token: 0x04003D60 RID: 15712
		[Token(Token = "0x4003D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MonoBehaviour Target;

		// Token: 0x04003D61 RID: 15713
		[Token(Token = "0x4003D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string MethodName;
	}
}
