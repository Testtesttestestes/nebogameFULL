using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000952 RID: 2386
	[Token(Token = "0x2000952")]
	public class SkillsInfo : MonoBehaviour
	{
		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B23")]
		public Button CloseButton
		{
			[Token(Token = "0x600387E")]
			[Address(RVA = "0x8828", Offset = "0x8828", VA = "0x8828")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B24")]
		public Dictionaries Dictionaries
		{
			[Token(Token = "0x600387F")]
			[Address(RVA = "0x8829", Offset = "0x8829", VA = "0x8829")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003880")]
			[Address(RVA = "0x882A", Offset = "0x882A", VA = "0x882A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B25")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6003881")]
			[Address(RVA = "0x882B", Offset = "0x882B", VA = "0x882B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003882")]
			[Address(RVA = "0x882C", Offset = "0x882C", VA = "0x882C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x882D", Offset = "0x882D", VA = "0x882D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_Players_SkillsInfo__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  Gameplay_Combat_View_Players_SkillsInfo__OnEnable(param1,param1);
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  if (iVar1 != 0) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)(*(int *)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) + 0x78) != 0),0);
		    Gameplay_Combat_View_Players_CombatUserBalance__Start
		              (*(undefined4 *)(param1 + 0x1c),
		               *(undefined4 *)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) + 0x78),param1);
		  }
		  Gameplay_Combat_View_Players_SkillsInfo__UpdateBalance(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x882E", Offset = "0x882E", VA = "0x882E")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Combat_View_Players_SkillsInfo__OnEnable(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  double param3;
		  undefined4 in_register_20000014;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 param2_00;
		  int iVar7;
		  uint uVar8;
		  uint uVar9;
		  uint uVar10;
		  int iVar11;
		  int iVar12;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a56703 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatSkillItemRenderer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CombatSkillItemRenderer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CombatSkillItemRenderer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_UserSkillsIndexes__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSkillItemRenderer__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSkillItemRenderer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSkillItemRenderer__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSkillItemRenderer__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_SkillsInfo_TypeInfo);
		    DAT_ram_00a56703 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = func_ii_12174(param1,0);
		  if (iVar2 == 0) {
		    return;
		  }
		  iVar2 = **(int **)(param1 + 0x2c);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf8) * 4))
		                    (*(int **)(param1 + 0x2c),
		                     CONCAT44(in_register_20000014,*(undefined4 *)(iVar2 + 0xfc)));
		  uVar8 = *(int *)(*(int *)(param1 + 0x30) + 0xc) - *(int *)(iVar2 + 0xc);
		  if ((int)uVar8 < 0) {
		    if (uVar8 != 0x80000000) {
		      uVar10 = uVar8 ^ 0xffffffff;
		      do {
		        uVar4 = *(undefined4 *)(param1 + 0x10);
		        uVar6 = *(undefined4 *)(param1 + 0x18);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        uVar4 = func_ii_6805(uVar6,uVar4,
		                             Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___);
		        iVar11 = Method_System_Collections_Generic_List_CombatSkillItemRenderer__Add__;
		        iVar12 = *(int *)(param1 + 0x30);
		        *(int *)(iVar12 + 0x10) = *(int *)(iVar12 + 0x10) + 1;
		        uVar9 = *(uint *)(iVar12 + 0xc);
		        if (uVar9 < *(uint *)(*(int *)(iVar12 + 8) + 0xc)) {
		          *(uint *)(iVar12 + 0xc) = uVar9 + 1;
		          *(undefined4 *)(*(int *)(iVar12 + 8) + uVar9 * 4 + 0x10) = uVar4;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar12,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		        }
		        bVar1 = 0 < (int)uVar10;
		        uVar10 = uVar10 - 1;
		      } while (bVar1);
		      goto code_r0x80c6b152;
		    }
		  }
		  else {
		code_r0x80c6b152:
		    if (0 < (int)uVar8) goto code_r0x80c6b270;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x30),
		             Method_System_Collections_Generic_List_CombatSkillItemRenderer__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar12 = import::env::invoke_iii
		                       (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                        Method_System_Collections_Generic_List_Enumerator_CombatSkillItemRenderer__MoveNext__
		                       );
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c6b21a;
		    }
		    if (iVar12 == 0) goto code_r0x80c6b309;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x20d,local_8._4_4_,1,0);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar11 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c6b21a:
		  iVar11 = global_1;
		  iVar12 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar12) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar12 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar12;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		      if (iVar12 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar12);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80c6b270:
		      uVar10 = *(uint *)(*(int *)(param1 + 0x30) + 0xc);
		      if (0 < (int)uVar10) {
		        do {
		          uVar4 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x30),uVar10 - 1,
		                             Method_System_Collections_Generic_List_CombatSkillItemRenderer__get_Item__
		                            );
		          func_ii_6612(uVar4,(uint)((int)uVar8 < 1),0);
		          uVar8 = uVar8 - 1;
		          bVar1 = 1 < uVar10;
		          uVar10 = uVar10 - 1;
		        } while (bVar1);
		      }
		code_r0x80c6b309:
		      iVar11 = *(int *)(iVar2 + 0xc);
		      if (0 < iVar11) {
		        iVar12 = 0;
		        do {
		          uVar4 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x30),iVar12,
		                             Method_System_Collections_Generic_List_CombatSkillItemRenderer__get_Item__
		                            );
		          iVar5 = System_Linq_Enumerable__ToList_object_
		                            (iVar2,iVar12,Method_System_Collections_Generic_List_int__get_Item__);
		          Google_Protobuf_Collections_RepeatedField_ulong___get_Item(uVar4,iVar12,0);
		          uVar6 = System_Collections_Generic_Dictionary_int__object___get_Item
		                            (*(undefined4 *)(param1 + 0x28),iVar5 + 1,0);
		          param2_00 = func_ii_7990(uVar6,0);
		          Core_Extensions_Dict_UserRatingKindDicExt__GetTitle(uVar4,param2_00,0);
		          uVar6 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar6,0);
		          Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId(uVar4,uVar6,0);
		          param3 = NAN;
		          iVar7 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                            (*(undefined4 *)(*(int *)(param1 + 0x2c) + 0x5c),iVar5,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__)
		          ;
		          if (iVar7 != 0) {
		            if (*(int *)(Gameplay_Combat_View_Players_SkillsInfo_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Combat_View_Players_SkillsInfo_TypeInfo);
		            }
		            iVar7 = Core_Data_Skills_SkillData___ctor
		                              (**(undefined4 **)
		                                 (Gameplay_Combat_View_Players_SkillsInfo_TypeInfo + 0x5c),iVar5,
		                               Method_System_Collections_Generic_HashSet_UserSkillsIndexes__Contains__
		                              );
		            if (iVar7 != 0) {
		              iVar7 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                                (*(undefined4 *)(*(int *)(param1 + 0x2c) + 0x5c),iVar5,
		                                 Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__
		                                );
		              param3 = (double)*(longlong *)(iVar7 + 0x10);
		            }
		          }
		          iVar5 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                            (*(undefined4 *)(*(int *)(param1 + 0x2c) + 0x58),iVar5,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          Gameplay_Combat_View_Players_CombatPlayerView__Gameplay_Combat_View_Players_ICombatPLayerView_get_gameObject
		                    (uVar4,*(undefined8 *)(iVar5 + 0x10),param3,param1);
		          iVar12 = iVar12 + 1;
		        } while (iVar12 != iVar11);
		      }
		      if (*(int *)(*(int *)(*(int *)(param1 + 0x2c) + 8) + 0x10) == 1) {
		        Gameplay_Combat_View_Players_SkillsInfo__UpdateInfo(param1,param1);
		      }
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x20e,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
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

		// Token: 0x06003885 RID: 14469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x882F", Offset = "0x882F", VA = "0x882F")]
		public void UpdateInfo()
		{
		/* --- GHIDRA: UpdateInfo ---
		void Gameplay_Combat_View_Players_SkillsInfo__UpdateInfo(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 param1_00;
		  uint uVar11;
		  longlong param2_00;
		  int local_1c;
		  int **local_18;
		  int *local_14;
		  int local_10;
		  int local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a56704 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSkillItemRenderer__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a56704 = '\x01';
		  }
		  local_8 = 0;
		  local_c = 0;
		  local_10 = 0;
		  iVar9 = *(int *)(*(int *)(param1 + 0x2c) + 0x18);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(uVar2,0);
		  local_14 = &local_8;
		  local_1c = 0;
		  local_18 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar10 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80c6b694;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80c6b8d7:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c6b8df;
		    }
		code_r0x80c6b694:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80c6b8d7;
		    if (iVar10 == 0) goto code_r0x80c6b928;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar10 + 200);
		          goto code_r0x80c6b771;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80c6b8b9:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c6b8df;
		    }
		code_r0x80c6b771:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80c6b8b9;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80c6b8df;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c6b8df:
		  iVar10 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_1c = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x80c6b928:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_14;
		      if (piVar5 != (int *)0x0) {
		        iVar10 = *piVar5;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		              puVar6 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80c6b9b8;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80c6b9b8:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,CONCAT44(in_register_20000014,puVar6[1]));
		      }
		      if (local_1c == 0) {
		        if (0 < *(int *)(iVar9 + 0xc)) {
		          iVar10 = 0;
		          do {
		            iVar4 = System_Linq_Enumerable__ToList_object_
		                              (iVar9,iVar10,
		                               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__get_Item__
		                              );
		            uVar2 = *(undefined4 *)(param1 + 0x14);
		            param1_00 = *(undefined4 *)(param1 + 0x18);
		            if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		              func_ii_306000(UnityEngine_Object_TypeInfo);
		            }
		            piVar5 = (int *)func_ii_6805(param1_00,uVar2,
		                                         Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___
		                                        );
		            Google_Protobuf_Collections_RepeatedField_ulong___get_Item(piVar5,iVar10,0);
		            param2_00 = (longlong)iVar4;
		            iVar7 = func_ii_10817(*(undefined4 *)(param1 + 0x28),param2_00,&local_c,0);
		            if (iVar7 != 0) {
		              uVar2 = (undefined4)((ulonglong)param2_00 >> 0x20);
		              piVar8 = (int *)Core_Gameplay_Managers_UserManager__get_User
		                                        (*(undefined4 *)(*(int *)(param1 + 0x2c) + 0x14),0);
		              iVar7 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x100) * 4))
		                                (piVar8,CONCAT44(uVar2,*(undefined4 *)(local_c + 0x18)),&local_10,
		                                 *(undefined4 *)(*piVar8 + 0x104));
		              if (iVar7 != 0) {
		                if (DAT_ram_00a56706 == '\0') {
		                  Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		                  Mono_Security_ASN1__get_Item(&StringLiteral_2563);
		                  Mono_Security_ASN1__get_Item(&StringLiteral_5);
		                  DAT_ram_00a56706 = '\x01';
		                }
		                bVar1 = iVar4 - 3U < 3;
		                uVar2 = StringLiteral_5;
		                if (bVar1) {
		                  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		                    func_ii_306000(Core_GameLocalization_TypeInfo);
		                  }
		                  uVar2 = func_ii_7508(StringLiteral_2563,1,0,1,0,0,0,0);
		                }
		                Core_Extensions_Dict_UserRatingKindDicExt__GetTitle(piVar5,uVar2,0);
		                if (DAT_ram_00a56705 == '\0') {
		                  Mono_Security_ASN1__get_Item(&StringLiteral_2564);
		                  Mono_Security_ASN1__get_Item(&StringLiteral_5);
		                  DAT_ram_00a56705 = '\x01';
		                }
		                uVar2 = StringLiteral_5;
		                if (bVar1) {
		                  uVar2 = Core_Extensions_Dict_DictExt__GetServiceOptionDic
		                                    (*(undefined4 *)(param1 + 0x28),StringLiteral_2564,0);
		                }
		                Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId(piVar5,uVar2,0);
		                uVar2 = Gameplay_Combat_View_Players_SkillsInfo__GetEffectTitle
		                                  (iVar10,*(undefined8 *)(local_10 + 0x10),
		                                   *(undefined4 *)(local_c + 0x1c),iVar10);
		                (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))
		                          (piVar5,uVar2,*(undefined4 *)(*piVar5 + 0xec));
		                iVar4 = Method_System_Collections_Generic_List_CombatSkillItemRenderer__Add__;
		                iVar7 = *(int *)(param1 + 0x30);
		                *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		                uVar11 = *(uint *)(iVar7 + 0xc);
		                if (uVar11 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		                  *(uint *)(iVar7 + 0xc) = uVar11 + 1;
		                  *(int **)(*(int *)(iVar7 + 8) + uVar11 * 4 + 0x10) = piVar5;
		                }
		                else {
		                  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                            (iVar7,piVar5,
		                             *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		                }
		              }
		            }
		            iVar10 = iVar10 + 1;
		          } while (iVar10 < *(int *)(iVar9 + 0xc));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_1c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x20f,&local_1c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		    import::env::__resumeException(uVar2);
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

		// Token: 0x06003886 RID: 14470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x8830", Offset = "0x8830", VA = "0x8830")]
		private void UpdateAntiqInfo()
		{
		/* --- GHIDRA: UpdateAntiqInfo ---
		undefined4
		Gameplay_Combat_View_Players_SkillsInfo__UpdateAntiqInfo(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a56705 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2564);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a56705 = '\x01';
		  }
		  if (param2 - 3U < 3) {
		    uVar1 = Core_Extensions_Dict_DictExt__GetServiceOptionDic
		                      (*(undefined4 *)(param1 + 0x28),StringLiteral_2564,0);
		    return uVar1;
		  }
		  return StringLiteral_5;
		}
		*/

		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x8831", Offset = "0x8831", VA = "0x8831")]
		private string GetEffectResource(Antiq.Types.EffectsDic.Types.EffectID effect)
		{
		/* --- GHIDRA: GetEffectResource ---
		undefined4
		Gameplay_Combat_View_Players_SkillsInfo__GetEffectResource
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a56706 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2563);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a56706 = '\x01';
		  }
		  if (param2 - 3U < 3) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_2563,1,0,1,0,0,0,0);
		    return uVar1;
		  }
		  return StringLiteral_5;
		}
		*/

			return null;
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003888")]
		[Address(RVA = "0x8832", Offset = "0x8832", VA = "0x8832")]
		private string GetEffectTitle(Antiq.Types.EffectsDic.Types.EffectID effect)
		{
		/* --- GHIDRA: GetEffectTitle ---
		undefined4
		Gameplay_Combat_View_Players_SkillsInfo__GetEffectTitle
		          (undefined4 param1,undefined8 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a56707 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28645);
		    DAT_ram_00a56707 = '\x01';
		  }
		  local_8 = param2;
		  if (param3 != 1) {
		    if (param3 == 2) {
		      uVar1 = func_ii_1081(DAT_ram_00a66964,&local_8);
		      uVar1 = func_ii_4419(StringLiteral_28645,uVar1,0);
		      return uVar1;
		    }
		    if (param3 != 3) {
		      return 0;
		    }
		  }
		  uVar1 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_28579,uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003889")]
		[Address(RVA = "0x8833", Offset = "0x8833", VA = "0x8833")]
		private string GetEffectValue(long value, uint valueType)
		{
		/* --- GHIDRA: GetEffectValue ---
		void Gameplay_Combat_View_Players_SkillsInfo__GetEffectValue(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  if (iVar1 != 0) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)(*(int *)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) + 0x78) != 0),0);
		    Gameplay_Combat_View_Players_CombatUserBalance__Start
		              (*(undefined4 *)(param1 + 0x1c),
		               *(undefined4 *)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) + 0x78),param1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388A")]
		[Address(RVA = "0x8834", Offset = "0x8834", VA = "0x8834")]
		public void UpdateBalance()
		{
		/* --- GHIDRA: UpdateBalance ---
		uint Gameplay_Combat_View_Players_SkillsInfo__UpdateBalance(int param1,undefined4 param2)
		
		{
		  uint param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  param2_00 = 0;
		  iVar1 = Core_Extensions_UriExt___c___QueryStringToDictionary_b__0_1
		                    (*(undefined4 *)(*(int *)(param1 + 0x2c) + 0x14),0);
		  if (iVar1 != 0) {
		    param2_00 = (uint)(*(int *)(*(int *)(param1 + 0x2c) + 0x54) !=
		                      *(int *)(*(int *)(*(int *)(param1 + 0x2c) + 8) + 0x14));
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00 ^ 1,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00 ^ 1,0);
		  return param2_00;
		}
		*/

		}

		// Token: 0x0600388B RID: 14475 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x600388B")]
		[Address(RVA = "0x8835", Offset = "0x8835", VA = "0x8835")]
		public bool TryShowLegendStub()
		{
		/* --- GHIDRA: TryShowLegendStub ---
		void Gameplay_Combat_View_Players_SkillsInfo__TryShowLegendStub(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a56708 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSkillItemRenderer___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatSkillItemRenderer__TypeInfo)
		    ;
		    DAT_ram_00a56708 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_CombatSkillItemRenderer__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_CombatSkillItemRenderer___ctor__);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388C")]
		[Address(RVA = "0x8836", Offset = "0x8836", VA = "0x8836")]
		public SkillsInfo()
		{
		/* --- GHIDRA: .cctor ---
		void Gameplay_Combat_View_Players_SkillsInfo___cctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5670a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a5670a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_SkillsInfo___ctor(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a56709 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_UserSkillsIndexes__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_UserSkillsIndexes___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_UserSkillsIndexes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_SkillsInfo_TypeInfo);
		    DAT_ram_00a56709 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_HashSet_UserSkillsIndexes__TypeInfo);
		  System_Collections_Generic_HashSet_int___get_Count
		            (param1_00,Method_System_Collections_Generic_HashSet_UserSkillsIndexes___ctor__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (param1_00,9,Method_System_Collections_Generic_HashSet_UserSkillsIndexes__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (param1_00,10,Method_System_Collections_Generic_HashSet_UserSkillsIndexes__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (param1_00,0xb,Method_System_Collections_Generic_HashSet_UserSkillsIndexes__Add__);
		  **(undefined4 **)(Gameplay_Combat_View_Players_SkillsInfo_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04001F3E RID: 7998
		[Token(Token = "0x4001F3E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _content;

		// Token: 0x04001F3F RID: 7999
		[Token(Token = "0x4001F3F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _antiqContent;

		// Token: 0x04001F40 RID: 8000
		[Token(Token = "0x4001F40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CombatSkillItemRenderer _skillPrefab;

		// Token: 0x04001F41 RID: 8001
		[Token(Token = "0x4001F41")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CombatUserBalance _balance;

		// Token: 0x04001F42 RID: 8002
		[Token(Token = "0x4001F42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeButton;

		// Token: 0x04001F43 RID: 8003
		[Token(Token = "0x4001F43")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _legendaryUserStub;

		// Token: 0x04001F44 RID: 8004
		[Token(Token = "0x4001F44")]
		[FieldOffset(Offset = "0x0")]
		public static HashSet<UserSkillsIndexes> RelativeSkillIndexes;

		// Token: 0x04001F47 RID: 8007
		[Token(Token = "0x4001F47")]
		[FieldOffset(Offset = "0x30")]
		private List<CombatSkillItemRenderer> _currentItems;
	}
}
