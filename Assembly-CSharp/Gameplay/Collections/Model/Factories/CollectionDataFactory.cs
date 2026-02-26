using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Collections.Model.Factories
{
	// Token: 0x020009E2 RID: 2530
	[Token(Token = "0x20009E2")]
	public class CollectionDataFactory : ICollectionDataFactory, IDisposable
	{
		// Token: 0x06003C73 RID: 15475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x8B3C", Offset = "0x8B3C", VA = "0x8B3C", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Collections_Model_Factories_CollectionDataFactory__Dispose
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a57ecb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11321);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11322);
		    DAT_ram_00a57ecb = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic____ctor__)
		  ;
		  *(undefined4 *)(param1 + 8) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic____ctor__
		            );
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  *(int **)(param1 + 0x18) = param2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e73de2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e73de2:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar2,StringLiteral_11321,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e73e78;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e73e78:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar2,StringLiteral_11322,0);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  Gameplay_Collections_Model_Factories_CollectionDataFactory___ctor(param1,puVar3);
		  Gameplay_Collections_Model_Factories_CollectionDataFactory__PopulateCollectionRanks(param1,puVar3)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x8B3D", Offset = "0x8B3D", VA = "0x8B3D")]
		public CollectionDataFactory(IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_Model_Factories_CollectionDataFactory___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 param2_01;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57ecc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_CollectionRanksDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CollectionRanksDic__GetEnumerator__
		              );
		    DAT_ram_00a57ecc = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 0x18);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x80e746b2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e746b2:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar8 + 0x128),
		                              Method_Google_Protobuf_Collections_RepeatedField_CollectionRanksDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e74796;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e74a62:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e74a6a;
		    }
		code_r0x80e74796:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e74a62;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80e74ab3;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_CollectionRanksDic__TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e74876;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_CollectionRanksDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e749b1:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e74a6a;
		    }
		code_r0x80e74876:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e749b1;
		    uVar5 = *(undefined4 *)(iVar8 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                       *(undefined4 *)(param1 + 0xc),uVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___ContainsKey__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e74a6a;
		    }
		    if (iVar4 == 0) {
		      param2_01 = *(undefined4 *)(param1 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TypeInfo
		                            );
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x225,param2_00,
		                   Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,param2_01,uVar5,
		                     param2_00,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___set_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e749c5;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e74a6a;
		    }
		code_r0x80e749c5:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(param1 + 0xc),uVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___get_Item__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e74a6a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar5,
		               *(undefined4 *)(iVar8 + 0x10),iVar8,
		               Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__set_Item__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e74a6a:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar8 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80e74ab3:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e74b2b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e74b2b:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc2,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x8B3E", Offset = "0x8B3E", VA = "0x8B3E")]
		private void PopulateCollectionRanks()
		{
		/* --- GHIDRA: PopulateCollectionRanks ---
		void Gameplay_Collections_Model_Factories_CollectionDataFactory__PopulateCollectionRanks
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 *puVar9;
		  undefined4 param2_00;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57ecd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDic__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__MedalDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_MedalDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Model_Factories_CollectionDataFactory___c__PopulateMedals_b__8_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo);
		    DAT_ram_00a57ecd = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar6 = *(int **)(param1 + 0x18);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x80e74ca7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e74ca7:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x70);
		  if (*(int *)(Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo);
		  }
		  puVar9 = *(undefined4 **)
		            (Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo + 0x5c);
		  iVar7 = puVar9[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo + 0x74) ==
		        0) {
		      func_ii_306000(Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo);
		      puVar9 = *(undefined4 **)
		                (Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar9;
		    iVar7 = unnamed_function_1417(System_Func_MedalDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar7,uVar4,
		               Method_Gameplay_Collections_Model_Factories_CollectionDataFactory___c__PopulateMedals_b__8_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo + 0x5c
		                     ) + 4) = iVar7;
		  }
		  uVar1 = 0;
		  piVar6 = (int *)System_Linq_Enumerable__Where_PlayerLoopSystem_
		                            (uVar8,iVar7,Method_System_Linq_Enumerable_Where_MedalDic___);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_MedalDic__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e74dbe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_IEnumerable_MedalDic__TypeInfo,0);
		code_r0x80e74dbe:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar9 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e74e8c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar9 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e75158:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e75160;
		    }
		code_r0x80e74e8c:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar9,piVar6,puVar9[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e75158;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x80e751a9;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_MedalDic__TypeInfo == *piVar10) {
		          puVar9 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e74f6c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar9 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MedalDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e750a7:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e75160;
		    }
		code_r0x80e74f6c:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar9,piVar6,puVar9[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e750a7;
		    uVar8 = *(undefined4 *)(iVar7 + 0x34);
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                       *(undefined4 *)(param1 + 8),uVar8,
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___ContainsKey__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e75160;
		    }
		    if (iVar3 == 0) {
		      param2_00 = *(undefined4 *)(param1 + 8);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_Dictionary_uint__MedalDic__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x225,uVar4,
		                   Method_System_Collections_Generic_Dictionary_uint__MedalDic___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,param2_00,uVar8,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___set_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e750bb;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e75160;
		    }
		code_r0x80e750bb:
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(param1 + 8),uVar8,
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___get_Item__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e75160;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar8,
		               *(undefined4 *)(iVar7 + 0x38),iVar7,
		               Method_System_Collections_Generic_Dictionary_uint__MedalDic__set_Item__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e75160:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar8);
		    iVar7 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80e751a9:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e75221;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e75221:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar8 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc3,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar8);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x8B3F", Offset = "0x8B3F", VA = "0x8B3F")]
		private void PopulateMedals()
		{
		/* --- GHIDRA: PopulateMedals ---
		void Gameplay_Collections_Model_Factories_CollectionDataFactory__PopulateMedals(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ecf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo);
		    DAT_ram_00a57ecf = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Collections_Model_Factories_CollectionDataFactory___c_TypeInfo + 0x5c)
		       = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x1AA2", Offset = "0x1AA2", VA = "0x1AA2", Slot = "4")]
		public CollectionData Create(CollectionsDic collectionsDict)
		{
		/* --- GHIDRA: Create ---
		undefined4
		Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		          (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 uVar1;
		  
		  if (*(int *)(param4 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12521);
		    if (*(int *)(param4 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		    }
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_12521,param2,0);
		  uVar1 = UnityEngine_Resources__GetBuiltinResource_object_(uVar1,**(undefined4 **)(param4 + 0x1c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_6805(uVar1,param3,*(undefined4 *)(*(int *)(param4 + 0x1c) + 8));
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0400216F RID: 8559
		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<uint, Dictionary<uint, MedalDic>> _medals;

		// Token: 0x04002170 RID: 8560
		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<uint, Dictionary<uint, CollectionRanksDic>> _ranks;

		// Token: 0x04002171 RID: 8561
		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _nonCollectionAvatarAssetId;

		// Token: 0x04002172 RID: 8562
		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x14")]
		private readonly string _nonCollectionMedalAssetId;

		// Token: 0x04002173 RID: 8563
		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x18")]
		private IDictProvider _dictProvider;
	}
}
