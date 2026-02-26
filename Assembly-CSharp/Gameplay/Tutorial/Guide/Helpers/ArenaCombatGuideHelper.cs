using System;
using DG.Tweening;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Helpers
{
	// Token: 0x0200048A RID: 1162
	[Token(Token = "0x200048A")]
	public class ArenaCombatGuideHelper : MonoBehaviour
	{
		// Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7A")]
		[Address(RVA = "0x6CF9", Offset = "0x6CF9", VA = "0x6CF9")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5849a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_Callback__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a5849a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar1,param1,Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_Callback__,0
		            );
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(1.0,uVar1,1,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x6CFA", Offset = "0x6CFA", VA = "0x6CFA")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper__Start(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint *param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5849b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_HandleTurnStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo);
		    DAT_ram_00a5849b = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar2 = **(int **)(param1 + 0x10);
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                               (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xe4));
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,
		             Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_HandleTurnStateChangedEvent__
		             ,0);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80ef4e41;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,
		                                   Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo,2);
		code_r0x80ef4e41:
		  (**(code **)((ulonglong)*param2_00 * 4))(param1_00,param1_01,param2_00[1]);
		  Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper__Callback(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x6CFB", Offset = "0x6CFB", VA = "0x6CFB")]
		private void Callback()
		{
		/* --- GHIDRA: Callback ---
		void Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper__Callback(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 param3;
		  int iVar8;
		  int *piVar9;
		  int local_24;
		  undefined1 *puStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5849c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_HandleTurnStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_IGuideTarget___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_CombatSpellData__CombatSpellButton__GetEnumerator__
		              );
		    DAT_ram_00a5849c = '\x01';
		  }
		  local_14 = (int *)0x0;
		  iVar8 = **(int **)(param1 + 0x10);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(iVar8 + 0xe0) * 4))
		                            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar8 + 0xe4));
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x80ef4f70;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo,4
		                               );
		code_r0x80ef4f70:
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  if (iVar8 != 3) {
		    return;
		  }
		  uVar1 = 0;
		  iVar8 = **(int **)(param1 + 0x10);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(iVar8 + 0xe0) * 4))
		                            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar8 + 0xe4));
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_HandleTurnStateChangedEvent__
		             ,0);
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd8);
		        goto code_r0x80ef502d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo,3
		                               );
		code_r0x80ef502d:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar2,uVar4,puVar3[1]);
		  uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x34),
		                     Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_24,uVar4,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_CombatSpellData__CombatSpellButton__GetEnumerator__
		            );
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_CombatSpellData__CombatSpellButton__MoveNext__
		                        );
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef53b3;
		      }
		      if (iVar5 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = local_8._4_4_;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x5f,local_8._4_4_,
		                         &local_14,Method_UnityEngine_Component_TryGetComponent_IGuideTarget___);
		      piVar2 = local_14;
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ef53b3;
		      }
		    } while (iVar6 == 0);
		    iVar8 = *local_14;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo == *piVar9) {
		          puVar7 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 0xe0);
		          goto code_r0x80ef51ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                        Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ef5379:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef53b3;
		    }
		code_r0x80ef51ae:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar7,piVar2,puVar7[1]);
		    piVar2 = local_14;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ef5379;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,long___TypeInfo,1);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef53b3;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(*(undefined4 *)(iVar5 + 0x4c),0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef53b3;
		    }
		    *(ulonglong *)(iVar6 + 0x10) = (ulonglong)uVar1;
		    iVar8 = *piVar2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo == *piVar9) {
		          puVar7 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 0xe8);
		          goto code_r0x80ef52fa;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar2,
		                        Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80ef52fa:
		    DAT_ram_009d3e38 = 0;
		    param3 = import::env::invoke_iiii(*puVar7,piVar2,iVar6,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x269,uVar4,param3,0)
		    ;
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ef53b3:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar5 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar5 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x177,&local_24);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
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

		// Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x6CFC", Offset = "0x6CFC", VA = "0x6CFC")]
		private void HandleTurnStateChangedEvent()
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x6CFD", Offset = "0x6CFD", VA = "0x6CFD")]
		public ArenaCombatGuideHelper()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5849d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GuideModel__GuideEvents__Dispose__);
		    DAT_ram_00a5849d = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_GuideModel__GuideEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private OneOnOneCombatView _combatMono;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x14")]
		private Tween _delayCall;
	}
}
