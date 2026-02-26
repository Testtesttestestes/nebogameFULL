using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013B0 RID: 5040
	[Token(Token = "0x20013B0")]
	internal class RTLFixerTool
	{
		// Token: 0x060077D3 RID: 30675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077D3")]
		[Address(RVA = "0xC12E", Offset = "0xC12E", VA = "0xC12E")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
		/* --- GHIDRA: RemoveTashkeel ---
		int I2_Loc_RTLFixerTool__RemoveTashkeel(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar5 = 0;
		  iVar6 = 0;
		  if (DAT_ram_00a54e1d == '\0') {
		    Mono_Security_ASN1__get_Item(&char___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TashkeelLocation__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TashkeelLocation__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TashkeelLocation__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TashkeelLocation__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TashkeelLocation__get_Count__);
		    DAT_ram_00a54e1d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (char___TypeInfo,*(int *)(param1 + 0xc) + *(int *)(param2 + 0xc));
		  if (*(int *)(param1 + 0xc) < 1) {
		    return iVar2;
		  }
		code_r0x80b23281:
		  *(undefined2 *)(iVar2 + iVar5 * 2 + 0x10) = *(undefined2 *)(param1 + iVar6 * 2 + 0x10);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param2,
		             Method_System_Collections_Generic_List_TashkeelLocation__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = CONCAT44(puStack_1c,local_20);
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    iVar5 = iVar5 + 1;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_TashkeelLocation__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 != iVar3) {
		code_r0x80b233c8:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x126,&local_20);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 1) {
		            import::env::__resumeException(param1_00);
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
		        piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x80b233c8;
		        }
		        if (iVar3 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x80b233a7:
		        DAT_ram_009d3e38 = 0;
		        iVar6 = iVar6 + 1;
		        if (*(int *)(param1 + 0xc) <= iVar6) {
		          DAT_ram_009d3e38 = 0;
		          return iVar2;
		        }
		        goto code_r0x80b23281;
		      }
		      if (iVar3 == 0) goto code_r0x80b233a7;
		    } while (*(int *)(local_8._4_4_ + 0xc) != iVar5);
		    *(undefined2 *)(iVar2 + iVar5 * 2 + 0x10) = *(undefined2 *)(local_8._4_4_ + 8);
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077D4")]
		[Address(RVA = "0xC12F", Offset = "0xC12F", VA = "0xC12F")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
		/* --- GHIDRA: ReturnTashkeel ---
		undefined4 I2_Loc_RTLFixerTool__ReturnTashkeel(undefined4 param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  bool bVar2;
		  int iVar3;
		  uint uVar4;
		  short sVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int param1_00;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 uVar11;
		  ushort *puVar12;
		  ushort *puVar13;
		  int iVar14;
		  uint uVar15;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a54e1e == '\0') {
		    Mono_Security_ASN1__get_Item(&char___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_char__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_char__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_char___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_char__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_char__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_char__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_RTLFixerTool_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e1e = '\x01';
		  }
		  uVar11 = StringLiteral_5;
		  local_4 = 0;
		  if (*(int *)(I2_Loc_RTLFixerTool_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_RTLFixerTool_TypeInfo);
		  }
		  iVar3 = 0;
		  uVar6 = I2_Loc_TashkeelLocation___ctor(param1,&local_4,param1);
		  iVar7 = I2_Loc_StringObfucator__XoREncode(uVar6,0);
		  param1_00 = I2_Loc_StringObfucator__XoREncode(uVar6,0);
		  iVar14 = I2_Loc_RTLFixerTool_TypeInfo;
		  if (0 < *(int *)(iVar7 + 0xc)) {
		    do {
		      if (DAT_ram_00a54e1a == '\0') {
		        Mono_Security_ASN1__get_Item(&I2_Loc_ArabicTable_TypeInfo);
		        DAT_ram_00a54e1a = '\x01';
		      }
		      if (*(int *)(*(int *)(I2_Loc_ArabicTable_TypeInfo + 0x5c) + 4) == 0) {
		        uVar6 = unnamed_function_1417(I2_Loc_ArabicTable_TypeInfo);
		        I2_Loc_ArabicMapping___ctor(uVar6,iVar7);
		        *(undefined4 *)(*(int *)(I2_Loc_ArabicTable_TypeInfo + 0x5c) + 4) = uVar6;
		      }
		      puVar12 = (ushort *)(iVar7 + iVar3 * 2 + 0x10);
		      uVar6 = I2_Loc_ArabicTable__get_ArabicMapper(iVar7,(uint)*puVar12,iVar7);
		      *puVar12 = (ushort)uVar6;
		      iVar3 = iVar3 + 1;
		      iVar8 = *(int *)(iVar7 + 0xc);
		    } while (iVar3 < iVar8);
		    iVar3 = 0;
		    iVar14 = I2_Loc_RTLFixerTool_TypeInfo;
		    if (0 < iVar8) {
		      do {
		        puVar12 = (ushort *)(iVar7 + iVar3 * 2 + 0x10);
		        if (*puVar12 == 0xfedd) {
		          if (iVar3 < iVar8 + -1) {
		            uVar4 = *(ushort *)(iVar7 + (iVar3 + 1) * 2 + 0x10) + 0x17f;
		            uVar15 = uVar4 * 0x8000;
		            uVar4 = (uVar4 & 0xfffe) >> 1;
		            if ((uVar15 & 0xffff | uVar4) < 7) {
		              if ((0x4bU >> (uVar4 & 0x1f) & 1) == 0) {
		                iVar8 = 0;
		              }
		              else {
		                *puVar12 = *(ushort *)
		                            (&DAT_ram_005a35d4 + (short)((ushort)uVar15 | (ushort)uVar4) * 2);
		                *(undefined2 *)(param1_00 + (iVar3 + 1) * 2 + 0x10) = 0xffff;
		                iVar8 = 1;
		              }
		            }
		            else {
		              iVar8 = 0;
		            }
		          }
		          else {
		            iVar8 = 0;
		          }
		        }
		        else {
		          iVar8 = 0;
		        }
		        uVar1 = *puVar12;
		        if (*(int *)(I2_Loc_RTLFixerTool_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_RTLFixerTool_TypeInfo);
		        }
		        iVar14 = I2_Loc_RTLFixerTool__FixLine((uint)uVar1,iVar7);
		        if (iVar14 == 0) {
		          if (*(int *)(I2_Loc_RTLFixerTool_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_RTLFixerTool_TypeInfo);
		          }
		          sVar5 = 3;
		          iVar14 = I2_Loc_RTLFixerTool__IsFinishingLetter(iVar7,iVar3,iVar7);
		          if (iVar14 == 0) {
		            if (*(int *)(I2_Loc_RTLFixerTool_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_RTLFixerTool_TypeInfo);
		            }
		            sVar5 = 1;
		            iVar14 = I2_Loc_RTLFixerTool__IsLeadingLetter(iVar7,iVar3,iVar7);
		            if (iVar14 == 0) {
		              if (*(int *)(I2_Loc_RTLFixerTool_TypeInfo + 0x74) == 0) {
		                func_ii_306000(I2_Loc_RTLFixerTool_TypeInfo);
		              }
		              sVar5 = 2;
		              iVar14 = I2_Loc_RTLFixerTool__IsIgnoredCharacter(iVar7,iVar3,iVar7);
		              if (iVar14 == 0) goto code_r0x80b1fd84;
		            }
		          }
		          *(ushort *)(iVar3 * 2 + param1_00 + 0x10) = *puVar12 + sVar5;
		        }
		code_r0x80b1fd84:
		        uVar1 = *puVar12;
		        if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Convert_TypeInfo);
		        }
		        uVar6 = System_Convert__ToString((uint)uVar1,0x10,0);
		        uVar11 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                           (uVar11,uVar6,StringLiteral_118,0);
		        if (*(int *)(I2_Loc_RTLFixerTool_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_RTLFixerTool_TypeInfo);
		        }
		        iVar14 = I2_Loc_RTLFixerTool_TypeInfo;
		        if (*(char *)(*(int *)(I2_Loc_RTLFixerTool_TypeInfo + 0x5c) + 1) != '\0') {
		          iVar9 = (iVar3 + iVar8) * 2;
		          sVar5 = *(short *)(iVar7 + iVar9 + 0x10);
		          if ((ushort)(sVar5 - 0x30U) < 10) {
		            *(short *)(iVar9 + param1_00 + 0x10) = sVar5 + 0x630;
		          }
		        }
		        iVar3 = iVar3 + iVar8 + 1;
		        iVar8 = *(int *)(iVar7 + 0xc);
		      } while (iVar3 < iVar8);
		    }
		  }
		  if (*(int *)(iVar14 + 0x74) == 0) {
		    func_ii_306000(iVar14);
		    iVar14 = I2_Loc_RTLFixerTool_TypeInfo;
		  }
		  uVar11 = local_4;
		  if (**(char **)(iVar14 + 0x5c) != '\0') {
		    if (*(int *)(iVar14 + 0x74) == 0) {
		      func_ii_306000(iVar14);
		    }
		    param1_00 = I2_Loc_RTLFixerTool__RemoveTashkeel(param1_00,uVar11,uVar11);
		  }
		  iVar7 = unnamed_function_1417(System_Collections_Generic_List_char__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar7,Method_System_Collections_Generic_List_char___ctor__);
		  iVar8 = unnamed_function_1417(System_Collections_Generic_List_char__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar8,Method_System_Collections_Generic_List_char___ctor__);
		  iVar3 = *(int *)(param1_00 + 0xc) + -1;
		  iVar14 = *(int *)(param1_00 + 0xc);
		  if (-1 < iVar3) {
		    do {
		      puVar12 = (ushort *)(param1_00 + iVar3 * 2 + 0x10);
		      uVar1 = *puVar12;
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar9 = func_ii_6380((uint)uVar1,0);
		      if (((iVar3 == 0) || (iVar9 == 0)) || (*(int *)(param1_00 + 0xc) + -1 <= iVar3)) {
		code_r0x80b2025f:
		        if (((iVar3 == 0) || (*puVar12 != 0x20)) || (*(int *)(param1_00 + 0xc) + -1 <= iVar3)) {
		code_r0x80b20409:
		          uVar1 = *puVar12;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar14 = System_Char__CheckNumber((uint)uVar1,0);
		          if (iVar14 == 0) {
		            uVar1 = *puVar12;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar14 = System_Char__IsUpper((uint)uVar1,0);
		            if (iVar14 == 0) {
		              uVar1 = *puVar12;
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar14 = System_Char__IsWhiteSpaceLatin1((uint)uVar1,0);
		              if (iVar14 == 0) {
		                uVar1 = *puVar12;
		                if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                  func_ii_306000(DAT_ram_00a66974);
		                }
		                iVar14 = System_Char__CheckSymbol((uint)uVar1,0);
		                if (iVar14 == 0) {
		                  uVar1 = *puVar12;
		                  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                    func_ii_306000(DAT_ram_00a66974);
		                  }
		                  iVar9 = func_ii_6380((uint)uVar1,0);
		                  iVar14 = Method_System_Collections_Generic_List_char__Add__;
		                  if (iVar9 == 0) {
		                    uVar1 = *puVar12;
		                    uVar4 = (uint)uVar1;
		                    if (s_EarlyUpdate_ProcessMouseInWindow_ram_0000f7fd + 2 <
		                        (char *)(uVar4 + 0x2000 & 0xffff)) {
		                      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                      uVar15 = *(uint *)(iVar8 + 0xc);
		                      if (uVar15 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                        *(uint *)(iVar8 + 0xc) = uVar15 + 1;
		                        *(ushort *)(*(int *)(iVar8 + 8) + uVar15 * 2 + 0x10) = uVar1;
		                      }
		                      else {
		                        func_ii_2963(iVar8,uVar4,
		                                     *(undefined4 *)
		                                      (*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		                      }
		                    }
		                    else {
		                      uVar15 = 0;
		                      iVar14 = *(int *)(iVar8 + 0xc);
		                      if (0 < iVar14) {
		                        do {
		                          uVar11 = System_Collections_Generic_List_ushort___get_Count
		                                             (iVar8,iVar14 + (uVar15 ^ 0xffffffff),
		                                              Method_System_Collections_Generic_List_char__get_Item__
		                                             );
		                          iVar14 = Method_System_Collections_Generic_List_char__Add__;
		                          *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		                          uVar4 = *(uint *)(iVar7 + 0xc);
		                          if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		                            *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		                            *(short *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = (short)uVar11;
		                          }
		                          else {
		                            func_ii_2963(iVar7,uVar11,
		                                         *(undefined4 *)
		                                          (*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		                          }
		                          uVar15 = uVar15 + 1;
		                          iVar14 = *(int *)(iVar8 + 0xc);
		                        } while ((int)uVar15 < iVar14);
		                        uVar4 = (uint)*puVar12;
		                        *(undefined4 *)(iVar8 + 0xc) = 0;
		                        *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                      }
		                      iVar14 = Method_System_Collections_Generic_List_char__Add__;
		                      if (uVar4 != 0xffff) {
		                        *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		                        uVar15 = *(uint *)(iVar7 + 0xc);
		                        if (uVar15 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		                          *(uint *)(iVar7 + 0xc) = uVar15 + 1;
		                          *(short *)(*(int *)(iVar7 + 8) + uVar15 * 2 + 0x10) = (short)uVar4;
		                        }
		                        else {
		                          func_ii_2963(iVar7,uVar4,
		                                       *(undefined4 *)
		                                        (*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		                        }
		                      }
		                    }
		                    goto code_r0x80b2094b;
		                  }
		                }
		              }
		            }
		          }
		          iVar14 = Method_System_Collections_Generic_List_char__Add__;
		          uVar1 = *puVar12;
		          uVar4 = (uint)uVar1;
		          if (uVar4 == 0x28) {
		            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		            uVar4 = *(uint *)(iVar8 + 0xc);
		            if (uVar4 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		              *(uint *)(iVar8 + 0xc) = uVar4 + 1;
		              *(undefined2 *)(*(int *)(iVar8 + 8) + uVar4 * 2 + 0x10) = 0x29;
		            }
		            else {
		              func_ii_2963(iVar8,0x29,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          else if (uVar4 == 0x29) {
		            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		            uVar4 = *(uint *)(iVar8 + 0xc);
		            if (uVar4 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		              *(uint *)(iVar8 + 0xc) = uVar4 + 1;
		              *(undefined2 *)(*(int *)(iVar8 + 8) + uVar4 * 2 + 0x10) = 0x28;
		            }
		            else {
		              func_ii_2963(iVar8,0x28,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          else if ((((uVar4 == 0x2a) || (uVar4 == 0x2b)) ||
		                   ((uVar4 == 0x2c || (((uVar4 == 0x2d || (uVar4 == 0x2e)) || (uVar4 == 0x2f))))))
		                  || (((uVar4 == 0x30 || (uVar4 == 0x31)) ||
		                      ((uVar4 == 0x32 ||
		                       (((uVar4 == 0x33 || (uVar4 == 0x34)) ||
		                        ((uVar4 == 0x35 ||
		                         (((((uVar4 == 0x36 || (uVar4 == 0x37)) || (uVar4 == 0x38)) ||
		                           ((uVar4 == 0x39 || (uVar4 == 0x3a)))) || (uVar4 == 0x3b)))))))))))) {
		code_r0x80b20762:
		            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		            uVar15 = *(uint *)(iVar8 + 0xc);
		            if (uVar15 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		              *(uint *)(iVar8 + 0xc) = uVar15 + 1;
		              *(ushort *)(*(int *)(iVar8 + 8) + uVar15 * 2 + 0x10) = uVar1;
		            }
		            else {
		              func_ii_2963(iVar8,uVar4,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          else if (uVar4 == 0x3c) {
		            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		            uVar4 = *(uint *)(iVar8 + 0xc);
		            if (uVar4 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		              *(uint *)(iVar8 + 0xc) = uVar4 + 1;
		              *(undefined2 *)(*(int *)(iVar8 + 8) + uVar4 * 2 + 0x10) = 0x3e;
		            }
		            else {
		              func_ii_2963(iVar8,0x3e,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          else {
		            if (uVar4 == 0x3d) goto code_r0x80b20762;
		            if (uVar4 == 0x3e) {
		              *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		              uVar4 = *(uint *)(iVar8 + 0xc);
		              if (uVar4 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                *(uint *)(iVar8 + 0xc) = uVar4 + 1;
		                *(undefined2 *)(*(int *)(iVar8 + 8) + uVar4 * 2 + 0x10) = 0x3c;
		              }
		              else {
		                func_ii_2963(iVar8,0x3c,
		                             *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		              }
		            }
		            else {
		              if (((((uVar4 == 0x3f) || (uVar4 == 0x40)) ||
		                   ((uVar4 == 0x41 || (((uVar4 == 0x42 || (uVar4 == 0x43)) || (uVar4 == 0x44))))))
		                  || ((((((uVar4 == 0x45 || (uVar4 == 0x46)) || (uVar4 == 0x47)) ||
		                        ((uVar4 == 0x48 || (uVar4 == 0x49)))) ||
		                       (((uVar4 == 0x4a || (((uVar4 == 0x4b || (uVar4 == 0x4c)) || (uVar4 == 0x4d)))
		                         ) || ((uVar4 == 0x4e || (uVar4 == 0x4f)))))) ||
		                      (((uVar4 == 0x50 ||
		                        (((uVar4 == 0x51 || (uVar4 == 0x52)) ||
		                         ((uVar4 == 0x53 ||
		                          ((((uVar4 == 0x54 || (uVar4 == 0x55)) || (uVar4 == 0x56)) ||
		                           ((uVar4 == 0x57 || (uVar4 == 0x58)))))))))) || (uVar4 == 0x59)))))) ||
		                 (uVar4 == 0x5a)) goto code_r0x80b20762;
		              if (uVar4 == 0x5b) {
		                *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		                uVar4 = *(uint *)(iVar7 + 0xc);
		                if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		                  *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		                  *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x5d;
		                }
		                else {
		                  func_ii_2963(iVar7,0x5d,
		                               *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		                }
		              }
		              else {
		                if ((uVar4 == 0x5c) || (uVar4 != 0x5d)) goto code_r0x80b20762;
		                *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		                uVar4 = *(uint *)(iVar7 + 0xc);
		                if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		                  *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		                  *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x5b;
		                }
		                else {
		                  func_ii_2963(iVar7,0x5b,
		                               *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		                }
		              }
		            }
		          }
		        }
		        else {
		          iVar14 = iVar14 * 2 + param1_00;
		          puVar13 = (ushort *)(iVar14 + 0xc);
		          uVar1 = *puVar13;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar9 = System_Char__IsUpper((uint)uVar1,0);
		          if (iVar9 == 0) {
		            uVar1 = *puVar13;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar9 = System_Char__IsWhiteSpaceLatin1((uint)uVar1,0);
		            if (iVar9 == 0) {
		              uVar1 = *puVar13;
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar9 = System_Char__CheckNumber((uint)uVar1,0);
		              if (iVar9 == 0) goto code_r0x80b20409;
		            }
		          }
		          puVar13 = (ushort *)(iVar14 + 0x10);
		          uVar1 = *puVar13;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar14 = System_Char__IsUpper((uint)uVar1,0);
		          if (iVar14 == 0) {
		            uVar1 = *puVar13;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar14 = System_Char__IsWhiteSpaceLatin1((uint)uVar1,0);
		            if (iVar14 == 0) {
		              uVar1 = *puVar13;
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar14 = System_Char__CheckNumber((uint)uVar1,0);
		              if (iVar14 == 0) goto code_r0x80b20409;
		            }
		          }
		          iVar14 = Method_System_Collections_Generic_List_char__Add__;
		          uVar1 = *puVar12;
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar4 = *(uint *)(iVar8 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar4 + 1;
		            *(ushort *)(*(int *)(iVar8 + 8) + uVar4 * 2 + 0x10) = uVar1;
		          }
		          else {
		            func_ii_2963(iVar8,(uint)uVar1,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      else {
		        iVar9 = iVar14 * 2 + param1_00;
		        uVar1 = *(ushort *)(iVar9 + 0xc);
		        if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		          func_ii_306000(DAT_ram_00a66974);
		        }
		        iVar10 = func_ii_6380((uint)uVar1,0);
		        if (iVar10 == 0) {
		          uVar1 = *(ushort *)(iVar9 + 0x10);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar9 = func_ii_6380((uint)uVar1,0);
		          if (iVar9 == 0) goto code_r0x80b2025f;
		        }
		        iVar14 = Method_System_Collections_Generic_List_char__Add__;
		        uVar1 = *puVar12;
		        uVar4 = (uint)uVar1;
		        if (uVar4 == 0x28) {
		          *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		          uVar4 = *(uint *)(iVar7 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		            *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		            *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x29;
		          }
		          else {
		            func_ii_2963(iVar7,0x29,*(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38)
		                        );
		          }
		        }
		        else if (uVar4 == 0x29) {
		          *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		          uVar4 = *(uint *)(iVar7 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		            *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		            *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x28;
		          }
		          else {
		            func_ii_2963(iVar7,0x28,*(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38)
		                        );
		          }
		        }
		        else if (((((uVar4 == 0x2a) || (uVar4 == 0x2b)) ||
		                  ((uVar4 == 0x2c || ((uVar4 == 0x2d || (uVar4 == 0x2e)))))) ||
		                 ((uVar4 == 0x2f ||
		                  ((((((uVar4 == 0x30 || (uVar4 == 0x31)) || (uVar4 == 0x32)) ||
		                     ((uVar4 == 0x33 || (uVar4 == 0x34)))) ||
		                    ((uVar4 == 0x35 || ((uVar4 == 0x36 || (uVar4 == 0x37)))))) || (uVar4 == 0x38))))
		                 )) || (((uVar4 == 0x39 || (uVar4 == 0x3a)) || (uVar4 == 0x3b)))) {
		code_r0x80b20203:
		          *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		          uVar15 = *(uint *)(iVar7 + 0xc);
		          if (uVar15 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		            *(uint *)(iVar7 + 0xc) = uVar15 + 1;
		            *(ushort *)(*(int *)(iVar7 + 8) + uVar15 * 2 + 0x10) = uVar1;
		          }
		          else {
		            func_ii_2963(iVar7,uVar4,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		          }
		        }
		        else if (uVar4 == 0x3c) {
		          *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		          uVar4 = *(uint *)(iVar7 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		            *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		            *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x3e;
		          }
		          else {
		            func_ii_2963(iVar7,0x3e,*(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38)
		                        );
		          }
		        }
		        else {
		          if (uVar4 == 0x3d) goto code_r0x80b20203;
		          if (uVar4 == 0x3e) {
		            *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		            uVar4 = *(uint *)(iVar7 + 0xc);
		            if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		              *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		              *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x3c;
		            }
		            else {
		              func_ii_2963(iVar7,0x3c,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          else {
		            if (((((uVar4 == 0x3f) || (uVar4 == 0x40)) ||
		                 (((uVar4 == 0x41 || ((uVar4 == 0x42 || (uVar4 == 0x43)))) || (uVar4 == 0x44)))) ||
		                (((((uVar4 == 0x45 || (uVar4 == 0x46)) || (uVar4 == 0x47)) ||
		                  (((uVar4 == 0x48 || (uVar4 == 0x49)) ||
		                   ((uVar4 == 0x4a || ((uVar4 == 0x4b || (uVar4 == 0x4c)))))))) ||
		                 ((uVar4 == 0x4d ||
		                  ((((uVar4 == 0x4e || (uVar4 == 0x4f)) || (uVar4 == 0x50)) ||
		                   ((uVar4 == 0x51 || (uVar4 == 0x52)))))))))) ||
		               (((uVar4 == 0x53 || ((uVar4 == 0x54 || (uVar4 == 0x55)))) ||
		                ((uVar4 == 0x56 ||
		                 ((((uVar4 == 0x57 || (uVar4 == 0x58)) || (uVar4 == 0x59)) || (uVar4 == 0x5a))))))))
		            goto code_r0x80b20203;
		            if (uVar4 == 0x5b) {
		              *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		              uVar4 = *(uint *)(iVar7 + 0xc);
		              if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		                *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		                *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x5d;
		              }
		              else {
		                func_ii_2963(iVar7,0x5d,
		                             *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		              }
		            }
		            else {
		              if (uVar4 == 0x5c) goto code_r0x80b20203;
		              if (uVar4 == 0x5d) {
		                *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		                uVar4 = *(uint *)(iVar7 + 0xc);
		                if (uVar4 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		                  *(uint *)(iVar7 + 0xc) = uVar4 + 1;
		                  *(undefined2 *)(*(int *)(iVar7 + 8) + uVar4 * 2 + 0x10) = 0x5b;
		                }
		                else {
		                  func_ii_2963(iVar7,0x5b,
		                               *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		                }
		              }
		              else if (uVar4 != 0xffff) goto code_r0x80b20203;
		            }
		          }
		        }
		      }
		code_r0x80b2094b:
		      bVar2 = 0 < iVar3;
		      iVar14 = iVar3;
		      iVar3 = iVar3 + -1;
		    } while (bVar2);
		  }
		  iVar14 = *(int *)(iVar8 + 0xc);
		  if (0 < iVar14) {
		    uVar4 = 0;
		    do {
		      uVar11 = System_Collections_Generic_List_ushort___get_Count
		                         (iVar8,iVar14 + (uVar4 ^ 0xffffffff),
		                          Method_System_Collections_Generic_List_char__get_Item__);
		      iVar14 = Method_System_Collections_Generic_List_char__Add__;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar15 = *(uint *)(iVar7 + 0xc);
		      if (uVar15 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar15 + 1;
		        *(short *)(*(int *)(iVar7 + 8) + uVar15 * 2 + 0x10) = (short)uVar11;
		      }
		      else {
		        func_ii_2963(iVar7,uVar11,*(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		      }
		      uVar4 = uVar4 + 1;
		      iVar14 = *(int *)(iVar8 + 0xc);
		    } while ((int)uVar4 < iVar14);
		    *(undefined4 *)(iVar8 + 0xc) = 0;
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		  }
		  iVar14 = 0;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(char___TypeInfo,*(undefined4 *)(iVar7 + 0xc));
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar11 = System_Collections_Generic_List_ushort___get_Count
		                         (iVar7,iVar14,Method_System_Collections_Generic_List_char__get_Item__);
		      *(short *)(iVar3 + iVar14 * 2 + 0x10) = (short)uVar11;
		      iVar14 = iVar14 + 1;
		    } while (iVar14 < *(int *)(iVar3 + 0xc));
		  }
		  uVar11 = System_String__ToCharArray(0,iVar3,0);
		  return uVar11;
		}
		*/

			return null;
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077D5")]
		[Address(RVA = "0xC130", Offset = "0xC130", VA = "0xC130")]
		internal static string FixLine(string str)
		{
		/* --- GHIDRA: FixLine ---
		uint I2_Loc_RTLFixerTool__FixLine(char *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  bool bVar2;
		  uint uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  bVar2 = true;
		  bVar1 = false;
		  iVar4 = func_ii_6380(param1,0);
		  iVar5 = System_Char__CheckNumber(param1,0);
		  iVar6 = System_Char__IsUpper(param1,0);
		  iVar7 = System_Char__IsWhiteSpaceLatin1(param1,0);
		  iVar8 = System_Char__CheckSymbol(param1,0);
		  if (((param1 == s_glProgramUniformMatrix4fv_ram_0000fb66 + 0x14) ||
		      (((((((param1 != s_glProgramUniformMatrix4fv_ram_0000fb66 + 0x15 &&
		            (param1 != s_glProgramUniformMatrix4fv_ram_0000fb66 + 0x16)) &&
		           (param1 != s_glProgramUniformMatrix4fv_ram_0000fb66 + 0x17)) &&
		          (((param1 != s_glProgramUniformMatrix4fv_ram_0000fb66 + 0x18 &&
		            (param1 != s_glProgramUniformMatrix4fv_ram_0000fb66 + 0x19)) &&
		           ((param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 &&
		            ((param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 1 &&
		             (param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 2)))))))) &&
		         (param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 3)) &&
		        (((param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 4 &&
		          (param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 5)) &&
		         (param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 6)))) &&
		       (((param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 7 &&
		         (param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 8)) &&
		        ((param1 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 9 &&
		         ((param1 == s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 10 ||
		          (param1 == s_glProgramUniform1iv_ram_0000fb4a + 0xc)))))))))) ||
		     (bVar2 = param1 == s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 0x12 ||
		              param1 == s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 0xe,
		     param1 <= &DAT_ram_0000feff)) {
		    bVar1 = s_AsyncGPUReadback___Not_enough_sp_ram_0000fe30 + 0x3f < param1;
		  }
		  uVar3 = 1;
		  if (((((bVar1 || bVar2) || param1 == s_glProgramUniformMatrix4x3fv_ram_0000fbe6 + 0x16) &&
		        ((((iVar4 == 0 && iVar5 == 0) && iVar6 == 0) && iVar7 == 0) && iVar8 == 0)) &&
		      (param1 != (char *)0x3e)) && (param1 != (char *)0x61)) {
		    uVar3 = (uint)(param1 == (char *)0x3c ||
		                  param1 == s_You_can_attach_a_native_debugger_ram_0000061a + 1);
		  }
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00016008 File Offset: 0x00014208
		[Token(Token = "0x60077D6")]
		[Address(RVA = "0xC131", Offset = "0xC131", VA = "0xC131")]
		internal static bool IsIgnoredCharacter(char ch)
		{
		/* --- GHIDRA: IsIgnoredCharacter ---
		uint I2_Loc_RTLFixerTool__IsIgnoredCharacter(int param1,int param2,undefined4 param3)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  uint uVar3;
		  int iVar4;
		  char *pcVar5;
		  uint uVar6;
		  ushort *puVar7;
		  
		  uVar2 = 1;
		  if (param2 != 0) {
		    puVar7 = (ushort *)(param2 * 2 + param1 + 0xe);
		    uVar3 = (uint)*puVar7;
		    if ((uVar3 != 0x20) &&
		       (((((uVar3 == 0x21 || (uVar3 == 0x22)) || (uVar3 == 0x23)) ||
		         ((((uVar3 == 0x24 || (uVar3 == 0x25)) ||
		           ((uVar3 == 0x26 || ((uVar3 == 0x27 || (uVar3 == 0x28)))))) || (uVar3 == 0x29)))) ||
		        ((uVar3 != 0x2a && (uVar3 != 0x41)))))) {
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar4 = func_ii_6380(uVar3,0);
		      if (iVar4 == 0) {
		        uVar1 = *puVar7;
		        if (uVar1 < 0xfe81) {
		          if ((uVar1 == 0x3c) || ((uVar1 != 0x3d && ((uVar1 == 0x3e || (uVar1 == 0xfb8a))))))
		          goto code_r0x80b23027;
		        }
		        else if ((uVar1 == 0xfe81) ||
		                ((uVar1 != 0xfe82 &&
		                 ((uVar1 == 0xfe83 ||
		                  ((((uVar1 != 0xfe84 && (uVar1 != 0xfe85)) && (uVar1 != 0xfe86)) &&
		                   ((uVar1 == 0xfe87 ||
		                    ((((uVar1 != 0xfe88 && (uVar1 != 0xfe89)) &&
		                      ((uVar1 != 0xfe8a && ((uVar1 != 0xfe8b && (uVar1 != 0xfe8c)))))) &&
		                     ((uVar1 == 0xfe8d ||
		                      (((((((uVar1 != 0xfe8e && (uVar1 != 0xfe8f)) && (uVar1 != 0xfe90)) &&
		                          ((uVar1 != 0xfe91 && (uVar1 != 0xfe92)))) &&
		                         ((((uVar1 != 0xfe93 && ((uVar1 != 0xfe94 && (uVar1 != 0xfe95)))) &&
		                           (uVar1 != 0xfe96)) &&
		                          ((((((uVar1 != 0xfe97 && (uVar1 != 0xfe98)) && (uVar1 != 0xfe99)) &&
		                             ((uVar1 != 0xfe9a && (uVar1 != 0xfe9b)))) &&
		                            ((uVar1 != 0xfe9c && ((uVar1 != 0xfe9d && (uVar1 != 0xfe9e)))))) &&
		                           (uVar1 != 0xfe9f)))))) &&
		                        (((((uVar1 != 0xfea0 && (uVar1 != 0xfea1)) && (uVar1 != 0xfea2)) &&
		                          (((uVar1 != 0xfea3 && (uVar1 != 0xfea4)) &&
		                           ((uVar1 != 0xfea5 && ((uVar1 != 0xfea6 && (uVar1 != 0xfea7)))))))) &&
		                         (uVar1 != 0xfea8)))) &&
		                       ((uVar1 == 0xfea9 ||
		                        ((uVar1 != 0xfeaa &&
		                         ((uVar1 == 0xfeab ||
		                          ((uVar1 != 0xfeac &&
		                           ((uVar1 == 0xfead ||
		                            ((uVar1 != 0xfeae && ((uVar1 == 0xfeaf || (uVar1 == 0xfeed))))))))))))))
		                       )))))))))))))))) goto code_r0x80b23027;
		        uVar2 = (uint)(uVar1 == 0xfe85);
		      }
		    }
		  }
		code_r0x80b23027:
		  uVar3 = 0;
		  pcVar5 = (char *)(uint)*(ushort *)(param1 + param2 * 2 + 0x10);
		  if (((((1 << ((uint)(pcVar5 + -0xfea9) & 0x1f) & 0x55U) == 0 || (char *)0x6 < pcVar5 + -0xfea9) &&
		       (pcVar5 != (char *)0x20)) && (pcVar5 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 10)) &&
		     (uVar6 = ((uint)(pcVar5 + 0x17f) & 0xfffe) >> 1,
		     ((uint)(((int)(pcVar5 + 0x17f) * 0x8000 & 0xffffU | uVar6) < 7) & 0x4fU >> (uVar6 & 0x1f) & 1)
		     == 0)) {
		    uVar3 = (uint)(pcVar5 != s_recursing_to_lookup__u_at__u_ram_0000feda + 0x13 &&
		                  pcVar5 != &DAT_ram_0000fe80);
		  }
		  if (param2 < *(int *)(param1 + 0xc) + -1) {
		    puVar7 = (ushort *)(param2 * 2 + param1 + 0x12);
		    uVar1 = *puVar7;
		    if (uVar1 == 0x20) {
		      uVar6 = 0;
		    }
		    else {
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar4 = func_ii_6380((uint)uVar1,0);
		      if (iVar4 == 0) {
		        uVar1 = *puVar7;
		        if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		          func_ii_306000(DAT_ram_00a66974);
		        }
		        iVar4 = System_Char__CheckNumber((uint)uVar1,0);
		        if (iVar4 == 0) {
		          uVar1 = *puVar7;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar4 = System_Char__CheckSymbol((uint)uVar1,0);
		          if (iVar4 == 0) {
		            uVar1 = *puVar7;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar4 = System_Char__IsUpper((uint)uVar1,0);
		            if (iVar4 == 0) {
		              uVar1 = *puVar7;
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar4 = System_Char__IsWhiteSpaceLatin1((uint)uVar1,0);
		              if (iVar4 == 0) {
		                uVar6 = (uint)(*puVar7 != 0xfe80);
		              }
		              else {
		                uVar6 = 0;
		              }
		            }
		            else {
		              uVar6 = 0;
		            }
		          }
		          else {
		            uVar6 = 0;
		          }
		        }
		        else {
		          uVar6 = 0;
		        }
		      }
		      else {
		        uVar6 = 0;
		      }
		    }
		  }
		  else {
		    uVar6 = 0;
		  }
		  return uVar6 & uVar2 & uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00016020 File Offset: 0x00014220
		[Token(Token = "0x60077D7")]
		[Address(RVA = "0xC132", Offset = "0xC132", VA = "0xC132")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
		/* --- GHIDRA: IsLeadingLetter ---
		uint I2_Loc_RTLFixerTool__IsLeadingLetter(int param1,int param2,undefined4 param3)
		
		{
		  short sVar1;
		  uint uVar2;
		  int iVar3;
		  ushort *puVar4;
		  char *param1_00;
		  
		  uVar2 = 0;
		  if (param2 != 0) {
		    puVar4 = (ushort *)(param2 * 2 + param1 + 0xe);
		    param1_00 = (char *)(uint)*puVar4;
		    if (((param1_00 != &DAT_ram_0000fe80) &&
		        (param1_00 != s_try_kerning_glyphs_at__u__u_ram_0000fe81)) &&
		       ((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 1 ||
		        ((param1_00 != s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 2 &&
		         ((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 3 ||
		          ((param1_00 != s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 4 &&
		           ((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 5 ||
		            ((param1_00 != s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 6 &&
		             (((((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 7 ||
		                 (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 8)) ||
		                (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 9)) ||
		               ((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 10 ||
		                (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xb)))) ||
		              ((param1_00 != s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xc &&
		               (((((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xd ||
		                   (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xe)) ||
		                  ((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xf ||
		                   ((((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x10 ||
		                      (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x11)) ||
		                     (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x12)) ||
		                    ((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x13 ||
		                     (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x14)))))))) ||
		                 (((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x15 ||
		                   ((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x16 ||
		                    (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x17)))) ||
		                  (((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x18 ||
		                    (((param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x19 ||
		                      (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x1a)) ||
		                     (param1_00 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x1b)))) ||
		                   ((((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d ||
		                      (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 1)) ||
		                     (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 2)) ||
		                    (((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 3 ||
		                      (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 4)) ||
		                     ((((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 5 ||
		                        (((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 6 ||
		                          (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 7)) ||
		                         (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 8)))) ||
		                       ((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 9 ||
		                        (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 10)))) ||
		                      (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xb))))))))))))
		                || ((param1_00 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xc &&
		                    ((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xd ||
		                     ((param1_00 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xe &&
		                      ((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xf ||
		                       ((param1_00 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x10 &&
		                        ((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x11 ||
		                         ((param1_00 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x12 &&
		                          ((((((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x13 ||
		                               (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x14))
		                              || ((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x15
		                                  || ((((param1_00 ==
		                                         s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x16 ||
		                                        (param1_00 ==
		                                         s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x17)) ||
		                                       (param1_00 ==
		                                        s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x18)) ||
		                                      ((param1_00 ==
		                                        s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x19 ||
		                                       (param1_00 ==
		                                        s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x1a))))))))
		                             || (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x1b))
		                            || ((param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x1c ||
		                                (param1_00 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x1d)))
		                            ) || (((((((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb ||
		                                       (((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 1 ||
		                                         (param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 2))
		                                        || (param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 3))
		                                       )) || (((param1_00 ==
		                                                s_kerned_glyphs_at__u__u_ram_0000febb + 4 ||
		                                               (param1_00 ==
		                                                s_kerned_glyphs_at__u__u_ram_0000febb + 5)) ||
		                                              (param1_00 ==
		                                               s_kerned_glyphs_at__u__u_ram_0000febb + 6)))) ||
		                                     (((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 7 ||
		                                       (param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 8)) ||
		                                      ((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 9 ||
		                                       (((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 10 ||
		                                         (param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 0xb))
		                                        || (param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 0xc
		                                           )))))))) ||
		                                    (((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 0xd ||
		                                      (param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 0xe)) ||
		                                     ((((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 0xf ||
		                                        (((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 0x10
		                                          || (param1_00 ==
		                                              s_kerned_glyphs_at__u__u_ram_0000febb + 0x11)) ||
		                                         ((param1_00 == s_kerned_glyphs_at__u__u_ram_0000febb + 0x12
		                                          || (((((param1_00 ==
		                                                  s_kerned_glyphs_at__u__u_ram_0000febb + 0x13 ||
		                                                 (param1_00 ==
		                                                  s_kerned_glyphs_at__u__u_ram_0000febb + 0x14)) ||
		                                                (param1_00 ==
		                                                 s_kerned_glyphs_at__u__u_ram_0000febb + 0x15)) ||
		                                               ((param1_00 ==
		                                                 s_kerned_glyphs_at__u__u_ram_0000febb + 0x16 ||
		                                                (param1_00 == &DAT_ram_0000fed2)))) ||
		                                              (param1_00 == &DAT_ram_0000fed3)))))))) ||
		                                       (((param1_00 == &DAT_ram_0000fed4 ||
		                                         (param1_00 == &DAT_ram_0000fed5)) ||
		                                        (param1_00 == &DAT_ram_0000fed6)))) ||
		                                      (((param1_00 == &DAT_ram_0000fed7 ||
		                                        (param1_00 == &DAT_ram_0000fed8)) ||
		                                       (param1_00 == &DAT_ram_0000fed9)))))))) ||
		                                   (((((param1_00 == s_recursing_to_lookup__u_at__u_ram_0000feda ||
		                                       (param1_00 == s_recursing_to_lookup__u_at__u_ram_0000feda + 1
		                                       )) || ((param1_00 ==
		                                               s_recursing_to_lookup__u_at__u_ram_0000feda + 2 ||
		                                              ((param1_00 ==
		                                                s_recursing_to_lookup__u_at__u_ram_0000feda + 3 ||
		                                               (param1_00 ==
		                                                s_recursing_to_lookup__u_at__u_ram_0000feda + 4)))))
		                                      ) || (param1_00 ==
		                                            s_recursing_to_lookup__u_at__u_ram_0000feda + 5)) ||
		                                    ((((param1_00 == s_recursing_to_lookup__u_at__u_ram_0000feda + 6
		                                       || (param1_00 ==
		                                           s_recursing_to_lookup__u_at__u_ram_0000feda + 7)) ||
		                                      (param1_00 == s_recursing_to_lookup__u_at__u_ram_0000feda + 8)
		                                      ) || ((param1_00 ==
		                                             s_recursing_to_lookup__u_at__u_ram_0000feda + 9 ||
		                                            (param1_00 ==
		                                             s_recursing_to_lookup__u_at__u_ram_0000feda + 10)))))))
		                                   ) || ((((param1_00 ==
		                                            s_recursing_to_lookup__u_at__u_ram_0000feda + 0xb ||
		                                           ((param1_00 ==
		                                             s_recursing_to_lookup__u_at__u_ram_0000feda + 0xc ||
		                                            (param1_00 ==
		                                             s_recursing_to_lookup__u_at__u_ram_0000feda + 0xd))))
		                                          || (param1_00 ==
		                                              s_recursing_to_lookup__u_at__u_ram_0000feda + 0xe)) ||
		                                         (((((param1_00 ==
		                                              s_recursing_to_lookup__u_at__u_ram_0000feda + 0xf ||
		                                             (param1_00 ==
		                                              s_recursing_to_lookup__u_at__u_ram_0000feda + 0x10))
		                                            || (param1_00 ==
		                                                s_recursing_to_lookup__u_at__u_ram_0000feda + 0x11))
		                                           || (param1_00 ==
		                                               s_recursing_to_lookup__u_at__u_ram_0000feda + 0x12))
		                                          || (((param1_00 !=
		                                                s_recursing_to_lookup__u_at__u_ram_0000feda + 0x13
		                                               && (param1_00 != (char *)0x20)) &&
		                                              (param1_00 !=
		                                               s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 10))))))
		                                        )))))))))))))))))))))))))))))))))))))) {
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      uVar2 = 0;
		      iVar3 = func_ii_6380(param1_00,0);
		      if (iVar3 == 0) {
		        uVar2 = (uint)((*puVar4 & 0xfffd) != 0x3c);
		      }
		    }
		  }
		  sVar1 = *(short *)(param1 + param2 * 2 + 0x10);
		  return uVar2 & (sVar1 != 0x20 && sVar1 != -0x180);
		}
		*/

			return default(bool);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x00016038 File Offset: 0x00014238
		[Token(Token = "0x60077D8")]
		[Address(RVA = "0xC133", Offset = "0xC133", VA = "0xC133")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
		/* --- GHIDRA: IsFinishingLetter ---
		uint I2_Loc_RTLFixerTool__IsFinishingLetter(int param1,int param2,undefined4 param3)
		
		{
		  short sVar1;
		  ushort uVar2;
		  uint uVar3;
		  int iVar4;
		  uint uVar5;
		  uint uVar6;
		  undefined4 param1_00;
		  int iVar7;
		  undefined4 *puVar8;
		  undefined4 *param2_00;
		  char *param1_01;
		  ushort *puVar9;
		  undefined *param1_02;
		  
		  uVar6 = 0;
		  uVar3 = 0;
		  if (param2 != 0) {
		    iVar4 = param1 + param2 * 2;
		    sVar1 = *(short *)(iVar4 + 0x10);
		    if (((sVar1 != -0x180) && (sVar1 != -0x17f)) &&
		       ((sVar1 == -0x17e ||
		        ((sVar1 != -0x17d &&
		         ((sVar1 == -0x17c ||
		          ((sVar1 != -0x17b &&
		           ((sVar1 == -0x17a ||
		            ((sVar1 != -0x179 &&
		             (((((sVar1 == -0x178 || (sVar1 == -0x177)) || (sVar1 == -0x176)) ||
		               ((sVar1 == -0x175 || (sVar1 == -0x174)))) ||
		              ((sVar1 != -0x173 &&
		               ((((((((sVar1 == -0x172 || (sVar1 == -0x171)) ||
		                     ((sVar1 == -0x170 ||
		                      (((sVar1 == -0x16f || (sVar1 == -0x16e)) || (sVar1 == -0x16d)))))) ||
		                    ((sVar1 == -0x16c || (sVar1 == -0x16b)))) ||
		                   ((sVar1 == -0x16a ||
		                    (((sVar1 == -0x169 || (sVar1 == -0x168)) ||
		                     ((sVar1 == -0x167 ||
		                      (((sVar1 == -0x166 || (sVar1 == -0x165)) || (sVar1 == -0x164)))))))))) ||
		                  (((sVar1 == -0x163 || (sVar1 == -0x162)) || (sVar1 == -0x161)))) ||
		                 (((sVar1 == -0x160 || (sVar1 == -0x15f)) ||
		                  ((sVar1 == -0x15e ||
		                   (((((sVar1 == -0x15d || (sVar1 == -0x15c)) || (sVar1 == -0x15b)) ||
		                     ((sVar1 == -0x15a || (sVar1 == -0x159)))) || (sVar1 == -0x158)))))))) ||
		                ((sVar1 != -0x157 &&
		                 ((sVar1 == -0x156 ||
		                  ((sVar1 != -0x155 &&
		                   ((sVar1 == -0x154 ||
		                    ((sVar1 != -0x153 &&
		                     ((sVar1 == -0x152 ||
		                      ((sVar1 != -0x151 &&
		                       (((((sVar1 == -0x150 || (sVar1 == -0x14f)) ||
		                          (((((sVar1 == -0x14e ||
		                              (((sVar1 == -0x14d || (sVar1 == -0x14c)) || (sVar1 == -0x14b)))) ||
		                             ((((((sVar1 == -0x14a || (sVar1 == -0x149)) || (sVar1 == -0x148)) ||
		                                ((sVar1 == -0x147 || (sVar1 == -0x146)))) ||
		                               ((((sVar1 == -0x145 ||
		                                  (((sVar1 == -0x144 || (sVar1 == -0x143)) || (sVar1 == -0x142))))
		                                 || ((sVar1 == -0x141 || (sVar1 == -0x140)))) || (sVar1 == -0x13f)))
		                               ) || (((sVar1 == -0x13e || (sVar1 == -0x13d)) ||
		                                     ((sVar1 == -0x13c ||
		                                      ((((sVar1 == -0x13b || (sVar1 == -0x13a)) || (sVar1 == -0x139)
		                                        ) || ((sVar1 == -0x138 || (sVar1 == -0x137)))))))))))) ||
		                            (((sVar1 == -0x136 || ((sVar1 == -0x135 || (sVar1 == -0x134)))) ||
		                             ((sVar1 == -0x133 ||
		                              (((sVar1 == -0x132 || (sVar1 == -0x131)) || (sVar1 == -0x130))))))))
		                           || (((((sVar1 == -0x12f || (sVar1 == -0x12e)) || (sVar1 == -0x12d)) ||
		                                ((sVar1 == -300 || (sVar1 == -299)))) ||
		                               (((sVar1 == -0x12a ||
		                                 (((sVar1 == -0x129 || (sVar1 == -0x128)) || (sVar1 == -0x127)))) ||
		                                (((sVar1 == -0x126 || (sVar1 == -0x125)) || (sVar1 == -0x124))))))))
		                          )) || ((((sVar1 == -0x123 || (sVar1 == -0x122)) ||
		                                  ((sVar1 == -0x121 ||
		                                   ((((sVar1 == -0x120 || (sVar1 == -0x11f)) || (sVar1 == -0x11e))
		                                    || ((sVar1 == -0x11d || (sVar1 == -0x11c)))))))) ||
		                                 (sVar1 == -0x11b)))) ||
		                        (((sVar1 == -0x11a || (sVar1 == -0x119)) ||
		                         ((((sVar1 == -0x118 ||
		                            (((sVar1 == -0x117 || (sVar1 == -0x116)) || (sVar1 == -0x115)))) ||
		                           (sVar1 == -0x114)) || ((sVar1 != -0x113 && (sVar1 != -0x476))))))))))))))
		                    )))))))))))))))))))))))))))) {
		      uVar3 = 1;
		    }
		    puVar9 = (ushort *)(iVar4 + 0xe);
		    param1_01 = (char *)(uint)*puVar9;
		    if ((param1_01 != s_try_kerning_glyphs_at__u__u_ram_0000fe81) &&
		       (((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 1 ||
		         ((param1_01 != s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 2 &&
		          (((((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 3 ||
		              (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 4)) ||
		             ((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 5 ||
		              (((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 6 ||
		                (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 7)) ||
		               (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 8)))))) ||
		            (((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 9 ||
		              (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 10)) ||
		             (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xb)))) ||
		           ((param1_01 != s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xc &&
		            (((((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xd ||
		                (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xe)) ||
		               ((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0xf ||
		                ((((((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x10 ||
		                     (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x11)) ||
		                    (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x12)) ||
		                   ((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x13 ||
		                    (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x14)))) ||
		                  (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x15)) ||
		                 ((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x16 ||
		                  (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x17)))))))) ||
		              ((((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x18 ||
		                 (((param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x19 ||
		                   (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x1a)) ||
		                  (param1_01 == s_try_kerning_glyphs_at__u__u_ram_0000fe81 + 0x1b)))) ||
		                (((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d ||
		                  (param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 1)) ||
		                 ((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 2 ||
		                  ((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 3 ||
		                   (param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 4)))))))) ||
		               ((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 5 ||
		                ((((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 6 ||
		                   (param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 7)) ||
		                  (param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 8)) ||
		                 (((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 9 ||
		                   (param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 10)) ||
		                  (param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xb)))))))))) ||
		             ((param1_01 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xc &&
		              ((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xd ||
		               ((param1_01 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xe &&
		                ((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0xf ||
		                 ((param1_01 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x10 &&
		                  ((param1_01 == s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x11 ||
		                   (((param1_01 != s_tried_kerning_glyphs_at__u__u_ram_0000fe9d + 0x12 &&
		                     (param1_01 != s_glProgramUniformMatrix3x4fv_ram_0000fb80 + 10)) &&
		                    (param1_01 != s_recursing_to_lookup__u_at__u_ram_0000feda + 0x13))))))))))))))))
		            )))))))) &&
		        ((1 << ((uint)(param1_01 + -0xfe80) & 0x1f) & 0xa1U) == 0 ||
		         (char *)0x7 < param1_01 + -0xfe80)))) {
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      uVar6 = 0;
		      iVar4 = func_ii_6380(param1_01,0);
		      if (((iVar4 == 0) && (uVar2 = *puVar9, uVar2 != 0x3c)) &&
		         ((uVar2 == 0x3d || ((uVar2 != 0x3e && (uVar2 != 0x20)))))) {
		        uVar6 = (uint)(uVar2 != 0x2a);
		      }
		    }
		  }
		  if (*(int *)(param1 + 0xc) + -1 <= param2) {
		    return 0;
		  }
		  puVar9 = (ushort *)(param2 * 2 + param1 + 0x12);
		  param1_02 = (undefined *)(uint)*puVar9;
		  if (param1_02 == (undefined *)0xd) {
		    return 0;
		  }
		  if (((((((param1_02 != (undefined *)0xe) && (param1_02 != (undefined *)0xf)) &&
		         (param1_02 != (undefined *)0x10)) &&
		        ((param1_02 != (undefined *)0x11 && (param1_02 != (undefined *)0x12)))) &&
		       ((param1_02 != (undefined *)0x13 &&
		        ((param1_02 != (undefined *)0x14 && (param1_02 != (undefined *)0x15)))))) &&
		      ((param1_02 != (undefined *)0x16 &&
		       (((param1_02 != (undefined *)0x17 && (param1_02 != (undefined *)0x18)) &&
		        (param1_02 != (undefined *)0x19)))))) &&
		     ((((param1_02 != (undefined *)0x1a && (param1_02 != (undefined *)0x1b)) &&
		       ((param1_02 != (undefined *)0x1c &&
		        ((param1_02 != (undefined *)0x1d && (param1_02 != (undefined *)0x1e)))))) &&
		      (param1_02 != (undefined *)0x1f)))) {
		    if (param1_02 == (undefined *)0x20) {
		      return 0;
		    }
		    if (param1_02 == &DAT_ram_0000fe80) {
		      return 0;
		    }
		  }
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  iVar4 = System_Char__CheckNumber(param1_02,0);
		  if (iVar4 != 0) {
		    return 0;
		  }
		  uVar2 = *puVar9;
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  iVar4 = System_Char__CheckSymbol((uint)uVar2,0);
		  if (iVar4 != 0) {
		    return 0;
		  }
		  uVar2 = *puVar9;
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  uVar5 = func_ii_6380((uint)uVar2,0);
		  if ((uVar3 & uVar6 & (uVar5 ^ 1)) == 0) {
		    return 0;
		  }
		  uVar2 = *puVar9;
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,DAT_ram_00a66974)
		    ;
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) goto code_r0x80b22d17;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x80b22d17:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x125,(uint)uVar2,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return uVar6 ^ 1;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar4 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar7) {
		    puVar8 = (undefined4 *)import::env::__cxa_begin_catch(param1_00);
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,DAT_ram_00a66938,
		                       *(undefined4 *)*puVar8);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar7 != 0) {
		        import::env::__cxa_end_catch();
		        return 0;
		      }
		      param2_00 = (undefined4 *)unnamed_function_951(4);
		      *param2_00 = *puVar8;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,&DAT_ram_0072c9c8,
		                 0);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x80b22e44;
		    }
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80b22e44:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x00016050 File Offset: 0x00014250
		[Token(Token = "0x60077D9")]
		[Address(RVA = "0xC134", Offset = "0xC134", VA = "0xC134")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077DA")]
		[Address(RVA = "0xC135", Offset = "0xC135", VA = "0xC135")]
		public RTLFixerTool()
		{
		/* --- GHIDRA: .cctor ---
		void I2_Loc_RTLFixerTool___cctor(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54e20 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_LanguageSourceData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e20 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Func_LanguageSourceData__bool__TypeInfo);
		  if (param1 != (int *)0x0) {
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param1,*(undefined4 *)(*param1 + 0xe4),0);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x24) = param1_00;
		    return;
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void I2_Loc_RTLFixerTool___ctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a54e1f == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_RTLFixerTool_TypeInfo);
		    DAT_ram_00a54e1f = '\x01';
		  }
		  **(undefined1 **)(I2_Loc_RTLFixerTool_TypeInfo + 0x5c) = 1;
		  return;
		}
		*/

		}

		// Token: 0x04003EDF RID: 16095
		[Token(Token = "0x4003EDF")]
		[FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		// Token: 0x04003EE0 RID: 16096
		[Token(Token = "0x4003EE0")]
		[FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;
	}
}
