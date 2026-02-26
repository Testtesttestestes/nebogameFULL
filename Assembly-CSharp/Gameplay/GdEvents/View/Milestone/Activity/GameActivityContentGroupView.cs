using System;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay.GdEvents.View.Milestone.Activity
{
	// Token: 0x02000732 RID: 1842
	[Token(Token = "0x2000732")]
	public class GameActivityContentGroupView : AbstractContentGroupView
	{
		// Token: 0x06002BF5 RID: 11253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x7C86", Offset = "0x7C86", VA = "0x7C86")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085E")]
		public ActivityGroupData Data
		{
			[Token(Token = "0x6002BF6")]
			[Address(RVA = "0x7C87", Offset = "0x7C87", VA = "0x7C87")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BF7")]
			[Address(RVA = "0x7C88", Offset = "0x7C88", VA = "0x7C88")]
			set
			{
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x218A", Offset = "0x218A", VA = "0x218A")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x7C89", Offset = "0x7C89", VA = "0x7C89")]
		private void HandleItemClickEvent(GameActivityData activity)
		{
		/* --- GHIDRA: HandleItemClickEvent ---
		void Gameplay_GdEvents_View_Milestone_Activity_GameActivityContentGroupView__HandleItemClickEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a28f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5a28f = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x811f368b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f38ce:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f38d6;
		    }
		code_r0x811f368b:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f38ce;
		    if (iVar7 == 0) goto code_r0x811f391f;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x811f3768;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f38b0:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f38d6;
		    }
		code_r0x811f3768:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f38b0;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f38d6;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
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
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f38d6:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x811f391f:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811f39af;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x811f39af:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x282,&local_14);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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

		// Token: 0x06002BFA RID: 11258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x7C8A", Offset = "0x7C8A", VA = "0x7C8A")]
		private void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_GdEvents_View_Milestone_Activity_GameActivityContentGroupView__Clear
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a290 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_GameActivityData___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityEvent_GameActivityData__TypeInfo);
		    DAT_ram_00a5a290 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityEvent_GameActivityData__TypeInfo);
		  Sirenix_Serialization_UnityEventFormatter_object___GetUninitializedObject
		            (param1_00,Method_UnityEngine_Events_UnityEvent_GameActivityData___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x7C8B", Offset = "0x7C8B", VA = "0x7C8B")]
		public GameActivityContentGroupView()
		{
		}

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _content;

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActivityView _activityPrefab;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		public UnityEvent<GameActivityData> ItemClickEvent;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x20")]
		private ActivityGroupData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GdEvents_View_Milestone_Activity_GameActivityContentGroupView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x20)) {
		    *(int *)(param1 + 0x20) = param2;
		    func_ii_8585(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_Milestone_Activity_GameActivityContentGroupView__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a28e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_GameActivityData__Invoke__);
		    DAT_ram_00a5a28e = '\x01';
		  }
		  func_ii_16397(*(undefined4 *)(param1 + 0x1c),param2,
		                Method_UnityEngine_Events_UnityEvent_GameActivityData__Invoke__);
		  return;
		}
		*/

}
