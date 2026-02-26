using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Ad.Placements.Base.Model;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model
{
	// Token: 0x02001218 RID: 4632
	[Token(Token = "0x2001218")]
	public class BattleBonusesAdModel : AbstractAdPlacementModel
	{
		// Token: 0x06006DC3 RID: 28099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC3")]
		[Address(RVA = "0xB883", Offset = "0xB883", VA = "0xB883")]
		public BattleBonusesAdModel(UserData user, IAdPlacementData placementData, IDictProvider dictionaries, MedalsManager medalsManager, IRequirementValidator requirementsValidator)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  int param2_00;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a7a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_BattleBonusMedal__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BattleBonusMedal__GetEnumerator__);
		    DAT_ram_00a5a7a3 = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x14);
		  iVar6 = *(int *)(iVar5 + 0xc);
		  *(undefined4 *)(iVar5 + 0xc) = 0;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  if (0 < iVar6) {
		    func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar6,0);
		  }
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar7;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8126c3e2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8126c3e2:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar5 + 0x2cc),
		                              Method_Google_Protobuf_Collections_RepeatedField_BattleBonusMedal__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar5 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8126c4c6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8126c71f:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126c727;
		    }
		code_r0x8126c4c6:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8126c71f;
		    if (iVar5 == 0) goto code_r0x8126c770;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_BattleBonusMedal__TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar5 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8126c5a3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_BattleBonusMedal__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8126c701:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126c727;
		    }
		code_r0x8126c5a3:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8126c701;
		    param2_00 = *(int *)(param1 + 0x14);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x14) + 0x20),
		                       *(undefined4 *)(iVar5 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    iVar6 = Method_System_Collections_Generic_List_MedalData__Add__;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8126c70b:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126c727;
		    }
		    *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		    uVar1 = *(uint *)(param2_00 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		      *(uint *)(param2_00 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(param2_00 + 8) + uVar1 * 4 + 0x10) = uVar4;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_00,uVar4,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8126c70b;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3bf,
		               *(undefined4 *)(param1 + 0x10),*(undefined4 *)(iVar5 + 0xc),
		               Method_System_Collections_Generic_HashSet_uint__Add__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar5 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8126c727:
		  iVar5 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_c = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x8126c770:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_8;
		      if (piVar7 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *piVar7;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8126c7eb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x8126c7eb:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x33a,&local_c);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
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
		*/

		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC4")]
		[Address(RVA = "0xB884", Offset = "0xB884", VA = "0xB884")]
		private void InitBonusMedals()
		{
		/* --- GHIDRA: InitBonusMedals ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel__InitBonusMedals
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a7a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__GetEnumerator__)
		    ;
		    DAT_ram_00a5a7a4 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_List_MedalData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126cbbb;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    uVar4 = local_8._4_4_;
		    piVar5 = *(int **)(param1 + 0x18);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0xd0);
		          goto code_r0x8126ca8d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8126ca8d:
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_0000223f,uVar4,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126cbbb;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 1,param2_00,
		                       *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xc),0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126cbbb;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 2,param1,
		                       *(undefined4 *)(iVar2 + 0x10),*(undefined4 *)(param1 + 8),
		                       *(undefined4 *)(param1 + 8));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126cbbb;
		    }
		    if (iVar2 != 0) {
		      DAT_ram_009d3e38 = 0;
		      return uVar4;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8126cbbb:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar2 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return 0;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 3,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar4);
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

		// Token: 0x06006DC5 RID: 28101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC5")]
		[Address(RVA = "0xB885", Offset = "0xB885", VA = "0xB885")]
		public MedalData GetAppropriateBonus()
		{
		/* --- GHIDRA: GetAppropriateBonus ---
		int Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel__GetAppropriateBonus
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a7a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalData__TypeInfo);
		    DAT_ram_00a5a7a5 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_MedalData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_MedalData___ctor__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_List_MedalData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126d5ce;
		    }
		    iVar7 = local_18;
		    if (iVar2 == 0) goto code_r0x8126d617;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = local_8._4_4_;
		    iVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_0000223f,local_8._4_4_,0)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x89,uVar4,
		                       *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x20),0);
		    iVar2 = DAT_ram_009d3e38;
		    iVar7 = Method_System_Collections_Generic_List_MedalData__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8126d5ce;
		    }
		    if (iVar3 != 0) {
		      *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar1 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		        *(uint *)(iVar1 + 0xc) = uVar6 + 1;
		        *(undefined4 *)(*(int *)(iVar1 + 8) + uVar6 * 4 + 0x10) = uVar4;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8126d5ce:
		          iVar7 = global_1;
		          iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar7 == iVar2) {
		            piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		            iVar7 = *piVar5;
		            DAT_ram_009d3e38 = 0;
		            local_18 = iVar7;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		code_r0x8126d617:
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 0) {
		                return iVar1;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 6,&local_18);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
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
		      }
		    }
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x8126d5ce;
		}
		*/

			return null;
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC6")]
		[Address(RVA = "0xB886", Offset = "0xB886", VA = "0xB886")]
		public List<MedalData> GetAchievedBonuses()
		{
			return null;
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0x2241", Offset = "0x2241", VA = "0x2241")]
		private bool CheckRestrictionsProxy(IList<RestrictionInfo> restrictionsInfo, UserData user)
		{
		/* --- GHIDRA: CheckRestrictionsProxy ---
		int * Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel__CheckRestrictionsProxy
		                (int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x04003971 RID: 14705
		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x10")]
		public HashSet<uint> BonusMedalIds;

		// Token: 0x04003972 RID: 14706
		[Token(Token = "0x4003972")]
		[FieldOffset(Offset = "0x14")]
		private List<MedalData> _bonusMedals;

		// Token: 0x04003973 RID: 14707
		[Token(Token = "0x4003973")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDictProvider _dictionaries;

		// Token: 0x04003974 RID: 14708
		[Token(Token = "0x4003974")]
		[FieldOffset(Offset = "0x1C")]
		private readonly MedalsManager _medalsManager;

		// Token: 0x04003975 RID: 14709
		[Token(Token = "0x4003975")]
		[FieldOffset(Offset = "0x20")]
		private readonly IRequirementValidator _requirementsValidator;
	}
}
