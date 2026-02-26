using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Chat.View.Smiles
{
	// Token: 0x02000AF8 RID: 2808
	[Token(Token = "0x2000AF8")]
	public class SmilesView : MonoBehaviourWithStates<SmilesViewStates>
	{
		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D5A")]
		public SmileItemView SmilePrefab
		{
			[Token(Token = "0x60043B4")]
			[Address(RVA = "0x9267", Offset = "0x9267", VA = "0x9267")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001A6 RID: 422
		// (add) Token: 0x060043B5 RID: 17333 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043B6 RID: 17334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A6")]
		public event Action<ChatSmileDic> ItemSelectedEvent
		{
			[Token(Token = "0x60043B5")]
			[Address(RVA = "0x9268", Offset = "0x9268", VA = "0x9268")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043B6")]
			[Address(RVA = "0x9269", Offset = "0x9269", VA = "0x9269")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043B8 RID: 17336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5B")]
		public RepeatedField<ChatSmileDic> Smiles
		{
			[Token(Token = "0x60043B7")]
			[Address(RVA = "0x926A", Offset = "0x926A", VA = "0x926A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043B8")]
			[Address(RVA = "0x926B", Offset = "0x926B", VA = "0x926B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B9")]
		[Address(RVA = "0x926C", Offset = "0x926C", VA = "0x926C")]
		private void OnEnable()
		{
		/* --- GHIDRA: <HandleCurrentStateChanged>b__20_0 ---
		undefined4
		Gameplay_Chat_View_Smiles_SmilesView___HandleCurrentStateChanged_b__20_0
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x10);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x2cc));
		  return uVar1;
		}
		*/

		/* --- GHIDRA: OnEnable ---
		void Gameplay_Chat_View_Smiles_SmilesView__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 param2_00;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57b00 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SmileItemView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SmileItemView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SmileItemView__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SmileItemView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_Smiles_SmilesView_ItemClickHandler__);
		    DAT_ram_00a57b00 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_List_SmileItemView__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_SmileItemView__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e2228c;
		    }
		    if (iVar2 == 0) goto code_r0x80e222e2;
		    param2_00 = *(undefined4 *)(local_8._4_4_ + 0x14);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_PointerEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Gameplay_Chat_View_Smiles_SmilesView_ItemClickHandler__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21,param2_00,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e2228c:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e222e2:
		      DAT_ram_009d3e38 = 0;
		      Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x40),0);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BA")]
		[Address(RVA = "0x926D", Offset = "0x926D", VA = "0x926D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Chat_View_Smiles_SmilesView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57b01 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ChatSmileDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SmileItemView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SmileItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_Path_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatSmileDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_Smiles_SmilesView_ItemClickHandler__);
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_TextUtilities_TypeInfo);
		    DAT_ram_00a57b01 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param1 + 0x38),
		                              Method_Google_Protobuf_Collections_RepeatedField_ChatSmileDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80e22422:
		  do {
		    do {
		      piVar6 = local_4;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar3 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80e224c8;
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
		code_r0x80e2250c:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e229ef;
		      }
		code_r0x80e224c8:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e2250c;
		      if (iVar8 == 0) goto code_r0x80e22a38;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_ChatSmileDic__TypeInfo == *piVar10) {
		            puVar3 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80e225bb;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ChatSmileDic__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e22723:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e229ef;
		      }
		code_r0x80e225bb:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e22723;
		      uVar2 = *(undefined4 *)(iVar8 + 0x18);
		      if (*(int *)(System_IO_Path_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_IO_Path_TypeInfo);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e229ef;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x28e,uVar2,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e22737:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e229ef;
		      }
		      if (*(int *)(TMPro_TMP_TextUtilities_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   TMPro_TMP_TextUtilities_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e22737;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23,uVar2,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e229ef;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x24,
		                         *(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 0x10) + 0x134),uVar2,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e229ef;
		      }
		    } while (iVar4 < 0);
		    uVar2 = *(undefined4 *)(param1 + 0x1c);
		    uVar9 = *(undefined4 *)(param1 + 0x28);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e229ef;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar9,uVar2,
		                       Method_UnityEngine_Object_Instantiate_SmileItemView___);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e229ef;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar4,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e2298c:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e229ef;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,1,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e2298c;
		    if (iVar8 != *(int *)(iVar4 + 0x18)) {
		      *(int *)(iVar4 + 0x18) = iVar8;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x25,iVar4,iVar4);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e229ef;
		      }
		    }
		    uVar9 = *(undefined4 *)(iVar4 + 0x14);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_PointerEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e229a0:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e229ef;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_Gameplay_Chat_View_Smiles_SmilesView_ItemClickHandler__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e229a0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x26,uVar9,uVar2,0);
		    iVar8 = Method_System_Collections_Generic_List_SmileItemView__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e229a0;
		    iVar5 = *(int *)(param1 + 0x3c);
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar5 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		      *(uint *)(iVar5 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar5 + 8) + uVar1 * 4 + 0x10) = iVar4;
		      goto code_r0x80e22422;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,iVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e229ef:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_c = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80e22a38:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_8;
		      if (piVar6 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *piVar6;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e22ab3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80e22ab3:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x27,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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
		*/

		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x926E", Offset = "0x926E", VA = "0x926E")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Chat_View_Smiles_SmilesView__Start(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57b02 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SmileItemView___);
		    DAT_ram_00a57b02 = '\x01';
		  }
		  iVar1 = func_ii_6601(*(undefined4 *)(param2 + 0x24),
		                       Method_UnityEngine_GameObject_GetComponent_SmileItemView___);
		  iVar2 = *(int *)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar1 + 0x18),
		             *(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x926F", Offset = "0x926F", VA = "0x926F")]
		private void ItemClickHandler(PointerEventData evtData)
		{
		/* --- GHIDRA: ItemClickHandler ---
		void Gameplay_Chat_View_Smiles_SmilesView__ItemClickHandler
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57b03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SmilesViewStates__HandleCurrentStateChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Smiles_SmilesView__HandleCurrentStateChanged_b__20_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a57b03 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ByteEnum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_SmilesViewStates__HandleCurrentStateChanged__);
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x40),0);
		  if (param3 == 0) {
		    local_18 = *(undefined8 *)(param1 + 0x2c);
		    local_4 = 0;
		    local_10 = 0;
		    local_c = local_18;
		    uVar1 = DG_Tweening_ShortcutExtensions__DOMoveZ
		                      (*(undefined4 *)(param1 + 0x20),&local_18,*(float *)(param1 + 0x24),0,0);
		    param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (param1_00,param1,
		               Method_Gameplay_Chat_View_Smiles_SmilesView__HandleCurrentStateChanged_b__20_0__,0);
		    uVar1 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                      (uVar1,param1_00,
		                       Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		  }
		  else {
		    if (param3 != 0xff) {
		      return;
		    }
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = DG_Tweening_ShortcutExtensions__DOLocalMoveX
		                      (*(undefined4 *)(param1 + 0x20),0.0,*(float *)(param1 + 0x24),0,0);
		  }
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x40),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x9270", Offset = "0x9270", VA = "0x9270", Slot = "4")]
		protected override void HandleCurrentStateChanged(SmilesViewStates fromState, SmilesViewStates toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void Gameplay_Chat_View_Smiles_SmilesView__HandleCurrentStateChanged(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b04 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SmileItemView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SmileItemView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_SmilesViewStates___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a57b04 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x24) = 0x3e4ccccd;
		  if (DAT_ram_00a65d40 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		    DAT_ram_00a65d40 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x2c) = **(undefined8 **)(UnityEngine_Vector2_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_SmileItemView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_SmileItemView___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(uVar1,0);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SmilesViewStates___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BE")]
		[Address(RVA = "0x9271", Offset = "0x9271", VA = "0x9271")]
		public SmilesView()
		{
		}

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _movingContent;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _rolleupToExpandDuration;

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SmileItemView _smilePrefab;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		private Vector2 _rolledUpPosition;

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[FieldOffset(Offset = "0x3C")]
		private List<SmileItemView> _views;

		// Token: 0x04002553 RID: 9555
		[Token(Token = "0x4002553")]
		[FieldOffset(Offset = "0x40")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SmilePrefab ---
		void Gameplay_Chat_View_Smiles_SmilesView__get_SmilePrefab
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57afe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatSmileDic__TypeInfo);
		    DAT_ram_00a57afe = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ChatSmileDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatSmileDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: add_ItemSelectedEvent ---
		void Gameplay_Chat_View_Smiles_SmilesView__add_ItemSelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57aff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatSmileDic__TypeInfo);
		    DAT_ram_00a57aff = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatSmileDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatSmileDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: set_Smiles ---
		void Gameplay_Chat_View_Smiles_SmilesView__set_Smiles(int param1,undefined4 param2)
		
		{
		  undefined8 local_10 [2];
		  
		  UnityEngine_Transform___ctor(local_10,*(undefined4 *)(param1 + 0x20),0);
		  *(undefined8 *)(param1 + 0x2c) = local_10[0];
		  return;
		}
		*/

}
