using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001352 RID: 4946
	[Token(Token = "0x2001352")]
	public abstract class I2BasePersistentStorage
	{
		// Token: 0x06007572 RID: 30066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007572")]
		[Address(RVA = "0xBF03", Offset = "0xBF03", VA = "0xBF03", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		/* --- GHIDRA: SetSetting_String ---
		undefined4
		I2_Loc_I2BasePersistentStorage__SetSetting_String
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  undefined4 *param2_00;
		  int local_4;
		  
		  if (DAT_ram_00a5971f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18903);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18902);
		    DAT_ram_00a5971f = '\x01';
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x350,param2,param3,0);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = func_ii_4769(uVar2,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (iVar4 != 0) {
		        DAT_ram_009d3e38 = 0;
		        return uVar2;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc6,uVar2,
		                         StringLiteral_18902,4,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (iVar4 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return uVar2;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc5,uVar2,
		                           *(undefined4 *)(StringLiteral_18902 + 8),0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81052275:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       System_Globalization_CultureInfo_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81052275;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00000f84 + 0x10e,0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar4 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 4,uVar2,uVar3,0);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              iVar6 = 0;
		              uVar2 = StringLiteral_5;
		              if (iVar4 < 1) {
		                DAT_ram_009d3e38 = 0;
		                return StringLiteral_5;
		              }
		              while( true ) {
		                DAT_ram_009d3e38 = 0;
		                local_4 = iVar6;
		                uVar3 = import::env::invoke_iii
		                                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                                   DAT_ram_00a66954,&local_4);
		                iVar1 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar1 == 1) {
		                  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x810522c3;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar3 = import::env::invoke_iiiii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,
		                                   StringLiteral_18903,uVar3,param2,0);
		                iVar1 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar1 == 1) break;
		                DAT_ram_009d3e38 = 0;
		                uVar3 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x350,uVar3,
		                                   StringLiteral_5,0);
		                iVar1 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar1 == 1) {
		                  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x810522c3;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar2 = import::env::invoke_iiii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,uVar2,
		                                   uVar3,0);
		                iVar1 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar1 == 1) {
		                  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x810522c3;
		                }
		                iVar6 = iVar6 + 1;
		                if (iVar6 == iVar4) {
		                  DAT_ram_009d3e38 = 0;
		                  return uVar2;
		                }
		              }
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		          }
		        }
		      }
		    }
		  }
		code_r0x810522c3:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar5);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar4 != 0) {
		          import::env::__cxa_end_catch();
		          uVar2 = unnamed_function_2232(&StringLiteral_7424);
		          uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2,0);
		          iVar6 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar6 + 0x74) == 0) {
		            func_ii_306000(iVar6);
		          }
		          func_ii_7109(uVar2,0);
		          return param3;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81052400;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81052400:
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

		// Token: 0x06007573 RID: 30067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007573")]
		[Address(RVA = "0xBF04", Offset = "0xBF04", VA = "0xBF04", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
		/* --- GHIDRA: GetSetting_String ---
		void I2_Loc_I2BasePersistentStorage__GetSetting_String
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 *param2_00;
		  int local_4;
		  
		  if (DAT_ram_00a59720 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18903);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18902);
		    DAT_ram_00a59720 = '\x01';
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x350,param2,0,0);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = func_ii_4769(uVar2,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc6,uVar2,
		                         StringLiteral_18902,4,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (iVar3 == 0) goto code_r0x81052703;
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc5,uVar2,
		                           *(undefined4 *)(StringLiteral_18902 + 8),0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x810526c7:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       System_Globalization_CultureInfo_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x810526c7;
		          }
		          DAT_ram_009d3e38 = 0;
		          param3_00 = import::env::invoke_ii
		                                (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x10e,0);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 4,uVar2,param3_00,0
		                              );
		            iVar5 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar5 != 1) {
		              iVar5 = 0;
		              if (0 < iVar3) {
		                do {
		                  DAT_ram_009d3e38 = 0;
		                  local_4 = iVar5;
		                  uVar2 = import::env::invoke_iii
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                                     DAT_ram_00a66954,&local_4);
		                  iVar1 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar1 == 1) {
		                    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x81052739;
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar2 = import::env::invoke_iiiii
		                                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,
		                                     StringLiteral_18903,uVar2,param2,0);
		                  if (DAT_ram_009d3e38 == 1) {
		code_r0x810526ef:
		                    DAT_ram_009d3e38 = 0;
		                    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x81052739;
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x351,uVar2,0);
		                  if (DAT_ram_009d3e38 == 1) goto code_r0x810526ef;
		                  iVar5 = iVar5 + 1;
		                } while (iVar3 != iVar5);
		              }
		              goto code_r0x81052703;
		            }
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		    }
		    else {
		code_r0x81052703:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x351,param2,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x81052739:
		  iVar5 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar3) {
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
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
		        if (iVar3 != 0) {
		          import::env::__cxa_end_catch();
		          uVar2 = unnamed_function_2232(&StringLiteral_7407);
		          uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2,0);
		          iVar5 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar5 + 0x74) == 0) {
		            func_ii_306000(iVar5);
		          }
		          func_ii_7109(uVar2,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81052874;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81052874:
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

			return null;
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007574")]
		[Address(RVA = "0xBF05", Offset = "0xBF05", VA = "0xBF05", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		/* --- GHIDRA: DeleteSetting ---
		void I2_Loc_I2BasePersistentStorage__DeleteSetting(undefined4 param1,undefined4 param2)
		
		{
		  func_ii_10838(0);
		  return;
		}
		*/

		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007575")]
		[Address(RVA = "0xBF06", Offset = "0xBF06", VA = "0xBF06", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		/* --- GHIDRA: ForceSaveSettings ---
		undefined4
		I2_Loc_I2BasePersistentStorage__ForceSaveSettings
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UnityEngine_PlayerPrefs__GetString(param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x6007576")]
		[Address(RVA = "0xBF07", Offset = "0xBF07", VA = "0xBF07", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x6007577")]
		[Address(RVA = "0xBF08", Offset = "0xBF08", VA = "0xBF08", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
		/* --- GHIDRA: CanAccessFiles ---
		undefined4
		I2_Loc_I2BasePersistentStorage__CanAccessFiles
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5,
		          undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  int *param2_00;
		  undefined4 param4_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  if (iVar1 == 0) {
		    return 0;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iiiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x352,param1,param2,param3,
		                     param1);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    uVar2 = param3;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x22c,0);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x353,uVar2,param4,uVar3,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        return 1;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*piVar5);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar4 != 0) {
		          piVar5 = (int *)*piVar5;
		          import::env::__cxa_end_catch();
		          if (param5 == 0) {
		            return 0;
		          }
		          uVar3 = unnamed_function_2232(&StringLiteral_775);
		          param1_00 = unnamed_function_2232(&StringLiteral_7468);
		          if (piVar5 == (int *)0x0) {
		            param4_00 = 0;
		          }
		          else {
		            param4_00 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd8) * 4))
		                                  (piVar5,*(undefined4 *)(*piVar5 + 0xdc));
		          }
		          uVar2 = System_Int32__ToString(param1_00,uVar2,uVar3,param4_00,0);
		          iVar1 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar1 + 0x74) == 0) {
		            func_ii_306000(iVar1);
		          }
		          func_ii_7109(uVar2,0);
		          return 0;
		        }
		        param2_00 = (int *)unnamed_function_951(4);
		        *param2_00 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81052b93;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81052b93:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007578")]
		[Address(RVA = "0x1ED9", Offset = "0x1ED9", VA = "0x1ED9")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
		/* --- GHIDRA: UpdateFilename ---
		void I2_Loc_I2BasePersistentStorage__UpdateFilename
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param3_00;
		  int iVar6;
		  int iVar7;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a65579 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_StreamWriter_TypeInfo);
		    DAT_ram_00a65579 = '\x01';
		  }
		  if (param1 == 0) {
		    uVar4 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar4 = unnamed_function_1417(uVar4);
		    uVar5 = unnamed_function_2232(&StringLiteral_26041);
		    Mono_Security_X509_X509Certificate___ctor(uVar4,uVar5,0);
		    uVar5 = unnamed_function_2232(&Method_System_IO_File_WriteAllText__);
		    func_ii_1050(uVar4,uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param3 == 0) {
		    uVar4 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar4 = unnamed_function_1417(uVar4);
		    uVar5 = unnamed_function_2232(&StringLiteral_22921);
		    Mono_Security_X509_X509Certificate___ctor(uVar4,uVar5,0);
		    uVar5 = unnamed_function_2232(&Method_System_IO_File_WriteAllText__);
		    func_ii_1050(uVar4,uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(param1 + 8) == 0) {
		    uVar4 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		    uVar4 = unnamed_function_1417(uVar4);
		    uVar5 = unnamed_function_2232(&StringLiteral_7257);
		    param3_00 = unnamed_function_2232(&StringLiteral_26041);
		    System_IO_EndOfStreamException___ctor(uVar4,uVar5,param3_00,0);
		    uVar5 = unnamed_function_2232(&Method_System_IO_File_WriteAllText__);
		    func_ii_1050(uVar4,uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2 = (int *)unnamed_function_1417(System_IO_StreamWriter_TypeInfo);
		  System_IO_StreamWriter___ctor(piVar2,param1,0,param3,0x400,param1);
		  local_c = 0;
		  local_8 = &local_4;
		  DAT_ram_009d3e38 = 0;
		  local_4 = piVar2;
		  import::env::invoke_viii
		            (*(undefined4 *)(*piVar2 + 0x140),piVar2,param2,*(undefined4 *)(*piVar2 + 0x144));
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar6 = global_1;
		    iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 == iVar7) {
		      piVar2 = (int *)import::env::__cxa_begin_catch(uVar4);
		      iVar6 = *piVar2;
		      DAT_ram_009d3e38 = 0;
		      local_c = iVar6;
		      import::env::invoke_v(0x123);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) goto code_r0x8283d36a;
		      uVar4 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_0000514d + 2,&local_c);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x8283d36a:
		  piVar2 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8283d3e2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8283d3e2:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  }
		  if (iVar6 == 0) {
		    return;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x6007579")]
		[Address(RVA = "0xBF09", Offset = "0xBF09", VA = "0xBF09", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
		/* --- GHIDRA: SaveFile ---
		undefined4
		I2_Loc_I2BasePersistentStorage__SaveFile
		          (int *param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  int *param2_00;
		  undefined4 param4_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  if (iVar1 == 0) {
		    return 0;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iiiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x352,param1,param2,param3,
		                     param1);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    uVar2 = param3;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x22c,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x354,uVar2,uVar3,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        DAT_ram_009d3e38 = 0;
		        return uVar3;
		      }
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*piVar5);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar4 != 0) {
		          piVar5 = (int *)*piVar5;
		          import::env::__cxa_end_catch();
		          if (param4 == 0) {
		            return 0;
		          }
		          uVar3 = unnamed_function_2232(&StringLiteral_775);
		          param1_00 = unnamed_function_2232(&StringLiteral_7425);
		          if (piVar5 == (int *)0x0) {
		            param4_00 = 0;
		          }
		          else {
		            param4_00 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd8) * 4))
		                                  (piVar5,*(undefined4 *)(*piVar5 + 0xdc));
		          }
		          uVar2 = System_Int32__ToString(param1_00,uVar2,uVar3,param4_00,0);
		          iVar1 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar1 + 0x74) == 0) {
		            func_ii_306000(iVar1);
		          }
		          func_ii_7109(uVar2,0);
		          return 0;
		        }
		        param2_00 = (int *)unnamed_function_951(4);
		        *param2_00 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81052dfa;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81052dfa:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600757A")]
		[Address(RVA = "0xBF0A", Offset = "0xBF0A", VA = "0xBF0A", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
		/* --- GHIDRA: LoadFile ---
		undefined4
		I2_Loc_I2BasePersistentStorage__LoadFile
		          (int *param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  int *param2_00;
		  undefined4 param4_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  if (iVar1 == 0) {
		    return 0;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iiiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x352,0,param2,param3,0);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    uVar2 = param3;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x30d,uVar2,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return 1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*piVar5);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar4 != 0) {
		          piVar5 = (int *)*piVar5;
		          import::env::__cxa_end_catch();
		          if (param4 == 0) {
		            return 0;
		          }
		          uVar3 = unnamed_function_2232(&StringLiteral_775);
		          param1_00 = unnamed_function_2232(&StringLiteral_7408);
		          if (piVar5 == (int *)0x0) {
		            param4_00 = 0;
		          }
		          else {
		            param4_00 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd8) * 4))
		                                  (piVar5,*(undefined4 *)(*piVar5 + 0xdc));
		          }
		          uVar2 = System_Int32__ToString(param1_00,uVar2,uVar3,param4_00,0);
		          iVar1 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar1 + 0x74) == 0) {
		            func_ii_306000(iVar1);
		          }
		          func_ii_7109(uVar2,0);
		          return 0;
		        }
		        param2_00 = (int *)unnamed_function_951(4);
		        *param2_00 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81053024;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81053024:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x600757B")]
		[Address(RVA = "0xBF0B", Offset = "0xBF0B", VA = "0xBF0B", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
		/* --- GHIDRA: DeleteFile ---
		undefined4
		I2_Loc_I2BasePersistentStorage__DeleteFile
		          (int *param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  int *param2_00;
		  undefined4 param4_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  if (iVar1 == 0) {
		    return 0;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iiiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x352,param1,param2,param3,
		                     param1);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    uVar2 = param3;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x30c,uVar2,0)
		    ;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return uVar3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*piVar5);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar4 != 0) {
		          piVar5 = (int *)*piVar5;
		          import::env::__cxa_end_catch();
		          if (param4 == 0) {
		            return 0;
		          }
		          uVar3 = unnamed_function_2232(&StringLiteral_775);
		          param1_00 = unnamed_function_2232(&StringLiteral_7465);
		          if (piVar5 == (int *)0x0) {
		            param4_00 = 0;
		          }
		          else {
		            param4_00 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd8) * 4))
		                                  (piVar5,*(undefined4 *)(*piVar5 + 0xdc));
		          }
		          uVar2 = System_Int32__ToString(param1_00,uVar2,uVar3,param4_00,0);
		          iVar1 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar1 + 0x74) == 0) {
		            func_ii_306000(iVar1);
		          }
		          func_ii_7109(uVar2,0);
		          return 0;
		        }
		        param2_00 = (int *)unnamed_function_951(4);
		        *param2_00 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8105324c;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x8105324c:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x600757C")]
		[Address(RVA = "0xBF0C", Offset = "0xBF0C", VA = "0xBF0C", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600757D")]
		[Address(RVA = "0xBF0D", Offset = "0xBF0D", VA = "0xBF0D")]
		protected I2BasePersistentStorage()
		{
		}
	}
}
