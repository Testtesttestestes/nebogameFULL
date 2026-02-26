using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Auchan;
using Protocol.Dic;

namespace Gameplay.Auchan.Model
{
	// Token: 0x02000C94 RID: 3220
	[Token(Token = "0x2000C94")]
	public class AuchanModel : AbstractModel
	{
		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06004E6F RID: 20079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FE5")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6004E6F")]
			[Address(RVA = "0x9CA0", Offset = "0x9CA0", VA = "0x9CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E70")]
		[Address(RVA = "0x9CA1", Offset = "0x9CA1", VA = "0x9CA1")]
		public AuchanModel(UserData user, IGame game, IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x8107c804) */
		
		uint Gameplay_Auchan_Model_AuchanModel___ctor
		               (int param1,longlong param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  longlong lVar6;
		  int iVar7;
		  int local_38;
		  undefined1 *local_34;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a59870 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__List_AuchanArtifactData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__List_AuchanArtifactData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__List_AuchanArtifactData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__List_AuchanArtifactData___GetEnumerator__
		              );
		    DAT_ram_00a59870 = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  *param3 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_30,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__List_AuchanArtifactData___GetEnumerator__
		            );
		  local_8 = local_28;
		  local_38 = 0;
		  local_34 = local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__List_AuchanArtifactData___MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar4 = global_1;
		      goto code_r0x8107c8c1;
		    }
		    if (iVar3 == 0) break;
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_30,local_8._4_4_,
		               Method_System_Collections_Generic_List_AuchanArtifactData__GetEnumerator__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar4 = global_1;
		code_r0x8107c8c1:
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar7 = *piVar5;
		        iVar4 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_38 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		          if (iVar7 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x8107c919:
		          DAT_ram_009d3e38 = 0;
		          return iVar4 == 6 & uVar1;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x14,&local_38);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8107c960:
		      DAT_ram_009d3e38 = 0;
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    local_18 = local_28;
		    local_20 = CONCAT44(puStack_2c,local_30);
		    local_30 = 0;
		    puStack_2c = &local_20;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                         Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__MoveNext__
		                        );
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8107c782:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar4 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar4 == iVar3) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar3 = *piVar5;
		          iVar4 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_30 = iVar3;
		          import::env::invoke_v(0x123);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 != 1) goto code_r0x8107c7d8;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar4 = global_1;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x13,&local_30);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) goto code_r0x8107c8c1;
		        goto code_r0x8107c960;
		      }
		      iVar3 = 0;
		      if (iVar4 == 0) {
		        iVar4 = 2;
		        goto code_r0x8107c7d8;
		      }
		      iVar4 = local_18._4_4_;
		      DAT_ram_009d3e38 = 0;
		      lVar6 = unnamed_function_184054
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x12,
		                         *(undefined4 *)(local_18._4_4_ + 0x1c),0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8107c782;
		    } while (param2 != lVar6);
		    *param3 = iVar4;
		    uVar1 = 1;
		    iVar4 = 6;
		code_r0x8107c7d8:
		    if (iVar3 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar3);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar4 = global_1;
		      goto code_r0x8107c8c1;
		    }
		    if ((iVar4 != 0) && ((iVar4 == 1 || (iVar4 != 2)))) goto code_r0x8107c919;
		  }
		  iVar4 = 7;
		  goto code_r0x8107c919;
		}
		*/

		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x6004E71")]
		[Address(RVA = "0x9CA2", Offset = "0x9CA2", VA = "0x9CA2")]
		public bool TryGetAuchanArtifact(ulong artId, out AuchanArtifactData artifact)
		{
		/* --- GHIDRA: TryGetAuchanArtifact ---
		int Gameplay_Auchan_Model_AuchanModel__TryGetAuchanArtifact(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  int iVar9;
		  undefined4 *puVar10;
		  int *piVar11;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59871 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_InventoryMetaFilterData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_InventoryMetaFilterData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtikulTypeMetaFilterDic__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtikulTypeMetaFilterDic__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtikulTypeMetaFilterDic__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_InventoryMetaFilterData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_InventoryMetaFilterData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_InventoryMetaFilterData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_InventoryMetaFilterData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Model_AuchanModel___c__GetAllArtikulTypeFilters_b__9_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		    DAT_ram_00a59871 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    return *(int *)(param1 + 0x18);
		  }
		  if (DAT_ram_00a5986e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5986e = '\x01';
		  }
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x8107cac4;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8107cac4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetString(uVar3,0x20,0);
		  iVar7 = unnamed_function_1417(System_Collections_Generic_List_InventoryMetaFilterData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar7,Method_System_Collections_Generic_List_InventoryMetaFilterData___ctor__);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_InventoryMetaFilterData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_InventoryMetaFilterData___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar3,
		             Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		code_r0x8107cb56:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ArtikulTypeMetaFilterDic__MoveNext__
		                      );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8107cd97;
		    }
		    if (iVar5 == 0) {
		      iVar5 = 5;
		      iVar9 = local_20;
		      goto code_r0x8107cde4;
		    }
		    uVar3 = local_8._4_4_;
		    if (DAT_ram_00a5986e == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Dict_IDictProvider_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a5986e = '\x01';
		        goto code_r0x8107cbdf;
		      }
		code_r0x8107cd7b:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8107cd97;
		    }
		code_r0x8107cbdf:
		    piVar6 = *(int **)(param1 + 0x1c);
		    iVar9 = *piVar6;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar11) {
		          puVar10 = (undefined4 *)(piVar11[1] * 8 + iVar9 + 0xd0);
		          goto code_r0x8107cc78;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar10 = (undefined4 *)
		              import::env::invoke_iiii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                         Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107cd7b;
		code_r0x8107cc78:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar10,piVar6,puVar10[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107cd7b;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x15,uVar3,uVar4,0);
		    iVar9 = Method_System_Collections_Generic_List_InventoryMetaFilterData__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107cd85;
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar7 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar3;
		      goto code_r0x8107cb56;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,uVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8107cd85:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8107cd97:
		      iVar9 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar5) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar9 = *piVar6;
		        iVar5 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x8107cde4:
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar5 != 0) {
		            if (iVar5 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar5 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar5 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar5 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar5 != 5) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		          }
		          if (*(int *)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		          }
		          puVar10 = *(undefined4 **)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c);
		          iVar9 = puVar10[1];
		          if (iVar9 == 0) {
		            if (*(int *)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		              puVar10 = *(undefined4 **)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c);
		            }
		            uVar3 = *puVar10;
		            iVar9 = unnamed_function_1417(System_Func_InventoryMetaFilterData__uint__TypeInfo);
		            System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                      (iVar9,uVar3,
		                       Method_Gameplay_Auchan_Model_AuchanModel___c__GetAllArtikulTypeFilters_b__9_0__
		                       ,0);
		            *(int *)(*(int *)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c) + 4) = iVar9;
		          }
		          uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (iVar7,iVar9,
		                             Method_System_Linq_Enumerable_OrderBy_InventoryMetaFilterData__uint___)
		          ;
		          uVar3 = System_Linq_Enumerable__Select_object__object_
		                            (uVar3,Method_System_Linq_Enumerable_ToList_InventoryMetaFilterData___);
		          *(undefined4 *)(param1 + 0x18) = uVar3;
		          return uVar3;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x16,&local_20);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        import::env::__resumeException(uVar3);
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
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E72")]
		[Address(RVA = "0x9CA3", Offset = "0x9CA3", VA = "0x9CA3")]
		public List<InventoryMetaFilterData> GetAllArtikulTypeFilters()
		{
		/* --- GHIDRA: GetAllArtikulTypeFilters ---
		/* WARNING: Removing unreachable block (ram,0x8107d910) */
		
		void Gameplay_Auchan_Model_AuchanModel__GetAllArtikulTypeFilters
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  undefined4 uVar11;
		  int *piVar12;
		  int iVar13;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  int local_20;
		  int **local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a59872 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__string__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_KeyValuePair_uint__List_AuchanArtifactData____uint___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_uint__List_AuchanArtifactData____uint__List_AuchanArtifactData____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_KeyValuePair_uint__List_AuchanArtifactData____uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_KeyValuePair_uint__List_AuchanArtifactData____List_AuchanArtifactData___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_AuchanItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_AuchanItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AuchanArtifactData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_InventoryMetaFilterData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Model_AuchanModel___c__PopulateDictionaries_b__10_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Model_AuchanModel___c__PopulateDictionaries_b__10_2__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Model_AuchanModel___c__DisplayClass10_0__PopulateDictionaries_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanModel___c__DisplayClass10_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		    DAT_ram_00a59872 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar2 = unnamed_function_1417(Gameplay_Auchan_Model_AuchanModel___c__DisplayClass10_0_TypeInfo);
		  uVar3 = Gameplay_Auchan_Model_AuchanModel__TryGetAuchanArtifact(param1,0);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  iVar13 = *param2;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_AuchanItem__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107d0f1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_AuchanItem__TypeInfo,0
		                               );
		code_r0x8107d0f1:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		  local_20 = 0;
		  local_1c = &local_4;
		  do {
		    piVar10 = local_4;
		    iVar13 = *local_4;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		          puVar6 = (undefined4 *)(iVar13 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x8107d1c6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8107d9ae:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      goto code_r0x8107d9e5;
		    }
		code_r0x8107d1c6:
		    DAT_ram_009d3e38 = 0;
		    iVar13 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		    piVar10 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107d9ae;
		    if (iVar13 == 0) {
		      iVar13 = 7;
		      goto code_r0x8107da30;
		    }
		    iVar13 = *local_4;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_AuchanItem__TypeInfo == *piVar12) {
		          puVar6 = (undefined4 *)(iVar13 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x8107d2a0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_AuchanItem__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8107d9d6:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      goto code_r0x8107d9e5;
		    }
		code_r0x8107d2a0:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107d9d6;
		    piVar10 = *(int **)(param1 + 0x14);
		    iVar13 = *piVar10;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		          puVar6 = (undefined4 *)(piVar12[1] * 8 + iVar13 + 0x158);
		          goto code_r0x8107d376;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                        Core_Gameplay_IGame_TypeInfo,0x13);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8107d9cc:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      goto code_r0x8107d9e5;
		    }
		code_r0x8107d376:
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107d9cc;
		    uVar11 = *(undefined4 *)(param1 + 8);
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		    iVar13 = DAT_ram_009d3e38;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8107d9c2:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      goto code_r0x8107d9e5;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x17,iVar9,uVar4,uVar7,uVar11,
		               iVar13);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107d9c2;
		    uVar4 = *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x1c) + 0xc) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_30,uVar3,
		               Method_System_Collections_Generic_List_InventoryMetaFilterData__GetEnumerator__);
		    iVar13 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar13 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      goto code_r0x8107d9e5;
		    }
		    local_10 = local_28;
		    local_18 = CONCAT44(puStack_2c,local_30);
		    local_30 = 0;
		    puStack_2c = &local_18;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar13 = import::env::invoke_iii
		                         (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                          Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__MoveNext__
		                         );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8107d88c;
		      if (iVar13 == 0) goto code_r0x8107d8de;
		      iVar13 = local_10._4_4_;
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                         *(undefined4 *)(local_10._4_4_ + 0x14),uVar4,
		                         Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__ContainsKey__
		                        );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8107d88c;
		    } while (iVar8 == 0);
		    uVar7 = *(undefined4 *)(param1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                      (iVar13,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8107d88c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar13 == iVar9) {
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_30 = *piVar10;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 != 1) goto code_r0x8107d8de;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x1a,&local_30);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) goto code_r0x8107d9e5;
		      goto code_r0x8107dc65;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,uVar7,uVar4,
		                       Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___ContainsKey__
		                      );
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107d88c;
		    if (iVar8 == 0) {
		      uVar7 = *(undefined4 *)(param1 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                        (iVar13,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_ii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                            System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar11,
		                     Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,uVar7,uVar4,uVar11,
		                       Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___Add__
		                      );
		            if (DAT_ram_009d3e38 != 1) {
		              uVar7 = *(undefined4 *)(param1 + 0x10);
		              DAT_ram_009d3e38 = 0;
		              uVar4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                                (iVar13,0);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar11 = import::env::invoke_iii
		                                   (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x19,iVar13,0)
		                ;
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar7,uVar4,
		                             uVar11,
		                             Method_System_Collections_Generic_Dictionary_uint__string__set_Item__);
		                  if (DAT_ram_009d3e38 != 1) {
		                    uVar7 = *(undefined4 *)(iVar2 + 8);
		                    DAT_ram_009d3e38 = 0;
		                    uVar4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                                      (iVar13,0);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      uVar11 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(iVar13,0);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_viiii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd0,uVar7,
		                                   uVar4,uVar11,
		                                   Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__
		                                  );
		                        if (DAT_ram_009d3e38 != 1) goto code_r0x8107d79c;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		      goto code_r0x8107d88c;
		    }
		code_r0x8107d79c:
		    uVar7 = *(undefined4 *)(param1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                      (iVar13,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107d88c;
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar7,uVar4,
		                       Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Item__
		                      );
		    iVar13 = Method_System_Collections_Generic_List_AuchanArtifactData__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8107d88c;
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar8 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		      *(uint *)(iVar8 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar8 + 8) + uVar1 * 4 + 0x10) = iVar9;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,iVar9,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar13 + 0x10) + 0x60) + 0x38));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8107d88c;
		    }
		code_r0x8107d8de:
		  } while (local_30 == 0);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_30);
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 != 1) {
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar13 = global_1;
		code_r0x8107d9e5:
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar13) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_20 = *piVar10;
		    iVar13 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x8107da30:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = *local_1c;
		      if (piVar10 != (int *)0x0) {
		        uVar1 = 0;
		        iVar9 = *piVar10;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8107daab;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x8107daab:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		      }
		      if (local_20 == 0) {
		        if ((iVar13 == 0) ||
		           ((((iVar13 != 1 && (iVar13 != 2)) && (iVar13 != 3)) &&
		            (((iVar13 != 4 && (iVar13 != 5)) && ((iVar13 != 6 && (iVar13 == 7)))))))) {
		          uVar4 = *(undefined4 *)(param1 + 0xc);
		          uVar3 = unnamed_function_1417
		                            (
		                            System_Func_KeyValuePair_uint__List_AuchanArtifactData____uint__TypeInfo
		                            );
		          System_Func_KeyValuePair_uint__object___float___Invoke
		                    (uVar3,iVar2,
		                     Method_Gameplay_Auchan_Model_AuchanModel___c__DisplayClass10_0__PopulateDictionaries_b__0__
		                     ,0);
		          uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (uVar4,uVar3,
		                             Method_System_Linq_Enumerable_OrderBy_KeyValuePair_uint__List_AuchanArtifactData____uint___
		                            );
		          if (*(int *)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		          }
		          puVar6 = *(undefined4 **)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c);
		          iVar13 = puVar6[2];
		          iVar2 = Gameplay_Auchan_Model_AuchanModel___c_TypeInfo;
		          if (iVar13 == 0) {
		            if (*(int *)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		              puVar6 = *(undefined4 **)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c);
		            }
		            uVar4 = *puVar6;
		            iVar13 = unnamed_function_1417
		                               (
		                               System_Func_KeyValuePair_uint__List_AuchanArtifactData____uint__TypeInfo
		                               );
		            System_Func_KeyValuePair_uint__object___float___Invoke
		                      (iVar13,uVar4,
		                       Method_Gameplay_Auchan_Model_AuchanModel___c__PopulateDictionaries_b__10_1__,
		                       0);
		            iVar2 = Gameplay_Auchan_Model_AuchanModel___c_TypeInfo;
		            *(int *)(*(int *)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c) + 8) = iVar13;
		          }
		          if (*(int *)(iVar2 + 0x74) == 0) {
		            func_ii_306000(iVar2);
		            iVar2 = Gameplay_Auchan_Model_AuchanModel___c_TypeInfo;
		          }
		          puVar6 = *(undefined4 **)(iVar2 + 0x5c);
		          iVar9 = puVar6[3];
		          if (iVar9 == 0) {
		            if (*(int *)(iVar2 + 0x74) == 0) {
		              func_ii_306000(iVar2);
		              puVar6 = *(undefined4 **)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c);
		            }
		            uVar4 = *puVar6;
		            iVar9 = unnamed_function_1417
		                              (
		                              System_Func_KeyValuePair_uint__List_AuchanArtifactData____List_AuchanArtifactData___TypeInfo
		                              );
		            System_Func_KeyValuePair_uint__object___bool___Invoke
		                      (iVar9,uVar4,
		                       Method_Gameplay_Auchan_Model_AuchanModel___c__PopulateDictionaries_b__10_2__,
		                       0);
		            *(int *)(*(int *)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c) + 0xc) = iVar9;
		          }
		          uVar3 = System_Linq_Enumerable__ToDictionary_KeyValuePair_Int32Enum__Int32Enum___Int32Enum__Int32Enum_
		                            (uVar3,iVar13,iVar9,
		                             Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_uint__List_AuchanArtifactData____uint__List_AuchanArtifactData____
		                            );
		          *(undefined4 *)(param1 + 0xc) = uVar3;
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_20);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x1b,&local_20);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x8107dc65:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E73")]
		[Address(RVA = "0x9CA4", Offset = "0x9CA4", VA = "0x9CA4")]
		public void PopulateDictionaries(IEnumerable<AuchanItem> items)
		{
		/* --- GHIDRA: PopulateDictionaries ---
		void Gameplay_Auchan_Model_AuchanModel__PopulateDictionaries(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58948 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		    DAT_ram_00a58948 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Auchan_Model_AuchanModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<uint, List<AuchanArtifactData>> ArtifactsByFilterID;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, string> CategoryNamesByFilterID;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x14")]
		public readonly IGame Game;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x18")]
		private List<InventoryMetaFilterData> _artikulTypeFiltersCache;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IDictProvider _dictProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Dict ---
		void Gameplay_Auchan_Model_AuchanModel__get_Dict
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5986f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___TypeInfo);
		    DAT_ram_00a5986f = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData____ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__string__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__string___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  return;
		}
		*/

}
