using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.ArtifactComparer.View.SkillSelector
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000CDD")]
	public class SkillSelectorView : MonoBehaviour
	{
		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x0000EB38 File Offset: 0x0000CD38
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103C")]
		public bool IsInitialized
		{
			[Token(Token = "0x6005030")]
			[Address(RVA = "0x9E41", Offset = "0x9E41", VA = "0x9E41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005031")]
			[Address(RVA = "0x9E42", Offset = "0x9E42", VA = "0x9E42")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001E8 RID: 488
		// (add) Token: 0x06005032 RID: 20530 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005033 RID: 20531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E8")]
		public event Action<SkillSelectorItemView> SelectEvent
		{
			[Token(Token = "0x6005032")]
			[Address(RVA = "0x9E43", Offset = "0x9E43", VA = "0x9E43")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005033")]
			[Address(RVA = "0x9E44", Offset = "0x9E44", VA = "0x9E44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700103D")]
		public List<SkillSelectorItemView> AllItems
		{
			[Token(Token = "0x6005034")]
			[Address(RVA = "0x9E45", Offset = "0x9E45", VA = "0x9E45")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005035")]
		[Address(RVA = "0x9E46", Offset = "0x9E46", VA = "0x9E46")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  uint uVar8;
		  int iVar9;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_int__Dispose__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_int__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_int__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkillSelectorItemView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SkillSelectorItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView_ItemOnSelectEvent__
		              );
		    DAT_ram_00a58a24 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param2,Method_System_Collections_Generic_List_int__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		code_r0x80f60418:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x216,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_int__MoveNext__);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f60798;
		    }
		    iVar9 = local_20;
		    if (iVar2 == 0) goto code_r0x80f6082a;
		    uVar7 = *(undefined4 *)(param1 + 0x10);
		    param2_00 = *(undefined4 *)(param1 + 0x24);
		    uVar5 = local_8._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f60798;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar7,
		                       Method_UnityEngine_Object_Instantiate_SkillSelectorItemView___);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f60798;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x210,iVar2,uVar5,iVar9);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f60798;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_SkillSelectorItemView__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f60772:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f60798;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView_ItemOnSelectEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f60772;
		    if (DAT_ram_00a58a1d == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_SkillSelectorItemView__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f60772;
		      DAT_ram_00a58a1d = '\x01';
		    }
		    iVar9 = *(int *)(iVar2 + 0x1c);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar9,uVar5,0);
		      uVar7 = System_Action_SkillSelectorItemView__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f60754:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f60798;
		      }
		      if (iVar3 == 0) {
		        iVar4 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                           System_Action_SkillSelectorItemView__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f60754;
		        if (iVar4 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,uVar7);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f60798;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = func_ii_4329(iVar2 + 0x1c,iVar4,iVar9);
		      iVar3 = Method_System_Collections_Generic_List_SkillSelectorItemView__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f60754;
		      bVar1 = iVar9 != iVar4;
		      iVar9 = iVar4;
		    } while (bVar1);
		    iVar9 = *(int *)(param1 + 0x30);
		    *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar9 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		      *(uint *)(iVar9 + 0xc) = uVar8 + 1;
		      *(int *)(*(int *)(iVar9 + 8) + uVar8 * 4 + 0x10) = iVar2;
		      goto code_r0x80f60418;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,iVar2,
		               *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f60798:
		      iVar9 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar2) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar9 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x80f6082a:
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 0) {
		            uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                              (*(undefined4 *)(param1 + 0x1c),0);
		            UnityEngine_Transform__get_childCount(uVar5,0);
		            uVar5 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent
		                              (*(undefined4 *)(param1 + 0x20),0);
		            UnityEngine_Transform__get_childCount(uVar5,0);
		            *(undefined1 *)(param1 + 0x28) = 1;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x211,&local_20);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
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
		  } while( true );
		}
		*/

		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005036")]
		[Address(RVA = "0x9E47", Offset = "0x9E47", VA = "0x9E47")]
		public void Init(List<int> skillIds)
		{
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005037")]
		[Address(RVA = "0x9E48", Offset = "0x9E48", VA = "0x9E48")]
		private void ItemOnSelectEvent(SkillSelectorItemView item)
		{
		/* --- GHIDRA: ItemOnSelectEvent ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__ItemOnSelectEvent
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a25 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkillSelectorItemView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkillSelectorItemView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView_ItemOnSelectEvent__
		              );
		    DAT_ram_00a58a25 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x30),
		             Method_System_Collections_Generic_List_SkillSelectorItemView__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_SkillSelectorItemView__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f60b34:
		      iVar6 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar2) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar2 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f60be3:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = *(int *)(param1 + 0x30);
		          iVar2 = *(int *)(iVar6 + 0xc);
		          *(undefined4 *)(iVar6 + 0xc) = 0;
		          *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		          if (0 < iVar2) {
		            func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar2,0);
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x212,&local_20);
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
		    if (iVar2 == 0) goto code_r0x80f60be3;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = local_8._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_SkillSelectorItemView__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f60b2c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f60b34;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView_ItemOnSelectEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f60b2c;
		    if (DAT_ram_00a58a1e == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_SkillSelectorItemView__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f60b2c;
		      DAT_ram_00a58a1e = '\x01';
		    }
		    iVar2 = *(int *)(iVar6 + 0x1c);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar2,uVar4,0);
		      param3 = System_Action_SkillSelectorItemView__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f60b18:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f60b34;
		      }
		      if (iVar3 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_SkillSelectorItemView__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f60b18;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,param3);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f60b34;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar3 = func_ii_4329(iVar6 + 0x1c,param2_00,iVar2);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f60b18;
		      bVar1 = iVar2 != iVar3;
		      iVar2 = iVar3;
		    } while (bVar1);
		  } while( true );
		}
		*/

		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x9E49", Offset = "0x9E49", VA = "0x9E49")]
		private void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__Clear
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__ItemOnSelectEvent(param1,param1);
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x34),0);
		  return;
		}
		*/

		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x9E4A", Offset = "0x9E4A", VA = "0x9E4A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a58a26 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x34),0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScaleX(uVar1,1.0,0.2,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x34),uVar1,0);
		  uVar1 = Core_Animations_GameSpineUiAnimation__Play(*(undefined4 *)(param1 + 0x18),1.0,0.1,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar1 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar1,0.1,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_float__float__FloatOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x34),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503A")]
		[Address(RVA = "0x9E4B", Offset = "0x9E4B", VA = "0x9E4B")]
		public void Show()
		{
		/* --- GHIDRA: Show ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__Show
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView_OnCompleteHide__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a58a27 = '\x01';
		  }
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x34),0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScaleX(uVar1,0.0,0.2,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,
		             Method_Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView_OnCompleteHide__,
		             0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar1,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x34),uVar1,0);
		  uVar1 = Core_Animations_GameSpineUiAnimation__Play(*(undefined4 *)(param1 + 0x18),0.0,0.1,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x34),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503B")]
		[Address(RVA = "0x9E4C", Offset = "0x9E4C", VA = "0x9E4C")]
		public void Hide()
		{
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503C")]
		[Address(RVA = "0x9E4D", Offset = "0x9E4D", VA = "0x9E4D")]
		private void OnCompleteHide()
		{
		/* --- GHIDRA: OnCompleteHide ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__OnCompleteHide
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkillSelectorItemView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SkillSelectorItemView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a58a28 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_SkillSelectorItemView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_SkillSelectorItemView___ctor__);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(uVar1,0);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503D")]
		[Address(RVA = "0x9E4E", Offset = "0x9E4E", VA = "0x9E4E")]
		public SkillSelectorView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView___ctor
		               (int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_01;
		  float param2_00;
		  
		  if (DAT_ram_00a58a29 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo);
		    DAT_ram_00a58a29 = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    param1_00 = *(int **)(*(int *)(param1 + 0x2c) + 0x10);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo + 0xb8)
		                   * 4 + -4) != Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_00,Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowComparedSkill__HandleDataChanged
		              (param1,*(undefined4 *)(param1 + 0x34),*(undefined4 *)(param1_00[0xe] + 0x20),param1);
		    Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId
		              (*(undefined4 *)(param1 + 0x38),param1_00[5],0);
		    iVar1 = param1_00[6];
		    uVar2 = *(undefined4 *)(param1 + 0x38);
		    if (*(int *)(param1_00[0xe] + 0x28) != 0) {
		      iVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                        (iVar1,*(int *)(param1_00[0xe] + 0x28),0);
		    }
		    Utils_StringUtils__GetNumberStringWithSpaces(uVar2,iVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x44);
		    param2_00 = 1.0;
		    if (*(char *)(param1_00[0xe] + 0x24) == '\0') {
		      param2_00 = 0.5;
		    }
		    UnityEngine_CanvasGroup__get_alpha(*(undefined4 *)(param1 + 0x48),param2_00,0);
		    UnityEngine_CanvasGroup__get_alpha(uVar2,param2_00,0);
		    iVar1 = *(int *)(*(int *)(param1 + 0x2c) + 0x14);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x3c),0);
		    if (iVar1 == 0) {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,0,0);
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x40),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,0,0);
		    }
		    else {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x40),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      param1_01 = *(int **)(*(int *)(param1 + 0x2c) + 0x14);
		      if (param1_01 != (int *)0x0) {
		        if (((uint)*(byte *)(*param1_01 + 0xb8) <
		             (uint)*(byte *)(Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*param1_01 + 100) +
		                     (uint)*(byte *)(Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo +
		                                    0xb8) * 4 + -4) !=
		            Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo)) {
		          System_Activator__CreateInstance
		                    (param1_01,Gameplay_ArtifactComparer_Model_ComparerValueRow_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowComparedSkill__HandleDataChanged
		                (param1,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(param1_01[0xe] + 0x20),param1
		                );
		      Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId
		                (*(undefined4 *)(param1 + 0x40),param1_01[5],0);
		      iVar1 = param1_01[6];
		      uVar2 = *(undefined4 *)(param1 + 0x40);
		      if (*(int *)(param1_01[0xe] + 0x28) != 0) {
		        iVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                          (iVar1,*(int *)(param1_01[0xe] + 0x28),0);
		      }
		      Utils_StringUtils__GetNumberStringWithSpaces(uVar2,iVar1,0);
		    }
		    iVar1 = **(int **)(param1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x30),param1_00[3],*(undefined4 *)(iVar1 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002BBB RID: 11195
		[Token(Token = "0x4002BBB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04002BBD RID: 11197
		[Token(Token = "0x4002BBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _content;

		// Token: 0x04002BBE RID: 11198
		[Token(Token = "0x4002BBE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _spacer;

		// Token: 0x04002BBF RID: 11199
		[Token(Token = "0x4002BBF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002BC0 RID: 11200
		[Token(Token = "0x4002BC0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillSelectorItemView _itemPrefab;

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		[FieldOffset(Offset = "0x30")]
		private List<SkillSelectorItemView> _allItems;

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x34")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsInitialized ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__set_IsInitialized
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a22 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		    DAT_ram_00a58a22 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SkillSelectorItemView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SkillSelectorItemView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		    DAT_ram_00a58a23 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SkillSelectorItemView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SkillSelectorItemView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: get_AllItems ---
		void Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorView__get_AllItems
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x14),0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0x3f800000;
		  local_18 = 0x3f800000;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(param1_00,&local_18,0);
		  UnityEngine_CanvasGroup__get_alpha(*(undefined4 *)(param1 + 0x18),0.0,0);
		  return;
		}
		*/

}
