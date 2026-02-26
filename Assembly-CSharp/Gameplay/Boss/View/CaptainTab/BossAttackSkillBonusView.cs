using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	public class BossAttackSkillBonusView : MonoBehaviour
	{
		// Token: 0x06004757 RID: 18263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004757")]
		[Address(RVA = "0x95EB", Offset = "0x95EB", VA = "0x95EB")]
		private void Awake()
		{
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E38")]
		public Skills Skills
		{
			[Token(Token = "0x6004758")]
			[Address(RVA = "0x95EC", Offset = "0x95EC", VA = "0x95EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004759")]
			[Address(RVA = "0x95ED", Offset = "0x95ED", VA = "0x95ED")]
			set
			{
			}
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600475A")]
		[Address(RVA = "0x95EE", Offset = "0x95EE", VA = "0x95EE")]
		public BossAttackSkillBonusView()
		{
		}

		// Token: 0x04002723 RID: 10019
		[Token(Token = "0x4002723")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002724 RID: 10020
		[Token(Token = "0x4002724")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SkillIconValue _skillIconValuePrefab;

		// Token: 0x04002725 RID: 10021
		[Token(Token = "0x4002725")]
		[FieldOffset(Offset = "0x18")]
		private GameObjectPool<SkillIconValue> _pool;

		// Token: 0x04002726 RID: 10022
		[Token(Token = "0x4002726")]
		[FieldOffset(Offset = "0x1C")]
		private List<SkillIconValue> _currentViews;

		// Token: 0x04002727 RID: 10023
		[Token(Token = "0x4002727")]
		[FieldOffset(Offset = "0x20")]
		private Skills _skills;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Skills ---
		void Gameplay_Boss_View_CaptainTab_BossAttackSkillBonusView__get_Skills
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57a41 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__Skill__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SkillIconValue__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__Skill__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SkillIconValue__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SkillIconValue__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__Skill__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SkillIconValue__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SkillIconValue__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkillIconValue__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_SkillIconValue__Get__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_SkillIconValue__Release__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__Skill__GetEnumerator__
		              );
		    DAT_ram_00a57a41 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  *(undefined4 *)(param1 + 0x20) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_List_SkillIconValue__GetEnumerator__);
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_SkillIconValue__MoveNext__)
		    ;
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e1595a;
		    }
		    if (iVar1 == 0) goto code_r0x80e159b0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18,*(undefined4 *)(param1 + 0x18)
		               ,local_8._4_4_,Method_Utils_Cache_ObjectPool_SkillIconValue__Release__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar4 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e1595a:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e159b0:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x1c);
		      iVar1 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		      }
		      if (*(int *)(param1 + 0x20) == 0) {
		        return;
		      }
		      uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (*(int *)(param1 + 0x20),
		                         Method_System_Collections_Generic_Dictionary_int__Skill__get_Values__);
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_20,uVar2,
		                 Method_System_Collections_Generic_Dictionary_ValueCollection_int__Skill__GetEnumerator__
		                );
		      local_30 = 0;
		      puStack_2c = &local_20;
		      do {
		        while( true ) {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar1 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,&local_20,
		                               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__Skill__MoveNext__
		                              );
		            iVar4 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar4 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e15bda;
		            }
		            iVar4 = local_30;
		            if (iVar1 == 0) goto code_r0x80e15c23;
		            iVar4 = local_18._4_4_;
		          } while (*(longlong *)(local_18._4_4_ + 0x10) < 1);
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x200,
		                             *(undefined4 *)(param1 + 0x18),
		                             Method_Utils_Cache_ObjectPool_SkillIconValue__Get__);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e15bda;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a,uVar2,iVar4,&local_30);
		          iVar1 = DAT_ram_009d3e38;
		          iVar4 = Method_System_Collections_Generic_List_SkillIconValue__Add__;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e15bda;
		          }
		          iVar1 = *(int *)(param1 + 0x1c);
		          *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		          uVar5 = *(uint *)(iVar1 + 0xc);
		          if (*(uint *)(*(int *)(iVar1 + 8) + 0xc) <= uVar5) break;
		          *(uint *)(iVar1 + 0xc) = uVar5 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar5 * 4 + 0x10) = uVar2;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar2,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar4 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e15bda:
		      iVar4 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar4 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x80e15c23:
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
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b,&local_30);
		      goto joined_r0x80e15c70;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x19,&local_30);
		joined_r0x80e15c70:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Skills ---
		void Gameplay_Boss_View_CaptainTab_BossAttackSkillBonusView__set_Skills
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SkillIconValue___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SkillIconValue__TypeInfo);
		    DAT_ram_00a57a42 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_SkillIconValue__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_SkillIconValue___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

}
