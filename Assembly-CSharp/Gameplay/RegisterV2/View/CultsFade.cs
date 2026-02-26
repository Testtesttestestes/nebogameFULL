using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x02000558 RID: 1368
	[Token(Token = "0x2000558")]
	public class CultsFade : MonoBehaviour
	{
		// Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x7255", Offset = "0x7255", VA = "0x7255")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_RegisterV2_View_CultsFade__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5834e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_CultsFade_HandleStateChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__add_CurrentStateChangedEvent__
		              );
		    DAT_ram_00a5834e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		                        );
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate_ByteEnum___Invoke
		            (param1_00,param1,Method_Gameplay_RegisterV2_View_CultsFade_HandleStateChangedEvent__,0)
		  ;
		  UI_MonoBehaviourWithStates_Int32Enum___HandleCurrentStateChanged
		            (param1_01,param1_00,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__add_CurrentStateChangedEvent__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x7256", Offset = "0x7256", VA = "0x7256")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_RegisterV2_View_CultsFade__Start
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_RegisterV2_View_CultsFade__HandleStateChangedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x7257", Offset = "0x7257", VA = "0x7257")]
		private void HandleStateChangedEvent(SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState fromState, SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState toState)
		{
		/* --- GHIDRA: HandleStateChangedEvent ---
		void Gameplay_RegisterV2_View_CultsFade__HandleStateChangedEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  float param3;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param3_00;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int local_18;
		  int **local_14;
		  int *local_10;
		  int local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5834f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_CultListElement___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__get_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a5834f = '\x01';
		  }
		  local_8 = (int *)0x0;
		  local_c = 0;
		  iVar7 = *(int *)(*(int *)(param1 + 0x14) + 0x18);
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x10),0);
		  local_10 = &local_c;
		  local_18 = 0;
		  local_14 = &local_4;
		  do {
		    do {
		      piVar5 = local_4;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80ed528c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ed52d0:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed55c6;
		      }
		code_r0x80ed528c:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      piVar5 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed52d0;
		      if (iVar8 == 0) goto code_r0x80ed560f;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 200);
		            goto code_r0x80ed537b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ed5466:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed55c6;
		      }
		code_r0x80ed537b:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed5466;
		      if (piVar5 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar5 + 0xb8) <
		             (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar5 + 100) +
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
		          goto code_r0x80ed55c6;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x5f,piVar5,&local_8,
		                         Method_UnityEngine_Component_TryGetComponent_CultListElement___);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed55c6;
		      }
		    } while (iVar4 == 0);
		    param3 = 1.0;
		    if (iVar7 == 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*local_8 + 0xf8),local_8,*(undefined4 *)(*local_8 + 0xfc));
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed55c6;
		      }
		      param3 = 1.0;
		      if (iVar4 == 0) {
		        param3 = 0.35;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiffi
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x135,local_8[8],param3,
		                       0.15,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed55c6;
		    }
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8[8],0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed55c6;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x133,uVar3,param3_00,
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ed55c6:
		  iVar7 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar8) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_18 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80ed560f:
		      DAT_ram_009d3e38 = 0;
		      local_c = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_10;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80ed569f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80ed569f:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_18 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_18);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14f,&local_18);
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

		// Token: 0x060020F5 RID: 8437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x7258", Offset = "0x7258", VA = "0x7258")]
		public void Validate()
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x7259", Offset = "0x7259", VA = "0x7259")]
		public CultsFade()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_CultsFade___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58350 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates___ctor__);
		    DAT_ram_00a58350 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _cultsLementsOwner;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SpellsAndCultDescriptionPanel _panel;
	}
}
