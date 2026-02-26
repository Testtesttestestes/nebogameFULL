using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2000438")]
	public class ScaleQueue : TutorialStepsQueueBase
	{
		// Token: 0x0600197B RID: 6523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x6B1A", Offset = "0x6B1A", VA = "0x6B1A")]
		public ScaleQueue(IEnumerable<IReadOnlyList<ScaleQueue.ScaleQueueArgs>> queue)
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x17000483")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x600197C")]
			[Address(RVA = "0x6B1B", Offset = "0x6B1B", VA = "0x6B1B", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x6B1C", Offset = "0x6B1C", VA = "0x6B1C", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x6B1D", Offset = "0x6B1D", VA = "0x6B1D", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x8")]
		private readonly Queue<IReadOnlyList<ScaleQueue.ScaleQueueArgs>> _queue;

		// Token: 0x02000439 RID: 1081
		[Token(Token = "0x2000439")]
		public class ScaleQueueArgs
		{
			// Token: 0x0600197F RID: 6527 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600197F")]
			[Address(RVA = "0x6B1E", Offset = "0x6B1E", VA = "0x6B1E")]
			public ScaleQueueArgs()
			{
			}

			// Token: 0x04000D8E RID: 3470
			[Token(Token = "0x4000D8E")]
			[FieldOffset(Offset = "0x8")]
			public Transform TargetTransform;

			// Token: 0x04000D8F RID: 3471
			[Token(Token = "0x4000D8F")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 TargetScale;

			// Token: 0x04000D90 RID: 3472
			[Token(Token = "0x4000D90")]
			[FieldOffset(Offset = "0x18")]
			public float ScaleDuration;

			// Token: 0x04000D91 RID: 3473
			[Token(Token = "0x4000D91")]
			[FieldOffset(Offset = "0x1C")]
			public Ease Ease;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepActionType ---
		void Gameplay_TutorialV2_Controller_ScaleQueue__get_StepActionType
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 *param2_00;
		  uint *puVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 param3_00;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a583c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ScaleQueue_ScaleQueueArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ScaleQueue_ScaleQueueArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs___Dequeue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a583c2 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  DAT_ram_009d3e38 = 0;
		  piVar2 = (int *)import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x155,
		                             *(undefined4 *)(param1 + 8),
		                             Method_System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs___Dequeue__
		                            );
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar9 = global_1;
		    iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar9 != iVar7) goto code_r0x80edd7eb;
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar6);
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_InvalidOperationException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar6,
		                         *(undefined4 *)*puVar4);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) {
		        if (iVar7 != 0) {
		          import::env::__cxa_end_catch();
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80edd7e9;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		  }
		  else {
		    uVar1 = 0;
		    iVar9 = *piVar2;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IEnumerable_ScaleQueue_ScaleQueueArgs__TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80edd2a2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  System_Collections_Generic_IEnumerable_ScaleQueue_ScaleQueueArgs__TypeInfo
		                                  ,0);
		code_r0x80edd2a2:
		    local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    local_c = 0;
		    local_8 = &local_4;
		code_r0x80edd2d3:
		    do {
		      do {
		        piVar2 = local_4;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar4 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80edd367;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80edd6c7:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80edd6cf;
		        }
		code_r0x80edd367:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		        piVar2 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80edd6c7;
		        if (iVar9 == 0) {
		          iVar9 = 0;
		          goto code_r0x80edd718;
		        }
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_ScaleQueue_ScaleQueueArgs__TypeInfo ==
		                *piVar8) {
		              puVar4 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80edd451;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_ScaleQueue_ScaleQueueArgs__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80edd627:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80edd6cf;
		        }
		code_r0x80edd451:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80edd627;
		        uVar6 = *(undefined4 *)(iVar9 + 8);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80edd6cf;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x268,uVar6,0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80edd6cf;
		        }
		      } while (iVar5 == 0);
		      if (*(float *)(iVar9 + 0x18) <= 0.0) {
		        DAT_ram_009d3e38 = 0;
		        local_10 = *(undefined4 *)(iVar9 + 0x14);
		        local_18 = *(undefined8 *)(iVar9 + 0xc);
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x25a,
		                   *(undefined4 *)(iVar9 + 8),&local_18,0);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80edd6cf;
		        }
		        goto code_r0x80edd2d3;
		      }
		      DAT_ram_009d3e38 = 0;
		      local_20 = *(undefined4 *)(iVar9 + 0x14);
		      local_28 = *(undefined8 *)(iVar9 + 0xc);
		      uVar6 = import::env::invoke_iiifi
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x156,
		                         *(undefined4 *)(iVar9 + 8),&local_28,*(float *)(iVar9 + 0x18),0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80edd6cf;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar6,*(undefined4 *)(iVar9 + 0x1c),
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80edd6cf;
		      }
		      DAT_ram_009d3e38 = 0;
		      param3_00 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                             *(undefined4 *)(iVar9 + 8),0);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80edd6cf;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x133,uVar6,param3_00,
		                 Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                );
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar9 != 1);
		    uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80edd6cf:
		    iVar9 = global_1;
		    iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar9 == iVar7) {
		      piVar2 = (int *)import::env::__cxa_begin_catch(uVar6);
		      iVar9 = *piVar2;
		      DAT_ram_009d3e38 = 0;
		      local_c = iVar9;
		      import::env::invoke_v(0x123);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		code_r0x80edd718:
		        piVar2 = local_4;
		        DAT_ram_009d3e38 = 0;
		        if (local_4 != (int *)0x0) {
		          uVar1 = 0;
		          iVar7 = *local_4;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            do {
		              if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		                puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x80edd790;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80edd790:
		          (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		        }
		        if (iVar9 == 0) {
		          return;
		        }
		        System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar6 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x158,&local_c);
		    iVar9 = DAT_ram_009d3e38;
		  }
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		code_r0x80edd7e9:
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80edd7eb:
		  import::env::__resumeException(uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
